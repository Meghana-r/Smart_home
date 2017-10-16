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
		Panel1.Hide()
		mypanel(0).Show()
		Panel1.Hide()
		For i As Integer = 1 To 5
			mypanel(i).Hide()
		Next
	End Sub

	Private Sub DashboardLightsBtn_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
		ControlNameLbl.Text = "Lights"
		Panel1.Show()
		ControlPanel.Hide()
		For y As Integer = 3 To 4
			presenttxt(y).Hide()
		Next
		For i As Integer = 0 To 2
			presenttxt(i).Text = "Room1 light" & i + 1

		Next
		'Do While RoomA.Room1Light1Bri.Value >= 0
		If RoomA.Room1Light1Bri.Value = 0 Then
				mytext(0).Text = "OFF "
			Else
				mytext(0).Text = "ON"
			End If
		'Loop
		'Do While RoomA.Room1Light2Bri.Value >= 0
		If RoomA.Room1Light2Bri.Value = 0 Then
				mytext(1).Text = "OFF "
			Else
				mytext(1).Text = "ON"
			End If
		'Loop
		'Do While RoomA.Room1Light3Bri.Value >= 0
		If RoomA.Room1Light3Bri.Value = 0 Then
				mytext(2).Text = "OFF "
			Else
				mytext(2).Text = "ON"
			End If
		'Loop

		For x As Integer = 3 To 4
			mytext(x).Hide()

		Next
	End Sub

	Private Sub DashboardAppBtn_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
		ControlNameLbl.Text = "Appliances"
		Panel1.Show()
		ControlPanel.Hide()
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

	Private Sub PanelBackBtn_Click(sender As Object, e As EventArgs) Handles PanelBackBtn.Click
		ControlPanel.Show()
		Panel1.Hide()
	End Sub

	Private Sub DashboardClimateBtn_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
		ControlNameLbl.Text = "Climate"
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
		ControlNameLbl.Text = "Surveillance"
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

	Private Sub DashboardRoom1BTN_Click(sender As Object, e As EventArgs) Handles DashboardRoom1BTN.Click
		mypanel(1).Show()
		Panel1.Hide()
		mypanel(0).Hide()

		For i As Integer = 2 To 5
			mypanel(i).Hide()
		Next
		'MasterBtnChecked = False

	End Sub
	'////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Room1 controls end here
	'Room2 Controls start'
	'//////////////////////////////////////////////////////////////////////////////////////////////////////
	'Private Sub DashboardLightsBtn2_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
	'	ControlNameLbl.Text = "Lights"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	For y As Integer = 3 To 4
	'		presenttxt(y).Hide()
	'	Next
	'	For i As Integer = 0 To 2
	'		presenttxt(i).Text = "Room1 light" & i + 1

	'	Next
	'	'Do While RoomA.Room1Light1Bri.Value >= 0
	'	If RoomB.Room2Light1Bri.Value = 0 Then
	'		mytext(0).Text = "OFF "
	'	Else
	'		mytext(0).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light2Bri.Value >= 0
	'	If RoomB.Room2Light2Bri.Value = 0 Then
	'		mytext(1).Text = "OFF "
	'	Else
	'		mytext(1).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light3Bri.Value >= 0
	'	If RoomB.Room2Light3Bri.Value = 0 Then
	'		mytext(2).Text = "OFF "
	'	Else
	'		mytext(2).Text = "ON"
	'	End If
	'	'Loop

	'	For x As Integer = 3 To 4
	'		mytext(x).Hide()

	'	Next
	'End Sub

	'Private Sub DashboardAppBtn2_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
	'	ControlNameLbl.Text = "Appliances"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	mytext(4).Hide()
	'	presenttxt(4).Hide()

	'	For i As Integer = 0 To 3
	'		presenttxt(i).Text = "Appliance" & i + 1

	'	Next
	'	If RoomB.tvStatus = True Then
	'		mytext(0).Text = "ON"
	'	Else
	'		mytext(0).Text = "OFF"
	'	End If
	'	If RoomB.Room3Pw1Status = True Then
	'		mytext(1).Text = "ON"
	'	Else
	'		mytext(1).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw2Status = True Then
	'		mytext(2).Text = "ON"
	'	Else
	'		mytext(2).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw3Status = True Then
	'		mytext(3).Text = "ON"
	'	Else
	'		mytext(3).Text = "OFF"
	'	End If

	'End Sub

	'Private Sub DashboardClimateBtn2_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
	'	ControlNameLbl.Text = "Climate"
	'	Panel1.Show()
	'	ControlPanel.Hide()

	'	presenttxt(0).Text = "The temperature of the Room is"
	'	presenttxt(0).AutoSize = True
	'	mytext(0).Text = RoomA.Room1TempLbl.Text
	'	presenttxt(1).Text = "The humidity of the Room is "
	'	presenttxt(1).AutoSize = True
	'	mytext(1).Text = RoomA.Room1dhtTemp.Text
	'	For i As Integer = 2 To 4
	'		presenttxt(i).Hide()
	'	Next
	'	For x As Integer = 2 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub

	'Private Sub DashBoardVideoBtn2_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn.Click
	'	ControlNameLbl.Text = "Surveillance"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	If RoomA.VidStat = True Then
	'		presenttxt(0).Text = "The video is running"
	'	Else
	'		presenttxt(0).Text = "The video is turned off"
	'	End If
	'	presenttxt(0).AutoSize = True
	'	For i As Integer = 1 To 4
	'		presenttxt(i).Hide()

	'	Next
	'	For x As Integer = 0 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub
	''//////////////////////////////////////////////////////////////////////////////////////////////////////
	''Room2 controls End
	''Room3 controls start
	''////////////////////////////////////////////////////////////////////////////////////////////////////
	'Private Sub DashboardRoom2BTN_Click(sender As Object, e As EventArgs) Handles DashboardRoom2BTN.Click
	'	mypanel(0).Hide()
	'	mypanel(1).Hide()
	'	mypanel(2).Show()
	'	Panel1.Hide()
	'	For i As Integer = 3 To 5
	'		mypanel(i).Hide()
	'	Next
	'End Sub
	'Private Sub DashboardLightsBtn3_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
	'	ControlNameLbl.Text = "Lights"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	For y As Integer = 3 To 4
	'		presenttxt(y).Hide()
	'	Next
	'	For i As Integer = 0 To 2
	'		presenttxt(i).Text = "Room1 light" & i + 1

	'	Next
	'	'Do While RoomA.Room1Light1Bri.Value >= 0
	'	If RoomA.Room1Light1Bri.Value = 0 Then
	'		mytext(0).Text = "OFF "
	'	Else
	'		mytext(0).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light2Bri.Value >= 0
	'	If RoomA.Room1Light2Bri.Value = 0 Then
	'		mytext(1).Text = "OFF "
	'	Else
	'		mytext(1).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light3Bri.Value >= 0
	'	If RoomA.Room1Light3Bri.Value = 0 Then
	'		mytext(2).Text = "OFF "
	'	Else
	'		mytext(2).Text = "ON"
	'	End If
	'	'Loop

	'	For x As Integer = 3 To 4
	'		mytext(x).Hide()

	'	Next
	'End Sub

	'Private Sub DashboardAppBtn3_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
	'	ControlNameLbl.Text = "Appliances"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	mytext(4).Hide()
	'	presenttxt(4).Hide()

	'	For i As Integer = 0 To 3
	'		presenttxt(i).Text = "Appliance" & i + 1

	'	Next
	'	If RoomA.tvStatus = True Then
	'		mytext(0).Text = "ON"
	'	Else
	'		mytext(0).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw1Status = True Then
	'		mytext(1).Text = "ON"
	'	Else
	'		mytext(1).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw2Status = True Then
	'		mytext(2).Text = "ON"
	'	Else
	'		mytext(2).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw3Status = True Then
	'		mytext(3).Text = "ON"
	'	Else
	'		mytext(3).Text = "OFF"
	'	End If

	'End Sub



	'Private Sub DashboardClimateBtn3_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
	'	ControlNameLbl.Text = "Climate"
	'	Panel1.Show()
	'	ControlPanel.Hide()

	'	presenttxt(0).Text = "The temperature of the Room is"
	'	presenttxt(0).AutoSize = True
	'	mytext(0).Text = RoomA.Room1TempLbl.Text
	'	presenttxt(1).Text = "The humidity of the Room is "
	'	presenttxt(1).AutoSize = True
	'	mytext(1).Text = RoomA.Room1dhtTemp.Text
	'	For i As Integer = 2 To 4
	'		presenttxt(i).Hide()
	'	Next
	'	For x As Integer = 2 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub

	'Private Sub DashBoardVideoBtn3_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn.Click
	'	ControlNameLbl.Text = "Surveillance"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	If RoomA.VidStat = True Then
	'		presenttxt(0).Text = "The video is running"
	'	Else
	'		presenttxt(0).Text = "The video is turned off"
	'	End If
	'	presenttxt(0).AutoSize = True
	'	For i As Integer = 1 To 4
	'		presenttxt(i).Hide()

	'	Next
	'	For x As Integer = 0 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub
	''////////////////////////////////////////////////////////////////////////////////////////////////////////////
	''Room3 controls end
	''Room4 control begin
	''/////////////////////////////////////////////////////////////////////////////////////////////////////////////
	'Private Sub DashboardKitchenBTN_Click(sender As Object, e As EventArgs) Handles DashboardKitchenBTN.Click
	'	mypanel(5).Hide()
	'	mypanel(4).Hide()
	'	mypanel(3).Show()
	'	Panel1.Hide()
	'	For i As Integer = 0 To 2
	'		mypanel(i).Hide()
	'	Next
	'End Sub

	'Private Sub DashboardLightsBtn4_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
	'	ControlNameLbl.Text = "Lights"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	For y As Integer = 3 To 4
	'		presenttxt(y).Hide()
	'	Next
	'	For i As Integer = 0 To 2
	'		presenttxt(i).Text = "Room1 light" & i + 1

	'	Next
	'	'Do While RoomA.Room1Light1Bri.Value >= 0
	'	If RoomA.Room1Light1Bri.Value = 0 Then
	'		mytext(0).Text = "OFF "
	'	Else
	'		mytext(0).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light2Bri.Value >= 0
	'	If RoomA.Room1Light2Bri.Value = 0 Then
	'		mytext(1).Text = "OFF "
	'	Else
	'		mytext(1).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light3Bri.Value >= 0
	'	If RoomA.Room1Light3Bri.Value = 0 Then
	'		mytext(2).Text = "OFF "
	'	Else
	'		mytext(2).Text = "ON"
	'	End If
	'	'Loop

	'	For x As Integer = 3 To 4
	'		mytext(x).Hide()

	'	Next
	'End Sub

	'Private Sub DashboardAppBtn4_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
	'	ControlNameLbl.Text = "Appliances"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	mytext(4).Hide()
	'	presenttxt(4).Hide()

	'	For i As Integer = 0 To 3
	'		presenttxt(i).Text = "Appliance" & i + 1

	'	Next
	'	If RoomA.tvStatus = True Then
	'		mytext(0).Text = "ON"
	'	Else
	'		mytext(0).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw1Status = True Then
	'		mytext(1).Text = "ON"
	'	Else
	'		mytext(1).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw2Status = True Then
	'		mytext(2).Text = "ON"
	'	Else
	'		mytext(2).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw3Status = True Then
	'		mytext(3).Text = "ON"
	'	Else
	'		mytext(3).Text = "OFF"
	'	End If

	'End Sub



	'Private Sub DashboardClimateBtn4_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
	'	ControlNameLbl.Text = "Climate"
	'	Panel1.Show()
	'	ControlPanel.Hide()

	'	presenttxt(0).Text = "The temperature of the Room is"
	'	presenttxt(0).AutoSize = True
	'	mytext(0).Text = RoomA.Room1TempLbl.Text
	'	presenttxt(1).Text = "The humidity of the Room is "
	'	presenttxt(1).AutoSize = True
	'	mytext(1).Text = RoomA.Room1dhtTemp.Text
	'	For i As Integer = 2 To 4
	'		presenttxt(i).Hide()
	'	Next
	'	For x As Integer = 2 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub

	'Private Sub DashBoardVideoBtn4_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn.Click
	'	ControlNameLbl.Text = "Surveillance"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	If RoomA.VidStat = True Then
	'		presenttxt(0).Text = "The video is running"
	'	Else
	'		presenttxt(0).Text = "The video is turned off"
	'	End If
	'	presenttxt(0).AutoSize = True
	'	For i As Integer = 1 To 4
	'		presenttxt(i).Hide()

	'	Next
	'	For x As Integer = 0 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub
	''/////////////////////////////////////////////////////////////////////////////////////////
	''Room4 controls end here
	''Room5 controls start here
	''/////////////////////////////////////////////////////////////////////////////////////////
	'Private Sub DashboardLivingBTN_Click(sender As Object, e As EventArgs) Handles DashboardLivingBTN.Click

	'	mypanel(5).Hide()
	'	mypanel(4).Show()
	'	Panel1.Hide()
	'	For i As Integer = 0 To 3
	'		mypanel(i).Hide()
	'	Next
	'End Sub
	'Private Sub DashboardLightsBtn5_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
	'	ControlNameLbl.Text = "Lights"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	For y As Integer = 3 To 4
	'		presenttxt(y).Hide()
	'	Next
	'	For i As Integer = 0 To 2
	'		presenttxt(i).Text = "Room1 light" & i + 1

	'	Next
	'	'Do While RoomA.Room1Light1Bri.Value >= 0
	'	If RoomA.Room1Light1Bri.Value = 0 Then
	'		mytext(0).Text = "OFF "
	'	Else
	'		mytext(0).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light2Bri.Value >= 0
	'	If RoomA.Room1Light2Bri.Value = 0 Then
	'		mytext(1).Text = "OFF "
	'	Else
	'		mytext(1).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light3Bri.Value >= 0
	'	If RoomA.Room1Light3Bri.Value = 0 Then
	'		mytext(2).Text = "OFF "
	'	Else
	'		mytext(2).Text = "ON"
	'	End If
	'	'Loop

	'	For x As Integer = 3 To 4
	'		mytext(x).Hide()

	'	Next
	'End Sub

	'Private Sub DashboardAppBtn5_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
	'	ControlNameLbl.Text = "Appliances"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	mytext(4).Hide()
	'	presenttxt(4).Hide()

	'	For i As Integer = 0 To 3
	'		presenttxt(i).Text = "Appliance" & i + 1

	'	Next
	'	If RoomA.tvStatus = True Then
	'		mytext(0).Text = "ON"
	'	Else
	'		mytext(0).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw1Status = True Then
	'		mytext(1).Text = "ON"
	'	Else
	'		mytext(1).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw2Status = True Then
	'		mytext(2).Text = "ON"
	'	Else
	'		mytext(2).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw3Status = True Then
	'		mytext(3).Text = "ON"
	'	Else
	'		mytext(3).Text = "OFF"
	'	End If

	'End Sub



	'Private Sub DashboardClimateBtn5_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
	'	ControlNameLbl.Text = "Climate"
	'	Panel1.Show()
	'	ControlPanel.Hide()

	'	presenttxt(0).Text = "The temperature of the Room is"
	'	presenttxt(0).AutoSize = True
	'	mytext(0).Text = RoomA.Room1TempLbl.Text
	'	presenttxt(1).Text = "The humidity of the Room is "
	'	presenttxt(1).AutoSize = True
	'	mytext(1).Text = RoomA.Room1dhtTemp.Text
	'	For i As Integer = 2 To 4
	'		presenttxt(i).Hide()
	'	Next
	'	For x As Integer = 2 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub

	'Private Sub DashBoardVideoBtn5_Click(sender As Object, e As EventArgs) Handles DashBoardVideoBtn.Click
	'	ControlNameLbl.Text = "Surveillance"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	If RoomA.VidStat = True Then
	'		presenttxt(0).Text = "The video is running"
	'	Else
	'		presenttxt(0).Text = "The video is turned off"
	'	End If
	'	presenttxt(0).AutoSize = True
	'	For i As Integer = 1 To 4
	'		presenttxt(i).Hide()

	'	Next
	'	For x As Integer = 0 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub
	''//////////////////////////////////////////////////////////////////////////////////////////
	''Room5 Controls end
	''Room6 controls begin
	''///////////////////////////////////////////////////////////////////////////////////////////
	'Private Sub DashboardBathroomBTN_Click(sender As Object, e As EventArgs) Handles MyBaseBathroomBTN.Click
	'	mypanel(5).Show()
	'	Panel1.Hide()
	'	For i As Integer = 0 To 4
	'		mypanel(i).Hide()
	'	Next
	'End Sub
	'Private Sub DashboardLightsBtn6_Click(sender As Object, e As EventArgs) Handles DashboardLightsBtn.Click
	'	ControlNameLbl.Text = "Lights"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	For y As Integer = 3 To 4
	'		presenttxt(y).Hide()
	'	Next
	'	For i As Integer = 0 To 2
	'		presenttxt(i).Text = "Room1 light" & i + 1

	'	Next
	'	'Do While RoomA.Room1Light1Bri.Value >= 0
	'	If RoomA.Room1Light1Bri.Value = 0 Then
	'		mytext(0).Text = "OFF "
	'	Else
	'		mytext(0).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light2Bri.Value >= 0
	'	If RoomA.Room1Light2Bri.Value = 0 Then
	'		mytext(1).Text = "OFF "
	'	Else
	'		mytext(1).Text = "ON"
	'	End If
	'	'Loop
	'	'Do While RoomA.Room1Light3Bri.Value >= 0
	'	If RoomA.Room1Light3Bri.Value = 0 Then
	'		mytext(2).Text = "OFF "
	'	Else
	'		mytext(2).Text = "ON"
	'	End If
	'	'Loop

	'	For x As Integer = 3 To 4
	'		mytext(x).Hide()

	'	Next
	'End Sub

	'Private Sub DashboardAppBtn6_Click(sender As Object, e As EventArgs) Handles DashboardAppBtn.Click
	'	ControlNameLbl.Text = "Appliances"
	'	Panel1.Show()
	'	ControlPanel.Hide()
	'	mytext(4).Hide()
	'	presenttxt(4).Hide()

	'	For i As Integer = 0 To 3
	'		presenttxt(i).Text = "Appliance" & i + 1

	'	Next
	'	If RoomA.tvStatus = True Then
	'		mytext(0).Text = "ON"
	'	Else
	'		mytext(0).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw1Status = True Then
	'		mytext(1).Text = "ON"
	'	Else
	'		mytext(1).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw2Status = True Then
	'		mytext(2).Text = "ON"
	'	Else
	'		mytext(2).Text = "OFF"
	'	End If
	'	If RoomA.Room1Pw3Status = True Then
	'		mytext(3).Text = "ON"
	'	Else
	'		mytext(3).Text = "OFF"
	'	End If

	'End Sub



	'Private Sub DashboardClimateBtn6_Click(sender As Object, e As EventArgs) Handles DashboardClimateBtn.Click
	'	ControlNameLbl.Text = "Climate"
	'	Panel1.Show()
	'	ControlPanel.Hide()

	'	presenttxt(0).Text = "The temperature of the Room is"
	'	presenttxt(0).AutoSize = True
	'	mytext(0).Text = RoomA.Room1TempLbl.Text
	'	presenttxt(1).Text = "The humidity of the Room is "
	'	presenttxt(1).AutoSize = True
	'	mytext(1).Text = RoomA.Room1dhtTemp.Text
	'	For i As Integer = 2 To 4
	'		presenttxt(i).Hide()
	'	Next
	'	For x As Integer = 2 To 4
	'		mytext(x).Hide()
	'	Next
	'End Sub
	''Room6 controls end


End Class