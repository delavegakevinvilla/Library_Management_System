<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(books))
        Me.data = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtap = New System.Windows.Forms.TextBox()
        Me.txttp = New System.Windows.Forms.TextBox()
        Me.txtbd = New System.Windows.Forms.TextBox()
        Me.txtyp = New System.Windows.Forms.TextBox()
        Me.txtcn = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdfirst = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdnext = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdprev = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdlast = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.navadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.idpic = New System.Windows.Forms.PictureBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtcr = New System.Windows.Forms.TextBox()
        Me.txtgenre = New System.Windows.Forms.ComboBox()
        Me.txtgen = New System.Windows.Forms.TextBox()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.AllowUserToDeleteRows = False
        Me.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Location = New System.Drawing.Point(175, 398)
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.RowTemplate.Height = 24
        Me.data.Size = New System.Drawing.Size(1173, 278)
        Me.data.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Author:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(534, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Book description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(520, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Call Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(511, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "year publication:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "CopyRight:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(511, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total of copies:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Genre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(511, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Available Copies:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txttitle
        '
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.Location = New System.Drawing.Point(175, 54)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(180, 27)
        Me.txttitle.TabIndex = 10
        '
        'txtap
        '
        Me.txtap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtap.Location = New System.Drawing.Point(885, 180)
        Me.txtap.Name = "txtap"
        Me.txtap.Size = New System.Drawing.Size(218, 27)
        Me.txtap.TabIndex = 12
        '
        'txttp
        '
        Me.txttp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttp.Location = New System.Drawing.Point(885, 137)
        Me.txttp.Name = "txttp"
        Me.txttp.Size = New System.Drawing.Size(218, 27)
        Me.txttp.TabIndex = 13
        '
        'txtbd
        '
        Me.txtbd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbd.Location = New System.Drawing.Point(175, 285)
        Me.txtbd.Multiline = True
        Me.txtbd.Name = "txtbd"
        Me.txtbd.Size = New System.Drawing.Size(928, 91)
        Me.txtbd.TabIndex = 15
        '
        'txtyp
        '
        Me.txtyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyp.Location = New System.Drawing.Point(885, 96)
        Me.txtyp.Name = "txtyp"
        Me.txtyp.Size = New System.Drawing.Size(218, 27)
        Me.txtyp.TabIndex = 16
        '
        'txtcn
        '
        Me.txtcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcn.Location = New System.Drawing.Point(885, 57)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(218, 27)
        Me.txtcn.TabIndex = 17
        '
        'txtauthor
        '
        Me.txtauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauthor.Location = New System.Drawing.Point(175, 93)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(180, 27)
        Me.txtauthor.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavigationToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1392, 28)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdfirst, Me.cmdnext, Me.cmdprev, Me.cmdlast})
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'cmdfirst
        '
        Me.cmdfirst.Image = CType(resources.GetObject("cmdfirst.Image"), System.Drawing.Image)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.Size = New System.Drawing.Size(152, 24)
        Me.cmdfirst.Text = "First"
        '
        'cmdnext
        '
        Me.cmdnext.Image = CType(resources.GetObject("cmdnext.Image"), System.Drawing.Image)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(152, 24)
        Me.cmdnext.Text = "Next"
        '
        'cmdprev
        '
        Me.cmdprev.Image = CType(resources.GetObject("cmdprev.Image"), System.Drawing.Image)
        Me.cmdprev.Name = "cmdprev"
        Me.cmdprev.Size = New System.Drawing.Size(152, 24)
        Me.cmdprev.Text = "Previous"
        '
        'cmdlast
        '
        Me.cmdlast.Image = CType(resources.GetObject("cmdlast.Image"), System.Drawing.Image)
        Me.cmdlast.Name = "cmdlast"
        Me.cmdlast.Size = New System.Drawing.Size(152, 24)
        Me.cmdlast.Text = "Last"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.navadd, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem, Me.PrintToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'navadd
        '
        Me.navadd.Image = CType(resources.GetObject("navadd.Image"), System.Drawing.Image)
        Me.navadd.Name = "navadd"
        Me.navadd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.navadd.Size = New System.Drawing.Size(203, 24)
        Me.navadd.Text = "Add books"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrystalReportToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.PrintToolStripMenuItem.Text = "Print Excel"
        '
        'CrystalReportToolStripMenuItem
        '
        Me.CrystalReportToolStripMenuItem.Name = "CrystalReportToolStripMenuItem"
        Me.CrystalReportToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.CrystalReportToolStripMenuItem.Text = "Crystal Report"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 29)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "ISBN:"
        '
        'txtisbn
        '
        Me.txtisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtisbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtisbn.Location = New System.Drawing.Point(175, 223)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(180, 27)
        Me.txtisbn.TabIndex = 21
        '
        'idpic
        '
        Me.idpic.Location = New System.Drawing.Point(1129, 54)
        Me.idpic.Name = "idpic"
        Me.idpic.Size = New System.Drawing.Size(218, 167)
        Me.idpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpic.TabIndex = 22
        Me.idpic.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1194, 253)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Insert Image"
        '
        'txtcr
        '
        Me.txtcr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcr.Location = New System.Drawing.Point(175, 180)
        Me.txtcr.Name = "txtcr"
        Me.txtcr.Size = New System.Drawing.Size(180, 27)
        Me.txtcr.TabIndex = 14
        '
        'txtgenre
        '
        Me.txtgenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgenre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtgenre.FormattingEnabled = True
        Me.txtgenre.Items.AddRange(New Object() {"Mystery", "Thriller", "Science Fiction", "Fantasy", "Romance", "Historical Fiction", "Horror", "Biography/Autobiography", "Memoir", "Self-help", "Young Adult", "Crime", "Adventure", "Comedy/Humor", "Poetry"})
        Me.txtgenre.Location = New System.Drawing.Point(174, 137)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(181, 30)
        Me.txtgenre.TabIndex = 29
        '
        'txtgen
        '
        Me.txtgen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtgen.Location = New System.Drawing.Point(175, 137)
        Me.txtgen.Multiline = True
        Me.txtgen.Name = "txtgen"
        Me.txtgen.Size = New System.Drawing.Size(180, 24)
        Me.txtgen.TabIndex = 28
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1392, 706)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.idpic)
        Me.Controls.Add(Me.txtisbn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.txtcn)
        Me.Controls.Add(Me.txtyp)
        Me.Controls.Add(Me.txtbd)
        Me.Controls.Add(Me.txtcr)
        Me.Controls.Add(Me.txttp)
        Me.Controls.Add(Me.txtap)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtgenre)
        Me.Controls.Add(Me.txtgen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtap As System.Windows.Forms.TextBox
    Friend WithEvents txttp As System.Windows.Forms.TextBox
    Friend WithEvents txtbd As System.Windows.Forms.TextBox
    Friend WithEvents txtyp As System.Windows.Forms.TextBox
    Friend WithEvents txtcn As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NavigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdfirst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdnext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdprev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdlast As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents navadd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtisbn As System.Windows.Forms.TextBox
    Friend WithEvents idpic As System.Windows.Forms.PictureBox
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtcr As System.Windows.Forms.TextBox
    Friend WithEvents txtgenre As System.Windows.Forms.ComboBox
    Friend WithEvents txtgen As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
