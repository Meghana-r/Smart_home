Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomE
    'Public Property Tab As New TabPage
    Private Sub RoomE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'Room5SetupSerial()
        Room5VidStop.Hide()
    End Sub

    Private Sub Room5SetupSerial()
        Room5SerialPort1.Close()
        Room5SerialPort1.PortName = "com4"
        Room5SerialPort1.BaudRate = 9600
        Room5SerialPort1.DataBits = 8
        Room5SerialPort1.Parity = Parity.None
        Room5SerialPort1.StopBits = StopBits.One
        Room5SerialPort1.Handshake = Handshake.None
        Room5SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room5SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room5Light1.Enabled = False
            Room5AppBrpBox.Enabled = False
            Room5Light2.Enabled = False
            Room5light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room5light1SW As New Stopwatch
    Dim Room5light2SW As New Stopwatch
    Dim Room5light3SW As New Stopwatch

    Private Sub Room5Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room5Light1Bri.ValueChanged
        Room5Light1Lbl.Text = String.Format("{0} %", arg0:=Room5Light1Bri.Value)
        Room5Light1Lbl.Text = Room5Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room5Light1Bri.Value = 0 Then
            Room5Light1off.Checked = True
            Room5light1SW.Stop()
            Room5UpdtLi1TimeInfo()
        Else
            Room5Light1on.Checked = True
            Room5light1SW.Reset()
            Room5light1SW.Start()
        End If
    End Sub

    Private Sub Room5Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room5Light2Bri.ValueChanged
        Room5Light2Lbl.Text = String.Format("{0} %", arg0:=Room5Light2Bri.Value)
        Room5Light2Lbl.Text = Room5Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room5Light2Bri.Value = 0 Then
            Room5Light2off.Checked = True
            Room5light2SW.Stop()
            Room5UpdtLi2TimeInfo()
        Else
            Room5Light2on.Checked = True
            Room5light2SW.Reset()
            Room5light2SW.Start()
        End If
    End Sub

    Private Sub Room5Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room5Light3Bri.ValueChanged
        Room5Light3Lbl.Text = String.Format("{0} %", arg0:=Room5Light3Bri.Value)
        Room5Light3Lbl.Text = Room5Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room5Light3Bri.Value = 0 Then
            Room5Light3off.Checked = True
            Room5light3SW.Stop()
            Room5UpdtLi3TimeInfo()
        Else
            Room5Light3on.Checked = True
            Room5light3SW.Reset()
            Room5light3SW.Start()
        End If
    End Sub

    Private Sub Room5Light1ChkStatus() Handles Room5Light1off.CheckedChanged, Room5Light1on.CheckedChanged
        If Room5Light1off.Checked = True And Room5Light1on.Checked = False Then
            Room5Light1Bri.Value = 0
        ElseIf Room5Light1off.Checked = False And Room5Light1on.Checked = True Then
            Room5Light1Bri.Value = 2
        End If
    End Sub

    Private Sub Room5Light2ChkStatus() Handles Room5Light2off.CheckedChanged, Room5Light2on.CheckedChanged
        If Room5Light2off.Checked = True And Room5Light2on.Checked = False Then
            Room5Light2Bri.Value = 0
        ElseIf Room5Light2off.Checked = False And Room5Light2on.Checked = True Then
            Room5Light2Bri.Value = 2
        End If
    End Sub

    Private Sub Room5Light3Status() Handles Room5Light3off.CheckedChanged, Room5Light3on.CheckedChanged
        If Room5Light3off.Checked = True And Room5Light3on.Checked = False Then
            Room5Light3Bri.Value = 0
        ElseIf Room5Light3off.Checked = False And Room5Light3on.Checked = True Then
            Room5Light3Bri.Value = 2
        End If
    End Sub

    Private Sub Room5UpdtLi1TimeInfo()
        Dim ts As TimeSpan = Room5light1SW.Elapsed
        Room5Light1TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub Room5UpdtLi2TimeInfo()
        Dim ts As TimeSpan = Room5light2SW.Elapsed
        Room5Light2TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub Room5UpdtLi3TimeInfo()
        Dim ts As TimeSpan = Room5light3SW.Elapsed
        Room5Light3TimerLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room5TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room5TempIncBtn.Click
        Room5ClimateBtnClick(1)
    End Sub

    Private Sub Room5TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room5TempDecBtn.Click
        Room5ClimateBtnClick(0)
    End Sub


    Private Sub Room5ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room5TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room5TempLbl.Text = n.ToString
        Room5TempLbl2.Text = n.ToString

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


    Private Sub Room5TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room5TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room5TempLbl.Text)
        m = 50
        Room5TempLbl.Text = m.ToString
        Room5TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room5UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room5DataReceived() Handles Room5SerialPort1.DataReceived
        Dim reading As String = Room5SerialPort1.ReadLine
        Room5UpdateLabel(reading)
    End Sub

    Private Sub Room5UpdateLabel(ByVal text As String)
        If Me.Room5dhtTemp.InvokeRequired Then
            Dim d As New Room5UpdateLabelDelegate(AddressOf Room5UpdateLabel)
            Me.Room5dhtTemp.Invoke(d, New Object() {text})
        Else
            Room5dhtTemp.Text = text
        End If
    End Sub
    'code for Climate settings end here


    ' Appliances
    Dim tvTimer As New Stopwatch
    Dim Room5Pw1Timer As New Stopwatch
    Dim Room5Pw2Timer As New Stopwatch
    Dim Room5Pw3Timer As New Stopwatch

    ' for on/off. on = true off = false
    Dim Room5Pw1Status As Boolean
    Dim Room5Pw2Status As Boolean
    Dim Room5Pw3Status As Boolean
    Dim tvStatus As Boolean

    Private Sub Room5Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room5Pw1Btn.Click
        If Room5Pw1Status = True Then
            Room5Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room5Pw1Timer.Stop()
            UpdateRoom5Pw1Time()
            Room5Pw1Status = False
        ElseIf Room5Pw1Status = False Then
            Room5Pw1Btn.BackgroundImage = My.Resources.poweron
            Room5Pw1Timer.Reset()
            Room5Pw1Timer.Start()
            Room5Pw1Status = True
        End If
    End Sub

    Private Sub Room5Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room5Pw2Btn.Click
        If Room5Pw2Status = True Then
            Room5Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room5Pw2Timer.Stop()
            UpdateRoom5Pw2Time()
            Room5Pw2Status = False
        ElseIf Room5Pw2Status = False Then
            Room5Pw2Btn.BackgroundImage = My.Resources.poweron
            Room5Pw2Timer.Reset()
            Room5Pw2Timer.Start()
            Room5Pw2Status = True
        End If
    End Sub

    Private Sub Room5Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room5Pw3Btn.Click
        If Room5Pw3Status = True Then
            Room5Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room5Pw3Timer.Stop()
            UpdateRoom5Pw3Time()
            Room5Pw3Status = False
        ElseIf Room5Pw3Status = False Then
            Room5Pw3Btn.BackgroundImage = My.Resources.poweron
            Room5Pw3Timer.Reset()
            Room5Pw3Timer.Start()
            Room5Pw3Status = True
        End If
    End Sub

    Private Sub UpdateRoom5Pw1Time()
        Dim ts As TimeSpan = Room5Pw1Timer.Elapsed
        Room5Pw1Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateRoom5Pw2Time()
        Dim ts As TimeSpan = Room5Pw2Timer.Elapsed
        Room5Pw2Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub

    Private Sub UpdateRoom5Pw3Time()
        Dim ts As TimeSpan = Room5Pw3Timer.Elapsed
        Room5Pw3Lbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub


    Private Sub Room5Back_Click(sender As Object, e As EventArgs) Handles Room5Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Room5ToDashboard_Click(sender As Object, e As EventArgs) Handles Room5ToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class

