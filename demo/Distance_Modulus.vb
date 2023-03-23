Public Class Distance_Modulus
    Private Sub Distance_Modulus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim AppMag, AbsMag, d As Double
        AppMag = Val(TextBox1.Text)
        AbsMag = Val(TextBox2.Text)
        d = Val(TextBox3.Text)

        If AppMag = 0 Then
            If ComboBox1.SelectedIndex = 1 Then
                d *= 1000
            ElseIf ComboBox1.SelectedIndex = 2 Then
                d *= 10 ^ 6
            ElseIf ComboBox1.SelectedItem = "ly" Then
                d *= 3.262
            ElseIf ComboBox1.SelectedItem = "m" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3600
            ElseIf ComboBox1.SelectedItem = "km" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3.6
            Else
                d = d
            End If

            AppMag = (5 * Math.Log10(d)) - 5 + AbsMag

            TextBox1.Text = Math.Round(AppMag, 3)

        ElseIf AbsMag = 0 Then

            If ComboBox1.SelectedIndex = 1 Then
                d *= 1000
            ElseIf ComboBox1.SelectedIndex = 2 Then
                d *= 10 ^ 6
            ElseIf ComboBox1.SelectedItem = "ly" Then
                d *= 3.262
            ElseIf ComboBox1.SelectedItem = "m" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3600
            ElseIf ComboBox1.SelectedItem = "km" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3.6
            Else
                d = d
            End If

            AbsMag = 5 - (5 * Math.Log10(d)) - AppMag

            TextBox2.Text = Math.Round(AbsMag, 3)

        ElseIf d = 0 Then
            d = 10 ^ ((AppMag - AbsMag + 5) / 5)
            If ComboBox1.SelectedIndex = 1 Then
                d *= 0.001
            ElseIf ComboBox1.SelectedIndex = 2 Then
                d *= 10 ^ (-6)
            ElseIf ComboBox1.SelectedItem = "ly" Then
                d *= 3.262
            ElseIf ComboBox1.SelectedItem = "m" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3600
            ElseIf ComboBox1.SelectedItem = "km" Then
                d *= 3.262 * 300000000.0 * 365.4 * 24 * 3.6
            Else
                d = d
            End If

            TextBox3.Text = Math.Round(d, 3)
        End If

    End Sub
End Class