Imports System.Data.Odbc
Imports System.Windows.Forms


Public Class inventory

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtItemName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescription.Focus()
        End If
    End Sub

    Private Sub txtDescription_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrice.Focus()
        End If
    End Sub

    Private Sub txtPrice_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStock.Focus()
        End If
    End Sub

    Private Sub txtStock_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtStock.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddItem.Focus()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub


    Private Sub frm_inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        Dim service_id As Integer
        Dim cmd As New OdbcCommand("SELECT IFNULL(MAX(service_id), 0) FROM service_items", con)
        service_id = cmd.ExecuteScalar

        If service_id > 0 Then
            Call get_service_id()
        Else
            txtItemID.Text = 1
        End If

        refreshMe()
    End Sub

    Private Sub get_service_id()
        Dim da As New OdbcDataAdapter("SELECT MAX(service_id) AS service_no FROM service_items", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txtItemID.Text = ds.Tables(0).Rows(0).Item("service_no") + 1
    End Sub
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvInventory.DataSource = Nothing
        isDataVisible = False
    End Sub
    Dim isDataVisible As Boolean = False

    Private Sub btnLoadInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInventory.Click

    End Sub

    Private Sub refreshMe()
        Try

            If con.State = ConnectionState.Open Then con.Close()


            con.Open()

            Dim query As String = "SELECT service_id, service_name, service_description, price, stocked, created_at, updated_at FROM service_items"
            Dim myCmd1 As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(myCmd1)
            Dim ds As New DataSet


            da.Fill(ds, "service_items")


            dgvInventory.DataSource = ds.Tables("service_items")

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvInventory.RowsDefaultCellStyle.BackColor = Drawing.Color.Azure
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Crimson


            dgvInventory.Columns("service_id").HeaderText = "Service/Item ID"
            dgvInventory.Columns("service_name").HeaderText = "Service/Item Name"
            dgvInventory.Columns("service_description").HeaderText = "Description"
            dgvInventory.Columns("price").HeaderText = "Price"
            dgvInventory.Columns("stocked").HeaderText = "Stock"
            dgvInventory.Columns("created_at").HeaderText = "Created At"
            dgvInventory.Columns("updated_at").HeaderText = "Last Updated"


            dgvInventory.Refresh()

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub




    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click

    End Sub



    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click

        txtItemName.Enabled = True
        txtDescription.Enabled = True
        txtPrice.Enabled = True
        txtStock.Enabled = True

        txtItemName.Focus()

        btnAddItem.Enabled = False
        btnEditItem.Enabled = False
        btnUpdateItem.Enabled = True
        btnDeleteItem.Enabled = True


    End Sub
    Private Sub btnUpdateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateItem.Click

    End Sub


    Private Sub dgvInventory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub



    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

    End Sub





End Class