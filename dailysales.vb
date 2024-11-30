Imports System.Data.Odbc

Public Class dailysales
    ' Variables for storing input values
    Private serviceIncome As Decimal
    Private productIncome As Decimal
    Private discounts As Decimal
    Private refunds As Decimal
    Private totalRevenue As Decimal ' Total Revenue
    Private selectedSalesID As String = Nothing ' Holds the Sales ID for editing or deleting

    ' Database connection variable
    Private con As OdbcConnection

    Private Sub dailysales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeConnection()
        InitializeForm()
        RefreshDataGridView() ' Refresh the DataGridView when the form loads
    End Sub

    ' Initialize the database connection
    Private Sub InitializeConnection()
        Try
            con = New OdbcConnection(Mod_publicvariables.constring)
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Error initializing database connection: " & ex.Message)
        End Try
    End Sub

    ' Initialize the form controls
    Private Sub InitializeForm()
        txtSalesID.Text = GenerateSalesID() ' Set the Sales ID
        txtSalesID.ReadOnly = True ' Make txtSalesID read-only
        InitializePaymentMethodComboBox()
        InitializeDiscountTypeComboBox() ' Initialize discount type combo box
        ResetTotalRevenueDisplay()
        txtServiceIncome.Focus()

        ' Hook up event handlers
        AddHandler btnCalculate.Click, AddressOf btnCalculate_Click
        AddHandler btnAddSales.Click, AddressOf btnAddSales_Click
        
        AddHandler btnDelete.Click, AddressOf btnDelete_Click
    End Sub

    Private Sub InitializeDiscountTypeComboBox()
        With cmbDiscountType
            .Items.Clear()
            .Items.Add("Select Discount Type") ' Placeholder
            .Items.Add("Service")
            .Items.Add("Product")
            .Items.Add("Both")
            .SelectedIndex = 0 ' Default placeholder selection
            .DropDownStyle = ComboBoxStyle.DropDownList ' Force selection from list
        End With
    End Sub


    ' Ensure that cmbDiscountType is declared and initialized correctly
    Private Sub InitializecmbDiscountType()
        ' Example of populating the ComboBox with discount types
        cmbDiscountType.Items.Clear() ' Clear any existing items
        cmbDiscountType.Items.Add("No Discount")
        cmbDiscountType.Items.Add("Percentage Discount")
        cmbDiscountType.Items.Add("Fixed Amount Discount")
        cmbDiscountType.SelectedIndex = 0 ' Optionally select the first item
    End Sub



    ' Method to generate a unique Sales ID based on the count of existing records
    Private Function GenerateSalesID() As String
        Dim salesID As Integer = 1 ' Start from 1
        Try
            Using cmd As New OdbcCommand("SELECT COUNT(*) FROM daily_sales", con)
                salesID = Convert.ToInt32(cmd.ExecuteScalar()) + 1 ' Increment by 1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Sales ID: " & ex.Message)
        End Try
        Return salesID.ToString() ' Return as a string
    End Function

    ' Initialize the payment method ComboBox
    Private Sub InitializePaymentMethodComboBox()
        With cmbPaymentMethod
            .Items.Clear() ' Clear existing items
            .Items.Add("Select Payment Method") ' Placeholder
            .Items.Add("GCash")
            .Items.Add("Cash")
            .Items.Add("Card")
            .SelectedIndex = 0 ' Set initial index to show the placeholder
            .DropDownStyle = ComboBoxStyle.DropDownList ' Restrict to selection only
        End With
    End Sub
    

    ' Calculate Total Revenue
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidateInput() Then
            Dim discountAppliedToService As Decimal = 0
            Dim discountAppliedToProduct As Decimal = 0

            ' Convert discounts to a percentage if it's provided as a percentage
            Dim discountValue As Decimal = discounts / 100

            ' Check which discount type is selected
            Select Case cmbDiscountType.SelectedItem.ToString()
                Case "Service"
                    discountAppliedToService = serviceIncome * discountValue ' Apply percentage to service income
                    discountAppliedToProduct = 0 ' No discount on product
                Case "Product"
                    discountAppliedToProduct = productIncome * discountValue ' Apply percentage to product income
                    discountAppliedToService = 0 ' No discount on service
                Case "Both"
                    ' Apply the discount equally as a percentage of both incomes
                    discountAppliedToService = serviceIncome * discountValue
                    discountAppliedToProduct = productIncome * discountValue
                Case Else
                    MessageBox.Show("Please select a valid discount type.")
                    Return ' Exit the calculation if no valid type is selected
            End Select

            ' Calculate Total Revenue based on the discount application
            totalRevenue = (serviceIncome - discountAppliedToService) + (productIncome - discountAppliedToProduct) - refunds
            txtTotalRevenue.Text = "₱" & totalRevenue.ToString("F2") ' Format as Peso
        End If
    End Sub





    ' Validate input fields and parse values
    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True

        ' Validate Service Income
        isValid = Decimal.TryParse(txtServiceIncome.Text, serviceIncome) AndAlso isValid

        ' Validate Product Income
        isValid = Decimal.TryParse(txtProductIncome.Text, productIncome) AndAlso isValid

        ' Validate Discounts
        discounts = If(String.IsNullOrEmpty(txtDiscounts.Text.Trim()), 0, ValidateDecimal(txtDiscounts.Text))

        ' Validate Refunds
        refunds = If(String.IsNullOrEmpty(txtRefunds.Text.Trim()), 0, ValidateDecimal(txtRefunds.Text))

        ' Ensure a valid discount type is selected
        If cmbDiscountType.SelectedIndex = 0 Then
            MessageBox.Show("Please select a discount type (Service, Product, or Both).")
            isValid = False
        End If

        Return isValid AndAlso discounts >= 0 AndAlso refunds >= 0
    End Function



    ' Helper function to validate decimal input
    Private Function ValidateDecimal(ByVal value As String) As Decimal
        Dim result As Decimal
        If Decimal.TryParse(value, result) Then
            Return result
        Else
            MessageBox.Show("Invalid decimal value: " & value)
            Return 0
        End If
    End Function

    ' Handle Enter key for moving focus to the next control
    Private Sub Control_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtServiceIncome.KeyDown, txtProductIncome.KeyDown, txtDiscounts.KeyDown, txtRefunds.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(CType(sender, Control), True, True, True, True)
        End If
    End Sub

    ' Allow only numeric input
    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtServiceIncome.KeyPress, txtProductIncome.KeyPress, txtDiscounts.KeyPress, txtRefunds.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    ' Reset Total Revenue display
    Private Sub ResetTotalRevenueDisplay()
        txtTotalRevenue.Text = "₱0.00" ' Initial display as Peso format
        txtTotalRevenue.ReadOnly = True ' Make it read-only
    End Sub

    ' Clear input fields
    Private Sub ClearInputs()
        txtSalesID.Text = GenerateSalesID() ' Regenerate Sales ID
        txtServiceIncome.Clear()
        txtProductIncome.Clear()
        txtDiscounts.Clear()
        txtRefunds.Clear()
        ResetTotalRevenueDisplay() ' Reset Total Revenue
        cmbPaymentMethod.SelectedIndex = 0 ' Reset to placeholder
        dtpSaleDate.Value = DateTime.Now ' Set to the current date
    End Sub

    ' Add sales to the database
    Private Sub btnAddSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSales.Click
        If ValidateInput() AndAlso cmbPaymentMethod.SelectedIndex > 0 Then
            Try
                Dim query As String = "INSERT INTO daily_sales (service_income, product_income, discounts, refunds, total_revenue, payment_method, sale_date) VALUES (?, ?, ?, ?, ?, ?, ?)"

                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("service_income", serviceIncome)
                    cmd.Parameters.AddWithValue("product_income", productIncome)
                    cmd.Parameters.AddWithValue("discounts", discounts)
                    cmd.Parameters.AddWithValue("refunds", refunds)
                    cmd.Parameters.AddWithValue("total_revenue", totalRevenue) ' Add Total Revenue to the database
                    cmd.Parameters.AddWithValue("payment_method", cmbPaymentMethod.Text.Trim())
                    cmd.Parameters.AddWithValue("sale_date", dtpSaleDate.Value)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sales record added successfully.")
                End Using

                ClearInputs() ' Clear input fields after adding sales
                RefreshDataGridView() ' Refresh the DataGridView after adding sales
            Catch ex As OdbcException
                MessageBox.Show("Error adding sales record: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message)
            End Try
        Else

        End If
    End Sub

    Private Sub RefreshDataGridView()
        Try
            Dim myCmd1 As New OdbcCommand("SELECT * FROM daily_sales", con)
            Dim da As New OdbcDataAdapter(myCmd1)
            Dim ds As New DataSet()

            da.Fill(ds, "daily_sales")

            dgv_dailysales.DataSource = ds.Tables(0) ' Set the DataSource to the DataTable
            dgv_dailysales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Auto-size columns

            ' Set the default font style and color for the DataGridView
            dgv_dailysales.DefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Regular) ' Set font to Verdana, size 12
            dgv_dailysales.DefaultCellStyle.ForeColor = Color.Black ' Set font color to black
            dgv_dailysales.DefaultCellStyle.BackColor = Color.Gray ' Set background color to bisque

            ' Set alternate row color for better readability
            Dim alternatingStyle As New DataGridViewCellStyle()
            alternatingStyle.BackColor = Color.WhiteSmoke ' Set alternating row color to light salmon
            dgv_dailysales.AlternatingRowsDefaultCellStyle = alternatingStyle

            ' Set header style
            Dim headerStyle As New DataGridViewCellStyle()
            headerStyle.Font = New Font("Verdana", 8, FontStyle.Bold) ' Bold font size 14
            headerStyle.ForeColor = Color.White ' Header font color
            headerStyle.BackColor = Color.Black ' Header background color

            ' Apply header style to the DataGridView
            dgv_dailysales.ColumnHeadersDefaultCellStyle = headerStyle

            ' Modify header text: Remove underscores and convert to uppercase
            For Each column As DataGridViewColumn In dgv_dailysales.Columns
                column.HeaderText = column.HeaderText.Replace("_", " ").ToUpper() ' Replace underscores with space and convert to uppercase
            Next

            ' Disable editing for the Sales ID column in the DataGridView
            dgv_dailysales.Columns("sales_id").ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Error refreshing sales data: " & ex.Message)
        End Try
    End Sub



    ' Handle Delete Button Click: Delete the selected sales record
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If dgv_dailysales.SelectedRows.Count > 0 Then
            selectedSalesID = dgv_dailysales.SelectedRows(0).Cells("sales_id").Value.ToString() ' Get the selected Sales ID

            ' Ask for confirmation before deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected sales record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM daily_sales WHERE sales_id = ?"
                    Using cmd As New OdbcCommand(query, con)
                        cmd.Parameters.AddWithValue("sales_id", selectedSalesID) ' Specify the record to delete
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Sales record deleted successfully.")

                        ClearInputs() ' Clear input fields after deleting sales
                        RefreshDataGridView() ' Refresh the DataGridView after deleting sales
                        selectedSalesID = Nothing ' Reset the selected Sales ID
                    End Using
                Catch ex As OdbcException
                    MessageBox.Show("Error deleting sales record: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An unexpected error occurred: " & ex.Message)
                End Try
            End If
        Else

        End If
    End Sub


    ' Handle Form Closing event
    Private Sub dailysales_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        
    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        Frm_vet.Show()
    End Sub

   
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ' Enable the textboxes and combobox for editing
        txtServiceIncome.Enabled = True
        txtProductIncome.Enabled = True
        txtDiscounts.Enabled = True
        txtRefunds.Enabled = True
        cmbPaymentMethod.Enabled = True
        dtpSaleDate.Enabled = True
        txtTotalRevenue.Enabled = True

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If ValidateInput() AndAlso Not String.IsNullOrEmpty(selectedSalesID) Then
            Try
                Dim query As String = "UPDATE daily_sales SET service_income = ?, product_income = ?, discounts = ?, refunds = ?, total_revenue = ?, payment_method = ?, sale_date = ? WHERE sales_id = ?"

                Using cmd As New OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("service_income", serviceIncome)
                    cmd.Parameters.AddWithValue("product_income", productIncome)
                    cmd.Parameters.AddWithValue("discounts", discounts)
                    cmd.Parameters.AddWithValue("refunds", refunds)
                    cmd.Parameters.AddWithValue("total_revenue", totalRevenue)
                    cmd.Parameters.AddWithValue("payment_method", cmbPaymentMethod.Text.Trim())
                    cmd.Parameters.AddWithValue("sale_date", dtpSaleDate.Value)
                    cmd.Parameters.AddWithValue("sales_id", selectedSalesID) ' Specify which record to update

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sales record updated successfully.")

                    ClearInputs() ' Clear input fields after updating sales
                    RefreshDataGridView() ' Refresh the DataGridView after updating sales
                    selectedSalesID = Nothing ' Reset the selected Sales ID
                End Using
            Catch ex As OdbcException
                MessageBox.Show("Error updating sales record: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message)
            End Try
        Else

        End If

        txtSalesID.Clear()
        txtDiscounts.Clear()
        txtServiceIncome.Clear()
        txtRefunds.Clear()
        txtTotalRevenue.Clear()








    End Sub

  
    Private Sub dgv_dailysales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_dailysales.CellContentClick
        ' Ensure the double-click is on a valid row
        If e.RowIndex >= 0 Then
            ' Get the selected Sales ID
            selectedSalesID = dgv_dailysales.Rows(e.RowIndex).Cells("sales_id").Value.ToString()

            'Load the selected record into input fields
            txtSalesID.Text = selectedSalesID
            txtServiceIncome.Text = dgv_dailysales.Rows(e.RowIndex).Cells("service_income").Value.ToString()
            txtProductIncome.Text = dgv_dailysales.Rows(e.RowIndex).Cells("product_income").Value.ToString()
            txtDiscounts.Text = dgv_dailysales.Rows(e.RowIndex).Cells("discounts").Value.ToString()
            txtRefunds.Text = dgv_dailysales.Rows(e.RowIndex).Cells("refunds").Value.ToString()
            cmbPaymentMethod.Text = dgv_dailysales.Rows(e.RowIndex).Cells("payment_method").Value.ToString()
            dtpSaleDate.Value = dgv_dailysales.Rows(e.RowIndex).Cells("sale_date").Value

            ' Recalculate the total revenue
            totalRevenue = (Decimal.Parse(txtServiceIncome.Text) + Decimal.Parse(txtProductIncome.Text)) - (Decimal.Parse(txtDiscounts.Text) + Decimal.Parse(txtRefunds.Text))
            txtTotalRevenue.Text = "₱" & totalRevenue.ToString("F2")

            ' Disable the textboxes and combobox so they cannot be edited
            txtServiceIncome.Enabled = False
            txtProductIncome.Enabled = False
            txtDiscounts.Enabled = False
            txtRefunds.Enabled = False
            cmbPaymentMethod.Enabled = False
            dtpSaleDate.Enabled = False
            txtTotalRevenue.Enabled = False
        End If


    End Sub

    Private Sub Daily_Sales_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Daily_Sales.Enter

    End Sub

    Private Sub txtSalesID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalesID.TextChanged

    End Sub
End Class
