<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralSec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneralSec))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picSecretary1 = New System.Windows.Forms.PictureBox()
        Me.picSecretary2 = New System.Windows.Forms.PictureBox()
        Me.picSecretary3 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picSecretary1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSecretary2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSecretary3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1040, 66)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SRC GENERAL SECETARY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 535)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1046, 66)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Double Click on the image of the preferred Candidate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSecretary1
        '
        Me.picSecretary1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picSecretary1.Image = CType(resources.GetObject("picSecretary1.Image"), System.Drawing.Image)
        Me.picSecretary1.Location = New System.Drawing.Point(57, 142)
        Me.picSecretary1.Name = "picSecretary1"
        Me.picSecretary1.Size = New System.Drawing.Size(309, 366)
        Me.picSecretary1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSecretary1.TabIndex = 10
        Me.picSecretary1.TabStop = False
        '
        'picSecretary2
        '
        Me.picSecretary2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picSecretary2.Image = CType(resources.GetObject("picSecretary2.Image"), System.Drawing.Image)
        Me.picSecretary2.Location = New System.Drawing.Point(385, 142)
        Me.picSecretary2.Name = "picSecretary2"
        Me.picSecretary2.Size = New System.Drawing.Size(309, 366)
        Me.picSecretary2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSecretary2.TabIndex = 11
        Me.picSecretary2.TabStop = False
        '
        'picSecretary3
        '
        Me.picSecretary3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picSecretary3.Image = CType(resources.GetObject("picSecretary3.Image"), System.Drawing.Image)
        Me.picSecretary3.Location = New System.Drawing.Point(717, 142)
        Me.picSecretary3.Name = "picSecretary3"
        Me.picSecretary3.Size = New System.Drawing.Size(309, 366)
        Me.picSecretary3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSecretary3.TabIndex = 12
        Me.picSecretary3.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(57, -3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(172, 52)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmGeneralSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picSecretary3)
        Me.Controls.Add(Me.picSecretary2)
        Me.Controls.Add(Me.picSecretary1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmGeneralSec"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picSecretary1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSecretary2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSecretary3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picSecretary1 As PictureBox
    Friend WithEvents picSecretary2 As PictureBox
    Friend WithEvents picSecretary3 As PictureBox
    Friend WithEvents btnBack As Button
End Class
