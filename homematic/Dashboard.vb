Imports MaterialSkin
Public Class Dashboard
	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
		DashboardMenu.Width = 50
		ControlPanel.Hide()
	End Sub

	Private Sub MenuOpen_Click(sender As Object, e As EventArgs) Handles MenuOpen.Click
		Do While DashboardMenu.Width < 250
			DashboardMenu.Width = DashboardMenu.Width + 1
			MenuOpen.Hide()
			MenuClose.Show()
			LogoSmall.Hide()
		Loop
	End Sub

	Private Sub MenuClose_Click(sender As Object, e As EventArgs) Handles MenuClose.Click
		Do While DashboardMenu.Width > 50
			DashboardMenu.Width = DashboardMenu.Width - 1
			LogoSmall.Show()
			MenuOpen.Show()
			ControlPanel.Hide()
		Loop
	End Sub
	Private Sub DashboardBack_Click(sender As Object, e As EventArgs) Handles DashboardBack.Click
		Form1.Show()
		Me.Hide()

	End Sub

	Private Sub MasterBTN_Click(sender As Object, e As EventArgs) Handles MasterBTN.Click
		ControlPanel.Show()

	End Sub
End Class