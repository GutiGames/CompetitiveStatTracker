<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankedJoust
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.SmiteJoustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteJoustTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.SmiteJoustTableAdapter()
        Me.MatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchNumberDataGridViewTextBoxColumn, Me.ResultDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SmiteJoustBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 531)
        Me.DataGridView1.TabIndex = 0
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SmiteJoustBindingSource
        '
        Me.SmiteJoustBindingSource.DataMember = "SmiteJoust"
        Me.SmiteJoustBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteJoustTableAdapter
        '
        Me.SmiteJoustTableAdapter.ClearBeforeFill = True
        '
        'MatchNumberDataGridViewTextBoxColumn
        '
        Me.MatchNumberDataGridViewTextBoxColumn.DataPropertyName = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.HeaderText = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.Name = "MatchNumberDataGridViewTextBoxColumn"
        '
        'ResultDataGridViewTextBoxColumn
        '
        Me.ResultDataGridViewTextBoxColumn.DataPropertyName = "Result"
        Me.ResultDataGridViewTextBoxColumn.HeaderText = "Result"
        Me.ResultDataGridViewTextBoxColumn.Name = "ResultDataGridViewTextBoxColumn"
        '
        'RankedJoust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RankedJoust"
        Me.Text = "RankedJoust"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents SmiteJoustBindingSource As BindingSource
    Friend WithEvents SmiteJoustTableAdapter As SmiteDataSetTableAdapters.SmiteJoustTableAdapter
    Friend WithEvents MatchNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
