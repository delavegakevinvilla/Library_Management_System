Public Class Forgetvb

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Check if password fields are empty
        If String.IsNullOrWhiteSpace(txtpass.Text) OrElse String.IsNullOrWhiteSpace(txtconfirm.Text) Then
            MsgBox("Please fill in both password fields.", MsgBoxStyle.Exclamation, "Reminder!!!")
            ResetPasswordFields()
            Exit Sub
        End If

        ' Check if passwords match
        If txtpass.Text.Trim <> txtconfirm.Text.Trim Then
            MsgBox("Passwords do not match. Please enter the password correctly again.", MsgBoxStyle.Exclamation, "Reminder!!!")
            ResetPasswordFields()
            Exit Sub
        End If

        ' Check if user ID field is empty
        If String.IsNullOrWhiteSpace(txtid.Text) Then
            MsgBox("Please enter the user ID.", MsgBoxStyle.Exclamation, "Reminder!!!")
            Exit Sub
        End If

        ' Confirm update
        If MsgBox("Would you like to save the changes you made to its database?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.YesNo, "Updating...") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE tbluser SET [Password]= ? WHERE [User Name] like ?", db)
            dbcmd.Parameters.AddWithValue("@password", txtconfirm.Text.Trim)
            dbcmd.Parameters.AddWithValue("@username", txtid.Text.Trim)

            dbcmd.ExecuteNonQuery()
            sqlquery()

            If MsgBox("Are you sure you want to update this?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                MsgBox("Updated successfully!", MsgBoxStyle.Information)
                ResetPasswordFields()
            Else
                Me.Focus()
            End If
        End If
    End Sub

    Private Sub Forgetvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        sqlquery()
    End Sub

    Private Sub ResetPasswordFields()
        ' Clear the text boxes.
        txtpass.Text = String.Empty
        txtconfirm.Text = String.Empty
        txtid.Text = String.Empty

        ' Set the focus to the first text box.
        txtid.Focus()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If MsgBox("Would you like to close the current window? Do you wish to continue?", MsgBoxStyle.YesNo, "Closing...") = MsgBoxResult.Yes Then
            Me.Close()
            login.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Would you like to go back to log in form?", MsgBoxStyle.YesNo, "Closing...") = MsgBoxResult.Yes Then
            Me.Close()
            login.Visible = True
        End If

    End Sub

    Private Sub txtconfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirm.TextChanged

    End Sub
End Class