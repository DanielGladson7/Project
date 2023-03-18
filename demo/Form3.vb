Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P, V, n, T As Double
        Dim R = 8.314
        If TextBox1.Text = "" Then
            V = TextBox2.Text
            n = TextBox3.Text
            T = TextBox4.Text
            P = (n * R * T) / V
            TextBox1.Text = Math.Round(P, 3)
        End If
        If TextBox2.Text = "" Then
            P = TextBox1.Text
            n = TextBox3.Text
            T = TextBox4.Text
            V = (n * R * T) / P
            TextBox2.Text = Math.Round(V, 3)
        End If
        If TextBox3.Text = "" Then
            V = TextBox2.Text
            P = TextBox1.Text
            T = TextBox4.Text
            n = (P * V) / (R * T)
            TextBox3.Text = Math.Round(n, 3)
        End If
        If TextBox4.Text = "" Then
            V = TextBox2.Text
            n = TextBox3.Text
            P = TextBox1.Text
            T = (P * V) / (n * R)
            TextBox4.Text = Math.Round(T, 3)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class