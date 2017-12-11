<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Title = New System.Windows.Forms.Label()
        Me.Smite = New System.Windows.Forms.PictureBox()
        Me.OW = New System.Windows.Forms.PictureBox()
        CType(Me.Smite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 51.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(93, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(1240, 75)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Competitive Stat Tracker"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Smite
        '
        Me.Smite.Image = CType(resources.GetObject("Smite.Image"), System.Drawing.Image)
        Me.Smite.Location = New System.Drawing.Point(53, 249)
        Me.Smite.Name = "Smite"
        Me.Smite.Size = New System.Drawing.Size(512, 285)
        Me.Smite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Smite.TabIndex = 1
        Me.Smite.TabStop = False
        '
        'OW
        '
        Me.OW.Image = CType(resources.GetObject("OW.Image"), System.Drawing.Image)
        Me.OW.Location = New System.Drawing.Point(740, 249)
        Me.OW.Name = "OW"
        Me.OW.Size = New System.Drawing.Size(512, 285)
        Me.OW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OW.TabIndex = 2
        Me.OW.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 681)
        Me.Controls.Add(Me.OW)
        Me.Controls.Add(Me.Smite)
        Me.Controls.Add(Me.Title)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Competitive Stat Tracker"
        CType(Me.Smite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Smite As PictureBox
    Friend WithEvents OW As PictureBox
End Class
