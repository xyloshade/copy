Imports System.Data.Odbc

Public Class client_data
    Dim con As New OdbcConnection("driver=MYSQL ODBC 5.3 ANSI Driver;localhost;port=3308;uid='root';pwd=;database=vet_db")

    Private Sub dgv_pets_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_client.CellContentClick

    End Sub

    Private Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim myCmd1 As New OdbcCommand("Select * from client_info", con)
            Dim da As New OdbcDataAdapter(myCmd1)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "client_info")

            dgv_client.DataSource = ds.Tables(0)
            dgv_client.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Set the default font style and color for the DataGridView
            dgv_client.DefaultCellStyle.Font = New Font("ariel", 12, FontStyle.Regular)
            dgv_client.DefaultCellStyle.ForeColor = Color.Black
            dgv_client.DefaultCellStyle.BackColor = Color.Gray

            ' Set alternate row color for better readability

            Dim alternatingStyle As New DataGridViewCellStyle()
            alternatingStyle.BackColor = Color.WhiteSmoke
            dgv_client.AlternatingRowsDefaultCellStyle = alternatingStyle

            ' Set header style
            Dim headerStyle As New DataGridViewCellStyle()
            headerStyle.Font = New Font("ariel", 8, FontStyle.Bold)
            headerStyle.ForeColor = Color.White
            headerStyle.BackColor = Color.Black

            ' Apply header style to the DataGridView
            dgv_client.ColumnHeadersDefaultCellStyle = headerStyle

            ' Refresh the DataGridView to apply styles
            dgv_client.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub pet_data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshMe()
    End Sub

    Private Sub dgv_client_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_client.Click
        Dim i As Integer

        i = dgv_client.CurrentRow.Index
        txt_clientid.Text = dgv_client.Item(0, i).Value
        txt_fname.Text = dgv_client.Item(1, i).Value
        txt_lname.Text = dgv_client.Item(2, i).Value
        txt_contactnum.Text = dgv_client.Item(3, i).Value
        txt_address.Text = dgv_client.Item(4, i).Value
        ComboBox1.Text = dgv_client.Item(5, i).Value
        txt_zip.Text = dgv_client.Item(6, i).Value
        txt_email.Text = dgv_client.Item(7, i).Value
        txt_pets.Text = dgv_client.Item(8, i).Value
        txt_petname.Text = dgv_client.Item(9, i).Value
        txt_petname2.Text = dgv_client.Item(10, i).Value
        txt_petname3.Text = dgv_client.Item(11, i).Value
        Cmb_city.Text = dgv_client.Item(12, i).Value

        'enable txtbox

        txt_email.Enabled = False
        txt_clientid.Enabled = False
        txt_email.Enabled = False
        txt_contactnum.Enabled = False
        txt_fname.Enabled = False
        txt_lname.Enabled = False
        txt_zip.Enabled = False
        txt_pets.Enabled = False
        txt_address.Enabled = False
        ComboBox1.Enabled = False
        txt_petname.Enabled = False
        txt_petname2.Enabled = False
        txt_petname3.Enabled = False




        ' Enable buttons
        btn_edit.Enabled = True
        btn_delete.Enabled = True
        btn_update.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim cid As String = txt_clientid.Text
        Dim bt As String = txt_fname.Text.ToUpper.Trim
        Dim ba As String = txt_lname.Text.ToUpper.Trim
        Dim a As String = txt_address.Text.Trim
        Dim em As String = txt_email.Text.Trim
        Dim vc As String = ComboBox1.Text.Trim
        Dim z As String = txt_zip.Text.Trim
        Dim cn As String = txt_contactnum.Text.Trim
        Dim p As String = txt_pets.Text.Trim
        Dim pn As String = txt_petname.Text.ToUpper.Trim
        Dim pn2 As String = txt_petname2.Text.ToUpper.Trim
        Dim pn3 As String = txt_petname3.Text.ToUpper.Trim
        Dim c As String = Cmb_city.Text.Trim




        con.Close()

        Try
            con.Open()
            Dim mycmd As New OdbcCommand
            With mycmd
                .Connection = con
                .CommandText = "update client_info set client_fname = '" & bt & "', client_lname= '" & ba & "', contact_num= '" & cn & "', address ='" & a & "', barangay= '" & vc & "', zip= '" & z & "', email= '" & em & "' ,pet_num= '" & p & "' , pet_name= '" & pn & "',pet_name2= '" & pn2 & "',pet_name3= '" & pn3 & "',city='" & c & "' where client_id= '" & cid & "'"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Client information updated", "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields
            txt_address.Clear()
            txt_clientid.Clear()
            txt_email.Clear()
            txt_lname.Clear()
            txt_contactnum.Clear()
            txt_fname.Clear()
            txt_pets.Clear()
            txt_zip.Clear()
            txt_petname.Clear()



            refreshMe()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        ' Enable fields for editing
        txt_address.Enabled = True
        txt_email.Enabled = True
        txt_clientid.Enabled = True
        txt_contactnum.Enabled = True
        txt_fname.Enabled = True
        txt_zip.Enabled = True
        ComboBox1.Enabled = True
        txt_pets.Enabled = True
        txt_lname.Enabled = True
        txt_petname.Enabled = True
        txt_petname2.Enabled = True
        txt_petname3.Enabled = True
        txt_fname.Focus()

        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_update.Enabled = True
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim result2 As DialogResult
        Dim bid1 As String = txt_clientid.Text

        result2 = MessageBox.Show("Are you sure you want to delete the record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result2 = Windows.Forms.DialogResult.Yes Then
            Try
                con.Open()
                Dim mycmd As New OdbcCommand
                With mycmd
                    .Connection = con
                    .CommandText = "delete from client_info where client_id = '" & bid1 & "'"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Information deleted", "Information Client", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

   
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
