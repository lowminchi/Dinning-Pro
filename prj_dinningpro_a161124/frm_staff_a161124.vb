Public Class frm_staff_a161124

    Private Sub frm_staff_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_DININGPRO_A161124.accdb;Persist Security Info=False;;"

        Dim mysql As String = "SELECT*FROM TBL_STAFF_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable
    End Sub
End Class