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
        Me.Back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.JoustWinRatioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoustWinRatioTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.JoustWinRatioTableAdapter()
        Me.GodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlayedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinRatioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoustWinRatioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(13, 13)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(133, 50)
        Me.Back.TabIndex = 32
        Me.Back.Text = "<="
        Me.Back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GodDataGridViewTextBoxColumn, Me.WinnedDataGridViewTextBoxColumn, Me.PlayedDataGridViewTextBoxColumn, Me.WinRatioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JoustWinRatioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(468, 256)
        Me.DataGridView1.TabIndex = 33
        '
        'GodDataGridViewTextBoxColumn
        '
        Me.GodDataGridViewTextBoxColumn.DataPropertyName = "God"
        Me.GodDataGridViewTextBoxColumn.HeaderText = "God"
        Me.GodDataGridViewTextBoxColumn.Name = "GodDataGridViewTextBoxColumn"
        Me.GodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinnedDataGridViewTextBoxColumn
        '
        Me.WinnedDataGridViewTextBoxColumn.DataPropertyName = "Winned"
        Me.WinnedDataGridViewTextBoxColumn.HeaderText = "Winned"
        Me.WinnedDataGridViewTextBoxColumn.Name = "WinnedDataGridViewTextBoxColumn"
        Me.WinnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlayedDataGridViewTextBoxColumn
        '
        Me.PlayedDataGridViewTextBoxColumn.DataPropertyName = "Played"
        Me.PlayedDataGridViewTextBoxColumn.HeaderText = "Played"
        Me.PlayedDataGridViewTextBoxColumn.Name = "PlayedDataGridViewTextBoxColumn"
        Me.PlayedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinRatioDataGridViewTextBoxColumn
        '
        Me.WinRatioDataGridViewTextBoxColumn.DataPropertyName = "WinRatio"
        Me.WinRatioDataGridViewTextBoxColumn.HeaderText = "WinRatio"
        Me.WinRatioDataGridViewTextBoxColumn.Name = "WinRatioDataGridViewTextBoxColumn"
        Me.WinRatioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JoustWinRatioBindingSource
        '
        Me.JoustWinRatioBindingSource.DataMember = "JoustWinRatio"
        Me.JoustWinRatioBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JoustWinRatioTableAdapter
        '
        Me.JoustWinRatioTableAdapter.ClearBeforeFill = True
        '
        'JoustStatsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Back)
        Me.Name = "JoustStatsScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JoustStatsScreen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoustWinRatioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents JoustWinRatioBindingSource As BindingSource
    Friend WithEvents JoustWinRatioTableAdapter As SmiteDataSetTableAdapters.JoustWinRatioTableAdapter
    Friend WithEvents GodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlayedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinRatioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
