﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Me.kitchentool = New System.Windows.Forms.ToolTip(Me.components)
		Me.Bthtool = New System.Windows.Forms.ToolTip(Me.components)
		Me.Room1tool = New System.Windows.Forms.ToolTip(Me.components)
		Me.Room2tip = New System.Windows.Forms.ToolTip(Me.components)
		Me.Masterroomtip = New System.Windows.Forms.ToolTip(Me.components)
		Me.Livingroomtip = New System.Windows.Forms.ToolTip(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ToDashboard = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Masterroombtn = New System.Windows.Forms.Button()
		Me.Livingbtn = New System.Windows.Forms.Button()
		Me.Room2btn = New System.Windows.Forms.Button()
		Me.Room1btn = New System.Windows.Forms.Button()
		Me.Bathroombtn = New System.Windows.Forms.Button()
		Me.Kitchenbtn = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Blueprintimage = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		CType(Me.Blueprintimage, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'kitchentool
		'
		Me.kitchentool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.kitchentool.ToolTipTitle = "KITCHEN"
		'
		'Bthtool
		'
		Me.Bthtool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Bthtool.ToolTipTitle = "BATHROOM"
		'
		'Room1tool
		'
		Me.Room1tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Room1tool.ToolTipTitle = "ROOM1"
		'
		'Room2tip
		'
		Me.Room2tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Room2tip.ToolTipTitle = "ROOM2"
		'
		'Masterroomtip
		'
		Me.Masterroomtip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Masterroomtip.ToolTipTitle = "MASTER ROOM"
		'
		'Livingroomtip
		'
		Me.Livingroomtip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Livingroomtip.ToolTipTitle = "LIVING ROOM"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Masterroombtn)
		Me.Panel1.Controls.Add(Me.Livingbtn)
		Me.Panel1.Controls.Add(Me.Room2btn)
		Me.Panel1.Controls.Add(Me.Room1btn)
		Me.Panel1.Controls.Add(Me.Bathroombtn)
		Me.Panel1.Controls.Add(Me.Kitchenbtn)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Location = New System.Drawing.Point(2, 26)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(352, 34)
		Me.Panel1.TabIndex = 11
		'
		'ToDashboard
		'
		Me.ToDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
		Me.ToDashboard.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ToDashboard.FlatAppearance.BorderSize = 0
		Me.ToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ToDashboard.Font = New System.Drawing.Font("Roboto Thin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToDashboard.ForeColor = System.Drawing.Color.White
		Me.ToDashboard.Location = New System.Drawing.Point(0, 493)
		Me.ToDashboard.Name = "ToDashboard"
		Me.ToDashboard.Size = New System.Drawing.Size(743, 33)
		Me.ToDashboard.TabIndex = 12
		Me.ToDashboard.Text = "DashBoard"
		Me.ToDashboard.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackgroundImage = Global.homematic.My.Resources.Resources.Menu
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(10, 11)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(15, 15)
		Me.Button2.TabIndex = 11
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Masterroombtn
		'
		Me.Masterroombtn.BackColor = System.Drawing.Color.Transparent
		Me.Masterroombtn.BackgroundImage = Global.homematic.My.Resources.Resources.dashboardMasterIcon
		Me.Masterroombtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Masterroombtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Masterroombtn.FlatAppearance.BorderSize = 0
		Me.Masterroombtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Masterroombtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Masterroombtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Masterroombtn.Location = New System.Drawing.Point(302, 6)
		Me.Masterroombtn.Name = "Masterroombtn"
		Me.Masterroombtn.Size = New System.Drawing.Size(25, 25)
		Me.Masterroombtn.TabIndex = 7
		Me.Masterroomtip.SetToolTip(Me.Masterroombtn, "Click to view Master Bedroom")
		Me.Masterroombtn.UseVisualStyleBackColor = False
		'
		'Livingbtn
		'
		Me.Livingbtn.BackColor = System.Drawing.Color.Transparent
		Me.Livingbtn.BackgroundImage = Global.homematic.My.Resources.Resources.DasboardLivingRoom
		Me.Livingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Livingbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Livingbtn.FlatAppearance.BorderSize = 0
		Me.Livingbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Livingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Livingbtn.Location = New System.Drawing.Point(64, 6)
		Me.Livingbtn.Name = "Livingbtn"
		Me.Livingbtn.Size = New System.Drawing.Size(25, 25)
		Me.Livingbtn.TabIndex = 4
		Me.Livingroomtip.SetToolTip(Me.Livingbtn, "Click to view Living Room")
		Me.Livingbtn.UseVisualStyleBackColor = False
		'
		'Room2btn
		'
		Me.Room2btn.BackColor = System.Drawing.Color.Transparent
		Me.Room2btn.BackgroundImage = Global.homematic.My.Resources.Resources.DashboardRoom2Icon
		Me.Room2btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2btn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room2btn.FlatAppearance.BorderSize = 0
		Me.Room2btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Room2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2btn.Location = New System.Drawing.Point(110, 6)
		Me.Room2btn.Name = "Room2btn"
		Me.Room2btn.Size = New System.Drawing.Size(25, 25)
		Me.Room2btn.TabIndex = 9
		Me.Room2tip.SetToolTip(Me.Room2btn, "Click to view Room2")
		Me.Room2btn.UseVisualStyleBackColor = False
		'
		'Room1btn
		'
		Me.Room1btn.BackColor = System.Drawing.Color.Transparent
		Me.Room1btn.BackgroundImage = Global.homematic.My.Resources.Resources.DashboardSingleBedicon
		Me.Room1btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1btn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room1btn.FlatAppearance.BorderSize = 0
		Me.Room1btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Room1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1btn.Location = New System.Drawing.Point(206, 6)
		Me.Room1btn.Name = "Room1btn"
		Me.Room1btn.Size = New System.Drawing.Size(25, 25)
		Me.Room1btn.TabIndex = 10
		Me.Room1tool.SetToolTip(Me.Room1btn, "Click to view Room1")
		Me.Room1btn.UseVisualStyleBackColor = False
		'
		'Bathroombtn
		'
		Me.Bathroombtn.BackColor = System.Drawing.Color.Transparent
		Me.Bathroombtn.BackgroundImage = Global.homematic.My.Resources.Resources.DashboardBathroomIcon1
		Me.Bathroombtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Bathroombtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Bathroombtn.FlatAppearance.BorderSize = 0
		Me.Bathroombtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Bathroombtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Bathroombtn.Location = New System.Drawing.Point(255, 6)
		Me.Bathroombtn.Name = "Bathroombtn"
		Me.Bathroombtn.Size = New System.Drawing.Size(25, 25)
		Me.Bathroombtn.TabIndex = 8
		Me.Bthtool.SetToolTip(Me.Bathroombtn, "Click to view Bathroom")
		Me.Bathroombtn.UseVisualStyleBackColor = False
		'
		'Kitchenbtn
		'
		Me.Kitchenbtn.BackColor = System.Drawing.Color.Transparent
		Me.Kitchenbtn.BackgroundImage = Global.homematic.My.Resources.Resources.DashboardKitchenIcon
		Me.Kitchenbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Kitchenbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Kitchenbtn.FlatAppearance.BorderSize = 0
		Me.Kitchenbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Kitchenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Kitchenbtn.Location = New System.Drawing.Point(158, 6)
		Me.Kitchenbtn.Name = "Kitchenbtn"
		Me.Kitchenbtn.Size = New System.Drawing.Size(25, 25)
		Me.Kitchenbtn.TabIndex = 3
		Me.kitchentool.SetToolTip(Me.Kitchenbtn, "Click to view Kitchen")
		Me.Kitchenbtn.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackgroundImage = Global.homematic.My.Resources.Resources.Menu
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(10, 11)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(15, 15)
		Me.Button1.TabIndex = 12
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Blueprintimage
		'
		Me.Blueprintimage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Blueprintimage.BackgroundImage = Global.homematic.My.Resources.Resources.BlueprintFinal
		Me.Blueprintimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Blueprintimage.Location = New System.Drawing.Point(2, 63)
		Me.Blueprintimage.Name = "Blueprintimage"
		Me.Blueprintimage.Size = New System.Drawing.Size(743, 431)
		Me.Blueprintimage.TabIndex = 0
		Me.Blueprintimage.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(743, 526)
		Me.Controls.Add(Me.ToDashboard)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Blueprintimage)
		Me.Name = "Form1"
		Me.Panel1.ResumeLayout(False)
		CType(Me.Blueprintimage, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Room1tool As ToolTip
	Friend WithEvents kitchentool As ToolTip
	Friend WithEvents Bthtool As ToolTip
	Friend WithEvents Room2tip As ToolTip
	Friend WithEvents Masterroomtip As ToolTip
	Friend WithEvents Livingroomtip As ToolTip
	Friend WithEvents Blueprintimage As PictureBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Masterroombtn As Button
	Friend WithEvents Livingbtn As Button
	Friend WithEvents Room2btn As Button
	Friend WithEvents Room1btn As Button
	Friend WithEvents Kitchenbtn As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents ToDashboard As Button
	Friend WithEvents Bathroombtn As Button
End Class
