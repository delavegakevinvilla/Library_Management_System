<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookreport
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
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.crbook = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(1404, 12)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(1284, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 22)
        Me.txtsearch.TabIndex = 1
        '
        'crbook
        '
        Me.crbook.ActiveViewIndex = -1
        Me.crbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crbook.Cursor = System.Windows.Forms.Cursors.Default
        Me.crbook.Location = New System.Drawing.Point(12, 40)
        Me.crbook.Name = "crbook"
        Me.crbook.Size = New System.Drawing.Size(1485, 449)
        Me.crbook.TabIndex = 2
        Me.crbook.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'bookreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 491)
        Me.Controls.Add(Me.crbook)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Name = "bookreport"
        Me.Text = "bookreport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents crbook As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
