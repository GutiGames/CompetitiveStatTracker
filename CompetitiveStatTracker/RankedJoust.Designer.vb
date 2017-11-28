<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RankedJoust
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
        Me.components = New System.ComponentModel.Container()
        Me.Add = New System.Windows.Forms.Button()
        Me.MatchID = New System.Windows.Forms.TextBox()
        Me.Tier = New System.Windows.Forms.ComboBox()
        Me.TiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.Winner = New System.Windows.Forms.ComboBox()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deaths = New System.Windows.Forms.TextBox()
        Me.Kills = New System.Windows.Forms.TextBox()
        Me.Assists = New System.Windows.Forms.TextBox()
        Me.Que = New System.Windows.Forms.ComboBox()
        Me.QueTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Atras = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMatchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyKDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommetsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoustMatchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoustMatchesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.JoustMatchesTableAdapter()
        Me.TiersTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.TiersTableAdapter()
        Me.TeamsTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.TeamsTableAdapter()
        Me.QueTypesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.QueTypesTableAdapter()
        Me.siguiente = New System.Windows.Forms.Button()
        CType(Me.TiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoustMatchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(972, 674)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 21)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'MatchID
        '
        Me.MatchID.Location = New System.Drawing.Point(15, 675)
        Me.MatchID.Name = "MatchID"
        Me.MatchID.Size = New System.Drawing.Size(100, 20)
        Me.MatchID.TabIndex = 6
        '
        'Tier
        '
        Me.Tier.AllowDrop = True
        Me.Tier.DataSource = Me.TiersBindingSource
        Me.Tier.DisplayMember = "Nombre"
        Me.Tier.FormattingEnabled = True
        Me.Tier.Location = New System.Drawing.Point(123, 674)
        Me.Tier.Name = "Tier"
        Me.Tier.Size = New System.Drawing.Size(85, 21)
        Me.Tier.TabIndex = 10
        Me.Tier.ValueMember = "IdTier"
        '
        'TiersBindingSource
        '
        Me.TiersBindingSource.DataMember = "Tiers"
        Me.TiersBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Winner
        '
        Me.Winner.AllowDrop = True
        Me.Winner.DataSource = Me.TeamsBindingSource
        Me.Winner.DisplayMember = "Names"
        Me.Winner.FormattingEnabled = True
        Me.Winner.Location = New System.Drawing.Point(214, 674)
        Me.Winner.Name = "Winner"
        Me.Winner.Size = New System.Drawing.Size(81, 21)
        Me.Winner.TabIndex = 11
        Me.Winner.ValueMember = "IdTeams"
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.SmiteDataSet
        '
        'Deaths
        '
        Me.Deaths.Location = New System.Drawing.Point(474, 674)
        Me.Deaths.Name = "Deaths"
        Me.Deaths.Size = New System.Drawing.Size(65, 20)
        Me.Deaths.TabIndex = 14
        '
        'Kills
        '
        Me.Kills.Location = New System.Drawing.Point(407, 674)
        Me.Kills.Name = "Kills"
        Me.Kills.Size = New System.Drawing.Size(65, 20)
        Me.Kills.TabIndex = 15
        '
        'Assists
        '
        Me.Assists.Location = New System.Drawing.Point(541, 674)
        Me.Assists.Name = "Assists"
        Me.Assists.Size = New System.Drawing.Size(65, 20)
        Me.Assists.TabIndex = 16
        '
        'Que
        '
        Me.Que.AllowDrop = True
        Me.Que.DataSource = Me.QueTypesBindingSource
        Me.Que.DisplayMember = "Name"
        Me.Que.FormattingEnabled = True
        Me.Que.Location = New System.Drawing.Point(301, 674)
        Me.Que.Name = "Que"
        Me.Que.Size = New System.Drawing.Size(100, 21)
        Me.Que.TabIndex = 17
        Me.Que.ValueMember = "IdQueType"
        '
        'QueTypesBindingSource
        '
        Me.QueTypesBindingSource.DataMember = "QueTypes"
        Me.QueTypesBindingSource.DataSource = Me.SmiteDataSet
        '
        'Comment
        '
        Me.Comment.Location = New System.Drawing.Point(619, 674)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(347, 21)
        Me.Comment.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 655)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Match Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 656)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tier:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 656)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Winner:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 654)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Kills:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(481, 654)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Deaths:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(548, 654)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Assists:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 654)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Que Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(756, 654)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Comment:"
        '
        'Atras
        '
        Me.Atras.Location = New System.Drawing.Point(12, 12)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(100, 48)
        Me.Atras.TabIndex = 31
        Me.Atras.Text = "<="
        Me.Atras.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMatchDataGridViewTextBoxColumn, Me.TierDataGridViewTextBoxColumn, Me.WinnerDataGridViewTextBoxColumn, Me.QueTypeDataGridViewTextBoxColumn, Me.MyKDataGridViewTextBoxColumn, Me.MyDDataGridViewTextBoxColumn, Me.MyADataGridViewTextBoxColumn, Me.MyKDADataGridViewTextBoxColumn, Me.CommetsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JoustMatchesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 583)
        Me.DataGridView1.TabIndex = 32
        '
        'IdMatchDataGridViewTextBoxColumn
        '
        Me.IdMatchDataGridViewTextBoxColumn.DataPropertyName = "IdMatch"
        Me.IdMatchDataGridViewTextBoxColumn.HeaderText = "IdMatch"
        Me.IdMatchDataGridViewTextBoxColumn.Name = "IdMatchDataGridViewTextBoxColumn"
        Me.IdMatchDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TierDataGridViewTextBoxColumn
        '
        Me.TierDataGridViewTextBoxColumn.DataPropertyName = "Tier"
        Me.TierDataGridViewTextBoxColumn.HeaderText = "Tier"
        Me.TierDataGridViewTextBoxColumn.Name = "TierDataGridViewTextBoxColumn"
        Me.TierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WinnerDataGridViewTextBoxColumn
        '
        Me.WinnerDataGridViewTextBoxColumn.DataPropertyName = "Winner"
        Me.WinnerDataGridViewTextBoxColumn.HeaderText = "Winner"
        Me.WinnerDataGridViewTextBoxColumn.Name = "WinnerDataGridViewTextBoxColumn"
        Me.WinnerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QueTypeDataGridViewTextBoxColumn
        '
        Me.QueTypeDataGridViewTextBoxColumn.DataPropertyName = "Que Type"
        Me.QueTypeDataGridViewTextBoxColumn.HeaderText = "Que Type"
        Me.QueTypeDataGridViewTextBoxColumn.Name = "QueTypeDataGridViewTextBoxColumn"
        Me.QueTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MyKDataGridViewTextBoxColumn
        '
        Me.MyKDataGridViewTextBoxColumn.DataPropertyName = "My K"
        Me.MyKDataGridViewTextBoxColumn.HeaderText = "My K"
        Me.MyKDataGridViewTextBoxColumn.Name = "MyKDataGridViewTextBoxColumn"
        Me.MyKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MyDDataGridViewTextBoxColumn
        '
        Me.MyDDataGridViewTextBoxColumn.DataPropertyName = "My D"
        Me.MyDDataGridViewTextBoxColumn.HeaderText = "My D"
        Me.MyDDataGridViewTextBoxColumn.Name = "MyDDataGridViewTextBoxColumn"
        Me.MyDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MyADataGridViewTextBoxColumn
        '
        Me.MyADataGridViewTextBoxColumn.DataPropertyName = "My A"
        Me.MyADataGridViewTextBoxColumn.HeaderText = "My A"
        Me.MyADataGridViewTextBoxColumn.Name = "MyADataGridViewTextBoxColumn"
        Me.MyADataGridViewTextBoxColumn.ReadOnly = True
        '
        'MyKDADataGridViewTextBoxColumn
        '
        Me.MyKDADataGridViewTextBoxColumn.DataPropertyName = "My KDA"
        Me.MyKDADataGridViewTextBoxColumn.HeaderText = "My KDA"
        Me.MyKDADataGridViewTextBoxColumn.Name = "MyKDADataGridViewTextBoxColumn"
        Me.MyKDADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommetsDataGridViewTextBoxColumn
        '
        Me.CommetsDataGridViewTextBoxColumn.DataPropertyName = "Commets"
        Me.CommetsDataGridViewTextBoxColumn.HeaderText = "Commets"
        Me.CommetsDataGridViewTextBoxColumn.Name = "CommetsDataGridViewTextBoxColumn"
        Me.CommetsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JoustMatchesBindingSource
        '
        Me.JoustMatchesBindingSource.DataMember = "JoustMatches"
        Me.JoustMatchesBindingSource.DataSource = Me.SmiteDataSet
        '
        'JoustMatchesTableAdapter
        '
        Me.JoustMatchesTableAdapter.ClearBeforeFill = True
        '
        'TiersTableAdapter
        '
        Me.TiersTableAdapter.ClearBeforeFill = True
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'QueTypesTableAdapter
        '
        Me.QueTypesTableAdapter.ClearBeforeFill = True
        '
        'siguiente
        '
        Me.siguiente.Location = New System.Drawing.Point(569, 12)
        Me.siguiente.Name = "siguiente"
        Me.siguiente.Size = New System.Drawing.Size(100, 48)
        Me.siguiente.TabIndex = 31
        Me.siguiente.Text = "<="
        Me.siguiente.UseVisualStyleBackColor = True
        '
        'RankedJoust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 721)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.siguiente)
        Me.Controls.Add(Me.Atras)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.Que)
        Me.Controls.Add(Me.Assists)
        Me.Controls.Add(Me.Kills)
        Me.Controls.Add(Me.Deaths)
        Me.Controls.Add(Me.Winner)
        Me.Controls.Add(Me.Tier)
        Me.Controls.Add(Me.MatchID)
        Me.Controls.Add(Me.Add)
        Me.Name = "RankedJoust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RankedJoust"
        CType(Me.TiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoustMatchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add As Button
    Friend WithEvents MatchID As TextBox
    Friend WithEvents Tier As ComboBox
    Friend WithEvents Winner As ComboBox
    Friend WithEvents Deaths As TextBox
    Friend WithEvents Kills As TextBox
    Friend WithEvents Assists As TextBox
    Friend WithEvents Que As ComboBox
    Friend WithEvents Comment As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Atras As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents JoustMatchesBindingSource As BindingSource
    Friend WithEvents JoustMatchesTableAdapter As SmiteDataSetTableAdapters.JoustMatchesTableAdapter
    Friend WithEvents IdMatchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WinnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyKDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommetsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiersBindingSource As BindingSource
    Friend WithEvents TiersTableAdapter As SmiteDataSetTableAdapters.TiersTableAdapter
    Friend WithEvents TeamsBindingSource As BindingSource
    Friend WithEvents TeamsTableAdapter As SmiteDataSetTableAdapters.TeamsTableAdapter
    Friend WithEvents QueTypesBindingSource As BindingSource
    Friend WithEvents QueTypesTableAdapter As SmiteDataSetTableAdapters.QueTypesTableAdapter
    Friend WithEvents siguiente As Button
End Class
