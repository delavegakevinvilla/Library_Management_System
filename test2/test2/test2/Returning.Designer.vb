<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Returning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Returning))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblisbn = New System.Windows.Forms.Label()
        Me.lblcn = New System.Windows.Forms.Label()
        Me.lblau = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dbs = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbltime2 = New System.Windows.Forms.Label()
        Me.lbldate2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tmrdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblpdf = New System.Windows.Forms.Label()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Returning Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 53)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KVD LIBRARY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblisbn)
        Me.GroupBox1.Controls.Add(Me.lblcn)
        Me.GroupBox1.Controls.Add(Me.lblau)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.lblc)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 362)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Return Stab"
        '
        'lblisbn
        '
        Me.lblisbn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblisbn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblisbn.Location = New System.Drawing.Point(180, 276)
        Me.lblisbn.Name = "lblisbn"
        Me.lblisbn.Size = New System.Drawing.Size(275, 35)
        Me.lblisbn.TabIndex = 24
        '
        'lblcn
        '
        Me.lblcn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcn.Location = New System.Drawing.Point(180, 236)
        Me.lblcn.Name = "lblcn"
        Me.lblcn.Size = New System.Drawing.Size(275, 35)
        Me.lblcn.TabIndex = 23
        '
        'lblau
        '
        Me.lblau.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblau.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblau.Location = New System.Drawing.Point(180, 191)
        Me.lblau.Name = "lblau"
        Me.lblau.Size = New System.Drawing.Size(275, 35)
        Me.lblau.TabIndex = 22
        '
        'lbltitle
        '
        Me.lbltitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(180, 148)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(275, 35)
        Me.lbltitle.TabIndex = 21
        '
        'lblc
        '
        Me.lblc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblc.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.Location = New System.Drawing.Point(180, 107)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(275, 35)
        Me.lblc.TabIndex = 20
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(180, 69)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(275, 35)
        Me.txtid.TabIndex = 19
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(180, 28)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(275, 35)
        Me.txtname.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 26)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Student ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ISBN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Author:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 26)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Course:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Call No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltime)
        Me.GroupBox2.Controls.Add(Me.lbldate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(579, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 183)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrowed Details"
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltime.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(110, 79)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(275, 35)
        Me.lbltime.TabIndex = 27
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldate.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(110, 36)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(275, 35)
        Me.lbldate.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "TIme:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Date:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 129)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(988, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dbs
        '
        Me.dbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbs.Location = New System.Drawing.Point(49, 563)
        Me.dbs.Name = "dbs"
        Me.dbs.RowTemplate.Height = 24
        Me.dbs.Size = New System.Drawing.Size(1025, 262)
        Me.dbs.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbltime2)
        Me.GroupBox3.Controls.Add(Me.lbldate2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(579, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 183)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Returning Details:"
        '
        'lbltime2
        '
        Me.lbltime2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltime2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime2.Location = New System.Drawing.Point(110, 79)
        Me.lbltime2.Name = "lbltime2"
        Me.lbltime2.Size = New System.Drawing.Size(275, 35)
        Me.lbltime2.TabIndex = 29
        '
        'lbldate2
        '
        Me.lbldate2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbldate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldate2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate2.Location = New System.Drawing.Point(110, 28)
        Me.lbldate2.Name = "lbldate2"
        Me.lbldate2.Size = New System.Drawing.Size(275, 35)
        Me.lbldate2.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 25)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "TIme:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 25)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Date:"
        '
        'tmrdate
        '
        Me.tmrdate.Interval = 1000
        '
        'lblpdf
        '
        Me.lblpdf.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpdf.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpdf.Location = New System.Drawing.Point(799, 73)
        Me.lblpdf.Name = "lblpdf"
        Me.lblpdf.Size = New System.Drawing.Size(275, 35)
        Me.lblpdf.TabIndex = 28
        '
        'btnreturn
        '
        Me.btnreturn.BackColor = System.Drawing.Color.Lime
        Me.btnreturn.Location = New System.Drawing.Point(842, 521)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(86, 36)
        Me.btnreturn.TabIndex = 29
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'Returning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(1427, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.lblpdf)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dbs)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Returning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dbs As System.Windows.Forms.DataGridView
    Friend WithEvents lblisbn As System.Windows.Forms.Label
    Friend WithEvents lblcn As System.Windows.Forms.Label
    Friend WithEvents lblau As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltime2 As System.Windows.Forms.Label
    Friend WithEvents lbldate2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tmrdate As System.Windows.Forms.Timer
    Friend WithEvents lblpdf As System.Windows.Forms.Label
    Friend WithEvents btnreturn As System.Windows.Forms.Button
End Class
