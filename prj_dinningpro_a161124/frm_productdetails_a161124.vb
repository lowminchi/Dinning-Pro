Public Class frm_productdetails_a161124

    Private Sub frm_productdetail_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable

        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub
    Private Sub refresh_text(ByVal id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161124 WHERE FLD_PRODUCT_ID ='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productid.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_manufacture.Text = mydatatable.Rows(0).Item("FLD_MANUFACTURE")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_material.Text = mydatatable.Rows(0).Item("FLD_MATERIAL")
        txt_colour.Text = mydatatable.Rows(0).Item("FLD_COLOUR")



        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productid.Text & ".jpg")

        Catch ex As Exception

                pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try


    End Sub
    Private Sub lst_id_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Private Sub txt_manufacture_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_manufacture.TextChanged

    End Sub

    Private Sub lbl_title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_title.Click

    End Sub

    Private Sub txt_type_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_type.TextChanged

    End Sub
End Class