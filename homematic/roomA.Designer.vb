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
		Me.Room1VidStop = New MaterialSkin.Controls.MaterialRaisedButton()
		Me.Room1VidStart = New MaterialSkin.Controls.MaterialRaisedButton()
		Me.ImageBox = New Emgu.CV.UI.ImageBox()
		Me.temptab = New System.Windows.Forms.TabPage()
		Me.Room1dhtTemp = New MaterialSkin.Controls.MaterialLabel()
		Me.ambientTemp = New MaterialSkin.Controls.MaterialLabel()
		Me.Room1TempLbl = New System.Windows.Forms.Label()
		Me.Room1TempLbl2 = New System.Windows.Forms.Label()
		Me.Room1TempIncBtn = New System.Windows.Forms.Button()
		Me.Room1TempDecBtn = New System.Windows.Forms.Button()
		Me.Room1TempResetBtn = New System.Windows.Forms.Button()
		Me.mediumhot = New System.Windows.Forms.PictureBox()
		Me.coldimage = New System.Windows.Forms.PictureBox()
		Me.sunimage = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Lighttab = New System.Windows.Forms.TabPage()
		Me.Room1light3 = New System.Windows.Forms.GroupBox()
		Me.Room1Light3Lbl = New System.Windows.Forms.Label()
		Me.Room1Light3on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light3off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light3Bri = New System.Windows.Forms.TrackBar()
		Me.Room2Light2 = New System.Windows.Forms.GroupBox()
		Me.Room1Light2on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light2off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light2Lbl = New System.Windows.Forms.Label()
		Me.Room1Light2Bri = New System.Windows.Forms.TrackBar()
		Me.Room1Light1 = New System.Windows.Forms.GroupBox()
		Me.Room1Light1on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light1Lbl = New System.Windows.Forms.Label()
		Me.Room1Light1off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room1Light1Bri = New System.Windows.Forms.TrackBar()
		Me.MasterTabControl = New MaterialSkin.Controls.MaterialTabControl()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Room1AppGrpBox2 = New System.Windows.Forms.GroupBox()
		Me.Room1Pw2Btn = New System.Windows.Forms.Button()
		Me.Room1Pw3Btn = New System.Windows.Forms.Button()
		Me.Room1AppBrpBox = New System.Windows.Forms.GroupBox()
		Me.tvBtn = New System.Windows.Forms.Button()
		Me.Room1Pw1Btn = New System.Windows.Forms.Button()
		Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.bulb = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Room1SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.Room1ToDashboard = New System.Windows.Forms.Button()
		Me.DashButtonPanel = New System.Windows.Forms.Panel()
		Me.Room1Back = New System.Windows.Forms.Button()
		Me.vidtab.SuspendLayout()
		CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.temptab.SuspendLayout()
		CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Lighttab.SuspendLayout()
		Me.Room1light3.SuspendLayout()
		CType(Me.Room1Light3Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Room2Light2.SuspendLayout()
		CType(Me.Room1Light2Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Room1Light1.SuspendLayout()
		CType(Me.Room1Light1Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MasterTabControl.SuspendLayout()
		Me.apptab.SuspendLayout()
		Me.Room1AppGrpBox2.SuspendLayout()
		Me.Room1AppBrpBox.SuspendLayout()
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
		Me.vidtab.Controls.Add(Me.Room1VidStop)
		Me.vidtab.Controls.Add(Me.Room1VidStart)
		Me.vidtab.Controls.Add(Me.ImageBox)
		Me.vidtab.Location = New System.Drawing.Point(4, 22)
		Me.vidtab.Name = "vidtab"
		Me.vidtab.Size = New System.Drawing.Size(746, 438)
		Me.vidtab.TabIndex = 3
		Me.vidtab.Text = "Surveillance"
		Me.vidtab.UseVisualStyleBackColor = True
		'
		'Room1VidStop
		'
		Me.Room1VidStop.AutoSize = True
		Me.Room1VidStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Room1VidStop.Depth = 0
		Me.Room1VidStop.Icon = Nothing
		Me.Room1VidStop.Location = New System.Drawing.Point(645, 12)
		Me.Room1VidStop.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1VidStop.Name = "Room1VidStop"
		Me.Room1VidStop.Primary = True
		Me.Room1VidStop.Size = New System.Drawing.Size(56, 36)
		Me.Room1VidStop.TabIndex = 4
		Me.Room1VidStop.Text = "Stop"
		Me.Room1VidStop.UseVisualStyleBackColor = True
		'
		'Room1VidStart
		'
		Me.Room1VidStart.AutoSize = True
		Me.Room1VidStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Room1VidStart.Depth = 0
		Me.Room1VidStart.Icon = Nothing
		Me.Room1VidStart.Location = New System.Drawing.Point(38, 12)
		Me.Room1VidStart.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1VidStart.Name = "Room1VidStart"
		Me.Room1VidStart.Primary = True
		Me.Room1VidStart.Size = New System.Drawing.Size(64, 36)
		Me.Room1VidStart.TabIndex = 3
		Me.Room1VidStart.Text = "Start"
		Me.Room1VidStart.UseVisualStyleBackColor = True
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
		Me.temptab.Controls.Add(Me.Room1dhtTemp)
		Me.temptab.Controls.Add(Me.ambientTemp)
		Me.temptab.Controls.Add(Me.Room1TempLbl)
		Me.temptab.Controls.Add(Me.Room1TempLbl2)
		Me.temptab.Controls.Add(Me.Room1TempIncBtn)
		Me.temptab.Controls.Add(Me.Room1TempDecBtn)
		Me.temptab.Controls.Add(Me.Room1TempResetBtn)
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
		'Room1dhtTemp
		'
		Me.Room1dhtTemp.AutoSize = True
		Me.Room1dhtTemp.Depth = 0
		Me.Room1dhtTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
		Me.Room1dhtTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Room1dhtTemp.Location = New System.Drawing.Point(422, 22)
		Me.Room1dhtTemp.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1dhtTemp.Name = "Room1dhtTemp"
		Me.Room1dhtTemp.Size = New System.Drawing.Size(17, 19)
		Me.Room1dhtTemp.TabIndex = 12
		Me.Room1dhtTemp.Text = "0"
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
		'Room1TempLbl
		'
		Me.Room1TempLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room1TempLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1TempLbl.ForeColor = System.Drawing.Color.White
		Me.Room1TempLbl.Location = New System.Drawing.Point(330, 105)
		Me.Room1TempLbl.Name = "Room1TempLbl"
		Me.Room1TempLbl.Size = New System.Drawing.Size(40, 38)
		Me.Room1TempLbl.TabIndex = 2
		Me.Room1TempLbl.Text = "50"
		Me.Room1TempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room1TempLbl2
		'
		Me.Room1TempLbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room1TempLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1TempLbl2.ForeColor = System.Drawing.Color.White
		Me.Room1TempLbl2.Location = New System.Drawing.Point(320, 168)
		Me.Room1TempLbl2.Name = "Room1TempLbl2"
		Me.Room1TempLbl2.Size = New System.Drawing.Size(100, 59)
		Me.Room1TempLbl2.TabIndex = 1
		Me.Room1TempLbl2.Text = "50"
		Me.Room1TempLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room1TempIncBtn
		'
		Me.Room1TempIncBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room1TempIncBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempIncrease
		Me.Room1TempIncBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1TempIncBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room1TempIncBtn.FlatAppearance.BorderSize = 0
		Me.Room1TempIncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1TempIncBtn.Location = New System.Drawing.Point(115, 112)
		Me.Room1TempIncBtn.Name = "Room1TempIncBtn"
		Me.Room1TempIncBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room1TempIncBtn.TabIndex = 9
		Me.Room1TempIncBtn.UseVisualStyleBackColor = False
		'
		'Room1TempDecBtn
		'
		Me.Room1TempDecBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room1TempDecBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempDecrease
		Me.Room1TempDecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1TempDecBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room1TempDecBtn.FlatAppearance.BorderSize = 0
		Me.Room1TempDecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1TempDecBtn.Location = New System.Drawing.Point(115, 237)
		Me.Room1TempDecBtn.Name = "Room1TempDecBtn"
		Me.Room1TempDecBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room1TempDecBtn.TabIndex = 8
		Me.Room1TempDecBtn.UseVisualStyleBackColor = False
		'
		'Room1TempResetBtn
		'
		Me.Room1TempResetBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room1TempResetBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Reset
		Me.Room1TempResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1TempResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room1TempResetBtn.FlatAppearance.BorderSize = 0
		Me.Room1TempResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1TempResetBtn.Location = New System.Drawing.Point(470, 182)
		Me.Room1TempResetBtn.Name = "Room1TempResetBtn"
		Me.Room1TempResetBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room1TempResetBtn.TabIndex = 7
		Me.Room1TempResetBtn.UseVisualStyleBackColor = False
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
		Me.Lighttab.Controls.Add(Me.Room1light3)
		Me.Lighttab.Controls.Add(Me.Room2Light2)
		Me.Lighttab.Controls.Add(Me.Room1Light1)
		Me.Lighttab.Location = New System.Drawing.Point(4, 22)
		Me.Lighttab.Name = "Lighttab"
		Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
		Me.Lighttab.Size = New System.Drawing.Size(746, 438)
		Me.Lighttab.TabIndex = 0
		Me.Lighttab.Text = "Lights"
		'
		'Room1light3
		'
		Me.Room1light3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room1light3.Controls.Add(Me.Room1Light3Lbl)
		Me.Room1light3.Controls.Add(Me.Room1Light3on)
		Me.Room1light3.Controls.Add(Me.Room1Light3off)
		Me.Room1light3.Controls.Add(Me.Room1Light3Bri)
		Me.Room1light3.Location = New System.Drawing.Point(3, 295)
		Me.Room1light3.Name = "Room1light3"
		Me.Room1light3.Size = New System.Drawing.Size(740, 140)
		Me.Room1light3.TabIndex = 20
		Me.Room1light3.TabStop = False
		Me.Room1light3.Text = "light3"
		'
		'Room1Light3Lbl
		'
		Me.Room1Light3Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room1Light3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room1Light3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1Light3Lbl.ForeColor = System.Drawing.Color.White
		Me.Room1Light3Lbl.Location = New System.Drawing.Point(179, 75)
		Me.Room1Light3Lbl.Name = "Room1Light3Lbl"
		Me.Room1Light3Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room1Light3Lbl.TabIndex = 18
		Me.Room1Light3Lbl.Text = "0"
		Me.Room1Light3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room1Light3on
		'
		Me.Room1Light3on.Depth = 0
		Me.Room1Light3on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light3on.Location = New System.Drawing.Point(113, 33)
		Me.Room1Light3on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light3on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light3on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light3on.Name = "Room1Light3on"
		Me.Room1Light3on.Ripple = True
		Me.Room1Light3on.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light3on.TabIndex = 0
		Me.Room1Light3on.Text = "ON"
		Me.Room1Light3on.UseVisualStyleBackColor = True
		'
		'Room1Light3off
		'
		Me.Room1Light3off.Checked = True
		Me.Room1Light3off.Depth = 0
		Me.Room1Light3off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light3off.Location = New System.Drawing.Point(580, 16)
		Me.Room1Light3off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light3off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light3off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light3off.Name = "Room1Light3off"
		Me.Room1Light3off.Ripple = True
		Me.Room1Light3off.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light3off.TabIndex = 1
		Me.Room1Light3off.TabStop = True
		Me.Room1Light3off.Text = "OFF"
		Me.Room1Light3off.UseVisualStyleBackColor = True
		'
		'Room1Light3Bri
		'
		Me.Room1Light3Bri.LargeChange = 1
		Me.Room1Light3Bri.Location = New System.Drawing.Point(229, 69)
		Me.Room1Light3Bri.Maximum = 4
		Me.Room1Light3Bri.Name = "Room1Light3Bri"
		Me.Room1Light3Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room1Light3Bri.TabIndex = 1
		Me.Room1Light3Bri.TabStop = False
		Me.Room1Light3Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room1Light3Bri.Value = 4
		'
		'Room2Light2
		'
		Me.Room2Light2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room2Light2.Controls.Add(Me.Room1Light2on)
		Me.Room2Light2.Controls.Add(Me.Room1Light2off)
		Me.Room2Light2.Controls.Add(Me.Room1Light2Lbl)
		Me.Room2Light2.Controls.Add(Me.Room1Light2Bri)
		Me.Room2Light2.Location = New System.Drawing.Point(3, 153)
		Me.Room2Light2.Name = "Room2Light2"
		Me.Room2Light2.Size = New System.Drawing.Size(740, 140)
		Me.Room2Light2.TabIndex = 20
		Me.Room2Light2.TabStop = False
		Me.Room2Light2.Text = "light2"
		'
		'Room1Light2on
		'
		Me.Room1Light2on.Depth = 0
		Me.Room1Light2on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light2on.Location = New System.Drawing.Point(113, 29)
		Me.Room1Light2on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light2on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light2on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light2on.Name = "Room1Light2on"
		Me.Room1Light2on.Ripple = True
		Me.Room1Light2on.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light2on.TabIndex = 0
		Me.Room1Light2on.Text = "ON"
		Me.Room1Light2on.UseVisualStyleBackColor = True
		'
		'Room1Light2off
		'
		Me.Room1Light2off.Checked = True
		Me.Room1Light2off.Depth = 0
		Me.Room1Light2off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light2off.Location = New System.Drawing.Point(580, 29)
		Me.Room1Light2off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light2off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light2off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light2off.Name = "Room1Light2off"
		Me.Room1Light2off.Ripple = True
		Me.Room1Light2off.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light2off.TabIndex = 1
		Me.Room1Light2off.TabStop = True
		Me.Room1Light2off.Text = "OFF"
		Me.Room1Light2off.UseVisualStyleBackColor = True
		'
		'Room1Light2Lbl
		'
		Me.Room1Light2Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room1Light2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room1Light2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1Light2Lbl.ForeColor = System.Drawing.Color.White
		Me.Room1Light2Lbl.Location = New System.Drawing.Point(179, 69)
		Me.Room1Light2Lbl.Name = "Room1Light2Lbl"
		Me.Room1Light2Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room1Light2Lbl.TabIndex = 17
		Me.Room1Light2Lbl.Text = "0"
		Me.Room1Light2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room1Light2Bri
		'
		Me.Room1Light2Bri.LargeChange = 1
		Me.Room1Light2Bri.Location = New System.Drawing.Point(229, 69)
		Me.Room1Light2Bri.Maximum = 4
		Me.Room1Light2Bri.Name = "Room1Light2Bri"
		Me.Room1Light2Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room1Light2Bri.TabIndex = 1
		Me.Room1Light2Bri.TabStop = False
		Me.Room1Light2Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room1Light2Bri.Value = 4
		'
		'Room1Light1
		'
		Me.Room1Light1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room1Light1.Controls.Add(Me.Room1Light1on)
		Me.Room1Light1.Controls.Add(Me.Room1Light1Lbl)
		Me.Room1Light1.Controls.Add(Me.Room1Light1off)
		Me.Room1Light1.Controls.Add(Me.Room1Light1Bri)
		Me.Room1Light1.Location = New System.Drawing.Point(3, 3)
		Me.Room1Light1.Name = "Room1Light1"
		Me.Room1Light1.Size = New System.Drawing.Size(740, 140)
		Me.Room1Light1.TabIndex = 19
		Me.Room1Light1.TabStop = False
		Me.Room1Light1.Text = "light1"
		'
		'Room1Light1on
		'
		Me.Room1Light1on.Depth = 0
		Me.Room1Light1on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light1on.Location = New System.Drawing.Point(113, 16)
		Me.Room1Light1on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light1on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light1on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light1on.Name = "Room1Light1on"
		Me.Room1Light1on.Ripple = True
		Me.Room1Light1on.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light1on.TabIndex = 0
		Me.Room1Light1on.Text = "ON"
		Me.Room1Light1on.UseVisualStyleBackColor = True
		'
		'Room1Light1Lbl
		'
		Me.Room1Light1Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room1Light1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room1Light1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1Light1Lbl.ForeColor = System.Drawing.Color.White
		Me.Room1Light1Lbl.Location = New System.Drawing.Point(179, 56)
		Me.Room1Light1Lbl.Name = "Room1Light1Lbl"
		Me.Room1Light1Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room1Light1Lbl.TabIndex = 18
		Me.Room1Light1Lbl.Text = "0"
		Me.Room1Light1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room1Light1off
		'
		Me.Room1Light1off.Checked = True
		Me.Room1Light1off.Depth = 0
		Me.Room1Light1off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room1Light1off.Location = New System.Drawing.Point(580, 16)
		Me.Room1Light1off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room1Light1off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room1Light1off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room1Light1off.Name = "Room1Light1off"
		Me.Room1Light1off.Ripple = True
		Me.Room1Light1off.Size = New System.Drawing.Size(55, 30)
		Me.Room1Light1off.TabIndex = 1
		Me.Room1Light1off.TabStop = True
		Me.Room1Light1off.Text = "OFF"
		Me.Room1Light1off.UseVisualStyleBackColor = True
		'
		'Room1Light1Bri
		'
		Me.Room1Light1Bri.LargeChange = 1
		Me.Room1Light1Bri.Location = New System.Drawing.Point(229, 56)
		Me.Room1Light1Bri.Maximum = 4
		Me.Room1Light1Bri.Name = "Room1Light1Bri"
		Me.Room1Light1Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room1Light1Bri.TabIndex = 1
		Me.Room1Light1Bri.TabStop = False
		Me.Room1Light1Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room1Light1Bri.Value = 4
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
		Me.apptab.Controls.Add(Me.Room1AppGrpBox2)
		Me.apptab.Controls.Add(Me.Room1AppBrpBox)
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
		'Room1AppGrpBox2
		'
		Me.Room1AppGrpBox2.Controls.Add(Me.Room1Pw2Btn)
		Me.Room1AppGrpBox2.Controls.Add(Me.Room1Pw3Btn)
		Me.Room1AppGrpBox2.Location = New System.Drawing.Point(326, 0)
		Me.Room1AppGrpBox2.Name = "Room1AppGrpBox2"
		Me.Room1AppGrpBox2.Size = New System.Drawing.Size(178, 408)
		Me.Room1AppGrpBox2.TabIndex = 7
		Me.Room1AppGrpBox2.TabStop = False
		Me.Room1AppGrpBox2.Text = "Connections"
		'
		'Room1Pw2Btn
		'
		Me.Room1Pw2Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room1Pw2Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room1Pw2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1Pw2Btn.FlatAppearance.BorderSize = 0
		Me.Room1Pw2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1Pw2Btn.Location = New System.Drawing.Point(73, 52)
		Me.Room1Pw2Btn.Name = "Room1Pw2Btn"
		Me.Room1Pw2Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room1Pw2Btn.TabIndex = 7
		Me.Room1Pw2Btn.UseVisualStyleBackColor = False
		'
		'Room1Pw3Btn
		'
		Me.Room1Pw3Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room1Pw3Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room1Pw3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1Pw3Btn.FlatAppearance.BorderSize = 0
		Me.Room1Pw3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1Pw3Btn.Location = New System.Drawing.Point(73, 186)
		Me.Room1Pw3Btn.Name = "Room1Pw3Btn"
		Me.Room1Pw3Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room1Pw3Btn.TabIndex = 4
		Me.Room1Pw3Btn.UseVisualStyleBackColor = False
		'
		'Room1AppBrpBox
		'
		Me.Room1AppBrpBox.Controls.Add(Me.tvBtn)
		Me.Room1AppBrpBox.Controls.Add(Me.Room1Pw1Btn)
		Me.Room1AppBrpBox.Location = New System.Drawing.Point(28, 3)
		Me.Room1AppBrpBox.Name = "Room1AppBrpBox"
		Me.Room1AppBrpBox.Size = New System.Drawing.Size(178, 408)
		Me.Room1AppBrpBox.TabIndex = 6
		Me.Room1AppBrpBox.TabStop = False
		Me.Room1AppBrpBox.Text = "Appliances"
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
		'Room1Pw1Btn
		'
		Me.Room1Pw1Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room1Pw1Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room1Pw1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1Pw1Btn.FlatAppearance.BorderSize = 0
		Me.Room1Pw1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1Pw1Btn.Location = New System.Drawing.Point(58, 183)
		Me.Room1Pw1Btn.Name = "Room1Pw1Btn"
		Me.Room1Pw1Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room1Pw1Btn.TabIndex = 4
		Me.Room1Pw1Btn.UseVisualStyleBackColor = False
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
		'Room1SerialPort1
		'
		'
		'Room1ToDashboard
		'
		Me.Room1ToDashboard.BackColor = System.Drawing.Color.Transparent
		Me.Room1ToDashboard.FlatAppearance.BorderSize = 0
		Me.Room1ToDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
		Me.Room1ToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1ToDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room1ToDashboard.ForeColor = System.Drawing.Color.White
		Me.Room1ToDashboard.Location = New System.Drawing.Point(17, 3)
		Me.Room1ToDashboard.Name = "Room1ToDashboard"
		Me.Room1ToDashboard.Size = New System.Drawing.Size(90, 29)
		Me.Room1ToDashboard.TabIndex = 10
		Me.Room1ToDashboard.Text = "Dashboard"
		Me.Room1ToDashboard.UseVisualStyleBackColor = False
		'
		'DashButtonPanel
		'
		Me.DashButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DashButtonPanel.BackColor = System.Drawing.Color.Transparent
		Me.DashButtonPanel.Controls.Add(Me.Room1ToDashboard)
		Me.DashButtonPanel.Location = New System.Drawing.Point(643, 24)
		Me.DashButtonPanel.Name = "DashButtonPanel"
		Me.DashButtonPanel.Size = New System.Drawing.Size(110, 32)
		Me.DashButtonPanel.TabIndex = 11
		'
		'Room1Back
		'
		Me.Room1Back.BackColor = System.Drawing.Color.Transparent
		Me.Room1Back.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
		Me.Room1Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room1Back.FlatAppearance.BorderSize = 0
		Me.Room1Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room1Back.Location = New System.Drawing.Point(4, 4)
		Me.Room1Back.Name = "Room1Back"
		Me.Room1Back.Size = New System.Drawing.Size(15, 15)
		Me.Room1Back.TabIndex = 7
		Me.Room1Back.UseVisualStyleBackColor = False
		'
		'RoomA
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(754, 559)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MaterialTabSelector1)
		Me.Controls.Add(Me.Room1Back)
		Me.Controls.Add(Me.MasterTabControl)
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
		Me.Room1light3.ResumeLayout(False)
		Me.Room1light3.PerformLayout()
		CType(Me.Room1Light3Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Room2Light2.ResumeLayout(False)
		Me.Room2Light2.PerformLayout()
		CType(Me.Room1Light2Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Room1Light1.ResumeLayout(False)
		Me.Room1Light1.PerformLayout()
		CType(Me.Room1Light1Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MasterTabControl.ResumeLayout(False)
		Me.apptab.ResumeLayout(False)
		Me.apptab.PerformLayout()
		Me.Room1AppGrpBox2.ResumeLayout(False)
		Me.Room1AppBrpBox.ResumeLayout(False)
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
    Friend WithEvents Room1Back As Button
    Friend WithEvents humidtip As ToolTip
    Friend WithEvents vidtab As TabPage
    Friend WithEvents Room1VidStop As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Room1VidStart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ImageBox As Emgu.CV.UI.ImageBox
    Friend WithEvents temptab As TabPage
    Friend WithEvents Room1TempIncBtn As Button
    Friend WithEvents Room1TempDecBtn As Button
    Friend WithEvents Room1TempResetBtn As Button
    Friend WithEvents humidbtn As Button
    Friend WithEvents mediumhot As PictureBox
    Friend WithEvents coldimage As PictureBox
    Friend WithEvents sunimage As PictureBox
    Friend WithEvents Room1TempLbl As Label
    Friend WithEvents Room1TempLbl2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lighttab As TabPage
    Friend WithEvents Room1light3 As GroupBox
    Friend WithEvents Room1Light3Lbl As Label
    Friend WithEvents Room1Light3on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light3off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light3Bri As TrackBar
    Friend WithEvents Room2Light2 As GroupBox
    Friend WithEvents Room1Light2on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light2off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light2Lbl As Label
    Friend WithEvents Room1Light2Bri As TrackBar
    Friend WithEvents Room1Light1 As GroupBox
    Friend WithEvents Room1Light1on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light1Lbl As Label
    Friend WithEvents Room1Light1off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room1Light1Bri As TrackBar
    Friend WithEvents MasterTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Room1SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents apptab As TabPage
    Friend WithEvents tvBtn As Button
    Friend WithEvents Room1Pw1Btn As Button
    Friend WithEvents Room1AppBrpBox As GroupBox
    Friend WithEvents Room1AppGrpBox2 As GroupBox
    Friend WithEvents Room1Pw2Btn As Button
    Friend WithEvents Room1Pw3Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Room1ToDashboard As Button
    Friend WithEvents DashButtonPanel As Panel
    Friend WithEvents Room1dhtTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ambientTemp As MaterialSkin.Controls.MaterialLabel
End Class
