Public Class userreports


    Private Sub userreports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cruser.ReportSource = Application.StartupPath & "\userreport.rpt"
        cruser.SelectionFormula = "{tbluser.User Name}  =  '" & txtsearch.Text.ToString.Trim & "'"
        cruser.Refresh()
        cruser.RefreshReport()
    End Sub

    Private Sub cruser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cruser.Load
        cruser.ReportSource = Application.StartupPath & "\userreport.rpt"
        cruser.Refresh()
        cruser.RefreshReport()
    End Sub
End Class