<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDuelMatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDuelMatch))
        Me.Back = New System.Windows.Forms.Button()
        Me.God1 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmiteDataSet = New CompetitiveStatTracker.SmiteDataSet()
        Me.God2 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Ban4 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Ban3 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ban2 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ban1 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Ban8 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource10 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Ban7 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ban6 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ban5 = New System.Windows.Forms.ComboBox()
        Me.GodsBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GodsTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.GodsTableAdapter()
        Me.AddPaB = New System.Windows.Forms.Button()
        Me.DuelBansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DuelBansTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.DuelBansTableAdapter()
        Me.DuelPicksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DuelPicksTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.DuelPicksTableAdapter()
        Me.DuelMatchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DuelMatchesTableAdapter = New CompetitiveStatTracker.SmiteDataSetTableAdapters.DuelMatchesTableAdapter()
        CType(Me.GodsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodsBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuelBansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuelPicksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuelMatchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(12, 12)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 50)
        Me.Back.TabIndex = 33
        Me.Back.Text = "<="
        Me.Back.UseVisualStyleBackColor = True
        '
        'God1
        '
        Me.God1.AllowDrop = True
        Me.God1.DataSource = Me.GodsBindingSource1
        Me.God1.DisplayMember = "Name"
        Me.God1.FormattingEnabled = True
        Me.God1.Location = New System.Drawing.Point(109, 348)
        Me.God1.Name = "God1"
        Me.God1.Size = New System.Drawing.Size(85, 21)
        Me.God1.TabIndex = 34
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
        'God2
        '
        Me.God2.AllowDrop = True
        Me.God2.DataSource = Me.GodsBindingSource2
        Me.God2.DisplayMember = "Name"
        Me.God2.FormattingEnabled = True
        Me.God2.Location = New System.Drawing.Point(110, 674)
        Me.God2.Name = "God2"
        Me.God2.Size = New System.Drawing.Size(85, 21)
        Me.God2.TabIndex = 36
        Me.God2.ValueMember = "IdGod"
        '
        'GodsBindingSource2
        '
        Me.GodsBindingSource2.DataMember = "Gods"
        Me.GodsBindingSource2.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource2.Sort = "Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(52, 395)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(52, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(650, 152)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 60
        Me.PictureBox6.TabStop = False
        '
        'Ban4
        '
        Me.Ban4.AllowDrop = True
        Me.Ban4.DataSource = Me.GodsBindingSource6
        Me.Ban4.DisplayMember = "Name"
        Me.Ban4.FormattingEnabled = True
        Me.Ban4.Location = New System.Drawing.Point(645, 239)
        Me.Ban4.Name = "Ban4"
        Me.Ban4.Size = New System.Drawing.Size(85, 21)
        Me.Ban4.TabIndex = 59
        Me.Ban4.ValueMember = "IdGod"
        '
        'GodsBindingSource6
        '
        Me.GodsBindingSource6.DataMember = "Gods"
        Me.GodsBindingSource6.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource6.Sort = "Name"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(342, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(444, 152)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 57
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(547, 152)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 58
        Me.PictureBox5.TabStop = False
        '
        'Ban3
        '
        Me.Ban3.AllowDrop = True
        Me.Ban3.DataSource = Me.GodsBindingSource5
        Me.Ban3.DisplayMember = "Name"
        Me.Ban3.FormattingEnabled = True
        Me.Ban3.Location = New System.Drawing.Point(542, 239)
        Me.Ban3.Name = "Ban3"
        Me.Ban3.Size = New System.Drawing.Size(85, 21)
        Me.Ban3.TabIndex = 53
        Me.Ban3.ValueMember = "IdGod"
        '
        'GodsBindingSource5
        '
        Me.GodsBindingSource5.DataMember = "Gods"
        Me.GodsBindingSource5.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource5.Sort = "Name"
        '
        'Ban2
        '
        Me.Ban2.AllowDrop = True
        Me.Ban2.DataSource = Me.GodsBindingSource4
        Me.Ban2.DisplayMember = "Name"
        Me.Ban2.FormattingEnabled = True
        Me.Ban2.Location = New System.Drawing.Point(439, 239)
        Me.Ban2.Name = "Ban2"
        Me.Ban2.Size = New System.Drawing.Size(85, 21)
        Me.Ban2.TabIndex = 54
        Me.Ban2.ValueMember = "IdGod"
        '
        'GodsBindingSource4
        '
        Me.GodsBindingSource4.DataMember = "Gods"
        Me.GodsBindingSource4.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource4.Sort = "Name"
        '
        'Ban1
        '
        Me.Ban1.AllowDrop = True
        Me.Ban1.DataSource = Me.GodsBindingSource3
        Me.Ban1.DisplayMember = "Name"
        Me.Ban1.FormattingEnabled = True
        Me.Ban1.Location = New System.Drawing.Point(337, 239)
        Me.Ban1.Name = "Ban1"
        Me.Ban1.Size = New System.Drawing.Size(85, 21)
        Me.Ban1.TabIndex = 55
        Me.Ban1.ValueMember = "IdGod"
        '
        'GodsBindingSource3
        '
        Me.GodsBindingSource3.DataMember = "Gods"
        Me.GodsBindingSource3.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource3.Sort = "Name"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox10.Location = New System.Drawing.Point(650, 501)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 65
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox9.Location = New System.Drawing.Point(547, 501)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 66
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(342, 501)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 67
        Me.PictureBox7.TabStop = False
        '
        'Ban8
        '
        Me.Ban8.AllowDrop = True
        Me.Ban8.DataSource = Me.GodsBindingSource10
        Me.Ban8.DisplayMember = "Name"
        Me.Ban8.FormattingEnabled = True
        Me.Ban8.Location = New System.Drawing.Point(645, 588)
        Me.Ban8.Name = "Ban8"
        Me.Ban8.Size = New System.Drawing.Size(85, 21)
        Me.Ban8.TabIndex = 61
        Me.Ban8.ValueMember = "IdGod"
        '
        'GodsBindingSource10
        '
        Me.GodsBindingSource10.DataMember = "Gods"
        Me.GodsBindingSource10.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource10.Sort = "Name"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(444, 501)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 68
        Me.PictureBox8.TabStop = False
        '
        'Ban7
        '
        Me.Ban7.AllowDrop = True
        Me.Ban7.DataSource = Me.GodsBindingSource9
        Me.Ban7.DisplayMember = "Name"
        Me.Ban7.FormattingEnabled = True
        Me.Ban7.Location = New System.Drawing.Point(542, 588)
        Me.Ban7.Name = "Ban7"
        Me.Ban7.Size = New System.Drawing.Size(85, 21)
        Me.Ban7.TabIndex = 63
        Me.Ban7.ValueMember = "IdGod"
        '
        'GodsBindingSource9
        '
        Me.GodsBindingSource9.DataMember = "Gods"
        Me.GodsBindingSource9.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource9.Sort = "Name"
        '
        'Ban6
        '
        Me.Ban6.AllowDrop = True
        Me.Ban6.DataSource = Me.GodsBindingSource8
        Me.Ban6.DisplayMember = "Name"
        Me.Ban6.FormattingEnabled = True
        Me.Ban6.Location = New System.Drawing.Point(439, 588)
        Me.Ban6.Name = "Ban6"
        Me.Ban6.Size = New System.Drawing.Size(85, 21)
        Me.Ban6.TabIndex = 62
        Me.Ban6.ValueMember = "IdGod"
        '
        'GodsBindingSource8
        '
        Me.GodsBindingSource8.DataMember = "Gods"
        Me.GodsBindingSource8.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource8.Sort = "Name"
        '
        'Ban5
        '
        Me.Ban5.AllowDrop = True
        Me.Ban5.DataSource = Me.GodsBindingSource7
        Me.Ban5.DisplayMember = "Name"
        Me.Ban5.FormattingEnabled = True
        Me.Ban5.Location = New System.Drawing.Point(337, 588)
        Me.Ban5.Name = "Ban5"
        Me.Ban5.Size = New System.Drawing.Size(85, 21)
        Me.Ban5.TabIndex = 64
        Me.Ban5.ValueMember = "IdGod"
        '
        'GodsBindingSource7
        '
        Me.GodsBindingSource7.DataMember = "Gods"
        Me.GodsBindingSource7.DataSource = Me.SmiteDataSet
        Me.GodsBindingSource7.Sort = "Name"
        '
        'GodsTableAdapter
        '
        Me.GodsTableAdapter.ClearBeforeFill = True
        '
        'AddPaB
        '
        Me.AddPaB.Location = New System.Drawing.Point(1244, 12)
        Me.AddPaB.Name = "AddPaB"
        Me.AddPaB.Size = New System.Drawing.Size(100, 50)
        Me.AddPaB.TabIndex = 69
        Me.AddPaB.Text = "Add"
        Me.AddPaB.UseVisualStyleBackColor = True
        '
        'DuelBansBindingSource
        '
        Me.DuelBansBindingSource.DataMember = "DuelBans"
        Me.DuelBansBindingSource.DataSource = Me.SmiteDataSet
        '
        'DuelBansTableAdapter
        '
        Me.DuelBansTableAdapter.ClearBeforeFill = True
        '
        'DuelPicksBindingSource
        '
        Me.DuelPicksBindingSource.DataMember = "DuelPicks"
        Me.DuelPicksBindingSource.DataSource = Me.SmiteDataSet
        '
        'DuelPicksTableAdapter
        '
        Me.DuelPicksTableAdapter.ClearBeforeFill = True
        '
        'DuelMatchesBindingSource
        '
        Me.DuelMatchesBindingSource.DataMember = "DuelMatches"
        Me.DuelMatchesBindingSource.DataSource = Me.SmiteDataSet
        '
        'DuelMatchesTableAdapter
        '
        Me.DuelMatchesTableAdapter.ClearBeforeFill = True
        '
        'AddDuelMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 764)
        Me.Controls.Add(Me.AddPaB)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Ban8)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Ban7)
        Me.Controls.Add(Me.Ban6)
        Me.Controls.Add(Me.Ban5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Ban4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Ban3)
        Me.Controls.Add(Me.Ban2)
        Me.Controls.Add(Me.Ban1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.God2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.God1)
        Me.Controls.Add(Me.Back)
        Me.Name = "AddDuelMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddDuelMatch"
        CType(Me.GodsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodsBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuelBansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuelPicksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuelMatchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents God1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents God2 As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Ban4 As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Ban3 As ComboBox
    Friend WithEvents Ban2 As ComboBox
    Friend WithEvents Ban1 As ComboBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Ban8 As ComboBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Ban7 As ComboBox
    Friend WithEvents Ban6 As ComboBox
    Friend WithEvents Ban5 As ComboBox
    Friend WithEvents SmiteDataSet As SmiteDataSet
    Friend WithEvents GodsBindingSource1 As BindingSource
    Friend WithEvents GodsTableAdapter As SmiteDataSetTableAdapters.GodsTableAdapter
    Friend WithEvents GodsBindingSource2 As BindingSource
    Friend WithEvents GodsBindingSource6 As BindingSource
    Friend WithEvents GodsBindingSource5 As BindingSource
    Friend WithEvents GodsBindingSource4 As BindingSource
    Friend WithEvents GodsBindingSource3 As BindingSource
    Friend WithEvents GodsBindingSource10 As BindingSource
    Friend WithEvents GodsBindingSource9 As BindingSource
    Friend WithEvents GodsBindingSource8 As BindingSource
    Friend WithEvents GodsBindingSource7 As BindingSource
    Friend WithEvents AddPaB As Button
    Friend WithEvents DuelBansBindingSource As BindingSource
    Friend WithEvents DuelBansTableAdapter As SmiteDataSetTableAdapters.DuelBansTableAdapter
    Friend WithEvents DuelPicksBindingSource As BindingSource
    Friend WithEvents DuelPicksTableAdapter As SmiteDataSetTableAdapters.DuelPicksTableAdapter
    Friend WithEvents DuelMatchesBindingSource As BindingSource
    Friend WithEvents DuelMatchesTableAdapter As SmiteDataSetTableAdapters.DuelMatchesTableAdapter
End Class
