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
        Me.humidtip = New System.Windows.Forms.ToolTip(Me.components)
        Me.humidbtn = New System.Windows.Forms.Button()
        Me.vidtab = New System.Windows.Forms.TabPage()
        Me.BtnStop = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BtnStart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ImageBox = New Emgu.CV.UI.ImageBox()
        Me.temptab = New System.Windows.Forms.TabPage()
        Me.dhtTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.ambientTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.Increasebtn = New System.Windows.Forms.Button()
        Me.Decreasebtn = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.mediumhot = New System.Windows.Forms.PictureBox()
        Me.coldimage = New System.Windows.Forms.PictureBox()
        Me.sunimage = New System.Windows.Forms.PictureBox()
        Me.templabel = New System.Windows.Forms.Label()
        Me.templabel2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lighttab = New System.Windows.Forms.TabPage()
        Me.light3 = New System.Windows.Forms.GroupBox()
        Me.timerlabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.brightness2 = New System.Windows.Forms.Label()
        Me.lit2on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lit2off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.brighttrack3 = New System.Windows.Forms.TrackBar()
        Me.Light2 = New System.Windows.Forms.GroupBox()
        Me.timerLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lit1on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lit1off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.brightness1 = New System.Windows.Forms.Label()
        Me.brighttrack2 = New System.Windows.Forms.TrackBar()
        Me.Light1 = New System.Windows.Forms.GroupBox()
        Me.timerLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.lighton = New MaterialSkin.Controls.MaterialRadioButton()
        Me.brightness = New System.Windows.Forms.Label()
        Me.lightoff = New MaterialSkin.Controls.MaterialRadioButton()
        Me.brighttrack = New System.Windows.Forms.TrackBar()
        Me.control = New MaterialSkin.Controls.MaterialTabControl()
        Me.apptab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.app2Timerlbl = New MaterialSkin.Controls.MaterialLabel()
        Me.app3Timerlbl = New MaterialSkin.Controls.MaterialLabel()
        Me.power3off = New System.Windows.Forms.Button()
        Me.power3on = New System.Windows.Forms.Button()
        Me.power2off = New System.Windows.Forms.Button()
        Me.power2on = New System.Windows.Forms.Button()
        Me.Appgrp = New System.Windows.Forms.GroupBox()
        Me.app1TimerLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.tvoff = New System.Windows.Forms.Button()
        Me.poweron = New System.Windows.Forms.Button()
        Me.tvon = New System.Windows.Forms.Button()
        Me.tvTimerLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.poweroff = New System.Windows.Forms.Button()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bulb = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MasterBack = New System.Windows.Forms.Button()
        Me.MasterToDashboard = New System.Windows.Forms.Button()
        Me.DashButtonPanel = New System.Windows.Forms.Panel()
        Me.vidtab.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.temptab.SuspendLayout()
        CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lighttab.SuspendLayout()
        Me.light3.SuspendLayout()
        CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Light2.SuspendLayout()
        CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Light1.SuspendLayout()
        CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.control.SuspendLayout()
        Me.apptab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Appgrp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bulb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DashButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'humidtip
        '
        Me.humidtip.ToolTipTitle = "Humidity"
        '
        'humidbtn
        '
        Me.humidbtn.BackColor = System.Drawing.Color.Transparent
        Me.humidbtn.BackgroundImage = Global.homematic.My.Resources.Resources.Humidity
        Me.humidbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.humidbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.humidbtn.FlatAppearance.BorderSize = 0
        Me.humidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.humidbtn.Location = New System.Drawing.Point(215, 182)
        Me.humidbtn.Name = "humidbtn"
        Me.humidbtn.Size = New System.Drawing.Size(36, 31)
        Me.humidbtn.TabIndex = 6
        Me.humidtip.SetToolTip(Me.humidbtn, "Click to view humidity levels")
        Me.humidbtn.UseVisualStyleBackColor = False
        '
        'vidtab
        '
        Me.vidtab.BackColor = System.Drawing.Color.White
        Me.vidtab.Controls.Add(Me.BtnStop)
        Me.vidtab.Controls.Add(Me.BtnStart)
        Me.vidtab.Controls.Add(Me.ImageBox)
        Me.vidtab.Location = New System.Drawing.Point(4, 22)
        Me.vidtab.Name = "vidtab"
        Me.vidtab.Size = New System.Drawing.Size(746, 438)
        Me.vidtab.TabIndex = 3
        Me.vidtab.Text = "Surveillance"
        Me.vidtab.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.AutoSize = True
        Me.BtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnStop.Depth = 0
        Me.BtnStop.Icon = Nothing
        Me.BtnStop.Location = New System.Drawing.Point(645, 12)
        Me.BtnStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Primary = True
        Me.BtnStop.Size = New System.Drawing.Size(56, 36)
        Me.BtnStop.TabIndex = 4
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.AutoSize = True
        Me.BtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnStart.Depth = 0
        Me.BtnStart.Icon = Nothing
        Me.BtnStart.Location = New System.Drawing.Point(38, 12)
        Me.BtnStart.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Primary = True
        Me.BtnStart.Size = New System.Drawing.Size(64, 36)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'ImageBox
        '
        Me.ImageBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageBox.Location = New System.Drawing.Point(38, 54)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(663, 342)
        Me.ImageBox.TabIndex = 2
        Me.ImageBox.TabStop = False
        '
        'temptab
        '
        Me.temptab.BackColor = System.Drawing.Color.White
        Me.temptab.Controls.Add(Me.dhtTemp)
        Me.temptab.Controls.Add(Me.ambientTemp)
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
        Me.temptab.Size = New System.Drawing.Size(746, 438)
        Me.temptab.TabIndex = 1
        Me.temptab.Text = "Climate"
        '
        'dhtTemp
        '
        Me.dhtTemp.AutoSize = True
        Me.dhtTemp.Depth = 0
        Me.dhtTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.dhtTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dhtTemp.Location = New System.Drawing.Point(422, 22)
        Me.dhtTemp.MouseState = MaterialSkin.MouseState.HOVER
        Me.dhtTemp.Name = "dhtTemp"
        Me.dhtTemp.Size = New System.Drawing.Size(17, 19)
        Me.dhtTemp.TabIndex = 12
        Me.dhtTemp.Text = "0"
        '
        'ambientTemp
        '
        Me.ambientTemp.AutoSize = True
        Me.ambientTemp.Depth = 0
        Me.ambientTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.ambientTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ambientTemp.Location = New System.Drawing.Point(212, 22)
        Me.ambientTemp.MouseState = MaterialSkin.MouseState.HOVER
        Me.ambientTemp.Name = "ambientTemp"
        Me.ambientTemp.Size = New System.Drawing.Size(186, 19)
        Me.ambientTemp.TabIndex = 11
        Me.ambientTemp.Text = "Temparature and Humidity"
        '
        'Increasebtn
        '
        Me.Increasebtn.BackColor = System.Drawing.Color.Transparent
        Me.Increasebtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempIncrease
        Me.Increasebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Increasebtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Increasebtn.FlatAppearance.BorderSize = 0
        Me.Increasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Increasebtn.Location = New System.Drawing.Point(115, 112)
        Me.Increasebtn.Name = "Increasebtn"
        Me.Increasebtn.Size = New System.Drawing.Size(36, 31)
        Me.Increasebtn.TabIndex = 9
        Me.Increasebtn.UseVisualStyleBackColor = False
        '
        'Decreasebtn
        '
        Me.Decreasebtn.BackColor = System.Drawing.Color.Transparent
        Me.Decreasebtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempDecrease
        Me.Decreasebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Decreasebtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Decreasebtn.FlatAppearance.BorderSize = 0
        Me.Decreasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Decreasebtn.Location = New System.Drawing.Point(115, 237)
        Me.Decreasebtn.Name = "Decreasebtn"
        Me.Decreasebtn.Size = New System.Drawing.Size(36, 31)
        Me.Decreasebtn.TabIndex = 8
        Me.Decreasebtn.UseVisualStyleBackColor = False
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.Transparent
        Me.resetbtn.BackgroundImage = Global.homematic.My.Resources.Resources.Reset
        Me.resetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.resetbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.resetbtn.FlatAppearance.BorderSize = 0
        Me.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetbtn.Location = New System.Drawing.Point(470, 182)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(36, 31)
        Me.resetbtn.TabIndex = 7
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'mediumhot
        '
        Me.mediumhot.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.mediumhot.Image = Global.homematic.My.Resources.Resources.RoomTemp
        Me.mediumhot.Location = New System.Drawing.Point(371, 105)
        Me.mediumhot.Name = "mediumhot"
        Me.mediumhot.Size = New System.Drawing.Size(30, 30)
        Me.mediumhot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mediumhot.TabIndex = 5
        Me.mediumhot.TabStop = False
        '
        'coldimage
        '
        Me.coldimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.coldimage.Image = Global.homematic.My.Resources.Resources.Cold
        Me.coldimage.Location = New System.Drawing.Point(371, 105)
        Me.coldimage.Name = "coldimage"
        Me.coldimage.Size = New System.Drawing.Size(30, 30)
        Me.coldimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coldimage.TabIndex = 4
        Me.coldimage.TabStop = False
        '
        'sunimage
        '
        Me.sunimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.sunimage.Image = Global.homematic.My.Resources.Resources.Hot
        Me.sunimage.Location = New System.Drawing.Point(371, 105)
        Me.sunimage.Name = "sunimage"
        Me.sunimage.Size = New System.Drawing.Size(30, 30)
        Me.sunimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sunimage.TabIndex = 3
        Me.sunimage.TabStop = False
        '
        'templabel
        '
        Me.templabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.templabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.templabel.ForeColor = System.Drawing.Color.White
        Me.templabel.Location = New System.Drawing.Point(330, 105)
        Me.templabel.Name = "templabel"
        Me.templabel.Size = New System.Drawing.Size(40, 38)
        Me.templabel.TabIndex = 2
        Me.templabel.Text = "50"
        Me.templabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'templabel2
        '
        Me.templabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.templabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.templabel2.ForeColor = System.Drawing.Color.White
        Me.templabel2.Location = New System.Drawing.Point(320, 168)
        Me.templabel2.Name = "templabel2"
        Me.templabel2.Size = New System.Drawing.Size(100, 59)
        Me.templabel2.TabIndex = 1
        Me.templabel2.Text = "50"
        Me.templabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.homematic.My.Resources.Resources.tempcontrol
        Me.PictureBox1.Location = New System.Drawing.Point(166, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 418)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lighttab
        '
        Me.Lighttab.BackColor = System.Drawing.Color.White
        Me.Lighttab.Controls.Add(Me.light3)
        Me.Lighttab.Controls.Add(Me.Light2)
        Me.Lighttab.Controls.Add(Me.Light1)
        Me.Lighttab.Location = New System.Drawing.Point(4, 22)
        Me.Lighttab.Name = "Lighttab"
        Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
        Me.Lighttab.Size = New System.Drawing.Size(746, 438)
        Me.Lighttab.TabIndex = 0
        Me.Lighttab.Text = "Lights"
        '
        'light3
        '
        Me.light3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.light3.Controls.Add(Me.timerlabel3)
        Me.light3.Controls.Add(Me.brightness2)
        Me.light3.Controls.Add(Me.lit2on)
        Me.light3.Controls.Add(Me.lit2off)
        Me.light3.Controls.Add(Me.brighttrack3)
        Me.light3.Location = New System.Drawing.Point(3, 295)
        Me.light3.Name = "light3"
        Me.light3.Size = New System.Drawing.Size(740, 140)
        Me.light3.TabIndex = 20
        Me.light3.TabStop = False
        Me.light3.Text = "light3"
        '
        'timerlabel3
        '
        Me.timerlabel3.AutoSize = True
        Me.timerlabel3.Depth = 0
        Me.timerlabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.timerlabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timerlabel3.Location = New System.Drawing.Point(6, 75)
        Me.timerlabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.timerlabel3.Name = "timerlabel3"
        Me.timerlabel3.Size = New System.Drawing.Size(39, 19)
        Me.timerlabel3.TabIndex = 20
        Me.timerlabel3.Text = "time"
        '
        'brightness2
        '
        Me.brightness2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.brightness2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.brightness2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brightness2.ForeColor = System.Drawing.Color.White
        Me.brightness2.Location = New System.Drawing.Point(179, 75)
        Me.brightness2.Name = "brightness2"
        Me.brightness2.Size = New System.Drawing.Size(40, 30)
        Me.brightness2.TabIndex = 18
        Me.brightness2.Text = "0"
        Me.brightness2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lit2on
        '
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
        Me.brighttrack3.LargeChange = 1
        Me.brighttrack3.Location = New System.Drawing.Point(229, 69)
        Me.brighttrack3.Maximum = 4
        Me.brighttrack3.Name = "brighttrack3"
        Me.brighttrack3.Size = New System.Drawing.Size(325, 45)
        Me.brighttrack3.TabIndex = 1
        Me.brighttrack3.TabStop = False
        Me.brighttrack3.TickStyle = System.Windows.Forms.TickStyle.None
        Me.brighttrack3.Value = 4
        '
        'Light2
        '
        Me.Light2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Light2.Controls.Add(Me.timerLabel2)
        Me.Light2.Controls.Add(Me.lit1on)
        Me.Light2.Controls.Add(Me.lit1off)
        Me.Light2.Controls.Add(Me.brightness1)
        Me.Light2.Controls.Add(Me.brighttrack2)
        Me.Light2.Location = New System.Drawing.Point(3, 153)
        Me.Light2.Name = "Light2"
        Me.Light2.Size = New System.Drawing.Size(740, 140)
        Me.Light2.TabIndex = 20
        Me.Light2.TabStop = False
        Me.Light2.Text = "light2"
        '
        'timerLabel2
        '
        Me.timerLabel2.AutoSize = True
        Me.timerLabel2.Depth = 0
        Me.timerLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.timerLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timerLabel2.Location = New System.Drawing.Point(6, 95)
        Me.timerLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.timerLabel2.Name = "timerLabel2"
        Me.timerLabel2.Size = New System.Drawing.Size(39, 19)
        Me.timerLabel2.TabIndex = 19
        Me.timerLabel2.Text = "time"
        '
        'lit1on
        '
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
        Me.brightness1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brightness1.ForeColor = System.Drawing.Color.White
        Me.brightness1.Location = New System.Drawing.Point(179, 69)
        Me.brightness1.Name = "brightness1"
        Me.brightness1.Size = New System.Drawing.Size(40, 30)
        Me.brightness1.TabIndex = 17
        Me.brightness1.Text = "0"
        Me.brightness1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'brighttrack2
        '
        Me.brighttrack2.LargeChange = 1
        Me.brighttrack2.Location = New System.Drawing.Point(229, 69)
        Me.brighttrack2.Maximum = 4
        Me.brighttrack2.Name = "brighttrack2"
        Me.brighttrack2.Size = New System.Drawing.Size(325, 45)
        Me.brighttrack2.TabIndex = 1
        Me.brighttrack2.TabStop = False
        Me.brighttrack2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.brighttrack2.Value = 4
        '
        'Light1
        '
        Me.Light1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Light1.Controls.Add(Me.timerLabel)
        Me.Light1.Controls.Add(Me.lighton)
        Me.Light1.Controls.Add(Me.brightness)
        Me.Light1.Controls.Add(Me.lightoff)
        Me.Light1.Controls.Add(Me.brighttrack)
        Me.Light1.Location = New System.Drawing.Point(3, 3)
        Me.Light1.Name = "Light1"
        Me.Light1.Size = New System.Drawing.Size(740, 140)
        Me.Light1.TabIndex = 19
        Me.Light1.TabStop = False
        Me.Light1.Text = "light1"
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Depth = 0
        Me.timerLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.timerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timerLabel.Location = New System.Drawing.Point(6, 105)
        Me.timerLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(39, 19)
        Me.timerLabel.TabIndex = 18
        Me.timerLabel.Text = "time"
        '
        'lighton
        '
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
        Me.lighton.Text = "ON"
        Me.lighton.UseVisualStyleBackColor = True
        '
        'brightness
        '
        Me.brightness.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.brightness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.brightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brightness.ForeColor = System.Drawing.Color.White
        Me.brightness.Location = New System.Drawing.Point(179, 56)
        Me.brightness.Name = "brightness"
        Me.brightness.Size = New System.Drawing.Size(40, 30)
        Me.brightness.TabIndex = 18
        Me.brightness.Text = "0"
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
        Me.brighttrack.LargeChange = 1
        Me.brighttrack.Location = New System.Drawing.Point(229, 56)
        Me.brighttrack.Maximum = 4
        Me.brighttrack.Name = "brighttrack"
        Me.brighttrack.Size = New System.Drawing.Size(325, 45)
        Me.brighttrack.TabIndex = 1
        Me.brighttrack.TabStop = False
        Me.brighttrack.TickStyle = System.Windows.Forms.TickStyle.None
        Me.brighttrack.Value = 4
        '
        'control
        '
        Me.control.Controls.Add(Me.Lighttab)
        Me.control.Controls.Add(Me.temptab)
        Me.control.Controls.Add(Me.apptab)
        Me.control.Controls.Add(Me.vidtab)
        Me.control.Depth = 0
        Me.control.Location = New System.Drawing.Point(0, 95)
        Me.control.MouseState = MaterialSkin.MouseState.HOVER
        Me.control.Name = "control"
        Me.control.SelectedIndex = 0
        Me.control.Size = New System.Drawing.Size(754, 464)
        Me.control.TabIndex = 0
        '
        'apptab
        '
        Me.apptab.BackColor = System.Drawing.Color.White
        Me.apptab.Controls.Add(Me.Label1)
        Me.apptab.Controls.Add(Me.GroupBox1)
        Me.apptab.Controls.Add(Me.Appgrp)
        Me.apptab.Location = New System.Drawing.Point(4, 22)
        Me.apptab.Name = "apptab"
        Me.apptab.Size = New System.Drawing.Size(746, 438)
        Me.apptab.TabIndex = 2
        Me.apptab.Text = "Appliances"
        Me.apptab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(529, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.app2Timerlbl)
        Me.GroupBox1.Controls.Add(Me.app3Timerlbl)
        Me.GroupBox1.Controls.Add(Me.power3off)
        Me.GroupBox1.Controls.Add(Me.power3on)
        Me.GroupBox1.Controls.Add(Me.power2off)
        Me.GroupBox1.Controls.Add(Me.power2on)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 408)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connections"
        '
        'app2Timerlbl
        '
        Me.app2Timerlbl.AutoSize = True
        Me.app2Timerlbl.Depth = 0
        Me.app2Timerlbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.app2Timerlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.app2Timerlbl.Location = New System.Drawing.Point(38, 246)
        Me.app2Timerlbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.app2Timerlbl.Name = "app2Timerlbl"
        Me.app2Timerlbl.Size = New System.Drawing.Size(108, 19)
        Me.app2Timerlbl.TabIndex = 11
        Me.app2Timerlbl.Text = "MaterialLabel3"
        '
        'app3Timerlbl
        '
        Me.app3Timerlbl.AutoSize = True
        Me.app3Timerlbl.Depth = 0
        Me.app3Timerlbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.app3Timerlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.app3Timerlbl.Location = New System.Drawing.Point(38, 95)
        Me.app3Timerlbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.app3Timerlbl.Name = "app3Timerlbl"
        Me.app3Timerlbl.Size = New System.Drawing.Size(108, 19)
        Me.app3Timerlbl.TabIndex = 12
        Me.app3Timerlbl.Text = "MaterialLabel4"
        '
        'power3off
        '
        Me.power3off.BackColor = System.Drawing.Color.Transparent
        Me.power3off.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.power3off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.power3off.FlatAppearance.BorderSize = 0
        Me.power3off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power3off.Location = New System.Drawing.Point(72, 43)
        Me.power3off.Name = "power3off"
        Me.power3off.Size = New System.Drawing.Size(40, 40)
        Me.power3off.TabIndex = 7
        Me.power3off.UseVisualStyleBackColor = False
        '
        'power3on
        '
        Me.power3on.BackColor = System.Drawing.Color.Transparent
        Me.power3on.BackgroundImage = Global.homematic.My.Resources.Resources.poweron
        Me.power3on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.power3on.FlatAppearance.BorderSize = 0
        Me.power3on.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power3on.Location = New System.Drawing.Point(72, 43)
        Me.power3on.Name = "power3on"
        Me.power3on.Size = New System.Drawing.Size(40, 40)
        Me.power3on.TabIndex = 6
        Me.power3on.UseVisualStyleBackColor = False
        '
        'power2off
        '
        Me.power2off.BackColor = System.Drawing.Color.Transparent
        Me.power2off.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.power2off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.power2off.FlatAppearance.BorderSize = 0
        Me.power2off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power2off.Location = New System.Drawing.Point(72, 184)
        Me.power2off.Name = "power2off"
        Me.power2off.Size = New System.Drawing.Size(40, 40)
        Me.power2off.TabIndex = 4
        Me.power2off.UseVisualStyleBackColor = False
        '
        'power2on
        '
        Me.power2on.BackColor = System.Drawing.Color.Transparent
        Me.power2on.BackgroundImage = Global.homematic.My.Resources.Resources.poweron
        Me.power2on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.power2on.FlatAppearance.BorderSize = 0
        Me.power2on.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power2on.Location = New System.Drawing.Point(72, 184)
        Me.power2on.Name = "power2on"
        Me.power2on.Size = New System.Drawing.Size(40, 40)
        Me.power2on.TabIndex = 5
        Me.power2on.UseVisualStyleBackColor = False
        '
        'Appgrp
        '
        Me.Appgrp.Controls.Add(Me.app1TimerLbl)
        Me.Appgrp.Controls.Add(Me.tvoff)
        Me.Appgrp.Controls.Add(Me.poweron)
        Me.Appgrp.Controls.Add(Me.tvon)
        Me.Appgrp.Controls.Add(Me.tvTimerLabel)
        Me.Appgrp.Controls.Add(Me.poweroff)
        Me.Appgrp.Location = New System.Drawing.Point(28, 3)
        Me.Appgrp.Name = "Appgrp"
        Me.Appgrp.Size = New System.Drawing.Size(178, 408)
        Me.Appgrp.TabIndex = 6
        Me.Appgrp.TabStop = False
        Me.Appgrp.Text = "Appliances"
        '
        'app1TimerLbl
        '
        Me.app1TimerLbl.AutoSize = True
        Me.app1TimerLbl.Depth = 0
        Me.app1TimerLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.app1TimerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.app1TimerLbl.Location = New System.Drawing.Point(35, 243)
        Me.app1TimerLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.app1TimerLbl.Name = "app1TimerLbl"
        Me.app1TimerLbl.Size = New System.Drawing.Size(108, 19)
        Me.app1TimerLbl.TabIndex = 10
        Me.app1TimerLbl.Text = "MaterialLabel2"
        '
        'tvoff
        '
        Me.tvoff.BackColor = System.Drawing.Color.Transparent
        Me.tvoff.BackgroundImage = Global.homematic.My.Resources.Resources.tvoff
        Me.tvoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tvoff.FlatAppearance.BorderSize = 0
        Me.tvoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tvoff.Location = New System.Drawing.Point(72, 40)
        Me.tvoff.Name = "tvoff"
        Me.tvoff.Size = New System.Drawing.Size(40, 40)
        Me.tvoff.TabIndex = 3
        Me.tvoff.UseVisualStyleBackColor = False
        '
        'poweron
        '
        Me.poweron.BackColor = System.Drawing.Color.Transparent
        Me.poweron.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.poweron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.poweron.FlatAppearance.BorderSize = 0
        Me.poweron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.poweron.Location = New System.Drawing.Point(58, 181)
        Me.poweron.Name = "poweron"
        Me.poweron.Size = New System.Drawing.Size(40, 40)
        Me.poweron.TabIndex = 4
        Me.poweron.UseVisualStyleBackColor = False
        '
        'tvon
        '
        Me.tvon.BackColor = System.Drawing.Color.Transparent
        Me.tvon.BackgroundImage = Global.homematic.My.Resources.Resources.tvon
        Me.tvon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tvon.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.tvon.FlatAppearance.BorderSize = 0
        Me.tvon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tvon.Location = New System.Drawing.Point(72, 40)
        Me.tvon.Name = "tvon"
        Me.tvon.Size = New System.Drawing.Size(40, 40)
        Me.tvon.TabIndex = 0
        Me.tvon.UseVisualStyleBackColor = False
        '
        'tvTimerLabel
        '
        Me.tvTimerLabel.AutoSize = True
        Me.tvTimerLabel.Depth = 0
        Me.tvTimerLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.tvTimerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tvTimerLabel.Location = New System.Drawing.Point(35, 92)
        Me.tvTimerLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.tvTimerLabel.Name = "tvTimerLabel"
        Me.tvTimerLabel.Size = New System.Drawing.Size(108, 19)
        Me.tvTimerLabel.TabIndex = 9
        Me.tvTimerLabel.Text = "MaterialLabel1"
        '
        'poweroff
        '
        Me.poweroff.BackColor = System.Drawing.Color.Transparent
        Me.poweroff.BackgroundImage = Global.homematic.My.Resources.Resources.poweron
        Me.poweroff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.poweroff.FlatAppearance.BorderSize = 0
        Me.poweroff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.poweroff.Location = New System.Drawing.Point(58, 181)
        Me.poweroff.Name = "poweroff"
        Me.poweroff.Size = New System.Drawing.Size(40, 40)
        Me.poweroff.TabIndex = 5
        Me.poweroff.UseVisualStyleBackColor = False
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.control
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 62)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(754, 27)
        Me.MaterialTabSelector1.TabIndex = 8
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.bulb)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(35, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 40)
        Me.Panel1.TabIndex = 9
        '
        'bulb
        '
        Me.bulb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bulb.BackColor = System.Drawing.Color.Transparent
        Me.bulb.Image = Global.homematic.My.Resources.Resources.LightIcon
        Me.bulb.Location = New System.Drawing.Point(5, 7)
        Me.bulb.Name = "bulb"
        Me.bulb.Size = New System.Drawing.Size(35, 30)
        Me.bulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bulb.TabIndex = 2
        Me.bulb.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.homematic.My.Resources.Resources.VideoIcon
        Me.PictureBox4.Location = New System.Drawing.Point(337, 10)
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
        Me.PictureBox3.Image = Global.homematic.My.Resources.Resources.ApplianceIcon
        Me.PictureBox3.Location = New System.Drawing.Point(217, 10)
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
        Me.PictureBox2.Image = Global.homematic.My.Resources.Resources.TempIcon
        Me.PictureBox2.Location = New System.Drawing.Point(105, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'SerialPort1
        '
        '
        'MasterBack
        '
        Me.MasterBack.BackColor = System.Drawing.Color.Transparent
        Me.MasterBack.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
        Me.MasterBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MasterBack.FlatAppearance.BorderSize = 0
        Me.MasterBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MasterBack.Location = New System.Drawing.Point(4, 4)
        Me.MasterBack.Name = "MasterBack"
        Me.MasterBack.Size = New System.Drawing.Size(15, 15)
        Me.MasterBack.TabIndex = 7
        Me.MasterBack.UseVisualStyleBackColor = False
        '
        'MasterToDashboard
        '
        Me.MasterToDashboard.BackColor = System.Drawing.Color.Transparent
        Me.MasterToDashboard.FlatAppearance.BorderSize = 0
        Me.MasterToDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MasterToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MasterToDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToDashboard.ForeColor = System.Drawing.Color.White
        Me.MasterToDashboard.Location = New System.Drawing.Point(17, 3)
        Me.MasterToDashboard.Name = "MasterToDashboard"
        Me.MasterToDashboard.Size = New System.Drawing.Size(90, 33)
        Me.MasterToDashboard.TabIndex = 10
        Me.MasterToDashboard.Text = "Dashboard"
        Me.MasterToDashboard.UseVisualStyleBackColor = False
        '
        'DashButtonPanel
        '
        Me.DashButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashButtonPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashButtonPanel.Controls.Add(Me.MasterToDashboard)
        Me.DashButtonPanel.Location = New System.Drawing.Point(643, 24)
        Me.DashButtonPanel.Name = "DashButtonPanel"
        Me.DashButtonPanel.Size = New System.Drawing.Size(110, 40)
        Me.DashButtonPanel.TabIndex = 11
        '
        'RoomA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 559)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MasterBack)
        Me.Controls.Add(Me.control)
        Me.Controls.Add(Me.DashButtonPanel)
        Me.Name = "RoomA"
        Me.vidtab.ResumeLayout(False)
        Me.vidtab.PerformLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.temptab.ResumeLayout(False)
        Me.temptab.PerformLayout()
        CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coldimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lighttab.ResumeLayout(False)
        Me.light3.ResumeLayout(False)
        Me.light3.PerformLayout()
        CType(Me.brighttrack3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Light2.ResumeLayout(False)
        Me.Light2.PerformLayout()
        CType(Me.brighttrack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Light1.ResumeLayout(False)
        Me.Light1.PerformLayout()
        CType(Me.brighttrack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.control.ResumeLayout(False)
        Me.apptab.ResumeLayout(False)
        Me.apptab.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Appgrp.ResumeLayout(False)
        Me.Appgrp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bulb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DashButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bulb As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents MasterBack As Button
	Friend WithEvents humidtip As ToolTip
	Friend WithEvents vidtab As TabPage
	Friend WithEvents BtnStop As MaterialSkin.Controls.MaterialRaisedButton
	Friend WithEvents BtnStart As MaterialSkin.Controls.MaterialRaisedButton
	Friend WithEvents ImageBox As Emgu.CV.UI.ImageBox
	Friend WithEvents temptab As TabPage
	Friend WithEvents Increasebtn As Button
	Friend WithEvents Decreasebtn As Button
	Friend WithEvents resetbtn As Button
	Friend WithEvents humidbtn As Button
	Friend WithEvents mediumhot As PictureBox
	Friend WithEvents coldimage As PictureBox
	Friend WithEvents sunimage As PictureBox
	Friend WithEvents templabel As Label
	Friend WithEvents templabel2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Lighttab As TabPage
	Friend WithEvents light3 As GroupBox
	Friend WithEvents brightness2 As Label
	Friend WithEvents lit2on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents lit2off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brighttrack3 As TrackBar
	Friend WithEvents Light2 As GroupBox
	Friend WithEvents lit1on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents lit1off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brightness1 As Label
	Friend WithEvents brighttrack2 As TrackBar
	Friend WithEvents Light1 As GroupBox
	Friend WithEvents lighton As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brightness As Label
	Friend WithEvents lightoff As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents brighttrack As TrackBar
	Friend WithEvents control As MaterialSkin.Controls.MaterialTabControl
	Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
	Friend WithEvents Panel1 As Panel
	Friend WithEvents SerialPort1 As IO.Ports.SerialPort
	Friend WithEvents apptab As TabPage
	Friend WithEvents tvoff As Button
	Friend WithEvents poweron As Button
	Friend WithEvents tvon As Button
	Friend WithEvents poweroff As Button
	Friend WithEvents Appgrp As GroupBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents power3off As Button
	Friend WithEvents power3on As Button
	Friend WithEvents power2off As Button
	Friend WithEvents power2on As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents MasterToDashboard As Button
	Friend WithEvents DashButtonPanel As Panel
    Friend WithEvents dhtTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ambientTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents timerLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents timerLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents timerlabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents app2Timerlbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents app3Timerlbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents app1TimerLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tvTimerLabel As MaterialSkin.Controls.MaterialLabel
End Class
