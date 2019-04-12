Public Class frm_vieworder_a161124

    Private Sub frm_vieworder_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_orderid.DataSource = run_sql_query("SELECT FLD_ORDER_ID FROM TBL_ORDER_A161124")
        cmb_orderid.DisplayMember = "FLD_ORDER_ID"

        grd_vieworder.Columns(0).HeaderText = "Product ID"
        grd_vieworder.Columns(1).HeaderText = "Product Name"
        grd_vieworder.Columns(2).HeaderText = "Quantity"
        grd_vieworder.Columns(3).HeaderText = "Unit Price"
        grd_vieworder.Columns(4).HeaderText = "Subtotal"

        txt_total.Text = "RM" & get_total()

    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_orderid.SelectedIndexChanged

        Dim order = run_sql_query("SELECT * FROM TBL_ORDER_A161124")
        Dim orderid = order.Rows(cmb_orderid.SelectedIndex).Item("FLD_ORDER_ID")

        Dim mydatatable = run_sql_query("SELECT TBL_QUANTITY_A161124.FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_QUANTITY, FLD_PRICE, FLD_QUANTITY*FLD_PRICE FROM TBL_QUANTITY_A161124, TBL_PRODUCTS_A161124 WHERE FLD_ORDER_ID ='" & orderid & "' AND TBL_QUANTITY_A161124.FLD_PRODUCT_ID = TBL_PRODUCTS_A161124.FLD_PRODUCT_ID")

        grd_vieworder.DataSource = mydatatable

        Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDER_A161124 WHERE FLD_ORDER_ID = '" & orderid & "'")

        txt_customerid.Text = orderdatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_staffid.Text = orderdatatable.Rows(0).Item("FLD_STAFF_ID")

        txt_total.Text = "RM" & get_total()

    End Sub

    Private Function get_total() As Integer

        Dim total As Integer = 0

        For i As Integer = 0 To grd_vieworder.RowCount - 1
            total = total + grd_vieworder(4, i).Value
        Next

        Return total

    End Function

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class