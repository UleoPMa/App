<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel_MenuLat = New System.Windows.Forms.Panel()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.Button_min = New System.Windows.Forms.Button()
        Me.Button_Max = New System.Windows.Forms.Button()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Albun = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label_Sector = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Panel_MenuLat.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Contenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_MenuLat
        '
        Me.Panel_MenuLat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_MenuLat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_MenuLat.Controls.Add(Me.Restaurar)
        Me.Panel_MenuLat.Controls.Add(Me.Button_min)
        Me.Panel_MenuLat.Controls.Add(Me.Button_Max)
        Me.Panel_MenuLat.Controls.Add(Me.Button_Salir)
        Me.Panel_MenuLat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MenuLat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MenuLat.Name = "Panel_MenuLat"
        Me.Panel_MenuLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel_MenuLat.Size = New System.Drawing.Size(784, 52)
        Me.Panel_MenuLat.TabIndex = 8
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.BackColor = System.Drawing.Color.White
        Me.Restaurar.BackgroundImage = Global.App.My.Resources.Resources.min
        Me.Restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Restaurar.Location = New System.Drawing.Point(706, 13)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(30, 30)
        Me.Restaurar.TabIndex = 3
        Me.Restaurar.UseVisualStyleBackColor = False
        Me.Restaurar.Visible = False
        '
        'Button_min
        '
        Me.Button_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_min.BackColor = System.Drawing.Color.White
        Me.Button_min.BackgroundImage = Global.App.My.Resources.Resources.menos
        Me.Button_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_min.Location = New System.Drawing.Point(670, 12)
        Me.Button_min.Name = "Button_min"
        Me.Button_min.Size = New System.Drawing.Size(30, 30)
        Me.Button_min.TabIndex = 2
        Me.Button_min.UseVisualStyleBackColor = False
        '
        'Button_Max
        '
        Me.Button_Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Max.BackColor = System.Drawing.Color.White
        Me.Button_Max.BackgroundImage = Global.App.My.Resources.Resources.max
        Me.Button_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button_Max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Max.Location = New System.Drawing.Point(706, 13)
        Me.Button_Max.Name = "Button_Max"
        Me.Button_Max.Size = New System.Drawing.Size(30, 30)
        Me.Button_Max.TabIndex = 1
        Me.Button_Max.UseVisualStyleBackColor = False
        '
        'Button_Salir
        '
        Me.Button_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Salir.BackColor = System.Drawing.Color.White
        Me.Button_Salir.BackgroundImage = Global.App.My.Resources.Resources.close
        Me.Button_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Salir.Location = New System.Drawing.Point(742, 13)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(30, 30)
        Me.Button_Salir.TabIndex = 0
        Me.Button_Salir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Albun)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label_Sector)
        Me.Panel1.Controls.Add(Me.Label_Nombre)
        Me.Panel1.Controls.Add(Me.Boton1)
        Me.Panel1.Controls.Add(Me.Panel_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 409)
        Me.Panel1.TabIndex = 0
        '
        'Albun
        '
        Me.Albun.BackColor = System.Drawing.Color.Transparent
        Me.Albun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Albun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Albun.FlatAppearance.BorderSize = 0
        Me.Albun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Albun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albun.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Albun.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Albun.Location = New System.Drawing.Point(37, 263)
        Me.Albun.Name = "Albun"
        Me.Albun.Size = New System.Drawing.Size(140, 30)
        Me.Albun.TabIndex = 12
        Me.Albun.Text = "Musica"
        Me.Albun.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Albun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Albun.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(37, 212)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 30)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Libros"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(14, 374)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Cerrar Sesión"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label_Sector
        '
        Me.Label_Sector.AutoSize = True
        Me.Label_Sector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sector.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label_Sector.Location = New System.Drawing.Point(123, 355)
        Me.Label_Sector.Name = "Label_Sector"
        Me.Label_Sector.Size = New System.Drawing.Size(47, 16)
        Me.Label_Sector.TabIndex = 9
        Me.Label_Sector.Text = "Sector"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label_Nombre.Location = New System.Drawing.Point(40, 355)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(57, 16)
        Me.Label_Nombre.TabIndex = 0
        Me.Label_Nombre.Text = "Nombre"
        '
        'Boton1
        '
        Me.Boton1.BackColor = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Boton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Boton1.FlatAppearance.BorderSize = 0
        Me.Boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton1.Location = New System.Drawing.Point(36, 161)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Boton1.Size = New System.Drawing.Size(140, 30)
        Me.Boton1.TabIndex = 5
        Me.Boton1.Text = "Inicio"
        Me.Boton1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Boton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton1.UseVisualStyleBackColor = False
        '
        'Panel_Logo
        '
        Me.Panel_Logo.BackgroundImage = Global.App.My.Resources.Resources.Logo1
        Me.Panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_Logo.Location = New System.Drawing.Point(36, 8)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(140, 125)
        Me.Panel_Logo.TabIndex = 0
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel_Contenedor.Controls.Add(Me.LabelHora)
        Me.Panel_Contenedor.Controls.Add(Me.LabelFecha)
        Me.Panel_Contenedor.Location = New System.Drawing.Point(216, 52)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(567, 409)
        Me.Panel_Contenedor.TabIndex = 9
        '
        'LabelHora
        '
        Me.LabelHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelHora.Location = New System.Drawing.Point(203, 123)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(159, 39)
        Me.LabelHora.TabIndex = 0
        Me.LabelHora.Text = "00:00:00"
        Me.LabelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFecha
        '
        Me.LabelFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFecha.Location = New System.Drawing.Point(121, 172)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(307, 24)
        Me.LabelFecha.TabIndex = 1
        Me.LabelFecha.Text = "Miercoles 25 de agosto de 2022"
        Me.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_MenuLat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel_MenuLat.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Contenedor.ResumeLayout(False)
        Me.Panel_Contenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_MenuLat As Panel
    Friend WithEvents Button_Salir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_min As Button
    Friend WithEvents Button_Max As Button
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents Label_Sector As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Boton1 As Button
    Friend WithEvents Restaurar As Button
    Friend WithEvents TimerHora As Timer
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Albun As Button
End Class
