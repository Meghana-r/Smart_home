Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomB
    'Public Property Tab As New TabPage
    Private Sub RoomB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'Room2SetupSerial()
        Room2VidStop.Hide()
    End Sub

    Private Sub Room2SetupSerial()
        Room2SerialPort1.Close()
        Room2SerialPort1.PortName = "com4"
        Room2SerialPort1.BaudRate = 9600
        Room2SerialPort1.DataBits = 8
        Room2SerialPort1.Parity = Parity.None
        Room2SerialPort1.StopBits = StopBits.One
        Room2SerialPort1.Handshake = Handshake.None
        Room2SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room2SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room2Light1.Enabled = False
            Room2AppBrpBox.Enabled = False
            Room2Light2.Enabled = False
            Room2light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room2light1SW As New Stopwatch
    Dim Room2light2SW As New Stopwatch
    Dim Room2light3SW As New Stopwatch

    Private Sub Room2Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room2Light1Bri.ValueChanged
        Room2Light1Lbl.Text = String.Format("{0} %", arg0:=Room2Light1Bri.Value)
        Room2Light1Lbl.Text = Room2Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room2Light1Bri.Value = 0 Then
            Room2Light1off.Checked = True
            Room2light1SW.Stop()
            Room2UpdtLi1TimeInfo()
        Else
            Room2Light1on.Checked = True
            Room2light1SW.Reset()
            Room2light1SW.Start()
        End If
    End Sub

    Private Sub Room2Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room2Light2Bri.ValueChanged
        Room2Light2Lbl.Text = String.Format("{0} %", arg0:=Room2Light2Bri.Value)
        Room2Light2Lbl.Text = Room2Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room2Light2Bri.Value = 0 Then
            Room2Light2off.Checked = True
            Room2light2SW.Stop()
            Room2UpdtLi2TimeInfo()
        Else
            Room2Light2on.Checked = True
            Room2light2SW.Reset()
            Room2light2SW.Start()
        End If
    End Sub

    Private Sub Room2Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room2Light3Bri.ValueChanged
        Room2Light3Lbl.Text = String.Format("{0} %", arg0:=Room2Light3Bri.Value)
        Room2Light3Lbl.Text = Room2Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room2Light3Bri.Value = 0 Then
            Room2Light3off.Checked = True
            Room2light3SW.Stop()
            Room2UpdtLi3TimeInfo()
        Else
            Room2Light3on.Checked = True
            Room2light3SW.Reset()
            Room2light3SW.Start()
        End If
    End Sub

    Private Sub Room2Light1ChkStatus() Handles Room2Light1off.CheckedChanged, Room2Light1on.CheckedChanged
        If Room2Light1off.Checked = True And Room2Light1on.Checked = False Then
            Room2Light1Bri.Value = 0
        ElseIf Room2Light1off.Checked = False And Room2Light1on.Checked = True Then
            Room2Light1Bri.Value = 2
        End If
    End Sub

    Private Sub Room2Light2ChkStatus() Handles Room2Light2off.CheckedChanged, Room2Light2on.CheckedChanged
        If Room2Light2off.Checked = True And Room2Light2on.Checked = False Then
            Room2Light2Bri.Value = 0
        ElseIf Room2Light2off.Checked = False And Room2Light2on.Checked = True Then
            Room2Light2Bri.Value = 2
        End If
    End Sub

    Private Sub Room2Light3Status() Handles Room2Light3off.CheckedChanged, Room2Light3on.CheckedChanged
        If Room2Light3off.Checked = True And Room2Light3on.Checked = False Then
            Room2Light3Bri.Value = 0
        ElseIf Room2Light3off.Checked = False And Room2Light3on.Checked = True Then
            Room2Light3Bri.Value = 2
        End If
    End Sub

    Private Sub Room2UpdtLi1TimeInfo()
        Dim ts As Long = Room2light1SW.ElapsedMilliseconds
        writeDb(ts, "Room2Light1")
    End Sub

    Private Sub Room2UpdtLi2TimeInfo()
        Dim ts As Long = Room2light2SW.ElapsedMilliseconds
        writeDb(ts, "Room2Light2")
    End Sub

    Private Sub Room2UpdtLi3TimeInfo()
        Dim ts As Long = Room2light3SW.ElapsedMilliseconds
        writeDb(ts, "Room2Light3")
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room2TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room2TempIncBtn.Click
        Room2ClimateBtnClick(1)
    End Sub

    Private Sub Room2TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room2TempDecBtn.Click
        Room2ClimateBtnClick(0)
    End Sub


    Private Sub Room2ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room2TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room2TempLbl.Text = n.ToString
        Room2TempLbl2.Text = n.ToString

        If (n >= 50) Then
            sunimage.Show()
            coldimage.Hide()
            mediumhot.Hide()
        ElseIf (n <= 20) Then
            coldimage.Show()
            sunimage.Hide()
            mediumhot.Hide()
        Else
            mediumhot.Show()
            sunimage.Hide()
            coldimage.Hide()
        End If
    End Sub


    Private Sub Room2TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room2TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room2TempLbl.Text)
        m = 50
        Room2TempLbl.Text = m.ToString
        Room2TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room2UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room2DataReceived() Handles Room2SerialPort1.DataReceived
        Dim reading As String = Room2SerialPort1.ReadLine
        Room2UpdateLabel(reading)
    End Sub

    Private Sub Room2UpdateLabel(ByVal text As String)
        If Me.Room2dhtTemp.InvokeRequired Then
            Dim d As New Room2UpdateLabelDelegate(AddressOf Room2UpdateLabel)
            Me.Room2dhtTemp.Invoke(d, New Object() {text})
        Else
            Room2dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here

    'code for camera starts here
    Dim Room2CameraCapture As VideoCapture
    Dim Room2ImageFrame As Mat
    Dim Room2FaceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")


    Private Sub Room2VidStart_Click(sender As Object, e As EventArgs) Handles Room2VidStart.Click
        Room2StartCam()
    End Sub

    Private Sub Room2StartCam()
        Room2CameraCapture = New VideoCapture()
        If Not Room2CameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            Room2VidStart.Hide()
            Room2VidStop.Show()
        End If
        AddHandler Application.Idle, AddressOf Room2ProcessCapture ' call the function when the event is raised.
    End Sub

    Private Sub Room2ProcessCapture(sender As System.Object, e As System.EventArgs)
        Room2ImageFrame = Room2CameraCapture.QuerySmallFrame

        If Room2ImageFrame IsNot Nothing Then
            For Each face As Rectangle In Room2FaceDetector.DetectMultiScale(
                         Room2ImageFrame, 'the frame where it is suposed to detect
                         1.1,        'the relative size of scanning window for the next pass
                         10,      ' minimum neighbours to group as a single detected frame
                         New Size(20, 20), ' size of the window
                         Size.Empty)      'maximum size of the window
                CvInvoke.Rectangle(Room2ImageFrame, face, New MCvScalar(255, 255, 255)) ' DRAW a rectangle around the detected area
            Next
        End If

        ImageBox.Image = Room2ImageFrame
    End Sub

    Private Sub Room2VidStop_Click(sender As Object, e As EventArgs) Handles Room2VidStop.Click
        Room2VidStop.Hide()
        Room2VidStart.Show()
        Room2CameraCapture.Dispose()
    End Sub
    'code for Camera ends here

    ' Appliances
    Dim tvTimer As New Stopwatch
    Dim Room2Pw1Timer As New Stopwatch
    Dim Room2Pw2Timer As New Stopwatch
    Dim Room2Pw3Timer As New Stopwatch

    ' for on/off. on = true off = false
    Dim Room2Pw1Status As Boolean
    Dim Room2Pw2Status As Boolean
    Dim Room2Pw3Status As Boolean
    Dim tvStatus As Boolean

    Private Sub Room2Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room2Pw1Btn.Click
        If Room2Pw1Status = True Then
            Room2Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room2Pw1Timer.Stop()
            UpdateRoom2Pw1Time()
            Room2Pw1Status = False
        ElseIf Room2Pw1Status = False Then
            Room2Pw1Btn.BackgroundImage = My.Resources.poweron
            Room2Pw1Timer.Reset()
            Room2Pw1Timer.Start()
            Room2Pw1Status = True
        End If
    End Sub

    Private Sub Room2Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room2Pw2Btn.Click
        If Room2Pw2Status = True Then
            Room2Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room2Pw2Timer.Stop()
            UpdateRoom2Pw2Time()
            Room2Pw2Status = False
        ElseIf Room2Pw2Status = False Then
            Room2Pw2Btn.BackgroundImage = My.Resources.poweron
            Room2Pw2Timer.Reset()
            Room2Pw2Timer.Start()
            Room2Pw2Status = True
        End If
    End Sub

    Private Sub Room2Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room2Pw3Btn.Click
        If Room2Pw3Status = True Then
            Room2Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room2Pw3Timer.Stop()
            UpdateRoom2Pw3Time()
            Room2Pw3Status = False
        ElseIf Room2Pw3Status = False Then
            Room2Pw3Btn.BackgroundImage = My.Resources.poweron
            Room2Pw3Timer.Reset()
            Room2Pw3Timer.Start()
            Room2Pw3Status = True
        End If
    End Sub

    Private Sub tvBtn_Click(sender As Object, e As EventArgs) Handles tvBtn.Click
        If tvStatus = True Then
            tvBtn.BackgroundImage = My.Resources.tvoff
            tvTimer.Stop()
            UpdateTvTime()
            tvStatus = False
        ElseIf tvStatus = False Then
            tvBtn.BackgroundImage = My.Resources.tvon
            tvTimer.Reset()
            tvTimer.Start()
            tvStatus = True
        End If
    End Sub

    Private Sub UpdateRoom2Pw1Time()
        Dim ts As Long = Room2Pw1Timer.ElapsedMilliseconds
        'Room2Pw1Lbl.Text = ts.ToString
    End Sub

    Private Sub UpdateRoom2Pw2Time()
        Dim ts As Long = Room2Pw1Timer.ElapsedMilliseconds
        'Room2Pw1Lbl.Text = ts.ToString
    End Sub

    Private Sub UpdateRoom2Pw3Time()
        Dim ts As Long = Room2Pw1Timer.ElapsedMilliseconds
        'Room2Pw1Lbl.Text = ts.ToString
    End Sub

    Private Sub UpdateTvTime()
        Dim ts As Long = Room2Pw1Timer.ElapsedMilliseconds
        'Room2Pw1Lbl.Text = ts.ToString
    End Sub

    Private Sub Room2Back_Click(sender As Object, e As EventArgs) Handles Room2Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Room2ToDashboard_Click(sender As Object, e As EventArgs) Handles Room2ToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class

