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
        'setupSerial()
        Room1BtnStop.Hide()
    End Sub

    Private Sub setupSerial()
        SerialPort1.Close()
        SerialPort1.PortName = "com4"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Light1.Enabled = False
            Room1AppBrpBox.Enabled = False
            Light2.Enabled = False
            light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room1light1SW As New Stopwatch
    Dim Room1light2SW As New Stopwatch
    Dim Room1light3SW As New Stopwatch

    Private Sub brighttrack_Scroll(sender As Object, e As EventArgs) Handles Room1Light1Bri.ValueChanged
        Room1Light1Lbl.Text = String.Format("{0} %", arg0:=Room1Light1Bri.Value)
        Room1Light1Lbl.Text = Room1Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room1Light1Bri.Value = 0 Then
            Room1Light1off.Checked = True
            Room1light1SW.Stop()
            UpdateTimeInfo()
        Else
            Room1Light1on.Checked = True
            Room1light1SW.Reset()
            Room1light1SW.Start()
        End If
    End Sub

    Private Sub brighttrack2_Scroll(sender As Object, e As EventArgs) Handles Room1Light2Bri.ValueChanged
        Room1Light2Lbl.Text = String.Format("{0} %", arg0:=Room1Light2Bri.Value)
        Room1Light2Lbl.Text = Room1Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room1Light2Bri.Value = 0 Then
            Room1Light2off.Checked = True
            Room1light2SW.Stop()
            UpdateTimeInfo2()
        Else
            Room1Light2on.Checked = True
            Room1light2SW.Reset()
            Room1light2SW.Start()
        End If
    End Sub

    Private Sub brighttrack3_Scroll(sender As Object, e As EventArgs) Handles Room1Light3Bri.ValueChanged
        Room1Light3Lbl.Text = String.Format("{0} %", arg0:=Room1Light3Bri.Value)
        Room1Light3Lbl.Text = Room1Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room1Light3Bri.Value = 0 Then
            Room1Light3off.Checked = True
            Room1light3SW.Stop()
            UpdateTimeInfo3()
        Else
            Room1Light3on.Checked = True
            Room1light3SW.Reset()
            Room1light3SW.Start()
        End If
    End Sub

    Private Sub checkBox1Status() Handles Room1Light1off.CheckedChanged, Room1Light1on.CheckedChanged
        If Room1Light1off.Checked = True And Room1Light1on.Checked = False Then
            Room1Light1Bri.Value = 0
        ElseIf Room1Light1off.Checked = False And Room1Light1on.Checked = True Then
            Room1Light1Bri.Value = 2
        End If
    End Sub

    Private Sub checkBox2Status() Handles Room1Light2off.CheckedChanged, Room1Light2on.CheckedChanged
        If Room1Light2off.Checked = True And Room1Light2on.Checked = False Then
            Room1Light2Bri.Value = 0
        ElseIf Room1Light2off.Checked = False And Room1Light2on.Checked = True Then
            Room1Light2Bri.Value = 2
        End If
    End Sub

    Private Sub checkBox3Status() Handles Room1Light3off.CheckedChanged, Room1Light3on.CheckedChanged
        If Room1Light3off.Checked = True And Room1Light3on.Checked = False Then
            Room1Light3Bri.Value = 0
        ElseIf Room1Light3off.Checked = False And Room1Light3on.Checked = True Then
            Room1Light3Bri.Value = 2
        End If
    End Sub

    Private Sub UpdateTimeInfo()
        Dim ts As TimeSpan = Room1light1SW.Elapsed
        Room1Light1TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateTimeInfo2()
        Dim ts As TimeSpan = Room1light2SW.Elapsed
        Room1Light2TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateTimeInfo3()
        Dim ts As TimeSpan = Room1light3SW.Elapsed
        Room1Light3TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub
    'code for light settings end here


    'code for Climate settings start here
    Private Sub Increasebtn_Click(sender As Object, e As EventArgs) Handles Room1TempIncBtn.Click
        climateBtnClick(1)
    End Sub

    Private Sub Decreasebtn_Click(sender As Object, e As EventArgs) Handles Room1TempDecBtn.Click
        climateBtnClick(0)
    End Sub

    Private Sub climateBtnClick(ByVal index As Int64)
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


    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles Room1TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room1TempLbl.Text)
        m = 50
        Room1TempLbl.Text = m.ToString
        Room1TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub UpdateLabelDelegate(ByVal myText As String)

    Private Sub DataReceived() Handles SerialPort1.DataReceived
        Dim reading As String = SerialPort1.ReadLine
        updateLabel(reading)
    End Sub

    Private Sub updateLabel(ByVal text As String)
        If Me.Room1dhtTemp.InvokeRequired Then
            Dim d As New UpdateLabelDelegate(AddressOf updateLabel)
            Me.Room1dhtTemp.Invoke(d, New Object() {text})
        Else
            Room1dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here

    'code for camera starts here
    Dim cameraCapture As VideoCapture
    Dim imageFrame As Mat
    Dim faceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles Room1VidStart.Click
        startCam()
    End Sub

    Private Sub startCam()
        cameraCapture = New VideoCapture()
        If Not cameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            Room1VidStart.Hide()
            Room1BtnStop.Show()
        End If
        AddHandler Application.Idle, AddressOf processCapture ' call the function when the event is raised.
    End Sub

    Private Sub processCapture(sender As System.Object, e As System.EventArgs)
        imageFrame = cameraCapture.QuerySmallFrame

        If imageFrame IsNot Nothing Then
            For Each face As Rectangle In faceDetector.DetectMultiScale(
                         imageFrame, 'the frame where it is suposed to detect
                         1.1,        'the relative size of scanning window for the next pass
                         10,      ' minimum neighbours to group as a single detected frame
                         New Size(20, 20), ' size of the window
                         Size.Empty)      'maximum size of the window
                CvInvoke.Rectangle(imageFrame, face, New MCvScalar(255, 255, 255)) ' DRAW a rectangle around the detected area
            Next
        End If

        ImageBox.Image = imageFrame
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles Room1BtnStop.Click
        Room1BtnStop.Hide()
        Room1VidStart.Show()
        cameraCapture.Dispose()
    End Sub
    'code for Camera ends here

    ' Appliances
    Dim tvTimer As New Stopwatch
    Dim Room1Pw1Timer As New Stopwatch
    Dim Room1Pw2Timer As New Stopwatch
    Dim Room1Pw3Timer As New Stopwatch

    ' for on/off. on = true off = false
    Dim Room1Pw1Status As Boolean
    Dim Room1Pw2Status As Boolean
    Dim Room1Pw3Status As Boolean
    Dim tvStatus As Boolean

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

    Private Sub MasterBack_Click(sender As Object, e As EventArgs) Handles MasterBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub MasterToDashboard_Click(sender As Object, e As EventArgs) Handles MasterToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class

