Public Class Form4
    Dim op As Single
    Dim nombre, marca, almacenamiento, modelo As String
    Dim factura, precio, nalmacenamiento, nservicios, capacidad, extra, adicional, subtotal, descuento, impuesto, total, pago, no As Double
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facturax = facturax + 1
        tbfactura.Text = facturax
    End Sub

    Private Sub cbsamsung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsamsung.SelectedIndexChanged
        op = cbsamsung.SelectedIndex
        Select Case op
            Case 0
                precio = 4000
                modelo = "Galaxy TAB S2 LTE"
            Case 1
                precio = 6000
                modelo = "Galaxy Tab S4"
            Case 2
                precio = 7000
                modelo = "Galaxy Tab S5e Wifi + Lte"
        End Select
        tbprecio.Text = Format(Val(precio), "L 0.00")
    End Sub

    Private Sub cbapple_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbapple.SelectedIndexChanged
        op = cbapple.SelectedIndex
        Select Case op
            Case 0
                precio = 7000
                modelo = "iPad 6th Gen (2018)"
            Case 1
                precio = 9000
                modelo = "iPad 7th Gen (2019)"
        End Select
        tbprecio.Text = Format(Val(precio), "L 0.00")
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
                    .marca = marca
                    .modelo = modelo
                    .capacidad = almacenamiento
                    .total = total

                End With

                lista.Add(guardar)
                aux = aux + 1
                no = 1
            End If
        End If
    End Sub

    Private Sub rbapple_CheckedChanged(sender As Object, e As EventArgs) Handles rbapple.CheckedChanged
        If rbapple.Checked = True Then
            cbapple.Visible = True
            marca = "APPLE"
        Else
            cbapple.Visible = False
        End If
    End Sub

    Private Sub rbsamsung_CheckedChanged(sender As Object, e As EventArgs) Handles rbsamsung.CheckedChanged
        If rbsamsung.Checked = True Then
            cbsamsung.Visible = True
            marca = "SAMSUNG"
        Else
            cbsamsung.Visible = False
        End If
    End Sub

    Private Sub chcobertor_CheckedChanged(sender As Object, e As EventArgs) Handles chcobertor.CheckedChanged
        If chcobertor.Checked = True Then
            extra = extra + 250
        Else
            extra = extra - 250
        End If
        tbextra.Text = Format(Val(extra), "L 0.00")
    End Sub

    Private Sub chtemplado_CheckedChanged(sender As Object, e As EventArgs) Handles chtemplado.CheckedChanged
        If chtemplado.Checked = True Then
            extra = extra + 150
        Else
            extra = extra - 150
        End If
        tbextra.Text = Format(Val(extra), "L 0.00")
    End Sub

    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click
        'Validaciones
        If tbnombre.Text.Trim = "" Then
            MsgBox("Ingrese el Nombre del Cliente", MsgBoxStyle.Information)
            tbnombre.Focus()
            Exit Sub
        End If

        If rbapple.Checked = False And rbsamsung.Checked = False Then
            MsgBox("Seleccione La Marca del Dispositivo", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cbapple.Text = "" And cbsamsung.Text = "" Then
            MsgBox("Seleccione el Modelo que desee ", MsgBoxStyle.Information)
            Exit Sub
        End If

        If rb64.Checked = False And rb128.Checked = False And rb256.Checked = False Then
            MsgBox("Seleccione La Capacidad del Dispositivo", MsgBoxStyle.Information)
            Exit Sub
        End If

        If rbcredito.Checked = False And rbefectivo.Checked = False Then
            MsgBox("Seleccione el Metodo de Pago", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Datos Generales
        nombre = tbnombre.Text
        no = 0

        If rb64.Checked = True Then
            nalmacenamiento = 500
            almacenamiento = "64Gb"

        End If

        If rb128.Checked = True Then
            nalmacenamiento = 1000
            almacenamiento = "128Gb"
        End If

        If rb256.Checked = True Then
            nalmacenamiento = 1500
            almacenamiento = "256Gb"
        End If

        'Calculos
        subtotal = precio + nalmacenamiento + extra

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
        tbalmacenamiento.Text = Format(Val(nalmacenamiento), "L 0.00")
        tbsubtotal.Text = Format(Val(subtotal), "L 0.00")
        tbdescuento.Text = Format(Val(descuento), "L 0.00")
        tbimpuesto.Text = Format(Val(impuesto), "L 0.00")
        tbtotal.Text = Format(Val(total), "L 0.00")
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
    Private Sub btregresar_Click(sender As Object, e As EventArgs) Handles btregresar.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        no = 0
        rbapple.Checked = False
        rbsamsung.Checked = False
        cbapple.Text = ""
        cbsamsung.Text = ""
        rb64.Checked = False
        rb128.Checked = False
        rb256.Checked = False
        chcobertor.Checked = False
        chtemplado.Checked = False
        rbcredito.Checked = False
        rbefectivo.Checked = False
        facturax = facturax + 1
        tbfactura.Text = facturax
        tbnombre.Text = ""
        tbalmacenamiento.Text = ""
        tbprecio.Text = ""
        tbextra.Text = ""
        tbsubtotal.Text = ""
        tbdescuento.Text = ""
        tbimpuesto.Text = ""
        tbtotal.Text = ""
        tbnombre.Focus()
    End Sub
End Class