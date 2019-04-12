<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatecustomer_a161124))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_updatecustomer = New System.Windows.Forms.DataGridView()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_phonenumber = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.txt_phonenumber = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bauhaus 93", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(232, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(366, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "UPDATE CUSTOMER"
        '
        'grd_updatecustomer
        '
        Me.grd_updatecustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updatecustomer.Location = New System.Drawing.Point(299, 66)
        Me.grd_updatecustomer.Name = "grd_updatecustomer"
        Me.grd_updatecustomer.Size = New System.Drawing.Size(240, 150)
        Me.grd_updatecustomer.TabIndex = 1
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_customerid.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.Black
        Me.lbl_customerid.Location = New System.Drawing.Point(188, 266)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(173, 24)
        Me.lbl_customerid.TabIndex = 2
        Me.lbl_customerid.Text = "CUSTOMER ID"
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_customername.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.ForeColor = System.Drawing.Color.Black
        Me.lbl_customername.Location = New System.Drawing.Point(185, 299)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(214, 24)
        Me.lbl_customername.TabIndex = 3
        Me.lbl_customername.Text = "CUSTOMER NAME"
        '
        'lbl_phonenumber
        '
        Me.lbl_phonenumber.AutoSize = True
        Me.lbl_phonenumber.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_phonenumber.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phonenumber.ForeColor = System.Drawing.Color.Black
        Me.lbl_phonenumber.Location = New System.Drawing.Point(185, 332)
        Me.lbl_phonenumber.Name = "lbl_phonenumber"
        Me.lbl_phonenumber.Size = New System.Drawing.Size(198, 24)
        Me.lbl_phonenumber.TabIndex = 4
        Me.lbl_phonenumber.Text = "PHONE NUMBER"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_email.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(185, 362)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(85, 24)
        Me.lbl_email.TabIndex = 5
        Me.lbl_email.Text = "EMAIL"
        '
        'txt_customerid
        '
        Me.txt_customerid.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerid.Location = New System.Drawing.Point(427, 263)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.Size = New System.Drawing.Size(244, 27)
        Me.txt_customerid.TabIndex = 6
        '
        'txt_customername
        '
        Me.txt_customername.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(427, 296)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(244, 27)
        Me.txt_customername.TabIndex = 7
        '
        'txt_phonenumber
        '
        Me.txt_phonenumber.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phonenumber.Location = New System.Drawing.Point(427, 329)
        Me.txt_phonenumber.Name = "txt_phonenumber"
        Me.txt_phonenumber.Size = New System.Drawing.Size(244, 27)
        Me.txt_phonenumber.TabIndex = 8
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(427, 359)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(244, 27)
        Me.txt_email.TabIndex = 9
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Cyan
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(240, 405)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(109, 34)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Violet
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(468, 405)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 34)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(698, 346)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 99)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'frm_updatecustomer_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_phonenumber)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_phonenumber)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.grd_updatecustomer)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updatecustomer_a161124"
        Me.Text = "frm_updatecustomer_a161124"
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents grd_updatecustomer As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_customerid As System.Windows.Forms.Label
    Friend WithEvents lbl_customername As System.Windows.Forms.Label
    Friend WithEvents lbl_phonenumber As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_customerid As System.Windows.Forms.TextBox
    Friend WithEvents txt_customername As System.Windows.Forms.TextBox
    Friend WithEvents txt_phonenumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
