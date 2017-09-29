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
		Me.Increasebtn = New System.Windows.Forms.Button()
		Me.Decreasebtn = New System.Windows.Forms.Button()
		Me.resetbtn = New System.Windows.Forms.Button()
		Me.humidbtn = New System.Windows.Forms.Button()
		Me.mediumhot = New System.Windows.Forms.PictureBox()
		Me.coldimage = New System.Windows.Forms.PictureBox()
		Me.sunimage = New System.Windows.Forms.PictureBox()
		Me.templabel = New System.Windows.Forms.Label()
		Me.templabel2 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.Socket1 = New System.Windows.Forms.GroupBox()
		Me.S1switchoff = New System.Windows.Forms.Button()
		Me.S1switchon = New System.Windows.Forms.Button()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		Me.vidtab = New System.Windows.Forms.TabPage()
		Me.Stattab = New System.Windows.Forms.TabPage()
		Me.Tabselect = New MaterialSkin.Controls.MaterialTabSelector()
		Me.humidtip = New System.Windows.Forms.ToolTip(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.bulb = New System.Windows.Forms.PictureBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.s2switchoff = New System.Windows.Forms.Button()
		Me.s2switchon = New System.Windows.Forms.Button()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.s3switchoff = New System.Windows.Forms.Button()
		Me.s3switchon = New System.Windows.Forms.Button()
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.s4switchoff = New System.Windows.Forms.Button()
		Me.s4switchon = New System.Windows.Forms.Button()
		Me.PictureBox9 = New System.Windows.Forms.PictureBox()
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
		Me.apptab.SuspendLayout()
		Me.Socket1.SuspendLayout()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bulb, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox4.SuspendLayout()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox5.SuspendLayout()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox6.SuspendLayout()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.brightness2)
		Me.GroupBox3.Controls.Add(Me.lit2on)
		Me.GroupBox3.Controls.Add(Me.lit2off)
		Me.GroupBox3.Controls.Add(Me.brighttrack3)
		Me.GroupBox3.Location = New System.Drawing.Point(3, 295)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(740, 120)
		Me.GroupBox3.TabIndex = 20
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "light3"
		'
		'brightness2
		'
		Me.brightness2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.brightness2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.brightness2.ForeColor = System.Drawing.Color.White
		Me.brightness2.Location = New System.Drawing.Point(179, 75)
		Me.brightness2.Name = "brightness2"
		Me.brightness2.Size = New System.Drawing.Size(40, 30)
		Me.brightness2.TabIndex = 18
		Me.brightness2.Text = "100"
		Me.brightness2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lit2on
		'
		Me.lit2on.Checked = True
		Me.lit2on.Depth = 0
		Me.lit2on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit2on.Location = New System.Drawing.Point(113, 33)
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
		Me.lit2off.Location = New System.Drawing.Point(580, 16)
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
		Me.brighttrack3.Location = New System.Drawing.Point(229, 69)
		Me.brighttrack3.Maximum = 100
		Me.brighttrack3.Minimum = 10
		Me.brighttrack3.Name = "brighttrack3"
		Me.brighttrack3.Size = New System.Drawing.Size(325, 45)
		Me.brighttrack3.TabIndex = 8
		Me.brighttrack3.TabStop = False
		Me.brighttrack3.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack3.Value = 100
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.lit1on)
		Me.GroupBox2.Controls.Add(Me.lit1off)
		Me.GroupBox2.Controls.Add(Me.brightness1)
		Me.GroupBox2.Controls.Add(Me.brighttrack2)
		Me.GroupBox2.Location = New System.Drawing.Point(3, 153)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(740, 120)
		Me.GroupBox2.TabIndex = 20
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "light2"
		'
		'lit1on
		'
		Me.lit1on.Checked = True
		Me.lit1on.Depth = 0
		Me.lit1on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lit1on.Location = New System.Drawing.Point(113, 29)
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
		Me.lit1off.Location = New System.Drawing.Point(580, 29)
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
		Me.brightness1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.brightness1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.brightness1.ForeColor = System.Drawing.Color.White
		Me.brightness1.Location = New System.Drawing.Point(179, 69)
		Me.brightness1.Name = "brightness1"
		Me.brightness1.Size = New System.Drawing.Size(40, 30)
		Me.brightness1.TabIndex = 17
		Me.brightness1.Text = "100"
		Me.brightness1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'brighttrack2
		'
		Me.brighttrack2.Location = New System.Drawing.Point(229, 69)
		Me.brighttrack2.Maximum = 100
		Me.brighttrack2.Minimum = 10
		Me.brighttrack2.Name = "brighttrack2"
		Me.brighttrack2.Size = New System.Drawing.Size(325, 45)
		Me.brighttrack2.TabIndex = 5
		Me.brighttrack2.TabStop = False
		Me.brighttrack2.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack2.Value = 100
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.lighton)
		Me.GroupBox1.Controls.Add(Me.brightness)
		Me.GroupBox1.Controls.Add(Me.lightoff)
		Me.GroupBox1.Controls.Add(Me.brighttrack)
		Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(740, 120)
		Me.GroupBox1.TabIndex = 19
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "light1"
		'
		'lighton
		'
		Me.lighton.Checked = True
		Me.lighton.Depth = 0
		Me.lighton.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lighton.Location = New System.Drawing.Point(113, 16)
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
		Me.brightness.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.brightness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.brightness.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.brightness.ForeColor = System.Drawing.Color.White
		Me.brightness.Location = New System.Drawing.Point(179, 56)
		Me.brightness.Name = "brightness"
		Me.brightness.Size = New System.Drawing.Size(40, 30)
		Me.brightness.TabIndex = 18
		Me.brightness.Text = "100"
		Me.brightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lightoff
		'
		Me.lightoff.Depth = 0
		Me.lightoff.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.lightoff.Location = New System.Drawing.Point(580, 16)
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
		Me.brighttrack.Location = New System.Drawing.Point(229, 56)
		Me.brighttrack.Maximum = 100
		Me.brighttrack.Minimum = 10
		Me.brighttrack.Name = "brighttrack"
		Me.brighttrack.Size = New System.Drawing.Size(325, 45)
		Me.brighttrack.TabIndex = 2
		Me.brighttrack.TabStop = False
		Me.brighttrack.TickStyle = System.Windows.Forms.TickStyle.None
		Me.brighttrack.Value = 100
		'
		'temptab
		'
		Me.temptab.BackColor = System.Drawing.Color.White
		Me.temptab.Controls.Add(Me.Increasebtn)
		Me.temptab.Controls.Add(Me.Decreasebtn)
		Me.temptab.Controls.Add(Me.resetbtn)
		Me.temptab.Controls.Add(Me.humidbtn)
		Me.temptab.Controls.Add(Me.mediumhot)
		Me.temptab.Controls.Add(Me.coldimage)
		Me.temptab.Controls.Add(Me.sunimage)
		Me.temptab.Controls.Add(Me.templabel)
		Me.temptab.Controls.Add(Me.templabel2)
		Me.temptab.Controls.Add(Me.PictureBox1)
		Me.temptab.Location = New System.Drawing.Point(4, 22)
		Me.temptab.Name = "temptab"
		Me.temptab.Padding = New System.Windows.Forms.Padding(3)
		Me.temptab.Size = New System.Drawing.Size(746, 418)
		Me.temptab.TabIndex = 1
		Me.temptab.Text = "Temperature"
		'
		'Increasebtn
		'
		Me.Increasebtn.BackColor = System.Drawing.Color.Transparent
		Me.Increasebtn.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Slide_Up_Filled_50
		Me.Increasebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Increasebtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Increasebtn.FlatAppearance.BorderSize = 0
		Me.Increasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Increasebtn.Location = New System.Drawing.Point(120, 112)
		Me.Increasebtn.Name = "Increasebtn"
		Me.Increasebtn.Size = New System.Drawing.Size(36, 31)
		Me.Increasebtn.TabIndex = 9
		Me.Increasebtn.UseVisualStyleBackColor = False
		'
		'Decreasebtn
		'
		Me.Decreasebtn.BackColor = System.Drawing.Color.Transparent
		Me.Decreasebtn.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Down_Button_Filled_50
		Me.Decreasebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Decreasebtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Decreasebtn.FlatAppearance.BorderSize = 0
		Me.Decreasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Decreasebtn.Location = New System.Drawing.Point(120, 237)
		Me.Decreasebtn.Name = "Decreasebtn"
		Me.Decreasebtn.Size = New System.Drawing.Size(36, 31)
		Me.Decreasebtn.TabIndex = 8
		Me.Decreasebtn.UseVisualStyleBackColor = False
		'
		'resetbtn
		'
		Me.resetbtn.BackColor = System.Drawing.Color.Transparent
		Me.resetbtn.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Reset_50
		Me.resetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.resetbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.resetbtn.FlatAppearance.BorderSize = 0
		Me.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.resetbtn.Location = New System.Drawing.Point(475, 182)
		Me.resetbtn.Name = "resetbtn"
		Me.resetbtn.Size = New System.Drawing.Size(36, 31)
		Me.resetbtn.TabIndex = 7
		Me.resetbtn.UseVisualStyleBackColor = False
		'
		'humidbtn
		'
		Me.humidbtn.BackColor = System.Drawing.Color.Transparent
		Me.humidbtn.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Partly_Cloudy_Day_50
		Me.humidbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.humidbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.humidbtn.FlatAppearance.BorderSize = 0
		Me.humidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.humidbtn.Location = New System.Drawing.Point(220, 182)
		Me.humidbtn.Name = "humidbtn"
		Me.humidbtn.Size = New System.Drawing.Size(36, 31)
		Me.humidbtn.TabIndex = 6
		Me.humidtip.SetToolTip(Me.humidbtn, "Click to view humidity levels")
		Me.humidbtn.UseVisualStyleBackColor = False
		'
		'mediumhot
		'
		Me.mediumhot.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.mediumhot.Image = Global.homematic.My.Resources.Resources.icons8_Sun_Filled_50__1_
		Me.mediumhot.Location = New System.Drawing.Point(376, 105)
		Me.mediumhot.Name = "mediumhot"
		Me.mediumhot.Size = New System.Drawing.Size(30, 30)
		Me.mediumhot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.mediumhot.TabIndex = 5
		Me.mediumhot.TabStop = False
		'
		'coldimage
		'
		Me.coldimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.coldimage.Image = Global.homematic.My.Resources.Resources.icons8_Snowflake_48
		Me.coldimage.Location = New System.Drawing.Point(376, 105)
		Me.coldimage.Name = "coldimage"
		Me.coldimage.Size = New System.Drawing.Size(30, 30)
		Me.coldimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.coldimage.TabIndex = 4
		Me.coldimage.TabStop = False
		'
		'sunimage
		'
		Me.sunimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.sunimage.Image = Global.homematic.My.Resources.Resources.icons8_Sun_Filled_50
		Me.sunimage.Location = New System.Drawing.Point(376, 105)
		Me.sunimage.Name = "sunimage"
		Me.sunimage.Size = New System.Drawing.Size(30, 30)
		Me.sunimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.sunimage.TabIndex = 3
		Me.sunimage.TabStop = False
		'
		'templabel
		'
		Me.templabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.templabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.templabel.ForeColor = System.Drawing.Color.White
		Me.templabel.Location = New System.Drawing.Point(335, 105)
		Me.templabel.Name = "templabel"
		Me.templabel.Size = New System.Drawing.Size(40, 38)
		Me.templabel.TabIndex = 2
		Me.templabel.Text = "50"
		Me.templabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'templabel2
		'
		Me.templabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.templabel2.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.templabel2.ForeColor = System.Drawing.Color.White
		Me.templabel2.Location = New System.Drawing.Point(325, 168)
		Me.templabel2.Name = "templabel2"
		Me.templabel2.Size = New System.Drawing.Size(100, 59)
		Me.templabel2.TabIndex = 1
		Me.templabel2.Text = "50"
		Me.templabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.homematic.My.Resources.Resources.tempcontrol
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
		Me.apptab.Controls.Add(Me.GroupBox6)
		Me.apptab.Controls.Add(Me.GroupBox5)
		Me.apptab.Controls.Add(Me.GroupBox4)
		Me.apptab.Controls.Add(Me.Socket1)
		Me.apptab.Location = New System.Drawing.Point(4, 22)
		Me.apptab.Name = "apptab"
		Me.apptab.Size = New System.Drawing.Size(746, 418)
		Me.apptab.TabIndex = 2
		Me.apptab.Text = "Appliances"
		Me.apptab.UseVisualStyleBackColor = True
		'
		'Socket1
		'
		Me.Socket1.Controls.Add(Me.S1switchoff)
		Me.Socket1.Controls.Add(Me.S1switchon)
		Me.Socket1.Controls.Add(Me.PictureBox6)
		Me.Socket1.Location = New System.Drawing.Point(8, 9)
		Me.Socket1.Name = "Socket1"
		Me.Socket1.Size = New System.Drawing.Size(341, 197)
		Me.Socket1.TabIndex = 0
		Me.Socket1.TabStop = False
		Me.Socket1.Text = "Socket1"
		'
		'S1switchoff
		'
		Me.S1switchoff.BackColor = System.Drawing.Color.Transparent
		Me.S1switchoff.BackgroundImage = Global.homematic.My.Resources.Resources.rect8353
		Me.S1switchoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.S1switchoff.FlatAppearance.BorderSize = 0
		Me.S1switchoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.S1switchoff.Location = New System.Drawing.Point(284, 35)
		Me.S1switchoff.Name = "S1switchoff"
		Me.S1switchoff.Size = New System.Drawing.Size(37, 60)
		Me.S1switchoff.TabIndex = 4
		Me.S1switchoff.UseVisualStyleBackColor = False
		'
		'S1switchon
		'
		Me.S1switchon.BackColor = System.Drawing.Color.Transparent
		Me.S1switchon.BackgroundImage = Global.homematic.My.Resources.Resources._20142_NSNJPQ
		Me.S1switchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.S1switchon.FlatAppearance.BorderSize = 0
		Me.S1switchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.S1switchon.Location = New System.Drawing.Point(284, 35)
		Me.S1switchon.Name = "S1switchon"
		Me.S1switchon.Size = New System.Drawing.Size(37, 60)
		Me.S1switchon.TabIndex = 3
		Me.S1switchon.UseVisualStyleBackColor = False
		'
		'PictureBox6
		'
		Me.PictureBox6.Image = Global.homematic.My.Resources.Resources.bitmap1
		Me.PictureBox6.Location = New System.Drawing.Point(6, 19)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(255, 150)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox6.TabIndex = 0
		Me.PictureBox6.TabStop = False
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
		'humidtip
		'
		Me.humidtip.ToolTipTitle = "Humidity"
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
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.s2switchoff)
		Me.GroupBox4.Controls.Add(Me.s2switchon)
		Me.GroupBox4.Controls.Add(Me.PictureBox7)
		Me.GroupBox4.Location = New System.Drawing.Point(397, 9)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(341, 197)
		Me.GroupBox4.TabIndex = 5
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Socket2"
		'
		's2switchoff
		'
		Me.s2switchoff.BackColor = System.Drawing.Color.Transparent
		Me.s2switchoff.BackgroundImage = Global.homematic.My.Resources.Resources.rect8353
		Me.s2switchoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s2switchoff.FlatAppearance.BorderSize = 0
		Me.s2switchoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s2switchoff.Location = New System.Drawing.Point(284, 35)
		Me.s2switchoff.Name = "s2switchoff"
		Me.s2switchoff.Size = New System.Drawing.Size(37, 60)
		Me.s2switchoff.TabIndex = 4
		Me.s2switchoff.UseVisualStyleBackColor = False
		'
		's2switchon
		'
		Me.s2switchon.BackColor = System.Drawing.Color.Transparent
		Me.s2switchon.BackgroundImage = Global.homematic.My.Resources.Resources._20142_NSNJPQ
		Me.s2switchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s2switchon.FlatAppearance.BorderSize = 0
		Me.s2switchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s2switchon.Location = New System.Drawing.Point(284, 35)
		Me.s2switchon.Name = "s2switchon"
		Me.s2switchon.Size = New System.Drawing.Size(37, 60)
		Me.s2switchon.TabIndex = 3
		Me.s2switchon.UseVisualStyleBackColor = False
		'
		'PictureBox7
		'
		Me.PictureBox7.Image = Global.homematic.My.Resources.Resources.bitmap1
		Me.PictureBox7.Location = New System.Drawing.Point(6, 19)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(255, 150)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox7.TabIndex = 0
		Me.PictureBox7.TabStop = False
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.s3switchoff)
		Me.GroupBox5.Controls.Add(Me.s3switchon)
		Me.GroupBox5.Controls.Add(Me.PictureBox8)
		Me.GroupBox5.Location = New System.Drawing.Point(8, 213)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(341, 197)
		Me.GroupBox5.TabIndex = 5
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "socket3"
		'
		's3switchoff
		'
		Me.s3switchoff.BackColor = System.Drawing.Color.Transparent
		Me.s3switchoff.BackgroundImage = Global.homematic.My.Resources.Resources.rect8353
		Me.s3switchoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s3switchoff.FlatAppearance.BorderSize = 0
		Me.s3switchoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s3switchoff.Location = New System.Drawing.Point(284, 35)
		Me.s3switchoff.Name = "s3switchoff"
		Me.s3switchoff.Size = New System.Drawing.Size(37, 60)
		Me.s3switchoff.TabIndex = 4
		Me.s3switchoff.UseVisualStyleBackColor = False
		'
		's3switchon
		'
		Me.s3switchon.BackColor = System.Drawing.Color.Transparent
		Me.s3switchon.BackgroundImage = Global.homematic.My.Resources.Resources._20142_NSNJPQ
		Me.s3switchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s3switchon.FlatAppearance.BorderSize = 0
		Me.s3switchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s3switchon.Location = New System.Drawing.Point(284, 35)
		Me.s3switchon.Name = "s3switchon"
		Me.s3switchon.Size = New System.Drawing.Size(37, 60)
		Me.s3switchon.TabIndex = 3
		Me.s3switchon.UseVisualStyleBackColor = False
		'
		'PictureBox8
		'
		Me.PictureBox8.Image = Global.homematic.My.Resources.Resources.bitmap1
		Me.PictureBox8.Location = New System.Drawing.Point(6, 19)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(255, 150)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox8.TabIndex = 0
		Me.PictureBox8.TabStop = False
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.s4switchoff)
		Me.GroupBox6.Controls.Add(Me.s4switchon)
		Me.GroupBox6.Controls.Add(Me.PictureBox9)
		Me.GroupBox6.Location = New System.Drawing.Point(397, 213)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(341, 197)
		Me.GroupBox6.TabIndex = 5
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "socket4"
		'
		's4switchoff
		'
		Me.s4switchoff.BackColor = System.Drawing.Color.Transparent
		Me.s4switchoff.BackgroundImage = Global.homematic.My.Resources.Resources.rect8353
		Me.s4switchoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s4switchoff.FlatAppearance.BorderSize = 0
		Me.s4switchoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s4switchoff.Location = New System.Drawing.Point(284, 35)
		Me.s4switchoff.Name = "s4switchoff"
		Me.s4switchoff.Size = New System.Drawing.Size(37, 60)
		Me.s4switchoff.TabIndex = 4
		Me.s4switchoff.UseVisualStyleBackColor = False
		'
		's4switchon
		'
		Me.s4switchon.BackColor = System.Drawing.Color.Transparent
		Me.s4switchon.BackgroundImage = Global.homematic.My.Resources.Resources._20142_NSNJPQ
		Me.s4switchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.s4switchon.FlatAppearance.BorderSize = 0
		Me.s4switchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.s4switchon.Location = New System.Drawing.Point(284, 35)
		Me.s4switchon.Name = "s4switchon"
		Me.s4switchon.Size = New System.Drawing.Size(37, 60)
		Me.s4switchon.TabIndex = 3
		Me.s4switchon.UseVisualStyleBackColor = False
		'
		'PictureBox9
		'
		Me.PictureBox9.Image = Global.homematic.My.Resources.Resources.bitmap1
		Me.PictureBox9.Location = New System.Drawing.Point(6, 19)
		Me.PictureBox9.Name = "PictureBox9"
		Me.PictureBox9.Size = New System.Drawing.Size(255, 150)
		Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox9.TabIndex = 0
		Me.PictureBox9.TabStop = False
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
		Me.apptab.ResumeLayout(False)
		Me.Socket1.ResumeLayout(False)
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bulb, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox5.ResumeLayout(False)
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox6.ResumeLayout(False)
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents templabel As Label
	Friend WithEvents templabel2 As Label
	Friend WithEvents coldimage As PictureBox
	Friend WithEvents mediumhot As PictureBox
	Friend WithEvents humidbtn As Button
	Friend WithEvents Increasebtn As Button
	Friend WithEvents Decreasebtn As Button
	Friend WithEvents resetbtn As Button
	Friend WithEvents humidtip As ToolTip
	Friend WithEvents Socket1 As GroupBox
	Friend WithEvents PictureBox6 As PictureBox
	Friend WithEvents S1switchoff As Button
	Friend WithEvents S1switchon As Button
	Friend WithEvents GroupBox6 As GroupBox
	Friend WithEvents s4switchoff As Button
	Friend WithEvents s4switchon As Button
	Friend WithEvents PictureBox9 As PictureBox
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents s3switchoff As Button
	Friend WithEvents s3switchon As Button
	Friend WithEvents PictureBox8 As PictureBox
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents s2switchoff As Button
	Friend WithEvents s2switchon As Button
	Friend WithEvents PictureBox7 As PictureBox
End Class
