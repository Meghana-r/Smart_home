Imports MaterialSkin

Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey800, Accent.Teal200, TextShade.WHITE)
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

    Private Sub Masterroombtn_Click(sender As Object, e As EventArgs) Handles Masterroombtn.Click
		RoomA.Show()
		Me.Hide()

	End Sub

	Private Sub ToDashboard_Click(sender As Object, e As EventArgs) Handles ToDashboard.Click
		Dashboard.Show()
		Me.Hide()
	End Sub

    Private Sub Room1btn_Click(sender As Object, e As EventArgs) Handles Room1btn.Click
        RoomB.Show()
        Me.Hide()
    End Sub

    Private Sub Room2btn_Click(sender As Object, e As EventArgs) Handles Room2btn.Click
        RoomC.Show()
        Me.Hide()
    End Sub

    Private Sub Livingbtn_Click(sender As Object, e As EventArgs) Handles Livingbtn.Click
        RoomD.Show()
        Me.Hide()
    End Sub

    Private Sub Bathroombtn_Click(sender As Object, e As EventArgs) Handles Bathroombtn.Click
        RoomE.Show()
        Me.Hide()
    End Sub
End Class