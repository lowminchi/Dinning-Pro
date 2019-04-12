Public Class frm_product_a161124

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_product.Click

    End Sub

    Private Sub grd_product_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellContentClick

    End Sub

    Private Sub frm_product_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_DININGPRO_A161124.accdb;Persist Security Info=False;;"

        Dim mysql As String = "SELECT*FROM TBL_PRODUCTS_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable
    End Sub
End Class