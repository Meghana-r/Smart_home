﻿Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports System.IO
Imports System.IO.Ports
Imports System.Threading


Public Class RoomA

    Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink400, Primary.Pink700, Primary.Pink500, Accent.Teal200, TextShade.WHITE)
        setupSerial()
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
            GroupBox1.Enabled = False
        End Try
    End Sub



    'code for light settings start here
    Private Sub brighttrack_Scroll(sender As Object, e As EventArgs) Handles brighttrack.Scroll
        brightness.Text = String.Format("{0} %", arg0:=brighttrack.Value)
        brightness.Text = brighttrack.Value.ToString
        SerialPort1.Write(brighttrack.Value)
        If brighttrack.Value = 0 Then
            lightoff.Checked = True
        Else lighton.Checked = True
        End If
    End Sub

    Private Sub checkBoxStatus() Handles lightoff.CheckedChanged, lighton.CheckedChanged
        If lightoff.Checked = True And lighton.Checked = False Then
            brighttrack.Value = 0
        ElseIf lightoff.Checked = False And lighton.Checked = True Then
            brighttrack.Value = 2
        End If
        SerialPort1.Write(brighttrack.Value)
        brightness.Text = brighttrack.Value.ToString
    End Sub

    'the value of the slider is shown in the label
    Private Sub brighttrack2_Scroll(sender As Object, e As EventArgs) Handles brighttrack2.Scroll
        brightness1.Text = brighttrack2.Value.ToString
        If brighttrack2.Value = 20 Then
            MsgBox("Brightness lower than this turns the light off. Turn the light off?")
            If MsgBoxResult.Ok Then
                lit1off.Checked = True
            End If
        End If
    End Sub

    Private Sub brighttrack3_Scroll(sender As Object, e As EventArgs) Handles brighttrack3.Scroll
        brightness2.Text = brighttrack3.Value.ToString
        If brighttrack3.Value = 20 Then
            MsgBox("Brightness lower than this turns the light off. Turn the light off?")
            If MsgBoxResult.Ok Then
                lit2off.Checked = True
            End If
        End If
    End Sub
    'code for light settings end here
    'code for Temperature settings start here
    Private Sub increasebtn_Click(sender As Object, e As EventArgs) Handles Increasebtn.Click
        Dim n As Integer
        n = Integer.Parse(templabel.Text)
        n = n + 1
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

    Private Sub Decreasebtn_Click(sender As Object, e As EventArgs) Handles Decreasebtn.Click
        Dim m As Integer

        m = Integer.Parse(templabel.Text)
        m = m - 1
        If (m <= 20) Then
            coldimage.Show()

            sunimage.Hide()
            mediumhot.Hide()

        ElseIf (m >= 50) Then
            sunimage.Show()
            mediumhot.Hide()
            coldimage.Hide()

        Else
            mediumhot.Show()
            sunimage.Hide()
            coldimage.Hide()
        End If
        templabel.Text = m.ToString
        templabel2.Text = m.ToString

    End Sub


    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Dim m As Integer

        m = Integer.Parse(templabel.Text)
        m = 50
        templabel.Text = m.ToString
        templabel2.Text = m.ToString

    End Sub
	'code for Temperature settings end here

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()

    End Sub

	Private Sub apptab_Click(sender As Object, e As EventArgs) Handles apptab.Click

	End Sub
End Class

