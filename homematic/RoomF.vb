Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Diagnostics


Public Class RoomF
    'Public Property Tab As New TabPage
    Private Sub RoomF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
        ' disable for debugging purposes only
        'Room6SetupSerial()
        Room6VidStop.Hide()
    End Sub

    Private Sub Room6SetupSerial()
        Room6SerialPort1.Close()
        Room6SerialPort1.PortName = "com4"
        Room6SerialPort1.BaudRate = 9600
        Room6SerialPort1.DataBits = 8
        Room6SerialPort1.Parity = Parity.None
        Room6SerialPort1.StopBits = StopBits.One
        Room6SerialPort1.Handshake = Handshake.None
        Room6SerialPort1.Encoding = System.Text.Encoding.Default
        Try
            Room6SerialPort1.Open()
        Catch ex As IOException
            MsgBox("Port not opened. All controls are unavailable.")
            Room6Light1.Enabled = False
            Room6AppBrpBox.Enabled = False
            Room6Light2.Enabled = False
            Room6light3.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Dim Room6light1SW As New Stopwatch
    Dim Room6light2SW As New Stopwatch
    Dim Room6light3SW As New Stopwatch

    Private Sub Room6Light1Bri_Scroll(sender As Object, e As EventArgs) Handles Room6Light1Bri.ValueChanged
        Room6Light1Lbl.Text = String.Format("{0} %", arg0:=Room6Light1Bri.Value)
        Room6Light1Lbl.Text = Room6Light1Bri.Value.ToString
        'SerialPort1.Write(brighttrack.Value) 
        If Room6Light1Bri.Value = 0 Then
            Room6Light1off.Checked = True
            Room6light1SW.Stop()
            Room6UpdtLi1TimeInfo()
        Else
            Room6Light1on.Checked = True
            Room6light1SW.Reset()
            Room6light1SW.Start()
        End If
    End Sub

    Private Sub Room6Light2Bri_Scroll(sender As Object, e As EventArgs) Handles Room6Light2Bri.ValueChanged
        Room6Light2Lbl.Text = String.Format("{0} %", arg0:=Room6Light2Bri.Value)
        Room6Light2Lbl.Text = Room6Light2Bri.Value.ToString
        'SerialPort1.Write(brighttrack2.Value)
        If Room6Light2Bri.Value = 0 Then
            Room6Light2off.Checked = True
            Room6light2SW.Stop()
            Room6UpdtLi2TimeInfo()
        Else
            Room6Light2on.Checked = True
            Room6light2SW.Reset()
            Room6light2SW.Start()
        End If
    End Sub

    Private Sub Room6Light3Bri_Scroll(sender As Object, e As EventArgs) Handles Room6Light3Bri.ValueChanged
        Room6Light3Lbl.Text = String.Format("{0} %", arg0:=Room6Light3Bri.Value)
        Room6Light3Lbl.Text = Room6Light3Bri.Value.ToString
        'SerialPort1.Write(brighttrack3.Value)
        If Room6Light3Bri.Value = 0 Then
            Room6Light3off.Checked = True
            Room6light3SW.Stop()
            Room6UpdtLi3TimeInfo()
        Else
            Room6Light3on.Checked = True
            Room6light3SW.Reset()
            Room6light3SW.Start()
        End If
    End Sub

    Private Sub Room6Light1ChkStatus() Handles Room6Light1off.CheckedChanged, Room6Light1on.CheckedChanged
        If Room6Light1off.Checked = True And Room6Light1on.Checked = False Then
            Room6Light1Bri.Value = 0
        ElseIf Room6Light1off.Checked = False And Room6Light1on.Checked = True Then
            Room6Light1Bri.Value = 2
        End If
    End Sub

    Private Sub Room6Light2ChkStatus() Handles Room6Light2off.CheckedChanged, Room6Light2on.CheckedChanged
        If Room6Light2off.Checked = True And Room6Light2on.Checked = False Then
            Room6Light2Bri.Value = 0
        ElseIf Room6Light2off.Checked = False And Room6Light2on.Checked = True Then
            Room6Light2Bri.Value = 2
        End If
    End Sub

    Private Sub Room6Light3Status() Handles Room6Light3off.CheckedChanged, Room6Light3on.CheckedChanged
        If Room6Light3off.Checked = True And Room6Light3on.Checked = False Then
            Room6Light3Bri.Value = 0
        ElseIf Room6Light3off.Checked = False And Room6Light3on.Checked = True Then
            Room6Light3Bri.Value = 2
        End If
    End Sub

    Private Sub Room6UpdtLi1TimeInfo()
        Dim ts As Long = Room6light1SW.ElapsedMilliseconds
        writeDb(ts, "Room6Light1")
    End Sub

    Private Sub Room6UpdtLi2TimeInfo()
        Dim ts As Long = Room6light2SW.ElapsedMilliseconds
        writeDb(ts, "Room6Light2")
    End Sub

    Private Sub Room6UpdtLi3TimeInfo()
        Dim ts As Long = Room6light3SW.ElapsedMilliseconds
        writeDb(ts, "Room6Light3")
    End Sub
    'code for light settings end here


    'code for Climate settings start here

    Private Sub Room6TempIncBtn_Click(sender As Object, e As EventArgs) Handles Room6TempIncBtn.Click
        Room6ClimateBtnClick(1)
    End Sub

    Private Sub Room6TempDecBtn_Click(sender As Object, e As EventArgs) Handles Room6TempDecBtn.Click
        Room6ClimateBtnClick(0)
    End Sub


    Private Sub Room6ClimateBtnClick(ByVal index As Int64)
        Dim n As Integer
        n = Integer.Parse(Room6TempLbl.Text)
        If index = 1 Then
            n = n + 1
        ElseIf index = 0 Then
            n = n - 1
        End If

        Room6TempLbl.Text = n.ToString
        Room6TempLbl2.Text = n.ToString

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


    Private Sub Room6TempResetBtn_Click(sender As Object, e As EventArgs) Handles Room6TempResetBtn.Click
        Dim m As Integer
        m = Integer.Parse(Room6TempLbl.Text)
        m = 50
        Room6TempLbl.Text = m.ToString
        Room6TempLbl2.Text = m.ToString
    End Sub

    Private Delegate Sub Room6UpdateLabelDelegate(ByVal myText As String)

    Private Sub Room6DataReceived() Handles Room6SerialPort1.DataReceived
        Dim reading As String = Room6SerialPort1.ReadLine
        Room6UpdateLabel(reading)
    End Sub

    Private Sub Room6UpdateLabel(ByVal text As String)
        If Me.Room6dhtTemp.InvokeRequired Then
            Dim d As New Room6UpdateLabelDelegate(AddressOf Room6UpdateLabel)
            Me.Room6dhtTemp.Invoke(d, New Object() {text})
        Else
            Room6dhtTemp.Text = text
        End If
    End Sub
	'code for Climate settings end here


	' for on/off. on = true off = false
	Public Property Room6Pw1Status As Boolean
	Public Property Room6Pw2Status As Boolean
	Public Property Room6Pw3Status As Boolean
	Public Property tvStatus As Boolean

	Private Sub Room6Pw1Btn_Click(sender As Object, e As EventArgs) Handles Room6Pw1Btn.Click
        If Room6Pw1Status = True Then
            Room6Pw1Btn.BackgroundImage = My.Resources.poweroff
            Room6Pw1Status = False
        ElseIf Room6Pw1Status = False Then
            Room6Pw1Btn.BackgroundImage = My.Resources.poweron
            Room6Pw1Status = True
        End If
    End Sub

    Private Sub Room6Pw2Btn_Click(sender As Object, e As EventArgs) Handles Room6Pw2Btn.Click
        If Room6Pw2Status = True Then
            Room6Pw2Btn.BackgroundImage = My.Resources.poweroff
            Room6Pw2Status = False
        ElseIf Room6Pw2Status = False Then
            Room6Pw2Btn.BackgroundImage = My.Resources.poweron
            Room6Pw2Status = True
        End If
    End Sub

    Private Sub Room6Pw3Btn_Click(sender As Object, e As EventArgs) Handles Room6Pw3Btn.Click
        If Room6Pw3Status = True Then
            Room6Pw3Btn.BackgroundImage = My.Resources.poweroff
            Room6Pw3Status = False
        ElseIf Room6Pw3Status = False Then
            Room6Pw3Btn.BackgroundImage = My.Resources.poweron
            Room6Pw3Status = True
        End If
    End Sub

    Private Sub Room6Back_Click(sender As Object, e As EventArgs) Handles Room6Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Room6ToDashboard_Click(sender As Object, e As EventArgs) Handles Room6ToDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class

