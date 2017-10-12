<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
	Inherits MaterialSkin.Controls.MaterialForm


	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.DashboardMenu = New System.Windows.Forms.Panel()
		Me.LogoSmall = New System.Windows.Forms.PictureBox()
		Me.LogoBig = New System.Windows.Forms.PictureBox()
		Me.DashboardBathroomBTN = New System.Windows.Forms.Button()
		Me.DashboardLivingBTN = New System.Windows.Forms.Button()
		Me.DashboardKitchenBTN = New System.Windows.Forms.Button()
		Me.DashboardRoom2BTN = New System.Windows.Forms.Button()
		Me.DashboardRoom1BTN = New System.Windows.Forms.Button()
		Me.MasterBTN = New System.Windows.Forms.Button()
		Me.MenuClose = New System.Windows.Forms.Button()
		Me.MenuOpen = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DashboardBack = New System.Windows.Forms.Button()
		Me.ControlPanel = New System.Windows.Forms.Panel()
		Me.DashboardClimateBtn = New System.Windows.Forms.Button()
		Me.DashBoardVideoBtn = New System.Windows.Forms.Button()
		Me.DashboardAppBtn = New System.Windows.Forms.Button()
		Me.DashboardLightsBtn = New System.Windows.Forms.Button()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.DashboardMenu.SuspendLayout()
		CType(Me.LogoSmall, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogoBig, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ControlPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'DashboardMenu
		'
		Me.DashboardMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.DashboardMenu.BackColor = System.Drawing.Color.Transparent
		Me.DashboardMenu.BackgroundImage = Global.homematic.My.Resources.Resources.Panelnew
		Me.DashboardMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardMenu.Controls.Add(Me.LogoSmall)
		Me.DashboardMenu.Controls.Add(Me.LogoBig)
		Me.DashboardMenu.Controls.Add(Me.DashboardBathroomBTN)
		Me.DashboardMenu.Controls.Add(Me.DashboardLivingBTN)
		Me.DashboardMenu.Controls.Add(Me.DashboardKitchenBTN)
		Me.DashboardMenu.Controls.Add(Me.DashboardRoom2BTN)
		Me.DashboardMenu.Controls.Add(Me.DashboardRoom1BTN)
		Me.DashboardMenu.Controls.Add(Me.MasterBTN)
		Me.DashboardMenu.Controls.Add(Me.MenuClose)
		Me.DashboardMenu.Controls.Add(Me.MenuOpen)
		Me.DashboardMenu.Location = New System.Drawing.Point(0, 63)
		Me.DashboardMenu.Name = "DashboardMenu"
		Me.DashboardMenu.Size = New System.Drawing.Size(235, 465)
		Me.DashboardMenu.TabIndex = 0
		'
		'LogoSmall
		'
		Me.LogoSmall.BackgroundImage = Global.homematic.My.Resources.Resources.homelogo
		Me.LogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.LogoSmall.Location = New System.Drawing.Point(3, 43)
		Me.LogoSmall.Name = "LogoSmall"
		Me.LogoSmall.Size = New System.Drawing.Size(45, 45)
		Me.LogoSmall.TabIndex = 9
		Me.LogoSmall.TabStop = False
		'
		'LogoBig
		'
		Me.LogoBig.BackgroundImage = Global.homematic.My.Resources.Resources.homelogo
		Me.LogoBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.LogoBig.Location = New System.Drawing.Point(78, 43)
		Me.LogoBig.Name = "LogoBig"
		Me.LogoBig.Size = New System.Drawing.Size(80, 80)
		Me.LogoBig.TabIndex = 8
		Me.LogoBig.TabStop = False
		'
		'DashboardBathroomBTN
		'
		Me.DashboardBathroomBTN.FlatAppearance.BorderSize = 0
		Me.DashboardBathroomBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.DashboardBathroomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardBathroomBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardBathroomBTN.Location = New System.Drawing.Point(0, 401)
		Me.DashboardBathroomBTN.Name = "DashboardBathroomBTN"
		Me.DashboardBathroomBTN.Size = New System.Drawing.Size(234, 41)
		Me.DashboardBathroomBTN.TabIndex = 7
		Me.DashboardBathroomBTN.Text = "BathRoom"
		Me.DashboardBathroomBTN.UseVisualStyleBackColor = True
		'
		'DashboardLivingBTN
		'
		Me.DashboardLivingBTN.FlatAppearance.BorderSize = 0
		Me.DashboardLivingBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.DashboardLivingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardLivingBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardLivingBTN.Location = New System.Drawing.Point(0, 354)
		Me.DashboardLivingBTN.Name = "DashboardLivingBTN"
		Me.DashboardLivingBTN.Size = New System.Drawing.Size(234, 41)
		Me.DashboardLivingBTN.TabIndex = 6
		Me.DashboardLivingBTN.Text = "Living Room"
		Me.DashboardLivingBTN.UseVisualStyleBackColor = True
		'
		'DashboardKitchenBTN
		'
		Me.DashboardKitchenBTN.FlatAppearance.BorderSize = 0
		Me.DashboardKitchenBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.DashboardKitchenBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardKitchenBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardKitchenBTN.Location = New System.Drawing.Point(0, 307)
		Me.DashboardKitchenBTN.Name = "DashboardKitchenBTN"
		Me.DashboardKitchenBTN.Size = New System.Drawing.Size(234, 41)
		Me.DashboardKitchenBTN.TabIndex = 5
		Me.DashboardKitchenBTN.Text = "Kitchen"
		Me.DashboardKitchenBTN.UseVisualStyleBackColor = True
		'
		'DashboardRoom2BTN
		'
		Me.DashboardRoom2BTN.FlatAppearance.BorderSize = 0
		Me.DashboardRoom2BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.DashboardRoom2BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardRoom2BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardRoom2BTN.Location = New System.Drawing.Point(0, 260)
		Me.DashboardRoom2BTN.Name = "DashboardRoom2BTN"
		Me.DashboardRoom2BTN.Size = New System.Drawing.Size(234, 41)
		Me.DashboardRoom2BTN.TabIndex = 4
		Me.DashboardRoom2BTN.Text = "Room 2"
		Me.DashboardRoom2BTN.UseVisualStyleBackColor = True
		'
		'DashboardRoom1BTN
		'
		Me.DashboardRoom1BTN.FlatAppearance.BorderSize = 0
		Me.DashboardRoom1BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.DashboardRoom1BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardRoom1BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardRoom1BTN.Location = New System.Drawing.Point(0, 213)
		Me.DashboardRoom1BTN.Name = "DashboardRoom1BTN"
		Me.DashboardRoom1BTN.Size = New System.Drawing.Size(234, 41)
		Me.DashboardRoom1BTN.TabIndex = 3
		Me.DashboardRoom1BTN.Text = "Room 1"
		Me.DashboardRoom1BTN.UseVisualStyleBackColor = True
		'
		'MasterBTN
		'
		Me.MasterBTN.FlatAppearance.BorderSize = 0
		Me.MasterBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.MasterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MasterBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MasterBTN.Location = New System.Drawing.Point(0, 166)
		Me.MasterBTN.Name = "MasterBTN"
		Me.MasterBTN.Size = New System.Drawing.Size(234, 41)
		Me.MasterBTN.TabIndex = 2
		Me.MasterBTN.Text = "Master Room"
		Me.MasterBTN.UseVisualStyleBackColor = True
		'
		'MenuClose
		'
		Me.MenuClose.BackgroundImage = Global.homematic.My.Resources.Resources.menudashboard
		Me.MenuClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MenuClose.FlatAppearance.BorderSize = 0
		Me.MenuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MenuClose.Location = New System.Drawing.Point(195, 17)
		Me.MenuClose.Name = "MenuClose"
		Me.MenuClose.Size = New System.Drawing.Size(20, 20)
		Me.MenuClose.TabIndex = 1
		Me.MenuClose.UseVisualStyleBackColor = True
		'
		'MenuOpen
		'
		Me.MenuOpen.BackgroundImage = Global.homematic.My.Resources.Resources.menudashboard
		Me.MenuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MenuOpen.FlatAppearance.BorderSize = 0
		Me.MenuOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MenuOpen.Location = New System.Drawing.Point(15, 17)
		Me.MenuOpen.Name = "MenuOpen"
		Me.MenuOpen.Size = New System.Drawing.Size(20, 20)
		Me.MenuOpen.TabIndex = 0
		Me.MenuOpen.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
		Me.Label1.Location = New System.Drawing.Point(3, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(186, 39)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Dashboard"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'DashboardBack
		'
		Me.DashboardBack.BackColor = System.Drawing.Color.Transparent
		Me.DashboardBack.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
		Me.DashboardBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.DashboardBack.FlatAppearance.BorderSize = 0
		Me.DashboardBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardBack.Location = New System.Drawing.Point(1, 3)
		Me.DashboardBack.Name = "DashboardBack"
		Me.DashboardBack.Size = New System.Drawing.Size(15, 15)
		Me.DashboardBack.TabIndex = 2
		Me.DashboardBack.UseVisualStyleBackColor = False
		'
		'ControlPanel
		'
		Me.ControlPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ControlPanel.Controls.Add(Me.DashboardClimateBtn)
		Me.ControlPanel.Controls.Add(Me.DashBoardVideoBtn)
		Me.ControlPanel.Controls.Add(Me.DashboardAppBtn)
		Me.ControlPanel.Controls.Add(Me.DashboardLightsBtn)
		Me.ControlPanel.Location = New System.Drawing.Point(236, 63)
		Me.ControlPanel.Name = "ControlPanel"
		Me.ControlPanel.Size = New System.Drawing.Size(534, 464)
		Me.ControlPanel.TabIndex = 3
		'
		'DashboardClimateBtn
		'
		Me.DashboardClimateBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.DashboardClimateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardClimateBtn.FlatAppearance.BorderSize = 0
		Me.DashboardClimateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DashboardClimateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardClimateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardClimateBtn.Location = New System.Drawing.Point(37, 302)
		Me.DashboardClimateBtn.Name = "DashboardClimateBtn"
		Me.DashboardClimateBtn.Size = New System.Drawing.Size(160, 140)
		Me.DashboardClimateBtn.TabIndex = 3
		Me.DashboardClimateBtn.Text = "Climate"
		Me.DashboardClimateBtn.UseVisualStyleBackColor = True
		'
		'DashBoardVideoBtn
		'
		Me.DashBoardVideoBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.DashBoardVideoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashBoardVideoBtn.FlatAppearance.BorderSize = 0
		Me.DashBoardVideoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DashBoardVideoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashBoardVideoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashBoardVideoBtn.Location = New System.Drawing.Point(371, 302)
		Me.DashBoardVideoBtn.Name = "DashBoardVideoBtn"
		Me.DashBoardVideoBtn.Size = New System.Drawing.Size(160, 140)
		Me.DashBoardVideoBtn.TabIndex = 2
		Me.DashBoardVideoBtn.Text = "Surveillance"
		Me.DashBoardVideoBtn.UseVisualStyleBackColor = True
		'
		'DashboardAppBtn
		'
		Me.DashboardAppBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.DashboardAppBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardAppBtn.FlatAppearance.BorderSize = 0
		Me.DashboardAppBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DashboardAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardAppBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardAppBtn.Location = New System.Drawing.Point(371, 43)
		Me.DashboardAppBtn.Name = "DashboardAppBtn"
		Me.DashboardAppBtn.Size = New System.Drawing.Size(160, 140)
		Me.DashboardAppBtn.TabIndex = 1
		Me.DashboardAppBtn.Text = "Appliances"
		Me.DashboardAppBtn.UseVisualStyleBackColor = True
		'
		'DashboardLightsBtn
		'
		Me.DashboardLightsBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.DashboardLightsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardLightsBtn.FlatAppearance.BorderSize = 0
		Me.DashboardLightsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DashboardLightsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardLightsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardLightsBtn.Location = New System.Drawing.Point(37, 41)
		Me.DashboardLightsBtn.Name = "DashboardLightsBtn"
		Me.DashboardLightsBtn.Size = New System.Drawing.Size(160, 140)
		Me.DashboardLightsBtn.TabIndex = 0
		Me.DashboardLightsBtn.Text = "Lights"
		Me.DashboardLightsBtn.UseVisualStyleBackColor = True
		'
		'TabControl1
		'
		Me.TabControl1.Location = New System.Drawing.Point(236, 65)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(528, 459)
		Me.TabControl1.TabIndex = 4
		'
		'Dashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(769, 529)
		Me.Controls.Add(Me.ControlPanel)
		Me.Controls.Add(Me.DashboardBack)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DashboardMenu)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Dashboard"
		Me.DashboardMenu.ResumeLayout(False)
		CType(Me.LogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LogoBig, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ControlPanel.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DashboardMenu As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents MenuOpen As Button
	Friend WithEvents MenuClose As Button
	Friend WithEvents DashboardBack As Button
	Friend WithEvents DashboardBathroomBTN As Button
	Friend WithEvents DashboardLivingBTN As Button
	Friend WithEvents DashboardKitchenBTN As Button
	Friend WithEvents DashboardRoom2BTN As Button
	Friend WithEvents DashboardRoom1BTN As Button
	Friend WithEvents MasterBTN As Button
	Friend WithEvents LogoBig As PictureBox
	Friend WithEvents LogoSmall As PictureBox
	Friend WithEvents ControlPanel As Panel
	Friend WithEvents DashboardLightsBtn As Button
	Friend WithEvents DashboardClimateBtn As Button
	Friend WithEvents DashBoardVideoBtn As Button
	Friend WithEvents DashboardAppBtn As Button
	Friend WithEvents TabControl1 As TabControl
End Class
