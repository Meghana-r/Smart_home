<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomA
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
		Me.control = New MaterialSkin.Controls.MaterialTabControl()
		Me.Lighttab = New System.Windows.Forms.TabPage()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.brightness2 = New System.Windows.Forms.Label()
		Me.lit2on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.lit2off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lit1on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.lit1off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brightness1 = New System.Windows.Forms.Label()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lighton = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brightness = New System.Windows.Forms.Label()
		Me.lightoff = New MaterialSkin.Controls.MaterialRadioButton()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.brighttrack3 = New System.Windows.Forms.TrackBar()
		Me.brighttrack2 = New System.Windows.Forms.TrackBar()
		Me.brighttrack = New System.Windows.Forms.TrackBar()
		Me.temptab = New System.Windows.Forms.TabPage()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.vidtab = New System.Windows.Forms.TabPage()
		Me.Stattab = New System.Windows.Forms.TabPage()
		Me.Tabselect = New MaterialSkin.Controls.MaterialTabSelector()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.control.SuspendLayout()
		Me.Lighttab.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'control
		'
		Me.control.Controls.Add(Me.Lighttab)
		Me.control.Controls.Add(Me.temptab)
		Me.control.Controls.Add(Me.apptab)
		Me.control.Controls.Add(Me.vidtab)
		Me.control.Controls.Add(Me.Stattab)
		Me.control.Depth = 0
		Me.control.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.control.Location = New System.Drawing.Point(0, 115)
		Me.control.MouseState = MaterialSkin.MouseState.HOVER
		Me.control.Name = "control"
		Me.control.SelectedIndex = 0
		Me.control.Size = New System.Drawing.Size(754, 444)
		Me.control.TabIndex = 0
		'
		'Lighttab
		'
		Me.Lighttab.BackColor = System.Drawing.Color.White
		Me.Lighttab.Controls.Add(Me.GroupBox3)
		Me.Lighttab.Controls.Add(Me.GroupBox2)
		Me.Lighttab.Controls.Add(Me.GroupBox1)
		Me.Lighttab.Location = New System.Drawing.Point(4, 22)
		Me.Lighttab.Name = "Lighttab"
		Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
		Me.Lighttab.Size = New System.Drawing.Size(746, 418)
		Me.Lighttab.TabIndex = 0
		Me.Lighttab.Text = "Lights"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.brightness2)
		Me.GroupBox3.Controls.Add(Me.lit2on)
		Me.GroupBox3.Controls.Add(Me.lit2off)
		Me.GroupBox3.Controls.Add(Me.brighttrack3)
		Me.GroupBox3.Controls.Add(Me.PictureBox8)
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
		Me.GroupBox3.Location = New System.Drawing.Point(363, 3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(180, 412)
		Me.GroupBox3.TabIndex = 20
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "light3"
		'
		'brightness2
		'
		Me.brightness2.BackColor = System.Drawing.Color.Transparent
		Me.brightness2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness2.Location = New System.Drawing.Point(81, 167)
		Me.brightness2.Name = "brightness2"
		Me.brightness2.Size = New System.Drawing.Size(30, 20)
		Me.brightness2.TabIndex = 18
		Me.brightness2.Text = "100"
		'
		'lit2on
		'
		Me.lit2on.Checked = True
		Me.lit2on.Depth = 0
		Me.lit2on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit2on.Location = New System.Drawing.Point(20, 29)
		Me.lit2on.Margin = New System.Windows.Forms.Padding(0)
		Me.lit2on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lit2on.MouseState = MaterialSkin.MouseState.HOVER
		Me.lit2on.Name = "lit2on"
		Me.lit2on.Ripple = True
		Me.lit2on.Size = New System.Drawing.Size(55, 30)
		Me.lit2on.TabIndex = 0
		Me.lit2on.TabStop = True
		Me.lit2on.Text = "ON"
		Me.lit2on.UseVisualStyleBackColor = True
		'
		'lit2off
		'
		Me.lit2off.Depth = 0
		Me.lit2off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit2off.Location = New System.Drawing.Point(81, 29)
		Me.lit2off.Margin = New System.Windows.Forms.Padding(0)
		Me.lit2off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lit2off.MouseState = MaterialSkin.MouseState.HOVER
		Me.lit2off.Name = "lit2off"
		Me.lit2off.Ripple = True
		Me.lit2off.Size = New System.Drawing.Size(55, 30)
		Me.lit2off.TabIndex = 1
		Me.lit2off.Text = "OFF"
		Me.lit2off.UseVisualStyleBackColor = True
		'
		'PictureBox8
		'
		Me.PictureBox8.Image = Global.homematic.My.Resources.Resources.teal
		Me.PictureBox8.Location = New System.Drawing.Point(6, 81)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(115, 115)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox8.TabIndex = 13
		Me.PictureBox8.TabStop = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lit1on)
		Me.GroupBox2.Controls.Add(Me.lit1off)
		Me.GroupBox2.Controls.Add(Me.brightness1)
		Me.GroupBox2.Controls.Add(Me.brighttrack2)
		Me.GroupBox2.Controls.Add(Me.PictureBox6)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
		Me.GroupBox2.Location = New System.Drawing.Point(183, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(180, 412)
		Me.GroupBox2.TabIndex = 20
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "light2"
		'
		'lit1on
		'
		Me.lit1on.Checked = True
		Me.lit1on.Depth = 0
		Me.lit1on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit1on.Location = New System.Drawing.Point(20, 29)
		Me.lit1on.Margin = New System.Windows.Forms.Padding(0)
		Me.lit1on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lit1on.MouseState = MaterialSkin.MouseState.HOVER
		Me.lit1on.Name = "lit1on"
		Me.lit1on.Ripple = True
		Me.lit1on.Size = New System.Drawing.Size(55, 30)
		Me.lit1on.TabIndex = 0
		Me.lit1on.TabStop = True
		Me.lit1on.Text = "ON"
		Me.lit1on.UseVisualStyleBackColor = True
		'
		'lit1off
		'
		Me.lit1off.Depth = 0
		Me.lit1off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit1off.Location = New System.Drawing.Point(85, 29)
		Me.lit1off.Margin = New System.Windows.Forms.Padding(0)
		Me.lit1off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lit1off.MouseState = MaterialSkin.MouseState.HOVER
		Me.lit1off.Name = "lit1off"
		Me.lit1off.Ripple = True
		Me.lit1off.Size = New System.Drawing.Size(55, 30)
		Me.lit1off.TabIndex = 1
		Me.lit1off.Text = "OFF"
		Me.lit1off.UseVisualStyleBackColor = True
		'
		'brightness1
		'
		Me.brightness1.BackColor = System.Drawing.Color.Transparent
		Me.brightness1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness1.Location = New System.Drawing.Point(80, 167)
		Me.brightness1.Name = "brightness1"
		Me.brightness1.Size = New System.Drawing.Size(30, 20)
		Me.brightness1.TabIndex = 17
		Me.brightness1.Text = "100"
		'
		'PictureBox6
		'
		Me.PictureBox6.Image = Global.homematic.My.Resources.Resources.teal
		Me.PictureBox6.Location = New System.Drawing.Point(6, 81)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(115, 115)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox6.TabIndex = 11
		Me.PictureBox6.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lighton)
		Me.GroupBox1.Controls.Add(Me.brightness)
		Me.GroupBox1.Controls.Add(Me.lightoff)
		Me.GroupBox1.Controls.Add(Me.brighttrack)
		Me.GroupBox1.Controls.Add(Me.PictureBox7)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
		Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(180, 412)
		Me.GroupBox1.TabIndex = 19
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "light1"
		'
		'lighton
		'
		Me.lighton.Checked = True
		Me.lighton.Depth = 0
		Me.lighton.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lighton.Location = New System.Drawing.Point(20, 29)
		Me.lighton.Margin = New System.Windows.Forms.Padding(0)
		Me.lighton.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lighton.MouseState = MaterialSkin.MouseState.HOVER
		Me.lighton.Name = "lighton"
		Me.lighton.Ripple = True
		Me.lighton.Size = New System.Drawing.Size(55, 30)
		Me.lighton.TabIndex = 0
		Me.lighton.TabStop = True
		Me.lighton.Text = "ON"
		Me.lighton.UseVisualStyleBackColor = True
		'
		'brightness
		'
		Me.brightness.BackColor = System.Drawing.Color.Transparent
		Me.brightness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness.Location = New System.Drawing.Point(81, 167)
		Me.brightness.Name = "brightness"
		Me.brightness.Size = New System.Drawing.Size(30, 20)
		Me.brightness.TabIndex = 18
		Me.brightness.Text = "100"
		'
		'lightoff
		'
		Me.lightoff.Depth = 0
		Me.lightoff.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lightoff.Location = New System.Drawing.Point(81, 29)
		Me.lightoff.Margin = New System.Windows.Forms.Padding(0)
		Me.lightoff.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.lightoff.MouseState = MaterialSkin.MouseState.HOVER
		Me.lightoff.Name = "lightoff"
		Me.lightoff.Ripple = True
		Me.lightoff.Size = New System.Drawing.Size(55, 30)
		Me.lightoff.TabIndex = 1
		Me.lightoff.Text = "OFF"
		Me.lightoff.UseVisualStyleBackColor = True
		'
		'PictureBox7
		'
		Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox7.Image = Global.homematic.My.Resources.Resources.teal
		Me.PictureBox7.Location = New System.Drawing.Point(4, 81)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(115, 115)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox7.TabIndex = 12
		Me.PictureBox7.TabStop = False
		'
		'brighttrack3
		'
		Me.brighttrack3.Location = New System.Drawing.Point(127, 81)
		Me.brighttrack3.Maximum = 100
		Me.brighttrack3.Minimum = 10
		Me.brighttrack3.Name = "brighttrack3"
		Me.brighttrack3.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.brighttrack3.Size = New System.Drawing.Size(45, 325)
		Me.brighttrack3.TabIndex = 8
		Me.brighttrack3.TabStop = False
		Me.brighttrack3.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack3.Value = 100
		'
		'brighttrack2
		'
		Me.brighttrack2.Location = New System.Drawing.Point(129, 81)
		Me.brighttrack2.Maximum = 100
		Me.brighttrack2.Minimum = 10
		Me.brighttrack2.Name = "brighttrack2"
		Me.brighttrack2.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.brighttrack2.Size = New System.Drawing.Size(45, 325)
		Me.brighttrack2.TabIndex = 5
		Me.brighttrack2.TabStop = False
		Me.brighttrack2.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack2.Value = 100
		'
		'brighttrack
		'
		Me.brighttrack.Location = New System.Drawing.Point(125, 81)
		Me.brighttrack.Maximum = 100
		Me.brighttrack.Minimum = 10
		Me.brighttrack.Name = "brighttrack"
		Me.brighttrack.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.brighttrack.Size = New System.Drawing.Size(45, 325)
		Me.brighttrack.TabIndex = 2
		Me.brighttrack.TabStop = False
		Me.brighttrack.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack.Value = 100
		'
		'temptab
		'
		Me.temptab.BackColor = System.Drawing.Color.White
		Me.temptab.Location = New System.Drawing.Point(4, 22)
		Me.temptab.Name = "temptab"
		Me.temptab.Padding = New System.Windows.Forms.Padding(3)
		Me.temptab.Size = New System.Drawing.Size(746, 418)
		Me.temptab.TabIndex = 1
		Me.temptab.Text = "Temperature"
		'
		'apptab
		'
		Me.apptab.BackColor = System.Drawing.Color.White
		Me.apptab.Location = New System.Drawing.Point(4, 22)
		Me.apptab.Name = "apptab"
		Me.apptab.Size = New System.Drawing.Size(746, 418)
		Me.apptab.TabIndex = 2
		Me.apptab.Text = "Appliances"
		Me.apptab.UseVisualStyleBackColor = True
		'
		'vidtab
		'
		Me.vidtab.BackColor = System.Drawing.Color.White
		Me.vidtab.Location = New System.Drawing.Point(4, 22)
		Me.vidtab.Name = "vidtab"
		Me.vidtab.Size = New System.Drawing.Size(746, 418)
		Me.vidtab.TabIndex = 3
		Me.vidtab.Text = "Video"
		Me.vidtab.UseVisualStyleBackColor = True
		'
		'Stattab
		'
		Me.Stattab.BackColor = System.Drawing.Color.White
		Me.Stattab.Location = New System.Drawing.Point(4, 22)
		Me.Stattab.Name = "Stattab"
		Me.Stattab.Size = New System.Drawing.Size(746, 418)
		Me.Stattab.TabIndex = 4
		Me.Stattab.Text = "Statistics"
		Me.Stattab.UseVisualStyleBackColor = True
		'
		'Tabselect
		'
		Me.Tabselect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Tabselect.BaseTabControl = Me.control
		Me.Tabselect.Depth = 0
		Me.Tabselect.Location = New System.Drawing.Point(0, 63)
		Me.Tabselect.MouseState = MaterialSkin.MouseState.HOVER
		Me.Tabselect.Name = "Tabselect"
		Me.Tabselect.Size = New System.Drawing.Size(754, 46)
		Me.Tabselect.TabIndex = 1
		Me.Tabselect.Text = "Tabselect"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Chevron_Left_26
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(15, 15)
		Me.Button1.TabIndex = 7
		Me.Button1.UseVisualStyleBackColor = False
		'
		'PictureBox5
		'
		Me.PictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox5.Image = Global.homematic.My.Resources.Resources.icons8_Statistics_50
		Me.PictureBox5.Location = New System.Drawing.Point(480, 33)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox5.TabIndex = 6
		Me.PictureBox5.TabStop = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox4.Image = Global.homematic.My.Resources.Resources.icons8_Video_Call_50__1_
		Me.PictureBox4.Location = New System.Drawing.Point(380, 33)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox4.TabIndex = 5
		Me.PictureBox4.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox3.Image = Global.homematic.My.Resources.Resources.icons8_Electrical_50
		Me.PictureBox3.Location = New System.Drawing.Point(276, 33)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 4
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.Image = Global.homematic.My.Resources.Resources.icons8_Temperature_50__1_
		Me.PictureBox2.Location = New System.Drawing.Point(154, 33)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 3
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Image = Global.homematic.My.Resources.Resources.icons8_Light_Automation_50__1_
		Me.PictureBox1.Location = New System.Drawing.Point(42, 33)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'RoomA
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(754, 559)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox5)
		Me.Controls.Add(Me.PictureBox4)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Tabselect)
		Me.Controls.Add(Me.control)
		Me.Name = "RoomA"
		Me.control.ResumeLayout(False)
		Me.Lighttab.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents control As MaterialSkin.Controls.MaterialTabControl
	Friend WithEvents Lighttab As TabPage
	Friend WithEvents temptab As TabPage
	Friend WithEvents apptab As TabPage
	Friend WithEvents vidtab As TabPage
	Friend WithEvents Stattab As TabPage
	Friend WithEvents Tabselect As MaterialSkin.Controls.MaterialTabSelector
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents lighton As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brighttrack As TrackBar
	Friend WithEvents brighttrack2 As TrackBar
	Friend WithEvents brighttrack3 As TrackBar
	Friend WithEvents PictureBox8 As PictureBox
	Friend WithEvents PictureBox7 As PictureBox
	Friend WithEvents PictureBox6 As PictureBox
	Friend WithEvents brightness As Label
	Friend WithEvents brightness1 As Label
	Friend WithEvents lightoff As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents lit1on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents lit1off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents lit2on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents lit2off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brightness2 As Label
End Class
