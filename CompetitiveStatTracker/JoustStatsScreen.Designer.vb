<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JoustStatsScreen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Atras = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinRatioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.WinRatioTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.WinRatioTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinRatioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Atras
        '
        Me.Atras.Location = New System.Drawing.Point(13, 13)
        Me.Atras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(133, 50)
        Me.Atras.TabIndex = 32
        Me.Atras.Text = "<="
        Me.Atras.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PlayedDataGridViewTextBoxColumn, Me.WinnedDataGridViewTextBoxColumn, Me.WinRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WinRatioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(468, 256)
        Me.DataGridView1.TabIndex = 33
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlayedDataGridViewTextBoxColumn
        '
        Me.PlayedDataGridViewTextBoxColumn.DataPropertyName = "Played"
        Me.PlayedDataGridViewTextBoxColumn.HeaderText = "Played"
        Me.PlayedDataGridViewTextBoxColumn.Name = "PlayedDataGridViewTextBoxColumn"
        Me.PlayedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinnedDataGridViewTextBoxColumn
        '
        Me.WinnedDataGridViewTextBoxColumn.DataPropertyName = "Winned"
        Me.WinnedDataGridViewTextBoxColumn.HeaderText = "Winned"
        Me.WinnedDataGridViewTextBoxColumn.Name = "WinnedDataGridViewTextBoxColumn"
        Me.WinnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinRateDataGridViewTextBoxColumn
        '
        Me.WinRateDataGridViewTextBoxColumn.DataPropertyName = "WinRate"
        Me.WinRateDataGridViewTextBoxColumn.HeaderText = "WinRate"
        Me.WinRateDataGridViewTextBoxColumn.Name = "WinRateDataGridViewTextBoxColumn"
        Me.WinRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinRatioBindingSource
        '
        Me.WinRatioBindingSource.DataMember = "WinRatio"
        Me.WinRatioBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WinRatioTableAdapter
        '
        Me.WinRatioTableAdapter.ClearBeforeFill = True
        '
        'JoustStatsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "JoustStatsScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JoustStatsScreen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinRatioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Atras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents WinRatioBindingSource As BindingSource
    Friend WithEvents WinRatioTableAdapter As SmiteDataSetTableAdapters.WinRatioTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
