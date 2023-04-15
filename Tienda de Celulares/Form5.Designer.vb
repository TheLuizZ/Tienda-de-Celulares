<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btregresar = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbimpuesto = New System.Windows.Forms.TextBox()
        Me.tbdescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbprecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbfactura = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbpago = New System.Windows.Forms.GroupBox()
        Me.rbefectivo = New System.Windows.Forms.RadioButton()
        Me.rbcredito = New System.Windows.Forms.RadioButton()
        Me.gbextras = New System.Windows.Forms.GroupBox()
        Me.chusb = New System.Windows.Forms.CheckBox()
        Me.chinalambricos = New System.Windows.Forms.CheckBox()
        Me.chparlantes = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbnormales = New System.Windows.Forms.RadioButton()
        Me.rbbluetooth = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb128 = New System.Windows.Forms.RadioButton()
        Me.rb32 = New System.Windows.Forms.RadioButton()
        Me.rb64 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbapple = New System.Windows.Forms.RadioButton()
        Me.rbxiaomi = New System.Windows.Forms.RadioButton()
        Me.rbsamsung = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbpago.SuspendLayout()
        Me.gbextras.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(309, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 37)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Accesorios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 45)
        Me.Label1.TabIndex = 9
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
        Me.btnuevo.Location = New System.Drawing.Point(298, 369)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnuevo.TabIndex = 44
        Me.btnuevo.Text = "Nuevo"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(287, 309)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(104, 23)
        Me.btguardar.TabIndex = 43
        Me.btguardar.Text = "Guardar Factura"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'btcalcular
        '
        Me.btcalcular.Location = New System.Drawing.Point(298, 254)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(75, 23)
        Me.btcalcular.TabIndex = 42
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.tbtotal)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.tbimpuesto)
        Me.GroupBox9.Controls.Add(Me.tbdescuento)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.tbprecio)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Location = New System.Drawing.Point(454, 211)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(326, 141)
        Me.GroupBox9.TabIndex = 41
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculos"
        '
        'tbtotal
        '
        Me.tbtotal.Enabled = False
        Me.tbtotal.Location = New System.Drawing.Point(124, 105)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(196, 23)
        Me.tbtotal.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total"
        '
        'tbimpuesto
        '
        Me.tbimpuesto.Enabled = False
        Me.tbimpuesto.Location = New System.Drawing.Point(124, 76)
        Me.tbimpuesto.Name = "tbimpuesto"
        Me.tbimpuesto.Size = New System.Drawing.Size(196, 23)
        Me.tbimpuesto.TabIndex = 11
        '
        'tbdescuento
        '
        Me.tbdescuento.Enabled = False
        Me.tbdescuento.Location = New System.Drawing.Point(124, 50)
        Me.tbdescuento.Name = "tbdescuento"
        Me.tbdescuento.Size = New System.Drawing.Size(196, 23)
        Me.tbdescuento.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Impuesto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Descuento"
        '
        'tbprecio
        '
        Me.tbprecio.Enabled = False
        Me.tbprecio.Location = New System.Drawing.Point(124, 21)
        Me.tbprecio.Name = "tbprecio"
        Me.tbprecio.Size = New System.Drawing.Size(196, 23)
        Me.tbprecio.TabIndex = 4
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
        Me.gbpago.Location = New System.Drawing.Point(234, 150)
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
        'gbextras
        '
        Me.gbextras.Controls.Add(Me.chusb)
        Me.gbextras.Controls.Add(Me.chinalambricos)
        Me.gbextras.Controls.Add(Me.chparlantes)
        Me.gbextras.Location = New System.Drawing.Point(14, 268)
        Me.gbextras.Name = "gbextras"
        Me.gbextras.Size = New System.Drawing.Size(208, 126)
        Me.gbextras.TabIndex = 38
        Me.gbextras.TabStop = False
        Me.gbextras.Text = "Extras"
        '
        'chusb
        '
        Me.chusb.AutoSize = True
        Me.chusb.Location = New System.Drawing.Point(14, 76)
        Me.chusb.Name = "chusb"
        Me.chusb.Size = New System.Drawing.Size(99, 19)
        Me.chusb.TabIndex = 2
        Me.chusb.Text = "Cargador USB"
        Me.chusb.UseVisualStyleBackColor = True
        '
        'chinalambricos
        '
        Me.chinalambricos.AutoSize = True
        Me.chinalambricos.Location = New System.Drawing.Point(14, 48)
        Me.chinalambricos.Name = "chinalambricos"
        Me.chinalambricos.Size = New System.Drawing.Size(141, 19)
        Me.chinalambricos.TabIndex = 1
        Me.chinalambricos.Text = "Cargador Inalambrico"
        Me.chinalambricos.UseVisualStyleBackColor = True
        '
        'chparlantes
        '
        Me.chparlantes.AutoSize = True
        Me.chparlantes.Location = New System.Drawing.Point(14, 22)
        Me.chparlantes.Name = "chparlantes"
        Me.chparlantes.Size = New System.Drawing.Size(74, 19)
        Me.chparlantes.TabIndex = 0
        Me.chparlantes.Text = "Parlantes"
        Me.chparlantes.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbnormales)
        Me.GroupBox5.Controls.Add(Me.rbbluetooth)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 209)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 53)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Auriculares"
        '
        'rbnormales
        '
        Me.rbnormales.AutoSize = True
        Me.rbnormales.Location = New System.Drawing.Point(8, 22)
        Me.rbnormales.Name = "rbnormales"
        Me.rbnormales.Size = New System.Drawing.Size(76, 19)
        Me.rbnormales.TabIndex = 18
        Me.rbnormales.TabStop = True
        Me.rbnormales.Text = "Normales"
        Me.rbnormales.UseVisualStyleBackColor = True
        '
        'rbbluetooth
        '
        Me.rbbluetooth.AutoSize = True
        Me.rbbluetooth.Location = New System.Drawing.Point(94, 22)
        Me.rbbluetooth.Name = "rbbluetooth"
        Me.rbbluetooth.Size = New System.Drawing.Size(77, 19)
        Me.rbbluetooth.TabIndex = 24
        Me.rbbluetooth.TabStop = True
        Me.rbbluetooth.Text = "bluetooth"
        Me.rbbluetooth.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb128)
        Me.GroupBox4.Controls.Add(Me.rb32)
        Me.GroupBox4.Controls.Add(Me.rb64)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 53)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Memorias MicroSD"
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
        Me.GroupBox1.Text = "Cobertores"
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
        Me.PictureBox5.Location = New System.Drawing.Point(0, -45)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(809, 525)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnuevo)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.btcalcular)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.gbpago)
        Me.Controls.Add(Me.gbextras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btregresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbpago.ResumeLayout(False)
        Me.gbpago.PerformLayout()
        Me.gbextras.ResumeLayout(False)
        Me.gbextras.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbimpuesto As TextBox
    Friend WithEvents tbdescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbprecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbfactura As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbpago As GroupBox
    Friend WithEvents rbefectivo As RadioButton
    Friend WithEvents rbcredito As RadioButton
    Friend WithEvents gbextras As GroupBox
    Friend WithEvents chinalambricos As CheckBox
    Friend WithEvents chparlantes As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbnormales As RadioButton
    Friend WithEvents rbbluetooth As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rb128 As RadioButton
    Friend WithEvents rb32 As RadioButton
    Friend WithEvents rb64 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbapple As RadioButton
    Friend WithEvents rbxiaomi As RadioButton
    Friend WithEvents rbsamsung As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chusb As CheckBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
