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
        Room1Light1off.Checked = False
        Room1SetupSerial()
        Room1VidStop.Hide()
    End Sub

    Private Sub Room1SetupSerial()
        ' SUB : Establishes Serial Port Connection with Arduino using proper settings
        ' INPUT : Takes no arguments
        ' OUTPUT : Disbales all control interfaces if serial port does not open (i.e. connection establishment fails)
        Room1SerialPort1.Close()
        Room1SerialPort1.PortName = "COM4"
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
            Room1AppGrpBox2.Enabled = False
            Room2Light2.Enabled = False
            Room1light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room1light1SW As New Stopwatch
    Dim Room1light2SW As New Stopwatch
    Dim Room1light3SW As New Stopwatch

    Private Sub Room1Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room1Light1Bri.ValueChanged
        ' SUB : Responds to event Room1Light1Bri.ValueChanged
        ' INPUT : nothing special
        ' OUTPUT : 1. Writes Room1Light1Bri.Value to Room1Light1Lbl
        '          2. Sends appropriate control signal to arduino for the light
        '          3. Starts/Stops stopwatch and invokes the TIME-UPDATE functions
        Room1Light1Lbl.Text = Room1Light1Bri.Value.ToString
        If Room1SerialPort1.IsOpen = True Then
            Room1SerialPort1.Write(Room1Light1Bri.Value)
        End If
        If Room1Light1Bri.Value = Room1Light1Bri.Minimum Then
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
        Room1Light2Lbl.Text = Room1Light2Bri.Value.ToString - 4
        If Room1SerialPort1.IsOpen = True Then
            Room1SerialPort1.Write(Room1Light2Bri.Value)
        End If
        If Room1Light2Bri.Value = Room1Light2Bri.Minimum Then
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
        Room1Light3Lbl.Text = Room1Light3Bri.Value.ToString - 8
        If Room1SerialPort1.IsOpen = True Then
            Room1SerialPort1.Write(Room1Light3Bri.Value)
        End If
        If Room1Light3Bri.Value = Room1Light3Bri.Minimum Then
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
        ' SUB : Handles the CheckChanged event for the checkboxes
        ' INPUT : nothing special
        ' OUTPUT : Changes the value of the trackbar Room1Light1Bri 
        '           This is done to ensure that only a single function can write to the serial port for specific device so as to reduce redundancy
        If Room1Light1off.Checked = True And Room1Light1on.Checked = False Then
            Room1Light1Bri.Value = Room1Light1Bri.Minimum
        ElseIf Room1Light1off.Checked = False And Room1Light1on.Checked = True Then
            Room1Light1Bri.Value = Room1Light1Bri.Maximum
        End If
    End Sub

    Private Sub Room1Light2ChkStatus() Handles Room1Light2off.CheckedChanged, Room1Light2on.CheckedChanged
        If Room1Light2off.Checked = True And Room1Light2on.Checked = False Then
            Room1Light2Bri.Value = Room1Light2Bri.Minimum
        ElseIf Room1Light2off.Checked = False And Room1Light2on.Checked = True Then
            Room1Light2Bri.Value = Room1Light2Bri.Maximum
        End If
    End Sub

    Private Sub Room1Light3Status() Handles Room1Light3off.CheckedChanged, Room1Light3on.CheckedChanged
        If Room1Light3off.Checked = True And Room1Light3on.Checked = False Then
            Room1Light3Bri.Value = Room1Light3Bri.Minimum
        ElseIf Room1Light3off.Checked = False And Room1Light3on.Checked = True Then
            Room1Light3Bri.Value = Room1Light3Bri.Maximum
        End If
    End Sub

    Private Sub Room1UpdtLi1TimeInfo()
        ' SUB : Updates the time info by calling a function to update the database
        ' INPUT : nothing as such
        ' OUTPUT : calulates the time from the stopwatch instance for this specific item and calls the update method with the appropriate name for the database query
        Dim ts As Long = Room1light1SW.ElapsedMilliseconds
        writeDb(ts, "Room1Light1")
    End Sub

    Private Sub Room1UpdtLi2TimeInfo()
        Dim ts As Long = Room1light2SW.ElapsedMilliseconds
        'Room1Light2TimerLbl.Text = ts.ToString
        writeDb(ts, "Room1Light2")
    End Sub

    Private Sub Room1UpdtLi3TimeInfo()
        Dim ts As Long = Room1light3SW.ElapsedMilliseconds
        'Room1Light3TimerLbl.Text = ts.ToString
        writeDb(ts, "Room1Light3")
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room1TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room1TempIncBtn.Click
        ' SUB : calls another function to manage the climate settings
        Room1ClimateBtnClick(1)
    End Sub

    Private Sub Room1TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room1TempDecBtn.Click
        Room1ClimateBtnClick(0)
    End Sub


    Private Sub Room1ClimateBtnClick(ByVal index As Int64)
        ' SUB : manages the climate settings
        ' INPUT : accepts an integer 
        ' OUTPUT : Compares the integer and then either raises or lowers the climate 
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
        ' resets the room temp
        Dim m As Integer
        m = Integer.Parse(Room1TempLbl.Text)
        m = 50
        Room1TempLbl.Text = m.ToString
        Room1TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room1UpdateLabelDelegate(ByVal myText As String)
    ' a delegate so that we can call a method from another thread


    Private Sub Room1DataReceived() Handles Room1SerialPort1.DataReceived
        ' accepts the DataReceived event handler and calls the Room1UpdateLabel method from the other thread
        ' with a string read from the serial port (humidity and temp from the arduino)
        Dim reading As String = Room1SerialPort1.ReadLine
        Room1UpdateLabel(reading)
    End Sub

    Private Sub Room1UpdateLabel(ByVal text As String)
        ' SUB : updates the temp and humidity label
        ' INPUT : string which is the data read from the serial port
        ' OUTPUT : 1. Check if it is in the other thread
        '          2. If yes then it calls the delegate with its own address (a recursive call)
        '          3. If no then it displays the string in the proper label
        ' Since the delegate gets the address ot itself on ht recursive call; this method gets called a second time but this time from the main thread because of the delegate
        If Me.Room1dhtTemp.InvokeRequired Then
            Dim d As New Room1UpdateLabelDelegate(AddressOf Room1UpdateLabel)
            Me.Room1dhtTemp.Invoke(d, New Object() {text}) ' this line invokes the desired function from another thread
        Else
            Room1dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here

    'code for camera starts here
    Dim Room1CameraCapture As VideoCapture 'VideoCapture object
    Dim Room1ImageFrame As Mat ' for storing images
    Dim Room1FaceDetector As New CascadeClassifier("..\..\Resources\classifiers\haarcascade_frontalface_default.xml") ' the detector loaded with a xml file
    Public Property VidStat As Boolean

	Public Sub Room1VidStart_Click(sender As Object, e As EventArgs) Handles Room1VidStart.Click
        ' starts the actual thing
        Room1StartCam()
        VidStat = True
	End Sub

    Private Sub Room1StartCam()
        ' SUB : starts the capture process
        ' INPUT : nothing special
        ' OUTPUT : checks if camera is opened or not
        '          1. If yes.. then shows the stop button
        '          2. If no.. then  notify that camera not found
        '  there is an event handler that calls a method to process the captures 
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
        ' SUB : this method processes the captures
        ' INPUT : nothing special
        ' OUTPUT : 1. takes an image frame
        '          2. uses haar cascade classifiers to DETECT faces ad draw rectangles around them

        Room1ImageFrame = Room1CameraCapture.QuerySmallFrame ' gets a frame from the capture thread

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
        ' Stops the video capture session
        Room1VidStop.Hide()
        Room1VidStart.Show()
        Room1CameraCapture.Dispose()
        VidStat = False
    End Sub
    'code for Camera ends here

    ' Appliances on?off code
    Dim tvTimer As New Stopwatch

    'For on/off. on = true off = false
    Public Property Room1Pw1Status As Boolean
	Public Property Room1Pw2Status As Boolean
	Public Property Room1Pw3Status As Boolean
	Public Property tvStatus As Boolean

	Private Sub Room1Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw1Btn.Click
        If Room1Pw1Status = True Then
            Room1Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw1Status = False
        ElseIf Room1Pw1Status = False Then
            Room1Pw1Btn.BackgroundImage = My.Resources.poweron
            Room1Pw1Status = True
        End If
    End Sub

    Private Sub Room1Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw2Btn.Click
        If Room1Pw2Status = True Then
            Room1Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw2Status = False
        ElseIf Room1Pw2Status = False Then
            Room1Pw2Btn.BackgroundImage = My.Resources.poweron
            Room1Pw2Status = True
        End If
    End Sub

    Private Sub Room1Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room1Pw3Btn.Click
        If Room1Pw3Status = True Then
            Room1Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room1Pw3Status = False
        ElseIf Room1Pw3Status = False Then
            Room1Pw3Btn.BackgroundImage = My.Resources.poweron
            Room1Pw3Status = True
        End If
    End Sub

    Private Sub tvBtn_Click(sender As Object, e As EventArgs) Handles tvBtn.Click
        ' switch on the TV and make sure that the time thing is updated
        If tvStatus = True Then
            tvBtn.BackgroundImage = My.Resources.tvoff
            tvTimer.Stop()
            UpdateTvTime()
            If Room1SerialPort1.IsOpen = True Then
                Room1SerialPort1.Write(13)
            End If
            tvStatus = False
        ElseIf tvStatus = False Then
            tvBtn.BackgroundImage = My.Resources.tvon
            tvTimer.Reset()
            tvTimer.Start()
            If Room1SerialPort1.IsOpen = True Then
                Room1SerialPort1.Write(12)
            End If
            tvStatus = True
        End If
    End Sub

    Private Sub UpdateTvTime()
        Dim ts As Long = tvTimer.ElapsedMilliseconds
        writeDb(ts, "Room1Pw1")
    End Sub

    Private Sub Room1Back_Click(sender As Object, e As EventArgs) Handles Room1Back.Click
        Form1.Show()
        Room1SerialPort1.Close()
        Me.Hide()
    End Sub

    Private Sub Room1ToDashboard_Click(sender As Object, e As EventArgs) Handles Room1ToDashboard.Click
        Dashboard.Show()
        'Me.Hide()
    End Sub
End Class

