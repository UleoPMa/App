<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Album_Musica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Album_Musica))
        Me.Boton_Reiniciar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.LabelG = New System.Windows.Forms.Label()
        Me.LabelNC = New System.Windows.Forms.Label()
        Me.NoCasMus = New System.Windows.Forms.TextBox()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.ArtistaMus = New System.Windows.Forms.TextBox()
        Me.LabelN = New System.Windows.Forms.Label()
        Me.NAlbumMus = New System.Windows.Forms.TextBox()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.CodigoMus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_registro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Grid_Album_Musica = New System.Windows.Forms.DataGridView()
        Me.LabelL = New System.Windows.Forms.Label()
        Me.AñoLanMus = New System.Windows.Forms.TextBox()
        Me.GeneroMus = New System.Windows.Forms.TextBox()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonConsulta = New System.Windows.Forms.Button()
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.label_CritBusqueda = New System.Windows.Forms.Label()
        Me.cb_CritBusqueda = New System.Windows.Forms.ComboBox()
        Me.label_BNomAl = New System.Windows.Forms.Label()
        Me.label_BCodigo = New System.Windows.Forms.Label()
        Me.label_BArtista = New System.Windows.Forms.Label()
        Me.label_BNoCan = New System.Windows.Forms.Label()
        Me.label_BGenero = New System.Windows.Forms.Label()
        Me.label_BAñoLan = New System.Windows.Forms.Label()
        Me.txt_BCodigo = New System.Windows.Forms.TextBox()
        Me.txt_BNombre = New System.Windows.Forms.TextBox()
        Me.txt_BArtista = New System.Windows.Forms.TextBox()
        Me.txt_NoCan = New System.Windows.Forms.TextBox()
        Me.txt_BGenero = New System.Windows.Forms.TextBox()
        Me.txt_AñoLan = New System.Windows.Forms.TextBox()
        CType(Me.Grid_Album_Musica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton_Reiniciar
        '
        Me.Boton_Reiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_Reiniciar.Location = New System.Drawing.Point(274, 365)
        Me.Boton_Reiniciar.Name = "Boton_Reiniciar"
        Me.Boton_Reiniciar.Size = New System.Drawing.Size(84, 31)
        Me.Boton_Reiniciar.TabIndex = 68
        Me.Boton_Reiniciar.Text = "Reiniciar"
        Me.Boton_Reiniciar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Location = New System.Drawing.Point(372, 366)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(84, 31)
        Me.Button_Eliminar.TabIndex = 67
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'LabelG
        '
        Me.LabelG.AutoSize = True
        Me.LabelG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG.Location = New System.Drawing.Point(12, 262)
        Me.LabelG.Name = "LabelG"
        Me.LabelG.Size = New System.Drawing.Size(67, 20)
        Me.LabelG.TabIndex = 65
        Me.LabelG.Text = "Genero:"
        '
        'LabelNC
        '
        Me.LabelNC.AutoSize = True
        Me.LabelNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNC.Location = New System.Drawing.Point(12, 212)
        Me.LabelNC.Name = "LabelNC"
        Me.LabelNC.Size = New System.Drawing.Size(167, 20)
        Me.LabelNC.TabIndex = 64
        Me.LabelNC.Text = "Número de canciones:"
        '
        'NoCasMus
        '
        Me.NoCasMus.Location = New System.Drawing.Point(12, 236)
        Me.NoCasMus.Name = "NoCasMus"
        Me.NoCasMus.Size = New System.Drawing.Size(143, 20)
        Me.NoCasMus.TabIndex = 63
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelA.Location = New System.Drawing.Point(12, 166)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(59, 20)
        Me.LabelA.TabIndex = 62
        Me.LabelA.Text = "Artista:"
        '
        'ArtistaMus
        '
        Me.ArtistaMus.Location = New System.Drawing.Point(12, 187)
        Me.ArtistaMus.Name = "ArtistaMus"
        Me.ArtistaMus.Size = New System.Drawing.Size(143, 20)
        Me.ArtistaMus.TabIndex = 61
        '
        'LabelN
        '
        Me.LabelN.AutoSize = True
        Me.LabelN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelN.Location = New System.Drawing.Point(12, 120)
        Me.LabelN.Name = "LabelN"
        Me.LabelN.Size = New System.Drawing.Size(118, 20)
        Me.LabelN.TabIndex = 60
        Me.LabelN.Text = "Nombre Álbum:"
        '
        'NAlbumMus
        '
        Me.NAlbumMus.Location = New System.Drawing.Point(11, 142)
        Me.NAlbumMus.Name = "NAlbumMus"
        Me.NAlbumMus.Size = New System.Drawing.Size(143, 20)
        Me.NAlbumMus.TabIndex = 59
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelC.Location = New System.Drawing.Point(12, 70)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(63, 20)
        Me.LabelC.TabIndex = 58
        Me.LabelC.Text = "Código:"
        '
        'CodigoMus
        '
        Me.CodigoMus.Location = New System.Drawing.Point(16, 96)
        Me.CodigoMus.Name = "CodigoMus"
        Me.CodigoMus.Size = New System.Drawing.Size(143, 20)
        Me.CodigoMus.TabIndex = 57
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(470, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 31)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXT_registro
        '
        Me.TXT_registro.AutoSize = True
        Me.TXT_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_registro.Location = New System.Drawing.Point(514, 59)
        Me.TXT_registro.Name = "TXT_registro"
        Me.TXT_registro.Size = New System.Drawing.Size(29, 20)
        Me.TXT_registro.TabIndex = 55
        Me.TXT_registro.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Registros:"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTitulo.Location = New System.Drawing.Point(215, 21)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(106, 31)
        Me.LabelTitulo.TabIndex = 53
        Me.LabelTitulo.Text = "Musica"
        '
        'Grid_Album_Musica
        '
        Me.Grid_Album_Musica.AllowUserToAddRows = False
        Me.Grid_Album_Musica.AllowUserToResizeColumns = False
        Me.Grid_Album_Musica.AllowUserToResizeRows = False
        Me.Grid_Album_Musica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid_Album_Musica.BackgroundColor = System.Drawing.Color.White
        Me.Grid_Album_Musica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid_Album_Musica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Album_Musica.GridColor = System.Drawing.SystemColors.Control
        Me.Grid_Album_Musica.Location = New System.Drawing.Point(181, 82)
        Me.Grid_Album_Musica.Name = "Grid_Album_Musica"
        Me.Grid_Album_Musica.ReadOnly = True
        Me.Grid_Album_Musica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_Album_Musica.Size = New System.Drawing.Size(375, 268)
        Me.Grid_Album_Musica.TabIndex = 52
        '
        'LabelL
        '
        Me.LabelL.AutoSize = True
        Me.LabelL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelL.Location = New System.Drawing.Point(12, 310)
        Me.LabelL.Name = "LabelL"
        Me.LabelL.Size = New System.Drawing.Size(138, 20)
        Me.LabelL.TabIndex = 70
        Me.LabelL.Text = "Año Lanzamiento:"
        '
        'AñoLanMus
        '
        Me.AñoLanMus.Location = New System.Drawing.Point(12, 332)
        Me.AñoLanMus.Name = "AñoLanMus"
        Me.AñoLanMus.Size = New System.Drawing.Size(143, 20)
        Me.AñoLanMus.TabIndex = 71
        '
        'GeneroMus
        '
        Me.GeneroMus.Location = New System.Drawing.Point(11, 284)
        Me.GeneroMus.Name = "GeneroMus"
        Me.GeneroMus.Size = New System.Drawing.Size(143, 20)
        Me.GeneroMus.TabIndex = 72
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonActualizar.Location = New System.Drawing.Point(470, 365)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonActualizar.TabIndex = 73
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonConsulta
        '
        Me.ButtonConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConsulta.Location = New System.Drawing.Point(176, 365)
        Me.ButtonConsulta.Name = "ButtonConsulta"
        Me.ButtonConsulta.Size = New System.Drawing.Size(84, 31)
        Me.ButtonConsulta.TabIndex = 74
        Me.ButtonConsulta.Text = "Consulta"
        Me.ButtonConsulta.UseVisualStyleBackColor = True
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegistro.Location = New System.Drawing.Point(176, 365)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(84, 31)
        Me.ButtonRegistro.TabIndex = 75
        Me.ButtonRegistro.Text = "Registro"
        Me.ButtonRegistro.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBuscar.Location = New System.Drawing.Point(471, 365)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonBuscar.TabIndex = 76
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.Location = New System.Drawing.Point(274, 365)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonMostrar.TabIndex = 77
        Me.ButtonMostrar.Text = "Mostrar todo"
        Me.ButtonMostrar.UseVisualStyleBackColor = True
        '
        'label_CritBusqueda
        '
        Me.label_CritBusqueda.AutoSize = True
        Me.label_CritBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CritBusqueda.Location = New System.Drawing.Point(12, 50)
        Me.label_CritBusqueda.Name = "label_CritBusqueda"
        Me.label_CritBusqueda.Size = New System.Drawing.Size(159, 40)
        Me.label_CritBusqueda.TabIndex = 78
        Me.label_CritBusqueda.Text = "Selecciona el crtiterio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de busqueda:"
        Me.label_CritBusqueda.Visible = False
        '
        'cb_CritBusqueda
        '
        Me.cb_CritBusqueda.FormattingEnabled = True
        Me.cb_CritBusqueda.Items.AddRange(New Object() {"Codigo", "Nombre del álbum", "Artista", "Num. Canciones", "Genero", "Año Lanzamiento"})
        Me.cb_CritBusqueda.Location = New System.Drawing.Point(16, 96)
        Me.cb_CritBusqueda.Name = "cb_CritBusqueda"
        Me.cb_CritBusqueda.Size = New System.Drawing.Size(139, 21)
        Me.cb_CritBusqueda.TabIndex = 79
        Me.cb_CritBusqueda.Visible = False
        '
        'label_BNomAl
        '
        Me.label_BNomAl.AutoSize = True
        Me.label_BNomAl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BNomAl.Location = New System.Drawing.Point(12, 120)
        Me.label_BNomAl.Name = "label_BNomAl"
        Me.label_BNomAl.Size = New System.Drawing.Size(118, 20)
        Me.label_BNomAl.TabIndex = 80
        Me.label_BNomAl.Text = "Nombre Álbum:"
        Me.label_BNomAl.Visible = False
        '
        'label_BCodigo
        '
        Me.label_BCodigo.AutoSize = True
        Me.label_BCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BCodigo.Location = New System.Drawing.Point(16, 120)
        Me.label_BCodigo.Name = "label_BCodigo"
        Me.label_BCodigo.Size = New System.Drawing.Size(63, 20)
        Me.label_BCodigo.TabIndex = 81
        Me.label_BCodigo.Text = "Codigo:"
        Me.label_BCodigo.Visible = False
        '
        'label_BArtista
        '
        Me.label_BArtista.AutoSize = True
        Me.label_BArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BArtista.Location = New System.Drawing.Point(12, 120)
        Me.label_BArtista.Name = "label_BArtista"
        Me.label_BArtista.Size = New System.Drawing.Size(59, 20)
        Me.label_BArtista.TabIndex = 82
        Me.label_BArtista.Text = "Artista:"
        Me.label_BArtista.Visible = False
        '
        'label_BNoCan
        '
        Me.label_BNoCan.AutoSize = True
        Me.label_BNoCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BNoCan.Location = New System.Drawing.Point(12, 120)
        Me.label_BNoCan.Name = "label_BNoCan"
        Me.label_BNoCan.Size = New System.Drawing.Size(167, 20)
        Me.label_BNoCan.TabIndex = 83
        Me.label_BNoCan.Text = "Numero de canciones:"
        Me.label_BNoCan.Visible = False
        '
        'label_BGenero
        '
        Me.label_BGenero.AutoSize = True
        Me.label_BGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BGenero.Location = New System.Drawing.Point(12, 120)
        Me.label_BGenero.Name = "label_BGenero"
        Me.label_BGenero.Size = New System.Drawing.Size(67, 20)
        Me.label_BGenero.TabIndex = 84
        Me.label_BGenero.Text = "Genero:"
        Me.label_BGenero.Visible = False
        '
        'label_BAñoLan
        '
        Me.label_BAñoLan.AutoSize = True
        Me.label_BAñoLan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BAñoLan.Location = New System.Drawing.Point(12, 120)
        Me.label_BAñoLan.Name = "label_BAñoLan"
        Me.label_BAñoLan.Size = New System.Drawing.Size(138, 20)
        Me.label_BAñoLan.TabIndex = 85
        Me.label_BAñoLan.Text = "Año Lanzamiento:"
        Me.label_BAñoLan.Visible = False
        '
        'txt_BCodigo
        '
        Me.txt_BCodigo.Location = New System.Drawing.Point(11, 143)
        Me.txt_BCodigo.Name = "txt_BCodigo"
        Me.txt_BCodigo.Size = New System.Drawing.Size(143, 20)
        Me.txt_BCodigo.TabIndex = 86
        Me.txt_BCodigo.Visible = False
        '
        'txt_BNombre
        '
        Me.txt_BNombre.Location = New System.Drawing.Point(12, 142)
        Me.txt_BNombre.Name = "txt_BNombre"
        Me.txt_BNombre.Size = New System.Drawing.Size(143, 20)
        Me.txt_BNombre.TabIndex = 87
        Me.txt_BNombre.Visible = False
        '
        'txt_BArtista
        '
        Me.txt_BArtista.Location = New System.Drawing.Point(12, 143)
        Me.txt_BArtista.Name = "txt_BArtista"
        Me.txt_BArtista.Size = New System.Drawing.Size(143, 20)
        Me.txt_BArtista.TabIndex = 88
        Me.txt_BArtista.Visible = False
        '
        'txt_NoCan
        '
        Me.txt_NoCan.Location = New System.Drawing.Point(12, 143)
        Me.txt_NoCan.Name = "txt_NoCan"
        Me.txt_NoCan.Size = New System.Drawing.Size(143, 20)
        Me.txt_NoCan.TabIndex = 89
        Me.txt_NoCan.Visible = False
        '
        'txt_BGenero
        '
        Me.txt_BGenero.Location = New System.Drawing.Point(11, 143)
        Me.txt_BGenero.Name = "txt_BGenero"
        Me.txt_BGenero.Size = New System.Drawing.Size(143, 20)
        Me.txt_BGenero.TabIndex = 90
        Me.txt_BGenero.Visible = False
        '
        'txt_AñoLan
        '
        Me.txt_AñoLan.Location = New System.Drawing.Point(12, 143)
        Me.txt_AñoLan.Name = "txt_AñoLan"
        Me.txt_AñoLan.Size = New System.Drawing.Size(143, 20)
        Me.txt_AñoLan.TabIndex = 91
        Me.txt_AñoLan.Visible = False
        '
        'Album_Musica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 409)
        Me.Controls.Add(Me.ButtonConsulta)
        Me.Controls.Add(Me.GeneroMus)
        Me.Controls.Add(Me.AñoLanMus)
        Me.Controls.Add(Me.LabelL)
        Me.Controls.Add(Me.Boton_Reiniciar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.LabelG)
        Me.Controls.Add(Me.LabelNC)
        Me.Controls.Add(Me.NoCasMus)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.ArtistaMus)
        Me.Controls.Add(Me.LabelN)
        Me.Controls.Add(Me.NAlbumMus)
        Me.Controls.Add(Me.LabelC)
        Me.Controls.Add(Me.TXT_registro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Grid_Album_Musica)
        Me.Controls.Add(Me.ButtonRegistro)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.label_CritBusqueda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.label_BCodigo)
        Me.Controls.Add(Me.label_BNomAl)
        Me.Controls.Add(Me.label_BArtista)
        Me.Controls.Add(Me.label_BNoCan)
        Me.Controls.Add(Me.label_BGenero)
        Me.Controls.Add(Me.label_BAñoLan)
        Me.Controls.Add(Me.txt_BCodigo)
        Me.Controls.Add(Me.txt_BNombre)
        Me.Controls.Add(Me.txt_BArtista)
        Me.Controls.Add(Me.txt_NoCan)
        Me.Controls.Add(Me.txt_BGenero)
        Me.Controls.Add(Me.txt_AñoLan)
        Me.Controls.Add(Me.CodigoMus)
        Me.Controls.Add(Me.cb_CritBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Album_Musica"
        Me.Text = "Album_Musica"
        CType(Me.Grid_Album_Musica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boton_Reiniciar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents LabelG As Label
    Friend WithEvents LabelNC As Label
    Friend WithEvents NoCasMus As TextBox
    Friend WithEvents LabelA As Label
    Friend WithEvents ArtistaMus As TextBox
    Friend WithEvents LabelN As Label
    Friend WithEvents NAlbumMus As TextBox
    Friend WithEvents LabelC As Label
    Friend WithEvents CodigoMus As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT_registro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Grid_Album_Musica As DataGridView
    Friend WithEvents LabelL As Label
    Friend WithEvents AñoLanMus As TextBox
    Friend WithEvents GeneroMus As TextBox
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonConsulta As Button
    Friend WithEvents ButtonRegistro As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonMostrar As Button
    Friend WithEvents label_CritBusqueda As Label
    Friend WithEvents cb_CritBusqueda As ComboBox
    Friend WithEvents label_BNomAl As Label
    Friend WithEvents label_BCodigo As Label
    Friend WithEvents label_BArtista As Label
    Friend WithEvents label_BNoCan As Label
    Friend WithEvents label_BGenero As Label
    Friend WithEvents label_BAñoLan As Label
    Friend WithEvents txt_BCodigo As TextBox
    Friend WithEvents txt_BNombre As TextBox
    Friend WithEvents txt_BArtista As TextBox
    Friend WithEvents txt_NoCan As TextBox
    Friend WithEvents txt_BGenero As TextBox
    Friend WithEvents txt_AñoLan As TextBox
End Class
