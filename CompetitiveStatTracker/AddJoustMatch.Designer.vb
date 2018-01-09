<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddJoustMatch
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
        Me.God1 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.GodsTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.GodsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GodsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.God2 = New System.Windows.Forms.ComboBox()
        Me.God3 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.God4 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.God5 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.God6 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BansBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BansBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BansBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BansBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BansBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BansBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ban1 = New System.Windows.Forms.ComboBox()
        Me.Ban2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Ban3 = New System.Windows.Forms.ComboBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Ban4 = New System.Windows.Forms.ComboBox()
        Me.Ban5 = New System.Windows.Forms.ComboBox()
        Me.Ban6 = New System.Windows.Forms.ComboBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.AddPaB = New System.Windows.Forms.Button()
        Me.JoustBansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoustBansTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.JoustBansTableAdapter()
        Me.JoustPicksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoustPicksTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.JoustPicksTableAdapter()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.JoustMatchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoustMatchesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.JoustMatchesTableAdapter()
        CType(Me.GodsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BansBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoustBansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoustPicksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoustMatchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'God1
        '
        Me.God1.AllowDrop = True
        Me.God1.DataSource = Me.GodsBindingSource1
        Me.God1.DisplayMember = "Name"
        Me.God1.FormattingEnabled = True
        Me.God1.Location = New System.Drawing.Point(160, 368)
        Me.God1.Name = "God1"
        Me.God1.Size = New System.Drawing.Size(85, 21)
        Me.God1.TabIndex = 21
        Me.God1.ValueMember = "IdGod"
        '
        'GodsBindingSource1
        '
        Me.GodsBindingSource1.DataMember = "Gods"
        Me.GodsBindingSource1.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource1.Sort = "Name"
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
        Me.PictureBox1.Location = New System.Drawing.Point(103, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(341, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'GodsBindingSource2
        '
        Me.GodsBindingSource2.DataMember = "Gods"
        Me.GodsBindingSource2.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource2.Sort = "Name"
        '
        'God2
        '
        Me.God2.AllowDrop = True
        Me.God2.DataSource = Me.GodsBindingSource2
        Me.God2.DisplayMember = "Name"
        Me.God2.FormattingEnabled = True
        Me.God2.Location = New System.Drawing.Point(399, 368)
        Me.God2.Name = "God2"
        Me.God2.Size = New System.Drawing.Size(85, 21)
        Me.God2.TabIndex = 21
        Me.God2.ValueMember = "IdGod"
        '
        'God3
        '
        Me.God3.AllowDrop = True
        Me.God3.DataSource = Me.GodsBindingSource3
        Me.God3.DisplayMember = "Name"
        Me.God3.FormattingEnabled = True
        Me.God3.Location = New System.Drawing.Point(638, 368)
        Me.God3.Name = "God3"
        Me.God3.Size = New System.Drawing.Size(85, 21)
        Me.God3.TabIndex = 21
        Me.God3.ValueMember = "IdGod"
        '
        'GodsBindingSource3
        '
        Me.GodsBindingSource3.DataMember = "Gods"
        Me.GodsBindingSource3.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource3.Sort = "Name"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(580, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'God4
        '
        Me.God4.AllowDrop = True
        Me.God4.DataSource = Me.GodsBindingSource4
        Me.God4.DisplayMember = "Name"
        Me.God4.FormattingEnabled = True
        Me.God4.Location = New System.Drawing.Point(638, 718)
        Me.God4.Name = "God4"
        Me.God4.Size = New System.Drawing.Size(85, 21)
        Me.God4.TabIndex = 21
        Me.God4.ValueMember = "IdGod"
        '
        'GodsBindingSource4
        '
        Me.GodsBindingSource4.DataMember = "Gods"
        Me.GodsBindingSource4.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource4.Sort = "Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(581, 439)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'God5
        '
        Me.God5.AllowDrop = True
        Me.God5.DataSource = Me.GodsBindingSource5
        Me.God5.DisplayMember = "Name"
        Me.God5.FormattingEnabled = True
        Me.God5.Location = New System.Drawing.Point(877, 718)
        Me.God5.Name = "God5"
        Me.God5.Size = New System.Drawing.Size(85, 21)
        Me.God5.TabIndex = 21
        Me.God5.ValueMember = "IdGod"
        '
        'GodsBindingSource5
        '
        Me.GodsBindingSource5.DataMember = "Gods"
        Me.GodsBindingSource5.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource5.Sort = "Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(819, 439)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'God6
        '
        Me.God6.AllowDrop = True
        Me.God6.DataSource = Me.GodsBindingSource6
        Me.God6.DisplayMember = "Name"
        Me.God6.FormattingEnabled = True
        Me.God6.Location = New System.Drawing.Point(1116, 718)
        Me.God6.Name = "God6"
        Me.God6.Size = New System.Drawing.Size(85, 21)
        Me.God6.TabIndex = 21
        Me.God6.ValueMember = "IdGod"
        '
        'GodsBindingSource6
        '
        Me.GodsBindingSource6.DataMember = "Gods"
        Me.GodsBindingSource6.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource6.Sort = "Name"
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(911, 139)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'BansBindingSource1
        '
        Me.BansBindingSource1.DataMember = "Gods"
        Me.BansBindingSource1.DataSource = Me.SmiteDataSet
        Me.BansBindingSource1.Sort = "Name"
        '
        'BansBindingSource2
        '
        Me.BansBindingSource2.DataMember = "Gods"
        Me.BansBindingSource2.DataSource = Me.SmiteDataSet
        Me.BansBindingSource2.Sort = "Name"
        '
        'BansBindingSource3
        '
        Me.BansBindingSource3.DataMember = "Gods"
        Me.BansBindingSource3.DataSource = Me.SmiteDataSet
        Me.BansBindingSource3.Sort = "Name"
        '
        'BansBindingSource4
        '
        Me.BansBindingSource4.DataMember = "Gods"
        Me.BansBindingSource4.DataSource = Me.SmiteDataSet
        Me.BansBindingSource4.Sort = "Name"
        '
        'BansBindingSource5
        '
        Me.BansBindingSource5.DataMember = "Gods"
        Me.BansBindingSource5.DataSource = Me.SmiteDataSet
        Me.BansBindingSource5.Sort = "Name"
        '
        'BansBindingSource6
        '
        Me.BansBindingSource6.DataMember = "Gods"
        Me.BansBindingSource6.DataSource = Me.SmiteDataSet
        Me.BansBindingSource6.Sort = "Name"
        '
        'Ban1
        '
        Me.Ban1.AllowDrop = True
        Me.Ban1.DataSource = Me.BansBindingSource1
        Me.Ban1.DisplayMember = "Name"
        Me.Ban1.FormattingEnabled = True
        Me.Ban1.Location = New System.Drawing.Point(919, 252)
        Me.Ban1.Name = "Ban1"
        Me.Ban1.Size = New System.Drawing.Size(85, 21)
        Me.Ban1.TabIndex = 21
        Me.Ban1.ValueMember = "IdGod"
        '
        'Ban2
        '
        Me.Ban2.AllowDrop = True
        Me.Ban2.DataSource = Me.BansBindingSource2
        Me.Ban2.DisplayMember = "Name"
        Me.Ban2.FormattingEnabled = True
        Me.Ban2.Location = New System.Drawing.Point(1042, 252)
        Me.Ban2.Name = "Ban2"
        Me.Ban2.Size = New System.Drawing.Size(85, 21)
        Me.Ban2.TabIndex = 21
        Me.Ban2.ValueMember = "IdGod"
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(1034, 139)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 22
        Me.PictureBox8.TabStop = False
        '
        'Ban3
        '
        Me.Ban3.AllowDrop = True
        Me.Ban3.DataSource = Me.BansBindingSource3
        Me.Ban3.DisplayMember = "Name"
        Me.Ban3.FormattingEnabled = True
        Me.Ban3.Location = New System.Drawing.Point(1165, 252)
        Me.Ban3.Name = "Ban3"
        Me.Ban3.Size = New System.Drawing.Size(85, 21)
        Me.Ban3.TabIndex = 21
        Me.Ban3.ValueMember = "IdGod"
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(1157, 139)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 22
        Me.PictureBox9.TabStop = False
        '
        'Ban4
        '
        Me.Ban4.AllowDrop = True
        Me.Ban4.DataSource = Me.BansBindingSource4
        Me.Ban4.DisplayMember = "Name"
        Me.Ban4.FormattingEnabled = True
        Me.Ban4.Location = New System.Drawing.Point(111, 668)
        Me.Ban4.Name = "Ban4"
        Me.Ban4.Size = New System.Drawing.Size(85, 21)
        Me.Ban4.TabIndex = 21
        Me.Ban4.ValueMember = "IdGod"
        '
        'Ban5
        '
        Me.Ban5.AllowDrop = True
        Me.Ban5.DataSource = Me.BansBindingSource5
        Me.Ban5.DisplayMember = "Name"
        Me.Ban5.FormattingEnabled = True
        Me.Ban5.Location = New System.Drawing.Point(234, 668)
        Me.Ban5.Name = "Ban5"
        Me.Ban5.Size = New System.Drawing.Size(85, 21)
        Me.Ban5.TabIndex = 21
        Me.Ban5.ValueMember = "IdGod"
        '
        'Ban6
        '
        Me.Ban6.AllowDrop = True
        Me.Ban6.DataSource = Me.BansBindingSource6
        Me.Ban6.DisplayMember = "Name"
        Me.Ban6.FormattingEnabled = True
        Me.Ban6.Location = New System.Drawing.Point(357, 668)
        Me.Ban6.Name = "Ban6"
        Me.Ban6.Size = New System.Drawing.Size(85, 21)
        Me.Ban6.TabIndex = 21
        Me.Ban6.ValueMember = "IdGod"
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(103, 555)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 22
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(226, 555)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 22
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(349, 555)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 22
        Me.PictureBox12.TabStop = False
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(25, 25)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 50)
        Me.Back.TabIndex = 32
        Me.Back.Text = "<="
        Me.Back.UseVisualStyleBackColor = True
        '
        'AddPaB
        '
        Me.AddPaB.Location = New System.Drawing.Point(1235, 25)
        Me.AddPaB.Name = "AddPaB"
        Me.AddPaB.Size = New System.Drawing.Size(100, 50)
        Me.AddPaB.TabIndex = 33
        Me.AddPaB.Text = "Add"
        Me.AddPaB.UseVisualStyleBackColor = True
        '
        'JoustBansBindingSource
        '
        Me.JoustBansBindingSource.DataMember = "JoustBans"
        Me.JoustBansBindingSource.DataSource = Me.SmiteDataSet
        '
        'JoustBansTableAdapter
        '
        Me.JoustBansTableAdapter.ClearBeforeFill = True
        '
        'JoustPicksBindingSource
        '
        Me.JoustPicksBindingSource.DataMember = "JoustPicks"
        Me.JoustPicksBindingSource.DataSource = Me.SmiteDataSet
        '
        'JoustPicksTableAdapter
        '
        Me.JoustPicksTableAdapter.ClearBeforeFill = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(1058, 439)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
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
        'AddJoustMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CompetitiveStatTracker.My.Resources.Graphics.JoustPB
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1356, 764)
        Me.Controls.Add(Me.AddPaB)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.God6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.God5)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Ban6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Ban3)
        Me.Controls.Add(Me.Ban5)
        Me.Controls.Add(Me.God4)
        Me.Controls.Add(Me.Ban2)
        Me.Controls.Add(Me.Ban4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Ban1)
        Me.Controls.Add(Me.God3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.God2)
        Me.Controls.Add(Me.God1)
        Me.Name = "AddJoustMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddJoustMatch"
        CType(Me.GodsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BansBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoustBansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoustPicksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoustMatchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents God1 As ComboBox
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents GodsBindingSource1 As BindingSource
    Friend WithEvents GodsTableAdapter As SmiteDataSetTableAdapters.GodsTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GodsBindingSource2 As BindingSource
    Friend WithEvents God2 As ComboBox
    Friend WithEvents God3 As ComboBox
    Friend WithEvents GodsBindingSource3 As BindingSource
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents God4 As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents God5 As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents God6 As ComboBox
    Friend WithEvents GodsBindingSource4 As BindingSource
    Friend WithEvents GodsBindingSource5 As BindingSource
    Friend WithEvents GodsBindingSource6 As BindingSource
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BansBindingSource1 As BindingSource
    Friend WithEvents BansBindingSource2 As BindingSource
    Friend WithEvents BansBindingSource3 As BindingSource
    Friend WithEvents BansBindingSource4 As BindingSource
    Friend WithEvents BansBindingSource5 As BindingSource
    Friend WithEvents BansBindingSource6 As BindingSource
    Friend WithEvents Ban1 As ComboBox
    Friend WithEvents Ban2 As ComboBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Ban3 As ComboBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Ban4 As ComboBox
    Friend WithEvents Ban5 As ComboBox
    Friend WithEvents Ban6 As ComboBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents AddPaB As Button
    Friend WithEvents JoustBansBindingSource As BindingSource
    Friend WithEvents JoustBansTableAdapter As SmiteDataSetTableAdapters.JoustBansTableAdapter
    Friend WithEvents JoustPicksBindingSource As BindingSource
    Friend WithEvents JoustPicksTableAdapter As SmiteDataSetTableAdapters.JoustPicksTableAdapter
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents JoustMatchesBindingSource As BindingSource
    Friend WithEvents JoustMatchesTableAdapter As SmiteDataSetTableAdapters.JoustMatchesTableAdapter
End Class
