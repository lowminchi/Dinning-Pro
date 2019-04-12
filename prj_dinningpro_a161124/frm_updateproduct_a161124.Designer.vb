<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a161124))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_updateproduct = New System.Windows.Forms.DataGridView()
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.pic_product3 = New System.Windows.Forms.PictureBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bauhaus 93", 24.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(289, -2)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(289, 38)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "UPDATE PRODUCT"
        '
        'grd_updateproduct
        '
        Me.grd_updateproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updateproduct.Location = New System.Drawing.Point(195, 39)
        Me.grd_updateproduct.Name = "grd_updateproduct"
        Me.grd_updateproduct.Size = New System.Drawing.Size(484, 150)
        Me.grd_updateproduct.TabIndex = 1
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.Location = New System.Drawing.Point(203, 198)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(130, 19)
        Me.lbl_productid.TabIndex = 2
        Me.lbl_productid.Text = "PRODUCT ID"
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(203, 225)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(163, 19)
        Me.lbl_productname.TabIndex = 3
        Me.lbl_productname.Text = "PRODUCT NAME"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(203, 253)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(66, 19)
        Me.lbl_price.TabIndex = 4
        Me.lbl_price.Text = "PRICE"
        '
        'lbl_manufacture
        '
        Me.lbl_manufacture.AutoSize = True
        Me.lbl_manufacture.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manufacture.Location = New System.Drawing.Point(203, 284)
        Me.lbl_manufacture.Name = "lbl_manufacture"
        Me.lbl_manufacture.Size = New System.Drawing.Size(156, 19)
        Me.lbl_manufacture.TabIndex = 5
        Me.lbl_manufacture.Text = "MANUFACTURE"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(203, 308)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(59, 19)
        Me.lbl_type.TabIndex = 6
        Me.lbl_type.Text = "TYPE"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(203, 338)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(108, 19)
        Me.lbl_material.TabIndex = 7
        Me.lbl_material.Text = "MATERIAL"
        '
        'lbl_colour
        '
        Me.lbl_colour.AutoSize = True
        Me.lbl_colour.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_colour.Location = New System.Drawing.Point(203, 369)
        Me.lbl_colour.Name = "lbl_colour"
        Me.lbl_colour.Size = New System.Drawing.Size(89, 19)
        Me.lbl_colour.TabIndex = 8
        Me.lbl_colour.Text = "COLOUR"
        '
        'txt_productid
        '
        Me.txt_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productid.Location = New System.Drawing.Point(398, 198)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.Size = New System.Drawing.Size(240, 22)
        Me.txt_productid.TabIndex = 9
        '
        'txt_productname
        '
        Me.txt_productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.Location = New System.Drawing.Point(398, 224)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(240, 22)
        Me.txt_productname.TabIndex = 10
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(398, 252)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(240, 22)
        Me.txt_price.TabIndex = 11
        '
        'txt_manufacture
        '
        Me.txt_manufacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_manufacture.Location = New System.Drawing.Point(398, 280)
        Me.txt_manufacture.Name = "txt_manufacture"
        Me.txt_manufacture.Size = New System.Drawing.Size(240, 22)
        Me.txt_manufacture.TabIndex = 12
        '
        'txt_material
        '
        Me.txt_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(398, 338)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(240, 22)
        Me.txt_material.TabIndex = 14
        '
        'txt_colour
        '
        Me.txt_colour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colour.Location = New System.Drawing.Point(398, 366)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.Size = New System.Drawing.Size(240, 22)
        Me.txt_colour.TabIndex = 15
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Cyan
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(236, 416)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(97, 29)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Violet
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(462, 416)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(92, 29)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'pic_product3
        '
        Me.pic_product3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product3.Location = New System.Drawing.Point(47, 56)
        Me.pic_product3.Name = "pic_product3"
        Me.pic_product3.Size = New System.Drawing.Size(100, 104)
        Me.pic_product3.TabIndex = 18
        Me.pic_product3.TabStop = False
        '
        'cmb_type
        '
        Me.cmb_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(398, 308)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(240, 24)
        Me.cmb_type.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(677, 342)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 103)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'frm_updateproduct_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.pic_product3)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
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
        Me.Controls.Add(Me.grd_updateproduct)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_updateproduct_a161124"
        Me.Text = "frm_updateproduct_a161124"
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents grd_updateproduct As System.Windows.Forms.DataGridView
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
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents pic_product3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
