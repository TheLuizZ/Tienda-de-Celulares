Public Class Form5
    Dim op As Single
    Dim nombre, marca, servicios, modelo As String
    Dim factura, precio, cobertor, sd, auriculares, extra, adicional, subtotal, descuento, impuesto, total, pago, no As Double

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facturax = facturax + 1
        tbfactura.Text = facturax
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
                    .modelo = "Desconocida"
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

        If rbcredito.Checked = False And rbefectivo.Checked = False Then
            MsgBox("Seleccione el Metodo de Pago", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Datos Generales
        nombre = tbnombre.Text
        no = 0

        If rbapple.Checked = True Then
            cobertor = 200
        End If
        If rbsamsung.Checked = True Then
            cobertor = 150
        End If
        If rbxiaomi.Checked = True Then
            cobertor = 100
        End If

        If rbnormales.Checked = True Then
            auriculares = 100
        End If
        If rbbluetooth.Checked = True Then
            auriculares = 250
        End If

        If rb32.Checked = True Then
            sd = 150
        End If
        If rb64.Checked = True Then
            sd = 300
        End If
        If rb128.Checked = True Then
            sd = 500
        End If





        'Calculos
        precio = cobertor + sd + auriculares + extra

        If rbcredito.Checked = True Then
            descuento = precio * 0.05

        End If

        If rbefectivo.Checked = True Then
            descuento = precio * 0.1
        End If

        impuesto = (precio - descuento) * 0.15
        total = precio - descuento + impuesto

        'Imprimir Calculos
        tbprecio.Text = Format(Val(precio), "L 0.00")
        tbdescuento.Text = Format(Val(descuento), "L 0.00")
        tbimpuesto.Text = Format(Val(impuesto), "L 0.00")
        tbtotal.Text = Format(Val(total), "L 0.00")
    End Sub
    Private Sub chusb_CheckedChanged(sender As Object, e As EventArgs) Handles chusb.CheckedChanged
        If chusb.Checked = True Then
            extra = extra + 125
        Else
            extra = extra - 125
        End If
    End Sub

    Private Sub chinalambricos_CheckedChanged(sender As Object, e As EventArgs) Handles chinalambricos.CheckedChanged
        If chinalambricos.Checked = True Then
            extra = extra + 250
        Else
            extra = extra - 250
        End If
    End Sub

    Private Sub chparlantes_CheckedChanged(sender As Object, e As EventArgs) Handles chparlantes.CheckedChanged
        If chparlantes.Checked = True Then
            extra = extra + 250
        Else
            extra = extra - 250
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
        rbxiaomi.Checked = False
        rb32.Checked = False
        rb64.Checked = False
        rb128.Checked = False
        rbnormales.Checked = False
        rbbluetooth.Checked = False
        chparlantes.Checked = False
        chinalambricos.Checked = False
        chusb.Checked = False
        rbcredito.Checked = False
        rbefectivo.Checked = False
        facturax = facturax + 1
        tbfactura.Text = facturax
        tbnombre.Text = ""
        tbprecio.Text = ""
        tbdescuento.Text = ""
        tbimpuesto.Text = ""
        tbtotal.Text = ""
        tbnombre.Focus()
    End Sub
End Class