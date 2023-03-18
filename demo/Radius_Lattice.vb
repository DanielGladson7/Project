Imports System.Data.OleDb

Public Class Radius_Lattice
    ReadOnly conn As New OleDbConnection
    Private Sub Radius_Lattice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DEVI\Documents\Database6.accdb"
        conn.Open()
        Dim sql As String
        sql = "select Const Value from Table1 where Constant = Speed of light"
        Dim cmd As New OleDbCommand(sql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        Label4.Text = myreader("relation")

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
        End If
    End Sub
End Class