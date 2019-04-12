Public Class frm_order_a161124

 

    Dim i As Integer = 0
    Dim current_row As Integer
    Dim Total As Integer
    Dim staffid As String
    Dim customerid As String

    Private Sub frm_order_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub


    Private Sub refresh_grid()

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161124")

        grd_vieworder.ColumnCount = 4
        grd_vieworder.RowCount = 0

        grd_vieworder.Columns(0).HeaderText = "Product Name"
        grd_vieworder.Columns(1).HeaderText = "Quantity"
        grd_vieworder.Columns(2).HeaderText = "Unit Price"
        grd_vieworder.Columns(3).HeaderText = "Subtotal"

        lbl_id.Text = generate_id()

        cmb_customer.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A161124")
        cmb_customer.DisplayMember = "FLD_CUSTOMER_ID"
        cmb_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A161124")
        cmb_staff.DisplayMember = "FLD_STAFF_ID"

        lbl_date.Text = Date.Now

        pic_product.BackgroundImage = Image.FromFile("pictures/001.jpg")

        txt_total.Text = ""

    End Sub

    Private Function generate_id() As String

        Dim newid As String

        Dim mydatatable As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A161124")

        If mydatatable.Rows.Count = 0 Then
            newid = "O100"
        Else
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A161124").Rows(0).Item("LASTID")
            newid = "O" & Mid(lastid, 2) + 1

        End If

        Return newid

    End Function

    Private Function get_current_row() As Integer

        current_row = grd_product.CurrentRow.Index

        Return current_row

    End Function

    Private Sub cmb_staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_staff.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_STAFF_A161124")

        staffid = mydatatable.Rows(cmb_staff.SelectedIndex).Item("FLD_STAFF_ID")

    End Sub

    Private Sub cmb_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_customer.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_CUSTOMER_A161124")

        customerid = mydatatable.Rows(cmb_customer.SelectedIndex).Item("FLD_CUSTOMER_ID")

    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellClick

        Dim current_row As Integer = grd_product.CurrentRow.Index

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & grd_product(0, current_row).Value & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_addtocart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addtocart.Click

        Dim count As Integer = 0
        Dim temp As Integer

        For x As Integer = 0 To grd_vieworder.RowCount - 1
            If grd_product(1, get_current_row).Value = grd_vieworder(0, x).Value Then
                count = count + 1
                temp = x
            End If
        Next

        If count > 0 Then
            grd_vieworder(1, temp).Value = grd_vieworder(1, temp).Value + num_quantity.Value
            Dim temptotal As Integer = num_quantity.Value * grd_vieworder(2, temp).Value
            grd_vieworder(3, temp).Value = grd_vieworder(3, temp).Value + temptotal

            Total = Total + temptotal
        Else
            grd_vieworder.RowCount = grd_vieworder.RowCount + 1
            grd_vieworder(0, i).Value = grd_product(1, get_current_row).Value
            grd_vieworder(1, i).Value = num_quantity.Value
            grd_vieworder(2, i).Value = grd_product(2, get_current_row).Value
            grd_vieworder(3, i).Value = num_quantity.Value * grd_product(2, get_current_row).Value

            Total = Total + grd_vieworder(3, i).Value

            i += 1
        End If

        'grd_vieworder.RowCount = grd_vieworder.RowCount + 1
        'grd_vieworder(0, i).Value = grd_products(1, get_current_row).Value
        'grd_vieworder(1, i).Value = nup_quantity.Value
        'grd_vieworder(2, i).Value = grd_products(2, get_current_row).Value
        'grd_vieworder(3, i).Value = "RM" & nup_quantity.Value * grd_products(2, get_current_row).Value

        'Total = Total + grd_vieworder(3, i).Value

        txt_total.Text = "RM" & Total


    End Sub

   
    Private Sub btn_confirm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click

        If grd_vieworder.RowCount > 0 Then

            myconnection2.Open()
            Dim mytransaction As OleDb.OleDbTransaction = myconnection2.BeginTransaction

            Dim orderid As String = lbl_id.Text

            Try

                Dim myordersql As String = "INSERT INTO TBL_ORDER_A161124 VALUES('" & orderid & "', '" & customerid & "', '" & staffid & "')"

                Dim myorderwritter As New OleDb.OleDbCommand(myordersql, myconnection2, mytransaction)

                myorderwritter.ExecuteNonQuery()

                For x As Integer = 0 To grd_vieworder.RowCount - 1

                    Dim productdatatable = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161124 WHERE FLD_PRODUCT_NAME ='" & grd_vieworder(0, x).Value & "'")
                    Dim productid As String = productdatatable.Rows(0).Item("FLD_PRODUCT_ID")
                    Dim quantity As Integer = grd_vieworder(1, x).Value

                    Dim quantitysql As String = "INSERT INTO TBL_QUANTITY_A161124 VALUES ('" & orderid & "', '" & productid & "', " & quantity & ")"

                    Dim quantitywritter As New OleDb.OleDbCommand(quantitysql, myconnection2, mytransaction)

                    quantitywritter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                Beep()
                MsgBox("Transaction Successful!")

                grd_vieworder.Rows.Clear()
                refresh_grid()

            Catch ex As Exception

                mytransaction.Rollback()
                Beep()
                MsgBox("An error occured while confirming order: " & vbCrLf & vbCrLf & ex.Message)
                myconnection2.Close()

                grd_vieworder.Rows.Clear()
                refresh_grid()

            End Try

            i = 0
        Else
            MsgBox("Please add product")
        End If

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If grd_vieworder.RowCount > 1 Then
            Dim current As Integer = grd_vieworder.CurrentRow.Index
            Total = Total - grd_vieworder(3, current).Value
            grd_vieworder.Rows.RemoveAt(current)
            txt_total.Text = Total
            i = i - 1
        Else
            MsgBox("Please kindly do not spam the delete button, thank you ^^")
        End If
    End Sub

    Private Sub btn_vieworder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vieworder.Click
        frm_vieworder_a161124.Show()
    End Sub

    Private Sub grd_vieworder_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_vieworder.CellContentClick

    End Sub

    Private Sub lbl_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_order.Click

    End Sub
End Class