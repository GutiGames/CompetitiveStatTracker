<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmiteMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SmiteMenu))
        Me.Conquest = New System.Windows.Forms.PictureBox()
        Me.Joust = New System.Windows.Forms.PictureBox()
        Me.Duel = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Atras = New System.Windows.Forms.Button()
        CType(Me.Conquest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Duel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Conquest
        '
        Me.Conquest.ErrorImage = Nothing
        Me.Conquest.Image = CType(resources.GetObject("Conquest.Image"), System.Drawing.Image)
        Me.Conquest.InitialImage = Nothing
        Me.Conquest.Location = New System.Drawing.Point(8, 67)
        Me.Conquest.Name = "Conquest"
        Me.Conquest.Size = New System.Drawing.Size(430, 602)
        Me.Conquest.TabIndex = 0
        Me.Conquest.TabStop = False
        '
        'Joust
        '
        Me.Joust.Image = CType(resources.GetObject("Joust.Image"), System.Drawing.Image)
        Me.Joust.Location = New System.Drawing.Point(439, 67)
        Me.Joust.Name = "Joust"
        Me.Joust.Size = New System.Drawing.Size(430, 602)
        Me.Joust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Joust.TabIndex = 1
        Me.Joust.TabStop = False
        '
        'Duel
        '
        Me.Duel.Image = CType(resources.GetObject("Duel.Image"), System.Drawing.Image)
        Me.Duel.Location = New System.Drawing.Point(870, 67)
        Me.Duel.Name = "Duel"
        Me.Duel.Size = New System.Drawing.Size(430, 602)
        Me.Duel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Duel.TabIndex = 2
        Me.Duel.TabStop = False
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(5, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(1290, 55)
        Me.Title.TabIndex = 3
        Me.Title.Text = "Competitive Smite"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Atras
        '
        Me.Atras.Location = New System.Drawing.Point(8, 12)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(100, 40)
        Me.Atras.TabIndex = 32
        Me.Atras.Text = "<="
        Me.Atras.UseVisualStyleBackColor = True
        '
        'SmiteMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 671)
        Me.Controls.Add(Me.Atras)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Duel)
        Me.Controls.Add(Me.Joust)
        Me.Controls.Add(Me.Conquest)
        Me.Name = "SmiteMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smite"
        CType(Me.Conquest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Duel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Conquest As PictureBox
    Friend WithEvents Joust As PictureBox
    Friend WithEvents Duel As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Atras As Button
End Class
