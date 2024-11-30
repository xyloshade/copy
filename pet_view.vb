
Imports System.Windows.Forms
Imports System.Data.Odbc


Public Class pet_view
    Dim gender As String
   
    

   
Private Sub pet_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshMe()
End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        'edit enable  txtbox
        txt_age.Enabled = True
        txt_breed.Enabled = True
        txt_color.Enabled = True
        txt_petname.Enabled = True
        txt_species.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        txt_petowner.Enabled = True
        FemaleRadio.Enabled = True
        MaleRadio.Enabled = True


        txt_petname.Focus()

        'edit enable buttons
        btn_edit.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True



    End Sub

    Private Sub refreshMe()
        con.Close()


        Try
            con.Open()

            Dim myCmd1 As New OdbcCommand("Select * from vet_info", con)
            Dim da As New OdbcDataAdapter(myCmd1)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "vet_info")

            dgv_petview.DataSource = ds.Tables(0)
            dgv_petview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgv_petview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_petview.Refresh()
            ' Set the default font style and color for the DataGridView
            dgv_petview.DefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Regular)
            dgv_petview.DefaultCellStyle.ForeColor = Color.Black
            dgv_petview.DefaultCellStyle.BackColor = Color.Bisque

            ' Set alternate row color for better readability
            Dim alternatingStyle As New DataGridViewCellStyle()
            alternatingStyle.BackColor = Color.LightSalmon
            dgv_petview.AlternatingRowsDefaultCellStyle = alternatingStyle

            ' Set header style
            Dim headerStyle As New DataGridViewCellStyle()
            headerStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
            headerStyle.ForeColor = Color.White
            headerStyle.BackColor = Color.Black

            ' Apply header style to the DataGridView
            dgv_petview.ColumnHeadersDefaultCellStyle = headerStyle
            dgv_petview.Refresh()
            dgv_petview.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            con.Close()
        End Try

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim vid As String
        Dim ag As String
        Dim c As String
        Dim s As String
        Dim p As String
        Dim br As String
        Dim bd As String
        Dim lv As String
        Dim ow As String
        'dim cl as integer'

        vid = txt_vid.Text
        ag = txt_age.Text.ToUpper.Trim
        c = txt_color.Text.ToUpper.Trim
        s = txt_species.Text.Trim
        p = txt_petname.Text.Trim
        br = txt_breed.Text.Trim

        If FemaleRadio.Checked Then
            gender = "FEMALE"
        ElseIf MaleRadio.Checked Then
            gender = "MALE"
        End If

        bd = DateTimePicker1.Text.Trim
        lv = DateTimePicker2.Text.Trim
        ow = txt_petowner.Text.Trim


        'c = txt_copies.text.trim'
        ' cl = CInt(c)'
        con.Close()

        Try
            con.Open()
            With mycmd
                .Connection = con
                .CommandText = "update  vet_info set vet_id = '" & txt_vid.Text & "',pet_name = '" & txt_petname.Text & "',pet_age = '" & txt_age.Text & "',pet_color= '" & txt_color.Text & "' ,animal_species ='" & txt_species.Text & "', pet_breed= '" & txt_breed.Text & "', pet_gender= '" & gender & "', pet_birthday= '" & bd & "' ,pet_session= '" & lv & "',pet_owner= '" & txt_petowner.Text & "', where vet_id= '" & vid & "'"
                .ExecuteNonQuery()
                .ExecuteNonQuery()
            End With
            MessageBox.Show("information has been updated", " update information", MessageBoxButtons.OK, MessageBoxIcon.Information)


           

            refreshMe()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dgv_petview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_petview.CellContentClick


        txt_vid.Text = dgv_petview.Item("vet_id", dgv_petview.CurrentRow.Index).Value
        txt_petname.Text = dgv_petview.Item("pet_name", dgv_petview.CurrentRow.Index).Value
        txt_age.Text = dgv_petview.Item("pet_age", dgv_petview.CurrentRow.Index).Value
        txt_color.Text = dgv_petview.Item("pet_color", dgv_petview.CurrentRow.Index).Value
        txt_species.Text = dgv_petview.Item("animal_species", dgv_petview.CurrentRow.Index).Value
        txt_breed.Text = dgv_petview.Item("pet_breed", dgv_petview.CurrentRow.Index).Value

        If dgv_petview.Item("pet_gender", dgv_petview.CurrentRow.Index).Value = "male" Then
            MaleRadio.Checked = True
            FemaleRadio.Checked = False
        ElseIf dgv_petview.Item("pet_gender", dgv_petview.CurrentRow.Index).Value = "female" Then
            MaleRadio.Checked = False
            FemaleRadio.Checked = True
        End If

        DateTimePicker1.Value = dgv_petview.Item("pet_birthday", dgv_petview.CurrentRow.Index).Value
        DateTimePicker2.Value = dgv_petview.Item("pet_session", dgv_petview.CurrentRow.Index).Value
        txt_petowner.Text = dgv_petview.Item("pet_owner", dgv_petview.CurrentRow.Index).Value







        'enable txtbox

        txt_petname.Enabled = False
        txt_age.Enabled = False
        txt_color.Enabled = False
        txt_species.Enabled = False
        txt_breed.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        txt_petowner.Enabled = False
        MaleRadio.Enabled = False
        FemaleRadio.Enabled = False



        'enabled button 

        btn_edit.Enabled = True
        btn_delete.Enabled = True
        btn_update.Enabled = False
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim result2 As New DialogResult
        Dim bid1 As String

        bid1 = txt_vid.Text

        connectMe()

        result2 = MessageBox.Show(" are you sure you want to delete the record?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result2 = Windows.Forms.DialogResult.Yes Then
            With mycmd
                .Connection = con
                .CommandText = "delete from vet_info where vet_id = '" & bid1 & "'"
                .ExecuteNonQuery()
            End With
            MessageBox.Show(" record deleted", "delete recods", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FemaleRadio.CheckedChanged
        gender = "female"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleRadio.CheckedChanged
        gender = "male"
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

 

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class