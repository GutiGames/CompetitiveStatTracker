<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddJoustMatch
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.God1 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.GodsTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.GodsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'God1
        '
        Me.God1.AllowDrop = True
        Me.God1.DataSource = Me.GodsBindingSource
        Me.God1.DisplayMember = "Name"
        Me.God1.FormattingEnabled = True
        Me.God1.Location = New System.Drawing.Point(71, 104)
        Me.God1.Name = "God1"
        Me.God1.Size = New System.Drawing.Size(85, 21)
        Me.God1.TabIndex = 21
        Me.God1.ValueMember = "IdGod"
        '
        'GodsBindingSource
        '
        Me.GodsBindingSource.DataMember = "Gods"
        Me.GodsBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GodsTableAdapter
        '
        Me.GodsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(71, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'AddJoustMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.God1)
        Me.Name = "AddJoustMatch"
        Me.Text = "AddJoustMatch"
        CType(Me.GodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents God1 As ComboBox
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents GodsBindingSource As BindingSource
    Friend WithEvents GodsTableAdapter As SmiteDataSetTableAdapters.GodsTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
End Class
