
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Mechanics.Show()
        Me.Hide()
    End Sub

    Private Sub SolidStateLbl_Click(sender As Object, e As EventArgs) Handles SolidStateLbl.Click
        Solid_State.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
