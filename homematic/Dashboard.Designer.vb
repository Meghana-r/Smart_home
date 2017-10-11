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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ControlPanel = New System.Windows.Forms.Panel()
		Me.Button10 = New System.Windows.Forms.Button()
		Me.Button9 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.DashboardTemp = New System.Windows.Forms.Button()
		Me.DashBoardBack = New System.Windows.Forms.Button()
		Me.DashboardMenu = New System.Windows.Forms.Panel()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.LogoSmall = New System.Windows.Forms.PictureBox()
		Me.MasterBTN = New System.Windows.Forms.Button()
		Me.MenuClose = New System.Windows.Forms.Button()
		Me.MenuOpen = New System.Windows.Forms.Button()
		Me.LogoBig = New System.Windows.Forms.PictureBox()
		Me.ControlPanel.SuspendLayout()
		Me.DashboardMenu.SuspendLayout()
		CType(Me.LogoSmall, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogoBig, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Roboto Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
		Me.Label1.Location = New System.Drawing.Point(306, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(186, 39)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Dashboard"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'ControlPanel
		'
		Me.ControlPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ControlPanel.Controls.Add(Me.Button10)
		Me.ControlPanel.Controls.Add(Me.Button9)
		Me.ControlPanel.Controls.Add(Me.Button3)
		Me.ControlPanel.Controls.Add(Me.DashboardTemp)
		Me.ControlPanel.Location = New System.Drawing.Point(254, 65)
		Me.ControlPanel.Name = "ControlPanel"
		Me.ControlPanel.Size = New System.Drawing.Size(515, 462)
		Me.ControlPanel.TabIndex = 4
		'
		'Button10
		'
		Me.Button10.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button10.FlatAppearance.BorderSize = 0
		Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button10.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button10.Location = New System.Drawing.Point(343, 302)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(160, 150)
		Me.Button10.TabIndex = 3
		Me.Button10.Text = "Surveillance"
		Me.Button10.UseVisualStyleBackColor = True
		'
		'Button9
		'
		Me.Button9.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button9.FlatAppearance.BorderSize = 0
		Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button9.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button9.Location = New System.Drawing.Point(78, 302)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(160, 150)
		Me.Button9.TabIndex = 2
		Me.Button9.Text = "Climate"
		Me.Button9.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(343, 42)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(160, 150)
		Me.Button3.TabIndex = 1
		Me.Button3.Text = "Lights"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'DashboardTemp
		'
		Me.DashboardTemp.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
		Me.DashboardTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardTemp.FlatAppearance.BorderSize = 0
		Me.DashboardTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashboardTemp.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardTemp.Location = New System.Drawing.Point(78, 42)
		Me.DashboardTemp.Name = "DashboardTemp"
		Me.DashboardTemp.Size = New System.Drawing.Size(160, 150)
		Me.DashboardTemp.TabIndex = 0
		Me.DashboardTemp.Text = "Temperature"
		Me.DashboardTemp.UseVisualStyleBackColor = True
		'
		'DashBoardBack
		'
		Me.DashBoardBack.BackColor = System.Drawing.Color.Transparent
		Me.DashBoardBack.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
		Me.DashBoardBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.DashBoardBack.FlatAppearance.BorderSize = 0
		Me.DashBoardBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
		Me.DashBoardBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DashBoardBack.Location = New System.Drawing.Point(2, 3)
		Me.DashBoardBack.Name = "DashBoardBack"
		Me.DashBoardBack.Size = New System.Drawing.Size(15, 15)
		Me.DashBoardBack.TabIndex = 3
		Me.DashBoardBack.UseVisualStyleBackColor = False
		'
		'DashboardMenu
		'
		Me.DashboardMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.DashboardMenu.BackgroundImage = Global.homematic.My.Resources.Resources.Panelnew
		Me.DashboardMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.DashboardMenu.Controls.Add(Me.Button8)
		Me.DashboardMenu.Controls.Add(Me.Button7)
		Me.DashboardMenu.Controls.Add(Me.Button6)
		Me.DashboardMenu.Controls.Add(Me.Button5)
		Me.DashboardMenu.Controls.Add(Me.Button4)
		Me.DashboardMenu.Controls.Add(Me.LogoSmall)
		Me.DashboardMenu.Controls.Add(Me.MasterBTN)
		Me.DashboardMenu.Controls.Add(Me.MenuClose)
		Me.DashboardMenu.Controls.Add(Me.MenuOpen)
		Me.DashboardMenu.Controls.Add(Me.LogoBig)
		Me.DashboardMenu.Location = New System.Drawing.Point(2, 65)
		Me.DashboardMenu.Name = "DashboardMenu"
		Me.DashboardMenu.Size = New System.Drawing.Size(250, 463)
		Me.DashboardMenu.TabIndex = 2
		'
		'Button8
		'
		Me.Button8.FlatAppearance.BorderSize = 0
		Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button8.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button8.Location = New System.Drawing.Point(0, 382)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(235, 40)
		Me.Button8.TabIndex = 9
		Me.Button8.Text = "Living Room"
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.FlatAppearance.BorderSize = 0
		Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button7.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button7.Location = New System.Drawing.Point(0, 336)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(235, 40)
		Me.Button7.TabIndex = 8
		Me.Button7.Text = "Bath Room"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.FlatAppearance.BorderSize = 0
		Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button6.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.Location = New System.Drawing.Point(0, 290)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(235, 40)
		Me.Button6.TabIndex = 7
		Me.Button6.Text = "Kitchen"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.Location = New System.Drawing.Point(0, 244)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(235, 40)
		Me.Button5.TabIndex = 6
		Me.Button5.Text = "Room2"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(0, 198)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(235, 40)
		Me.Button4.TabIndex = 5
		Me.Button4.Text = "Room 1"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'LogoSmall
		'
		Me.LogoSmall.BackgroundImage = Global.homematic.My.Resources.Resources.homelogo
		Me.LogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.LogoSmall.Location = New System.Drawing.Point(2, 53)
		Me.LogoSmall.Name = "LogoSmall"
		Me.LogoSmall.Size = New System.Drawing.Size(25, 25)
		Me.LogoSmall.TabIndex = 4
		Me.LogoSmall.TabStop = False
		'
		'MasterBTN
		'
		Me.MasterBTN.FlatAppearance.BorderSize = 0
		Me.MasterBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.MasterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MasterBTN.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MasterBTN.Location = New System.Drawing.Point(0, 152)
		Me.MasterBTN.Name = "MasterBTN"
		Me.MasterBTN.Size = New System.Drawing.Size(235, 40)
		Me.MasterBTN.TabIndex = 3
		Me.MasterBTN.Text = "Master Bedroom"
		Me.MasterBTN.UseVisualStyleBackColor = True
		'
		'MenuClose
		'
		Me.MenuClose.BackColor = System.Drawing.Color.Transparent
		Me.MenuClose.BackgroundImage = Global.homematic.My.Resources.Resources.menudashboard
		Me.MenuClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MenuClose.FlatAppearance.BorderSize = 0
		Me.MenuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MenuClose.Location = New System.Drawing.Point(185, 25)
		Me.MenuClose.Name = "MenuClose"
		Me.MenuClose.Size = New System.Drawing.Size(21, 22)
		Me.MenuClose.TabIndex = 2
		Me.MenuClose.UseVisualStyleBackColor = False
		'
		'MenuOpen
		'
		Me.MenuOpen.BackColor = System.Drawing.Color.Transparent
		Me.MenuOpen.BackgroundImage = Global.homematic.My.Resources.Resources.menudashboard
		Me.MenuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MenuOpen.FlatAppearance.BorderSize = 0
		Me.MenuOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.MenuOpen.Location = New System.Drawing.Point(3, 25)
		Me.MenuOpen.Name = "MenuOpen"
		Me.MenuOpen.Size = New System.Drawing.Size(21, 22)
		Me.MenuOpen.TabIndex = 1
		Me.MenuOpen.UseVisualStyleBackColor = False
		'
		'LogoBig
		'
		Me.LogoBig.BackgroundImage = Global.homematic.My.Resources.Resources.homelogo
		Me.LogoBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.LogoBig.Location = New System.Drawing.Point(66, 47)
		Me.LogoBig.Name = "LogoBig"
		Me.LogoBig.Size = New System.Drawing.Size(77, 79)
		Me.LogoBig.TabIndex = 0
		Me.LogoBig.TabStop = False
		'
		'Dashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(769, 529)
		Me.Controls.Add(Me.ControlPanel)
		Me.Controls.Add(Me.DashBoardBack)
		Me.Controls.Add(Me.DashboardMenu)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Dashboard"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ControlPanel.ResumeLayout(False)
		Me.DashboardMenu.ResumeLayout(False)
		CType(Me.LogoSmall, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LogoBig, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents DashboardMenu As Panel
	Friend WithEvents LogoBig As PictureBox
	Friend WithEvents MenuOpen As Button
	Friend WithEvents MenuClose As Button
	Friend WithEvents LogoSmall As PictureBox
	Friend WithEvents MasterBTN As Button
	Friend WithEvents Button8 As Button
	Friend WithEvents Button7 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents DashBoardBack As Button
	Friend WithEvents ControlPanel As Panel
	Friend WithEvents DashboardTemp As Button
	Friend WithEvents Button10 As Button
	Friend WithEvents Button9 As Button
	Friend WithEvents Button3 As Button
End Class
