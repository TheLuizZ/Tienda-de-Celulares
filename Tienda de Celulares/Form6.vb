Public Class Form6
    Dim op As Single
    Dim nombre, marca, servicios, modelo As String
    Dim factura, precio, nservicios, capacidad, extra, adicional, subtotal, descuento, impuesto, total, pago, no As Double
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facturax = facturax + 1
        tbfactura.Text = facturax
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        no = 0
        rbapple.Checked = False
        rbsamsung.Checked = False
        rbxiaomi.Checked = False
        chsoftware.Checked = False
        chpantalla.Checked = False
        chbateria.Checked = False
        chcarga.Checked = False
        rbcredito.Checked = False
        rbefectivo.Checked = False
        facturax = facturax + 1
        tbfactura.Text = facturax
        tbnombre.Text = ""
        tbmodelo.Text = ""
        tbprecio.Text = ""
        tbextra.Text = ""
        tbservicios.Text = ""
        tbsubtotal.Text = ""
        tbdescuento.Text = ""
        tbimpuesto.Text = ""
        tbtotal.Text = ""
        tbnombre.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If no = 1 Then
            MsgBox("Debe Darle al boton nuevo para ingresar un nuevo cliente", MsgBoxStyle.Information)
        Else
            If tbtotal.Text = "" Then
                MsgBox("Debe Calcular Primero")
                btcalcular.Focus()
            Else
                Dim guardar As New Facturas
                With guardar
                    .factura = facturax
                    .nombre = nombre
                    .articulo = articulo
                    .marca = "Desconocida"
                    .modelo = modelo
                    .capacidad = "Desconocida"
                    .total = total

                End With

                lista.Add(guardar)
                aux = aux + 1
                no = 1
            End If
        End If
    End Sub
    Private Sub tbnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click
        'Validaciones
        If tbnombre.Text.Trim = "" Then
            MsgBox("Ingrese el Nombre del Cliente", MsgBoxStyle.Information)
            tbnombre.Focus()
            Exit Sub
        End If

        If rbapple.Checked = False And rbsamsung.Checked = False And rbxiaomi.Checked = False Then
            MsgBox("Seleccione La Marca del Dispositivo", MsgBoxStyle.Information)
            Exit Sub
        End If

        If chsoftware.Checked = False And chpantalla.Checked = False And chbateria.Checked = False And chcarga.Checked = False Then
            MsgBox("Seleccione Los servicios que necesita", MsgBoxStyle.Information)
            Exit Sub
        End If

        If rbcredito.Checked = False And rbefectivo.Checked = False Then
            MsgBox("Seleccione el Metodo de Pago", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Datos Generales
        nombre = tbnombre.Text
        modelo = tbmodelo.Text
        no = 0

        'Calculos
        subtotal = precio + (nservicios * extra)

        If rbcredito.Checked = True Then
            descuento = subtotal * 0.05

        End If

        If rbefectivo.Checked = True Then
            descuento = subtotal * 0.1
        End If

        impuesto = (subtotal - descuento) * 0.15
        total = subtotal - descuento + impuesto

        'Imprimir Calculos
        tbextra.Text = Format(Val(extra), "L 0.00")
        tbsubtotal.Text = Format(Val(subtotal), "L 0.00")
        tbdescuento.Text = Format(Val(descuento), "L 0.00")
        tbimpuesto.Text = Format(Val(impuesto), "L 0.00")
        tbtotal.Text = Format(Val(total), "L 0.00")
    End Sub

    Private Sub chcarga_CheckedChanged(sender As Object, e As EventArgs) Handles chcarga.CheckedChanged
        If chcarga.Checked = True Then
            nservicios = nservicios + 750
        Else
            nservicios = nservicios - 750
        End If
        tbservicios.Text = Format(Val(nservicios), "L 0.00")
    End Sub

    Private Sub chbateria_CheckedChanged(sender As Object, e As EventArgs) Handles chbateria.CheckedChanged
        If chbateria.Checked = True Then
            nservicios = nservicios + 1000
        Else
            nservicios = nservicios - 1000
        End If
        tbservicios.Text = Format(Val(nservicios), "L 0.00")
    End Sub

    Private Sub chpantalla_CheckedChanged(sender As Object, e As EventArgs) Handles chpantalla.CheckedChanged
        If chpantalla.Checked = True Then
            nservicios = nservicios + 2000
        Else
            nservicios = nservicios - 2000
        End If
        tbservicios.Text = Format(Val(nservicios), "L 0.00")
    End Sub

    Private Sub chsoftware_CheckedChanged(sender As Object, e As EventArgs) Handles chsoftware.CheckedChanged
        If chsoftware.Checked = True Then
            nservicios = nservicios + 500
        Else
            nservicios = nservicios - 500
        End If
        tbservicios.Text = Format(Val(nservicios), "L 0.00")
    End Sub

    Private Sub rbxiaomi_CheckedChanged(sender As Object, e As EventArgs) Handles rbxiaomi.CheckedChanged
        If rbxiaomi.Checked = True Then
            precio = 250
            extra = 0.5
            marca = "XIAOMI"
            tbprecio.Text = Format(Val(precio), "L 0.00")
        End If
    End Sub

    Private Sub rbsamsung_CheckedChanged(sender As Object, e As EventArgs) Handles rbsamsung.CheckedChanged
        If rbsamsung.Checked = True Then
            precio = 500
            extra = 1.5
            marca = "SAMSUNG"
            tbprecio.Text = Format(Val(precio), "L 0.00")
        End If
    End Sub

    Private Sub btregresar_Click(sender As Object, e As EventArgs) Handles btregresar.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub rbapple_CheckedChanged(sender As Object, e As EventArgs) Handles rbapple.CheckedChanged
        If rbapple.Checked = True Then
            precio = 750
            extra = 2.5
            marca = "APPLE"
            tbprecio.Text = Format(Val(precio), "L 0.00")
        End If
    End Sub
End Class