<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btregresar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbextra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.tbdescuento = New System.Windows.Forms.TextBox()
        Me.tbimpuesto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbsubtotal = New System.Windows.Forms.TextBox()
        Me.tbprecio = New System.Windows.Forms.TextBox()
        Me.tbservicios = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbfactura = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbpago = New System.Windows.Forms.GroupBox()
        Me.rbefectivo = New System.Windows.Forms.RadioButton()
        Me.rbcredito = New System.Windows.Forms.RadioButton()
        Me.gbespecificaciones = New System.Windows.Forms.GroupBox()
        Me.tbmodelo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chcarga = New System.Windows.Forms.CheckBox()
        Me.chbateria = New System.Windows.Forms.CheckBox()
        Me.chsoftware = New System.Windows.Forms.CheckBox()
        Me.chpantalla = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbapple = New System.Windows.Forms.RadioButton()
        Me.rbxiaomi = New System.Windows.Forms.RadioButton()
        Me.rbsamsung = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbpago.SuspendLayout()
        Me.gbespecificaciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(274, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Servicio Técnico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Smartphone Store"
        '
        'btregresar
        '
        Me.btregresar.Location = New System.Drawing.Point(12, 415)
        Me.btregresar.Name = "btregresar"
        Me.btregresar.Size = New System.Drawing.Size(75, 23)
        Me.btregresar.TabIndex = 14
        Me.btregresar.Text = "Regresar"
        Me.btregresar.UseVisualStyleBackColor = True
        '
        'btnuevo
        '
        Me.btnuevo.Location = New System.Drawing.Point(332, 346)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(104, 23)
        Me.btnuevo.TabIndex = 44
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(332, 317)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(104, 23)
        Me.btguardar.TabIndex = 43
        Me.btguardar.Text = "Guardar Factura"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'btcalcular
        '
        Me.btcalcular.Location = New System.Drawing.Point(332, 288)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(104, 23)
        Me.btcalcular.TabIndex = 42
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.tbextra)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.tbtotal)
        Me.GroupBox9.Controls.Add(Me.tbdescuento)
        Me.GroupBox9.Controls.Add(Me.tbimpuesto)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.tbsubtotal)
        Me.GroupBox9.Controls.Add(Me.tbprecio)
        Me.GroupBox9.Controls.Add(Me.tbservicios)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Location = New System.Drawing.Point(454, 211)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(326, 227)
        Me.GroupBox9.TabIndex = 41
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculos"
        '
        'tbextra
        '
        Me.tbextra.Enabled = False
        Me.tbextra.Location = New System.Drawing.Point(124, 77)
        Me.tbextra.Name = "tbextra"
        Me.tbextra.Size = New System.Drawing.Size(196, 23)
        Me.tbextra.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Extra"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total"
        '
        'tbtotal
        '
        Me.tbtotal.Enabled = False
        Me.tbtotal.Location = New System.Drawing.Point(124, 187)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(196, 23)
        Me.tbtotal.TabIndex = 11
        '
        'tbdescuento
        '
        Me.tbdescuento.Enabled = False
        Me.tbdescuento.Location = New System.Drawing.Point(124, 134)
        Me.tbdescuento.Name = "tbdescuento"
        Me.tbdescuento.Size = New System.Drawing.Size(196, 23)
        Me.tbdescuento.TabIndex = 10
        '
        'tbimpuesto
        '
        Me.tbimpuesto.Enabled = False
        Me.tbimpuesto.Location = New System.Drawing.Point(124, 161)
        Me.tbimpuesto.Name = "tbimpuesto"
        Me.tbimpuesto.Size = New System.Drawing.Size(196, 23)
        Me.tbimpuesto.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Impuesto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "SubTotal"
        '
        'tbsubtotal
        '
        Me.tbsubtotal.Enabled = False
        Me.tbsubtotal.Location = New System.Drawing.Point(124, 106)
        Me.tbsubtotal.Name = "tbsubtotal"
        Me.tbsubtotal.Size = New System.Drawing.Size(196, 23)
        Me.tbsubtotal.TabIndex = 5
        '
        'tbprecio
        '
        Me.tbprecio.Enabled = False
        Me.tbprecio.Location = New System.Drawing.Point(124, 21)
        Me.tbprecio.Name = "tbprecio"
        Me.tbprecio.Size = New System.Drawing.Size(196, 23)
        Me.tbprecio.TabIndex = 4
        '
        'tbservicios
        '
        Me.tbservicios.Enabled = False
        Me.tbservicios.Location = New System.Drawing.Point(124, 48)
        Me.tbservicios.Name = "tbservicios"
        Me.tbservicios.Size = New System.Drawing.Size(196, 23)
        Me.tbservicios.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Servicios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Precio"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbfactura)
        Me.GroupBox8.Controls.Add(Me.tbnombre)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Location = New System.Drawing.Point(454, 95)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(326, 110)
        Me.GroupBox8.TabIndex = 40
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos Generales"
        '
        'tbfactura
        '
        Me.tbfactura.Enabled = False
        Me.tbfactura.Location = New System.Drawing.Point(222, 21)
        Me.tbfactura.Name = "tbfactura"
        Me.tbfactura.Size = New System.Drawing.Size(98, 23)
        Me.tbfactura.TabIndex = 4
        Me.tbfactura.Text = "1"
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(124, 48)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(196, 23)
        Me.tbnombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre del Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No. Factura"
        '
        'gbpago
        '
        Me.gbpago.Controls.Add(Me.rbefectivo)
        Me.gbpago.Controls.Add(Me.rbcredito)
        Me.gbpago.Location = New System.Drawing.Point(14, 288)
        Me.gbpago.Name = "gbpago"
        Me.gbpago.Size = New System.Drawing.Size(202, 86)
        Me.gbpago.TabIndex = 39
        Me.gbpago.TabStop = False
        Me.gbpago.Text = "Metodos de Pago"
        '
        'rbefectivo
        '
        Me.rbefectivo.AutoSize = True
        Me.rbefectivo.Location = New System.Drawing.Point(11, 47)
        Me.rbefectivo.Name = "rbefectivo"
        Me.rbefectivo.Size = New System.Drawing.Size(67, 19)
        Me.rbefectivo.TabIndex = 26
        Me.rbefectivo.TabStop = True
        Me.rbefectivo.Text = "Efectivo"
        Me.rbefectivo.UseVisualStyleBackColor = True
        '
        'rbcredito
        '
        Me.rbcredito.AutoSize = True
        Me.rbcredito.Location = New System.Drawing.Point(11, 22)
        Me.rbcredito.Name = "rbcredito"
        Me.rbcredito.Size = New System.Drawing.Size(64, 19)
        Me.rbcredito.TabIndex = 25
        Me.rbcredito.TabStop = True
        Me.rbcredito.Text = "Credito"
        Me.rbcredito.UseVisualStyleBackColor = True
        '
        'gbespecificaciones
        '
        Me.gbespecificaciones.Controls.Add(Me.tbmodelo)
        Me.gbespecificaciones.Controls.Add(Me.Label13)
        Me.gbespecificaciones.Controls.Add(Me.chcarga)
        Me.gbespecificaciones.Controls.Add(Me.chbateria)
        Me.gbespecificaciones.Controls.Add(Me.chsoftware)
        Me.gbespecificaciones.Controls.Add(Me.chpantalla)
        Me.gbespecificaciones.Location = New System.Drawing.Point(14, 150)
        Me.gbespecificaciones.Name = "gbespecificaciones"
        Me.gbespecificaciones.Size = New System.Drawing.Size(422, 132)
        Me.gbespecificaciones.TabIndex = 37
        Me.gbespecificaciones.TabStop = False
        Me.gbespecificaciones.Text = "Especificaciones"
        '
        'tbmodelo
        '
        Me.tbmodelo.Location = New System.Drawing.Point(229, 46)
        Me.tbmodelo.Name = "tbmodelo"
        Me.tbmodelo.Size = New System.Drawing.Size(156, 23)
        Me.tbmodelo.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Modelo"
        '
        'chcarga
        '
        Me.chcarga.AutoSize = True
        Me.chcarga.Location = New System.Drawing.Point(11, 98)
        Me.chcarga.Name = "chcarga"
        Me.chcarga.Size = New System.Drawing.Size(112, 19)
        Me.chcarga.TabIndex = 5
        Me.chcarga.Text = "Centro de Carga"
        Me.chcarga.UseVisualStyleBackColor = True
        '
        'chbateria
        '
        Me.chbateria.AutoSize = True
        Me.chbateria.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chbateria.Location = New System.Drawing.Point(11, 73)
        Me.chbateria.Name = "chbateria"
        Me.chbateria.Size = New System.Drawing.Size(62, 19)
        Me.chbateria.TabIndex = 4
        Me.chbateria.Text = "Bateria"
        Me.chbateria.UseVisualStyleBackColor = True
        '
        'chsoftware
        '
        Me.chsoftware.AutoSize = True
        Me.chsoftware.Location = New System.Drawing.Point(11, 23)
        Me.chsoftware.Name = "chsoftware"
        Me.chsoftware.Size = New System.Drawing.Size(72, 19)
        Me.chsoftware.TabIndex = 2
        Me.chsoftware.Text = "Software"
        Me.chsoftware.UseVisualStyleBackColor = True
        '
        'chpantalla
        '
        Me.chpantalla.AutoSize = True
        Me.chpantalla.Location = New System.Drawing.Point(11, 48)
        Me.chpantalla.Name = "chpantalla"
        Me.chpantalla.Size = New System.Drawing.Size(68, 19)
        Me.chpantalla.TabIndex = 3
        Me.chpantalla.Text = "Pantalla"
        Me.chpantalla.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbapple)
        Me.GroupBox1.Controls.Add(Me.rbxiaomi)
        Me.GroupBox1.Controls.Add(Me.rbsamsung)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 49)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marca"
        '
        'rbapple
        '
        Me.rbapple.AutoSize = True
        Me.rbapple.Location = New System.Drawing.Point(25, 22)
        Me.rbapple.Name = "rbapple"
        Me.rbapple.Size = New System.Drawing.Size(59, 19)
        Me.rbapple.TabIndex = 15
        Me.rbapple.TabStop = True
        Me.rbapple.Text = "APPLE"
        Me.rbapple.UseVisualStyleBackColor = True
        '
        'rbxiaomi
        '
        Me.rbxiaomi.AutoSize = True
        Me.rbxiaomi.Location = New System.Drawing.Point(197, 22)
        Me.rbxiaomi.Name = "rbxiaomi"
        Me.rbxiaomi.Size = New System.Drawing.Size(69, 19)
        Me.rbxiaomi.TabIndex = 17
        Me.rbxiaomi.TabStop = True
        Me.rbxiaomi.Text = "XIAOMI "
        Me.rbxiaomi.UseVisualStyleBackColor = True
        '
        'rbsamsung
        '
        Me.rbsamsung.AutoSize = True
        Me.rbsamsung.Location = New System.Drawing.Point(100, 22)
        Me.rbsamsung.Name = "rbsamsung"
        Me.rbsamsung.Size = New System.Drawing.Size(81, 19)
        Me.rbsamsung.TabIndex = 16
        Me.rbsamsung.TabStop = True
        Me.rbsamsung.Text = "SAMSUNG"
        Me.rbsamsung.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(0, -33)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(809, 525)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnuevo)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.btcalcular)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbpago)
        Me.Controls.Add(Me.gbespecificaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btregresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbpago.ResumeLayout(False)
        Me.gbpago.PerformLayout()
        Me.gbespecificaciones.ResumeLayout(False)
        Me.gbespecificaciones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btregresar As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btcalcular As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents tbdescuento As TextBox
    Friend WithEvents tbimpuesto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbsubtotal As TextBox
    Friend WithEvents tbprecio As TextBox
    Friend WithEvents tbservicios As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbfactura As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbpago As GroupBox
    Friend WithEvents rbefectivo As RadioButton
    Friend WithEvents rbcredito As RadioButton
    Friend WithEvents gbespecificaciones As GroupBox
    Friend WithEvents chcarga As CheckBox
    Friend WithEvents chbateria As CheckBox
    Friend WithEvents chsoftware As CheckBox
    Friend WithEvents chpantalla As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbapple As RadioButton
    Friend WithEvents rbxiaomi As RadioButton
    Friend WithEvents rbsamsung As RadioButton
    Friend WithEvents tbextra As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbmodelo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
