<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btregresar = New System.Windows.Forms.Button()
        Me.rbapple = New System.Windows.Forms.RadioButton()
        Me.rbsamsung = New System.Windows.Forms.RadioButton()
        Me.rbxiaomi = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbapple = New System.Windows.Forms.ComboBox()
        Me.cbsamsung = New System.Windows.Forms.ComboBox()
        Me.cbxiaomi = New System.Windows.Forms.ComboBox()
        Me.gbespecificaciones = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbblanco = New System.Windows.Forms.RadioButton()
        Me.rbnegro = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb128 = New System.Windows.Forms.RadioButton()
        Me.rb32 = New System.Windows.Forms.RadioButton()
        Me.rb64 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gbextras = New System.Windows.Forms.GroupBox()
        Me.chtemplado = New System.Windows.Forms.CheckBox()
        Me.chcobertor = New System.Windows.Forms.CheckBox()
        Me.gbpago = New System.Windows.Forms.GroupBox()
        Me.rbefectivo = New System.Windows.Forms.RadioButton()
        Me.rbcredito = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbfactura = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbimpuesto = New System.Windows.Forms.TextBox()
        Me.tbsubtotal = New System.Windows.Forms.TextBox()
        Me.tbdescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbextra = New System.Windows.Forms.TextBox()
        Me.tbprecio = New System.Windows.Forms.TextBox()
        Me.tbalmacenamiento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbespecificaciones.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbextras.SuspendLayout()
        Me.gbpago.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(330, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Celulares"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 45)
        Me.Label1.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbapple)
        Me.GroupBox1.Controls.Add(Me.rbxiaomi)
        Me.GroupBox1.Controls.Add(Me.rbsamsung)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 49)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marca"
        '
        'cbapple
        '
        Me.cbapple.FormattingEnabled = True
        Me.cbapple.Items.AddRange(New Object() {"Apple iPhone 12", "Apple iPhone 11", "Apple iPhone X", "Apple iPhone 8", "Apple iPhone 7"})
        Me.cbapple.Location = New System.Drawing.Point(8, 22)
        Me.cbapple.Name = "cbapple"
        Me.cbapple.Size = New System.Drawing.Size(188, 23)
        Me.cbapple.TabIndex = 19
        Me.cbapple.Visible = False
        '
        'cbsamsung
        '
        Me.cbsamsung.FormattingEnabled = True
        Me.cbsamsung.Items.AddRange(New Object() {"Samsung Galaxy S20", "Samsung Galaxy S10", "Samsung Galaxy S9", "Samsung Galaxy S8", "Samsung Galaxy S7"})
        Me.cbsamsung.Location = New System.Drawing.Point(8, 22)
        Me.cbsamsung.Name = "cbsamsung"
        Me.cbsamsung.Size = New System.Drawing.Size(194, 23)
        Me.cbsamsung.TabIndex = 20
        Me.cbsamsung.Visible = False
        '
        'cbxiaomi
        '
        Me.cbxiaomi.FormattingEnabled = True
        Me.cbxiaomi.Items.AddRange(New Object() {"Xiaomi Mi 10", "POCO X3", "Xiaomi Redmi 9", "Xiaomi Redmi Note 9"})
        Me.cbxiaomi.Location = New System.Drawing.Point(8, 22)
        Me.cbxiaomi.Name = "cbxiaomi"
        Me.cbxiaomi.Size = New System.Drawing.Size(194, 23)
        Me.cbxiaomi.TabIndex = 21
        Me.cbxiaomi.Visible = False
        '
        'gbespecificaciones
        '
        Me.gbespecificaciones.Controls.Add(Me.GroupBox5)
        Me.gbespecificaciones.Controls.Add(Me.GroupBox4)
        Me.gbespecificaciones.Controls.Add(Me.GroupBox3)
        Me.gbespecificaciones.Location = New System.Drawing.Point(22, 165)
        Me.gbespecificaciones.Name = "gbespecificaciones"
        Me.gbespecificaciones.Size = New System.Drawing.Size(422, 152)
        Me.gbespecificaciones.TabIndex = 23
        Me.gbespecificaciones.TabStop = False
        Me.gbespecificaciones.Text = "Especificaciones"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbblanco)
        Me.GroupBox5.Controls.Add(Me.rbnegro)
        Me.GroupBox5.Location = New System.Drawing.Point(220, 86)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(183, 53)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Color"
        '
        'rbblanco
        '
        Me.rbblanco.AutoSize = True
        Me.rbblanco.Location = New System.Drawing.Point(8, 22)
        Me.rbblanco.Name = "rbblanco"
        Me.rbblanco.Size = New System.Drawing.Size(61, 19)
        Me.rbblanco.TabIndex = 18
        Me.rbblanco.TabStop = True
        Me.rbblanco.Text = "Blanco"
        Me.rbblanco.UseVisualStyleBackColor = True
        '
        'rbnegro
        '
        Me.rbnegro.AutoSize = True
        Me.rbnegro.Location = New System.Drawing.Point(94, 22)
        Me.rbnegro.Name = "rbnegro"
        Me.rbnegro.Size = New System.Drawing.Size(58, 19)
        Me.rbnegro.TabIndex = 24
        Me.rbnegro.TabStop = True
        Me.rbnegro.Text = "Negro"
        Me.rbnegro.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb128)
        Me.GroupBox4.Controls.Add(Me.rb32)
        Me.GroupBox4.Controls.Add(Me.rb64)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 53)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Almacenamiento"
        '
        'rb128
        '
        Me.rb128.AutoSize = True
        Me.rb128.Location = New System.Drawing.Point(135, 22)
        Me.rb128.Name = "rb128"
        Me.rb128.Size = New System.Drawing.Size(61, 19)
        Me.rb128.TabIndex = 25
        Me.rb128.TabStop = True
        Me.rb128.Text = "128 Gb"
        Me.rb128.UseVisualStyleBackColor = True
        '
        'rb32
        '
        Me.rb32.AutoSize = True
        Me.rb32.Location = New System.Drawing.Point(8, 22)
        Me.rb32.Name = "rb32"
        Me.rb32.Size = New System.Drawing.Size(55, 19)
        Me.rb32.TabIndex = 18
        Me.rb32.TabStop = True
        Me.rb32.Text = "32 Gb"
        Me.rb32.UseVisualStyleBackColor = True
        '
        'rb64
        '
        Me.rb64.AutoSize = True
        Me.rb64.Location = New System.Drawing.Point(69, 22)
        Me.rb64.Name = "rb64"
        Me.rb64.Size = New System.Drawing.Size(55, 19)
        Me.rb64.TabIndex = 24
        Me.rb64.TabStop = True
        Me.rb64.Text = "64 Gb"
        Me.rb64.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxiaomi)
        Me.GroupBox3.Controls.Add(Me.cbsamsung)
        Me.GroupBox3.Controls.Add(Me.cbapple)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 58)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modelos"
        '
        'gbextras
        '
        Me.gbextras.Controls.Add(Me.chtemplado)
        Me.gbextras.Controls.Add(Me.chcobertor)
        Me.gbextras.Location = New System.Drawing.Point(22, 323)
        Me.gbextras.Name = "gbextras"
        Me.gbextras.Size = New System.Drawing.Size(208, 86)
        Me.gbextras.TabIndex = 29
        Me.gbextras.TabStop = False
        Me.gbextras.Text = "Extras"
        '
        'chtemplado
        '
        Me.chtemplado.AutoSize = True
        Me.chtemplado.Location = New System.Drawing.Point(14, 48)
        Me.chtemplado.Name = "chtemplado"
        Me.chtemplado.Size = New System.Drawing.Size(112, 19)
        Me.chtemplado.TabIndex = 1
        Me.chtemplado.Text = "Vidrio Templado"
        Me.chtemplado.UseVisualStyleBackColor = True
        '
        'chcobertor
        '
        Me.chcobertor.AutoSize = True
        Me.chcobertor.Location = New System.Drawing.Point(14, 22)
        Me.chcobertor.Name = "chcobertor"
        Me.chcobertor.Size = New System.Drawing.Size(73, 19)
        Me.chcobertor.TabIndex = 0
        Me.chcobertor.Text = "Cobertor"
        Me.chcobertor.UseVisualStyleBackColor = True
        '
        'gbpago
        '
        Me.gbpago.Controls.Add(Me.rbefectivo)
        Me.gbpago.Controls.Add(Me.rbcredito)
        Me.gbpago.Location = New System.Drawing.Point(242, 323)
        Me.gbpago.Name = "gbpago"
        Me.gbpago.Size = New System.Drawing.Size(202, 86)
        Me.gbpago.TabIndex = 30
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbfactura)
        Me.GroupBox8.Controls.Add(Me.tbnombre)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Location = New System.Drawing.Point(462, 110)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(326, 110)
        Me.GroupBox8.TabIndex = 31
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
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.tbtotal)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.tbimpuesto)
        Me.GroupBox9.Controls.Add(Me.tbsubtotal)
        Me.GroupBox9.Controls.Add(Me.tbdescuento)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.tbextra)
        Me.GroupBox9.Controls.Add(Me.tbprecio)
        Me.GroupBox9.Controls.Add(Me.tbalmacenamiento)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Location = New System.Drawing.Point(462, 226)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(326, 212)
        Me.GroupBox9.TabIndex = 32
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculos"
        '
        'tbtotal
        '
        Me.tbtotal.Enabled = False
        Me.tbtotal.Location = New System.Drawing.Point(124, 184)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(196, 23)
        Me.tbtotal.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total"
        '
        'tbimpuesto
        '
        Me.tbimpuesto.Enabled = False
        Me.tbimpuesto.Location = New System.Drawing.Point(124, 155)
        Me.tbimpuesto.Name = "tbimpuesto"
        Me.tbimpuesto.Size = New System.Drawing.Size(196, 23)
        Me.tbimpuesto.TabIndex = 11
        '
        'tbsubtotal
        '
        Me.tbsubtotal.Enabled = False
        Me.tbsubtotal.Location = New System.Drawing.Point(124, 102)
        Me.tbsubtotal.Name = "tbsubtotal"
        Me.tbsubtotal.Size = New System.Drawing.Size(196, 23)
        Me.tbsubtotal.TabIndex = 10
        '
        'tbdescuento
        '
        Me.tbdescuento.Enabled = False
        Me.tbdescuento.Location = New System.Drawing.Point(124, 129)
        Me.tbdescuento.Name = "tbdescuento"
        Me.tbdescuento.Size = New System.Drawing.Size(196, 23)
        Me.tbdescuento.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Impuesto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "SubTotal"
        '
        'tbextra
        '
        Me.tbextra.Enabled = False
        Me.tbextra.Location = New System.Drawing.Point(124, 74)
        Me.tbextra.Name = "tbextra"
        Me.tbextra.Size = New System.Drawing.Size(196, 23)
        Me.tbextra.TabIndex = 5
        '
        'tbprecio
        '
        Me.tbprecio.Enabled = False
        Me.tbprecio.Location = New System.Drawing.Point(124, 21)
        Me.tbprecio.Name = "tbprecio"
        Me.tbprecio.Size = New System.Drawing.Size(196, 23)
        Me.tbprecio.TabIndex = 4
        '
        'tbalmacenamiento
        '
        Me.tbalmacenamiento.Enabled = False
        Me.tbalmacenamiento.Location = New System.Drawing.Point(124, 48)
        Me.tbalmacenamiento.Name = "tbalmacenamiento"
        Me.tbalmacenamiento.Size = New System.Drawing.Size(196, 23)
        Me.tbalmacenamiento.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Extra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Almacenamiento"
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
        'btcalcular
        '
        Me.btcalcular.Location = New System.Drawing.Point(586, 81)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(75, 23)
        Me.btcalcular.TabIndex = 33
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(684, 81)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(104, 23)
        Me.btguardar.TabIndex = 34
        Me.btguardar.Text = "Guardar Factura"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'btnuevo
        '
        Me.btnuevo.Location = New System.Drawing.Point(369, 415)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnuevo.TabIndex = 35
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(0, -32)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(809, 525)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 36
        Me.PictureBox5.TabStop = False
        '
        'Form3
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
        Me.Controls.Add(Me.gbextras)
        Me.Controls.Add(Me.gbespecificaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btregresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbespecificaciones.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.gbextras.ResumeLayout(False)
        Me.gbextras.PerformLayout()
        Me.gbpago.ResumeLayout(False)
        Me.gbpago.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btregresar As Button
    Friend WithEvents rbapple As RadioButton
    Friend WithEvents rbsamsung As RadioButton
    Friend WithEvents rbxiaomi As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbapple As ComboBox
    Friend WithEvents cbsamsung As ComboBox
    Friend WithEvents cbxiaomi As ComboBox
    Friend WithEvents gbespecificaciones As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbblanco As RadioButton
    Friend WithEvents rbnegro As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rb128 As RadioButton
    Friend WithEvents rb32 As RadioButton
    Friend WithEvents rb64 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gbextras As GroupBox
    Friend WithEvents chtemplado As CheckBox
    Friend WithEvents chcobertor As CheckBox
    Friend WithEvents gbpago As GroupBox
    Friend WithEvents rbefectivo As RadioButton
    Friend WithEvents rbcredito As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbfactura As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbimpuesto As TextBox
    Friend WithEvents tbsubtotal As TextBox
    Friend WithEvents tbdescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbextra As TextBox
    Friend WithEvents tbprecio As TextBox
    Friend WithEvents tbalmacenamiento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btcalcular As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
