<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btninventory = New System.Windows.Forms.Button()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.lbltmr = New System.Windows.Forms.Label()
        Me.btnborrow = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblduty = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.idpict = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.idpict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BackgroundImage = CType(resources.GetObject("btnUser.BackgroundImage"), System.Drawing.Image)
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.Location = New System.Drawing.Point(24, 120)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(244, 245)
        Me.btnUser.TabIndex = 2
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Red
        Me.btnlogout.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(1154, 400)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(110, 48)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btninventory
        '
        Me.btninventory.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.Image = CType(resources.GetObject("btninventory.Image"), System.Drawing.Image)
        Me.btninventory.Location = New System.Drawing.Point(937, 120)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Size = New System.Drawing.Size(252, 246)
        Me.btninventory.TabIndex = 4
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'tmr
        '
        '
        'lbltmr
        '
        Me.lbltmr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltmr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltmr.Location = New System.Drawing.Point(179, 75)
        Me.lbltmr.Name = "lbltmr"
        Me.lbltmr.Size = New System.Drawing.Size(154, 34)
        Me.lbltmr.TabIndex = 5
        '
        'btnborrow
        '
        Me.btnborrow.BackgroundImage = CType(resources.GetObject("btnborrow.BackgroundImage"), System.Drawing.Image)
        Me.btnborrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnborrow.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrow.Image = CType(resources.GetObject("btnborrow.Image"), System.Drawing.Image)
        Me.btnborrow.Location = New System.Drawing.Point(329, 121)
        Me.btnborrow.Name = "btnborrow"
        Me.btnborrow.Size = New System.Drawing.Size(244, 245)
        Me.btnborrow.TabIndex = 6
        Me.btnborrow.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.BackgroundImage = CType(resources.GetObject("btnreturn.BackgroundImage"), System.Drawing.Image)
        Me.btnreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreturn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Image = CType(resources.GetObject("btnreturn.Image"), System.Drawing.Image)
        Me.btnreturn.Location = New System.Drawing.Point(633, 120)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(244, 245)
        Me.btnreturn.TabIndex = 7
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Borrowing"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(626, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Returning Books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(991, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 37)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Inventory"
        '
        'lblduty
        '
        Me.lblduty.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblduty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblduty.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduty.Location = New System.Drawing.Point(179, 6)
        Me.lblduty.Name = "lblduty"
        Me.lblduty.Size = New System.Drawing.Size(192, 35)
        Me.lblduty.TabIndex = 1
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblid.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(179, 41)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(192, 35)
        Me.lblid.TabIndex = 12
        '
        'idpict
        '
        Me.idpict.Location = New System.Drawing.Point(1140, 2)
        Me.idpict.Name = "idpict"
        Me.idpict.Size = New System.Drawing.Size(135, 105)
        Me.idpict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.idpict.TabIndex = 24
        Me.idpict.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "User:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 27)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ID Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 27)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "TIme:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(1295, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.idpict)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btnborrow)
        Me.Controls.Add(Me.lbltmr)
        Me.Controls.Add(Me.btninventory)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.lblduty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.idpict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btninventory As System.Windows.Forms.Button
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents lbltmr As System.Windows.Forms.Label
    Friend WithEvents btnborrow As System.Windows.Forms.Button
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblduty As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents idpict As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
