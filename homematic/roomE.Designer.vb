<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomE
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
        Me.temptab = New System.Windows.Forms.TabPage()
        Me.Room5dhtTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.ambientTemp = New MaterialSkin.Controls.MaterialLabel()
        Me.Room5TempLbl = New System.Windows.Forms.Label()
        Me.Room5TempLbl2 = New System.Windows.Forms.Label()
        Me.Room5TempIncBtn = New System.Windows.Forms.Button()
        Me.Room5TempDecBtn = New System.Windows.Forms.Button()
        Me.Room5TempResetBtn = New System.Windows.Forms.Button()
        Me.mediumhot = New System.Windows.Forms.PictureBox()
        Me.coldimage = New System.Windows.Forms.PictureBox()
        Me.sunimage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lighttab = New System.Windows.Forms.TabPage()
        Me.Room5light3 = New System.Windows.Forms.GroupBox()
        Me.Room5Light3Lbl = New System.Windows.Forms.Label()
        Me.Room5Light3on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light3off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light3Bri = New System.Windows.Forms.TrackBar()
        Me.Room5Light2 = New System.Windows.Forms.GroupBox()
        Me.Room5Light2on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light2off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light2Lbl = New System.Windows.Forms.Label()
        Me.Room5Light2Bri = New System.Windows.Forms.TrackBar()
        Me.Room5Light1 = New System.Windows.Forms.GroupBox()
        Me.Room5Light1on = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light1Lbl = New System.Windows.Forms.Label()
        Me.Room5Light1off = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Room5Light1Bri = New System.Windows.Forms.TrackBar()
        Me.MasterTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.apptab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Room5AppGrpBox2 = New System.Windows.Forms.GroupBox()
        Me.Room5Pw2Btn = New System.Windows.Forms.Button()
        Me.Room5Pw3Btn = New System.Windows.Forms.Button()
        Me.Room5AppBrpBox = New System.Windows.Forms.GroupBox()
        Me.Room5Pw1Btn = New System.Windows.Forms.Button()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bulb = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Room5SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Room5ToDashboard = New System.Windows.Forms.Button()
        Me.DashButtonPanel = New System.Windows.Forms.Panel()
        Me.Room5Back = New System.Windows.Forms.Button()
        Me.temptab.SuspendLayout()
        CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coldimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lighttab.SuspendLayout()
        Me.Room5light3.SuspendLayout()
        CType(Me.Room5Light3Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Room5Light2.SuspendLayout()
        CType(Me.Room5Light2Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Room5Light1.SuspendLayout()
        CType(Me.Room5Light1Bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterTabControl.SuspendLayout()
        Me.apptab.SuspendLayout()
        Me.Room5AppGrpBox2.SuspendLayout()
        Me.Room5AppBrpBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bulb, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'temptab
        '
        Me.temptab.BackColor = System.Drawing.Color.White
        Me.temptab.Controls.Add(Me.Room5dhtTemp)
        Me.temptab.Controls.Add(Me.ambientTemp)
        Me.temptab.Controls.Add(Me.Room5TempLbl)
        Me.temptab.Controls.Add(Me.Room5TempLbl2)
        Me.temptab.Controls.Add(Me.Room5TempIncBtn)
        Me.temptab.Controls.Add(Me.Room5TempDecBtn)
        Me.temptab.Controls.Add(Me.Room5TempResetBtn)
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
        'Room5dhtTemp
        '
        Me.Room5dhtTemp.AutoSize = True
        Me.Room5dhtTemp.Depth = 0
        Me.Room5dhtTemp.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Room5dhtTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Room5dhtTemp.Location = New System.Drawing.Point(422, 22)
        Me.Room5dhtTemp.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5dhtTemp.Name = "Room5dhtTemp"
        Me.Room5dhtTemp.Size = New System.Drawing.Size(17, 19)
        Me.Room5dhtTemp.TabIndex = 12
        Me.Room5dhtTemp.Text = "0"
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
        'Room5TempLbl
        '
        Me.Room5TempLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room5TempLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5TempLbl.ForeColor = System.Drawing.Color.White
        Me.Room5TempLbl.Location = New System.Drawing.Point(330, 105)
        Me.Room5TempLbl.Name = "Room5TempLbl"
        Me.Room5TempLbl.Size = New System.Drawing.Size(40, 38)
        Me.Room5TempLbl.TabIndex = 2
        Me.Room5TempLbl.Text = "50"
        Me.Room5TempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room5TempLbl2
        '
        Me.Room5TempLbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room5TempLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5TempLbl2.ForeColor = System.Drawing.Color.White
        Me.Room5TempLbl2.Location = New System.Drawing.Point(320, 168)
        Me.Room5TempLbl2.Name = "Room5TempLbl2"
        Me.Room5TempLbl2.Size = New System.Drawing.Size(100, 59)
        Me.Room5TempLbl2.TabIndex = 1
        Me.Room5TempLbl2.Text = "50"
        Me.Room5TempLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room5TempIncBtn
        '
        Me.Room5TempIncBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room5TempIncBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempIncrease
        Me.Room5TempIncBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5TempIncBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room5TempIncBtn.FlatAppearance.BorderSize = 0
        Me.Room5TempIncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5TempIncBtn.Location = New System.Drawing.Point(115, 112)
        Me.Room5TempIncBtn.Name = "Room5TempIncBtn"
        Me.Room5TempIncBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room5TempIncBtn.TabIndex = 9
        Me.Room5TempIncBtn.UseVisualStyleBackColor = False
        '
        'Room5TempDecBtn
        '
        Me.Room5TempDecBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room5TempDecBtn.BackgroundImage = Global.homematic.My.Resources.Resources.TempDecrease
        Me.Room5TempDecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5TempDecBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room5TempDecBtn.FlatAppearance.BorderSize = 0
        Me.Room5TempDecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5TempDecBtn.Location = New System.Drawing.Point(115, 237)
        Me.Room5TempDecBtn.Name = "Room5TempDecBtn"
        Me.Room5TempDecBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room5TempDecBtn.TabIndex = 8
        Me.Room5TempDecBtn.UseVisualStyleBackColor = False
        '
        'Room5TempResetBtn
        '
        Me.Room5TempResetBtn.BackColor = System.Drawing.Color.Transparent
        Me.Room5TempResetBtn.BackgroundImage = Global.homematic.My.Resources.Resources.Reset
        Me.Room5TempResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5TempResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Room5TempResetBtn.FlatAppearance.BorderSize = 0
        Me.Room5TempResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5TempResetBtn.Location = New System.Drawing.Point(470, 182)
        Me.Room5TempResetBtn.Name = "Room5TempResetBtn"
        Me.Room5TempResetBtn.Size = New System.Drawing.Size(36, 31)
        Me.Room5TempResetBtn.TabIndex = 7
        Me.Room5TempResetBtn.UseVisualStyleBackColor = False
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
        Me.Lighttab.Controls.Add(Me.Room5light3)
        Me.Lighttab.Controls.Add(Me.Room5Light2)
        Me.Lighttab.Controls.Add(Me.Room5Light1)
        Me.Lighttab.Location = New System.Drawing.Point(4, 22)
        Me.Lighttab.Name = "Lighttab"
        Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
        Me.Lighttab.Size = New System.Drawing.Size(746, 438)
        Me.Lighttab.TabIndex = 0
        Me.Lighttab.Text = "Lights"
        '
        'Room5light3
        '
        Me.Room5light3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room5light3.Controls.Add(Me.Room5Light3Lbl)
        Me.Room5light3.Controls.Add(Me.Room5Light3on)
        Me.Room5light3.Controls.Add(Me.Room5Light3off)
        Me.Room5light3.Controls.Add(Me.Room5Light3Bri)
        Me.Room5light3.Location = New System.Drawing.Point(3, 295)
        Me.Room5light3.Name = "Room5light3"
        Me.Room5light3.Size = New System.Drawing.Size(740, 140)
        Me.Room5light3.TabIndex = 20
        Me.Room5light3.TabStop = False
        Me.Room5light3.Text = "light3"
        '
        'Room5Light3Lbl
        '
        Me.Room5Light3Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room5Light3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room5Light3Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5Light3Lbl.ForeColor = System.Drawing.Color.White
        Me.Room5Light3Lbl.Location = New System.Drawing.Point(179, 75)
        Me.Room5Light3Lbl.Name = "Room5Light3Lbl"
        Me.Room5Light3Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room5Light3Lbl.TabIndex = 18
        Me.Room5Light3Lbl.Text = "0"
        Me.Room5Light3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room5Light3on
        '
        Me.Room5Light3on.Depth = 0
        Me.Room5Light3on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light3on.Location = New System.Drawing.Point(113, 33)
        Me.Room5Light3on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light3on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light3on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light3on.Name = "Room5Light3on"
        Me.Room5Light3on.Ripple = True
        Me.Room5Light3on.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light3on.TabIndex = 0
        Me.Room5Light3on.Text = "ON"
        Me.Room5Light3on.UseVisualStyleBackColor = True
        '
        'Room5Light3off
        '
        Me.Room5Light3off.Depth = 0
        Me.Room5Light3off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light3off.Location = New System.Drawing.Point(580, 16)
        Me.Room5Light3off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light3off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light3off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light3off.Name = "Room5Light3off"
        Me.Room5Light3off.Ripple = True
        Me.Room5Light3off.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light3off.TabIndex = 1
        Me.Room5Light3off.Text = "OFF"
        Me.Room5Light3off.UseVisualStyleBackColor = True
        '
        'Room5Light3Bri
        '
        Me.Room5Light3Bri.LargeChange = 1
        Me.Room5Light3Bri.Location = New System.Drawing.Point(229, 69)
        Me.Room5Light3Bri.Maximum = 4
        Me.Room5Light3Bri.Name = "Room5Light3Bri"
        Me.Room5Light3Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room5Light3Bri.TabIndex = 1
        Me.Room5Light3Bri.TabStop = False
        Me.Room5Light3Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room5Light3Bri.Value = 4
        '
        'Room5Light2
        '
        Me.Room5Light2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room5Light2.Controls.Add(Me.Room5Light2on)
        Me.Room5Light2.Controls.Add(Me.Room5Light2off)
        Me.Room5Light2.Controls.Add(Me.Room5Light2Lbl)
        Me.Room5Light2.Controls.Add(Me.Room5Light2Bri)
        Me.Room5Light2.Location = New System.Drawing.Point(3, 153)
        Me.Room5Light2.Name = "Room5Light2"
        Me.Room5Light2.Size = New System.Drawing.Size(740, 140)
        Me.Room5Light2.TabIndex = 20
        Me.Room5Light2.TabStop = False
        Me.Room5Light2.Text = "light2"
        '
        'Room5Light2on
        '
        Me.Room5Light2on.Depth = 0
        Me.Room5Light2on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light2on.Location = New System.Drawing.Point(113, 29)
        Me.Room5Light2on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light2on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light2on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light2on.Name = "Room5Light2on"
        Me.Room5Light2on.Ripple = True
        Me.Room5Light2on.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light2on.TabIndex = 0
        Me.Room5Light2on.Text = "ON"
        Me.Room5Light2on.UseVisualStyleBackColor = True
        '
        'Room5Light2off
        '
        Me.Room5Light2off.Depth = 0
        Me.Room5Light2off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light2off.Location = New System.Drawing.Point(580, 29)
        Me.Room5Light2off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light2off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light2off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light2off.Name = "Room5Light2off"
        Me.Room5Light2off.Ripple = True
        Me.Room5Light2off.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light2off.TabIndex = 1
        Me.Room5Light2off.Text = "OFF"
        Me.Room5Light2off.UseVisualStyleBackColor = True
        '
        'Room5Light2Lbl
        '
        Me.Room5Light2Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room5Light2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room5Light2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5Light2Lbl.ForeColor = System.Drawing.Color.White
        Me.Room5Light2Lbl.Location = New System.Drawing.Point(179, 69)
        Me.Room5Light2Lbl.Name = "Room5Light2Lbl"
        Me.Room5Light2Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room5Light2Lbl.TabIndex = 17
        Me.Room5Light2Lbl.Text = "0"
        Me.Room5Light2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room5Light2Bri
        '
        Me.Room5Light2Bri.LargeChange = 1
        Me.Room5Light2Bri.Location = New System.Drawing.Point(229, 69)
        Me.Room5Light2Bri.Maximum = 4
        Me.Room5Light2Bri.Name = "Room5Light2Bri"
        Me.Room5Light2Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room5Light2Bri.TabIndex = 1
        Me.Room5Light2Bri.TabStop = False
        Me.Room5Light2Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room5Light2Bri.Value = 4
        '
        'Room5Light1
        '
        Me.Room5Light1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Room5Light1.Controls.Add(Me.Room5Light1on)
        Me.Room5Light1.Controls.Add(Me.Room5Light1Lbl)
        Me.Room5Light1.Controls.Add(Me.Room5Light1off)
        Me.Room5Light1.Controls.Add(Me.Room5Light1Bri)
        Me.Room5Light1.Location = New System.Drawing.Point(3, 3)
        Me.Room5Light1.Name = "Room5Light1"
        Me.Room5Light1.Size = New System.Drawing.Size(740, 140)
        Me.Room5Light1.TabIndex = 19
        Me.Room5Light1.TabStop = False
        Me.Room5Light1.Text = "light1"
        '
        'Room5Light1on
        '
        Me.Room5Light1on.Depth = 0
        Me.Room5Light1on.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light1on.Location = New System.Drawing.Point(113, 16)
        Me.Room5Light1on.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light1on.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light1on.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light1on.Name = "Room5Light1on"
        Me.Room5Light1on.Ripple = True
        Me.Room5Light1on.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light1on.TabIndex = 0
        Me.Room5Light1on.Text = "ON"
        Me.Room5Light1on.UseVisualStyleBackColor = True
        '
        'Room5Light1Lbl
        '
        Me.Room5Light1Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Room5Light1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Room5Light1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5Light1Lbl.ForeColor = System.Drawing.Color.White
        Me.Room5Light1Lbl.Location = New System.Drawing.Point(179, 56)
        Me.Room5Light1Lbl.Name = "Room5Light1Lbl"
        Me.Room5Light1Lbl.Size = New System.Drawing.Size(40, 30)
        Me.Room5Light1Lbl.TabIndex = 18
        Me.Room5Light1Lbl.Text = "0"
        Me.Room5Light1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Room5Light1off
        '
        Me.Room5Light1off.Depth = 0
        Me.Room5Light1off.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Room5Light1off.Location = New System.Drawing.Point(580, 16)
        Me.Room5Light1off.Margin = New System.Windows.Forms.Padding(0)
        Me.Room5Light1off.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Room5Light1off.MouseState = MaterialSkin.MouseState.HOVER
        Me.Room5Light1off.Name = "Room5Light1off"
        Me.Room5Light1off.Ripple = True
        Me.Room5Light1off.Size = New System.Drawing.Size(55, 30)
        Me.Room5Light1off.TabIndex = 1
        Me.Room5Light1off.Text = "OFF"
        Me.Room5Light1off.UseVisualStyleBackColor = True
        '
        'Room5Light1Bri
        '
        Me.Room5Light1Bri.LargeChange = 1
        Me.Room5Light1Bri.Location = New System.Drawing.Point(229, 56)
        Me.Room5Light1Bri.Maximum = 4
        Me.Room5Light1Bri.Name = "Room5Light1Bri"
        Me.Room5Light1Bri.Size = New System.Drawing.Size(325, 45)
        Me.Room5Light1Bri.TabIndex = 1
        Me.Room5Light1Bri.TabStop = False
        Me.Room5Light1Bri.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Room5Light1Bri.Value = 4
        '
        'MasterTabControl
        '
        Me.MasterTabControl.Controls.Add(Me.Lighttab)
        Me.MasterTabControl.Controls.Add(Me.temptab)
        Me.MasterTabControl.Controls.Add(Me.apptab)
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
        Me.apptab.Controls.Add(Me.Room5AppGrpBox2)
        Me.apptab.Controls.Add(Me.Room5AppBrpBox)
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
        'Room5AppGrpBox2
        '
        Me.Room5AppGrpBox2.Controls.Add(Me.Room5Pw2Btn)
        Me.Room5AppGrpBox2.Controls.Add(Me.Room5Pw3Btn)
        Me.Room5AppGrpBox2.Location = New System.Drawing.Point(326, 0)
        Me.Room5AppGrpBox2.Name = "Room5AppGrpBox2"
        Me.Room5AppGrpBox2.Size = New System.Drawing.Size(178, 408)
        Me.Room5AppGrpBox2.TabIndex = 7
        Me.Room5AppGrpBox2.TabStop = False
        Me.Room5AppGrpBox2.Text = "Connections"
        '
        'Room5Pw2Btn
        '
        Me.Room5Pw2Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room5Pw2Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room5Pw2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5Pw2Btn.FlatAppearance.BorderSize = 0
        Me.Room5Pw2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5Pw2Btn.Location = New System.Drawing.Point(73, 52)
        Me.Room5Pw2Btn.Name = "Room5Pw2Btn"
        Me.Room5Pw2Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room5Pw2Btn.TabIndex = 7
        Me.Room5Pw2Btn.UseVisualStyleBackColor = False
        '
        'Room5Pw3Btn
        '
        Me.Room5Pw3Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room5Pw3Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room5Pw3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5Pw3Btn.FlatAppearance.BorderSize = 0
        Me.Room5Pw3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5Pw3Btn.Location = New System.Drawing.Point(73, 186)
        Me.Room5Pw3Btn.Name = "Room5Pw3Btn"
        Me.Room5Pw3Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room5Pw3Btn.TabIndex = 4
        Me.Room5Pw3Btn.UseVisualStyleBackColor = False
        '
        'Room5AppBrpBox
        '
        Me.Room5AppBrpBox.Controls.Add(Me.Room5Pw1Btn)
        Me.Room5AppBrpBox.Location = New System.Drawing.Point(28, 3)
        Me.Room5AppBrpBox.Name = "Room5AppBrpBox"
        Me.Room5AppBrpBox.Size = New System.Drawing.Size(178, 408)
        Me.Room5AppBrpBox.TabIndex = 6
        Me.Room5AppBrpBox.TabStop = False
        Me.Room5AppBrpBox.Text = "Appliances"
        '
        'Room5Pw1Btn
        '
        Me.Room5Pw1Btn.BackColor = System.Drawing.Color.Transparent
        Me.Room5Pw1Btn.BackgroundImage = Global.homematic.My.Resources.Resources.poweroff
        Me.Room5Pw1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5Pw1Btn.FlatAppearance.BorderSize = 0
        Me.Room5Pw1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5Pw1Btn.Location = New System.Drawing.Point(58, 183)
        Me.Room5Pw1Btn.Name = "Room5Pw1Btn"
        Me.Room5Pw1Btn.Size = New System.Drawing.Size(40, 40)
        Me.Room5Pw1Btn.TabIndex = 4
        Me.Room5Pw1Btn.UseVisualStyleBackColor = False
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
        'Room5SerialPort1
        '
        '
        'Room5ToDashboard
        '
        Me.Room5ToDashboard.BackColor = System.Drawing.Color.Transparent
        Me.Room5ToDashboard.FlatAppearance.BorderSize = 0
        Me.Room5ToDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Room5ToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5ToDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room5ToDashboard.ForeColor = System.Drawing.Color.White
        Me.Room5ToDashboard.Location = New System.Drawing.Point(17, 3)
        Me.Room5ToDashboard.Name = "Room5ToDashboard"
        Me.Room5ToDashboard.Size = New System.Drawing.Size(90, 33)
        Me.Room5ToDashboard.TabIndex = 10
        Me.Room5ToDashboard.Text = "Dashboard"
        Me.Room5ToDashboard.UseVisualStyleBackColor = False
        '
        'DashButtonPanel
        '
        Me.DashButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashButtonPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashButtonPanel.Controls.Add(Me.Room5ToDashboard)
        Me.DashButtonPanel.Location = New System.Drawing.Point(643, 24)
        Me.DashButtonPanel.Name = "DashButtonPanel"
        Me.DashButtonPanel.Size = New System.Drawing.Size(110, 40)
        Me.DashButtonPanel.TabIndex = 11
        '
        'Room5Back
        '
        Me.Room5Back.BackColor = System.Drawing.Color.Transparent
        Me.Room5Back.BackgroundImage = Global.homematic.My.Resources.Resources.BackButton
        Me.Room5Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Room5Back.FlatAppearance.BorderSize = 0
        Me.Room5Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Room5Back.Location = New System.Drawing.Point(4, 4)
        Me.Room5Back.Name = "Room5Back"
        Me.Room5Back.Size = New System.Drawing.Size(15, 15)
        Me.Room5Back.TabIndex = 7
        Me.Room5Back.UseVisualStyleBackColor = False
        '
        'RoomE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 559)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Room5Back)
        Me.Controls.Add(Me.MasterTabControl)
        Me.Controls.Add(Me.DashButtonPanel)
        Me.Name = "RoomE"
        Me.temptab.ResumeLayout(False)
        Me.temptab.PerformLayout()
        CType(Me.mediumhot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coldimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lighttab.ResumeLayout(False)
        Me.Room5light3.ResumeLayout(False)
        Me.Room5light3.PerformLayout()
        CType(Me.Room5Light3Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Room5Light2.ResumeLayout(False)
        Me.Room5Light2.PerformLayout()
        CType(Me.Room5Light2Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Room5Light1.ResumeLayout(False)
        Me.Room5Light1.PerformLayout()
        CType(Me.Room5Light1Bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterTabControl.ResumeLayout(False)
        Me.apptab.ResumeLayout(False)
        Me.apptab.PerformLayout()
        Me.Room5AppGrpBox2.ResumeLayout(False)
        Me.Room5AppBrpBox.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.bulb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DashButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bulb As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Room5Back As Button
    Friend WithEvents humidtip As ToolTip
    Friend WithEvents temptab As TabPage
    Friend WithEvents Room5TempIncBtn As Button
    Friend WithEvents Room5TempDecBtn As Button
    Friend WithEvents Room5TempResetBtn As Button
    Friend WithEvents humidbtn As Button
    Friend WithEvents mediumhot As PictureBox
    Friend WithEvents coldimage As PictureBox
    Friend WithEvents sunimage As PictureBox
    Friend WithEvents Room5TempLbl As Label
    Friend WithEvents Room5TempLbl2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lighttab As TabPage
    Friend WithEvents Room5light3 As GroupBox
    Friend WithEvents Room5Light3Lbl As Label
    Friend WithEvents Room5Light3on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light3off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light3Bri As TrackBar
    Friend WithEvents Room5Light2 As GroupBox
    Friend WithEvents Room5Light2on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light2off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light2Lbl As Label
    Friend WithEvents Room5Light2Bri As TrackBar
    Friend WithEvents Room5Light1 As GroupBox
    Friend WithEvents Room5Light1on As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light1Lbl As Label
    Friend WithEvents Room5Light1off As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Room5Light1Bri As TrackBar
    Friend WithEvents MasterTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Room5SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents apptab As TabPage
    Friend WithEvents Room5Pw1Btn As Button
    Friend WithEvents Room5AppBrpBox As GroupBox
    Friend WithEvents Room5AppGrpBox2 As GroupBox
    Friend WithEvents Room5Pw2Btn As Button
    Friend WithEvents Room5Pw3Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Room5ToDashboard As Button
    Friend WithEvents DashButtonPanel As Panel
    Friend WithEvents Room5dhtTemp As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ambientTemp As MaterialSkin.Controls.MaterialLabel
End Class
