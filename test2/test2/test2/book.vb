Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class books
    Dim booktitle As String
    Dim title As String
    

    Private Sub book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Opendbbooks()
        sqlquerybooks()
        lock()

        data.DataSource = dbds.Tables("book")

    End Sub
    Sub lock()
        txtauthor.ReadOnly = True
        txttitle.ReadOnly = True
        txtcr.ReadOnly = True
        txtcn.ReadOnly = True
        txtyp.ReadOnly = True
        txttp.ReadOnly = True
        txtap.ReadOnly = True
        txtbd.ReadOnly = True
        txtisbn.ReadOnly = True
        txtgen.ReadOnly = True
        txtgenre.Visible = False
    End Sub
    Sub unlock()
        txtauthor.ReadOnly = False
        txttitle.ReadOnly = False
        txtcr.ReadOnly = False
        txtcn.ReadOnly = False
        txtyp.ReadOnly = False
        txttp.ReadOnly = False
        txtap.ReadOnly = False
        txtbd.ReadOnly = False
        txtisbn.ReadOnly = False
        txtgen.ReadOnly = False
        txtgenre.Visible = True
    End Sub
    Sub itemclear()
        txtauthor.Text = " "
        txttitle.Text = " "
        txtgenre.Text = " "
        txtcr.Text = " "
        txtcn.Text = " "
        txtyp.Text = " "
        txttp.Text = " "
        txtap.Text = " "
        txtbd.Text = " "
        txtisbn.Text = " "
    End Sub
    Sub displaybooks()
        Try
            booktitle = data.Rows(recpointer).Cells("Title of the book").Value.ToString()
            txtauthor.Text = dbds.Tables("book").Rows(recpointer).Item("Author of the book")
            txttitle.Text = dbds.Tables("book").Rows(recpointer).Item("Title of the book")
            txtcn.Text = dbds.Tables("book").Rows(recpointer).Item("Call No")
            txtyp.Text = dbds.Tables("book").Rows(recpointer).Item("Publication Year")
            txtbd.Text = dbds.Tables("book").Rows(recpointer).Item("Description")
            txtcr.Text = dbds.Tables("book").Rows(recpointer).Item("Copyright")
            txttp.Text = dbds.Tables("book").Rows(recpointer).Item("Number of books")
            txtap.Text = dbds.Tables("book").Rows(recpointer).Item("Available books")
            txtgenre.Text = dbds.Tables("book").Rows(recpointer).Item("Genre")
            txtisbn.Text = dbds.Tables("book").Rows(recpointer).Item("ISBN")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfirst.Click
        data.Rows(recpointer).Selected = False
        recpointer = 0
        data.Rows(recpointer).Selected = True
        displaybooks()
        idpic.ImageLocation = Application.StartupPath & "\imagebook\" & booktitle & ".jpg"
    End Sub

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        If recpointer < trec Then
            data.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            data.Rows(recpointer).Selected = True
            displaybooks()
            idpic.ImageLocation = Application.StartupPath & "\imagebook\" & booktitle & ".jpg"
        End If
    End Sub

    Private Sub cmdprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprev.Click
        If recpointer > 0 Then
            data.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            data.Rows(recpointer).Selected = True
            displaybooks()
            idpic.ImageLocation = Application.StartupPath & "\imagebook\" & booktitle & ".jpg"
        End If
    End Sub

    Private Sub cmdlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlast.Click
        data.Rows(recpointer).Selected = False
        recpointer = trec
        data.Rows(recpointer).Selected = True
        displaybooks()
        idpic.ImageLocation = Application.StartupPath & "\imagebook\" & booktitle & ".jpg"
    End Sub

    Private Sub navadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles navadd.Click
        unlock()
        itemclear()
        idpic.Image = Nothing

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("If you'll continue, then the records will permanently be deleted from it's database!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM book WHERE [Author of the book] like '" & txtauthor.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            data.DataSource = dbds.Tables("book")
            itemclear()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If MsgBox("The data(s) are now being stored in the database...", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("INSERT INTO book([Call No],[ISBN],[Title of the book],[Author of the book],[Publication Year],[Genre],[Copyright],[Number of books],[Description],[Available books]) VALUES ('" & txtcn.Text.Trim & "','" & txtisbn.Text.Trim & "','" & txttitle.Text.Trim & "','" & txtauthor.Text.Trim & "','" & txtyp.Text.Trim & "','" & txtgenre.Text.Trim & "','" & txtcr.Text.Trim & "','" & txttp.Text.Trim & "','" & txtbd.Text.Trim & "','" & txtap.Text.Trim & "')", db)
            dbcmd.ExecuteNonQuery()
            sqlquerybooks()
            lock()


            data.Enabled = True

            data.DataSource = dbds.Tables("book")

        Else
            txtauthor.Focus()
        End If


        If sw = False Then
            If MsgBox("Do you want to save the changes you made to its database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "updating...") = MsgBoxResult.Yes Then
                db.Open()
                dbcmd = New OleDb.OleDbCommand("UPDATE book SET [Author of the book]= '" & txtauthor.Text.Trim & "' WHERE [Genre]like '" & txtgenre.Text.Trim & "'", db)
                dbcmd.ExecuteNonQuery()
                sqlquerybooks()
                lock()

                data.Enabled = True

                data.DataSource = dbds.Tables("book")
            Else
                Me.Focus()

            End If
        End If
        idpic.Image = Nothing
    End Sub

    Private Sub txttitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttitle.TextChanged

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        main.Show()
        Me.Close()


    End Sub



    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If data.RowCount = Nothing Then
            MessageBox.Show("Nothing to Export.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = data.RowCount - 1
            colsTotal = data.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = data.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = data.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub releaseobject(ByRef obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub data_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data.CellContentClick

        data.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim row As DataGridViewRow = data.Rows(e.RowIndex)

        txttitle.Text = row.Cells("Title of the book").Value.ToString()
        txtauthor.Text = row.Cells("Author of the book").Value.ToString()
        txtgenre.Text = row.Cells("Genre").Value.ToString()
        txtcr.Text = row.Cells("Copyright").Value.ToString()
        txtyp.Text = row.Cells("Publication Year").Value.ToString()
        txtbd.Text = row.Cells("Description").Value.ToString()
        txttp.Text = row.Cells("Number of books").Value.ToString()
        txtap.Text = row.Cells("Available books").Value.ToString()
        txtgenre.Text = row.Cells("Genre").Value.ToString()
        txtisbn.Text = row.Cells("ISBN").Value.ToString()
        txtcn.Text = row.Cells("Call No").Value.ToString()
        data.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.RowIndex >= 0 Then
            Dim userId As String = data.Rows(e.RowIndex).Cells("Title of the book").Value.ToString()
            Dim imagePath As String = Application.StartupPath & "\imagebook\" & userId & ".jpg"
            If File.Exists(imagePath) Then
                idpic.Image = Image.FromFile(imagePath)
            Else
                idpic.Image = Nothing
            End If
        End If

    End Sub


    Private Sub idpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idpic.Click
        idpic.ImageLocation = Application.StartupPath & "\imagebook\" & txttitle.Text.Trim & ".jpg" 'this code is for emerut
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txttitle.Text.Trim.Length > 0 Then
            ofd.FileName = ""
            ofd.ShowDialog()
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(ofd.FileName, Application.StartupPath & "\imagebook\" & Trim(txttitle.Text) & ".jpg", True)
                    idpic.ImageLocation = Application.StartupPath & "\imagebook\" & txttitle.Text.Trim & ".jpg"
                    idpic.Load()
                Catch err As Exception
                    MsgBox(err.ToString)

                End Try
            End If
        Else
            MsgBox("Please type the User ID before browsing for images...", MsgBoxStyle.Information, "reminder!!!")
        End If

    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim x As String
        x = InputBox("Enter Book Title to Search : ").Trim()

        If x.Length < 1 Then
            Exit Sub
        Else
            Try
                book = New OleDb.OleDbDataAdapter("SELECT * FROM book WHERE [Title of the book] = @Title", db)
                book.SelectCommand.Parameters.AddWithValue("@Title", x)
                dbds = New DataSet
                book.Fill(dbds, "book")
                If dbds.Tables("book").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("book").Rows.Count) - 1
                    data.DataSource = dbds.Tables("book")

                    ' Hide the Password column
                    data.Columns("Password").Visible = False

                    ' Display the image for the first row
                    Dim row As DataRow = dbds.Tables("book").Rows(0)
                    booktitle = row.Field(Of String)("Title of the book")
                    Dim imagePath As String = Application.StartupPath & "\imagebook\" & booktitle & ".jpg"

                    If File.Exists(imagePath) Then
                        idpic.Image = Image.FromFile(imagePath)
                    Else
                        idpic.Image = Nothing
                        MessageBox.Show("Image not found for the selected book.", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Catch ex As Exception
            Finally
                db.Close()
            End Try
        End If
    End Sub


    Private Sub txtgen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcr.TextChanged

    End Sub

    Private Sub txtgenre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgenre.SelectedIndexChanged

    End Sub

    Private Sub txtbd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbd.TextChanged

    End Sub

    Private Sub CrystalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportToolStripMenuItem.Click
        bookreport.Show()
    End Sub
End Class