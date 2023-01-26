<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libros))
        Me.TXT_registro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Grid_Libros = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_au = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_suc = New System.Windows.Forms.ComboBox()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Boton_Reiniciar = New System.Windows.Forms.Button()
        Me.Boton_Actualizar = New System.Windows.Forms.Button()
        Me.ButtonConsulta = New System.Windows.Forms.Button()
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.label_BuscarPor = New System.Windows.Forms.Label()
        Me.cb_CriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.label_CFolio = New System.Windows.Forms.Label()
        Me.label_CNombre = New System.Windows.Forms.Label()
        Me.label_CAutor = New System.Windows.Forms.Label()
        Me.label_CDescrip = New System.Windows.Forms.Label()
        Me.label_CSuc = New System.Windows.Forms.Label()
        Me.txt_CAutor = New System.Windows.Forms.TextBox()
        Me.txt_CDescrip = New System.Windows.Forms.TextBox()
        Me.txt_CNombre = New System.Windows.Forms.TextBox()
        Me.txt_CFolio = New System.Windows.Forms.TextBox()
        Me.cb_CSuc = New System.Windows.Forms.ComboBox()
        Me.ButtonMostar = New System.Windows.Forms.Button()
        CType(Me.Grid_Libros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_registro
        '
        Me.TXT_registro.AutoSize = True
        Me.TXT_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_registro.Location = New System.Drawing.Point(514, 69)
        Me.TXT_registro.Name = "TXT_registro"
        Me.TXT_registro.Size = New System.Drawing.Size(29, 20)
        Me.TXT_registro.TabIndex = 37
        Me.TXT_registro.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Registros:"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTitulo.Location = New System.Drawing.Point(215, 31)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(94, 31)
        Me.LabelTitulo.TabIndex = 33
        Me.LabelTitulo.Text = "Libros"
        '
        'Grid_Libros
        '
        Me.Grid_Libros.AllowUserToAddRows = False
        Me.Grid_Libros.AllowUserToResizeColumns = False
        Me.Grid_Libros.AllowUserToResizeRows = False
        Me.Grid_Libros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid_Libros.BackgroundColor = System.Drawing.Color.White
        Me.Grid_Libros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Libros.GridColor = System.Drawing.SystemColors.Control
        Me.Grid_Libros.Location = New System.Drawing.Point(181, 92)
        Me.Grid_Libros.Name = "Grid_Libros"
        Me.Grid_Libros.ReadOnly = True
        Me.Grid_Libros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_Libros.Size = New System.Drawing.Size(375, 268)
        Me.Grid_Libros.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(470, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 31)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_fol
        '
        Me.txt_fol.Location = New System.Drawing.Point(12, 105)
        Me.txt_fol.Name = "txt_fol"
        Me.txt_fol.Size = New System.Drawing.Size(143, 20)
        Me.txt_fol.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Folio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nombre:"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(12, 165)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(143, 20)
        Me.txt_nom.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Autor:"
        '
        'txt_au
        '
        Me.txt_au.Location = New System.Drawing.Point(12, 221)
        Me.txt_au.Name = "txt_au"
        Me.txt_au.Size = New System.Drawing.Size(143, 20)
        Me.txt_au.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Descripción"
        '
        'txt_descrip
        '
        Me.txt_descrip.Location = New System.Drawing.Point(12, 280)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(143, 20)
        Me.txt_descrip.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Sucursal de venta:"
        '
        'ComboBox_suc
        '
        Me.ComboBox_suc.FormattingEnabled = True
        Me.ComboBox_suc.Items.AddRange(New Object() {"México", "Argentina", "Colombia", "Estados Unidos"})
        Me.ComboBox_suc.Location = New System.Drawing.Point(16, 345)
        Me.ComboBox_suc.Name = "ComboBox_suc"
        Me.ComboBox_suc.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox_suc.TabIndex = 48
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Eliminar.Location = New System.Drawing.Point(372, 366)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(84, 31)
        Me.Button_Eliminar.TabIndex = 49
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Boton_Reiniciar
        '
        Me.Boton_Reiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_Reiniciar.Location = New System.Drawing.Point(274, 366)
        Me.Boton_Reiniciar.Name = "Boton_Reiniciar"
        Me.Boton_Reiniciar.Size = New System.Drawing.Size(84, 31)
        Me.Boton_Reiniciar.TabIndex = 50
        Me.Boton_Reiniciar.Text = "Reiniciar"
        Me.Boton_Reiniciar.UseVisualStyleBackColor = True
        '
        'Boton_Actualizar
        '
        Me.Boton_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton_Actualizar.Location = New System.Drawing.Point(470, 366)
        Me.Boton_Actualizar.Name = "Boton_Actualizar"
        Me.Boton_Actualizar.Size = New System.Drawing.Size(84, 31)
        Me.Boton_Actualizar.TabIndex = 51
        Me.Boton_Actualizar.Text = "Actualizar"
        Me.Boton_Actualizar.UseVisualStyleBackColor = True
        Me.Boton_Actualizar.Visible = False
        '
        'ButtonConsulta
        '
        Me.ButtonConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConsulta.Location = New System.Drawing.Point(176, 366)
        Me.ButtonConsulta.Name = "ButtonConsulta"
        Me.ButtonConsulta.Size = New System.Drawing.Size(84, 31)
        Me.ButtonConsulta.TabIndex = 52
        Me.ButtonConsulta.Text = "Consulta"
        Me.ButtonConsulta.UseVisualStyleBackColor = True
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegistro.Location = New System.Drawing.Point(176, 366)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(84, 31)
        Me.ButtonRegistro.TabIndex = 53
        Me.ButtonRegistro.Text = "Registro"
        Me.ButtonRegistro.UseVisualStyleBackColor = True
        Me.ButtonRegistro.Visible = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBuscar.Location = New System.Drawing.Point(472, 366)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonBuscar.TabIndex = 54
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        Me.ButtonBuscar.Visible = False
        '
        'label_BuscarPor
        '
        Me.label_BuscarPor.AutoSize = True
        Me.label_BuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_BuscarPor.Location = New System.Drawing.Point(12, 60)
        Me.label_BuscarPor.Name = "label_BuscarPor"
        Me.label_BuscarPor.Size = New System.Drawing.Size(158, 40)
        Me.label_BuscarPor.TabIndex = 55
        Me.label_BuscarPor.Text = "Selecciona el criterio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de busqueda:"
        Me.label_BuscarPor.Visible = False
        '
        'cb_CriterioBusqueda
        '
        Me.cb_CriterioBusqueda.FormattingEnabled = True
        Me.cb_CriterioBusqueda.Items.AddRange(New Object() {"Folio", "Nombre", "Autor", "Descripcion", "Sucursal_venta"})
        Me.cb_CriterioBusqueda.Location = New System.Drawing.Point(13, 104)
        Me.cb_CriterioBusqueda.Name = "cb_CriterioBusqueda"
        Me.cb_CriterioBusqueda.Size = New System.Drawing.Size(139, 21)
        Me.cb_CriterioBusqueda.TabIndex = 56
        Me.cb_CriterioBusqueda.Visible = False
        '
        'label_CFolio
        '
        Me.label_CFolio.AutoSize = True
        Me.label_CFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CFolio.Location = New System.Drawing.Point(12, 138)
        Me.label_CFolio.Name = "label_CFolio"
        Me.label_CFolio.Size = New System.Drawing.Size(47, 20)
        Me.label_CFolio.TabIndex = 57
        Me.label_CFolio.Text = "Folio:"
        Me.label_CFolio.Visible = False
        '
        'label_CNombre
        '
        Me.label_CNombre.AutoSize = True
        Me.label_CNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CNombre.Location = New System.Drawing.Point(12, 138)
        Me.label_CNombre.Name = "label_CNombre"
        Me.label_CNombre.Size = New System.Drawing.Size(69, 20)
        Me.label_CNombre.TabIndex = 58
        Me.label_CNombre.Text = "Nombre:"
        Me.label_CNombre.Visible = False
        '
        'label_CAutor
        '
        Me.label_CAutor.AutoSize = True
        Me.label_CAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CAutor.Location = New System.Drawing.Point(12, 138)
        Me.label_CAutor.Name = "label_CAutor"
        Me.label_CAutor.Size = New System.Drawing.Size(52, 20)
        Me.label_CAutor.TabIndex = 59
        Me.label_CAutor.Text = "Autor:"
        Me.label_CAutor.Visible = False
        '
        'label_CDescrip
        '
        Me.label_CDescrip.AutoSize = True
        Me.label_CDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CDescrip.Location = New System.Drawing.Point(12, 138)
        Me.label_CDescrip.Name = "label_CDescrip"
        Me.label_CDescrip.Size = New System.Drawing.Size(92, 20)
        Me.label_CDescrip.TabIndex = 60
        Me.label_CDescrip.Text = "Descripción"
        Me.label_CDescrip.Visible = False
        '
        'label_CSuc
        '
        Me.label_CSuc.AutoSize = True
        Me.label_CSuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CSuc.Location = New System.Drawing.Point(12, 138)
        Me.label_CSuc.Name = "label_CSuc"
        Me.label_CSuc.Size = New System.Drawing.Size(140, 20)
        Me.label_CSuc.TabIndex = 61
        Me.label_CSuc.Text = "Sucursal de venta:"
        Me.label_CSuc.Visible = False
        '
        'txt_CAutor
        '
        Me.txt_CAutor.Location = New System.Drawing.Point(13, 164)
        Me.txt_CAutor.Name = "txt_CAutor"
        Me.txt_CAutor.Size = New System.Drawing.Size(143, 20)
        Me.txt_CAutor.TabIndex = 62
        Me.txt_CAutor.Visible = False
        '
        'txt_CDescrip
        '
        Me.txt_CDescrip.Location = New System.Drawing.Point(13, 164)
        Me.txt_CDescrip.Name = "txt_CDescrip"
        Me.txt_CDescrip.Size = New System.Drawing.Size(143, 20)
        Me.txt_CDescrip.TabIndex = 63
        Me.txt_CDescrip.Visible = False
        '
        'txt_CNombre
        '
        Me.txt_CNombre.Location = New System.Drawing.Point(13, 164)
        Me.txt_CNombre.Name = "txt_CNombre"
        Me.txt_CNombre.Size = New System.Drawing.Size(143, 20)
        Me.txt_CNombre.TabIndex = 64
        Me.txt_CNombre.Visible = False
        '
        'txt_CFolio
        '
        Me.txt_CFolio.Location = New System.Drawing.Point(12, 164)
        Me.txt_CFolio.Name = "txt_CFolio"
        Me.txt_CFolio.Size = New System.Drawing.Size(143, 20)
        Me.txt_CFolio.TabIndex = 65
        Me.txt_CFolio.Visible = False
        '
        'cb_CSuc
        '
        Me.cb_CSuc.FormattingEnabled = True
        Me.cb_CSuc.Items.AddRange(New Object() {"México", "Argentina", "Colombia", "Estados Unidos"})
        Me.cb_CSuc.Location = New System.Drawing.Point(13, 164)
        Me.cb_CSuc.Name = "cb_CSuc"
        Me.cb_CSuc.Size = New System.Drawing.Size(139, 21)
        Me.cb_CSuc.TabIndex = 66
        Me.cb_CSuc.Visible = False
        '
        'ButtonMostar
        '
        Me.ButtonMostar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostar.Location = New System.Drawing.Point(274, 366)
        Me.ButtonMostar.Name = "ButtonMostar"
        Me.ButtonMostar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonMostar.TabIndex = 67
        Me.ButtonMostar.Text = "Mostrar todo"
        Me.ButtonMostar.UseVisualStyleBackColor = True
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 409)
        Me.Controls.Add(Me.Boton_Reiniciar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.ComboBox_suc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_descrip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_au)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fol)
        Me.Controls.Add(Me.TXT_registro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Grid_Libros)
        Me.Controls.Add(Me.label_BuscarPor)
        Me.Controls.Add(Me.cb_CriterioBusqueda)
        Me.Controls.Add(Me.label_CFolio)
        Me.Controls.Add(Me.label_CNombre)
        Me.Controls.Add(Me.label_CAutor)
        Me.Controls.Add(Me.label_CDescrip)
        Me.Controls.Add(Me.label_CSuc)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_CFolio)
        Me.Controls.Add(Me.txt_CNombre)
        Me.Controls.Add(Me.txt_CAutor)
        Me.Controls.Add(Me.txt_CDescrip)
        Me.Controls.Add(Me.cb_CSuc)
        Me.Controls.Add(Me.Boton_Actualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ButtonMostar)
        Me.Controls.Add(Me.ButtonConsulta)
        Me.Controls.Add(Me.ButtonRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Libros"
        Me.Text = "Libros"
        CType(Me.Grid_Libros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_registro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Grid_Libros As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_fol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_au As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_descrip As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_suc As ComboBox
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Boton_Reiniciar As Button
    Friend WithEvents Boton_Actualizar As Button
    Friend WithEvents ButtonConsulta As Button
    Friend WithEvents ButtonRegistro As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents label_BuscarPor As Label
    Friend WithEvents cb_CriterioBusqueda As ComboBox
    Friend WithEvents label_CFolio As Label
    Friend WithEvents label_CNombre As Label
    Friend WithEvents label_CAutor As Label
    Friend WithEvents label_CDescrip As Label
    Friend WithEvents label_CSuc As Label
    Friend WithEvents txt_CAutor As TextBox
    Friend WithEvents txt_CDescrip As TextBox
    Friend WithEvents txt_CNombre As TextBox
    Friend WithEvents txt_CFolio As TextBox
    Friend WithEvents cb_CSuc As ComboBox
    Friend WithEvents ButtonMostar As Button
End Class
