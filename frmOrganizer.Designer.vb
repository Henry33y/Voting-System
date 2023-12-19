<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrganizer
    Inherits System.Windows.Forms.Form

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
        Me.picOrganizer1 = New System.Windows.Forms.PictureBox()
        Me.picOrganizer2 = New System.Windows.Forms.PictureBox()
        Me.picOrganizer3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picOrganizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrganizer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrganizer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOrganizer1
        '
        Me.picOrganizer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picOrganizer1.Image = Global.WindowsApp1.My.Resources.Resources.ian_dooley
        Me.picOrganizer1.Location = New System.Drawing.Point(153, 151)
        Me.picOrganizer1.Margin = New System.Windows.Forms.Padding(2)
        Me.picOrganizer1.Name = "picOrganizer1"
        Me.picOrganizer1.Size = New System.Drawing.Size(299, 243)
        Me.picOrganizer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer1.TabIndex = 0
        Me.picOrganizer1.TabStop = False
        '
        'picOrganizer2
        '
        Me.picOrganizer2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picOrganizer2.Image = Global.WindowsApp1.My.Resources.Resources.michael_dam
        Me.picOrganizer2.Location = New System.Drawing.Point(476, 151)
        Me.picOrganizer2.Margin = New System.Windows.Forms.Padding(2)
        Me.picOrganizer2.Name = "picOrganizer2"
        Me.picOrganizer2.Size = New System.Drawing.Size(306, 243)
        Me.picOrganizer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer2.TabIndex = 0
        Me.picOrganizer2.TabStop = False
        '
        'picOrganizer3
        '
        Me.picOrganizer3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picOrganizer3.Image = Global.WindowsApp1.My.Resources.Resources.aiony_haust
        Me.picOrganizer3.Location = New System.Drawing.Point(807, 151)
        Me.picOrganizer3.Margin = New System.Windows.Forms.Padding(2)
        Me.picOrganizer3.Name = "picOrganizer3"
        Me.picOrganizer3.Size = New System.Drawing.Size(251, 243)
        Me.picOrganizer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer3.TabIndex = 0
        Me.picOrganizer3.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label5.Location = New System.Drawing.Point(114, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1039, 66)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SRC ORGANIZER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(153, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(905, 66)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Double Click on the image of the preferred Candidate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(153, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(172, 52)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmOrganizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picOrganizer3)
        Me.Controls.Add(Me.picOrganizer2)
        Me.Controls.Add(Me.picOrganizer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "frmOrganizer"
        Me.ShowInTaskbar = False
        Me.Text = "frmOrganizer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picOrganizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrganizer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrganizer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picOrganizer1 As PictureBox
    Friend WithEvents picOrganizer2 As PictureBox
    Friend WithEvents picOrganizer3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
End Class
