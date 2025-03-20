<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userreports
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cruser = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1200, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(1079, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 22)
        Me.txtsearch.TabIndex = 1
        '
        'cruser
        '
        Me.cruser.ActiveViewIndex = -1
        Me.cruser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cruser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cruser.Location = New System.Drawing.Point(12, 65)
        Me.cruser.Name = "cruser"
        Me.cruser.Size = New System.Drawing.Size(1273, 412)
        Me.cruser.TabIndex = 2
        Me.cruser.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'userreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 489)
        Me.Controls.Add(Me.cruser)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Button1)
        Me.Name = "userreports"
        Me.Text = "userreports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cruser As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
