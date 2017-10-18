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
		For i As Integer = 0 To 5
			mypanel(i).Hide()
		Next
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
		Panel1.Hide()
		mypanel(0).Show()
		For i As Integer = 1 To 5
			mypanel(i).Hide()
		Next
	End Sub
	Private Sub DashboardLightsBtn_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
		Panel1.Show()
		ControlNameLbl.Text = "Lights"
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Master Room" & i + 1
		Next
		If RoomA.Room1Light1off.Checked = True Then
			mytext(0).Text = "OFF "
		Else
			mytext(0).Text = "ON"
		End If
		If RoomA.Room1Light2off.Checked = True Then
			mytext(1).Text = "OFF "
		Else
			mytext(1).Text = "ON"
		End If
		If RoomA.Room1Light3off.Checked = True Then
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
		ControlNameLbl.Text = "Appliances"
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance" & i + 1

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

	End Sub



	Private Sub DashboardClimateBtn_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
		Panel1.Show()
		ControlNameLbl.Text = "Climate"
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
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
		ControlNameLbl.Text = "Surveillance"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
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
	'////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Room1 controls end here
	'Room2 Controls start'
	'//////////////////////////////////////////////////////////////////////////////////////////////////////
	Private Sub DashboardRoom1BTN_Click(sender As Object, e As EventArgs) Handles DashboardRoom1BTN.Click
		mypanel(1).Show()
		Panel1.Hide()
		mypanel(0).Hide()

		For i As Integer = 2 To 5
			mypanel(i).Hide()
		Next
	End Sub
	Private Sub DashboardLightsBtn2_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn2.Click
		ControlNameLbl.Text = "Lights"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Room1 light" & i + 1
		Next
		If RoomB.Room2Light1off.Checked = True Then
			mytext(0).Text = "OFF "
		Else
			mytext(0).Text = "ON"
		End If
		If RoomB.Room2Light2off.Checked = True Then
			mytext(1).Text = "OFF "
		Else
			mytext(1).Text = "ON"
		End If
		If RoomB.Room2Light3off.Checked = True Then
			mytext(2).Text = "OFF "
		Else
			mytext(2).Text = "ON"
		End If
		For x As Integer = 3 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashboardAppBtn2_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn2.Click
		ControlNameLbl.Text = "Appliances"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance" & i + 1

		Next
		If RoomB.tvStatus = True Then
			mytext(0).Text = "ON"
		Else
			mytext(0).Text = "OFF"
		End If
		If RoomB.Room2Pw1Status = True Then
			mytext(1).Text = "ON"
		Else
			mytext(1).Text = "OFF"
		End If
		If RoomB.Room2Pw2Status = True Then
			mytext(2).Text = "ON"
		Else
			mytext(2).Text = "OFF"
		End If
		If RoomB.Room2Pw3Status = True Then
			mytext(3).Text = "ON"
		Else
			mytext(3).Text = "OFF"
		End If

	End Sub

	Private Sub DashboardClimateBtn2_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn2.Click
		ControlNameLbl.Text = "Climate"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		presenttxt(0).Text = "The temperature of the Room is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomB.Room2TempLbl.Text
		presenttxt(1).Text = "The humidity of the Room is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomB.Room2dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashBoardVideoBtn2_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn2.Click
		ControlNameLbl.Text = "Surveillance"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		If RoomB.Vidstat = True Then
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
	'//////////////////////////////////////////////////////////////////////////////////////////////////////
	'Room2 controls End
	'Room3 controls start
	'////////////////////////////////////////////////////////////////////////////////////////////////////
	Private Sub DashboardRoom2BTN_click(sender As Object, e As EventArgs) Handles DashboardRoom2BTN.Click
		mypanel(0).Hide()
		mypanel(1).Hide()
		mypanel(2).Show()
		Panel1.Hide()
		For i As Integer = 3 To 5
			mypanel(i).Hide()
		Next
	End Sub
	Private Sub Dashboardlightsbtn3_click(sender As Object, e As EventArgs) Handles DashboardLightsBtn3.Click
		ControlNameLbl.Text = "lights"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Room2 light" & i + 1

		Next
		If RoomC.Room3Light1off.Checked = True Then
			mytext(0).Text = "off "
		Else
			mytext(0).Text = "on"
		End If
		If RoomC.Room3Light2off.Checked = True Then
			mytext(1).Text = "off "
		Else
			mytext(1).Text = "on"
		End If
		If RoomC.Room3Light3off.Checked = True Then
			mytext(2).Text = "off "
		Else
			mytext(2).Text = "on"
		End If
		'loop

		For x As Integer = 3 To 4
			mytext(x).Hide()

		Next
	End Sub

	Private Sub DashboardAppBtn3_click(sender As Object, e As EventArgs) Handles DashboardAppBtn3.Click
		ControlNameLbl.Text = "Appliances"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance" & i + 1

		Next
		If RoomC.tvStatus = True Then
			mytext(0).Text = "on"
		Else
			mytext(0).Text = "off"
		End If
		If RoomC.Room3Pw1Status = True Then
			mytext(1).Text = "on"
		Else
			mytext(1).Text = "off"
		End If
		If RoomC.Room3Pw2Status = True Then
			mytext(2).Text = "on"
		Else
			mytext(2).Text = "off"
		End If
		If RoomC.Room3Pw3Status = True Then
			mytext(3).Text = "on"
		Else
			mytext(3).Text = "off"
		End If

	End Sub



	Private Sub DashboardClimateBtn3_click(sender As Object, e As EventArgs) Handles DashboardClimateBtn3.Click
		ControlNameLbl.Text = "climate"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		presenttxt(0).Text = "the temperature of the room is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomC.Room3TempLbl.Text
		presenttxt(1).Text = "the humidity of the room is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomC.Room3dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashboardVideoBtn3_click(sender As Object, e As EventArgs) Handles DashboardVideoBtn3.Click
		ControlNameLbl.Text = "surveillance"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		If RoomC.Vidstat = True Then
			presenttxt(0).Text = "the video is running"
		Else
			presenttxt(0).Text = "the video is turned off"
		End If
		presenttxt(0).AutoSize = True
		For i As Integer = 1 To 4
			presenttxt(i).Hide()

		Next
		For x As Integer = 0 To 4
			mytext(x).Hide()
		Next
	End Sub
	'////////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Room3 controls end
	'LIVING ROOM control begin
	'/////////////////////////////////////////////////////////////////////////////////////////////////////////////
	Private Sub dashboardlivingbtn_click(sender As Object, e As EventArgs) Handles DashboardLivingBTN.Click
		mypanel(3).Show()
		mypanel(4).Hide()
		mypanel(5).Hide()
		For i As Integer = 0 To 2
			mypanel(i).Hide()
		Next
	End Sub
	Private Sub DashboardLightsBtn4_click(sender As Object, e As EventArgs) Handles DashboardLightsBtn4.Click
		ControlNameLbl.Text = "lights"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "living room light" & i + 1

		Next
		If RoomD.Room4Light1off.Checked = True Then
			mytext(0).Text = "off "
		Else
			mytext(0).Text = "on"
		End If
		If RoomD.Room4Light2off.Checked = True Then
			mytext(1).Text = "off "
		Else
			mytext(1).Text = "on"
		End If
		If RoomD.Room4Light3off.Checked = True Then
			mytext(2).Text = "off "
		Else
			mytext(2).Text = "on"
		End If
		'loop

		For x As Integer = 3 To 4
			mytext(x).Hide()

		Next
	End Sub

	Private Sub DashboardAppBtn4_click(sender As Object, e As EventArgs) Handles DashboardAppBtn4.Click
		ControlNameLbl.Text = "appliances"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "appliance" & i + 1

		Next
		If RoomD.tvStatus = True Then
			mytext(0).Text = "on"
		Else
			mytext(0).Text = "off"
		End If
		If RoomD.Room4Pw1Status = True Then
			mytext(1).Text = "on"
		Else
			mytext(1).Text = "off"
		End If
		If RoomD.Room4Pw2Status = True Then
			mytext(2).Text = "on"
		Else
			mytext(2).Text = "off"
		End If
		If RoomD.Room4Pw3Status = True Then
			mytext(3).Text = "on"
		Else
			mytext(3).Text = "off"
		End If

	End Sub



	Private Sub DashboardClimateBtn4_click(sender As Object, e As EventArgs) Handles DashboardClimateBtn4.Click
		ControlNameLbl.Text = "climate"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		presenttxt(0).Text = "the temperature is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomD.Room4TempLbl.Text
		presenttxt(1).Text = "the humidity is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomC.Room3dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashboardVideoBtn4_click(sender As Object, e As EventArgs) Handles DashboardVideoBtn4.Click
		ControlNameLbl.Text = "surveillance"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		If RoomD.Vidstat = True Then
			presenttxt(0).Text = "the video is running"
		Else
			presenttxt(0).Text = "the video is turned off"
		End If
		presenttxt(0).AutoSize = True
		For i As Integer = 1 To 4
			presenttxt(i).Hide()

		Next
		For x As Integer = 0 To 4
			mytext(x).Hide()
		Next
	End Sub
	'////////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Living Roomcontrols end
	'Kitchen control begin
	'/////////////////////////////////////////////////////////////////////////////////////////////////////////////
	Private Sub DashboardKitchenBTN_Click(sender As Object, e As EventArgs) Handles DashboardKitchenBTN.Click
		mypanel(4).Show()
		mypanel(5).Hide()
		For i As Integer = 0 To 3
			mypanel(i).Hide()
		Next
	End Sub
	Private Sub Dashboardlightsbtn5_click(sender As Object, e As EventArgs) Handles DashboardLightsBtn5.Click
		ControlNameLbl.Text = "lights"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Kitchen Light" & i + 1

		Next
		If RoomE.Room5Light1off.Checked = True Then
			mytext(0).Text = "off "
		Else
			mytext(0).Text = "on"
		End If
		If RoomE.Room5Light2off.Checked = True Then
			mytext(1).Text = "off "
		Else
			mytext(1).Text = "on"
		End If
		If RoomE.Room5Light3off.Checked = True Then
			mytext(2).Text = "off "
		Else
			mytext(2).Text = "on"
		End If
		'loop

		For x As Integer = 3 To 4
			mytext(x).Hide()

		Next
	End Sub

	Private Sub DashboardAppBtn5_click(sender As Object, e As EventArgs) Handles DashboardAppBtn5.Click
		ControlNameLbl.Text = "Appliances"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()

		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance" & i + 1

		Next
		If RoomE.tvStatus = True Then
			mytext(0).Text = "on"
		Else
			mytext(0).Text = "off"
		End If
		If RoomE.Room5Pw1Status = True Then
			mytext(1).Text = "on"
		Else
			mytext(1).Text = "off"
		End If
		If RoomE.Room5Pw2Status = True Then
			mytext(2).Text = "on"
		Else
			mytext(2).Text = "off"
		End If
		If RoomE.Room5Pw3Status = True Then
			mytext(3).Text = "on"
		Else
			mytext(3).Text = "off"
		End If

	End Sub
	Private Sub DashboardClimateBtn5_click(sender As Object, e As EventArgs) Handles DashboardClimateBtn5.Click
		ControlNameLbl.Text = "climate"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		presenttxt(0).Text = "the temperature of the room is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomE.Room5TempLbl.Text
		presenttxt(1).Text = "the humidity of the room is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomC.Room3dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub
	'////////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Kitchen controls end
	'Bathroom control begin
	'/////////////////////////////////////////////////////////////////////////////////////////////////////////////
	Private Sub DashboardBathroomBTN_Click(sender As Object, e As EventArgs) Handles DashboardBathroomBTN.Click
		mypanel(5).Show()
		For i As Integer = 0 To 4
			mypanel(i).Hide()
		Next
	End Sub

	Private Sub Dashboardlightsbtn6_click(sender As Object, e As EventArgs) Handles DashboardLightsBtn6.Click
		ControlNameLbl.Text = "lights"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "BathroomLight" & i + 1

		Next
		If RoomF.Room6Light1off.Checked = True Then
			mytext(0).Text = "OFF "
		Else
			mytext(0).Text = "ON"
		End If
		If RoomF.Room6Light2off.Checked = True Then
			mytext(1).Text = "OFF "
		Else
			mytext(1).Text = "ON"
		End If
		If RoomF.Room6Light3off.Checked = True Then
			mytext(2).Text = "OFF "
		Else
			mytext(2).Text = "ON"
		End If
		For x As Integer = 3 To 4
			mytext(x).Hide()
		Next
	End Sub

	Private Sub DashboardAppBtn6_click(sender As Object, e As EventArgs) Handles DashboardAppBtn6.Click
		ControlNameLbl.Text = "Appliances"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		mytext(4).Hide()
		presenttxt(4).Hide()
		For i As Integer = 0 To 3
			presenttxt(i).Text = "Appliance" & i + 1

		Next
		If RoomF.tvStatus = True Then
			mytext(0).Text = "on"
		Else
			mytext(0).Text = "off"
		End If
		If RoomF.Room6Pw1Status = True Then
			mytext(1).Text = "on"
		Else
			mytext(1).Text = "off"
		End If
		If RoomF.Room6Pw2Status = True Then
			mytext(2).Text = "on"
		Else
			mytext(2).Text = "off"
		End If
		If RoomF.Room6Pw3Status = True Then
			mytext(3).Text = "on"
		Else
			mytext(3).Text = "off"
		End If

	End Sub
	Private Sub DashboardClimateBtn6_click(sender As Object, e As EventArgs) Handles DashboardClimateBtn6.Click
		ControlNameLbl.Text = "Climate"
		Panel1.Show()
		For z As Integer = 0 To 5
			mypanel(z).Hide()
		Next
		presenttxt(0).Text = "the temperature is"
		presenttxt(0).AutoSize = True
		mytext(0).Text = RoomF.Room6TempLbl.Text
		presenttxt(1).Text = "the humidity is "
		presenttxt(1).AutoSize = True
		mytext(1).Text = RoomF.Room6dhtTemp.Text
		For i As Integer = 2 To 4
			presenttxt(i).Hide()
		Next
		For x As Integer = 2 To 4
			mytext(x).Hide()
		Next
	End Sub


	'////////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Bathroom control end
	'/////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class