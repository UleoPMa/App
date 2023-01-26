<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecuperarPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperarPass))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ComboBoxUsuarios = New System.Windows.Forms.ComboBox()
        Me.Txt_correos = New System.Windows.Forms.TextBox()
        Me.Enviar_Solicitud = New System.Windows.Forms.Button()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.Abrir = New System.Windows.Forms.Timer(Me.components)
        Me.Cerar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(310, 18)
        Me.Panel2.TabIndex = 5
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
        Me.Panel1.TabIndex = 4
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
        Me.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar.Location = New System.Drawing.Point(276, 7)
        Me.Cerrar.Margin = New System.Windows.Forms.Padding(5)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Padding = New System.Windows.Forms.Padding(100)
        Me.Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Cerrar.TabIndex = 1
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Logo.BackgroundImage = Global.App.My.Resources.Resources.Logo1
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Logo.Location = New System.Drawing.Point(96, 54)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(140, 125)
        Me.Logo.TabIndex = 6
        Me.Logo.TabStop = False
        '
        'ComboBoxUsuarios
        '
        Me.ComboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsuarios.FormattingEnabled = True
        Me.ComboBoxUsuarios.Items.AddRange(New Object() {"Ulises", "Jimena", "Buan Josco", "Bob", "Jisus"})
        Me.ComboBoxUsuarios.Location = New System.Drawing.Point(33, 217)
        Me.ComboBoxUsuarios.Name = "ComboBoxUsuarios"
        Me.ComboBoxUsuarios.Size = New System.Drawing.Size(250, 21)
        Me.ComboBoxUsuarios.TabIndex = 9
        '
        'Txt_correos
        '
        Me.Txt_correos.Location = New System.Drawing.Point(33, 273)
        Me.Txt_correos.Name = "Txt_correos"
        Me.Txt_correos.ReadOnly = True
        Me.Txt_correos.Size = New System.Drawing.Size(250, 20)
        Me.Txt_correos.TabIndex = 10
        Me.Txt_correos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Enviar_Solicitud
        '
        Me.Enviar_Solicitud.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Enviar_Solicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Enviar_Solicitud.Location = New System.Drawing.Point(188, 315)
        Me.Enviar_Solicitud.Name = "Enviar_Solicitud"
        Me.Enviar_Solicitud.Size = New System.Drawing.Size(95, 30)
        Me.Enviar_Solicitud.TabIndex = 11
        Me.Enviar_Solicitud.Text = "Enviar"
        Me.Enviar_Solicitud.UseVisualStyleBackColor = False
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelUsuario.Location = New System.Drawing.Point(32, 193)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(161, 19)
        Me.LabelUsuario.TabIndex = 12
        Me.LabelUsuario.Text = "Usuarios registrados"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(32, 251)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(146, 19)
        Me.LabelCorreo.TabIndex = 13
        Me.LabelCorreo.Text = "Correo Electrónico"
        '
        'Abrir
        '
        Me.Abrir.Interval = 25
        '
        'Cerar
        '
        Me.Cerar.Interval = 25
        '
        'RecuperarPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(310, 400)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.Enviar_Solicitud)
        Me.Controls.Add(Me.Txt_correos)
        Me.Controls.Add(Me.ComboBoxUsuarios)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecuperarPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecuperarPass"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Minimizar As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents ComboBoxUsuarios As ComboBox
    Friend WithEvents Txt_correos As TextBox
    Friend WithEvents Enviar_Solicitud As Button
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents Abrir As Timer
    Friend WithEvents Cerar As Timer
End Class
