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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MasterBTN = New System.Windows.Forms.Button()
        Me.MenuClose = New System.Windows.Forms.Button()
        Me.MenuOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DashboardBack = New System.Windows.Forms.Button()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.DashboardMenu.Controls.Add(Me.Button6)
        Me.DashboardMenu.Controls.Add(Me.Button5)
        Me.DashboardMenu.Controls.Add(Me.Button4)
        Me.DashboardMenu.Controls.Add(Me.Button3)
        Me.DashboardMenu.Controls.Add(Me.Button2)
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
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(0, 401)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(234, 41)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "BathRoom"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 354)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 41)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Living Room"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(0, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 41)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Kitchen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(234, 41)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Room 2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Room 1"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.ControlPanel.Controls.Add(Me.Button9)
        Me.ControlPanel.Controls.Add(Me.Button8)
        Me.ControlPanel.Controls.Add(Me.Button7)
        Me.ControlPanel.Controls.Add(Me.Button1)
        Me.ControlPanel.Location = New System.Drawing.Point(236, 63)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(534, 464)
        Me.ControlPanel.TabIndex = 3
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(37, 302)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 140)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Climate"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(371, 302)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 140)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Surveillance"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(371, 43)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(160, 140)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Lights"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.homematic.My.Resources.Resources.Cards
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(37, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 140)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Temperature"
        Me.Button1.UseVisualStyleBackColor = True
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
	Friend WithEvents Button6 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents MasterBTN As Button
	Friend WithEvents LogoBig As PictureBox
	Friend WithEvents LogoSmall As PictureBox
	Friend WithEvents ControlPanel As Panel
	Friend WithEvents Button1 As Button
	Friend WithEvents Button9 As Button
	Friend WithEvents Button8 As Button
	Friend WithEvents Button7 As Button
End Class
