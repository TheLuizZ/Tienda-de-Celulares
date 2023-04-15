Public Class Form7
    Dim fila As Integer
    Private Sub btregresar_Click(sender As Object, e As EventArgs) Handles btregresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btfacturas_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        dgvfacturas.RowCount = aux
        For i = 0 To aux - 1
            dgvfacturas.Item(0, i).Value = lista(i).factura
            dgvfacturas.Item(1, i).Value = lista(i).nombre
            dgvfacturas.Item(2, i).Value = lista(i).articulo
            dgvfacturas.Item(3, i).Value = lista(i).marca
            dgvfacturas.Item(4, i).Value = lista(i).modelo
            dgvfacturas.Item(5, i).Value = lista(i).capacidad
            dgvfacturas.Item(6, i).Value = lista(i).total
        Next
    End Sub

    Private Sub btfacturas_Click_1(sender As Object, e As EventArgs) Handles btfacturas.Click
        Dim i As Integer
        dgvfacturas.RowCount = aux
        For i = 0 To aux - 1
            dgvfacturas.Item(0, i).Value = lista(i).factura
            dgvfacturas.Item(1, i).Value = lista(i).nombre
            dgvfacturas.Item(2, i).Value = lista(i).articulo
            dgvfacturas.Item(3, i).Value = lista(i).marca
            dgvfacturas.Item(4, i).Value = lista(i).modelo
            dgvfacturas.Item(5, i).Value = lista(i).capacidad
            dgvfacturas.Item(6, i).Value = lista(i).total
        Next
    End Sub
End Class