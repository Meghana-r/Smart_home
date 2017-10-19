Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomC
    'Public Property Tab As New TabPage
    Private Sub RoomC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        Room3SetupSerial()
        Room3VidStop.Hide()
    End Sub

    Private Sub Room3SetupSerial()
        Room3SerialPort1.Close()
        Room3SerialPort1.PortName = Room3SerialPortName
        Room3SerialPort1.BaudRate = 9600
        Room3SerialPort1.DataBits = 8
        Room3SerialPort1.Parity = Parity.None
        Room3SerialPort1.StopBits = StopBits.One
        Room3SerialPort1.Handshake = Handshake.None
        Room3SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room3SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room3Light1.Enabled = False
            Room3AppBrpBox.Enabled = False
            Room3Light2.Enabled = False
            Room3light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room3light1SW As New Stopwatch
    Dim Room3light2SW As New Stopwatch
    Dim Room3light3SW As New Stopwatch

    Private Sub Room3Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room3Light1Bri.ValueChanged
        Room3Light1Lbl.Text = String.Format("{0} %", arg0:=Room3Light1Bri.Value)
        Room3Light1Lbl.Text = Room3Light1Bri.Value.ToString
        If Room3SerialPort1.IsOpen = True Then
            Room3SerialPort1.Write(Room3Light1Bri.Value)
        End If
        If Room3Light1Bri.Value = Room3Light1Bri.Minimum Then
            Room3Light1off.Checked = True
            Room3light1SW.Stop()
            Room3UpdtLi1TimeInfo()
        Else
            Room3Light1on.Checked = True
            Room3light1SW.Reset()
            Room3light1SW.Start()
        End If
    End Sub

    Private Sub Room3Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room3Light2Bri.ValueChanged
        Room3Light2Lbl.Text = String.Format("{0} %", arg0:=Room3Light2Bri.Value)
        Room3Light2Lbl.Text = Room3Light2Bri.Value.ToString - 4
        If Room3SerialPort1.IsOpen = True Then
            Room3SerialPort1.Write(Room3Light2Bri.Value)
        End If
        If Room3Light2Bri.Value = Room3Light2Bri.Minimum Then
            Room3Light2off.Checked = True
            Room3light2SW.Stop()
            Room3UpdtLi2TimeInfo()
        Else
            Room3Light2on.Checked = True
            Room3light2SW.Reset()
            Room3light2SW.Start()
        End If
    End Sub

    Private Sub Room3Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room3Light3Bri.ValueChanged
        Room3Light3Lbl.Text = String.Format("{0} %", arg0:=Room3Light3Bri.Value)
        Room3Light3Lbl.Text = Room3Light3Bri.Value.ToString - 8
        If Room3SerialPort1.IsOpen = True Then
            Room3SerialPort1.Write(Room3Light3Bri.Value)
        End If
        If Room3Light3Bri.Value = Room3Light3Bri.Minimum Then
            Room3Light3off.Checked = True
            Room3light3SW.Stop()
            Room3UpdtLi3TimeInfo()
        Else
            Room3Light3on.Checked = True
            Room3light3SW.Reset()
            Room3light3SW.Start()
        End If
    End Sub

    Private Sub Room3Light1ChkStatus() Handles Room3Light1off.CheckedChanged, Room3Light1on.CheckedChanged
        If Room3Light1off.Checked = True And Room3Light1on.Checked = False Then
            Room3Light1Bri.Value = Room3Light1Bri.Minimum
        ElseIf Room3Light1off.Checked = False And Room3Light1on.Checked = True Then
            Room3Light1Bri.Value = Room3Light1Bri.Maximum
        End If
    End Sub

    Private Sub Room3Light2ChkStatus() Handles Room3Light2off.CheckedChanged, Room3Light2on.CheckedChanged
        If Room3Light2off.Checked = True And Room3Light2on.Checked = False Then
            Room3Light2Bri.Value = Room3Light2Bri.Minimum
        ElseIf Room3Light2off.Checked = False And Room3Light2on.Checked = True Then
            Room3Light2Bri.Value = Room3Light2Bri.Maximum
        End If
    End Sub

    Private Sub Room3Light3Status() Handles Room3Light3off.CheckedChanged, Room3Light3on.CheckedChanged
        If Room3Light3off.Checked = True And Room3Light3on.Checked = False Then
            Room3Light3Bri.Value = Room3Light3Bri.Minimum
        ElseIf Room3Light3off.Checked = False And Room3Light3on.Checked = True Then
            Room3Light3Bri.Value = Room3Light3Bri.Maximum
        End If
    End Sub

    Private Sub Room3UpdtLi1TimeInfo()
        Dim ts As Long = Room3light1SW.ElapsedMilliseconds
        writeDb(ts, "Room3Light1")
    End Sub

    Private Sub Room3UpdtLi2TimeInfo()
        Dim ts As Long = Room3light2SW.ElapsedMilliseconds
        writeDb(ts, "Room3Light1")
    End Sub

    Private Sub Room3UpdtLi3TimeInfo()
        Dim ts As Long = Room3light3SW.ElapsedMilliseconds
        writeDb(ts, "Room3Light1")
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room3TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room3TempIncBtn.Click
        Room3ClimateBtnClick(1)
    End Sub

    Private Sub Room3TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room3TempDecBtn.Click
        Room3ClimateBtnClick(0)
    End Sub


    Private Sub Room3ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room3TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room3TempLbl.Text = n.ToString
        Room3TempLbl2.Text = n.ToString

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


    Private Sub Room3TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room3TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room3TempLbl.Text)
        m = 50
        Room3TempLbl.Text = m.ToString
        Room3TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room3UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room3DataReceived() Handles Room3SerialPort1.DataReceived
        Dim reading As String = Room3SerialPort1.ReadLine
        Room3UpdateLabel(reading)
    End Sub

    Private Sub Room3UpdateLabel(ByVal text As String)
        If Me.Room3dhtTemp.InvokeRequired Then
            Dim d As New Room3UpdateLabelDelegate(AddressOf Room3UpdateLabel)
            Me.Room3dhtTemp.Invoke(d, New Object() {text})
        Else
            Room3dhtTemp.Text = text
        End If
    End Sub
	'code for Climate settings end here

	'code for camera starts here
	Public Property Vidstat As Boolean
	Dim Room3CameraCapture As VideoCapture
    Dim Room3ImageFrame As Mat
    Dim Room3FaceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")


    Private Sub Room3VidStart_Click(sender As Object, e As EventArgs) Handles Room3VidStart.Click
		Room3StartCam()
		Vidstat = True
	End Sub

    Private Sub Room3StartCam()
        Room3CameraCapture = New VideoCapture()
        If Not Room3CameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            Room3VidStart.Hide()
            Room3VidStop.Show()
        End If
        AddHandler Application.Idle, AddressOf Room3ProcessCapture ' call the function when the event is raised.
    End Sub

    Private Sub Room3ProcessCapture(sender As System.Object, e As System.EventArgs)
        Room3ImageFrame = Room3CameraCapture.QuerySmallFrame

        If Room3ImageFrame IsNot Nothing Then
            For Each face As Rectangle In Room3FaceDetector.DetectMultiScale(
                         Room3ImageFrame, 'the frame where it is suposed to detect
                         1.1,        'the relative size of scanning window for the next pass
                         10,      ' minimum neighbours to group as a single detected frame
                         New Size(20, 20), ' size of the window
                         Size.Empty)      'maximum size of the window
                CvInvoke.Rectangle(Room3ImageFrame, face, New MCvScalar(255, 255, 255)) ' DRAW a rectangle around the detected area
            Next
        End If

        ImageBox.Image = Room3ImageFrame
    End Sub

    Private Sub Room3VidStop_Click(sender As Object, e As EventArgs) Handles Room3VidStop.Click
        Room3VidStop.Hide()
        Room3VidStart.Show()
		Room3CameraCapture.Dispose()
		Vidstat = False
	End Sub
    'code for Camera ends here

    ' Appliances
    Dim tvTimer As New Stopwatch

	' for on/off. on = true off = false
	Public Property Room3Pw1Status As Boolean
	Public Property Room3Pw2Status As Boolean
	Public Property Room3Pw3Status As Boolean
	Public Property tvStatus As Boolean

	Private Sub Room3Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room3Pw1Btn.Click
        If Room3Pw1Status = True Then
            Room3Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room3Pw1Status = False
        ElseIf Room3Pw1Status = False Then
            Room3Pw1Btn.BackgroundImage = My.Resources.poweron
            Room3Pw1Status = True
        End If
    End Sub

    Private Sub Room3Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room3Pw2Btn.Click
        If Room3Pw2Status = True Then
            Room3Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room3Pw2Status = False
        ElseIf Room3Pw2Status = False Then
            Room3Pw2Btn.BackgroundImage = My.Resources.poweron
            Room3Pw2Status = True
        End If
    End Sub

    Private Sub Room3Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room3Pw3Btn.Click
        If Room3Pw3Status = True Then
            Room3Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room3Pw3Status = False
        ElseIf Room3Pw3Status = False Then
            Room3Pw3Btn.BackgroundImage = My.Resources.poweron
            Room3Pw3Status = True
        End If
    End Sub

    Private Sub tvBtn_Click(sender As Object, e As EventArgs) Handles tvBtn.Click
        If tvStatus = True Then
            tvBtn.BackgroundImage = My.Resources.tvoff
            tvTimer.Stop()
            UpdateTvTime()
            If Room3SerialPort1.IsOpen = True Then
                Room3SerialPort1.Write(13)
            End If
            tvStatus = False
        ElseIf tvStatus = False Then
            tvBtn.BackgroundImage = My.Resources.tvon
            tvTimer.Reset()
            tvTimer.Start()
            If Room3SerialPort1.IsOpen = True Then
                Room3SerialPort1.Write(12)
            End If
            tvStatus = True
        End If
    End Sub

    Private Sub UpdateTvTime()
        Dim ts As Long = tvTimer.ElapsedMilliseconds
        writeDb(ts, "Room3Pw1")
    End Sub

    Private Sub Room3Back_Click(sender As Object, e As EventArgs) Handles Room3Back.Click
        Form1.Show()
        Room3SerialPort1.Close()
        If Not Room3CameraCapture Is Nothing Then
            Room3CameraCapture.Dispose()
        End If
        Me.Hide()
    End Sub

    Private Sub Room3ToDashboard_Click(sender As Object, e As EventArgs) Handles Room3ToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class

