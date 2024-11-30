Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class login_in

    Dim con As New OdbcConnection("driver=MYSQL ODBC 5.3 ANSI Driver;localhost;port=3308;uid ='root';pwd=;database=vet_db")
    Dim mycmd As New OdbcCommand
    Dim readuser As OdbcDataReader

   

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sign_in.Show()
    End Sub

    Private Sub login_in_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_uname.Show()
        btn_login.Enabled = True
        txt_pword.UseSystemPasswordChar = True
        txt_uname.Focus()
    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If txt_pword.UseSystemPasswordChar = True Then

            'show password
            txt_pword.UseSystemPasswordChar = False

        Else
            'hide password
            txt_pword.UseSystemPasswordChar = True
        End If

    End Sub

    
    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_uname.Text = "" And txt_pword.Text = "" Then
            MessageBox.Show("fill up username and password should not be blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_uname.Focus()

            btn_login.Enabled = False

        ElseIf txt_uname.Text = "" Or txt_pword.Text = "" Then
            MessageBox.Show("user name or password should not be  blank", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txt_uname.Text = ""
            txt_pword.Text = ""
            txt_uname.Focus()
            btn_login.Enabled = False

        Else
            connectMe()
            con.Close()
            Try
                con.Open()


                With mycmd
                    .Connection = con
                    .CommandText = "select * from login_tbl where uname ='" & txt_uname.Text & "' and pword =MD5('" & txt_pword.Text & "')"

                    .ExecuteNonQuery()
                End With

                readuser = mycmd.ExecuteReader
                If readuser.HasRows Then
                    readuser.Read()
                    username = txt_uname.Text
                    username1 = readuser!fname
                    Dim mainmenu As New Frm_vet
                    Me.Hide()
                    mainmenu.Show()
                Else
                    MessageBox.Show("username and password did not match ", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_uname.Text = ""
                    txt_pword.Text = ""
                    txt_uname.Focus()
                    btn_login.Enabled = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub txt_uname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_uname.KeyDown
        If e.KeyCode = 13 Then
            If txt_uname.Text = "" Then
                MessageBox.Show("fill username", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_uname.Focus()
            Else
                txt_pword.Focus()

            End If
        End If
    End Sub

    Private Sub txt_pword_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pword.KeyDown
        If e.KeyCode = 13 Then
            If txt_pword.Text = "" Then
                MessageBox.Show("fill password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pword.Focus()
            Else
                btn_login.Focus()

            End If
        End If
    End Sub

   
End Class
