<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomB
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
		Me.Room2VidStop = New MaterialSkin.Controls.MaterialRaisedButton()
		Me.Room2VidStart = New MaterialSkin.Controls.MaterialRaisedButton()
		Me.ImageBox = New Emgu.CV.UI.ImageBox()
		Me.temptab = New System.Windows.Forms.TabPage()
		Me.Room2dhtTemp = New MaterialSkin.Controls.MaterialLabel()
		Me.ambientTemp = New MaterialSkin.Controls.MaterialLabel()
		Me.Room2TempLbl = New System.Windows.Forms.Label()
		Me.Room2TempLbl2 = New System.Windows.Forms.Label()
		Me.Room2TempIncBtn = New System.Windows.Forms.Button()
		Me.Room2TempDecBtn = New System.Windows.Forms.Button()
		Me.Room2TempResetBtn = New System.Windows.Forms.Button()
		Me.mediumhot = New System.Windows.Forms.PictureBox()
		Me.coldimage = New System.Windows.Forms.PictureBox()
		Me.sunimage = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Lighttab = New System.Windows.Forms.TabPage()
		Me.Room2light3 = New System.Windows.Forms.GroupBox()
		Me.Room2Light3Lbl = New System.Windows.Forms.Label()
		Me.Room2Light3on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light3off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light3Bri = New System.Windows.Forms.TrackBar()
		Me.Room2Light2 = New System.Windows.Forms.GroupBox()
		Me.Room2Light2on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light2off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light2Lbl = New System.Windows.Forms.Label()
		Me.Room2Light2Bri = New System.Windows.Forms.TrackBar()
		Me.Room2Light1 = New System.Windows.Forms.GroupBox()
		Me.Room2Light1on = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light1Lbl = New System.Windows.Forms.Label()
		Me.Room2Light1off = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Room2Light1Bri = New System.Windows.Forms.TrackBar()
		Me.MasterTabControl = New MaterialSkin.Controls.MaterialTabControl()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Room2AppGrpBox2 = New System.Windows.Forms.GroupBox()
		Me.Room2Pw2Btn = New System.Windows.Forms.Button()
		Me.Room2Pw3Btn = New System.Windows.Forms.Button()
		Me.Room2AppBrpBox = New System.Windows.Forms.GroupBox()
		Me.tvBtn = New System.Windows.Forms.Button()
		Me.Room2Pw1Btn = New System.Windows.Forms.Button()
		Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.bulb = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Room2SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.Room2ToDashboard = New System.Windows.Forms.Button()
		Me.DashButtonPanel = New System.Windows.Forms.Panel()
		Me.Room2Back = New System.Windows.Forms.Button()
		Me.vidtab.SuspendLayout()
		CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.temptab.SuspendLayout()
		CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Lighttab.SuspendLayout()
		Me.Room2light3.SuspendLayout()
		CType(Me.Room2Light3Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Room2Light2.SuspendLayout()
		CType(Me.Room2Light2Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Room2Light1.SuspendLayout()
		CType(Me.Room2Light1Bri, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MasterTabControl.SuspendLayout()
		Me.apptab.SuspendLayout()
		Me.Room2AppGrpBox2.SuspendLayout()
		Me.Room2AppBrpBox.SuspendLayout()
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
		Me.vidtab.Controls.Add(Me.Room2VidStop)
		Me.vidtab.Controls.Add(Me.Room2VidStart)
		Me.vidtab.Controls.Add(Me.ImageBox)
		Me.vidtab.Location = New System.Drawing.Point(4, 22)
		Me.vidtab.Name = "vidtab"
		Me.vidtab.Size = New System.Drawing.Size(746, 438)
		Me.vidtab.TabIndex = 3
		Me.vidtab.Text = "Surveillance"
		Me.vidtab.UseVisualStyleBackColor = True
		'
		'Room2VidStop
		'
		Me.Room2VidStop.AutoSize = True
		Me.Room2VidStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Room2VidStop.Depth = 0
		Me.Room2VidStop.Icon = Nothing
		Me.Room2VidStop.Location = New System.Drawing.Point(645, 12)
		Me.Room2VidStop.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2VidStop.Name = "Room2VidStop"
		Me.Room2VidStop.Primary = True
		Me.Room2VidStop.Size = New System.Drawing.Size(56, 36)
		Me.Room2VidStop.TabIndex = 4
		Me.Room2VidStop.Text = "Stop"
		Me.Room2VidStop.UseVisualStyleBackColor = True
		'
		'Room2VidStart
		'
		Me.Room2VidStart.AutoSize = True
		Me.Room2VidStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Room2VidStart.Depth = 0
		Me.Room2VidStart.Icon = Nothing
		Me.Room2VidStart.Location = New System.Drawing.Point(38, 12)
		Me.Room2VidStart.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2VidStart.Name = "Room2VidStart"
		Me.Room2VidStart.Primary = True
		Me.Room2VidStart.Size = New System.Drawing.Size(64, 36)
		Me.Room2VidStart.TabIndex = 3
		Me.Room2VidStart.Text = "Start"
		Me.Room2VidStart.UseVisualStyleBackColor = True
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
		Me.temptab.Controls.Add(Me.Room2dhtTemp)
		Me.temptab.Controls.Add(Me.ambientTemp)
		Me.temptab.Controls.Add(Me.Room2TempLbl)
		Me.temptab.Controls.Add(Me.Room2TempLbl2)
		Me.temptab.Controls.Add(Me.Room2TempIncBtn)
		Me.temptab.Controls.Add(Me.Room2TempDecBtn)
		Me.temptab.Controls.Add(Me.Room2TempResetBtn)
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
		'Room2dhtTemp
		'
		Me.Room2dhtTemp.AutoSize = True
		Me.Room2dhtTemp.Depth = 0
		Me.Room2dhtTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
		Me.Room2dhtTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Room2dhtTemp.Location = New System.Drawing.Point(422, 22)
		Me.Room2dhtTemp.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2dhtTemp.Name = "Room2dhtTemp"
		Me.Room2dhtTemp.Size = New System.Drawing.Size(17, 19)
		Me.Room2dhtTemp.TabIndex = 12
		Me.Room2dhtTemp.Text = "0"
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
		'Room2TempLbl
		'
		Me.Room2TempLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room2TempLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2TempLbl.ForeColor = System.Drawing.Color.White
		Me.Room2TempLbl.Location = New System.Drawing.Point(330, 105)
		Me.Room2TempLbl.Name = "Room2TempLbl"
		Me.Room2TempLbl.Size = New System.Drawing.Size(40, 38)
		Me.Room2TempLbl.TabIndex = 2
		Me.Room2TempLbl.Text = "50"
		Me.Room2TempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room2TempLbl2
		'
		Me.Room2TempLbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room2TempLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2TempLbl2.ForeColor = System.Drawing.Color.White
		Me.Room2TempLbl2.Location = New System.Drawing.Point(320, 168)
		Me.Room2TempLbl2.Name = "Room2TempLbl2"
		Me.Room2TempLbl2.Size = New System.Drawing.Size(100, 59)
		Me.Room2TempLbl2.TabIndex = 1
		Me.Room2TempLbl2.Text = "50"
		Me.Room2TempLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room2TempIncBtn
		'
		Me.Room2TempIncBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room2TempIncBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempIncrease
		Me.Room2TempIncBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2TempIncBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room2TempIncBtn.FlatAppearance.BorderSize = 0
		Me.Room2TempIncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2TempIncBtn.Location = New System.Drawing.Point(115, 112)
		Me.Room2TempIncBtn.Name = "Room2TempIncBtn"
		Me.Room2TempIncBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room2TempIncBtn.TabIndex = 9
		Me.Room2TempIncBtn.UseVisualStyleBackColor = False
		'
		'Room2TempDecBtn
		'
		Me.Room2TempDecBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room2TempDecBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempDecrease
		Me.Room2TempDecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2TempDecBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room2TempDecBtn.FlatAppearance.BorderSize = 0
		Me.Room2TempDecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2TempDecBtn.Location = New System.Drawing.Point(115, 237)
		Me.Room2TempDecBtn.Name = "Room2TempDecBtn"
		Me.Room2TempDecBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room2TempDecBtn.TabIndex = 8
		Me.Room2TempDecBtn.UseVisualStyleBackColor = False
		'
		'Room2TempResetBtn
		'
		Me.Room2TempResetBtn.BackColor = System.Drawing.Color.Transparent
		Me.Room2TempResetBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Reset
		Me.Room2TempResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2TempResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Room2TempResetBtn.FlatAppearance.BorderSize = 0
		Me.Room2TempResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2TempResetBtn.Location = New System.Drawing.Point(470, 182)
		Me.Room2TempResetBtn.Name = "Room2TempResetBtn"
		Me.Room2TempResetBtn.Size = New System.Drawing.Size(36, 31)
		Me.Room2TempResetBtn.TabIndex = 7
		Me.Room2TempResetBtn.UseVisualStyleBackColor = False
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
		Me.Lighttab.Controls.Add(Me.Room2light3)
		Me.Lighttab.Controls.Add(Me.Room2Light2)
		Me.Lighttab.Controls.Add(Me.Room2Light1)
		Me.Lighttab.Location = New System.Drawing.Point(4, 22)
		Me.Lighttab.Name = "Lighttab"
		Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
		Me.Lighttab.Size = New System.Drawing.Size(746, 438)
		Me.Lighttab.TabIndex = 0
		Me.Lighttab.Text = "Lights"
		'
		'Room2light3
		'
		Me.Room2light3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room2light3.Controls.Add(Me.Room2Light3Lbl)
		Me.Room2light3.Controls.Add(Me.Room2Light3on)
		Me.Room2light3.Controls.Add(Me.Room2Light3off)
		Me.Room2light3.Controls.Add(Me.Room2Light3Bri)
		Me.Room2light3.Location = New System.Drawing.Point(3, 295)
		Me.Room2light3.Name = "Room2light3"
		Me.Room2light3.Size = New System.Drawing.Size(740, 140)
		Me.Room2light3.TabIndex = 20
		Me.Room2light3.TabStop = False
		Me.Room2light3.Text = "light3"
		'
		'Room2Light3Lbl
		'
		Me.Room2Light3Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room2Light3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room2Light3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2Light3Lbl.ForeColor = System.Drawing.Color.White
		Me.Room2Light3Lbl.Location = New System.Drawing.Point(179, 75)
		Me.Room2Light3Lbl.Name = "Room2Light3Lbl"
		Me.Room2Light3Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room2Light3Lbl.TabIndex = 18
		Me.Room2Light3Lbl.Text = "0"
		Me.Room2Light3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room2Light3on
		'
		Me.Room2Light3on.Depth = 0
		Me.Room2Light3on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light3on.Location = New System.Drawing.Point(113, 33)
		Me.Room2Light3on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light3on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light3on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light3on.Name = "Room2Light3on"
		Me.Room2Light3on.Ripple = True
		Me.Room2Light3on.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light3on.TabIndex = 0
		Me.Room2Light3on.Text = "ON"
		Me.Room2Light3on.UseVisualStyleBackColor = True
		'
		'Room2Light3off
		'
		Me.Room2Light3off.Depth = 0
		Me.Room2Light3off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light3off.Location = New System.Drawing.Point(580, 16)
		Me.Room2Light3off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light3off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light3off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light3off.Name = "Room2Light3off"
		Me.Room2Light3off.Ripple = True
		Me.Room2Light3off.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light3off.TabIndex = 1
		Me.Room2Light3off.Text = "OFF"
		Me.Room2Light3off.UseVisualStyleBackColor = True
		'
		'Room2Light3Bri
		'
		Me.Room2Light3Bri.LargeChange = 1
		Me.Room2Light3Bri.Location = New System.Drawing.Point(229, 69)
		Me.Room2Light3Bri.Maximum = 4
		Me.Room2Light3Bri.Name = "Room2Light3Bri"
		Me.Room2Light3Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room2Light3Bri.TabIndex = 1
		Me.Room2Light3Bri.TabStop = False
		Me.Room2Light3Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room2Light3Bri.Value = 4
		'
		'Room2Light2
		'
		Me.Room2Light2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room2Light2.Controls.Add(Me.Room2Light2on)
		Me.Room2Light2.Controls.Add(Me.Room2Light2off)
		Me.Room2Light2.Controls.Add(Me.Room2Light2Lbl)
		Me.Room2Light2.Controls.Add(Me.Room2Light2Bri)
		Me.Room2Light2.Location = New System.Drawing.Point(3, 153)
		Me.Room2Light2.Name = "Room2Light2"
		Me.Room2Light2.Size = New System.Drawing.Size(740, 140)
		Me.Room2Light2.TabIndex = 20
		Me.Room2Light2.TabStop = False
		Me.Room2Light2.Text = "light2"
		'
		'Room2Light2on
		'
		Me.Room2Light2on.Depth = 0
		Me.Room2Light2on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light2on.Location = New System.Drawing.Point(113, 30)
		Me.Room2Light2on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light2on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light2on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light2on.Name = "Room2Light2on"
		Me.Room2Light2on.Ripple = True
		Me.Room2Light2on.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light2on.TabIndex = 0
		Me.Room2Light2on.Text = "ON"
		Me.Room2Light2on.UseVisualStyleBackColor = True
		'
		'Room2Light2off
		'
		Me.Room2Light2off.Depth = 0
		Me.Room2Light2off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light2off.Location = New System.Drawing.Point(580, 29)
		Me.Room2Light2off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light2off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light2off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light2off.Name = "Room2Light2off"
		Me.Room2Light2off.Ripple = True
		Me.Room2Light2off.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light2off.TabIndex = 1
		Me.Room2Light2off.Text = "OFF"
		Me.Room2Light2off.UseVisualStyleBackColor = True
		'
		'Room2Light2Lbl
		'
		Me.Room2Light2Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room2Light2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room2Light2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2Light2Lbl.ForeColor = System.Drawing.Color.White
		Me.Room2Light2Lbl.Location = New System.Drawing.Point(179, 69)
		Me.Room2Light2Lbl.Name = "Room2Light2Lbl"
		Me.Room2Light2Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room2Light2Lbl.TabIndex = 17
		Me.Room2Light2Lbl.Text = "0"
		Me.Room2Light2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room2Light2Bri
		'
		Me.Room2Light2Bri.LargeChange = 1
		Me.Room2Light2Bri.Location = New System.Drawing.Point(229, 69)
		Me.Room2Light2Bri.Maximum = 4
		Me.Room2Light2Bri.Name = "Room2Light2Bri"
		Me.Room2Light2Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room2Light2Bri.TabIndex = 1
		Me.Room2Light2Bri.TabStop = False
		Me.Room2Light2Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room2Light2Bri.Value = 4
		'
		'Room2Light1
		'
		Me.Room2Light1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Room2Light1.Controls.Add(Me.Room2Light1on)
		Me.Room2Light1.Controls.Add(Me.Room2Light1Lbl)
		Me.Room2Light1.Controls.Add(Me.Room2Light1off)
		Me.Room2Light1.Controls.Add(Me.Room2Light1Bri)
		Me.Room2Light1.Location = New System.Drawing.Point(3, 3)
		Me.Room2Light1.Name = "Room2Light1"
		Me.Room2Light1.Size = New System.Drawing.Size(740, 140)
		Me.Room2Light1.TabIndex = 19
		Me.Room2Light1.TabStop = False
		Me.Room2Light1.Text = "light1"
		'
		'Room2Light1on
		'
		Me.Room2Light1on.Depth = 0
		Me.Room2Light1on.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light1on.Location = New System.Drawing.Point(113, 16)
		Me.Room2Light1on.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light1on.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light1on.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light1on.Name = "Room2Light1on"
		Me.Room2Light1on.Ripple = True
		Me.Room2Light1on.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light1on.TabIndex = 0
		Me.Room2Light1on.Text = "ON"
		Me.Room2Light1on.UseVisualStyleBackColor = True
		'
		'Room2Light1Lbl
		'
		Me.Room2Light1Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
		Me.Room2Light1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Room2Light1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2Light1Lbl.ForeColor = System.Drawing.Color.White
		Me.Room2Light1Lbl.Location = New System.Drawing.Point(179, 56)
		Me.Room2Light1Lbl.Name = "Room2Light1Lbl"
		Me.Room2Light1Lbl.Size = New System.Drawing.Size(40, 30)
		Me.Room2Light1Lbl.TabIndex = 18
		Me.Room2Light1Lbl.Text = "0"
		Me.Room2Light1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Room2Light1off
		'
		Me.Room2Light1off.Depth = 0
		Me.Room2Light1off.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.Room2Light1off.Location = New System.Drawing.Point(580, 16)
		Me.Room2Light1off.Margin = New System.Windows.Forms.Padding(0)
		Me.Room2Light1off.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.Room2Light1off.MouseState = MaterialSkin.MouseState.HOVER
		Me.Room2Light1off.Name = "Room2Light1off"
		Me.Room2Light1off.Ripple = True
		Me.Room2Light1off.Size = New System.Drawing.Size(55, 30)
		Me.Room2Light1off.TabIndex = 1
		Me.Room2Light1off.Text = "OFF"
		Me.Room2Light1off.UseVisualStyleBackColor = True
		'
		'Room2Light1Bri
		'
		Me.Room2Light1Bri.LargeChange = 1
		Me.Room2Light1Bri.Location = New System.Drawing.Point(229, 56)
		Me.Room2Light1Bri.Maximum = 4
		Me.Room2Light1Bri.Name = "Room2Light1Bri"
		Me.Room2Light1Bri.Size = New System.Drawing.Size(325, 45)
		Me.Room2Light1Bri.TabIndex = 1
		Me.Room2Light1Bri.TabStop = False
		Me.Room2Light1Bri.TickStyle = System.Windows.Forms.TickStyle.None
		Me.Room2Light1Bri.Value = 4
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
		Me.apptab.Controls.Add(Me.Room2AppGrpBox2)
		Me.apptab.Controls.Add(Me.Room2AppBrpBox)
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
		'Room2AppGrpBox2
		'
		Me.Room2AppGrpBox2.Controls.Add(Me.Room2Pw2Btn)
		Me.Room2AppGrpBox2.Controls.Add(Me.Room2Pw3Btn)
		Me.Room2AppGrpBox2.Location = New System.Drawing.Point(326, 0)
		Me.Room2AppGrpBox2.Name = "Room2AppGrpBox2"
		Me.Room2AppGrpBox2.Size = New System.Drawing.Size(178, 408)
		Me.Room2AppGrpBox2.TabIndex = 7
		Me.Room2AppGrpBox2.TabStop = False
		Me.Room2AppGrpBox2.Text = "Connections"
		'
		'Room2Pw2Btn
		'
		Me.Room2Pw2Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room2Pw2Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room2Pw2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2Pw2Btn.FlatAppearance.BorderSize = 0
		Me.Room2Pw2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2Pw2Btn.Location = New System.Drawing.Point(73, 52)
		Me.Room2Pw2Btn.Name = "Room2Pw2Btn"
		Me.Room2Pw2Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room2Pw2Btn.TabIndex = 7
		Me.Room2Pw2Btn.UseVisualStyleBackColor = False
		'
		'Room2Pw3Btn
		'
		Me.Room2Pw3Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room2Pw3Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room2Pw3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2Pw3Btn.FlatAppearance.BorderSize = 0
		Me.Room2Pw3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2Pw3Btn.Location = New System.Drawing.Point(73, 186)
		Me.Room2Pw3Btn.Name = "Room2Pw3Btn"
		Me.Room2Pw3Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room2Pw3Btn.TabIndex = 4
		Me.Room2Pw3Btn.UseVisualStyleBackColor = False
		'
		'Room2AppBrpBox
		'
		Me.Room2AppBrpBox.Controls.Add(Me.tvBtn)
		Me.Room2AppBrpBox.Controls.Add(Me.Room2Pw1Btn)
		Me.Room2AppBrpBox.Location = New System.Drawing.Point(28, 3)
		Me.Room2AppBrpBox.Name = "Room2AppBrpBox"
		Me.Room2AppBrpBox.Size = New System.Drawing.Size(178, 408)
		Me.Room2AppBrpBox.TabIndex = 6
		Me.Room2AppBrpBox.TabStop = False
		Me.Room2AppBrpBox.Text = "Appliances"
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
		'Room2Pw1Btn
		'
		Me.Room2Pw1Btn.BackColor = System.Drawing.Color.Transparent
		Me.Room2Pw1Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
		Me.Room2Pw1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2Pw1Btn.FlatAppearance.BorderSize = 0
		Me.Room2Pw1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2Pw1Btn.Location = New System.Drawing.Point(58, 183)
		Me.Room2Pw1Btn.Name = "Room2Pw1Btn"
		Me.Room2Pw1Btn.Size = New System.Drawing.Size(40, 40)
		Me.Room2Pw1Btn.TabIndex = 4
		Me.Room2Pw1Btn.UseVisualStyleBackColor = False
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
		'Room2SerialPort1
		'
		'
		'Room2ToDashboard
		'
		Me.Room2ToDashboard.BackColor = System.Drawing.Color.Transparent
		Me.Room2ToDashboard.FlatAppearance.BorderSize = 0
		Me.Room2ToDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
		Me.Room2ToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2ToDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Room2ToDashboard.ForeColor = System.Drawing.Color.White
		Me.Room2ToDashboard.Location = New System.Drawing.Point(17, 3)
		Me.Room2ToDashboard.Name = "Room2ToDashboard"
		Me.Room2ToDashboard.Size = New System.Drawing.Size(90, 33)
		Me.Room2ToDashboard.TabIndex = 10
		Me.Room2ToDashboard.Text = "Dashboard"
		Me.Room2ToDashboard.UseVisualStyleBackColor = False
		'
		'DashButtonPanel
		'
		Me.DashButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DashButtonPanel.BackColor = System.Drawing.Color.Transparent
		Me.DashButtonPanel.Controls.Add(Me.Room2ToDashboard)
		Me.DashButtonPanel.Location = New System.Drawing.Point(643, 24)
		Me.DashButtonPanel.Name = "DashButtonPanel"
		Me.DashButtonPanel.Size = New System.Drawing.Size(110, 40)
		Me.DashButtonPanel.TabIndex = 11
		'
		'Room2Back
		'
		Me.Room2Back.BackColor = System.Drawing.Color.Transparent
		Me.Room2Back.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
		Me.Room2Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Room2Back.FlatAppearance.BorderSize = 0
		Me.Room2Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Room2Back.Location = New System.Drawing.Point(4, 4)
		Me.Room2Back.Name = "Room2Back"
		Me.Room2Back.Size = New System.Drawing.Size(15, 15)
		Me.Room2Back.TabIndex = 7
		Me.Room2Back.UseVisualStyleBackColor = False
		'
		'RoomB
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(754, 559)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MaterialTabSelector1)
		Me.Controls.Add(Me.Room2Back)
		Me.Controls.Add(Me.MasterTabControl)
		Me.Controls.Add(Me.DashButtonPanel)
		Me.Name = "RoomB"
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
		Me.Room2light3.ResumeLayout(False)
		Me.Room2light3.PerformLayout()
		CType(Me.Room2Light3Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Room2Light2.ResumeLayout(False)
		Me.Room2Light2.PerformLayout()
		CType(Me.Room2Light2Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Room2Light1.ResumeLayout(False)
		Me.Room2Light1.PerformLayout()
		CType(Me.Room2Light1Bri, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MasterTabControl.ResumeLayout(False)
		Me.apptab.ResumeLayout(False)
		Me.apptab.PerformLayout()
		Me.Room2AppGrpBox2.ResumeLayout(False)
		Me.Room2AppBrpBox.ResumeLayout(False)
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
    Friend WithEvents Room2Back As Button
    Friend WithEvents humidtip As ToolTip
    Friend WithEvents vidtab As TabPage
    Friend WithEvents Room2VidStop As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Room2VidStart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ImageBox As Emgu.CV.UI.ImageBox
    Friend WithEvents temptab As TabPage
    Friend WithEvents Room2TempIncBtn As Button
    Friend WithEvents Room2TempDecBtn As Button
    Friend WithEvents Room2TempResetBtn As Button
    Friend WithEvents humidbtn As Button
    Friend WithEvents mediumhot As PictureBox
    Friend WithEvents coldimage As PictureBox
    Friend WithEvents sunimage As PictureBox
    Friend WithEvents Room2TempLbl As Label
    Friend WithEvents Room2TempLbl2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lighttab As TabPage
    Friend WithEvents Room2light3 As GroupBox
    Friend WithEvents Room2Light3Lbl As Label
    Friend WithEvents Room2Light3on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light3off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light3Bri As TrackBar
    Friend WithEvents Room2Light2 As GroupBox
    Friend WithEvents Room2Light2on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light2off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light2Lbl As Label
    Friend WithEvents Room2Light2Bri As TrackBar
    Friend WithEvents Room2Light1 As GroupBox
    Friend WithEvents Room2Light1on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light1Lbl As Label
    Friend WithEvents Room2Light1off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room2Light1Bri As TrackBar
    Friend WithEvents MasterTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Room2SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents apptab As TabPage
    Friend WithEvents tvBtn As Button
    Friend WithEvents Room2Pw1Btn As Button
    Friend WithEvents Room2AppBrpBox As GroupBox
    Friend WithEvents Room2AppGrpBox2 As GroupBox
    Friend WithEvents Room2Pw2Btn As Button
    Friend WithEvents Room2Pw3Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Room2ToDashboard As Button
    Friend WithEvents DashButtonPanel As Panel
    Friend WithEvents Room2dhtTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ambientTemp As MaterialSkin.Controls.MaterialLabel
End Class
