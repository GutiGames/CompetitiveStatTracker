<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankedDuel
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
        Me.Back = New System.Windows.Forms.Button()
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
        Me.DuelMatchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.Que = New System.Windows.Forms.ComboBox()
        Me.QueTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Assists = New System.Windows.Forms.TextBox()
        Me.Kills = New System.Windows.Forms.TextBox()
        Me.Deaths = New System.Windows.Forms.TextBox()
        Me.Winner = New System.Windows.Forms.ComboBox()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tier = New System.Windows.Forms.ComboBox()
        Me.TiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatchID = New System.Windows.Forms.TextBox()
        Me.Modify = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.DuelMatchesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.DuelMatchesTableAdapter()
        Me.TiersTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.TiersTableAdapter()
        Me.TeamsTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.TeamsTableAdapter()
        Me.QueTypesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.QueTypesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Stats = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuelMatchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMatchDataGridViewTextBoxColumn, Me.TierDataGridViewTextBoxColumn, Me.WinnerDataGridViewTextBoxColumn, Me.QueTypeDataGridViewTextBoxColumn, Me.MyKDataGridViewTextBoxColumn, Me.MyDDataGridViewTextBoxColumn, Me.MyADataGridViewTextBoxColumn, Me.MyKDADataGridViewTextBoxColumn, Me.CommetsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DuelMatchesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 500)
        Me.DataGridView1.TabIndex = 33
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
        'DuelMatchesBindingSource
        '
        Me.DuelMatchesBindingSource.DataMember = "DuelMatches"
        Me.DuelMatchesBindingSource.DataSource = Me.SmiteDataSet
        '
        'SmiteDataSet
        '
        Me.SmiteDataSet.DataSetName = "SmiteDataSet"
        Me.SmiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(863, 617)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Comment:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(325, 617)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Que Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(605, 617)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Assists:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(510, 617)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Deaths:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 617)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Kills:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 617)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Winner:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 617)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Tier:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 617)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Match Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Comment
        '
        Me.Comment.Location = New System.Drawing.Point(683, 636)
        Me.Comment.Margin = New System.Windows.Forms.Padding(4)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(461, 22)
        Me.Comment.TabIndex = 41
        '
        'Que
        '
        Me.Que.AllowDrop = True
        Me.Que.DataSource = Me.QueTypesBindingSource
        Me.Que.DisplayMember = "Name"
        Me.Que.FormattingEnabled = True
        Me.Que.Location = New System.Drawing.Point(327, 636)
        Me.Que.Margin = New System.Windows.Forms.Padding(4)
        Me.Que.Name = "Que"
        Me.Que.Size = New System.Drawing.Size(66, 21)
        Me.Que.TabIndex = 40
        Me.Que.ValueMember = "IdQueType"
        '
        'QueTypesBindingSource
        '
        Me.QueTypesBindingSource.DataMember = "QueTypes"
        Me.QueTypesBindingSource.DataSource = Me.SmiteDataSet
        '
        'Assists
        '
        Me.Assists.Location = New System.Drawing.Point(589, 636)
        Me.Assists.Margin = New System.Windows.Forms.Padding(4)
        Me.Assists.Name = "Assists"
        Me.Assists.Size = New System.Drawing.Size(86, 20)
        Me.Assists.TabIndex = 39
        '
        'Kills
        '
        Me.Kills.Location = New System.Drawing.Point(401, 636)
        Me.Kills.Margin = New System.Windows.Forms.Padding(4)
        Me.Kills.Name = "Kills"
        Me.Kills.Size = New System.Drawing.Size(86, 20)
        Me.Kills.TabIndex = 38
        '
        'Deaths
        '
        Me.Deaths.Location = New System.Drawing.Point(495, 636)
        Me.Deaths.Margin = New System.Windows.Forms.Padding(4)
        Me.Deaths.Name = "Deaths"
        Me.Deaths.Size = New System.Drawing.Size(86, 20)
        Me.Deaths.TabIndex = 37
        '
        'Winner
        '
        Me.Winner.AllowDrop = True
        Me.Winner.DataSource = Me.TeamsBindingSource
        Me.Winner.DisplayMember = "Names"
        Me.Winner.FormattingEnabled = True
        Me.Winner.Location = New System.Drawing.Point(246, 636)
        Me.Winner.Margin = New System.Windows.Forms.Padding(4)
        Me.Winner.Name = "Winner"
        Me.Winner.Size = New System.Drawing.Size(73, 21)
        Me.Winner.TabIndex = 36
        Me.Winner.ValueMember = "IdTeams"
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.SmiteDataSet
        '
        'Tier
        '
        Me.Tier.AllowDrop = True
        Me.Tier.DataSource = Me.TiersBindingSource
        Me.Tier.DisplayMember = "Nombre"
        Me.Tier.FormattingEnabled = True
        Me.Tier.Location = New System.Drawing.Point(126, 636)
        Me.Tier.Margin = New System.Windows.Forms.Padding(4)
        Me.Tier.Name = "Tier"
        Me.Tier.Size = New System.Drawing.Size(112, 21)
        Me.Tier.TabIndex = 35
        Me.Tier.ValueMember = "IdTier"
        '
        'TiersBindingSource
        '
        Me.TiersBindingSource.DataMember = "Tiers"
        Me.TiersBindingSource.DataSource = Me.SmiteDataSet
        '
        'MatchID
        '
        Me.MatchID.Location = New System.Drawing.Point(16, 636)
        Me.MatchID.Margin = New System.Windows.Forms.Padding(4)
        Me.MatchID.Name = "MatchID"
        Me.MatchID.Size = New System.Drawing.Size(102, 20)
        Me.MatchID.TabIndex = 34
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(1205, 636)
        Me.Modify.Margin = New System.Windows.Forms.Padding(4)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(45, 22)
        Me.Modify.TabIndex = 50
        Me.Modify.Text = "Edit"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(1152, 636)
        Me.Add.Margin = New System.Windows.Forms.Padding(4)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(45, 22)
        Me.Add.TabIndex = 51
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'DuelMatchesTableAdapter
        '
        Me.DuelMatchesTableAdapter.ClearBeforeFill = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(978, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "=>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Stats
        '
        Me.Stats.Location = New System.Drawing.Point(1119, 13)
        Me.Stats.Margin = New System.Windows.Forms.Padding(4)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(133, 50)
        Me.Stats.TabIndex = 53
        Me.Stats.Text = "Stats"
        Me.Stats.UseVisualStyleBackColor = True
        '
        'RankedDuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Stats)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.Add)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Back)
        Me.Name = "RankedDuel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RankedDuel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuelMatchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Comment As TextBox
    Friend WithEvents Que As ComboBox
    Friend WithEvents Assists As TextBox
    Friend WithEvents Kills As TextBox
    Friend WithEvents Deaths As TextBox
    Friend WithEvents Winner As ComboBox
    Friend WithEvents Tier As ComboBox
    Friend WithEvents MatchID As TextBox
    Friend WithEvents Modify As Button
    Friend WithEvents Add As Button
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents DuelMatchesBindingSource As BindingSource
    Friend WithEvents DuelMatchesTableAdapter As SmiteDataSetTableAdapters.DuelMatchesTableAdapter
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Stats As Button
End Class
