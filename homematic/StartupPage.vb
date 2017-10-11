Imports MaterialSkin

Public Class StartupPage

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
		Panel1.Width = 50
	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Do While Panel1.Width > 50
			Panel1.Width = Panel1.Width - 1
			Button2.Show()
		Loop
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Do While Panel1.Width < 440
			Panel1.Width = Panel1.Width + 1
			Button2.Hide()
		Loop
	End Sub

	Private Sub ToDashboard_Click(sender As Object, e As EventArgs) Handles ToDashboard.Click
		Dashboard.Show()
		Me.Hide()

	End Sub
End Class