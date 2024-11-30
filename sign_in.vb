Imports System.Data.Odbc
Imports System.Text.RegularExpressions
Public Class sign_in

    Private Sub sign_in_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
     

    End Sub
    Private Sub btn_sign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sign.Click

        'validation
        Dim par As String
        par = ("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If Regex.IsMatch(txt_email.Text, par) Then


        Else
            MsgBox("Please fill out  the filed")
            Return
        End If






        connectMe()
        Dim u As String
        Dim p As String
        Dim f As String
        Dim em As String
        Dim ln As String


        u = txt_user.Text.Trim
        p = txt_password.Text.Trim
        f = txt_fname.Text.Trim
        em = txt_email.Text.Trim
        ln = txt_lname.Text.Trim


        con.Close()


        Try
            con.Open()
            With mycmd
                .Connection = con
                .CommandText = "insert into login_tbl values('" & u & "', md5( '" & p & "'),'" & em & "','" & f & "', '" & ln & "')"
                .ExecuteNonQuery()
            End With
            MessageBox.Show(" informationadded", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txt_fname.Clear()
            txt_lname.Clear()
            txt_email.Clear()
            txt_user.Clear()
            txt_password.Clear()

            txt_fname.Focus()
            Frm_vet.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress

        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("sorry , only letters(a-z), numbers (0-9),and period are allowed. ")
            txt_email.Focus()
            Return
        End If

    End Sub
    Private Sub txt_fname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fname.KeyDown

        If e.KeyCode = 13 Then
            If txt_fname.Text = "" Then
                MessageBox.Show("please fill the fild ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_fname.Focus()
            End If
            txt_lname.Focus()
        End If
    End Sub

    Private Sub txt_lname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lname.KeyDown
        If e.KeyCode = 13 Then
            If txt_lname.Text = "" Then
                MessageBox.Show("please fill the fild ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_lname.Focus()
            End If
            txt_user.Focus()
        End If
    End Sub

    Private Sub txt_user_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = 13 Then
            If txt_user.Text = "" Then
                MessageBox.Show("please fill the fild ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_user.Focus()
            End If
            txt_password.Focus()
        End If
    End Sub

    

    Private Sub txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = 13 Then
            If txt_password.Text = "" Then
                MessageBox.Show("please fill the fild ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Focus()
            End If
            btn_sign.Focus()
        End If
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        login_in.Show()
    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub sign_in_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class