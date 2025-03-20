Public Class main
   
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblduty.Text = XName
        lblid.Text = Xid

        If xpriv = "User" Then
            btnUser.Enabled = False
            btninventory.Enabled = False
            btnborrow.Enabled = True
            btnreturn.Enabled = True
        End If

        If xpriv = "Admin" Then
            btnUser.Enabled = True
            btninventory.Enabled = True
            btnborrow.Enabled = True
            btnreturn.Enabled = True
        End If

        If xpost = "Admin" And xpriv = "Admin" Then
            btnUser.Enabled = True
            btninventory.Enabled = True
            btnborrow.Enabled = True
            btnreturn.Enabled = True
        End If
        tmr.Enabled = True
    End Sub
    Sub itemsclear()
        lblduty.Text = " "
    End Sub


    Private Sub mnuclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("This action will terminate the user from using the system? Would you like to proceed?", MsgBoxStyle.YesNo, "closing...") = MsgBoxResult.Yes Then

            Dim counter As Integer

            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter

            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub

    'Private Sub mnuuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuuser.Click
    '    frmuser.Show()
    '    mnu.Enabled = False

    'End Sub

    'Private Sub mnurooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurooms.Click
    '    frmroom.Show()
    '    mnu.Enabled = False
    'End Sub


    'Private Sub mnulogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulogout.Click


    '    Dim counter As Integer

    '    For counter = 90 To 10 Step -20
    '        Me.Opacity = counter / 100
    '        Me.Refresh()
    '        Threading.Thread.Sleep(5)
    '    Next counter
    '    Me.Close()
    '    frmlogin.Show()
    'End Sub



    'Private Sub mnuinquiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuinquiry.Click
    '    sw = True
    '    frminquiry.Show()
    '    frminquiry.Label13.Visible = False
    '    frminquiry.lblbalance.Visible = False
    '    frminquiry.gbguest.Visible = False
    '    frminquiry.gbothers.Visible = False
    '    frminquiry.dgtrans.Visible = False
    '    Me.mnu.Enabled = False

    'End Sub


    'Private Sub mnubooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnubooking.Click
    '    sw = True
    '    frminquiry.Show()
    '    mnu.Enabled = False

    'End Sub

    'Private Sub mnucheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucheckin.Click
    '    sw = False
    '    frminquiry.Show()
    '    Me.mnu.Enabled = False
    '    frminquiry.gbd8.Visible = False
    '    frminquiry.gbguest.Visible = False
    '    frminquiry.gbothers.Visible = False
    '    frminquiry.gbpayments.Visible = False
    '    frminquiry.gbroom.Visible = False
    '    frminquiry.dgtrans.Visible = True

    'End Sub

    'Private Sub frmtransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufile.Click

    'End Sub

    Private Sub lblduty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        lbltmr.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblduty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblduty.Click

    End Sub

    Private Sub lbltmr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltmr.Click

    End Sub

    Private Sub btnborrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrow.Click
        Me.Hide()
        borrowing.Show()
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub btninventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninventory.Click
        Me.Hide()
        books.Show()
    End Sub

    Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
        Me.Hide()
        Returning.Show()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()

        login.Show()
    End Sub

    Private Sub lblid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblid.Click

    End Sub

    Private Sub idpict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idpict.Click
        idpict.ImageLocation = Application.StartupPath & "\Image\" & lblduty.Text.Trim & ".jpg"
    End Sub
End Class
