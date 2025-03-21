﻿Public Class Form2

#Region "Custom Subroutines & Functions"
    Private Function CheckTools()
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(ComboBox1.Text) Or String.IsNullOrWhiteSpace(ComboBox2.Text) _
             Or String.IsNullOrWhiteSpace(ComboBox3.Text) Or String.IsNullOrWhiteSpace(ComboBox4.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) _
              Or String.IsNullOrWhiteSpace(TextBox3.Text) Or String.IsNullOrWhiteSpace(TextBox4.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) _
              Or String.IsNullOrWhiteSpace(TextBox6.Text) Or String.IsNullOrWhiteSpace(TextBox7.Text) Or String.IsNullOrWhiteSpace(TextBox8.Text) Then
            MessageBox.Show("Please make sure that all data have been entered.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub AddPatient()
        If CheckTools() Then
            'Write patient to file
            Dim pathPatient As String = Form1.pathPatients & TextBox8.Text & " - " & TextBox1.Text & "\"
            My.Computer.FileSystem.CreateDirectory(pathPatient)
            Dim interactiveControls() As Control = {TextBox1, TextBox8, ComboBox1, ComboBox2, ComboBox3, ComboBox4, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
            Dim sWriter As New System.IO.StreamWriter(pathPatient & "patientInfo.txt")
            For Each ctrl As Control In interactiveControls
                If ctrl Is ComboBox2 Or ctrl Is ComboBox3 Then
                    sWriter.Write(ctrl.Text & "/")
                Else
                    sWriter.WriteLine(ctrl.Text)
                End If
            Next
            sWriter.Close()
            PictureBox1.Image.Save(pathPatient & "imgPatient.png", System.Drawing.Imaging.ImageFormat.Png)
            sWriter = New System.IO.StreamWriter(Form1.pathGeneric & "PID.txt")
            sWriter.Write(Form1.PID + 1)
            sWriter.Close()

            'Visualise patient
            Form1.UpdateFPanel2()
            Close()
        End If
    End Sub
#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Location = New Point(Form1.Left + 25, Form1.Top + 45)
        For x = 1 To 31
            ComboBox2.Items.Add(x)
            If x < 13 Then
                ComboBox3.Items.Add(x)
            End If
        Next
        For x = 1900 To Date.UtcNow.Year
            ComboBox4.Items.Add(x)
        Next
        Form1.LoadGeneric()
        TextBox8.Text = Form1.PID
        PictureBox1.Image = My.Resources.iconPatient72
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddPatient()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddPatient()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim msgReply = MessageBox.Show("Clear patient data?", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim intControls() As Control = {TextBox1, ComboBox1, ComboBox2, ComboBox3, ComboBox4, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7}
        If msgReply = Windows.Forms.DialogResult.Yes Then
            For Each ctrl As Control In intControls
                ctrl.Text = ""
            Next
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.Image = My.Resources.iconPatient72
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        TextBox8.Text = Form1.PID
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.Load(OpenFileDialog1.FileName)
            End If
        End If
    End Sub

    
End Class