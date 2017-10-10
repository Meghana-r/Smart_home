Imports MaterialSkin

Public Class Form1
	'Private Sub Button1_Click(sender As Object, e As EventArgs)
	'	Me.Close()

	'End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Teal200, TextShade.WHITE)

	End Sub
End Class