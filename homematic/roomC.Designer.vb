<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomC
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
        Me.Room3VidStop = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Room3VidStart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ImageBox = New Emgu.CV.UI.ImageBox()
        Me.temptab = New System.Windows.Forms.TabPage()
        Me.Room3dhtTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.ambientTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3TempLbl = New System.Windows.Forms.Label()
        Me.Room3TempLbl2 = New System.Windows.Forms.Label()
        Me.Room3TempIncBtn = New System.Windows.Forms.Button()
        Me.Room3TempDecBtn = New System.Windows.Forms.Button()
        Me.Room3TempResetBtn = New System.Windows.Forms.Button()
        Me.mediumhot = New System.Windows.Forms.PictureBox()
        Me.coldimage = New System.Windows.Forms.PictureBox()
        Me.sunimage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lighttab = New System.Windows.Forms.TabPage()
        Me.Room3light3 = New System.Windows.Forms.GroupBox()
        Me.Room3Light3TimerLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3Light3Lbl = New System.Windows.Forms.Label()
        Me.Room3Light3on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light3off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light3Bri = New System.Windows.Forms.TrackBar()
        Me.Room3Light2 = New System.Windows.Forms.GroupBox()
        Me.Room3Light2TimerLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3Light2on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light2off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light2Lbl = New System.Windows.Forms.Label()
        Me.Room3Light2Bri = New System.Windows.Forms.TrackBar()
        Me.Room3Light1 = New System.Windows.Forms.GroupBox()
        Me.Room3Light1TimerLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3Light1on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light1Lbl = New System.Windows.Forms.Label()
        Me.Room3Light1off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room3Light1Bri = New System.Windows.Forms.TrackBar()
        Me.MasterTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.apptab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Room3AppGrpBox2 = New System.Windows.Forms.GroupBox()
        Me.Room3Pw2Lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3Pw3Lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Room3Pw2Btn = New System.Windows.Forms.Button()
        Me.Room3Pw3Btn = New System.Windows.Forms.Button()
        Me.Room3AppBrpBox = New System.Windows.Forms.GroupBox()
        Me.Room3Pw1Lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.tvBtn = New System.Windows.Forms.Button()
        Me.Room3Pw1Btn = New System.Windows.Forms.Button()
        Me.tvLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bulb = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Room3SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Room3ToDashboard = New System.Windows.Forms.Button()
        Me.DashButtonPanel = New System.Windows.Forms.Panel()
        Me.Room3Back = New System.Windows.Forms.Button()
        Me.vidtab.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.temptab.SuspendLayout()
        CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lighttab.SuspendLayout()
        Me.Room3light3.SuspendLayout()
        CType(Me.Room3Light3Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Room3Light2.SuspendLayout()
        CType(Me.Room3Light2Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Room3Light1.SuspendLayout()
        CType(Me.Room3Light1Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterTabControl.SuspendLayout()
        Me.apptab.SuspendLayout()
        Me.Room3AppGrpBox2.SuspendLayout()
        Me.Room3AppBrpBox.SuspendLayout()
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
        Me.vidtab.Controls.Add(Me.Room3VidStop)
        Me.vidtab.Controls.Add(Me.Room3VidStart)
        Me.vidtab.Controls.Add(Me.ImageBox)
        Me.vidtab.Location = New System.Drawing.Point(4, 22)
        Me.vidtab.Name = "vidtab"
        Me.vidtab.Size = New System.Drawing.Size(746, 438)
        Me.vidtab.TabIndex = 3
        Me.vidtab.Text = "Surveillance"
        Me.vidtab.UseVisualStyleBackColor = True
        '
        'Room3VidStop
        '
        Me.Room3VidStop.AutoSize = True
        Me.Room3VidStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Room3VidStop.Depth = 0
        Me.Room3VidStop.Icon = Nothing
        Me.Room3VidStop.Location = New System.Drawing.Point(645, 12)
        Me.Room3VidStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3VidStop.Name = "Room3VidStop"
        Me.Room3VidStop.Primary = True
        Me.Room3VidStop.Size = New System.Drawing.Size(56, 36)
        Me.Room3VidStop.TabIndex = 4
        Me.Room3VidStop.Text = "Stop"
        Me.Room3VidStop.UseVisualStyleBackColor = True
        '
        'Room3VidStart
        '
        Me.Room3VidStart.AutoSize = True
        Me.Room3VidStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Room3VidStart.Depth = 0
        Me.Room3VidStart.Icon = Nothing
        Me.Room3VidStart.Location = New System.Drawing.Point(38, 12)
        Me.Room3VidStart.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3VidStart.Name = "Room3VidStart"
        Me.Room3VidStart.Primary = True
        Me.Room3VidStart.Size = New System.Drawing.Size(64, 36)
        Me.Room3VidStart.TabIndex = 3
        Me.Room3VidStart.Text = "Start"
        Me.Room3VidStart.UseVisualStyleBackColor = True
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
        Me.temptab.Controls.Add(Me.Room3dhtTemp)
        Me.temptab.Controls.Add(Me.ambientTemp)
        Me.temptab.Controls.Add(Me.Room3TempLbl)
        Me.temptab.Controls.Add(Me.Room3TempLbl2)
        Me.temptab.Controls.Add(Me.Room3TempIncBtn)
        Me.temptab.Controls.Add(Me.Room3TempDecBtn)
        Me.temptab.Controls.Add(Me.Room3TempResetBtn)
        Me.temptab.Controls.Add(Me.humidbtn)
        Me.temptab.Controls.Add(Me.mediumhot)
        Me.temptab.Controls.Add(Me.coldimage)
        Me.temptab.Controls.Add(Me.sunimage)
        Me.temptab.Controls.Add(Me.PictureBox1)
        Me.temptab.Location = New System.Drawing.Point(4, 22)
        Me.temptab.Name = "temptab"
        Me.temptab.Padding = New System.Windows.Forms.Padding(3)
        Me.temptab.Size = New System.Drawing.Size(746, 438)
        Me.temptab.TabIndex = 1
        Me.temptab.Text = "Climate"
        '
        'Room3dhtTemp
        '
        Me.Room3dhtTemp.AutoSize = True
        Me.Room3dhtTemp.Depth = 0
        Me.Room3dhtTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3dhtTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3dhtTemp.Location = New System.Drawing.Point(422, 22)
        Me.Room3dhtTemp.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3dhtTemp.Name = "Room3dhtTemp"
        Me.Room3dhtTemp.Size = New System.Drawing.Size(17, 19)
        Me.Room3dhtTemp.TabIndex = 12
        Me.Room3dhtTemp.Text = "0"
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
        'Room3TempLbl
        '
        Me.Room3TempLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room3TempLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3TempLbl.ForeColor = System.Drawing.Color.White
        Me.Room3TempLbl.Location = New System.Drawing.Point(330, 105)
        Me.Room3TempLbl.Name = "Room3TempLbl"
        Me.Room3TempLbl.Size = New System.Drawing.Size(40, 38)
        Me.Room3TempLbl.TabIndex = 2
        Me.Room3TempLbl.Text = "50"
        Me.Room3TempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room3TempLbl2
        '
        Me.Room3TempLbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room3TempLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3TempLbl2.ForeColor = System.Drawing.Color.White
        Me.Room3TempLbl2.Location = New System.Drawing.Point(320, 168)
        Me.Room3TempLbl2.Name = "Room3TempLbl2"
        Me.Room3TempLbl2.Size = New System.Drawing.Size(100, 59)
        Me.Room3TempLbl2.TabIndex = 1
        Me.Room3TempLbl2.Text = "50"
        Me.Room3TempLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room3TempIncBtn
        '
        Me.Room3TempIncBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room3TempIncBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempIncrease
        Me.Room3TempIncBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3TempIncBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room3TempIncBtn.FlatAppearance.BorderSize = 0
        Me.Room3TempIncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3TempIncBtn.Location = New System.Drawing.Point(115, 112)
        Me.Room3TempIncBtn.Name = "Room3TempIncBtn"
        Me.Room3TempIncBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room3TempIncBtn.TabIndex = 9
        Me.Room3TempIncBtn.UseVisualStyleBackColor = False
        '
        'Room3TempDecBtn
        '
        Me.Room3TempDecBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room3TempDecBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempDecrease
        Me.Room3TempDecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3TempDecBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room3TempDecBtn.FlatAppearance.BorderSize = 0
        Me.Room3TempDecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3TempDecBtn.Location = New System.Drawing.Point(115, 237)
        Me.Room3TempDecBtn.Name = "Room3TempDecBtn"
        Me.Room3TempDecBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room3TempDecBtn.TabIndex = 8
        Me.Room3TempDecBtn.UseVisualStyleBackColor = False
        '
        'Room3TempResetBtn
        '
        Me.Room3TempResetBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room3TempResetBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Reset
        Me.Room3TempResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3TempResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room3TempResetBtn.FlatAppearance.BorderSize = 0
        Me.Room3TempResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3TempResetBtn.Location = New System.Drawing.Point(470, 182)
        Me.Room3TempResetBtn.Name = "Room3TempResetBtn"
        Me.Room3TempResetBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room3TempResetBtn.TabIndex = 7
        Me.Room3TempResetBtn.UseVisualStyleBackColor = False
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
        Me.Lighttab.Controls.Add(Me.Room3light3)
        Me.Lighttab.Controls.Add(Me.Room3Light2)
        Me.Lighttab.Controls.Add(Me.Room3Light1)
        Me.Lighttab.Location = New System.Drawing.Point(4, 22)
        Me.Lighttab.Name = "Lighttab"
        Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
        Me.Lighttab.Size = New System.Drawing.Size(746, 438)
        Me.Lighttab.TabIndex = 0
        Me.Lighttab.Text = "Lights"
        '
        'Room3light3
        '
        Me.Room3light3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room3light3.Controls.Add(Me.Room3Light3TimerLbl)
        Me.Room3light3.Controls.Add(Me.Room3Light3Lbl)
        Me.Room3light3.Controls.Add(Me.Room3Light3on)
        Me.Room3light3.Controls.Add(Me.Room3Light3off)
        Me.Room3light3.Controls.Add(Me.Room3Light3Bri)
        Me.Room3light3.Location = New System.Drawing.Point(3, 295)
        Me.Room3light3.Name = "Room3light3"
        Me.Room3light3.Size = New System.Drawing.Size(740, 140)
        Me.Room3light3.TabIndex = 20
        Me.Room3light3.TabStop = False
        Me.Room3light3.Text = "light3"
        '
        'Room3Light3TimerLbl
        '
        Me.Room3Light3TimerLbl.AutoSize = True
        Me.Room3Light3TimerLbl.Depth = 0
        Me.Room3Light3TimerLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Light3TimerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Light3TimerLbl.Location = New System.Drawing.Point(6, 75)
        Me.Room3Light3TimerLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light3TimerLbl.Name = "Room3Light3TimerLbl"
        Me.Room3Light3TimerLbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Light3TimerLbl.TabIndex = 20
        Me.Room3Light3TimerLbl.Text = "time"
        '
        'Room3Light3Lbl
        '
        Me.Room3Light3Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room3Light3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room3Light3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3Light3Lbl.ForeColor = System.Drawing.Color.White
        Me.Room3Light3Lbl.Location = New System.Drawing.Point(179, 75)
        Me.Room3Light3Lbl.Name = "Room3Light3Lbl"
        Me.Room3Light3Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room3Light3Lbl.TabIndex = 18
        Me.Room3Light3Lbl.Text = "0"
        Me.Room3Light3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room3Light3on
        '
        Me.Room3Light3on.Depth = 0
        Me.Room3Light3on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light3on.Location = New System.Drawing.Point(113, 33)
        Me.Room3Light3on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light3on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light3on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light3on.Name = "Room3Light3on"
        Me.Room3Light3on.Ripple = True
        Me.Room3Light3on.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light3on.TabIndex = 0
        Me.Room3Light3on.Text = "ON"
        Me.Room3Light3on.UseVisualStyleBackColor = True
        '
        'Room3Light3off
        '
        Me.Room3Light3off.Depth = 0
        Me.Room3Light3off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light3off.Location = New System.Drawing.Point(580, 16)
        Me.Room3Light3off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light3off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light3off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light3off.Name = "Room3Light3off"
        Me.Room3Light3off.Ripple = True
        Me.Room3Light3off.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light3off.TabIndex = 1
        Me.Room3Light3off.Text = "OFF"
        Me.Room3Light3off.UseVisualStyleBackColor = True
        '
        'Room3Light3Bri
        '
        Me.Room3Light3Bri.LargeChange = 1
        Me.Room3Light3Bri.Location = New System.Drawing.Point(229, 69)
        Me.Room3Light3Bri.Maximum = 4
        Me.Room3Light3Bri.Name = "Room3Light3Bri"
        Me.Room3Light3Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room3Light3Bri.TabIndex = 1
        Me.Room3Light3Bri.TabStop = False
        Me.Room3Light3Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room3Light3Bri.Value = 4
        '
        'Room3Light2
        '
        Me.Room3Light2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room3Light2.Controls.Add(Me.Room3Light2TimerLbl)
        Me.Room3Light2.Controls.Add(Me.Room3Light2on)
        Me.Room3Light2.Controls.Add(Me.Room3Light2off)
        Me.Room3Light2.Controls.Add(Me.Room3Light2Lbl)
        Me.Room3Light2.Controls.Add(Me.Room3Light2Bri)
        Me.Room3Light2.Location = New System.Drawing.Point(3, 153)
        Me.Room3Light2.Name = "Room3Light2"
        Me.Room3Light2.Size = New System.Drawing.Size(740, 140)
        Me.Room3Light2.TabIndex = 20
        Me.Room3Light2.TabStop = False
        Me.Room3Light2.Text = "light2"
        '
        'Room3Light2TimerLbl
        '
        Me.Room3Light2TimerLbl.AutoSize = True
        Me.Room3Light2TimerLbl.Depth = 0
        Me.Room3Light2TimerLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Light2TimerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Light2TimerLbl.Location = New System.Drawing.Point(6, 95)
        Me.Room3Light2TimerLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light2TimerLbl.Name = "Room3Light2TimerLbl"
        Me.Room3Light2TimerLbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Light2TimerLbl.TabIndex = 19
        Me.Room3Light2TimerLbl.Text = "time"
        '
        'Room3Light2on
        '
        Me.Room3Light2on.Depth = 0
        Me.Room3Light2on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light2on.Location = New System.Drawing.Point(113, 29)
        Me.Room3Light2on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light2on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light2on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light2on.Name = "Room3Light2on"
        Me.Room3Light2on.Ripple = True
        Me.Room3Light2on.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light2on.TabIndex = 0
        Me.Room3Light2on.Text = "ON"
        Me.Room3Light2on.UseVisualStyleBackColor = True
        '
        'Room3Light2off
        '
        Me.Room3Light2off.Depth = 0
        Me.Room3Light2off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light2off.Location = New System.Drawing.Point(580, 29)
        Me.Room3Light2off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light2off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light2off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light2off.Name = "Room3Light2off"
        Me.Room3Light2off.Ripple = True
        Me.Room3Light2off.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light2off.TabIndex = 1
        Me.Room3Light2off.Text = "OFF"
        Me.Room3Light2off.UseVisualStyleBackColor = True
        '
        'Room3Light2Lbl
        '
        Me.Room3Light2Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room3Light2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room3Light2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3Light2Lbl.ForeColor = System.Drawing.Color.White
        Me.Room3Light2Lbl.Location = New System.Drawing.Point(179, 69)
        Me.Room3Light2Lbl.Name = "Room3Light2Lbl"
        Me.Room3Light2Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room3Light2Lbl.TabIndex = 17
        Me.Room3Light2Lbl.Text = "0"
        Me.Room3Light2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room3Light2Bri
        '
        Me.Room3Light2Bri.LargeChange = 1
        Me.Room3Light2Bri.Location = New System.Drawing.Point(229, 69)
        Me.Room3Light2Bri.Maximum = 4
        Me.Room3Light2Bri.Name = "Room3Light2Bri"
        Me.Room3Light2Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room3Light2Bri.TabIndex = 1
        Me.Room3Light2Bri.TabStop = False
        Me.Room3Light2Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room3Light2Bri.Value = 4
        '
        'Room3Light1
        '
        Me.Room3Light1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room3Light1.Controls.Add(Me.Room3Light1TimerLbl)
        Me.Room3Light1.Controls.Add(Me.Room3Light1on)
        Me.Room3Light1.Controls.Add(Me.Room3Light1Lbl)
        Me.Room3Light1.Controls.Add(Me.Room3Light1off)
        Me.Room3Light1.Controls.Add(Me.Room3Light1Bri)
        Me.Room3Light1.Location = New System.Drawing.Point(3, 3)
        Me.Room3Light1.Name = "Room3Light1"
        Me.Room3Light1.Size = New System.Drawing.Size(740, 140)
        Me.Room3Light1.TabIndex = 19
        Me.Room3Light1.TabStop = False
        Me.Room3Light1.Text = "light1"
        '
        'Room3Light1TimerLbl
        '
        Me.Room3Light1TimerLbl.AutoSize = True
        Me.Room3Light1TimerLbl.Depth = 0
        Me.Room3Light1TimerLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Light1TimerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Light1TimerLbl.Location = New System.Drawing.Point(6, 105)
        Me.Room3Light1TimerLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light1TimerLbl.Name = "Room3Light1TimerLbl"
        Me.Room3Light1TimerLbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Light1TimerLbl.TabIndex = 18
        Me.Room3Light1TimerLbl.Text = "time"
        '
        'Room3Light1on
        '
        Me.Room3Light1on.Depth = 0
        Me.Room3Light1on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light1on.Location = New System.Drawing.Point(113, 16)
        Me.Room3Light1on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light1on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light1on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light1on.Name = "Room3Light1on"
        Me.Room3Light1on.Ripple = True
        Me.Room3Light1on.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light1on.TabIndex = 0
        Me.Room3Light1on.Text = "ON"
        Me.Room3Light1on.UseVisualStyleBackColor = True
        '
        'Room3Light1Lbl
        '
        Me.Room3Light1Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room3Light1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room3Light1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3Light1Lbl.ForeColor = System.Drawing.Color.White
        Me.Room3Light1Lbl.Location = New System.Drawing.Point(179, 56)
        Me.Room3Light1Lbl.Name = "Room3Light1Lbl"
        Me.Room3Light1Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room3Light1Lbl.TabIndex = 18
        Me.Room3Light1Lbl.Text = "0"
        Me.Room3Light1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room3Light1off
        '
        Me.Room3Light1off.Depth = 0
        Me.Room3Light1off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room3Light1off.Location = New System.Drawing.Point(580, 16)
        Me.Room3Light1off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room3Light1off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room3Light1off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Light1off.Name = "Room3Light1off"
        Me.Room3Light1off.Ripple = True
        Me.Room3Light1off.Size = New System.Drawing.Size(55, 30)
        Me.Room3Light1off.TabIndex = 1
        Me.Room3Light1off.Text = "OFF"
        Me.Room3Light1off.UseVisualStyleBackColor = True
        '
        'Room3Light1Bri
        '
        Me.Room3Light1Bri.LargeChange = 1
        Me.Room3Light1Bri.Location = New System.Drawing.Point(229, 56)
        Me.Room3Light1Bri.Maximum = 4
        Me.Room3Light1Bri.Name = "Room3Light1Bri"
        Me.Room3Light1Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room3Light1Bri.TabIndex = 1
        Me.Room3Light1Bri.TabStop = False
        Me.Room3Light1Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room3Light1Bri.Value = 4
        '
        'MasterTabControl
        '
        Me.MasterTabControl.Controls.Add(Me.Lighttab)
        Me.MasterTabControl.Controls.Add(Me.temptab)
        Me.MasterTabControl.Controls.Add(Me.apptab)
        Me.MasterTabControl.Controls.Add(Me.vidtab)
        Me.MasterTabControl.Depth = 0
        Me.MasterTabControl.Location = New System.Drawing.Point(0, 95)
        Me.MasterTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.MasterTabControl.Name = "MasterTabControl"
        Me.MasterTabControl.SelectedIndex = 0
        Me.MasterTabControl.Size = New System.Drawing.Size(754, 464)
        Me.MasterTabControl.TabIndex = 0
        '
        'apptab
        '
        Me.apptab.BackColor = System.Drawing.Color.White
        Me.apptab.Controls.Add(Me.Label1)
        Me.apptab.Controls.Add(Me.Room3AppGrpBox2)
        Me.apptab.Controls.Add(Me.Room3AppBrpBox)
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
        'Room3AppGrpBox2
        '
        Me.Room3AppGrpBox2.Controls.Add(Me.Room3Pw2Lbl)
        Me.Room3AppGrpBox2.Controls.Add(Me.Room3Pw3Lbl)
        Me.Room3AppGrpBox2.Controls.Add(Me.Room3Pw2Btn)
        Me.Room3AppGrpBox2.Controls.Add(Me.Room3Pw3Btn)
        Me.Room3AppGrpBox2.Location = New System.Drawing.Point(326, 0)
        Me.Room3AppGrpBox2.Name = "Room3AppGrpBox2"
        Me.Room3AppGrpBox2.Size = New System.Drawing.Size(178, 408)
        Me.Room3AppGrpBox2.TabIndex = 7
        Me.Room3AppGrpBox2.TabStop = False
        Me.Room3AppGrpBox2.Text = "Connections"
        '
        'Room3Pw2Lbl
        '
        Me.Room3Pw2Lbl.AutoSize = True
        Me.Room3Pw2Lbl.Depth = 0
        Me.Room3Pw2Lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Pw2Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Pw2Lbl.Location = New System.Drawing.Point(38, 95)
        Me.Room3Pw2Lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Pw2Lbl.Name = "Room3Pw2Lbl"
        Me.Room3Pw2Lbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Pw2Lbl.TabIndex = 11
        Me.Room3Pw2Lbl.Text = "time"
        '
        'Room3Pw3Lbl
        '
        Me.Room3Pw3Lbl.AutoSize = True
        Me.Room3Pw3Lbl.Depth = 0
        Me.Room3Pw3Lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Pw3Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Pw3Lbl.Location = New System.Drawing.Point(38, 246)
        Me.Room3Pw3Lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Pw3Lbl.Name = "Room3Pw3Lbl"
        Me.Room3Pw3Lbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Pw3Lbl.TabIndex = 12
        Me.Room3Pw3Lbl.Text = "time"
        '
        'Room3Pw2Btn
        '
        Me.Room3Pw2Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room3Pw2Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room3Pw2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3Pw2Btn.FlatAppearance.BorderSize = 0
        Me.Room3Pw2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3Pw2Btn.Location = New System.Drawing.Point(73, 52)
        Me.Room3Pw2Btn.Name = "Room3Pw2Btn"
        Me.Room3Pw2Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room3Pw2Btn.TabIndex = 7
        Me.Room3Pw2Btn.UseVisualStyleBackColor = False
        '
        'Room3Pw3Btn
        '
        Me.Room3Pw3Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room3Pw3Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room3Pw3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3Pw3Btn.FlatAppearance.BorderSize = 0
        Me.Room3Pw3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3Pw3Btn.Location = New System.Drawing.Point(73, 186)
        Me.Room3Pw3Btn.Name = "Room3Pw3Btn"
        Me.Room3Pw3Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room3Pw3Btn.TabIndex = 4
        Me.Room3Pw3Btn.UseVisualStyleBackColor = False
        '
        'Room3AppBrpBox
        '
        Me.Room3AppBrpBox.Controls.Add(Me.Room3Pw1Lbl)
        Me.Room3AppBrpBox.Controls.Add(Me.tvBtn)
        Me.Room3AppBrpBox.Controls.Add(Me.Room3Pw1Btn)
        Me.Room3AppBrpBox.Controls.Add(Me.tvLbl)
        Me.Room3AppBrpBox.Location = New System.Drawing.Point(28, 3)
        Me.Room3AppBrpBox.Name = "Room3AppBrpBox"
        Me.Room3AppBrpBox.Size = New System.Drawing.Size(178, 408)
        Me.Room3AppBrpBox.TabIndex = 6
        Me.Room3AppBrpBox.TabStop = False
        Me.Room3AppBrpBox.Text = "Appliances"
        '
        'Room3Pw1Lbl
        '
        Me.Room3Pw1Lbl.AutoSize = True
        Me.Room3Pw1Lbl.Depth = 0
        Me.Room3Pw1Lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room3Pw1Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room3Pw1Lbl.Location = New System.Drawing.Point(35, 243)
        Me.Room3Pw1Lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room3Pw1Lbl.Name = "Room3Pw1Lbl"
        Me.Room3Pw1Lbl.Size = New System.Drawing.Size(39, 19)
        Me.Room3Pw1Lbl.TabIndex = 10
        Me.Room3Pw1Lbl.Text = "time"
        '
        'tvBtn
        '
        Me.tvBtn.BackColor = System.Drawing.Color.Transparent
        Me.tvBtn.BackgroundImage = Global.homematic.My.Resources.Resources.tvoff
        Me.tvBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tvBtn.FlatAppearance.BorderSize = 0
        Me.tvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tvBtn.Location = New System.Drawing.Point(67, 49)
        Me.tvBtn.Name = "tvBtn"
        Me.tvBtn.Size = New System.Drawing.Size(40, 40)
        Me.tvBtn.TabIndex = 3
        Me.tvBtn.UseVisualStyleBackColor = False
        '
        'Room3Pw1Btn
        '
        Me.Room3Pw1Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room3Pw1Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room3Pw1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3Pw1Btn.FlatAppearance.BorderSize = 0
        Me.Room3Pw1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3Pw1Btn.Location = New System.Drawing.Point(58, 183)
        Me.Room3Pw1Btn.Name = "Room3Pw1Btn"
        Me.Room3Pw1Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room3Pw1Btn.TabIndex = 4
        Me.Room3Pw1Btn.UseVisualStyleBackColor = False
        '
        'tvLbl
        '
        Me.tvLbl.AutoSize = True
        Me.tvLbl.Depth = 0
        Me.tvLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.tvLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tvLbl.Location = New System.Drawing.Point(35, 92)
        Me.tvLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.tvLbl.Name = "tvLbl"
        Me.tvLbl.Size = New System.Drawing.Size(39, 19)
        Me.tvLbl.TabIndex = 9
        Me.tvLbl.Text = "time"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MasterTabControl
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
        'Room3SerialPort1
        '
        '
        'Room3ToDashboard
        '
        Me.Room3ToDashboard.BackColor = System.Drawing.Color.Transparent
        Me.Room3ToDashboard.FlatAppearance.BorderSize = 0
        Me.Room3ToDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Room3ToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3ToDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room3ToDashboard.ForeColor = System.Drawing.Color.White
        Me.Room3ToDashboard.Location = New System.Drawing.Point(17, 3)
        Me.Room3ToDashboard.Name = "Room3ToDashboard"
        Me.Room3ToDashboard.Size = New System.Drawing.Size(90, 33)
        Me.Room3ToDashboard.TabIndex = 10
        Me.Room3ToDashboard.Text = "Dashboard"
        Me.Room3ToDashboard.UseVisualStyleBackColor = False
        '
        'DashButtonPanel
        '
        Me.DashButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashButtonPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashButtonPanel.Controls.Add(Me.Room3ToDashboard)
        Me.DashButtonPanel.Location = New System.Drawing.Point(643, 24)
        Me.DashButtonPanel.Name = "DashButtonPanel"
        Me.DashButtonPanel.Size = New System.Drawing.Size(110, 40)
        Me.DashButtonPanel.TabIndex = 11
        '
        'Room3Back
        '
        Me.Room3Back.BackColor = System.Drawing.Color.Transparent
        Me.Room3Back.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
        Me.Room3Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room3Back.FlatAppearance.BorderSize = 0
        Me.Room3Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room3Back.Location = New System.Drawing.Point(4, 4)
        Me.Room3Back.Name = "Room3Back"
        Me.Room3Back.Size = New System.Drawing.Size(15, 15)
        Me.Room3Back.TabIndex = 7
        Me.Room3Back.UseVisualStyleBackColor = False
        '
        'RoomC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 559)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Room3Back)
        Me.Controls.Add(Me.MasterTabControl)
        Me.Controls.Add(Me.DashButtonPanel)
        Me.Name = "RoomC"
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
        Me.Room3light3.ResumeLayout(False)
        Me.Room3light3.PerformLayout()
        CType(Me.Room3Light3Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Room3Light2.ResumeLayout(False)
        Me.Room3Light2.PerformLayout()
        CType(Me.Room3Light2Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Room3Light1.ResumeLayout(False)
        Me.Room3Light1.PerformLayout()
        CType(Me.Room3Light1Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterTabControl.ResumeLayout(False)
        Me.apptab.ResumeLayout(False)
        Me.apptab.PerformLayout()
        Me.Room3AppGrpBox2.ResumeLayout(False)
        Me.Room3AppGrpBox2.PerformLayout()
        Me.Room3AppBrpBox.ResumeLayout(False)
        Me.Room3AppBrpBox.PerformLayout()
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
	Friend WithEvents Room3Back As Button
	Friend WithEvents humidtip As ToolTip
	Friend WithEvents vidtab As TabPage
	Friend WithEvents Room3VidStop As MaterialSkin.Controls.MaterialRaisedButton
	Friend WithEvents Room3VidStart As MaterialSkin.Controls.MaterialRaisedButton
	Friend WithEvents ImageBox As Emgu.CV.UI.ImageBox
	Friend WithEvents temptab As TabPage
	Friend WithEvents Room3TempIncBtn As Button
	Friend WithEvents Room3TempDecBtn As Button
	Friend WithEvents Room3TempResetBtn As Button
	Friend WithEvents humidbtn As Button
	Friend WithEvents mediumhot As PictureBox
	Friend WithEvents coldimage As PictureBox
	Friend WithEvents sunimage As PictureBox
	Friend WithEvents Room3TempLbl As Label
	Friend WithEvents Room3TempLbl2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Lighttab As TabPage
	Friend WithEvents Room3light3 As GroupBox
	Friend WithEvents Room3Light3Lbl As Label
	Friend WithEvents Room3Light3on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light3off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light3Bri As TrackBar
	Friend WithEvents Room3Light2 As GroupBox
	Friend WithEvents Room3Light2on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light2off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light2Lbl As Label
	Friend WithEvents Room3Light2Bri As TrackBar
	Friend WithEvents Room3Light1 As GroupBox
	Friend WithEvents Room3Light1on As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light1Lbl As Label
	Friend WithEvents Room3Light1off As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents Room3Light1Bri As TrackBar
	Friend WithEvents MasterTabControl As MaterialSkin.Controls.MaterialTabControl
	Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Room3SerialPort1 As IO.Ports.SerialPort
	Friend WithEvents apptab As TabPage
	Friend WithEvents tvBtn As Button
	Friend WithEvents Room3Pw1Btn As Button
    Friend WithEvents Room3AppBrpBox As GroupBox
    Friend WithEvents Room3AppGrpBox2 As GroupBox
    Friend WithEvents Room3Pw2Btn As Button
    Friend WithEvents Room3Pw3Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Room3ToDashboard As Button
	Friend WithEvents DashButtonPanel As Panel
    Friend WithEvents Room3dhtTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ambientTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Light1TimerLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Light2TimerLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Light3TimerLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Pw2Lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Pw3Lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Room3Pw1Lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tvLbl As MaterialSkin.Controls.MaterialLabel
End Class
