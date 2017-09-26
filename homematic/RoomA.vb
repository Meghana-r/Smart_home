
Imports MaterialSkin

Public Class RoomA
	'A material skin form is imported

	Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Pink400, Primary.Pink700, Primary.Pink500, Accent.Teal200, TextShade.WHITE)
		'If Me.WindowState = FormWindowState.Maximized Then
		'	bulb.Location = Location(42, 33) As point
		'End If
	End Sub
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



End Class

