<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dailysales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dailysales))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSalesID = New System.Windows.Forms.TextBox
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker
        Me.txtServiceIncome = New System.Windows.Forms.TextBox
        Me.txtProductIncome = New System.Windows.Forms.TextBox
        Me.txtDiscounts = New System.Windows.Forms.TextBox
        Me.txtRefunds = New System.Windows.Forms.TextBox
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox
        Me.btnAddSales = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtTotalRevenue = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.dgv_dailysales = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Daily_Sales = New System.Windows.Forms.GroupBox
        Me.cmbDiscountType = New System.Windows.Forms.ComboBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        CType(Me.dgv_dailysales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Daily_Sales.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SERVICE INCOME"
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PRODUCT INCOME"
        Me.Label5.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAYMENT METHOD"
        Me.Label2.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DISCOUNT"
        Me.Label6.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALES DATE"
        Me.Label1.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(33, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = " REFUND"
        Me.Label7.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALES ID"
        Me.Label3.UseWaitCursor = True
        '
        'txtSalesID
        '
        Me.txtSalesID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesID.Location = New System.Drawing.Point(233, 68)
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(255, 27)
        Me.txtSalesID.TabIndex = 7
        Me.txtSalesID.UseWaitCursor = True
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSaleDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleDate.Location = New System.Drawing.Point(233, 111)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(255, 27)
        Me.dtpSaleDate.TabIndex = 8
        Me.dtpSaleDate.UseWaitCursor = True
        '
        'txtServiceIncome
        '
        Me.txtServiceIncome.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceIncome.Location = New System.Drawing.Point(233, 193)
        Me.txtServiceIncome.Name = "txtServiceIncome"
        Me.txtServiceIncome.Size = New System.Drawing.Size(255, 27)
        Me.txtServiceIncome.TabIndex = 10
        Me.txtServiceIncome.UseWaitCursor = True
        '
        'txtProductIncome
        '
        Me.txtProductIncome.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductIncome.Location = New System.Drawing.Point(233, 232)
        Me.txtProductIncome.Name = "txtProductIncome"
        Me.txtProductIncome.Size = New System.Drawing.Size(255, 27)
        Me.txtProductIncome.TabIndex = 11
        Me.txtProductIncome.UseWaitCursor = True
        '
        'txtDiscounts
        '
        Me.txtDiscounts.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscounts.Location = New System.Drawing.Point(233, 276)
        Me.txtDiscounts.Name = "txtDiscounts"
        Me.txtDiscounts.Size = New System.Drawing.Size(125, 27)
        Me.txtDiscounts.TabIndex = 12
        Me.txtDiscounts.UseWaitCursor = True
        '
        'txtRefunds
        '
        Me.txtRefunds.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefunds.Location = New System.Drawing.Point(233, 319)
        Me.txtRefunds.Name = "txtRefunds"
        Me.txtRefunds.Size = New System.Drawing.Size(255, 27)
        Me.txtRefunds.TabIndex = 13
        Me.txtRefunds.UseWaitCursor = True
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"G CASH", "CASH", "CARD"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(233, 154)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(255, 26)
        Me.cmbPaymentMethod.TabIndex = 14
        Me.cmbPaymentMethod.Text = "           ----SELECT----"
        Me.cmbPaymentMethod.UseWaitCursor = True
        '
        'btnAddSales
        '
        Me.btnAddSales.BackColor = System.Drawing.Color.Bisque
        Me.btnAddSales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSales.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnAddSales.Image = CType(resources.GetObject("btnAddSales.Image"), System.Drawing.Image)
        Me.btnAddSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSales.Location = New System.Drawing.Point(180, 485)
        Me.btnAddSales.Name = "btnAddSales"
        Me.btnAddSales.Size = New System.Drawing.Size(191, 50)
        Me.btnAddSales.TabIndex = 15
        Me.btnAddSales.Text = "SAVE"
        Me.btnAddSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSales.UseVisualStyleBackColor = False
        Me.btnAddSales.UseWaitCursor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Bisque
        Me.btnCalculate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnCalculate.Location = New System.Drawing.Point(367, 352)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(124, 49)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "TOTAL"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.UseVisualStyleBackColor = False
        Me.btnCalculate.UseWaitCursor = True
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRevenue.Location = New System.Drawing.Point(233, 362)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.Size = New System.Drawing.Size(125, 27)
        Me.txtTotalRevenue.TabIndex = 17
        Me.txtTotalRevenue.UseWaitCursor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(34, 366)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(137, 23)
        Me.label8.TabIndex = 18
        Me.label8.Text = "TOTAL REVENUE"
        Me.label8.UseWaitCursor = True
        '
        'dgv_dailysales
        '
        Me.dgv_dailysales.AllowUserToAddRows = False
        Me.dgv_dailysales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_dailysales.CausesValidation = False
        Me.dgv_dailysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dailysales.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.dgv_dailysales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_dailysales.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgv_dailysales.Location = New System.Drawing.Point(513, 51)
        Me.dgv_dailysales.Name = "dgv_dailysales"
        Me.dgv_dailysales.Size = New System.Drawing.Size(763, 467)
        Me.dgv_dailysales.TabIndex = 19
        Me.dgv_dailysales.UseWaitCursor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Bisque
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnUpdate.Location = New System.Drawing.Point(344, 433)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(147, 46)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.UseWaitCursor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Bisque
        Me.btnEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(59, 433)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(134, 43)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.UseWaitCursor = True
        '
        'Daily_Sales
        '
        Me.Daily_Sales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Daily_Sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Daily_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Daily_Sales.Controls.Add(Me.cmbDiscountType)
        Me.Daily_Sales.Controls.Add(Me.btnDelete)
        Me.Daily_Sales.Controls.Add(Me.dgv_dailysales)
        Me.Daily_Sales.Controls.Add(Me.btnEdit)
        Me.Daily_Sales.Controls.Add(Me.btnUpdate)
        Me.Daily_Sales.Controls.Add(Me.label8)
        Me.Daily_Sales.Controls.Add(Me.txtTotalRevenue)
        Me.Daily_Sales.Controls.Add(Me.btnCalculate)
        Me.Daily_Sales.Controls.Add(Me.btnAddSales)
        Me.Daily_Sales.Controls.Add(Me.cmbPaymentMethod)
        Me.Daily_Sales.Controls.Add(Me.txtRefunds)
        Me.Daily_Sales.Controls.Add(Me.txtDiscounts)
        Me.Daily_Sales.Controls.Add(Me.txtProductIncome)
        Me.Daily_Sales.Controls.Add(Me.txtServiceIncome)
        Me.Daily_Sales.Controls.Add(Me.dtpSaleDate)
        Me.Daily_Sales.Controls.Add(Me.txtSalesID)
        Me.Daily_Sales.Controls.Add(Me.Label3)
        Me.Daily_Sales.Controls.Add(Me.Label7)
        Me.Daily_Sales.Controls.Add(Me.Label1)
        Me.Daily_Sales.Controls.Add(Me.Label6)
        Me.Daily_Sales.Controls.Add(Me.Label2)
        Me.Daily_Sales.Controls.Add(Me.Label5)
        Me.Daily_Sales.Controls.Add(Me.Label4)
        Me.Daily_Sales.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Daily_Sales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daily_Sales.ForeColor = System.Drawing.Color.White
        Me.Daily_Sales.Location = New System.Drawing.Point(0, 28)
        Me.Daily_Sales.Name = "Daily_Sales"
        Me.Daily_Sales.Size = New System.Drawing.Size(1300, 737)
        Me.Daily_Sales.TabIndex = 7
        Me.Daily_Sales.TabStop = False
        Me.Daily_Sales.Text = "DAILY SALES"
        Me.Daily_Sales.UseWaitCursor = True
        '
        'cmbDiscountType
        '
        Me.cmbDiscountType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiscountType.FormattingEnabled = True
        Me.cmbDiscountType.Location = New System.Drawing.Point(367, 280)
        Me.cmbDiscountType.Name = "cmbDiscountType"
        Me.cmbDiscountType.Size = New System.Drawing.Size(121, 21)
        Me.cmbDiscountType.TabIndex = 23
        Me.cmbDiscountType.UseWaitCursor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Bisque
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSalmon
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(199, 433)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(139, 46)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.UseWaitCursor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.UseWaitCursor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'dailysales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.BG5_optimized1
        Me.ClientSize = New System.Drawing.Size(1300, 752)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Daily_Sales)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dailysales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.dgv_dailysales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Daily_Sales.ResumeLayout(False)
        Me.Daily_Sales.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSalesID As System.Windows.Forms.TextBox
    Friend WithEvents dtpSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtServiceIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtProductIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscounts As System.Windows.Forms.TextBox
    Friend WithEvents txtRefunds As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSales As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtTotalRevenue As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_dailysales As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Daily_Sales As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cmbDiscountType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
