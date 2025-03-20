Public Class login
    
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        sqlquery()
        lock()
    End Sub
    Sub lock()
        txtid.ReadOnly = True
        txtname.ReadOnly = True
        txtstudentid.ReadOnly = True
        txtpw.ReadOnly = True
        txtrpw.ReadOnly = True
        txtpos.ReadOnly = True
        cbopriv.Visible = False

    End Sub
    Sub unlock()
        txtid.ReadOnly = False
        txtname.ReadOnly = False
        txtstudentid.ReadOnly = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpos.ReadOnly = False
        cbopriv.Visible = True
    End Sub
    Sub display()
        Try
            txtid.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User ID")
            txtname.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User Name")
            txtpos.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Position")
            txtstudentid.Text = dbds.Tables("tbluser").Rows(recpointer).Item("studentid")
            txtpriv.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Privilege")
            cbopriv.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Privilege")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        If txtun.Text = "" OrElse txtpw2.Text = "" Then
            MsgBox("Please enter both User Name and Password.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        opendb()
        tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser WHERE [User Name] like '" & txtun.Text & "' and [Password] like '" & txtpw2.Text & "'", db)
        dbds = New DataSet()
        tbluser.Fill(dbds, "tbluser")
        trec = dbds.Tables("tbluser").Rows.Count
        recpointer = trec + 1

        If trec > 0 Then
            XName = txtun.Text
            Xid = dbds.Tables("tbluser").Rows(0).Item("studentid")
            xpost = dbds.Tables("tbluser").Rows(0).Item("Position")
            xpriv = dbds.Tables("tbluser").Rows(0).Item("Privilege")
            Me.Visible = False

            txtun.Clear()
            txtpw2.Clear()
            main.Show()
        Else
            xtry = xtry + 1

            If xtry > 2 Then
                Me.Close()
                db.Close()
                MsgBox("You have exceeded the maximum number of login attempts. Please try again later.", MsgBoxStyle.Critical)
            Else
                MsgBox("The Password of you have entered does not correspond with your User Name...TRY AGAIN! (" & 3 - xtry & " attempts remaining)", MsgBoxStyle.Critical)
            End If

            txtun.Clear()
            txtpw2.Clear()
            txtun.Focus()
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to leave the program?", "Confirm Exit", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        pregister.BringToFront()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pregister.BringToFront()
    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        If sw Then
            Dim result As DialogResult = MessageBox.Show("The current user is not finished. Are you sure you want to create a new user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If
        Dim userId As String
        Dim userIdNum As String

        recpointer = trec + 1

        userIdNum = "KVD-"
        recpointer = recpointer + 1

        Dim numStr As String = recpointer.ToString("D5")

        userId = userIdNum & numStr
        txtid.Text = userId
        sw = True
        txtpriv.Visible = False
        cbopriv.Visible = True
        txtid.Focus()
        unlock()
        txtpriv.Visible = False
        cbopriv.Visible = True
        txtid.Focus()



    End Sub

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click

        If String.IsNullOrWhiteSpace(txtid.Text) Or String.IsNullOrWhiteSpace(txtname.Text) Or String.IsNullOrWhiteSpace(txtpw.Text) Or String.IsNullOrWhiteSpace(txtrpw.Text) Or String.IsNullOrWhiteSpace(txtpos.Text) Or String.IsNullOrWhiteSpace(cbopriv.Text) Then
            MsgBox("Please fill in all required fields before saving.", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If txtpw.Text.Trim = txtrpw.Text.Trim Then

            If sw = True Then
                If MsgBox("The information is currently being stored in the database...", MsgBoxStyle.DefaultButton1 + vbYesNo, "currently saving...") = MsgBoxResult.Yes Then
                    db.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tbluser([User ID],[User Name],[Password],[Position],[Privilege],[studentid]) VALUES ('" & txtid.Text.Trim & "','" & txtname.Text.Trim & "','" & txtpw.Text.Trim & "','" & txtpos.Text.Trim & "','" & cbopriv.Text.Trim & "','" & txtstudentid.Text.Trim & "')", db)
                    dbcmd.ExecuteNonQuery()
                    sqlquery()


                    txtid.Clear()
                    txtname.Clear()
                    txtpw.Clear()
                    txtrpw.Clear()
                    txtpos.Clear()
                    txtstudentid.Clear()
                    cbopriv.Text = ""
                    txtpriv.Text = ""

                    cbopriv.Visible = False
                    txtpriv.Visible = True

                Else
                    txtid.Focus()
                End If
            End If

            If sw = False Then

                Me.Focus()
            End If
        Else
            MsgBox("Password mismatch, please input the right password...!!", , "Error!!!")
            txtpw.Focus()
            txtpw.Clear()
            txtrpw.Clear()
        End If
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        Me.Refresh()
        opendb()
        sqlquery()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Forgetvb.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtun.Text = "" OrElse txtpw2.Text = "" Then
            MsgBox("Please enter both User Name and Password.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        opendb()
        tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser WHERE [User Name] = ? AND [Password] = ?", db)
        tbluser.SelectCommand.Parameters.AddWithValue("@username", txtun.Text)
        tbluser.SelectCommand.Parameters.AddWithValue("@password", txtpw2.Text)
        dbds = New DataSet()
        tbluser.Fill(dbds, "tbluser")
        trec = dbds.Tables("tbluser").Rows.Count
        recpointer = trec + 1

        If trec > 0 Then
            XName = txtun.Text
            Xid = dbds.Tables("tbluser").Rows(0).Item("studentid")
            xpost = dbds.Tables("tbluser").Rows(0).Item("Position")
            xpriv = dbds.Tables("tbluser").Rows(0).Item("Privilege")
            Me.Visible = False

            txtun.Clear()
            txtpw2.Clear()
            main.Show()
        Else
            xtry = xtry + 1

            If xtry > 2 Then
                Me.Close()
                db.Close()
                MsgBox("You have exceeded the maximum number of login attempts. Please try again later.", MsgBoxStyle.Critical)
            Else
                MsgBox("The Password of you have entered does not correspond with your User Name...TRY AGAIN! (" & 3 - xtry & " attempts remaining)", MsgBoxStyle.Critical)
            End If

            txtun.Clear()
            txtpw2.Clear()
            txtun.Focus()
        End If
    End Sub
End Class