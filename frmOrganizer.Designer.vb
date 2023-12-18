<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganizer
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
        Me.picOrganizer1 = New System.Windows.Forms.PictureBox()
        Me.picOrganizer2 = New System.Windows.Forms.PictureBox()
        Me.picOrganizer3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picOrganizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrganizer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrganizer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOrganizer1
        '
        Me.picOrganizer1.Image = Global.WindowsApp1.My.Resources.Resources.ian_dooley
        Me.picOrganizer1.Location = New System.Drawing.Point(36, 128)
        Me.picOrganizer1.Name = "picOrganizer1"
        Me.picOrganizer1.Size = New System.Drawing.Size(325, 294)
        Me.picOrganizer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer1.TabIndex = 0
        Me.picOrganizer1.TabStop = False
        '
        'picOrganizer2
        '
        Me.picOrganizer2.Image = Global.WindowsApp1.My.Resources.Resources.michael_dam
        Me.picOrganizer2.Location = New System.Drawing.Point(397, 128)
        Me.picOrganizer2.Name = "picOrganizer2"
        Me.picOrganizer2.Size = New System.Drawing.Size(325, 294)
        Me.picOrganizer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer2.TabIndex = 0
        Me.picOrganizer2.TabStop = False
        '
        'picOrganizer3
        '
        Me.picOrganizer3.Image = Global.WindowsApp1.My.Resources.Resources.aiony_haust
        Me.picOrganizer3.Location = New System.Drawing.Point(759, 128)
        Me.picOrganizer3.Name = "picOrganizer3"
        Me.picOrganizer3.Size = New System.Drawing.Size(325, 294)
        Me.picOrganizer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrganizer3.TabIndex = 0
        Me.picOrganizer3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Organizer"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DblClick on candidate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmOrganizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picOrganizer3)
        Me.Controls.Add(Me.picOrganizer2)
        Me.Controls.Add(Me.picOrganizer1)
        Me.MinimizeBox = False
        Me.Name = "frmOrganizer"
        Me.ShowInTaskbar = False
        Me.Text = "frmOrganizer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picOrganizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrganizer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrganizer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picOrganizer1 As PictureBox
    Friend WithEvents picOrganizer2 As PictureBox
    Friend WithEvents picOrganizer3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
