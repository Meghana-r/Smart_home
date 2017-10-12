Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomA

    Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'setupSerial()
        BtnStop.Hide()
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
            Appgrp.Enabled = False
            Light2.Enabled = False
            light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim light1SW As New Stopwatch
    Dim light2SW As New Stopwatch
    Dim light3SW As New Stopwatch

    Private Sub brighttrack_Scroll(sender As Object, e As EventArgs) Handles brighttrack.ValueChanged
        brightness.Text = String.Format("{0} %", arg0:=brighttrack.Value)
        brightness.Text = brighttrack.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If brighttrack.Value = 0 Then
            lightoff.Checked = True
            light1SW.Stop()
            UpdateTimeInfo()
        Else
            lighton.Checked = True
            light1SW.Reset()
            light1SW.Start()
        End If
    End Sub

    Private Sub brighttrack2_Scroll(sender As Object, e As EventArgs) Handles brighttrack2.ValueChanged
        brightness1.Text = String.Format("{0} %", arg0:=brighttrack2.Value)
        brightness1.Text = brighttrack2.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If brighttrack2.Value = 0 Then
            lit1off.Checked = True
            light2SW.Stop()
            UpdateTimeInfo2()
        Else
            lit1on.Checked = True
            light2SW.Reset()
            light2SW.Start()
        End If
    End Sub

    Private Sub brighttrack3_Scroll(sender As Object, e As EventArgs) Handles brighttrack3.ValueChanged
        brightness2.Text = String.Format("{0} %", arg0:=brighttrack3.Value)
        brightness2.Text = brighttrack3.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If brighttrack3.Value = 0 Then
            lit2off.Checked = True
            light3SW.Stop()
            UpdateTimeInfo3
        Else
            lit2on.Checked = True
            light3SW.Reset()
            light3SW.Start()
        End If
    End Sub

    Private Sub checkBox1Status() Handles lightoff.CheckedChanged, lighton.CheckedChanged
        If lightoff.Checked = True And lighton.Checked = False Then
            brighttrack.Value = 0
        ElseIf lightoff.Checked = False And lighton.Checked = True Then
            brighttrack.Value = 2
        End If
    End Sub

    Private Sub checkBox2Status() Handles lit1off.CheckedChanged, lit1on.CheckedChanged
        If lit1off.Checked = True And lit1on.Checked = False Then
            brighttrack2.Value = 0
        ElseIf lit1off.Checked = False And lit1on.Checked = True Then
            brighttrack2.Value = 2
        End If
    End Sub

    Private Sub checkBox3Status() Handles lit2off.CheckedChanged, lit2on.CheckedChanged
        If lit2off.Checked = True And lit2on.Checked = False Then
            brighttrack3.Value = 0
        ElseIf lit2off.Checked = False And lit2on.Checked = True Then
            brighttrack3.Value = 2
        End If
    End Sub

    Private Sub UpdateTimeInfo()
        Dim ts As TimeSpan = light1SW.Elapsed
        timerLabel.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateTimeInfo2()
        Dim ts As TimeSpan = light2SW.Elapsed
        timerLabel2.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateTimeInfo3()
        Dim ts As TimeSpan = light3SW.Elapsed
        timerLabel3.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub
    'code for light settings end here


    'code for Climate settings start here
    Private Sub Increasebtn_Click(sender As Object, e As EventArgs) Handles Increasebtn.Click
        climateBtnClick(1)
    End Sub

    Private Sub Decreasebtn_Click(sender As Object, e As EventArgs) Handles Decreasebtn.Click
        climateBtnClick(0)
    End Sub

    Private Sub climateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(templabel.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        templabel.Text = n.ToString
        templabel2.Text = n.ToString

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


    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Dim m As Integer
        m = Integer.Parse(templabel.Text)
        m = 50
        templabel.Text = m.ToString
        templabel2.Text = m.ToString
    End Sub

    Private Delegate Sub UpdateLabelDelegate(ByVal myText As String)

    Private Sub DataReceived() Handles SerialPort1.DataReceived
        Dim reading As String = SerialPort1.ReadLine
        updateLabel(reading)
    End Sub

    Private Sub updateLabel(ByVal text As String)
        If Me.dhtTemp.InvokeRequired Then
            Dim d As New UpdateLabelDelegate(AddressOf updateLabel)
            Me.dhtTemp.Invoke(d, New Object() {text})
        Else
            dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here

    'code for camera starts here
    Dim cameraCapture As VideoCapture
    Dim imageFrame As Mat
    Dim faceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml")


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        startCam()
    End Sub

    Private Sub startCam()
        cameraCapture = New VideoCapture()
        If Not cameraCapture.IsOpened Then
            MsgBox("camera not found!")
        Else
            BtnStart.Hide()
            BtnStop.Show()
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

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        BtnStop.Hide()
        BtnStart.Show()
        cameraCapture.Dispose()
    End Sub
    'code for Camera ends here

    ' Appliances
    Dim tvTimer As New Stopwatch
    Private Sub tvoff_Click(sender As Object, e As EventArgs) Handles tvoff.Click
		tvon.Show()
        tvoff.Hide()
    End Sub

	Private Sub tvon_Click(sender As Object, e As EventArgs) Handles tvon.Click
		tvoff.Show()
        tvon.Hide()
    End Sub

	Private Sub poweroff_Click(sender As Object, e As EventArgs) Handles poweroff.Click
		poweron.Show()
        poweroff.Hide()
    End Sub

	Private Sub poweron_Click(sender As Object, e As EventArgs) Handles poweron.Click
		poweroff.Show()
		poweron.Hide()
	End Sub

	Private Sub power3off_Click(sender As Object, e As EventArgs) Handles power3off.Click
		power3on.Show()
        power3off.Hide()
    End Sub

	Private Sub apptab_Click(sender As Object, e As EventArgs) Handles apptab.Click
		If Appgrp.Enabled = False Then
			MsgBox("Ports not available")
		End If
	End Sub

	Private Sub power2off_Click_1(sender As Object, e As EventArgs) Handles power2off.Click
		power2off.Hide()
		power2on.Show()
	End Sub

	Private Sub power2on_Click(sender As Object, e As EventArgs) Handles power2on.Click
		power2on.Hide()
        power2off.Show()
    End Sub

	Private Sub power3on_Click(sender As Object, e As EventArgs) Handles power3on.Click
		power3on.Hide()
		power3off.Show()
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

