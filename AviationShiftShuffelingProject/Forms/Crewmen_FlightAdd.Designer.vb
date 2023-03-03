<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crewmen_FlightAdd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.Icoonbtnupdate = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsave = New FontAwesome.Sharp.IconButton()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSelectedID = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsave1 = New FontAwesome.Sharp.IconButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbarlinecategory = New System.Windows.Forms.ComboBox()
        Me.tbflightNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.SplitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 94)
        Me.Panel1.TabIndex = 19
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Size = New System.Drawing.Size(1370, 94)
        Me.SplitContainer2.SplitterDistance = 668
        Me.SplitContainer2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(212, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ADD CREWMAN DETAILS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(259, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADD FLIGHT DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSelectedID)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(8)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.SplitContainer1.Size = New System.Drawing.Size(1370, 467)
        Me.SplitContainer1.SplitterDistance = 671
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelete)
        Me.Panel5.Controls.Add(Me.Icoonbtnupdate)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(551, 182)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(112, 277)
        Me.Panel5.TabIndex = 49
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDelete.IconSize = 18
        Me.btnDelete.Location = New System.Drawing.Point(5, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDelete.Size = New System.Drawing.Size(105, 40)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Icoonbtnupdate
        '
        Me.Icoonbtnupdate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Icoonbtnupdate.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Icoonbtnupdate.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Icoonbtnupdate.IconColor = System.Drawing.Color.Black
        Me.Icoonbtnupdate.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.Icoonbtnupdate.IconSize = 18
        Me.Icoonbtnupdate.Location = New System.Drawing.Point(4, 22)
        Me.Icoonbtnupdate.Name = "Icoonbtnupdate"
        Me.Icoonbtnupdate.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Icoonbtnupdate.Size = New System.Drawing.Size(105, 40)
        Me.Icoonbtnupdate.TabIndex = 46
        Me.Icoonbtnupdate.Text = "UPDATE"
        Me.Icoonbtnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Icoonbtnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Icoonbtnupdate.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(8, 182)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(541, 277)
        Me.Panel4.TabIndex = 48
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AID, Me.AName, Me.AGroup, Me.APosition})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(541, 277)
        Me.DataGridView1.TabIndex = 45
        '
        'AID
        '
        Me.AID.HeaderText = "ID"
        Me.AID.Name = "AID"
        Me.AID.ReadOnly = True
        '
        'AName
        '
        Me.AName.HeaderText = "Name"
        Me.AName.Name = "AName"
        Me.AName.ReadOnly = True
        Me.AName.Width = 150
        '
        'AGroup
        '
        Me.AGroup.HeaderText = "Group"
        Me.AGroup.Name = "AGroup"
        Me.AGroup.ReadOnly = True
        '
        'APosition
        '
        Me.APosition.HeaderText = "Position"
        Me.APosition.Name = "APosition"
        Me.APosition.ReadOnly = True
        Me.APosition.Width = 155
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.cbPosition)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cbGroup)
        Me.Panel3.Controls.Add(Me.tbName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(8, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(655, 174)
        Me.Panel3.TabIndex = 47
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnsave.IconColor = System.Drawing.Color.Black
        Me.btnsave.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnsave.IconSize = 18
        Me.btnsave.Location = New System.Drawing.Point(83, 117)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnsave.Size = New System.Drawing.Size(133, 40)
        Me.btnsave.TabIndex = 52
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'cbPosition
        '
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Location = New System.Drawing.Point(83, 74)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(213, 23)
        Me.cbPosition.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Group"
        '
        'cbGroup
        '
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(83, 38)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(213, 23)
        Me.cbGroup.TabIndex = 49
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(83, 1)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(213, 23)
        Me.tbName.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Name"
        '
        'lblSelectedID
        '
        Me.lblSelectedID.AutoSize = True
        Me.lblSelectedID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSelectedID.Location = New System.Drawing.Point(612, 262)
        Me.lblSelectedID.Name = "lblSelectedID"
        Me.lblSelectedID.Size = New System.Drawing.Size(0, 15)
        Me.lblSelectedID.TabIndex = 46
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.IconButton4)
        Me.Panel8.Controls.Add(Me.IconButton2)
        Me.Panel8.Controls.Add(Me.IconButton3)
        Me.Panel8.Controls.Add(Me.IconButton1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(509, 244)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(180, 215)
        Me.Panel8.TabIndex = 56
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.IconButton4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton4.IconSize = 18
        Me.IconButton4.Location = New System.Drawing.Point(32, 147)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton4.Size = New System.Drawing.Size(133, 40)
        Me.IconButton4.TabIndex = 58
        Me.IconButton4.Text = "DELETE"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.IconButton2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Plane
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton2.IconSize = 18
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(32, 9)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(133, 40)
        Me.IconButton2.TabIndex = 56
        Me.IconButton2.Text = "FLIGHT TIME"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.IconButton3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton3.IconSize = 18
        Me.IconButton3.Location = New System.Drawing.Point(32, 101)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton3.Size = New System.Drawing.Size(133, 40)
        Me.IconButton3.TabIndex = 57
        Me.IconButton3.Text = "UPDATE"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.IconButton1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 18
        Me.IconButton1.Location = New System.Drawing.Point(32, 55)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(133, 40)
        Me.IconButton1.TabIndex = 55
        Me.IconButton1.Text = "ADD FLIGHT"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridView2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(8, 244)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(495, 215)
        Me.Panel7.TabIndex = 55
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DateTimePicker1)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.TextBox5)
        Me.Panel6.Controls.Add(Me.TextBox4)
        Me.Panel6.Controls.Add(Me.TextBox3)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.btnsave1)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.cbarlinecategory)
        Me.Panel6.Controls.Add(Me.tbflightNo)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(8, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(681, 236)
        Me.Panel6.TabIndex = 47
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(136, 114)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 23)
        Me.TextBox5.TabIndex = 54
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(280, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(66, 23)
        Me.TextBox4.TabIndex = 53
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(208, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(66, 23)
        Me.TextBox3.TabIndex = 52
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 23)
        Me.TextBox1.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Departure Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "STD"
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnsave1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsave1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnsave1.IconColor = System.Drawing.Color.Black
        Me.btnsave1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnsave1.IconSize = 18
        Me.btnsave1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave1.Location = New System.Drawing.Point(136, 183)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnsave1.Size = New System.Drawing.Size(133, 40)
        Me.btnsave1.TabIndex = 48
        Me.btnsave1.Text = "SAVE"
        Me.btnsave1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(232, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 23)
        Me.TextBox2.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Airline Category"
        '
        'cbarlinecategory
        '
        Me.cbarlinecategory.FormattingEnabled = True
        Me.cbarlinecategory.Location = New System.Drawing.Point(136, 46)
        Me.cbarlinecategory.Name = "cbarlinecategory"
        Me.cbarlinecategory.Size = New System.Drawing.Size(90, 23)
        Me.cbarlinecategory.TabIndex = 46
        '
        'tbflightNo
        '
        Me.tbflightNo.Location = New System.Drawing.Point(136, 8)
        Me.tbflightNo.Name = "tbflightNo"
        Me.tbflightNo.Size = New System.Drawing.Size(170, 23)
        Me.tbflightNo.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Flight No"
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 467)
        Me.Panel2.TabIndex = 20
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(495, 215)
        Me.DataGridView2.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 150)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 23)
        Me.DateTimePicker1.TabIndex = 56
        '
        'Crewmen_FlightAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Crewmen_FlightAdd"
        Me.Text = "FlightAdd"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lblSelectedID As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnsave As FontAwesome.Sharp.IconButton
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents Icoonbtnupdate As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AID As DataGridViewTextBoxColumn
    Friend WithEvents AName As DataGridViewTextBoxColumn
    Friend WithEvents AGroup As DataGridViewTextBoxColumn
    Friend WithEvents APosition As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsave1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbarlinecategory As ComboBox
    Friend WithEvents tbflightNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
End Class
