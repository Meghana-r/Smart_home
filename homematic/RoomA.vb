Imports MaterialSkin
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum

Public Class RoomA

	Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Pink400, Primary.Pink700, Primary.Pink500, Accent.Teal200, TextShade.WHITE)
		'sunimage.Hide()
		'coldimage.Hide()
		'mediumhot.Hide()


	End Sub
	'code for light settings start here
	Private Sub brighttrack_Scroll(sender As Object, e As EventArgs) Handles brighttrack.Scroll
		brightness.Text = String.Format("{0} %", arg0:=brighttrack.Value)
		brightness.Text = brighttrack.Value.ToString
		If brighttrack.Value = 20 Then
			MsgBox("Brightness lower than this turns the light off.
Turn the light off?")
			If MsgBoxResult.Ok = 1 Then
				lightoff.Checked = True
			Else lighton.Checked = True



			End If
		End If

	End Sub

	'the value of the slider is shown in the label
	Private Sub brighttrack2_Scroll(sender As Object, e As EventArgs) Handles brighttrack2.Scroll
		brightness1.Text = brighttrack2.Value.ToString
		If brighttrack2.Value = 20 Then
			MsgBox("Brightness lower than this turns the light off.
Turn the light off?")
			If MsgBoxResult.Ok Then
				lit1off.Checked = True
			End If
		End If

	End Sub

	Private Sub brighttrack3_Scroll(sender As Object, e As EventArgs) Handles brighttrack3.Scroll
		brightness2.Text = brighttrack3.Value.ToString
		If brighttrack3.Value = 20 Then
			MsgBox("Brightness lower than this turns the light off.
Turn the light off?")
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
	'code for Appliances settings start here
	Private Sub S1switchoff_Click(sender As Object, e As EventArgs) Handles S1switchoff.Click
		S1switchon.Show()
		S1switchoff.Hide()
		MsgBox("The appliance is connected")

	End Sub

	Private Sub S1switchon_Click(sender As Object, e As EventArgs) Handles S1switchon.Click
		S1switchon.Hide()
		S1switchoff.Show()
		MsgBox("The appliance is disconnected")
	End Sub

	Private Sub s2switchon_Click(sender As Object, e As EventArgs) Handles s2switchon.Click
		s2switchon.Hide()
		s2switchoff.Show()
		MsgBox("The appliance is disconnected")
	End Sub

	Private Sub s2switchoff_Click(sender As Object, e As EventArgs) Handles s2switchoff.Click
		s2switchon.Show()
		s2switchoff.Hide()
		MsgBox("The appliance is connected")
	End Sub

	Private Sub s4switchon_Click(sender As Object, e As EventArgs) Handles s4switchon.Click
		s4switchon.Hide()
		s4switchoff.Show()
		MsgBox("The appliance is disconnected")
	End Sub

	Private Sub s4switchoff_Click(sender As Object, e As EventArgs) Handles s4switchoff.Click
		s4switchon.Show()
		s4switchoff.Hide()
		MsgBox("The appliance is connected")
	End Sub

	Private Sub s3switchon_Click(sender As Object, e As EventArgs) Handles s3switchon.Click
		s3switchon.Hide()
		s3switchoff.Show()
		MsgBox("The appliance is disconnected")
	End Sub

    Private Sub s3switchoff_Click(sender As Object, e As EventArgs) Handles s3switchoff.Click
        s3switchon.Show()
        s3switchoff.Hide()
        MsgBox("The appliance is connected")
    End Sub
    'code for appliances settings end here

    Dim cameraCapture As VideoCapture
    Dim imageFrame As Mat

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        cameraCapture = New VideoCapture()
        cameraCapture.Start() ' some reference is needed .. just accept the suggested solution
        AddHandler Application.Idle, AddressOf processCapture ' call the function when the event is raised.
    End Sub

    Private Sub processCapture(sender As System.Object, e As System.EventArgs)
        imageFrame = cameraCapture.QueryFrame
        ImageBox.Image = imageFrame
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        cameraCapture.Stop()
        cameraCapture.Dispose()
    End Sub
End Class

