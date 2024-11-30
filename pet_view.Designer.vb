<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pet_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pet_view))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txt_petowner = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.MaleRadio = New System.Windows.Forms.RadioButton
        Me.FemaleRadio = New System.Windows.Forms.RadioButton
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_breed = New System.Windows.Forms.TextBox
        Me.txt_species = New System.Windows.Forms.TextBox
        Me.txt_color = New System.Windows.Forms.TextBox
        Me.txt_age = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_petname = New System.Windows.Forms.TextBox
        Me.dgv_petview = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_vid = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_petview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_petowner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MaleRadio)
        Me.GroupBox1.Controls.Add(Me.FemaleRadio)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_breed)
        Me.GroupBox1.Controls.Add(Me.txt_species)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.txt_age)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_petname)
        Me.GroupBox1.Controls.Add(Me.dgv_petview)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_vid)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1692, 670)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(208, 377)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 425)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'txt_petowner
        '
        Me.txt_petowner.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petowner.Location = New System.Drawing.Point(208, 465)
        Me.txt_petowner.Name = "txt_petowner"
        Me.txt_petowner.Size = New System.Drawing.Size(217, 27)
        Me.txt_petowner.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(56, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "PET AGE"
        '
        'MaleRadio
        '
        Me.MaleRadio.AutoSize = True
        Me.MaleRadio.Location = New System.Drawing.Point(371, 222)
        Me.MaleRadio.Name = "MaleRadio"
        Me.MaleRadio.Size = New System.Drawing.Size(54, 17)
        Me.MaleRadio.TabIndex = 23
        Me.MaleRadio.TabStop = True
        Me.MaleRadio.Text = "MALE"
        Me.MaleRadio.UseVisualStyleBackColor = True
        '
        'FemaleRadio
        '
        Me.FemaleRadio.AutoSize = True
        Me.FemaleRadio.Location = New System.Drawing.Point(238, 222)
        Me.FemaleRadio.Name = "FemaleRadio"
        Me.FemaleRadio.Size = New System.Drawing.Size(67, 17)
        Me.FemaleRadio.TabIndex = 22
        Me.FemaleRadio.TabStop = True
        Me.FemaleRadio.Text = "FEMALE"
        Me.FemaleRadio.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Snow
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.Location = New System.Drawing.Point(36, 516)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(166, 68)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Snow
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.Location = New System.Drawing.Point(208, 516)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(167, 68)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Snow
        Me.btn_update.Location = New System.Drawing.Point(381, 515)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(161, 69)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(44, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PET SESSION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(47, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "BIRTHDAY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(44, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ANIMAL BREED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(44, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ANIMAL SPECIES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(47, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "GENDER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(44, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "MAIN COLOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PET OWNER"
        '
        'txt_breed
        '
        Me.txt_breed.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_breed.Location = New System.Drawing.Point(208, 324)
        Me.txt_breed.Name = "txt_breed"
        Me.txt_breed.Size = New System.Drawing.Size(217, 27)
        Me.txt_breed.TabIndex = 9
        '
        'txt_species
        '
        Me.txt_species.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_species.Location = New System.Drawing.Point(208, 272)
        Me.txt_species.Name = "txt_species"
        Me.txt_species.Size = New System.Drawing.Size(217, 27)
        Me.txt_species.TabIndex = 8
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(208, 164)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(217, 27)
        Me.txt_color.TabIndex = 6
        '
        'txt_age
        '
        Me.txt_age.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(208, 117)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(217, 27)
        Me.txt_age.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PET NAME"
        '
        'txt_petname
        '
        Me.txt_petname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname.Location = New System.Drawing.Point(208, 64)
        Me.txt_petname.Name = "txt_petname"
        Me.txt_petname.Size = New System.Drawing.Size(217, 27)
        Me.txt_petname.TabIndex = 3
        '
        'dgv_petview
        '
        Me.dgv_petview.AllowUserToAddRows = False
        Me.dgv_petview.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_petview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_petview.Location = New System.Drawing.Point(431, 35)
        Me.dgv_petview.Name = "dgv_petview"
        Me.dgv_petview.Size = New System.Drawing.Size(869, 474)
        Me.dgv_petview.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VET ID"
        '
        'txt_vid
        '
        Me.txt_vid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vid.Location = New System.Drawing.Point(208, 31)
        Me.txt_vid.Name = "txt_vid"
        Me.txt_vid.Size = New System.Drawing.Size(66, 27)
        Me.txt_vid.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'pet_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.BG5_optimized1
        Me.ClientSize = New System.Drawing.Size(1300, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pet_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_petview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_vid As System.Windows.Forms.TextBox
    Friend WithEvents txt_petname As System.Windows.Forms.TextBox
    Friend WithEvents dgv_petview As System.Windows.Forms.DataGridView
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_breed As System.Windows.Forms.TextBox
    Friend WithEvents txt_species As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents txt_petowner As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
