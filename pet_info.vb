Imports System.Windows.Forms
Imports System.Data.Odbc
Public Class pet_info
    Dim gender As String
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        connectMe()

        Dim vid As Integer
        Dim cmd As New OdbcCommand("Select ifnull(max(vet_id),0) vet_no from vet_info", con)
        vid = cmd.ExecuteScalar

        If vid > 0 Then
            Call get_vet_id()
        Else
            txt_vid.Text = 1
        End If
    End Sub
    Private Sub get_vet_id()
        Dim da As New OdbcDataAdapter("select max(vet_id) vet_no from vet_info", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)


        Txt_vid.Text = ds.Tables(0).Rows(0).Item("vet_no") + 1

    End Sub




    Private Sub Txt_petname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_petname.KeyDown

        If e.KeyCode = 13 Then
            If txt_petname.Text = "" Then
                MessageBox.Show("enter petname", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_petname.Focus()
            Else
                Txt_petowners.Focus()

            End If
        End If
    End Sub


    Private Sub txt_ownersname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_petowners.KeyDown
        If e.KeyCode = 13 Then
            If Txt_petowners.Text = "" Then
                MessageBox.Show("enter owner name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_petowners.Focus()
            Else
                txt_age.Focus()

            End If
        End If

    End Sub

    Private Sub Txt_age_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_age.KeyDown
        If e.KeyCode = 13 Then
            If Txt_age.Text = "" Then
                MessageBox.Show("enter age of pet", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_age.Focus()
            Else
                Txt_color.Focus()

            End If
        End If


    End Sub

    Private Sub Txt_color_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_color.KeyDown

        If e.KeyCode = 13 Then
            If Txt_color.Text = "" Then
                MessageBox.Show("enter animal color", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_color.Focus()
            Else
                RadioButton1.Focus()
                RadioButton2.Focus()

            End If
        End If
    End Sub

    Private Sub txt_species_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_species.KeyDown
        If e.KeyCode = 13 Then
            If txt_species.Text = "" Then
                MessageBox.Show("enter pet species", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_species.Focus()
            Else
                Txt_breed.Focus()

            End If
        End If
    End Sub

    Private Sub Txt_breed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_breed.KeyDown
        If e.KeyCode = 13 Then
            If Txt_breed.Text = "" Then
                MessageBox.Show("enter pet breed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_breed.Focus()
            Else
                dtpbd.Focus()

            End If
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim vid As String
        Dim s As String
        Dim ow As String
        Dim age As String
        Dim c As String
        Dim p As String
        Dim br As String
        Dim bd As String
        Dim la As String
        Dim gender As String

        gender = ""

        vid = txt_vid.Text
        p = txt_petname.Text.ToUpper.Trim
        ow = Txt_petowners.Text.ToUpper.Trim
        age = txt_age.Text.Trim
        br = Txt_breed.Text.ToUpper.Trim
        c = txt_color.Text.ToUpper.Trim
        s = Txt_species.Text.ToUpper.Trim

        If RadioButton1.Checked Then
            gender = "FEMALE"
        ElseIf RadioButton2.Checked Then
            gender = "MALE"
        End If


        bd = dtpbd.Text.Trim
        la = dtpsession.Text.Trim

        'MessageBox.Show(gender)

        con.Close()

        Try
            con.Open()
            With mycmd
                .Connection = con
                .CommandText = "insert into vet_info values('" & vid & "','" & p & "','" & age & "','" & c & "','" & s & "','" & br & "','" & gender & "','" & bd & "','" & la & "','" & ow & "')"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("your information  added", "add database", MessageBoxButtons.OK, MessageBoxIcon.Information)



            txt_petname.Focus()
            Call get_vet_id()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try


        txt_age.Clear()
        Txt_breed.Clear()
        txt_color.Clear()
        txt_petname.Clear()
        Txt_petowners.Clear()
        txt_vid.Clear()
        Txt_species.Clear()


    End Sub




    Private Sub RadioButton1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioButton1.KeyDown

        gender = "female"


    End Sub

    Private Sub RadioButton2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioButton2.KeyDown

        gender = "male"

    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpbd.KeyDown
        If e.KeyCode = 13 Then
            If dtpbd.Text = "" Then
                MessageBox.Show("enter pet brithday", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpbd.Focus()
            Else
                dtpsession.Focus()

            End If
        End If
    End Sub

    Private Sub DateTimePicker2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpsession.KeyDown
        If e.KeyCode = 13 Then
            If dtpsession.Text = "" Then
                MessageBox.Show("enter pet last visit", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpsession.Focus()
            Else
                btn_add.Focus()

            End If
        End If
    End Sub

    Private Sub Btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_view.Click
        Me.Hide()
        pet_view.Show()

    End Sub

   

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class