Imports System.IO
Imports System.Drawing.Printing
Imports System.Data.OleDb

Public Class borrowing
    Private printDoc As New PrintDocument()

    Private Sub borrowing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblduty.Text = XName
        txtstudent.Text = Xid
        Opendbborrow()
        sqlqueryborrow()
        Opendbbooks()
        sqlquerybooks()
        data.DataSource = dbds.Tables("book")
        tmr.Enabled = True


    End Sub
    Private Sub btnborrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrow.Click
        If MsgBox("Are you sure you want to borrow?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Borrowing...") = MsgBoxResult.Yes Then
            Dim Name As String = lblduty.Text.Trim
            Dim callNum As String = txtcn.Text.Trim
            Dim title As String = txttitle.Text.Trim
            Dim isbn As String = txtisbn.Text.Trim
            Dim author As String = txtauthor.Text.Trim
            Dim course As String = cbocourse.SelectedItem.ToString()
            Dim copyright As String = txtcr.Text.Trim
            Dim studentId As String = txtstudent.Text.Trim
            Dim borrowDate As Date = dtp.Value
            Dim tm As String = lbltmr.Text.Trim

            Dim dueDate As Date = borrowDate.AddDays(1)
            Dim dueTime As TimeSpan = New TimeSpan(9, 0, 0)


            db.Open()
            dbcmd = New OleDb.OleDbCommand("INSERT INTO borrow ([call num],[tl],[dt],[tm],[au],[nm],[course],[isbn],[copyright],[studentid],[description]) VALUES ('" & txtcn.Text.Trim & "','" & txttitle.Text.Trim & "','" & dtp.Text.Trim & "','" & lbltmr.Text.Trim & "','" & txtauthor.Text.Trim & "','" & lblduty.Text.Trim & "','" & cbocourse.Text.Trim & "', '" & txtisbn.Text.Trim & "','" & txtcr.Text.Trim & "','" & txtstudent.Text.Trim & "','" & txtdescription.Text.Trim & "')", db)
            dbcmd.ExecuteNonQuery()
            dbcmd = New OleDb.OleDbCommand("UPDATE book SET [Available books] = [Available books] - 1 WHERE [Title of the book] = '" & txttitle.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            data.Refresh()
            sqlquerybooks()
            data.DataSource = dbds.Tables("book")
            'MessageBox.Show("Borrowed book information: " & Environment.NewLine & _
            '                "Name: " & Name & Environment.NewLine & _
            '        "Student ID: " & studentId & Environment.NewLine & _
            '        "Title: " & title & Environment.NewLine & _
            '        "ISBN: " & isbn & Environment.NewLine & _
            '        "Call Number: " & callNum & Environment.NewLine & _
            '        "Author: " & author & Environment.NewLine & _
            '        "Course: " & course & Environment.NewLine & _
            '        "Copyright: " & copyright & Environment.NewLine & _
            '        "Date: " & borrowDate.ToString("yyyy-mm-dd") & Environment.NewLine & _
            '        "Time: " & tm & Environment.NewLine & _
            '        "Due Date: " & dueDate.ToString("yyyy-MM-dd") & Environment.NewLine & _
            '        "Due Time: " & dueTime.ToString("hh\:mm\:ss"), "Borrowed Book", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlqueryborrow()
            TextBox1.Clear()

            ' Append the receipt content    
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)

            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("*        Borrowed Book Information        *" & vbNewLine)
            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("Title:          " & title & vbNewLine)
            TextBox1.AppendText("ISBN:           " & isbn & vbNewLine)
            TextBox1.AppendText("Call Number:    " & callNum & vbNewLine)
            TextBox1.AppendText("Author:         " & author & vbNewLine)
            TextBox1.AppendText("Course:         " & course & vbNewLine)
            TextBox1.AppendText("Copyright:      " & copyright & vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("*        Student Information        *" & vbNewLine)
            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("Name:     " & Name & vbNewLine)
            TextBox1.AppendText("Student ID:     " & studentId & vbNewLine)
            TextBox1.AppendText("Course:     " & course & vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("*        Returning Information And Details        *" & vbNewLine)
            TextBox1.AppendText("===========================================================================" & vbNewLine)
            TextBox1.AppendText("Date:           " & borrowDate.ToString("yyyy-MM-dd") & vbNewLine)
            TextBox1.AppendText("Time:           " & tm & vbNewLine)
            TextBox1.AppendText("Due Date:       " & dueDate.ToString("yyyy-MM-dd") & vbNewLine)
            TextBox1.AppendText("Due Time:       " & dueTime.ToString("hh\:mm\:ss") & vbNewLine)
            TextBox1.AppendText("===========================================================================")

            ' Print the receipt
            PrintPreviewDialog1.ShowDialog()
        Else
            txtauthor.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        lbltmr.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub data_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data.CellContentClick
        data.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = data.Rows(e.RowIndex)

            txttitle.Text = row.Cells("Title of the book").Value.ToString()
            txtauthor.Text = row.Cells("Author of the book").Value.ToString()
            txtgenre.Text = row.Cells("Genre").Value.ToString()
            txtcr.Text = row.Cells("Copyright").Value.ToString()
            txtdescription.Text = row.Cells("Description").Value.ToString()
            txtgenre.Text = row.Cells("Genre").Value.ToString()
            txtisbn.Text = row.Cells("ISBN").Value.ToString()
            txtcn.Text = row.Cells("Call No").Value.ToString()
            Dim bookTitle As String = row.Cells("Title of the book").Value.ToString()
            Dim imagePath As String = Application.StartupPath & "\imagebook\" & bookTitle & ".jpg"

            If File.Exists(imagePath) Then
                idpic.Image = Image.FromFile(imagePath)
            Else
                idpic.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If Button2.Text = "Refresh" Then
        '    frmBooksInventory_Load(sender, e)
        '    B.Text = "Search"
        'Else
        Dim x As String
        x = InputBox("Enter Book Title to Search : ")

        If x.Length < 1 Then
        Else
            Try
                book = New OleDb.OleDbDataAdapter("SELECT * FROM book WHERE [Title of the book] like '" & x.Trim & "'", db)
                dbds = New DataSet
                book.Fill(dbds, "book")
                If dbds.Tables("book").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("book").Rows.Count) - 1
                    data.DataSource = dbds.Tables("book")
                    'mnuSearch.Text = "Refresh"
                Else
                    MsgBox("No record found.", MsgBoxStyle.OkOnly)
                    If MsgBox("Do you want to search another record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'mnuSearch.PerformClick()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Close()
            End Try
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString(TextBox1.Text, Font, New SolidBrush(Color.Black), 140, 140)
        e.Graphics.DrawImage(PictureBox2.Image, New Rectangle(120, 130, PictureBox2.Width - 15, PictureBox2.Height - 25))
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub idpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idpic.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Opendbbooks()
        sqlquerybooks()

        dbcmd = New OleDb.OleDbCommand("SELECT * FROM book WHERE [Title of the book] LIKE '%" & TextBox2.Text & "%'", db)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = dbcmd
        dbds = New DataSet
        dbds.Clear()
        da.Fill(dbds, "book")
        data.DataSource = dbds.Tables("book")
    End Sub
End Class