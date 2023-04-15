Public Class Form1
    Private Sub rbcliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbcliente.CheckedChanged
        If rbcliente.Checked Then
            btacceder.Visible = True
            'btinscribirse.Visible=True
        Else
            btacceder.Visible = False
            btinscribirse.Visible = False
            gbaccediendo.Visible = False
            btcingresar.Visible = False
            'gbsuscribiendose.Visible=False
            'btsuscribirse.Visible=False
        End If
    End Sub
    Private Sub rbgerencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbgerencia.CheckedChanged
        If rbgerencia.Checked Then
            gbgaccediendo.Visible = True
            btgingresar.Visible = True
        Else
            gbgaccediendo.Visible = False
            btgingresar.Visible = False
        End If
    End Sub
    Private Sub btcacceder_Click(sender As Object, e As EventArgs) Handles btacceder.Click
        gbaccediendo.Visible = True
        btcingresar.Visible = True
        gbregistro.Visible = False
        btregistrar.Visible = False
    End Sub

    Private Sub btinscribirse_Click(sender As Object, e As EventArgs) Handles btinscribirse.Click
        gbregistro.Visible = True
        btregistrar.Visible = True
        gbaccediendo.Visible = False
        btcingresar.Visible = False
    End Sub

    Private Sub btcingresar_Click(sender As Object, e As EventArgs) Handles btcingresar.Click
        If tbausuario.Text = "" And tbacontraseña.Text = "" Then
            MsgBox("Debe llenar el usuario y contraseña")
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub btsuscribirse_Click(sender As Object, e As EventArgs) Handles btregistrar.Click
        gbregistro.Visible = False
        btregistrar.Visible = False
        gbaccediendo.Visible = True
        btcingresar.Visible = True
    End Sub

    Private Sub btgingresar_Click(sender As Object, e As EventArgs) Handles btgingresar.Click
        If tbgusuario.Text = "admin" And tbgcontraseña.Text = "admin" Then
            Me.Hide()
            Form7.Show()
        Else
            MsgBox("Usuario o contraseña incorrecta")
        End If
    End Sub

    Private Sub chmostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chmostrar.CheckedChanged
        If chmostrar.Checked = False Then
            tbgcontraseña.PasswordChar = "*"
        Else
            If chmostrar.Checked = True Then
                tbgcontraseña.PasswordChar = ""
            End If
        End If
    End Sub

    Private Sub btolvide_Click(sender As Object, e As EventArgs) Handles btolvide.Click
        MsgBox("Usuario: admin     Contraseña: admin", vbInformation, "Usuario & Contraseña")
    End Sub

    Private Sub chmostrar2_CheckedChanged(sender As Object, e As EventArgs) Handles chmostrar2.CheckedChanged
        If chmostrar2.Checked = False Then
            tbacontraseña.PasswordChar = "*"
        Else
            If chmostrar2.Checked = True Then
                tbacontraseña.PasswordChar = ""
            End If
        End If
    End Sub
End Class
