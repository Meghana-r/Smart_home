Imports MaterialSkin

Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey800, Accent.Teal200, TextShade.WHITE)

	End Sub

	Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

	End Sub
End Class