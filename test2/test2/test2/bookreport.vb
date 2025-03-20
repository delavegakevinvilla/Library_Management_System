Public Class bookreport

    Private Sub crbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crbook.Load
        crbook.ReportSource = Application.StartupPath & "\bookmanagementt1.rpt"
        crbook.Refresh()
        crbook.RefreshReport()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        crbook.ReportSource = Application.StartupPath & "\bookmanagementt1.rpt"
        crbook.SelectionFormula = "{book.Title of the book}  =  '" & txtsearch.Text.ToString.Trim & "'"
        crbook.Refresh()
        crbook.RefreshReport()
    End Sub

    Private Sub bookreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class