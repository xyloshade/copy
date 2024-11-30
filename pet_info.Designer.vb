<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pet_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pet_info))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btn_view = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.dtpsession = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpbd = New System.Windows.Forms.DateTimePicker
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txt_color = New System.Windows.Forms.TextBox
        Me.Txt_breed = New System.Windows.Forms.TextBox
        Me.Txt_species = New System.Windows.Forms.TextBox
        Me.txt_age = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_petowners = New System.Windows.Forms.TextBox
        Me.txt_petname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_vid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Btn_view)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.dtpsession)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpbd)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.Txt_breed)
        Me.GroupBox1.Controls.Add(Me.Txt_species)
        Me.GroupBox1.Controls.Add(Me.txt_age)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_petowners)
        Me.GroupBox1.Controls.Add(Me.txt_petname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_vid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(277, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 753)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PET INFO"
        '
        'Btn_view
        '
        Me.Btn_view.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_view.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_view.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_view.Location = New System.Drawing.Point(71, 561)
        Me.Btn_view.Name = "Btn_view"
        Me.Btn_view.Size = New System.Drawing.Size(181, 50)
        Me.Btn_view.TabIndex = 27
        Me.Btn_view.TabStop = False
        Me.Btn_view.Text = "VIEW " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATA"
        Me.Btn_view.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_add.Location = New System.Drawing.Point(451, 561)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(192, 50)
        Me.btn_add.TabIndex = 17
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'dtpsession
        '
        Me.dtpsession.CustomFormat = "yyyy/MM/dd"
        Me.dtpsession.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpsession.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsession.Location = New System.Drawing.Point(273, 444)
        Me.dtpsession.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpsession.Name = "dtpsession"
        Me.dtpsession.Size = New System.Drawing.Size(298, 27)
        Me.dtpsession.TabIndex = 26
        Me.dtpsession.Value = New Date(2024, 10, 1, 22, 3, 8, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(134, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "LAST VISIT"
        '
        'dtpbd
        '
        Me.dtpbd.CustomFormat = "yyyy/MM/dd"
        Me.dtpbd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbd.Location = New System.Drawing.Point(271, 403)
        Me.dtpbd.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpbd.Name = "dtpbd"
        Me.dtpbd.Size = New System.Drawing.Size(300, 27)
        Me.dtpbd.TabIndex = 23
        Me.dtpbd.Value = New Date(2024, 10, 1, 22, 3, 8, 0)
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(435, 277)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 27)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "male"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(299, 277)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 27)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "female"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(273, 236)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(288, 27)
        Me.txt_color.TabIndex = 13
        '
        'Txt_breed
        '
        Me.Txt_breed.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_breed.Location = New System.Drawing.Point(273, 360)
        Me.Txt_breed.Name = "Txt_breed"
        Me.Txt_breed.Size = New System.Drawing.Size(298, 27)
        Me.Txt_breed.TabIndex = 15
        '
        'Txt_species
        '
        Me.Txt_species.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_species.Location = New System.Drawing.Point(273, 317)
        Me.Txt_species.Name = "Txt_species"
        Me.Txt_species.Size = New System.Drawing.Size(298, 27)
        Me.Txt_species.TabIndex = 14
        '
        'txt_age
        '
        Me.txt_age.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(273, 192)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(288, 27)
        Me.txt_age.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(132, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "BIRTHDAY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(98, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ANIMAL BREED"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(87, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ANIMAL SPECIES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(127, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(106, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "MAIN COLOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(141, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PET AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OWNERS NAME"
        '
        'Txt_petowners
        '
        Me.Txt_petowners.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_petowners.Location = New System.Drawing.Point(273, 152)
        Me.Txt_petowners.Name = "Txt_petowners"
        Me.Txt_petowners.Size = New System.Drawing.Size(288, 27)
        Me.Txt_petowners.TabIndex = 4
        '
        'txt_petname
        '
        Me.txt_petname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname.Location = New System.Drawing.Point(273, 104)
        Me.txt_petname.Name = "txt_petname"
        Me.txt_petname.Size = New System.Drawing.Size(288, 27)
        Me.txt_petname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(127, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PET NAME"
        '
        'txt_vid
        '
        Me.txt_vid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vid.Location = New System.Drawing.Point(273, 61)
        Me.txt_vid.Name = "txt_vid"
        Me.txt_vid.Size = New System.Drawing.Size(52, 27)
        Me.txt_vid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(157, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "vet id"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'pet_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.BG5_optimized1
        Me.ClientSize = New System.Drawing.Size(1284, 751)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pet_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_petowners As System.Windows.Forms.TextBox
    Friend WithEvents txt_petname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Txt_breed As System.Windows.Forms.TextBox
    Friend WithEvents Txt_species As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dtpbd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpsession As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_view As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
