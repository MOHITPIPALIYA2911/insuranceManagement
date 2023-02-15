Imports System.Configuration
Imports System.Data.OleDb
Public Class Form1
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

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
        Dim sql As String = " select * from policy_master where po_no= " & txtppn.Text & ""
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
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from policy_master inner join agent_master on policy_master.age_code =agent_master.age_code ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "policy_master")
        GridView.DataSource = ds.Tables("policy_master")
        conn.Close()
    End Sub

    Private Sub btnq1_Click(sender As Object, e As EventArgs) Handles btnq1.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from policy_master inner join agent_master on policy_master.age_code =agent_master.age_code ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "policy_master")
        GridView.DataSource = ds.Tables("policy_master")
        conn.Close()
    End Sub

    Private Sub btnq2_Click(sender As Object, e As EventArgs) Handles btnq2.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\insuranceManagement\insuranceManagementDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from policy_master inner join agent_master on policy_master.age_code =agent_master.age_code ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "policy_master")
        GridView.DataSource = ds.Tables("policy_master")
        conn.Close()
    End Sub
End Class
