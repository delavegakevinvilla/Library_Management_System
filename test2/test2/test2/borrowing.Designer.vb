<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borrowing))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtgenre = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtcr = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtstudent = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtisbn = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcn = New System.Windows.Forms.Label()
        Me.txttitle = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.Label()
        Me.lbltmr = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.lblduty = New System.Windows.Forms.Label()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.btnborrow = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idpic = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Books = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Books.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(197, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 133)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BORROWING"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KVD LIBRARY"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtgenre)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtcr)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtstudent)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtisbn)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtcn)
        Me.GroupBox1.Controls.Add(Me.txttitle)
        Me.GroupBox1.Controls.Add(Me.txtauthor)
        Me.GroupBox1.Controls.Add(Me.lbltmr)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.lblduty)
        Me.GroupBox1.Controls.Add(Me.cbocourse)
        Me.GroupBox1.Controls.Add(Me.btnborrow)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(197, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1157, 349)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrowing Form:"
        '
        'txtgenre
        '
        Me.txtgenre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtgenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgenre.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgenre.Location = New System.Drawing.Point(561, 26)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(192, 35)
        Me.txtgenre.TabIndex = 32
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(460, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 25)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Genre:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(758, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 25)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Description:"
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(898, 24)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(253, 258)
        Me.txtdescription.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(759, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 25)
        Me.Label23.TabIndex = 28
        '
        'txtcr
        '
        Me.txtcr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtcr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcr.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcr.Location = New System.Drawing.Point(169, 311)
        Me.txtcr.Name = "txtcr"
        Me.txtcr.Size = New System.Drawing.Size(176, 35)
        Me.txtcr.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(36, 321)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 25)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Copy Right:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(368, 414)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 35)
        Me.Label18.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(235, 424)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 25)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "ISBN:"
        '
        'txtstudent
        '
        Me.txtstudent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtstudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstudent.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudent.Location = New System.Drawing.Point(561, 123)
        Me.txtstudent.Name = "txtstudent"
        Me.txtstudent.Size = New System.Drawing.Size(192, 35)
        Me.txtstudent.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(451, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 25)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Student ID:"
        '
        'txtisbn
        '
        Me.txtisbn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtisbn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtisbn.Location = New System.Drawing.Point(169, 261)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(176, 35)
        Me.txtisbn.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 25)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "ISBN:"
        '
        'txtcn
        '
        Me.txtcn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcn.Location = New System.Drawing.Point(169, 212)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(176, 35)
        Me.txtcn.TabIndex = 19
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.Location = New System.Drawing.Point(169, 167)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(176, 35)
        Me.txttitle.TabIndex = 18
        '
        'txtauthor
        '
        Me.txtauthor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauthor.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauthor.Location = New System.Drawing.Point(168, 119)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(176, 35)
        Me.txtauthor.TabIndex = 17
        '
        'lbltmr
        '
        Me.lbltmr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltmr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltmr.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltmr.Location = New System.Drawing.Point(168, 75)
        Me.lbltmr.Name = "lbltmr"
        Me.lbltmr.Size = New System.Drawing.Size(175, 35)
        Me.lbltmr.TabIndex = 16
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(169, 28)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(175, 30)
        Me.dtp.TabIndex = 7
        '
        'lblduty
        '
        Me.lblduty.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblduty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblduty.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduty.Location = New System.Drawing.Point(561, 73)
        Me.lblduty.Name = "lblduty"
        Me.lblduty.Size = New System.Drawing.Size(192, 35)
        Me.lblduty.TabIndex = 15
        '
        'cbocourse
        '
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"Computer Science", "Information Technology"})
        Me.cbocourse.Location = New System.Drawing.Point(561, 172)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(192, 33)
        Me.cbocourse.TabIndex = 14
        '
        'btnborrow
        '
        Me.btnborrow.Location = New System.Drawing.Point(962, 309)
        Me.btnborrow.Name = "btnborrow"
        Me.btnborrow.Size = New System.Drawing.Size(97, 32)
        Me.btnborrow.TabIndex = 3
        Me.btnborrow.Text = "Borrow"
        Me.btnborrow.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Author:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Call # Of Book:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(451, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Course/yr:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date:"
        '
        'idpic
        '
        Me.idpic.Location = New System.Drawing.Point(21, 151)
        Me.idpic.Name = "idpic"
        Me.idpic.Size = New System.Drawing.Size(154, 121)
        Me.idpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpic.TabIndex = 2
        Me.idpic.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 129)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(21, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'data
        '
        Me.data.AllowUserToDeleteRows = False
        Me.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Location = New System.Drawing.Point(0, 3)
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.RowTemplate.Height = 24
        Me.data.Size = New System.Drawing.Size(1137, 139)
        Me.data.TabIndex = 6
        '
        'tmr
        '
        '
        'Books
        '
        Me.Books.Controls.Add(Me.TabPage1)
        Me.Books.Controls.Add(Me.TabPage2)
        Me.Books.Location = New System.Drawing.Point(197, 517)
        Me.Books.Name = "Books"
        Me.Books.SelectedIndex = 0
        Me.Books.Size = New System.Drawing.Size(1151, 168)
        Me.Books.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.data)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1143, 139)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Books"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1143, 139)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1140, 143)
        Me.TextBox1.TabIndex = 0
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(556, 219)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 30)
        Me.TextBox2.TabIndex = 33
        '
        'borrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(1385, 697)
        Me.ControlBox = False
        Me.Controls.Add(Me.Books)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.idpic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "borrowing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "borrowing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.idpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Books.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbocourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idpic As System.Windows.Forms.PictureBox
    Friend WithEvents btnborrow As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblduty As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents lbltmr As System.Windows.Forms.Label
    Friend WithEvents txtisbn As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcn As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.Label
    Friend WithEvents txtauthor As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtcr As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtstudent As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgenre As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Books As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
