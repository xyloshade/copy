<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
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
        Me.btnUpdateItem = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItemID = New System.Windows.Forms.TextBox
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnEditItem = New System.Windows.Forms.Button
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.btnLoadInventory = New System.Windows.Forms.Button
        Me.dgvInventory = New System.Windows.Forms.DataGridView
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.txtLastUpdated = New System.Windows.Forms.TextBox
        Me.txtCreationDate = New System.Windows.Forms.TextBox
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Location = New System.Drawing.Point(954, 442)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(89, 23)
        Me.btnUpdateItem.TabIndex = 43
        Me.btnUpdateItem.Text = "Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Item/Service ID:"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(347, 167)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(100, 20)
        Me.txtItemID.TabIndex = 41
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(800, 442)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(148, 23)
        Me.btnDeleteItem.TabIndex = 40
        Me.btnDeleteItem.Text = " Delete Item/Service "
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnEditItem
        '
        Me.btnEditItem.Location = New System.Drawing.Point(683, 442)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(111, 23)
        Me.btnEditItem.TabIndex = 39
        Me.btnEditItem.Text = " Edit Item/Service"
        Me.btnEditItem.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(548, 442)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(129, 23)
        Me.btnAddItem.TabIndex = 38
        Me.btnAddItem.Text = " Add Item/Service"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnLoadInventory
        '
        Me.btnLoadInventory.Location = New System.Drawing.Point(453, 442)
        Me.btnLoadInventory.Name = "btnLoadInventory"
        Me.btnLoadInventory.Size = New System.Drawing.Size(89, 23)
        Me.btnLoadInventory.TabIndex = 37
        Me.btnLoadInventory.Text = "Load Inventory"
        Me.btnLoadInventory.UseVisualStyleBackColor = True
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(453, 167)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.Size = New System.Drawing.Size(590, 253)
        Me.dgvInventory.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(453, 112)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Last Updated:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Creation Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Stock Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Item/Service Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Item/Service Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(534, 115)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(509, 20)
        Me.txtSearch.TabIndex = 28
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Location = New System.Drawing.Point(347, 326)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(100, 20)
        Me.txtLastUpdated.TabIndex = 27
        '
        'txtCreationDate
        '
        Me.txtCreationDate.Location = New System.Drawing.Point(347, 299)
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.ReadOnly = True
        Me.txtCreationDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCreationDate.TabIndex = 26
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(347, 273)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 25
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(347, 246)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 24
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(347, 220)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 23
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(347, 193)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 22
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 577)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnLoadInventory)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtLastUpdated)
        Me.Controls.Add(Me.txtCreationDate)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemName)
        Me.Name = "inventory"
        Me.Text = "inventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateItem As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnEditItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnLoadInventory As System.Windows.Forms.Button
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtLastUpdated As System.Windows.Forms.TextBox
    Friend WithEvents txtCreationDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
End Class
