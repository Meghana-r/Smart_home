Imports MaterialSkin

Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey800, Accent.Teal200, TextShade.WHITE)
		Panel1.Width = 50
	End Sub

	Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

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
End Class