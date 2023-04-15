Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        articulo = "Celular"
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        articulo = "Tablets"
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        articulo = "Accesorios"
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        articulo = "Soporte Tecnico"
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub btregresar_Click(sender As Object, e As EventArgs) Handles btregresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class