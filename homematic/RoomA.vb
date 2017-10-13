Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomA
	'Public Property Tab As New TabPage
	Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'Room1SetupSerial()
        Room1VidStop.Hide()
    End Sub

    Private Sub Room1SetupSerial()
        Room1SerialPort1.Close()
        Room1SerialPort1.PortName = "com4"
        Room1SerialPort1.BaudRate = 9600
        Room1SerialPort1.DataBits = 8
        Room1SerialPort1.Parity = Parity.None
        Room1SerialPort1.StopBits = StopBits.One
        Room1SerialPort1.Handshake = Handshake.None
        Room1SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room1SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room1Light1.Enabled = False
            Room1AppBrpBox.Enabled = False
            Room2Light2.Enabled = False
            Room1light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room1light1SW As New Stopwatch
    Dim Room1light2SW As New Stopwatch
    Dim Room1light3SW As New Stopwatch

    Private Sub Room1Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room1Light1Bri.ValueChanged
        Room1Light1Lbl.Text = String.Format("{0} %", arg0:=Room1Light1Bri.Value)
        Room1Light1Lbl.Text = Room1Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room1Light1Bri.Value = 0 Then
            Room1Light1off.Checked = True
            Room1light1SW.Stop()
            Room1UpdtLi1TimeInfo()
        Else
            Room1Light1on.Checked = True
            Room1light1SW.Reset()
            Room1light1SW.Start()
        End If
    End Sub

    Private Sub Room1Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room1Light2Bri.ValueChanged
        Room1Light2Lbl.Text = String.Format("{0} %", arg0:=Room1Light2Bri.Value)
        Room1Light2Lbl.Text = Room1Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room1Light2Bri.Value = 0 Then
            Room1Light2off.Checked = True
            Room1light2SW.Stop()
            Room1UpdtLi2TimeInfo()
        Else
            Room1Light2on.Checked = True
            Room1light2SW.Reset()
            Room1light2SW.Start()
        End If
    End Sub

    Private Sub Room1Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room1Light3Bri.ValueChanged
        Room1Light3Lbl.Text = String.Format("{0} %", arg0:=Room1Light3Bri.Value)
        Room1Light3Lbl.Text = Room1Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room1Light3Bri.Value = 0 Then
            Room1Light3off.Checked = True
            Room1light3SW.Stop()
            Room1UpdtLi3TimeInfo()
        Else
            Room1Light3on.Checked = True
            Room1light3SW.Reset()
            Room1light3SW.Start()
        End If
    End Sub

    Private Sub Room1Light1ChkStatus() Handles Room1Light1off.CheckedChanged, Room1Light1on.CheckedChanged
        If Room1Light1off.Checked = True And Room1Light1on.Checked = False Then
            Room1Light1Bri.Value = 0
        ElseIf Room1Light1off.Checked = False And Room1Light1on.Checked = True Then
            Room1Light1Bri.Value = 2
        End If
    End Sub

    Private Sub Room1Light2ChkStatus() Handles Room1Light2off.CheckedChanged, Room1Light2on.CheckedChanged
        If Room1Light2off.Checked = True And Room1Light2on.Checked = False Then
            Room1Light2Bri.Value = 0
        ElseIf Room1Light2off.Checked = False And Room1Light2on.Checked = True Then
            Room1Light2Bri.Value = 2
        End If
    End Sub

    Private Sub Room1Light3Status() Handles Room1Light3off.CheckedChanged, Room1Light3on.CheckedChanged
        If Room1Light3off.Checked = True And Room1Light3on.Checked = False Then
            Room1Light3Bri.Value = 0
        ElseIf Room1Light3off.Checked = False And Room1Light3on.Checked = True Then
            Room1Light3Bri.Value = 2
        End If
    End Sub

    Private Sub Room1UpdtLi1TimeInfo()
        Dim ts As TimeSpan = Room1light1SW.Elapsed
        Room1Light1TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub Room1UpdtLi2TimeInfo()
        Dim ts As TimeSpan = Room1light2SW.Elapsed
        Room1Light2TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub Room1UpdtLi3TimeInfo()
        Dim ts As TimeSpan = Room1light3SW.Elapsed
        Room1Light3TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room1TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room1TempIncBtn.Click
        Room1ClimateBtnClick(1)
    End Sub

    Private Sub Room1TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room1TempDecBtn.Click
        Room1ClimateBtnClick(0)
    End Sub


    Private Sub Room1ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room1TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room1TempLbl.Text = n.ToString
        Room1TempLbl2.Text = n.ToString

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


    Private Sub Room1TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room1TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room1TempLbl.Text)
        m = 50
        Room1TempLbl.Text = m.ToString
        Room1TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room1UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room1DataReceived() Handles Room1SerialPort1.DataReceived
        Dim reading As String = Room1SerialPort1.ReadLine
        Room1UpdateLabel(reading)
    End Sub

    Private Sub Room1UpdateLabel(ByVal text As String)
        If Me.Room1dhtTemp.InvokeRequired Then
            Dim d As New Room1UpdateLabelDelegate(AddressOf Room1UpdateLabel)
            Me.Room1dhtTemp.Invoke(d, New Object() {text})
        Else
            Room1dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here

    'code for camera starts here
    Dim Room1CameraCapture As VideoCapture
    Dim Room1ImageFrame As Mat
    Dim Room1FaceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")
	Public Property VidStat As Boolean

	Public Sub Room1VidStart_Click(sender As Object, e As EventArgs) Handles Room1VidStart.Click
		Room1StartCam()
		VidStat = True
	End Sub

	Private Sub Room1StartCam()
        Room1CameraCapture = New VideoCapture()
        If Not Room1CameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            Room1VidStart.Hide()
            Room1VidStop.Show()
        End If
        AddHandler Application.Idle, AddressOf Room1ProcessCapture ' call the function when the event is raised.
    End Sub

    Private Sub Room1ProcessCapture(sender As System.Object, e As System.EventArgs)
        Room1ImageFrame = Room1CameraCapture.QuerySmallFrame

        If Room1ImageFrame IsNot Nothing Then
            For Each face As Rectangle In Room1FaceDetector.DetectMultiScale(
                         Room1ImageFrame, 'the frame where it is suposed to detect
                         1.1,        'the relative size of scanning window for the next pass
                         10,      ' minimum neighbours to group as a single detected frame
                         New Size(20, 20), ' size of the window
                         Size.Empty)      'maximum size of the window
                CvInvoke.Rectangle(Room1ImageFrame, face, New MCvScalar(255, 255, 255)) ' DRAW a rectangle around the detected area
            Next
        End If

        ImageBox.Image = Room1ImageFrame
    End Sub

	Public Sub Room1VidStop_Click(sender As Object, e As EventArgs) Handles Room1VidStop.Click
		Room1VidStop.Hide()
		Room1VidStart.Show()
		Room1CameraCapture.Dispose()
		VidStat = False
	End Sub
	'code for Camera ends here

	' Appliances
	Dim tvTimer As New Stopwatch
    Dim Room1Pw1Timer As New Stopwatch
    Dim Room1Pw2Timer As New Stopwatch
    Dim Room1Pw3Timer As New Stopwatch

	' for on/off. on = true off = false
	Public Property Room1Pw1Status As Boolean
	Public Property Room1Pw2Status As Boolean
	Public Property Room1Pw3Status As Boolean
	Public Property tvStatus As Boolean

	Private Sub Room1Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw1Btn.Click
        If Room1Pw1Status = True Then
            Room1Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw1Timer.Stop()
            UpdateRoom1Pw1Time()
            Room1Pw1Status = False
        ElseIf Room1Pw1Status = False Then
            Room1Pw1Btn.BackgroundImage = My.Resources.poweron
            Room1Pw1Timer.Reset()
            Room1Pw1Timer.Start()
            Room1Pw1Status = True
        End If
    End Sub

    Private Sub Room1Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw2Btn.Click
        If Room1Pw2Status = True Then
            Room1Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw2Timer.Stop()
            UpdateRoom1Pw2Time()
            Room1Pw2Status = False
        ElseIf Room1Pw2Status = False Then
            Room1Pw2Btn.BackgroundImage = My.Resources.poweron
            Room1Pw2Timer.Reset()
            Room1Pw2Timer.Start()
            Room1Pw2Status = True
        End If
    End Sub

    Private Sub Room1Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw3Btn.Click
        If Room1Pw3Status = True Then
            Room1Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw3Timer.Stop()
            UpdateRoom1Pw3Time()
            Room1Pw3Status = False
        ElseIf Room1Pw3Status = False Then
            Room1Pw3Btn.BackgroundImage = My.Resources.poweron
            Room1Pw3Timer.Reset()
            Room1Pw3Timer.Start()
            Room1Pw3Status = True
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

    Private Sub UpdateRoom1Pw1Time()
        Dim ts As TimeSpan = Room1Pw1Timer.Elapsed
        Room1Pw1Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateRoom1Pw2Time()
        Dim ts As TimeSpan = Room1Pw2Timer.Elapsed
        Room1Pw2Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateRoom1Pw3Time()
        Dim ts As TimeSpan = Room1Pw3Timer.Elapsed
        Room1Pw3Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateTvTime()
        Dim ts As TimeSpan = tvTimer.Elapsed
        tvLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub Room1Back_Click(sender As Object, e As EventArgs) Handles Room1Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Room1ToDashboard_Click(sender As Object, e As EventArgs) Handles Room1ToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class

