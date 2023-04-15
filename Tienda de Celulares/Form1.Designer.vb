<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbgerencia = New System.Windows.Forms.RadioButton()
        Me.rbcliente = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btacceder = New System.Windows.Forms.Button()
        Me.btinscribirse = New System.Windows.Forms.Button()
        Me.gbaccediendo = New System.Windows.Forms.GroupBox()
        Me.tbacontraseña = New System.Windows.Forms.TextBox()
        Me.tbausuario = New System.Windows.Forms.TextBox()
        Me.gbregistro = New System.Windows.Forms.GroupBox()
        Me.btregistrar = New System.Windows.Forms.Button()
        Me.tbrcorreo = New System.Windows.Forms.TextBox()
        Me.Correo = New System.Windows.Forms.Label()
        Me.tbrcontraseña = New System.Windows.Forms.TextBox()
        Me.tbrusuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btcingresar = New System.Windows.Forms.Button()
        Me.btgingresar = New System.Windows.Forms.Button()
        Me.gbgaccediendo = New System.Windows.Forms.GroupBox()
        Me.btolvide = New System.Windows.Forms.Button()
        Me.chmostrar = New System.Windows.Forms.CheckBox()
        Me.tbgcontraseña = New System.Windows.Forms.TextBox()
        Me.tbgusuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.chmostrar2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbaccediendo.SuspendLayout()
        Me.gbregistro.SuspendLayout()
        Me.gbgaccediendo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Smartphone Store"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbgerencia)
        Me.GroupBox1.Controls.Add(Me.rbcliente)
        Me.GroupBox1.Controls.Add(Me.btacceder)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione que Tipo de Usuario es:"
        '
        'rbgerencia
        '
        Me.rbgerencia.AutoSize = True
        Me.rbgerencia.Location = New System.Drawing.Point(18, 58)
        Me.rbgerencia.Name = "rbgerencia"
        Me.rbgerencia.Size = New System.Drawing.Size(71, 19)
        Me.rbgerencia.TabIndex = 1
        Me.rbgerencia.TabStop = True
        Me.rbgerencia.Text = "Gerencia"
        Me.rbgerencia.UseVisualStyleBackColor = True
        '
        'rbcliente
        '
        Me.rbcliente.AutoSize = True
        Me.rbcliente.Location = New System.Drawing.Point(18, 33)
        Me.rbcliente.Name = "rbcliente"
        Me.rbcliente.Size = New System.Drawing.Size(62, 19)
        Me.rbcliente.TabIndex = 0
        Me.rbcliente.TabStop = True
        Me.rbcliente.Text = "Cliente"
        Me.rbcliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña"
        '
        'btacceder
        '
        Me.btacceder.Location = New System.Drawing.Point(66, 83)
        Me.btacceder.Name = "btacceder"
        Me.btacceder.Size = New System.Drawing.Size(75, 23)
        Me.btacceder.TabIndex = 4
        Me.btacceder.Text = "Acceder"
        Me.btacceder.UseVisualStyleBackColor = True
        Me.btacceder.Visible = False
        '
        'btinscribirse
        '
        Me.btinscribirse.Location = New System.Drawing.Point(343, 216)
        Me.btinscribirse.Name = "btinscribirse"
        Me.btinscribirse.Size = New System.Drawing.Size(75, 23)
        Me.btinscribirse.TabIndex = 5
        Me.btinscribirse.Text = "Inscribirse"
        Me.btinscribirse.UseVisualStyleBackColor = True
        Me.btinscribirse.Visible = False
        '
        'gbaccediendo
        '
        Me.gbaccediendo.Controls.Add(Me.chmostrar2)
        Me.gbaccediendo.Controls.Add(Me.tbacontraseña)
        Me.gbaccediendo.Controls.Add(Me.btcingresar)
        Me.gbaccediendo.Controls.Add(Me.tbausuario)
        Me.gbaccediendo.Controls.Add(Me.Label3)
        Me.gbaccediendo.Controls.Add(Me.Label2)
        Me.gbaccediendo.Location = New System.Drawing.Point(277, 216)
        Me.gbaccediendo.Name = "gbaccediendo"
        Me.gbaccediendo.Size = New System.Drawing.Size(213, 176)
        Me.gbaccediendo.TabIndex = 2
        Me.gbaccediendo.TabStop = False
        Me.gbaccediendo.Text = "Accediendo"
        Me.gbaccediendo.Visible = False
        '
        'tbacontraseña
        '
        Me.tbacontraseña.Location = New System.Drawing.Point(98, 66)
        Me.tbacontraseña.Name = "tbacontraseña"
        Me.tbacontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbacontraseña.Size = New System.Drawing.Size(100, 23)
        Me.tbacontraseña.TabIndex = 5
        '
        'tbausuario
        '
        Me.tbausuario.Location = New System.Drawing.Point(98, 37)
        Me.tbausuario.Name = "tbausuario"
        Me.tbausuario.Size = New System.Drawing.Size(100, 23)
        Me.tbausuario.TabIndex = 4
        '
        'gbregistro
        '
        Me.gbregistro.Controls.Add(Me.btregistrar)
        Me.gbregistro.Controls.Add(Me.tbrcorreo)
        Me.gbregistro.Controls.Add(Me.Correo)
        Me.gbregistro.Controls.Add(Me.tbrcontraseña)
        Me.gbregistro.Controls.Add(Me.tbrusuario)
        Me.gbregistro.Controls.Add(Me.Label4)
        Me.gbregistro.Controls.Add(Me.Label5)
        Me.gbregistro.Location = New System.Drawing.Point(277, 216)
        Me.gbregistro.Name = "gbregistro"
        Me.gbregistro.Size = New System.Drawing.Size(213, 182)
        Me.gbregistro.TabIndex = 6
        Me.gbregistro.TabStop = False
        Me.gbregistro.Text = "Registro"
        Me.gbregistro.Visible = False
        '
        'btregistrar
        '
        Me.btregistrar.Location = New System.Drawing.Point(56, 138)
        Me.btregistrar.Name = "btregistrar"
        Me.btregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btregistrar.TabIndex = 8
        Me.btregistrar.Text = "Registrar"
        Me.btregistrar.UseVisualStyleBackColor = True
        Me.btregistrar.Visible = False
        '
        'tbrcorreo
        '
        Me.tbrcorreo.Location = New System.Drawing.Point(85, 95)
        Me.tbrcorreo.Name = "tbrcorreo"
        Me.tbrcorreo.Size = New System.Drawing.Size(100, 23)
        Me.tbrcorreo.TabIndex = 7
        '
        'Correo
        '
        Me.Correo.AutoSize = True
        Me.Correo.Location = New System.Drawing.Point(36, 98)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(43, 15)
        Me.Correo.TabIndex = 6
        Me.Correo.Text = "Correo"
        '
        'tbrcontraseña
        '
        Me.tbrcontraseña.Location = New System.Drawing.Point(85, 66)
        Me.tbrcontraseña.Name = "tbrcontraseña"
        Me.tbrcontraseña.Size = New System.Drawing.Size(100, 23)
        Me.tbrcontraseña.TabIndex = 5
        '
        'tbrusuario
        '
        Me.tbrusuario.Location = New System.Drawing.Point(85, 37)
        Me.tbrusuario.Name = "tbrusuario"
        Me.tbrusuario.Size = New System.Drawing.Size(100, 23)
        Me.tbrusuario.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Usuario"
        '
        'btcingresar
        '
        Me.btcingresar.Location = New System.Drawing.Point(66, 131)
        Me.btcingresar.Name = "btcingresar"
        Me.btcingresar.Size = New System.Drawing.Size(75, 23)
        Me.btcingresar.TabIndex = 7
        Me.btcingresar.Text = "Ingresar"
        Me.btcingresar.UseVisualStyleBackColor = True
        Me.btcingresar.Visible = False
        '
        'btgingresar
        '
        Me.btgingresar.Location = New System.Drawing.Point(69, 170)
        Me.btgingresar.Name = "btgingresar"
        Me.btgingresar.Size = New System.Drawing.Size(75, 23)
        Me.btgingresar.TabIndex = 9
        Me.btgingresar.Text = "Ingresar"
        Me.btgingresar.UseVisualStyleBackColor = True
        Me.btgingresar.Visible = False
        '
        'gbgaccediendo
        '
        Me.gbgaccediendo.Controls.Add(Me.btolvide)
        Me.gbgaccediendo.Controls.Add(Me.btgingresar)
        Me.gbgaccediendo.Controls.Add(Me.chmostrar)
        Me.gbgaccediendo.Controls.Add(Me.tbgcontraseña)
        Me.gbgaccediendo.Controls.Add(Me.tbgusuario)
        Me.gbgaccediendo.Controls.Add(Me.Label6)
        Me.gbgaccediendo.Controls.Add(Me.Label7)
        Me.gbgaccediendo.Location = New System.Drawing.Point(277, 216)
        Me.gbgaccediendo.Name = "gbgaccediendo"
        Me.gbgaccediendo.Size = New System.Drawing.Size(213, 212)
        Me.gbgaccediendo.TabIndex = 6
        Me.gbgaccediendo.TabStop = False
        Me.gbgaccediendo.Text = "Accediendo"
        Me.gbgaccediendo.Visible = False
        '
        'btolvide
        '
        Me.btolvide.Location = New System.Drawing.Point(36, 127)
        Me.btolvide.Name = "btolvide"
        Me.btolvide.Size = New System.Drawing.Size(151, 23)
        Me.btolvide.TabIndex = 10
        Me.btolvide.Text = "Olvide mi Contraseña"
        Me.btolvide.UseVisualStyleBackColor = True
        '
        'chmostrar
        '
        Me.chmostrar.AutoSize = True
        Me.chmostrar.Location = New System.Drawing.Point(27, 102)
        Me.chmostrar.Name = "chmostrar"
        Me.chmostrar.Size = New System.Drawing.Size(130, 19)
        Me.chmostrar.TabIndex = 6
        Me.chmostrar.Text = "Mostrar Contraseña"
        Me.chmostrar.UseVisualStyleBackColor = True
        '
        'tbgcontraseña
        '
        Me.tbgcontraseña.Location = New System.Drawing.Point(98, 66)
        Me.tbgcontraseña.Name = "tbgcontraseña"
        Me.tbgcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbgcontraseña.Size = New System.Drawing.Size(100, 23)
        Me.tbgcontraseña.TabIndex = 5
        '
        'tbgusuario
        '
        Me.tbgusuario.Location = New System.Drawing.Point(98, 37)
        Me.tbgusuario.Name = "tbgusuario"
        Me.tbgusuario.Size = New System.Drawing.Size(100, 23)
        Me.tbgusuario.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Usuario"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(802, 461)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'chmostrar2
        '
        Me.chmostrar2.AutoSize = True
        Me.chmostrar2.Location = New System.Drawing.Point(42, 95)
        Me.chmostrar2.Name = "chmostrar2"
        Me.chmostrar2.Size = New System.Drawing.Size(130, 19)
        Me.chmostrar2.TabIndex = 8
        Me.chmostrar2.Text = "Mostrar Contraseña"
        Me.chmostrar2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbaccediendo)
        Me.Controls.Add(Me.gbgaccediendo)
        Me.Controls.Add(Me.gbregistro)
        Me.Controls.Add(Me.btinscribirse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbaccediendo.ResumeLayout(False)
        Me.gbaccediendo.PerformLayout()
        Me.gbregistro.ResumeLayout(False)
        Me.gbregistro.PerformLayout()
        Me.gbgaccediendo.ResumeLayout(False)
        Me.gbgaccediendo.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbgerencia As RadioButton
    Friend WithEvents rbcliente As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btacceder As Button
    Friend WithEvents btinscribirse As Button
    Friend WithEvents gbaccediendo As GroupBox
    Friend WithEvents tbacontraseña As TextBox
    Friend WithEvents tbausuario As TextBox
    Friend WithEvents gbregistro As GroupBox
    Friend WithEvents tbrcontraseña As TextBox
    Friend WithEvents tbrusuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btcingresar As Button
    Friend WithEvents btregistrar As Button
    Friend WithEvents btgingresar As Button
    Friend WithEvents btgingre As Button
    Friend WithEvents gbgaccediendo As GroupBox
    Friend WithEvents tbgcontraseña As TextBox
    Friend WithEvents tbgusuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chmostrar As CheckBox
    Friend WithEvents btolvide As Button
    Friend WithEvents tbrcorreo As TextBox
    Friend WithEvents Correo As Label
    Friend WithEvents chmostrar2 As CheckBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
