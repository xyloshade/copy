Imports System.Data.Odbc

Public Class Frm_vet
    Dim iscollapsed As Boolean = True
    Dim con As New OdbcConnection("driver=MYSQL ODBC 5.3 ANSI Driver;server=localhost;port=3308;uid=root;pwd=;database=vet_db")

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshme()

    End Sub

    ' Open the Daily Sales form in full-screen mode
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        dailysales.Show()
    End Sub

    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        client_info.Show()
    End Sub

    ' Open the Pet Info form in full-screen mode
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pet_info.Show() ' Show the form
    End Sub

    Private Sub Txt_search_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_search.Enter

        If Txt_search.Text = "search" Then
            Txt_search.Text = ""

            Txt_search.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Txt_search_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_search.Leave
        If Txt_search.Text = "" Then
            Txt_search.Text = " search"

            Txt_search.ForeColor = Color.Silver

        End If

    End Sub

    ' Search for pets based on user input
    Private Sub Txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_search.TextChanged

        Dim da As New OdbcDataAdapter
        Dim ds As New System.Data.DataSet

        da = New OdbcDataAdapter("Select * from vet_info  where vet_id like '%" & Txt_search.Text & "' or  animal_species like '" & Txt_search.Text & "%' or '%" & Txt_search.Text & "' or  pet_name like '" & Txt_search.Text & "%' or   pet_breed like '" & Txt_search.Text & "%'or  pet_gender like '" & Txt_search.Text & "%' or pet_owner like '" & Txt_search.Text & "%' or pet_birthday like '" & Txt_search.Text & "%' ", con)
        da.Fill(ds, "vet_info") ' search items
        dgv_pets.DataSource = ds.Tables("vet_info").DefaultView
    End Sub

    ' Refresh  DataGridView with client info
    Private Sub Refreshme()
        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM vet_info"
            Using cmd As New OdbcCommand(query, con)
                Dim da As New OdbcDataAdapter(cmd)
                Dim ds As New DataSet()
                da.Fill(ds, "vet_info")

                dgv_pets.DataSource = ds.Tables("vet_info").DefaultView
                ConfigureDataGridView()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try





    End Sub

    ' Configure  DataGridView appearance
    Private Sub ConfigureDataGridView()


        dgv_pets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_pets.Refresh()
        ' Set the default font style and color for the DataGridView
        dgv_pets.DefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Regular) ' Set font to Verdana, size 12
        dgv_pets.DefaultCellStyle.ForeColor = Color.Black ' Set font color to black
        dgv_pets.DefaultCellStyle.BackColor = Color.LightGray ' Set background color to bisque

        ' Set alternate row color for better readability
        Dim alternatingStyle As New DataGridViewCellStyle()
        alternatingStyle.BackColor = Color.WhiteSmoke ' Set alternating row color to light salmon
        dgv_pets.AlternatingRowsDefaultCellStyle = alternatingStyle

        ' Set header style
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Verdana", 8, FontStyle.Bold) ' Bold font size 14
        headerStyle.ForeColor = Color.White ' Header font color
        headerStyle.BackColor = Color.Black ' Header background color

        ' Apply header style to the DataGridView
        dgv_pets.ColumnHeadersDefaultCellStyle = headerStyle




    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dialog As Integer
        dialog = MessageBox.Show("are you sure you want to exit the application?.", " Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = vbYes Then
            Me.Close()
        End If


    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DAILYSALEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        dailysales.Show()
    End Sub

    Private Sub PETMAMGEMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pet_info.Show() ' Show the form
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dialog As Integer
        dialog = MessageBox.Show("are you sure you want to exit the application?.", " Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox2_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dialog As Integer
        dialog = MessageBox.Show("are you sure you want to exit the application?.", " Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim dialog As Integer
        dialog = MessageBox.Show("are you sure you want to exit the application?.", " Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_pets_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_pets_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pets.CellContentClick

    End Sub
End Class





