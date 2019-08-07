Public Class Form2

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Gambar_Click(sender As Object, e As EventArgs) Handles Gambar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class