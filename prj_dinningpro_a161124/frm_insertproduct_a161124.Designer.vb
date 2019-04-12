<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a161124))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product2 = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_insertpicture = New System.Windows.Forms.Button()
        Me.grd_insertproduct = New System.Windows.Forms.DataGridView()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_manufacture = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_colour = New System.Windows.Forms.Label()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_manufacture = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pic_product2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bauhaus 93", 24.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(277, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(271, 38)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "INSERT PRODUCT"
        '
        'pic_product2
        '
        Me.pic_product2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product2.Location = New System.Drawing.Point(40, 66)
        Me.pic_product2.Name = "pic_product2"
        Me.pic_product2.Size = New System.Drawing.Size(162, 181)
        Me.pic_product2.TabIndex = 1
        Me.pic_product2.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(40, 277)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(162, 20)
        Me.txt_picture.TabIndex = 2
        '
        'btn_insertpicture
        '
        Me.btn_insertpicture.BackColor = System.Drawing.Color.Cyan
        Me.btn_insertpicture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertpicture.Location = New System.Drawing.Point(70, 305)
        Me.btn_insertpicture.Name = "btn_insertpicture"
        Me.btn_insertpicture.Size = New System.Drawing.Size(96, 30)
        Me.btn_insertpicture.TabIndex = 3
        Me.btn_insertpicture.Text = "SELECT"
        Me.btn_insertpicture.UseVisualStyleBackColor = False
        '
        'grd_insertproduct
        '
        Me.grd_insertproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertproduct.Location = New System.Drawing.Point(238, 66)
        Me.grd_insertproduct.Name = "grd_insertproduct"
        Me.grd_insertproduct.Size = New System.Drawing.Size(552, 181)
        Me.grd_insertproduct.TabIndex = 4
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.Location = New System.Drawing.Point(235, 267)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(120, 19)
        Me.lbl_productid.TabIndex = 5
        Me.lbl_productid.Text = "PRODUCT ID"
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(234, 296)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(151, 19)
        Me.lbl_productname.TabIndex = 6
        Me.lbl_productname.Text = "PRODUCT NAME"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(234, 325)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(61, 19)
        Me.lbl_price.TabIndex = 7
        Me.lbl_price.Text = "PRICE"
        '
        'lbl_manufacture
        '
        Me.lbl_manufacture.AutoSize = True
        Me.lbl_manufacture.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manufacture.Location = New System.Drawing.Point(234, 361)
        Me.lbl_manufacture.Name = "lbl_manufacture"
        Me.lbl_manufacture.Size = New System.Drawing.Size(145, 19)
        Me.lbl_manufacture.TabIndex = 8
        Me.lbl_manufacture.Text = "MANUFACTURE"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(235, 391)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(55, 19)
        Me.lbl_type.TabIndex = 9
        Me.lbl_type.Text = "TYPE"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(234, 418)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(100, 19)
        Me.lbl_material.TabIndex = 10
        Me.lbl_material.Text = "MATERIAL"
        '
        'lbl_colour
        '
        Me.lbl_colour.AutoSize = True
        Me.lbl_colour.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_colour.Location = New System.Drawing.Point(235, 444)
        Me.lbl_colour.Name = "lbl_colour"
        Me.lbl_colour.Size = New System.Drawing.Size(83, 19)
        Me.lbl_colour.TabIndex = 11
        Me.lbl_colour.Text = "COLOUR"
        '
        'txt_productid
        '
        Me.txt_productid.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productid.Location = New System.Drawing.Point(399, 265)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.Size = New System.Drawing.Size(316, 20)
        Me.txt_productid.TabIndex = 12
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(399, 291)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(316, 20)
        Me.txt_productname.TabIndex = 13
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(399, 326)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(316, 20)
        Me.txt_price.TabIndex = 14
        '
        'txt_manufacture
        '
        Me.txt_manufacture.Location = New System.Drawing.Point(399, 360)
        Me.txt_manufacture.Name = "txt_manufacture"
        Me.txt_manufacture.Size = New System.Drawing.Size(316, 20)
        Me.txt_manufacture.TabIndex = 15
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(399, 419)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(316, 20)
        Me.txt_material.TabIndex = 17
        '
        'txt_colour
        '
        Me.txt_colour.Location = New System.Drawing.Point(399, 445)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.Size = New System.Drawing.Size(316, 20)
        Me.txt_colour.TabIndex = 18
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Cyan
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(399, 471)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(126, 32)
        Me.btn_insert.TabIndex = 19
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(399, 389)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(316, 21)
        Me.cmb_type.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(721, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 99)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'frm_insertproduct_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 542)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_colour)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_manufacture)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lbl_colour)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_manufacture)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.grd_insertproduct)
        Me.Controls.Add(Me.btn_insertpicture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_product2)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a161124"
        Me.Text = "frm_insertproduct_a161124"
        CType(Me.pic_product2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents pic_product2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_picture As System.Windows.Forms.TextBox
    Friend WithEvents btn_insertpicture As System.Windows.Forms.Button
    Friend WithEvents grd_insertproduct As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_productid As System.Windows.Forms.Label
    Friend WithEvents lbl_productname As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_manufacture As System.Windows.Forms.Label
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents lbl_material As System.Windows.Forms.Label
    Friend WithEvents lbl_colour As System.Windows.Forms.Label
    Friend WithEvents txt_productid As System.Windows.Forms.TextBox
    Friend WithEvents txt_productname As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_manufacture As System.Windows.Forms.TextBox
    Friend WithEvents txt_material As System.Windows.Forms.TextBox
    Friend WithEvents txt_colour As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
