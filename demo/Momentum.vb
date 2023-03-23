Public Class Momentum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m, v, p As Double

        m = Val(TextBox1.Text)
        p = Val(TextBox3.Text)
        v = Val(TextBox2.Text)

        If Val(m) = 0 Then

            If ComboBox2.SelectedIndex = 1 Then
                v *= (5 / 18)
            Else
                v = v
            End If

            If ComboBox3.SelectedIndex = 1 Then
                p *= (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 2 Then
                p *= 10 ^ (-3) * (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 3 Then
                p *= 10 ^ (-3)
            Else
                p = p
            End If

            m = p / v

            If ComboBox1.SelectedIndex = 1 Then
                m *= 0.001
            ElseIf ComboBox1.SelectedIndex = 2 Then
                m *= 10 ^ (-6)
            Else
                m = m
            End If
            TextBox1.Text = m

        ElseIf Val(p) = 0 Then

            If ComboBox1.SelectedIndex = 1 Then
                m *= 0.001
            ElseIf ComboBox1.SelectedIndex = 2 Then
                m *= 10 ^ (-6)
            Else
                m = m
            End If

            If ComboBox2.SelectedIndex = 1 Then
                v *= (5 / 18)
            Else
                v = v
            End If

            p = m * v

            If ComboBox3.SelectedIndex = 1 Then
                p *= (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 2 Then
                p *= 10 ^ (-3) * (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 3 Then
                p *= 10 ^ (-3)
            Else
                p = p
            End If

            TextBox3.Text = p

        ElseIf Val(v) = 0 Then

            If ComboBox1.SelectedIndex = 1 Then
                m *= 0.001
            ElseIf ComboBox1.SelectedIndex = 2 Then
                m *= 10 ^ (-6)
            Else
                m = m
            End If

            If ComboBox3.SelectedIndex = 1 Then
                p *= (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 2 Then
                p *= 10 ^ (-3) * (18 / 5)
            ElseIf ComboBox3.SelectedIndex = 3 Then
                p *= 10 ^ (-3)
            Else
                p = p
            End If

            v = p / m

            If ComboBox2.SelectedIndex = 1 Then
                v *= (5 / 18)
            Else
                v = v
            End If

            TextBox2.Text = v
        End If

    End Sub

    Private Sub Momentum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class