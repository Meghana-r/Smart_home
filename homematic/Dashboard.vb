Imports MaterialSkin
Public Class Dashboard

	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
		SkinManager.ColorScheme = New ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey700, Accent.Pink200, TextShade.WHITE)
		DashboardMenu.Width = 50
		ControlPanel.Hide()
		Panel1.Hide()
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
		Panel1.Hide()

	End Sub
	Private Sub DashboardLightsBtn_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
		Panel1.Show()
		ControlPanel.Hide()
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Room1 light" & i + 1

		Next

		If RoomA.Room1Light2Bri.Value = 0 Then
			mytext(0).Text = "OFF "
		Else
			mytext(0).Text = "ON"
		End If
		If RoomA.Room1Light1Bri.Value = 0 Then
			mytext(1).Text = "OFF "
		Else
			mytext(1).Text = "ON"
		End If
		If RoomA.Room1Light3Bri.Value = 0 Then
			mytext(2).Text = "OFF "
		Else
			mytext(2).Text = "ON"
		End If
		For x As Integer = 3 To 4
			mytext(x).Hide()

		Next
	End Sub

	Private Sub DashboardAppBtn_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
		Panel1.Show()
		ControlPanel.Hide()

		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance Status" & i + 1

		Next
		If RoomA.tvStatus = True Then
			mytext(0).Text = "ON"
		Else
			mytext(0).Text = "OFF"
		End If
		If RoomA.Room1Pw1Status = True Then
			mytext(1).Text = "ON"
		Else
			mytext(1).Text = "OFF"
		End If
		If RoomA.Room1Pw2Status = True Then
			mytext(2).Text = "ON"
		Else
			mytext(2).Text = "OFF"
		End If
		If RoomA.Room1Pw3Status = True Then
			mytext(3).Text = "ON"
		Else
			mytext(3).Text = "OFF"
		End If
		mytext(4).Hide()
	End Sub

	Private Sub PanelBackBtn_Click(sender As Object, e As EventArgs) Handles PanelBackBtn.Click
		ControlPanel.Show()
		Panel1.Hide()
	End Sub

	Private Sub DashboardClimateBtn_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
		Panel1.Show()
		ControlPanel.Hide()

		presenttxt(0).Text = "The temperature of the Room is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomA.Room1TempLbl.Text
		presenttxt(1).Text = "The humidity of the Room is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomA.Room1dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashBoardVideoBtn_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn.Click
		Panel1.Show()
		ControlPanel.Hide()
		If RoomA.VidStat = True Then
			presenttxt(0).Text = "The video is running"
		Else
			presenttxt(0).Text = "The video is turned off"
		End If
		presenttxt(0).AutoSize = True
		For i As Integer = 1 To 4
			presenttxt(i).Hide()

		Next
		For x As Integer = 0 To 4
			mytext(x).Hide()
		Next
	End Sub

End Class