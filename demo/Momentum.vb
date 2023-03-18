Public Class Momentum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m, v, p

        If TextBox3.Text = "" Then
            m = TextBox1.Text
            v = TextBox2.Text
            p = m * v
        End If

        If TextBox1.Text = "" Then
            p = TextBox3.Text
            v = TextBox2.Text
            m = p / v
        End If

        If TextBox2.Text = "" Then
            m = TextBox1.Text
            p = TextBox3.Text
            v = p / m
        End If

        If ComboBox1.SelectedIndex = 1 Then
            m = m * 0.01
        ElseIf ComboBox1.SelectedIndex = 2 Then
            m = m * 10 ^ (-6)
        Else
            m = m
        End If

        If ComboBox2.SelectedIndex = 1 Then
            v = v * (5 / 18)
        Else
            v = v
        End If

        If ComboBox3.SelectedIndex = 1 Then
            p = p * (18 / 5)
        ElseIf ComboBox3.SelectedIndex = 2 Then
            p = p * 10 ^ (-3) * (18 / 5)
        ElseIf ComboBox3.SelectedIndex = 3 Then
            p = p * 10 ^ (-3)
        Else
            p = p
        End If

        TextBox1.Text = m
        TextBox2.Text = v
        TextBox3.Text = p

    End Sub

    Private Sub Momentum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class