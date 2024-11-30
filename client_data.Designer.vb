<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client_data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client_data))
        Me.dgv_client = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_clientid = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Cmb_city = New System.Windows.Forms.ComboBox
        Me.txt_petname3 = New System.Windows.Forms.TextBox
        Me.txt_petname2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_petname = New System.Windows.Forms.TextBox
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txt_pets = New System.Windows.Forms.TextBox
        Me.btn_update = New System.Windows.Forms.Button
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_zip = New System.Windows.Forms.TextBox
        Me.Label = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.txt_contactnum = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dgv_client, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_client
        '
        Me.dgv_client.AllowUserToAddRows = False
        Me.dgv_client.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_client.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_client.Location = New System.Drawing.Point(0, 358)
        Me.dgv_client.Name = "dgv_client"
        Me.dgv_client.Size = New System.Drawing.Size(1296, 265)
        Me.dgv_client.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.rr
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 18)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENT ID"
        '
        'txt_clientid
        '
        Me.txt_clientid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientid.Location = New System.Drawing.Point(330, 10)
        Me.txt_clientid.Name = "txt_clientid"
        Me.txt_clientid.Size = New System.Drawing.Size(237, 27)
        Me.txt_clientid.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Cmb_city)
        Me.Panel1.Controls.Add(Me.txt_petname3)
        Me.Panel1.Controls.Add(Me.txt_petname2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_petname)
        Me.Panel1.Controls.Add(Me.dgv_client)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.txt_pets)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_zip)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_address)
        Me.Panel1.Controls.Add(Me.txt_contactnum)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_lname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_fname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_clientid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 792)
        Me.Panel1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(172, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 23)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CITY"
        '
        'Cmb_city
        '
        Me.Cmb_city.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_city.FormattingEnabled = True
        Me.Cmb_city.Items.AddRange(New Object() {"San Jose del Monte", "San Miguel", "San Rafael", "Santa Maria"})
        Me.Cmb_city.Location = New System.Drawing.Point(327, 314)
        Me.Cmb_city.Name = "Cmb_city"
        Me.Cmb_city.Size = New System.Drawing.Size(240, 26)
        Me.Cmb_city.TabIndex = 27
        '
        'txt_petname3
        '
        Me.txt_petname3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname3.Location = New System.Drawing.Point(924, 284)
        Me.txt_petname3.Name = "txt_petname3"
        Me.txt_petname3.Size = New System.Drawing.Size(240, 27)
        Me.txt_petname3.TabIndex = 26
        '
        'txt_petname2
        '
        Me.txt_petname2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname2.Location = New System.Drawing.Point(924, 238)
        Me.txt_petname2.Name = "txt_petname2"
        Me.txt_petname2.Size = New System.Drawing.Size(240, 27)
        Me.txt_petname2.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(791, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "PET NAME #3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(791, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 23)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "PET NAME #2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(793, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "PET NAME "
        '
        'txt_petname
        '
        Me.txt_petname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname.Location = New System.Drawing.Point(924, 182)
        Me.txt_petname.Name = "txt_petname"
        Me.txt_petname.Size = New System.Drawing.Size(240, 27)
        Me.txt_petname.TabIndex = 21
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Bisque
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.Location = New System.Drawing.Point(562, 633)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(173, 59)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Bisque
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.Location = New System.Drawing.Point(289, 629)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(171, 63)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bagong Buhay III, ", "Citrus, ", "Ciudad Real, ", "Dulong Bayan, ", "Fatima, ", "Fatima II, ", "Fatima III,", "Fatima IV,", "Fatima V, ", "Francisco Homes-Guijo,", "Francisco Homes-Mulawin,", "Francisco Homes-Narra, ", "Francisco Homes-Yakal, ", "Gaya-gaya, ", "Graceville,", "Gumaoc Central, ", "Gumaoc East, ", "Gumaoc West, ", "Kaybanban, ", "Kaypian, ", "Lawang Pari, ", "Maharlika, ", "Minuyan, ", "Minuyan II, ", "Minuyan III, ", "Minuyan IV,", "Minuyan Proper, ", "Minuyan V, ", "Muzon, ", "Paradise III, ", "Poblacion, ", "Poblacion I, ", "Saint Martin de Porres,", "San Isidro, ", "San Manuel, ", "San Martin, ", "San Martin II, ", "San Martin III, ", "San Martin IV, ", "San Pedro, ", "San Rafael, ", "San Rafael I,", "San Rafael III, ", "San Rafael IV,", "San Rafael V, ", "San Roque, ", "Santa Cruz, ", "Santa Cruz II, ", "Santa Cruz III, ", "Santa Cruz IV, ", "Santa Cruz V, ", "Santo Cristo,", "Santo Niño,", "Santo Niño II,", "Sapang Palay, ", "Tungkong Mangga, ", "", "", "", "Bagbaguin,Balasing,", "Buenavista, ", "Bulac, ", "Camangyanan,", "Catmon, ", "Cay Pombo, ", "Caysio, ", "Guyong,", "Lalakhan, ", "Mag-asawang Sapa, ", "Mahabang Parang, ", "Manggahan, ", "Parada, ", "Poblacion,", "Pulong Buhangin, ", "San Gabriel, ", "San Jose Patag, ", "San Vicente,", "Santa Clara, ", "Santa Cruz, ", "Silangan, ", "Tabing Bakod, ", "Tumana, "})
        Me.ComboBox1.Location = New System.Drawing.Point(327, 269)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 26)
        Me.ComboBox1.TabIndex = 19
        '
        'txt_pets
        '
        Me.txt_pets.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pets.Location = New System.Drawing.Point(924, 131)
        Me.txt_pets.Name = "txt_pets"
        Me.txt_pets.Size = New System.Drawing.Size(240, 27)
        Me.txt_pets.TabIndex = 18
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Bisque
        Me.btn_update.Location = New System.Drawing.Point(829, 633)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(173, 63)
        Me.btn_update.TabIndex = 4
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(924, 75)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(240, 27)
        Me.txt_email.TabIndex = 17
        '
        'txt_zip
        '
        Me.txt_zip.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_zip.Location = New System.Drawing.Point(924, 17)
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(240, 27)
        Me.txt_zip.TabIndex = 16
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Transparent
        Me.Label.Location = New System.Drawing.Point(791, 131)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(93, 23)
        Me.Label.TabIndex = 15
        Me.Label.Text = "# OF PET/S"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(793, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "EMAIL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(791, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ZIP/IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(173, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "BARANGAY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(173, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ADDRESS"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(330, 221)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(240, 27)
        Me.txt_address.TabIndex = 9
        '
        'txt_contactnum
        '
        Me.txt_contactnum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contactnum.Location = New System.Drawing.Point(327, 160)
        Me.txt_contactnum.Name = "txt_contactnum"
        Me.txt_contactnum.Size = New System.Drawing.Size(240, 27)
        Me.txt_contactnum.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(173, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CONTACT #" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(327, 114)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(240, 27)
        Me.txt_lname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(172, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LAST NAME"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(327, 63)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(240, 27)
        Me.txt_fname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(173, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIRST NAME"
        '
        'client_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.BG5_optimized1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1300, 758)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "client_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dgv_client, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_client As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_clientid As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_pets As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_zip As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_contactnum As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_petname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_petname3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_petname2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Cmb_city As System.Windows.Forms.ComboBox
End Class
