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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TotalElo = New System.Windows.Forms.TextBox()
        Me.EloBalance = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.MatchID = New System.Windows.Forms.TextBox()
        Me.Tier = New System.Windows.Forms.ComboBox()
        Me.Result = New System.Windows.Forms.ComboBox()
        Me.Role = New System.Windows.Forms.ComboBox()
        Me.God = New System.Windows.Forms.ComboBox()
        Me.Deads = New System.Windows.Forms.TextBox()
        Me.Kills = New System.Windows.Forms.TextBox()
        Me.Assists = New System.Windows.Forms.TextBox()
        Me.Que = New System.Windows.Forms.ComboBox()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SmiteJoustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteJoustDataSet = New CompetitiveStatTracker.SmiteJoustDataSet()
        Me.MatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EloBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmiteJoustTableAdapter = New CompetitiveStatTracker.SmiteJoustDataSetTableAdapters.SmiteJoustTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteJoustDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchNumberDataGridViewTextBoxColumn, Me.TierDataGridViewTextBoxColumn, Me.ResultDataGridViewTextBoxColumn, Me.EloBalanceDataGridViewTextBoxColumn, Me.TotalEloDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.GodDataGridViewTextBoxColumn, Me.KDADataGridViewTextBoxColumn, Me.QueTypeDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SmiteJoustBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 585)
        Me.DataGridView1.TabIndex = 0
        '
        'TotalElo
        '
        Me.TotalElo.Location = New System.Drawing.Point(455, 619)
        Me.TotalElo.Name = "TotalElo"
        Me.TotalElo.Size = New System.Drawing.Size(100, 20)
        Me.TotalElo.TabIndex = 2
        '
        'EloBalance
        '
        Me.EloBalance.Location = New System.Drawing.Point(349, 619)
        Me.EloBalance.Name = "EloBalance"
        Me.EloBalance.Size = New System.Drawing.Size(100, 20)
        Me.EloBalance.TabIndex = 3
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(972, 619)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 30)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(972, 655)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(75, 30)
        Me.Modify.TabIndex = 5
        Me.Modify.Text = "Update"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'MatchID
        '
        Me.MatchID.Location = New System.Drawing.Point(38, 619)
        Me.MatchID.Name = "MatchID"
        Me.MatchID.Size = New System.Drawing.Size(100, 20)
        Me.MatchID.TabIndex = 6
        '
        'Tier
        '
        Me.Tier.AllowDrop = True
        Me.Tier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmiteJoustBindingSource, "Tier", True))
        Me.Tier.FormattingEnabled = True
        Me.Tier.Items.AddRange(New Object() {"Bronze V", "Bronze IV", "Bronze III", "Bronze II", "Bronze I", "Silver V", "Silver IV", "Silver III", "Silver II", "Silver I", "Gold V", "Gold IV", "Gold III", "Gold II", "Gold I", "Platinum V", "Platinum IV", "Platinum III", "Platinum II", "Platinum I", "Diamond V", "Diamond IV", "Diamond III", "Diamond II", "Diamond I", "Master", "Grandmaster"})
        Me.Tier.Location = New System.Drawing.Point(144, 618)
        Me.Tier.Name = "Tier"
        Me.Tier.Size = New System.Drawing.Size(100, 21)
        Me.Tier.TabIndex = 10
        '
        'Result
        '
        Me.Result.AllowDrop = True
        Me.Result.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmiteJoustBindingSource, "Tier", True))
        Me.Result.FormattingEnabled = True
        Me.Result.Items.AddRange(New Object() {"Win", "Lose"})
        Me.Result.Location = New System.Drawing.Point(250, 618)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(93, 21)
        Me.Result.TabIndex = 11
        '
        'Role
        '
        Me.Role.AllowDrop = True
        Me.Role.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmiteJoustBindingSource, "Tier", True))
        Me.Role.FormattingEnabled = True
        Me.Role.Items.AddRange(New Object() {"ADC", "Mage", "Support"})
        Me.Role.Location = New System.Drawing.Point(38, 666)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(100, 21)
        Me.Role.TabIndex = 12
        '
        'God
        '
        Me.God.AllowDrop = True
        Me.God.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmiteJoustBindingSource, "Tier", True))
        Me.God.FormattingEnabled = True
        Me.God.Items.AddRange(New Object() {"Agni", "Ah Muzen Cab", "Ah Puch", "Amaterasu", "Anhur", "Anubis", "Ao Kuang", "Aphrodite", "Apollo", "Arachne", "Ares", "Artemis", "Artio", "Athena", "Awilix", "Bacchus", "Bakasura", "Bastet", "Bellona", "Cabrakan", "Camazotz", "Cernunnos", "Chaac", "Chang'e", "Chiron", "Chronos", "Cu Chulainn", "Cupid", "Da Ji", "Erlang Shen", "Fafnir", "Fenrir", "Freya", "Ganesha", "Geb", "Guan Yu", "Hades", "He Bo", "Hel", "Hercules", "Hou Yi", "Hun Batz", "Isis", "Izanami", "Janus", "Jing Wei", "Kali", "Khepri", "Kukulkan", "Kumbhakarna", "Kuzenbo", "Loki", "Medusa", "Mercury", "Ne Zha", "Neith", "Nemesis", "Nike", "Nox", "Nu Wa", "Odin", "Osiris", "Poseidon", "Ra", "Raijin", "Rama", "Ratatoskr", "Ravana", "Scylla", "Serqet", "Skadi", "Sobek", "Sol", "Sun Wukong", "Susano", "Sylvanus", "Terra", "Thanatos", "The Morrigan", "Thor", "Thoth", "Tyr", "Ullr", "Vamana", "Vulcan", "Xbalanque", "Xing Tian", "Ymir", "Zeus", "Zhong Kui" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.God.Location = New System.Drawing.Point(144, 667)
        Me.God.Name = "God"
        Me.God.Size = New System.Drawing.Size(100, 21)
        Me.God.TabIndex = 13
        '
        'Deads
        '
        Me.Deads.Location = New System.Drawing.Point(317, 668)
        Me.Deads.Name = "Deads"
        Me.Deads.Size = New System.Drawing.Size(65, 20)
        Me.Deads.TabIndex = 14
        '
        'Kills
        '
        Me.Kills.Location = New System.Drawing.Point(250, 668)
        Me.Kills.Name = "Kills"
        Me.Kills.Size = New System.Drawing.Size(65, 20)
        Me.Kills.TabIndex = 15
        '
        'Assists
        '
        Me.Assists.Location = New System.Drawing.Point(384, 668)
        Me.Assists.Name = "Assists"
        Me.Assists.Size = New System.Drawing.Size(65, 20)
        Me.Assists.TabIndex = 16
        '
        'Que
        '
        Me.Que.AllowDrop = True
        Me.Que.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmiteJoustBindingSource, "Tier", True))
        Me.Que.FormattingEnabled = True
        Me.Que.Items.AddRange(New Object() {"Solo", "Party"})
        Me.Que.Location = New System.Drawing.Point(455, 668)
        Me.Que.Name = "Que"
        Me.Que.Size = New System.Drawing.Size(100, 21)
        Me.Que.TabIndex = 17
        '
        'Comment
        '
        Me.Comment.Location = New System.Drawing.Point(561, 619)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(405, 70)
        Me.Comment.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Match Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 601)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tier:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Result:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 601)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Elo Balance:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 601)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Total Elo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 648)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Role:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 648)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "God:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(265, 648)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Kills:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 648)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Deaths:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(391, 648)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Assists:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(473, 648)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Que Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(733, 601)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Comment:"
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
        'MatchNumberDataGridViewTextBoxColumn
        '
        Me.MatchNumberDataGridViewTextBoxColumn.DataPropertyName = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.HeaderText = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.Name = "MatchNumberDataGridViewTextBoxColumn"
        Me.MatchNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TierDataGridViewTextBoxColumn
        '
        Me.TierDataGridViewTextBoxColumn.DataPropertyName = "Tier"
        Me.TierDataGridViewTextBoxColumn.HeaderText = "Tier"
        Me.TierDataGridViewTextBoxColumn.Name = "TierDataGridViewTextBoxColumn"
        Me.TierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResultDataGridViewTextBoxColumn
        '
        Me.ResultDataGridViewTextBoxColumn.DataPropertyName = "Result"
        Me.ResultDataGridViewTextBoxColumn.HeaderText = "Result"
        Me.ResultDataGridViewTextBoxColumn.Name = "ResultDataGridViewTextBoxColumn"
        Me.ResultDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EloBalanceDataGridViewTextBoxColumn
        '
        Me.EloBalanceDataGridViewTextBoxColumn.DataPropertyName = "Elo Balance"
        Me.EloBalanceDataGridViewTextBoxColumn.HeaderText = "Elo Balance"
        Me.EloBalanceDataGridViewTextBoxColumn.Name = "EloBalanceDataGridViewTextBoxColumn"
        Me.EloBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalEloDataGridViewTextBoxColumn
        '
        Me.TotalEloDataGridViewTextBoxColumn.DataPropertyName = "Total Elo"
        Me.TotalEloDataGridViewTextBoxColumn.HeaderText = "Total Elo"
        Me.TotalEloDataGridViewTextBoxColumn.Name = "TotalEloDataGridViewTextBoxColumn"
        Me.TotalEloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GodDataGridViewTextBoxColumn
        '
        Me.GodDataGridViewTextBoxColumn.DataPropertyName = "God"
        Me.GodDataGridViewTextBoxColumn.HeaderText = "God"
        Me.GodDataGridViewTextBoxColumn.Name = "GodDataGridViewTextBoxColumn"
        Me.GodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KDADataGridViewTextBoxColumn
        '
        Me.KDADataGridViewTextBoxColumn.DataPropertyName = "KDA"
        Me.KDADataGridViewTextBoxColumn.HeaderText = "KDA"
        Me.KDADataGridViewTextBoxColumn.Name = "KDADataGridViewTextBoxColumn"
        Me.KDADataGridViewTextBoxColumn.ReadOnly = True
        '
        'QueTypeDataGridViewTextBoxColumn
        '
        Me.QueTypeDataGridViewTextBoxColumn.DataPropertyName = "Que Type"
        Me.QueTypeDataGridViewTextBoxColumn.HeaderText = "Que Type"
        Me.QueTypeDataGridViewTextBoxColumn.Name = "QueTypeDataGridViewTextBoxColumn"
        Me.QueTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SmiteJoustTableAdapter
        '
        Me.SmiteJoustTableAdapter.ClearBeforeFill = True
        '
        'RankedJoust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 717)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.Que)
        Me.Controls.Add(Me.Assists)
        Me.Controls.Add(Me.Kills)
        Me.Controls.Add(Me.Deads)
        Me.Controls.Add(Me.God)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Tier)
        Me.Controls.Add(Me.MatchID)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.EloBalance)
        Me.Controls.Add(Me.TotalElo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RankedJoust"
        Me.Text = "RankedJoust"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteJoustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteJoustDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TotalElo As TextBox
    Friend WithEvents EloBalance As TextBox
    Friend WithEvents Add As Button
    Friend WithEvents Modify As Button
    Friend WithEvents MatchID As TextBox
    Friend WithEvents SmiteJoustDataSet As SmiteJoustDataSet
    Friend WithEvents SmiteJoustBindingSource As BindingSource
    Friend WithEvents SmiteJoustTableAdapter As SmiteJoustDataSetTableAdapters.SmiteJoustTableAdapter
    Friend WithEvents MatchNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EloBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tier As ComboBox
    Friend WithEvents Result As ComboBox
    Friend WithEvents Role As ComboBox
    Friend WithEvents God As ComboBox
    Friend WithEvents Deads As TextBox
    Friend WithEvents Kills As TextBox
    Friend WithEvents Assists As TextBox
    Friend WithEvents Que As ComboBox
    Friend WithEvents Comment As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
