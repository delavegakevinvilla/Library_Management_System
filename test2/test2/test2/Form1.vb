Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Drawing.Printing
Imports System.Data.OleDb
Public Class Form1
    Dim userId As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the initial focus to the User ID text box
        txtid.Focus()

        ' Set the sw variable to True to allow the user to create a new account
        sw = True

        ' Enable the New User button
        NewUserToolStripMenuItem.Enabled = True

        ' Clear and unlock all the text boxes
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                CType(ctl, TextBox).Clear()
                CType(ctl, TextBox).ReadOnly = False
            End If
        Next
        dg.ReadOnly = True
        ' Load the data from the database
        opendb()
        sqlquery()
        lock()
        'idpict.Image = XName
        dg.DataSource = dbds.Tables("tbluser")
        TMR.Enabled = True
    End Sub
    Sub lock()
        txtid.ReadOnly = True
        txtname.ReadOnly = True
        txtpass.ReadOnly = True
        txtrp.ReadOnly = True
        txtpos.ReadOnly = True
        txtpriv.ReadOnly = True
        cbopriv.Visible = False
        txtidnum.ReadOnly = True

    End Sub
    Sub unlock()
        txtid.ReadOnly = False
        txtname.ReadOnly = False
        txtpass.ReadOnly = False
        txtrp.ReadOnly = False
        txtpos.ReadOnly = False
        txtpriv.ReadOnly = False
        cbopriv.Visible = True
        txtidnum.ReadOnly = False
    End Sub
    Sub navlock()
        navfirst.Enabled = False
        navnext.Enabled = False
        navprev.Enabled = False
        navlast.Enabled = False

    End Sub
    Sub navunlock()
        navfirst.Enabled = True
        navnext.Enabled = True
        navprev.Enabled = True
        navlast.Enabled = True
    End Sub
    Sub itemsclear()
        txtid.Text = ""
        txtname.Text = ""
        txtpass.Text = ""
        txtrp.Text = ""
        txtpos.Text = ""
        txtpriv.Text = ""
        cbopriv.Text = ""
        txtidnum.Text = ""
    End Sub

    Sub display()
        userId = dg.Rows(recpointer).Cells("User ID").Value.ToString()
        Try
            txtid.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User ID")
            txtname.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User Name")
            txtpos.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Position")
            txtpriv.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Privilege")
            txtidnum.Text = dbds.Tables("tbuser").Rows(recpointer).Item("studentiid")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If MsgBox("Will this action end the open window? Are you ready to move ahead?", MsgBoxStyle.YesNo, "closing please wait...") = MsgBoxResult.Yes Then

            Dim counter As Integer

            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            Me.FileToolStripMenuItem.Enabled = True

            Me.Close()
            main.Show()
        Else
            Me.Focus()
        End If
    End Sub


    Private Sub navfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles navfirst.Click

        dg.Rows(recpointer).Selected = False
        recpointer = 0
        dg.Rows(recpointer).Selected = True
        display()
        idpict.ImageLocation = Application.StartupPath & "\images\" & userId & ".jpg"
    End Sub

    Private Sub navnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles navnext.Click
        If recpointer < trec Then
            dg.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dg.Rows(recpointer).Selected = True
            display()
            idpict.ImageLocation = Application.StartupPath & "\images\" & userId & ".jpg"
        End If
    End Sub

    Private Sub navprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles navprev.Click
        If recpointer > 0 Then
            dg.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dg.Rows(recpointer).Selected = True
            display()
            idpict.ImageLocation = Application.StartupPath & "\images\" & userId & ".jpg"
        End If
    End Sub
    Private Sub navlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles navlast.Click
        dg.Rows(recpointer).Selected = False
        recpointer = trec
        dg.Rows(recpointer).Selected = True
        display()
        idpict.ImageLocation = Application.StartupPath & "\images\" & userId & ".jpg"
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewUserToolStripMenuItem.Click

            itemsclear()
            dg.Rows(recpointer).Selected = False
            recpointer = trec + 1
            dg.Rows(recpointer).Selected = True

            Dim userIdNum As String = "KVD-"
            recpointer = recpointer + 1

            Dim numStr As String = recpointer.ToString("D5")

            Dim userId As String = userIdNum & numStr
            txtid.Text = userId
            sw = True
            unlock()
            txtpriv.Visible = False
            cbopriv.Visible = True
            txtid.Focus()
            dg.Enabled = True
            navlock()


    End Sub


    Private Function AllTextBoxesFilled() As Boolean
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                If CType(ctl, TextBox).Text.Trim = "" Then
                    Return False
                End If
            End If
        Next


        Return True
    End Function


    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("The records will be permanently removed from its database if you proceed!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tbluser WHERE [User ID] like '" & txtid.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            dg.DataSource = dbds.Tables("tbluser")
            itemsclear()
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim x As String
        x = InputBox("Enter User ID to Search : ").Trim()

        If x.Length < 1 Then
            Exit Sub
        Else
            Try
                tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser WHERE [User ID] = @UserID", db)
                tbluser.SelectCommand.Parameters.AddWithValue("@UserID", x)
                dbds = New DataSet
                tbluser.Fill(dbds, "tbluser")
                If dbds.Tables("tbluser").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
                    dg.DataSource = dbds.Tables("tbluser")

                    ' Hide the Password column
                    dg.Columns("Password").Visible = False
                End If
            Catch ex As Exception
                MsgBox(Err.ToString)
            Finally
                db.Close()
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If sw Then
            If txtpass.Text.Trim = txtrp.Text.Trim Then
                If txtid.Text.Trim = "" Or txtname.Text.Trim = "" Or txtpass.Text.Trim = "" Or txtrp.Text.Trim = "" Or txtpos.Text.Trim = "" Or cbopriv.Text.Trim = "" Then
                    MessageBox.Show("PLease Fill-up all the fields before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                db.Open()
                dbcmd = New OleDb.OleDbCommand("INSERT INTO tbluser([User ID],[User Name],[Password],[Position],[Privilege],[studentid]) VALUES ('" & txtid.Text.Trim & "','" & txtname.Text.Trim & "','" & txtpass.Text.Trim & "','" & txtpos.Text.Trim & "','" & cbopriv.Text.Trim & "','" & txtidnum.Text.Trim & "')", db)
                dbcmd.ExecuteNonQuery()
                sqlquery()
                lock()

                cbopriv.Visible = False
                txtpriv.Visible = True
                dg.Enabled = True

                dg.DataSource = dbds.Tables("tbluser")

                itemsclear()

            Else
                MessageBox.Show("Password mismatch, please input the right password...!!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpass.Focus()
                txtpass.Clear()
                txtrp.Clear()

            End If

        Else
            If txtpass.Text.Trim = "" Then
                MessageBox.Show("Password is a required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MsgBox("Would you like to keep the modifications you made to its database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "updating please wait...") = MsgBoxResult.Yes Then
                db.Open()
                dbcmd = New OleDb.OleDbCommand("UPDATE tbluser SET [Password]= '" & txtpass.Text.Trim & "' WHERE [User ID]like '" & txtid.Text.Trim & "'", db)
                dbcmd.ExecuteNonQuery()
                sqlquery()
                lock()

                dg.Enabled = True

                dg.DataSource = dbds.Tables("tbluser")

                itemsclear()

            Else
                Me.Focus()

            End If

        End If

        idpict.Image = Nothing
    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        lock()
        cbopriv.Visible = False
        txtid.Focus()
        dg.Enabled = True
        navunlock()
        dg.Enabled = True
        itemsclear()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        sw = False
        txtname.ReadOnly = False
        txtpass.ReadOnly = False
        txtrp.ReadOnly = False
        txtpass.Clear()
        txtrp.Clear()
        dg.Enabled = False
        txtpass.Focus()
    End Sub

    Private Sub dg_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dg.CellClick
        dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.RowIndex >= 0 Then
            Dim userId As String = dg.Rows(e.RowIndex).Cells("User ID").Value.ToString()
            Dim imagePath As String = Application.StartupPath & "\images\" & userId & ".jpg"
            If File.Exists(imagePath) Then
                idpict.Image = Image.FromFile(imagePath)
            Else
                idpict.Image = Nothing
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtid.Text.Trim.Length > 0 Then
            ofd.FileName = ""
            ofd.ShowDialog()
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(ofd.FileName, Application.StartupPath & "\images\" & Trim(txtid.Text) & ".jpg", True)
                    idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                    idpict.Load()
                Catch err As Exception
                    MsgBox(err.ToString)

                End Try
            End If
        Else
            MsgBox("Please type the User ID before browsing for images...", MsgBoxStyle.Information, "reminder!!!")
        End If

    End Sub

    Private Sub idpict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idpict.Click
        idpict.ImageLocation = Application.StartupPath & "\Image\" & txtid.Text.Trim & ".jpg"
    End Sub

    Private Sub ofd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If dg.RowCount = Nothing Then
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

            rowsTotal = dg.RowCount - 1
            colsTotal = dg.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dg.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dg.Rows(I).Cells(j).Value
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
            'RELEASE ALLOACTED RESOURCES
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

    Private Sub CrystalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportToolStripMenuItem.Click
        userreports.Show()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dg.Rows(e.RowIndex)

            txtid.Text = row.Cells("User ID").Value.ToString()
            txtname.Text = row.Cells("User Name").Value.ToString()
            txtpos.Text = row.Cells("Position").Value.ToString()
            txtidnum.Text = row.Cells("studentid").Value.ToString()
            txtpriv.Text = row.Cells("Privilege").Value.ToString()
           
            Dim imagePath As String = Application.StartupPath & "\images\" & userId & ".jpg"

            If File.Exists(imagePath) Then
                idpict.Image = Image.FromFile(imagePath)
            Else
                idpict.Image = Nothing
            End If
        End If
    End Sub

End Class
