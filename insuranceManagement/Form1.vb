Imports System.Configuration
Imports System.Data.OleDb
Public Class Form1
    Sub agtName()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select DISTINCT ag_name from agent_master ", conn)
        Dim cmd As New OleDbCommand()
        Dim ds As New DataSet()
        adp.Fill(ds, "agent_mater")
        agt_name.DataSource = ds.Tables("agent_mater")
        agt_name.ValueMember = "ag_name"
        agt_name.DisplayMember = "ag_name"
        conn.Close()
    End Sub

    Sub viewAg()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from agent_master ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "agent_master")
        GridView.DataSource = ds.Tables("agent_master")
        conn.Close()
        txtaac.Clear()
        txtaan.Clear()
        txtac.Clear()
    End Sub
    Sub viewPo()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from policy_master ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "policy_master")
        GridView.DataSource = ds.Tables("policy_master")
        conn.Close()
        txtpac.Clear()
        txtpcn.Clear()
        txtped.Clear()
        txtppa.Clear()
        txtppn.Clear()
        txtpsd.Clear()
    End Sub
    Private Sub btnagi_Click(sender As Object, e As EventArgs) Handles btnagi.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into agent_master values(" & txtaac.Text & ",'" & txtaan.Text & "','" & txtac.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully!")
        conn.Close()
        viewAg()
    End Sub

    Private Sub btnagu_Click(sender As Object, e As EventArgs) Handles btnagu.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update agent_master set ag_name='" & txtaan.Text & "', city='" & txtac.Text & "' where ag_code= " & txtaac.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully!")
        conn.Close()
        viewAg()
    End Sub

    Private Sub btnagd_Click(sender As Object, e As EventArgs) Handles btnagd.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete * from agent_master where ag_code= " & txtaac.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        viewAg()
    End Sub

    Private Sub btnags_Click(sender As Object, e As EventArgs) Handles btnags.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim sql As String = " select * from agent_master where ag_code= " & txtaac.Text & ""
        Using cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                txtaac.Text = reader("ag_code").ToString()
                txtaan.Text = reader("ag_name").ToString()
                txtac.Text = reader("city").ToString()
            End While
        End Using
        conn.Close()
    End Sub

    Private Sub btnshowag_Click(sender As Object, e As EventArgs) Handles btnshowag.Click
        viewAg()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnshowpo.Click
        viewPo()
    End Sub

    Private Sub btnpoi_Click(sender As Object, e As EventArgs) Handles btnpoi.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into policy_master values('" & txtppn.Text & "'," & txtpac.Text & ",'" & txtpcn.Text & "','" & txtpsd.Text & "','" & txtped.Text & "'," & txtppa.Text & ")"
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully!")
        conn.Close()
        viewPo()
    End Sub

    Private Sub btnpos_Click(sender As Object, e As EventArgs) Handles btnpos.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim sql As String = "select * from policy_master where ag_name ='" & agt_name.Text & "' "
        Using cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                txtpac.Text = reader("ag_code").ToString()
                txtpcn.Text = reader("cust_name").ToString()
                txtped.Text = reader("end_date").ToString()
                txtppa.Text = reader("po_amt").ToString()
                txtppn.Text = reader("po_no").ToString()
                txtpsd.Text = reader("start_date").ToString()
            End While
        End Using
        conn.Close()
    End Sub

    Private Sub btnpou_Click(sender As Object, e As EventArgs) Handles btnpou.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update policy_master set ag_code=" & txtpac.Text & ",cust_name='" & txtpcn.Text & "',start_date='" & txtpsd.Text & "',end_date='" & txtped.Text & "',po_amt=" & txtppa.Text & " where po_no= " & txtppn.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully!")
        conn.Close()
        viewPo()
    End Sub

    Private Sub btnpod_Click(sender As Object, e As EventArgs) Handles btnpod.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete * from policy_master where po_no= " & txtppn.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        viewPo()
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim adp As New OleDbDataAdapter
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        adp = New OleDbDataAdapter("select a.ag_code,a.ag_name,a.city,p.po_no,p.ag_code,p.cust_name,p.start_date,p.end_date,p.po_amt from policy_master p inner join agent_master a on a.ag_code = p.ag_code  ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "agent_master")
        GridView.DataSource = ds.Tables("agent_master")
        conn.Close()
    End Sub

    Private Sub btnq1_Click(sender As Object, e As EventArgs) Handles btnq1.Click
        Dim adp As New OleDbDataAdapter
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        adp = New OleDbDataAdapter("select p.po_no,a.ag_code,p.cust_name,p.po_amt from policy_master p inner join agent_master a on a.ag_code = p.ag_code order by po_amt", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "agent_master")
        GridView.DataSource = ds.Tables("agent_master")
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles agt_name.SelectedIndexChanged

        Dim adp As New OleDbDataAdapter
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        adp = New OleDbDataAdapter("select a.ag_name, p.cust_name,p.po_amt from policy_master p inner join agent_master a on a.ag_code = p.ag_code where ag_name ='" & agt_name.Text & "'  ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "agent_master")
        GridView.DataSource = ds.Tables("agent_master")
        lab1.Show()
        ttlamt.Text = 0
        ttlamt.Show()

        Dim cmd As New OleDbCommand("SELECT SUM(po_amt) FROM policy_master inner join agent_master on agent_master.ag_code = policy_master.ag_code WHERE ag_name = '" & agt_name.Text & "'", conn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot DBNull.Value Then
            Dim sum As Decimal = Convert.ToDecimal(result)
            ttlamt.Text = sum
        End If

        'try 3
        'Dim sum1 As Decimal
        'For Each itemsum In ds.Tables("agent_master")
        '    sum1 += itemsum.
        'Next

        'try 2
        'Dim dt As New DataTable()
        'dt.Columns.AddRange(New DataColumn(2) {New DataColumn("EmployeeId", GetType(Integer)),
        '                               New DataColumn("Name", GetType(String)),
        '                               New DataColumn("Salary", GetType(Integer))})
        'dt.Rows.Add(1, "John Hammond", 45000)
        'dt.Rows.Add(2, "Mudassar Khan", 32000)
        'dt.Rows.Add(3, "Robert Schidner", 19000)
        'dt.Rows.Add(3, "Suzanne Mathews", 18500)
        'Dim sum As Integer = Convert.ToInt32(dt.Compute("SUM(Salary)", String.Empty))
        'ttlamt.Text = sum

        'try 1
        'Dim sql As String = " select po_amt from policy_master  "
        'Using cmd As New OleDbCommand(sql, conn)
        '    Dim reader As OleDbDataReader = cmd.ExecuteReader()
        '    Dim amtint As Integer = CType("ttlamt.Text", Integer)
        '    While reader.Read()
        '        ttlamt.Text = ttlamt.Text + reader("po_amt")
        '    End While
        'End Using


        conn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agtName()
        lab1.Hide()
        ttlamt.Hide()
    End Sub
End Class
