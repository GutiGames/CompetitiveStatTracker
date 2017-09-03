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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 2.0R)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EloBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmiteJoustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteJoustDataSet = New CompetitiveStatTracker.SmiteJoustDataSet()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.TotalElo = New System.Windows.Forms.TextBox()
        Me.EloBalance = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.MatchID = New System.Windows.Forms.TextBox()
        Me.SmiteJoustTableAdapter = New CompetitiveStatTracker.SmiteJoustDataSetTableAdapters.SmiteJoustTableAdapter()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteJoustDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchNumberDataGridViewTextBoxColumn, Me.ResultDataGridViewTextBoxColumn, Me.EloBalanceDataGridViewTextBoxColumn, Me.TotalEloDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SmiteJoustBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(717, 214)
        Me.DataGridView1.TabIndex = 0
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
        'EloBalanceDataGridViewTextBoxColumn
        '
        Me.EloBalanceDataGridViewTextBoxColumn.DataPropertyName = "Elo Balance"
        Me.EloBalanceDataGridViewTextBoxColumn.HeaderText = "Elo Balance"
        Me.EloBalanceDataGridViewTextBoxColumn.Name = "EloBalanceDataGridViewTextBoxColumn"
        '
        'TotalEloDataGridViewTextBoxColumn
        '
        Me.TotalEloDataGridViewTextBoxColumn.DataPropertyName = "Total Elo"
        Me.TotalEloDataGridViewTextBoxColumn.HeaderText = "Total Elo"
        Me.TotalEloDataGridViewTextBoxColumn.Name = "TotalEloDataGridViewTextBoxColumn"
        '
        'SmiteJoustBindingSource
        '
        Me.SmiteJoustBindingSource.DataMember = "SmiteJoust"
        Me.SmiteJoustBindingSource.DataSource = Me.SmiteJoustDataSet
        '
        'SmiteJoustDataSet
        '
        Me.SmiteJoustDataSet.DataSetName = "SmiteJoustDataSet"
        Me.SmiteJoustDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(183, 429)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(100, 20)
        Me.Result.TabIndex = 1
        '
        'TotalElo
        '
        Me.TotalElo.Location = New System.Drawing.Point(395, 429)
        Me.TotalElo.Name = "TotalElo"
        Me.TotalElo.Size = New System.Drawing.Size(100, 20)
        Me.TotalElo.TabIndex = 2
        '
        'EloBalance
        '
        Me.EloBalance.Location = New System.Drawing.Point(289, 429)
        Me.EloBalance.Name = "EloBalance"
        Me.EloBalance.Size = New System.Drawing.Size(100, 20)
        Me.EloBalance.TabIndex = 3
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(512, 429)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(512, 458)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(75, 23)
        Me.Modify.TabIndex = 5
        Me.Modify.Text = "Update"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'MatchID
        '
        Me.MatchID.Location = New System.Drawing.Point(77, 429)
        Me.MatchID.Name = "MatchID"
        Me.MatchID.Size = New System.Drawing.Size(100, 20)
        Me.MatchID.TabIndex = 6
        '
        'SmiteJoustTableAdapter
        '
        Me.SmiteJoustTableAdapter.ClearBeforeFill = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.SmiteJoustBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(759, 30)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Elo"
        Series1.Points.Add(DataPoint1)
        Series1.XValueMember = "MatchNumber"
        Series1.YValueMembers = "MatchNumber"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'RankedJoust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 596)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MatchID)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.EloBalance)
        Me.Controls.Add(Me.TotalElo)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RankedJoust"
        Me.Text = "RankedJoust"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteJoustDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SmiteJoustDataSet As SmiteJoustDataSet
    Friend WithEvents SmiteJoustBindingSource As BindingSource
    Friend WithEvents SmiteJoustTableAdapter As SmiteJoustDataSetTableAdapters.SmiteJoustTableAdapter
    Friend WithEvents MatchNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EloBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Result As TextBox
    Friend WithEvents TotalElo As TextBox
    Friend WithEvents EloBalance As TextBox
    Friend WithEvents Add As Button
    Friend WithEvents Modify As Button
    Friend WithEvents MatchID As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
