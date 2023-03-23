Imports System.Data.OleDb

Public Class Radius_Lattice
    ReadOnly conn As New OleDbConnection
    Private Sub Radius_Lattice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        '    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DEVI\Documents\Database6.accdb"
        '    conn.Open()
        '    Dim cmd As New OleDbCommand("Select ConstValue from Table1 where Symbol = 'c'", conn)
        '    Dim myReader As OleDbDataReader = cmd.ExecuteReader
        '    If (myReader.Read()) Then
        '        MsgBox(Val(myReader.GetValue(0)))
        '    End If
        '    conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, r As Double
        a = Val(TextBox1.Text)
        r = Val(TextBox2.Text)

        If RadioButton1.Checked = True Then

            If a = 0 Then

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                a = 2 * r

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                TextBox1.Text = Math.Round(a, 3)

            ElseIf r = 0 Then

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                r = a / 2

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                TextBox2.Text = Math.Round(r, 3)

            End If

        ElseIf RadioButton2.Checked = True Then

            If a = 0 Then

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                a = (4 / Math.Sqrt(3)) * r

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                TextBox1.Text = Math.Round(a, 3)

            ElseIf r = 0 Then

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                r = (Math.Sqrt(3) / 4) * a

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                TextBox2.Text = Math.Round(r, 3)

            End If

        ElseIf RadioButton3.Checked = True Then

            If a = 0 Then

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                a = (2 * Math.Sqrt(2)) * r

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                TextBox1.Text = Math.Round(a, 3)

            ElseIf r = 0 Then

                If ComboBox1.SelectedIndex = 1 Then
                    a *= 0.1
                Else
                    a = a
                End If

                r = a / (2 * Math.Sqrt(2))

                If ComboBox2.SelectedIndex = 1 Then
                    r *= 0.1
                Else
                    r = r
                End If

                TextBox2.Text = Math.Round(r, 3)
            End If

        End If
    End Sub
End Class