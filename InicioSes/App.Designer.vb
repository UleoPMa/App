<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Txt_passwords = New System.Windows.Forms.TextBox()
        Me.Iniciar_sesion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ComboBoxUsuarios = New System.Windows.Forms.ComboBox()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Boton_Ocultar = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Minimizar)
        Me.Panel1.Controls.Add(Me.Cerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(310, 40)
        Me.Panel1.TabIndex = 0
        '
        'Minimizar
        '
        Me.Minimizar.BackColor = System.Drawing.Color.White
        Me.Minimizar.BackgroundImage = Global.App.My.Resources.Resources.menos
        Me.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar.Location = New System.Drawing.Point(245, 7)
        Me.Minimizar.Margin = New System.Windows.Forms.Padding(5)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Padding = New System.Windows.Forms.Padding(100)
        Me.Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.White
        Me.Cerrar.BackgroundImage = Global.App.My.Resources.Resources.close
        Me.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar.Location = New System.Drawing.Point(276, 7)
        Me.Cerrar.Margin = New System.Windows.Forms.Padding(5)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Padding = New System.Windows.Forms.Padding(100)
        Me.Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Cerrar.TabIndex = 1
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Txt_passwords
        '
        Me.Txt_passwords.Location = New System.Drawing.Point(30, 268)
        Me.Txt_passwords.Name = "Txt_passwords"
        Me.Txt_passwords.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_passwords.Size = New System.Drawing.Size(250, 20)
        Me.Txt_passwords.TabIndex = 3
        Me.Txt_passwords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Iniciar_sesion
        '
        Me.Iniciar_sesion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Iniciar_sesion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Iniciar_sesion.Location = New System.Drawing.Point(185, 335)
        Me.Iniciar_sesion.Name = "Iniciar_sesion"
        Me.Iniciar_sesion.Size = New System.Drawing.Size(95, 30)
        Me.Iniciar_sesion.TabIndex = 4
        Me.Iniciar_sesion.Text = "Iniciar Sesión"
        Me.Iniciar_sesion.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(310, 18)
        Me.Panel2.TabIndex = 3
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelUsuario.Location = New System.Drawing.Point(29, 184)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(67, 19)
        Me.LabelUsuario.TabIndex = 5
        Me.LabelUsuario.Text = "Usuario"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelPassword.Location = New System.Drawing.Point(29, 241)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(93, 19)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "Contraseña"
        '
        'ComboBoxUsuarios
        '
        Me.ComboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsuarios.FormattingEnabled = True
        Me.ComboBoxUsuarios.Items.AddRange(New Object() {"Ulises", "Jimena", "Buan Josco", "Bob", "Jisus"})
        Me.ComboBoxUsuarios.Location = New System.Drawing.Point(30, 212)
        Me.ComboBoxUsuarios.Name = "ComboBoxUsuarios"
        Me.ComboBoxUsuarios.Size = New System.Drawing.Size(250, 21)
        Me.ComboBoxUsuarios.TabIndex = 8
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 25
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 25
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MintCream
        Me.LinkLabel1.Location = New System.Drawing.Point(90, 305)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Olvidaste tu contraseña?"
        '
        'Boton_Ocultar
        '
        Me.Boton_Ocultar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Boton_Ocultar.BackColor = System.Drawing.Color.White
        Me.Boton_Ocultar.BackgroundImage = Global.App.My.Resources.Resources.password
        Me.Boton_Ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Boton_Ocultar.FlatAppearance.BorderSize = 0
        Me.Boton_Ocultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Ocultar.Location = New System.Drawing.Point(248, 270)
        Me.Boton_Ocultar.Name = "Boton_Ocultar"
        Me.Boton_Ocultar.Size = New System.Drawing.Size(30, 16)
        Me.Boton_Ocultar.TabIndex = 10
        Me.Boton_Ocultar.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Logo.BackgroundImage = Global.App.My.Resources.Resources.Logo1
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Logo.Location = New System.Drawing.Point(93, 56)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(125, 125)
        Me.Logo.TabIndex = 1
        Me.Logo.TabStop = False
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(310, 400)
        Me.Controls.Add(Me.Boton_Ocultar)
        Me.Controls.Add(Me.ComboBoxUsuarios)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Iniciar_sesion)
        Me.Controls.Add(Me.Txt_passwords)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cerrar As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Txt_passwords As TextBox
    Friend WithEvents Iniciar_sesion As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ComboBoxUsuarios As ComboBox
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Boton_Ocultar As Button
End Class
