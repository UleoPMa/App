<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.LabelBienvenida = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Labeltexto = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelSector = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BotonIniciar = New System.Windows.Forms.Button()
        Me.BarraDeProg = New System.Windows.Forms.ProgressBar()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCargando = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBienvenida
        '
        Me.LabelBienvenida.AutoSize = True
        Me.LabelBienvenida.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBienvenida.Location = New System.Drawing.Point(196, 68)
        Me.LabelBienvenida.Name = "LabelBienvenida"
        Me.LabelBienvenida.Size = New System.Drawing.Size(145, 28)
        Me.LabelBienvenida.TabIndex = 6
        Me.LabelBienvenida.Text = "Bienvenid@"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(550, 45)
        Me.Panel1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.App.My.Resources.Resources.menos
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(477, 12)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(100)
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.App.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(508, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(100)
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Labeltexto
        '
        Me.Labeltexto.AutoSize = True
        Me.Labeltexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltexto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labeltexto.Location = New System.Drawing.Point(444, -1)
        Me.Labeltexto.Name = "Labeltexto"
        Me.Labeltexto.Size = New System.Drawing.Size(92, 18)
        Me.Labeltexto.TabIndex = 8
        Me.Labeltexto.Text = "Informática"
        '
        'correo
        '
        Me.correo.AutoSize = True
        Me.correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.correo.Location = New System.Drawing.Point(26, 142)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(68, 24)
        Me.correo.TabIndex = 10
        Me.correo.Text = "Correo"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(26, 120)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 24)
        Me.LabelNombre.TabIndex = 12
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelEdad
        '
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelEdad.Location = New System.Drawing.Point(28, 166)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(55, 24)
        Me.LabelEdad.TabIndex = 15
        Me.LabelEdad.Text = "Edad"
        '
        'LabelSector
        '
        Me.LabelSector.AutoSize = True
        Me.LabelSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSector.Location = New System.Drawing.Point(28, 192)
        Me.LabelSector.Name = "LabelSector"
        Me.LabelSector.Size = New System.Drawing.Size(64, 24)
        Me.LabelSector.TabIndex = 14
        Me.LabelSector.Text = "Sector"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Labeltexto)
        Me.Panel2.Location = New System.Drawing.Point(2, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(550, 18)
        Me.Panel2.TabIndex = 16
        '
        'BotonIniciar
        '
        Me.BotonIniciar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BotonIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BotonIniciar.Location = New System.Drawing.Point(443, 234)
        Me.BotonIniciar.Name = "BotonIniciar"
        Me.BotonIniciar.Size = New System.Drawing.Size(95, 30)
        Me.BotonIniciar.TabIndex = 17
        Me.BotonIniciar.Text = "Contraseña"
        Me.BotonIniciar.UseVisualStyleBackColor = False
        '
        'BarraDeProg
        '
        Me.BarraDeProg.ForeColor = System.Drawing.Color.Lime
        Me.BarraDeProg.Location = New System.Drawing.Point(157, 209)
        Me.BarraDeProg.Name = "BarraDeProg"
        Me.BarraDeProg.Size = New System.Drawing.Size(214, 30)
        Me.BarraDeProg.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.BarraDeProg.TabIndex = 18
        Me.BarraDeProg.Value = 5
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 30
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 30
        '
        'LabelCargando
        '
        Me.LabelCargando.AutoSize = True
        Me.LabelCargando.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCargando.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCargando.Location = New System.Drawing.Point(341, 182)
        Me.LabelCargando.Name = "LabelCargando"
        Me.LabelCargando.Size = New System.Drawing.Size(30, 24)
        Me.LabelCargando.TabIndex = 19
        Me.LabelCargando.Text = "00"
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(550, 300)
        Me.Controls.Add(Me.LabelCargando)
        Me.Controls.Add(Me.BarraDeProg)
        Me.Controls.Add(Me.BotonIniciar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelEdad)
        Me.Controls.Add(Me.LabelSector)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelBienvenida)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBienvenida As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Labeltexto As Label
    Friend WithEvents correo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelEdad As Label
    Friend WithEvents LabelSector As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BotonIniciar As Button
    Friend WithEvents BarraDeProg As ProgressBar
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents LabelCargando As Label
End Class
