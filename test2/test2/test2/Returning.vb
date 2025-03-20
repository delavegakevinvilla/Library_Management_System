Imports System.Data.OleDb
Imports System.IO
Public Class Returning
    Private Sub DisplayPenalty()

        Dim penalty As Decimal = GetPenaltyFromDatabase()
        lblpdf.Text = penalty.ToString("C")

    End Sub
    Private Function getduedaysfromdatabase() As Decimal
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If

        Dim duedays As Decimal

        Using cmd As New OleDbCommand("SELECT [Due] FROM penalty WHERE [NO] = @SettingID", db)
            cmd.Parameters.AddWithValue("@SettingID", 1) ' Assuming the penalty setting ID is 1

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                If Decimal.TryParse(result.ToString(), duedays) Then
                    Return duedays
                Else

                    Throw New Exception("Invalid duedays format in database.")
                End If
            Else

                Throw New Exception("No duedays found in database.")
            End If
        End Using
    End Function
    Private Function GetPenaltyFromDatabase() As Decimal
        If db.State = ConnectionState.Closed Then
            openpenalty()
            db.Open()
        End If

        Dim penalty As Decimal

        Using cmd As New OleDbCommand("SELECT [penalty] FROM penalty WHERE [No] = @SettingID", db)
            cmd.Parameters.AddWithValue("@SettingID", 1) ' Assuming the penalty setting ID is 1

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                If Decimal.TryParse(result.ToString(), penalty) Then
                    Return penalty
                Else

                    Throw New Exception("Invalid penalty format in database.")
                End If
            Else

                Throw New Exception("No penalty found in database.")
            End If
        End Using
    End Function

    Private Sub Returning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtname.Text = XName
        txtid.Text = Xid
        Opendbborrow()
        sqlqueryborrow()
        tmrdate.Enabled = True
        dbs.DataSource = dbds.Tables("borrow")
        lblpdf.Text = GetPenaltyFromDatabase()
    End Sub

    Private Sub dbs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbs.CellContentClick
        dbs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dbs.Rows(e.RowIndex)

            lbltitle.Text = row.Cells("tl").Value.ToString()
            lblc.Text = row.Cells("course").Value.ToString()
            lblau.Text = row.Cells("au").Value.ToString()
            lbltime.Text = row.Cells("tm").Value.ToString()
            lbldate.Text = row.Cells("dt").Value.ToString()
            lblcn.Text = row.Cells("call num").Value.ToString()
            lblisbn.Text = row.Cells("isbn").Value.ToString()
            'txtcn.Text = row.Cells("Call No").Value.ToString()
            'Dim bookTitle As String = row.Cells("Title of the book").Value.ToString()
            'Dim imagePath As String = Application.StartupPath & "\imagebook\" & bookTitle & ".jpg"

            'If File.Exists(imagePath) Then
            '    idpic.Image = Image.FromFile(imagePath)
            'Else
            '    idpic.Image = Nothing
            'End If
        End If
    End Sub

    Private Sub tmrdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrdate.Tick
        lbldate2.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
        Dim userId As String = txtname.Text.Trim()
        Dim borrowCount As Integer = GetBorrowCount(userId)

        If borrowCount >= 2 Then
            MessageBox.Show("You have already borrowed twice and cannot borrow more.", "Borrowing Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the subroutine without proceeding further
        End If
    End Sub
    Private Function GetBorrowCount(ByVal userId As String) As Integer
        Dim borrowCount As Integer = 0
        Try

            Dim query As String = "SELECT COUNT(*) FROM transaction WHERE STUDENTID = @UserId"
            Using connection As New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dbase.mdb")
                connection.Open()
                Using command As New OleDb.OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserId", userId)
                    borrowCount = CInt(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error retrieving borrow count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return borrowCount
    End Function
End Class