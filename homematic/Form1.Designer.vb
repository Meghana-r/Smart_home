<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.Blueprintimage = New System.Windows.Forms.PictureBox()
		CType(Me.Blueprintimage, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Blueprintimage
		'
		Me.Blueprintimage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Blueprintimage.BackgroundImage = Global.homematic.My.Resources.Resources.Blueprint2
		Me.Blueprintimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Blueprintimage.Location = New System.Drawing.Point(2, 66)
		Me.Blueprintimage.Name = "Blueprintimage"
		Me.Blueprintimage.Size = New System.Drawing.Size(779, 492)
		Me.Blueprintimage.TabIndex = 0
		Me.Blueprintimage.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = Global.homematic.My.Resources.Resources.Blueprint21
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(783, 563)
		Me.Controls.Add(Me.Blueprintimage)
		Me.Name = "Form1"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.Blueprintimage, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Blueprintimage As PictureBox
End Class
