Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomD
    'Public Property Tab As New TabPage
    Private Sub RoomD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'Room4SetupSerial()
        Room4VidStop.Hide()
    End Sub

    Private Sub Room4SetupSerial()
        Room4SerialPort1.Close()
        Room4SerialPort1.PortName = "com4"
        Room4SerialPort1.BaudRate = 9600
        Room4SerialPort1.DataBits = 8
        Room4SerialPort1.Parity = Parity.None
        Room4SerialPort1.StopBits = StopBits.One
        Room4SerialPort1.Handshake = Handshake.None
        Room4SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room4SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room4Light1.Enabled = False
            Room4AppBrpBox.Enabled = False
            Room4Light2.Enabled = False
            Room4light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room4light1SW As New Stopwatch
    Dim Room4light2SW As New Stopwatch
    Dim Room4light3SW As New Stopwatch

    Private Sub Room4Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room4Light1Bri.ValueChanged
        Room4Light1Lbl.Text = String.Format("{0} %", arg0:=Room4Light1Bri.Value)
        Room4Light1Lbl.Text = Room4Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room4Light1Bri.Value = 0 Then
            Room4Light1off.Checked = True
            Room4light1SW.Stop()
            Room4UpdtLi1TimeInfo()
        Else
            Room4Light1on.Checked = True
            Room4light1SW.Reset()
            Room4light1SW.Start()
        End If
    End Sub

    Private Sub Room4Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room4Light2Bri.ValueChanged
        Room4Light2Lbl.Text = String.Format("{0} %", arg0:=Room4Light2Bri.Value)
        Room4Light2Lbl.Text = Room4Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room4Light2Bri.Value = 0 Then
            Room4Light2off.Checked = True
            Room4light2SW.Stop()
            Room4UpdtLi2TimeInfo()
        Else
            Room4Light2on.Checked = True
            Room4light2SW.Reset()
            Room4light2SW.Start()
        End If
    End Sub

    Private Sub Room4Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room4Light3Bri.ValueChanged
        Room4Light3Lbl.Text = String.Format("{0} %", arg0:=Room4Light3Bri.Value)
        Room4Light3Lbl.Text = Room4Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room4Light3Bri.Value = 0 Then
            Room4Light3off.Checked = True
            Room4light3SW.Stop()
            Room4UpdtLi3TimeInfo()
        Else
            Room4Light3on.Checked = True
            Room4light3SW.Reset()
            Room4light3SW.Start()
        End If
    End Sub

    Private Sub Room4Light1ChkStatus() Handles Room4Light1off.CheckedChanged, Room4Light1on.CheckedChanged
        If Room4Light1off.Checked = True And Room4Light1on.Checked = False Then
            Room4Light1Bri.Value = 0
        ElseIf Room4Light1off.Checked = False And Room4Light1on.Checked = True Then
            Room4Light1Bri.Value = 2
        End If
    End Sub

    Private Sub Room4Light2ChkStatus() Handles Room4Light2off.CheckedChanged, Room4Light2on.CheckedChanged
        If Room4Light2off.Checked = True And Room4Light2on.Checked = False Then
            Room4Light2Bri.Value = 0
        ElseIf Room4Light2off.Checked = False And Room4Light2on.Checked = True Then
            Room4Light2Bri.Value = 2
        End If
    End Sub

    Private Sub Room4Light3Status() Handles Room4Light3off.CheckedChanged, Room4Light3on.CheckedChanged
        If Room4Light3off.Checked = True And Room4Light3on.Checked = False Then
            Room4Light3Bri.Value = 0
        ElseIf Room4Light3off.Checked = False And Room4Light3on.Checked = True Then
            Room4Light3Bri.Value = 2
        End If
    End Sub

    Private Sub Room4UpdtLi1TimeInfo()
        Dim ts As Long = Room4light1SW.ElapsedMilliseconds
        writeDb(ts, "Room4Light1")
    End Sub

    Private Sub Room4UpdtLi2TimeInfo()
        Dim ts As Long = Room4light2SW.ElapsedMilliseconds
        writeDb(ts, "Room4Light2")
    End Sub

    Private Sub Room4UpdtLi3TimeInfo()
        Dim ts As Long = Room4light3SW.ElapsedMilliseconds
        writeDb(ts, "Room4Light2")
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room4TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room4TempIncBtn.Click
        Room4ClimateBtnClick(1)
    End Sub

    Private Sub Room4TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room4TempDecBtn.Click
        Room4ClimateBtnClick(0)
    End Sub


    Private Sub Room4ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room4TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room4TempLbl.Text = n.ToString
        Room4TempLbl2.Text = n.ToString

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


    Private Sub Room4TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room4TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room4TempLbl.Text)
        m = 50
        Room4TempLbl.Text = m.ToString
        Room4TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room4UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room4DataReceived() Handles Room4SerialPort1.DataReceived
        Dim reading As String = Room4SerialPort1.ReadLine
        Room4UpdateLabel(reading)
    End Sub

    Private Sub Room4UpdateLabel(ByVal text As String)
        If Me.Room4dhtTemp.InvokeRequired Then
            Dim d As New Room4UpdateLabelDelegate(AddressOf Room4UpdateLabel)
            Me.Room4dhtTemp.Invoke(d, New Object() {text})
        Else
            Room4dhtTemp.Text = text
        End If
    End Sub
	'code for Climate settings end here

	'code for camera starts here
	Public Property Vidstat As Boolean
	Dim Room4CameraCapture As VideoCapture
    Dim Room4ImageFrame As Mat
    Dim Room4FaceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")


    Private Sub Room4VidStart_Click(sender As Object, e As EventArgs) Handles Room4VidStart.Click
		Room4StartCam()
		Vidstat = True
	End Sub

    Private Sub Room4StartCam()
        Room4CameraCapture = New VideoCapture()
        If Not Room4CameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            Room4VidStart.Hide()
            Room4VidStop.Show()
        End If
        AddHandler Application.Idle, AddressOf Room4ProcessCapture ' call the function when the event is raised.
    End Sub

    Private Sub Room4ProcessCapture(sender As System.Object, e As System.EventArgs)
        Room4ImageFrame = Room4CameraCapture.QuerySmallFrame

        If Room4ImageFrame IsNot Nothing Then
            For Each face As Rectangle In Room4FaceDetector.DetectMultiScale(
                         Room4ImageFrame, 'the frame where it is suposed to detect
                         1.1,        'the relative size of scanning window for the next pass
                         10,      ' minimum neighbours to group as a single detected frame
                         New Size(20, 20), ' size of the window
                         Size.Empty)      'maximum size of the window
                CvInvoke.Rectangle(Room4ImageFrame, face, New MCvScalar(255, 255, 255)) ' DRAW a rectangle around the detected area
            Next
        End If

        ImageBox.Image = Room4ImageFrame
    End Sub

    Private Sub Room4VidStop_Click(sender As Object, e As EventArgs) Handles Room4VidStop.Click
        Room4VidStop.Hide()
        Room4VidStart.Show()
		Room4CameraCapture.Dispose()
		Vidstat = False
	End Sub
    'code for Camera ends here

    ' Appliances
    Dim tvTimer As New Stopwatch
	' for on/off. on = true off = false
	Public Property Room4Pw1Status As Boolean
	Public Property Room4Pw2Status As Boolean
	Public Property Room4Pw3Status As Boolean
	Public Property tvStatus As Boolean

	Private Sub Room4Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room4Pw1Btn.Click
        If Room4Pw1Status = True Then
            Room4Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room4Pw1Status = False
        ElseIf Room4Pw1Status = False Then
            Room4Pw1Btn.BackgroundImage = My.Resources.poweron
            Room4Pw1Status = True
        End If
    End Sub

    Private Sub Room4Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room4Pw2Btn.Click
        If Room4Pw2Status = True Then
            Room4Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room4Pw2Status = False
        ElseIf Room4Pw2Status = False Then
            Room4Pw2Btn.BackgroundImage = My.Resources.poweron
            Room4Pw2Status = True
        End If
    End Sub

    Private Sub Room4Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room4Pw3Btn.Click
        If Room4Pw3Status = True Then
            Room4Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room4Pw3Status = False
        ElseIf Room4Pw3Status = False Then
            Room4Pw3Btn.BackgroundImage = My.Resources.poweron
            Room4Pw3Status = True
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

    Private Sub UpdateTvTime()
        Dim ts As Long = tvTimer.ElapsedMilliseconds
    End Sub

    Private Sub Room4Back_Click(sender As Object, e As EventArgs) Handles Room4Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

	Private Sub Room4ToDashboard_Click(sender As Object, e As EventArgs) Handles Room4ToDashboard.Click
		Dashboard.Show()
		Me.Hide()
	End Sub
End Class

