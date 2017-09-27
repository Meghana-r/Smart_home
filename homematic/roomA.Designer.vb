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
		Me.components = New System.ComponentModel.Container()
		Me.control = New MaterialSkin.Controls.MaterialTabControl()
		Me.Lighttab = New System.Windows.Forms.TabPage()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.brightness2 = New System.Windows.Forms.Label()
		Me.lit2on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.lit2off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brighttrack3 = New System.Windows.Forms.TrackBar()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lit1on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.lit1off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brightness1 = New System.Windows.Forms.Label()
		Me.brighttrack2 = New System.Windows.Forms.TrackBar()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lighton = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brightness = New System.Windows.Forms.Label()
		Me.lightoff = New MaterialSkin.Controls.MaterialRadioButton()
		Me.brighttrack = New System.Windows.Forms.TrackBar()
		Me.temptab = New System.Windows.Forms.TabPage()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.mediumhot = New System.Windows.Forms.PictureBox()
		Me.coldimage = New System.Windows.Forms.PictureBox()
		Me.sunimage = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.labtemop = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.vidtab = New System.Windows.Forms.TabPage()
		Me.Stattab = New System.Windows.Forms.TabPage()
		Me.Tabselect = New MaterialSkin.Controls.MaterialTabSelector()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.bulb = New System.Windows.Forms.PictureBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.humidtip = New System.Windows.Forms.ToolTip(Me.components)
		Me.control.SuspendLayout()
		Me.Lighttab.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.temptab.SuspendLayout()
		CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bulb, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
		Me.GroupBox3.Location = New System.Drawing.Point(563, 3)
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
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lit1on)
		Me.GroupBox2.Controls.Add(Me.lit1off)
		Me.GroupBox2.Controls.Add(Me.brightness1)
		Me.GroupBox2.Controls.Add(Me.brighttrack2)
		Me.GroupBox2.Location = New System.Drawing.Point(288, 3)
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
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lighton)
		Me.GroupBox1.Controls.Add(Me.brightness)
		Me.GroupBox1.Controls.Add(Me.lightoff)
		Me.GroupBox1.Controls.Add(Me.brighttrack)
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
		Me.brightness.Location = New System.Drawing.Point(89, 167)
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
		Me.temptab.Controls.Add(Me.Button5)
		Me.temptab.Controls.Add(Me.Button4)
		Me.temptab.Controls.Add(Me.Button3)
		Me.temptab.Controls.Add(Me.Button2)
		Me.temptab.Controls.Add(Me.mediumhot)
		Me.temptab.Controls.Add(Me.coldimage)
		Me.temptab.Controls.Add(Me.sunimage)
		Me.temptab.Controls.Add(Me.Label1)
		Me.temptab.Controls.Add(Me.labtemop)
		Me.temptab.Controls.Add(Me.PictureBox1)
		Me.temptab.Location = New System.Drawing.Point(4, 22)
		Me.temptab.Name = "temptab"
		Me.temptab.Padding = New System.Windows.Forms.Padding(3)
		Me.temptab.Size = New System.Drawing.Size(746, 418)
		Me.temptab.TabIndex = 1
		Me.temptab.Text = "Temperature"
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Transparent
		Me.Button2.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Partly_Cloudy_Day_50
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(220, 182)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(36, 31)
		Me.Button2.TabIndex = 6
		Me.humidtip.SetToolTip(Me.Button2, "Click ti view humidity levels")
		Me.Button2.UseVisualStyleBackColor = False
		'
		'mediumhot
		'
		Me.mediumhot.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.mediumhot.Image = Global.homematic.My.Resources.Resources.icons8_Sun_Filled_50__1_
		Me.mediumhot.Location = New System.Drawing.Point(323, 73)
		Me.mediumhot.Name = "mediumhot"
		Me.mediumhot.Size = New System.Drawing.Size(34, 32)
		Me.mediumhot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.mediumhot.TabIndex = 5
		Me.mediumhot.TabStop = False
		'
		'coldimage
		'
		Me.coldimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.coldimage.Image = Global.homematic.My.Resources.Resources.icons8_Snowflake_48
		Me.coldimage.Location = New System.Drawing.Point(323, 73)
		Me.coldimage.Name = "coldimage"
		Me.coldimage.Size = New System.Drawing.Size(34, 32)
		Me.coldimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.coldimage.TabIndex = 4
		Me.coldimage.TabStop = False
		'
		'sunimage
		'
		Me.sunimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.sunimage.Image = Global.homematic.My.Resources.Resources.icons8_Sun_Filled_50
		Me.sunimage.Location = New System.Drawing.Point(323, 73)
		Me.sunimage.Name = "sunimage"
		Me.sunimage.Size = New System.Drawing.Size(34, 32)
		Me.sunimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.sunimage.TabIndex = 3
		Me.sunimage.TabStop = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(362, 66)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 41)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "100"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'labtemop
		'
		Me.labtemop.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.labtemop.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.labtemop.ForeColor = System.Drawing.Color.White
		Me.labtemop.Location = New System.Drawing.Point(325, 156)
		Me.labtemop.Name = "labtemop"
		Me.labtemop.Size = New System.Drawing.Size(86, 71)
		Me.labtemop.TabIndex = 1
		Me.labtemop.Text = "100"
		Me.labtemop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.homematic.My.Resources.Resources.tempco1
		Me.PictureBox1.Location = New System.Drawing.Point(171, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(418, 418)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
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
		'bulb
		'
		Me.bulb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.bulb.BackColor = System.Drawing.Color.Transparent
		Me.bulb.Image = Global.homematic.My.Resources.Resources.icons8_Light_Automation_50__1_
		Me.bulb.Location = New System.Drawing.Point(42, 33)
		Me.bulb.Name = "bulb"
		Me.bulb.Size = New System.Drawing.Size(35, 30)
		Me.bulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.bulb.TabIndex = 2
		Me.bulb.TabStop = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Transparent
		Me.Button3.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Reset_50
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(475, 182)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(36, 31)
		Me.Button3.TabIndex = 7
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Transparent
		Me.Button4.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Down_Button_Filled_50
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Location = New System.Drawing.Point(62, 223)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(36, 31)
		Me.Button4.TabIndex = 8
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.Transparent
		Me.Button5.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Slide_Up_Filled_50
		Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Location = New System.Drawing.Point(62, 100)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(36, 31)
		Me.Button5.TabIndex = 9
		Me.Button5.UseVisualStyleBackColor = False
		'
		'humidtip
		'
		Me.humidtip.ToolTipTitle = "Humidity"
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
		Me.Controls.Add(Me.bulb)
		Me.Controls.Add(Me.Tabselect)
		Me.Controls.Add(Me.control)
		Me.Name = "RoomA"
		Me.control.ResumeLayout(False)
		Me.Lighttab.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).EndInit()
		Me.temptab.ResumeLayout(False)
		CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.coldimage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.sunimage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bulb, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents control As MaterialSkin.Controls.MaterialTabControl
	Friend WithEvents Lighttab As TabPage
	Friend WithEvents apptab As TabPage
	Friend WithEvents vidtab As TabPage
	Friend WithEvents Stattab As TabPage
	Friend WithEvents Tabselect As MaterialSkin.Controls.MaterialTabSelector
	Friend WithEvents bulb As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents lighton As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brighttrack As TrackBar
	Friend WithEvents brighttrack2 As TrackBar
	Friend WithEvents brighttrack3 As TrackBar
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
	Friend WithEvents temptab As TabPage
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents sunimage As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents labtemop As Label
	Friend WithEvents coldimage As PictureBox
	Friend WithEvents mediumhot As PictureBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents humidtip As ToolTip
End Class
