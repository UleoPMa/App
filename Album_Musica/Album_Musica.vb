Imports System.Data
Imports System.Data.OleDb

Public Class Album_Musica
    Private Sub Album_Musica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMusica()
        Limpiar_txtM()
    End Sub

    Public comandosM As New OleDbCommand

    Private Sub Registrar_Musica()
        Try
            comandosM.Connection = conexion
            comandosM = New OleDbCommand("INSERT INTO Album_Musica(Codigo, Nombre_Álbum, Artista, No_Canciones, Genero, Año_Lanzamiento)" & Chr(13) &
        "VALUES(Codigo,Nombre_Álbum,Artista,No_Canciones,Genero,Año_Lanzamiento)", conexion)
            comandosM.Parameters.AddWithValue("@Codigo", CodigoMus.Text)
            comandosM.Parameters.AddWithValue("@Nombre Álbum", NAlbumMus.Text)
            comandosM.Parameters.AddWithValue("@Artista", ArtistaMus.Text)
            comandosM.Parameters.AddWithValue("@No Canciones", NoCasMus.Text)
            comandosM.Parameters.AddWithValue("@Genero", GeneroMus.Text)
            comandosM.Parameters.AddWithValue("@Año Lanzamiento", AñoLanMus.Text)

            comandosM.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MostrarMusica()
        Try
            Dim paquete As New DataSet
            Dim ConsultaSQL As String
            Dim Adaptador As OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM Album_Musica"

            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

            paquete.Tables.Add("Album_Musica")

            Adaptador.Fill(paquete.Tables("Album_Musica"))

            Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
            TXT_registro.Text = Grid_Album_Musica.Rows.Count

            Grid_Album_Musica.Columns("Codigo").Width = 120
            Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
            Grid_Album_Musica.Columns("Artista").Width = 120
            Grid_Album_Musica.Columns("No_Canciones").Width = 120
            Grid_Album_Musica.Columns("Genero").Width = 120
            Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GeneroMus.Text = Nothing Or
                CodigoMus.Text = Nothing Or
                NAlbumMus.Text = Nothing Or
                ArtistaMus.Text = Nothing Or
                NoCasMus.Text = Nothing Or
                AñoLanMus.Text = Nothing Then
            MsgBox("Espacios vacios o incorrectos, vuelva a ingresarlos", MsgBoxStyle.Critical, "Nuevo Registro")
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Se agregara un nuevo registro de Musica, ¿Deseas continuar?", "Nuevo Registro", MessageBoxButtons.YesNo)

            If respuesta = DialogResult.Yes Then
                Registrar_Musica()
                MostrarMusica()
                Limpiar_txtM()

            ElseIf respuesta = DialogResult.No Then


            End If
        End If
    End Sub

    Private Sub Limpiar_txtM()
        CodigoMus.Clear()
        NAlbumMus.Clear()
        ArtistaMus.Clear()
        NoCasMus.Clear()
        GeneroMus.Clear()
        AñoLanMus.Clear()
        Grid_Album_Musica.ClearSelection()
        ButtonActualizar.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Buscar_Folio_RepetidoM()
        Try

            Dim adaptador As New OleDbDataAdapter
            Dim paquete As New DataSet
            Dim ConsultaSQL As String
            Dim registro As Long

            ConsultaSQL = "SELECT * FROM Album_Musica WHERE Codigo = " & CodigoMus.Text
            adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            paquete = New DataSet

            adaptador.Fill(paquete, "Album_Musica")
            registro = paquete.Tables("Album_Musica").Rows.Count

            If registro <> 0 Then
                MsgBox("Este codigo ya exite, intenta nuevamente", MsgBoxStyle.Critical, "Nuevo Registro")
                CodigoMus.Focus()

            End If
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CodigoMus_Leave(sender As Object, e As EventArgs) Handles CodigoMus.Leave
        Buscar_Folio_RepetidoM()
    End Sub

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click
        Try
            If Grid_Album_Musica.SelectedRows.Count = 0 Then
                MsgBox("No existe fila seleccionada, Selecciona un registro a eliminar", MsgBoxStyle.Critical, "Eliminar registro")
            Else
                Dim respuesta As DialogResult = MessageBox.Show("Se eliminara el registro seleccionado", "Eliminar Registro", MessageBoxButtons.YesNo)

                If respuesta = DialogResult.Yes Then
                    Dim Comando_Eliminar As New OleDbCommand
                    For Each Fila As DataGridViewRow In Grid_Album_Musica.SelectedRows
                        Dim Codigo As Double = Fila.Cells("Codigo").Value
                        Comando_Eliminar.Connection = conexion
                        Comando_Eliminar.CommandText = "DELETE FROM Album_Musica WHERE Codigo = " & Codigo
                        Comando_Eliminar.ExecuteNonQuery()
                    Next

                    MostrarMusica()

                ElseIf respuesta = DialogResult.No Then


                End If
            End If
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Doble_Click_FilaM()
        Try

            For Each Fila As DataGridViewRow In Grid_Album_Musica.SelectedRows
                Dim Codigo As Integer = Fila.Cells("Codigo").Value
                Dim NombreAl As String = Fila.Cells("Nombre_Álbum").Value
                Dim Artista As String = Fila.Cells("Artista").Value
                Dim NCanciones As String = Fila.Cells("No_Canciones").Value
                Dim Genero As String = Fila.Cells("Genero").Value
                Dim AnioLan As String = Fila.Cells("Año_Lanzamiento").Value

                CodigoMus.Text = Codigo
                NAlbumMus.Text = NombreAl
                ArtistaMus.Text = Artista
                NoCasMus.Text = NCanciones
                GeneroMus.Text = Genero
                AñoLanMus.Text = AnioLan

            Next


        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Grid_Album_Musica_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Album_Musica.CellDoubleClick
        Doble_Click_FilaM()
        ButtonActualizar.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub Actualizar_Musica()
        Try
            Dim Comando_Actualizar As New OleDbCommand
            Dim Codigo As Integer

            Codigo = CodigoMus.Text
            Comando_Actualizar.Connection = conexion

            Comando_Actualizar.CommandText = "UPDATE Album_Musica SET Nombre_Álbum = '" & NAlbumMus.Text &
                "', Artista = '" & ArtistaMus.Text &
                "', No_Canciones = '" & NoCasMus.Text &
                "', Genero = '" & GeneroMus.Text &
                "', Año_Lanzamiento = '" & AñoLanMus.Text &
                "'WHERE Codigo = " & Codigo

            Comando_Actualizar.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Boton_Reiniciar_Click(sender As Object, e As EventArgs) Handles Boton_Reiniciar.Click
        Limpiar_txtM()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If CodigoMus.Text = Nothing Or
                NAlbumMus.Text = Nothing Or
                ArtistaMus.Text = Nothing Or
                NoCasMus.Text = Nothing Or
                GeneroMus.Text = Nothing Or
                AñoLanMus.Text = Nothing Then

            MsgBox("No existe informacion para actualizar, !Revisa¡", MsgBoxStyle.Critical, "Actualizar")
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Se actualizara el registro seleccionado, ¿desea continuar?", "Actualizar Registro", MessageBoxButtons.YesNo)

            If respuesta = DialogResult.Yes Then
                Actualizar_Musica()
                MostrarMusica()
                Limpiar_txtM()

            ElseIf respuesta = DialogResult.No Then


            End If
        End If

    End Sub

    Private Sub CodigoMus_TextChanged(sender As Object, e As EventArgs) Handles CodigoMus.TextChanged

    End Sub

    Private Sub ConsultaBus_Musi()
        LabelC.Visible = False
        CodigoMus.Visible = False
        LabelN.Visible = False
        NAlbumMus.Visible = False
        LabelA.Visible = False
        ArtistaMus.Visible = False
        LabelNC.Visible = False
        NoCasMus.Visible = False
        LabelG.Visible = False
        GeneroMus.Visible = False
        LabelL.Visible = False
        AñoLanMus.Visible = False
        Boton_Reiniciar.Visible = False
        ButtonConsulta.Visible = False
        Button_Eliminar.Visible = False
        Button1.Visible = False
        ButtonActualizar.Visible = False

        label_CritBusqueda.Visible = True
        cb_CritBusqueda.Visible = True
    End Sub

    Private Sub ButtonConsulta_Click(sender As Object, e As EventArgs) Handles ButtonConsulta.Click
        ConsultaBus_Musi()
    End Sub

    Private Sub SeleecionarCrit_Busqueda(sender As Object, e As EventArgs) Handles cb_CritBusqueda.SelectedIndexChanged
        MostrarMusica()
        Dim seleccionBus = cb_CritBusqueda.Text
        'Codigo
        'Nombre del álbum
        'Artista
        'Num.Canciones
        'Genero
        'Año Lanzamiento

        If seleccionBus = "Codigo" Then
            label_BCodigo.Visible = True
            txt_BCodigo.Visible = True

            label_BNomAl.Visible = False
            txt_BNombre.Visible = False
            label_BArtista.Visible = False
            txt_BArtista.Visible = False
            label_BNoCan.Visible = False
            txt_NoCan.Visible = False
            label_BGenero.Visible = False
            txt_BGenero.Visible = False
            label_BAñoLan.Visible = False
            txt_AñoLan.Visible = False

        ElseIf seleccionBus = "Nombre del álbum" Then
            label_BNomAl.Visible = True
            txt_BNombre.Visible = True

            label_BCodigo.Visible = False
            txt_BCodigo.Visible = False
            label_BArtista.Visible = False
            txt_BArtista.Visible = False
            label_BNoCan.Visible = False
            txt_NoCan.Visible = False
            label_BGenero.Visible = False
            txt_BGenero.Visible = False
            label_BAñoLan.Visible = False
            txt_AñoLan.Visible = False

        ElseIf seleccionBus = "Artista" Then
            label_BArtista.Visible = True
            txt_BArtista.Visible = True

            label_BCodigo.Visible = False
            txt_BCodigo.Visible = False
            label_BNomAl.Visible = False
            txt_BNombre.Visible = False
            label_BNoCan.Visible = False
            txt_NoCan.Visible = False
            label_BGenero.Visible = False
            txt_BGenero.Visible = False
            label_BAñoLan.Visible = False
            txt_AñoLan.Visible = False

        ElseIf seleccionBus = "Num. Canciones" Then
            label_BNoCan.Visible = True
            txt_NoCan.Visible = True

            label_BCodigo.Visible = False
            txt_BCodigo.Visible = False
            label_BNomAl.Visible = False
            txt_BNombre.Visible = False
            label_BArtista.Visible = False
            txt_BArtista.Visible = False
            label_BGenero.Visible = False
            txt_BGenero.Visible = False
            label_BAñoLan.Visible = False
            txt_AñoLan.Visible = False

        ElseIf seleccionBus = "Genero" Then
            label_BGenero.Visible = True
            txt_BGenero.Visible = True

            label_BCodigo.Visible = False
            txt_BCodigo.Visible = False
            label_BNomAl.Visible = False
            txt_BNombre.Visible = False
            label_BArtista.Visible = False
            txt_BArtista.Visible = False
            label_BNoCan.Visible = False
            txt_NoCan.Visible = False
            label_BAñoLan.Visible = False
            txt_AñoLan.Visible = False

        ElseIf seleccionBus = "Año Lanzamiento" Then
            label_BAñoLan.Visible = True
            txt_AñoLan.Visible = True

            label_BCodigo.Visible = False
            txt_BCodigo.Visible = False
            label_BNomAl.Visible = False
            txt_BNombre.Visible = False
            label_BArtista.Visible = False
            txt_BArtista.Visible = False
            label_BNoCan.Visible = False
            txt_NoCan.Visible = False
            label_BGenero.Visible = False
            txt_BGenero.Visible = False

        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim busqueda

        If txt_BCodigo.Text <> Nothing Then
            busqueda = txt_BCodigo.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE Codigo =" + busqueda + ""

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_BCodigo.Clear()

        ElseIf txt_BNombre.Text <> Nothing Then
            busqueda = txt_BNombre.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE Nombre_álbum LIKE '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_BNombre.Clear()

        ElseIf txt_BArtista.Text <> Nothing Then
            busqueda = txt_BArtista.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE Artista LIKE '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_BArtista.Clear()

        ElseIf txt_NoCan.Text <> Nothing Then
            busqueda = txt_NoCan.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE No_Canciones = " + busqueda + ""

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_NoCan.Clear()

        ElseIf txt_BGenero.Text <> Nothing Then
            busqueda = txt_BGenero.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE Genero LIKE '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_BGenero.Clear()

        ElseIf txt_AñoLan.Text <> Nothing Then
            busqueda = txt_AñoLan.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Album_Musica WHERE Año_Lanzamiento LIKE '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Album_Musica")

                Adaptador.Fill(paquete.Tables("Album_Musica"))

                Grid_Album_Musica.DataSource = paquete.Tables("Album_Musica")
                TXT_registro.Text = Grid_Album_Musica.Rows.Count

                Grid_Album_Musica.Columns("Codigo").Width = 120
                Grid_Album_Musica.Columns("Nombre_Álbum").Width = 120
                Grid_Album_Musica.Columns("Artista").Width = 120
                Grid_Album_Musica.Columns("No_Canciones").Width = 120
                Grid_Album_Musica.Columns("Genero").Width = 120
                Grid_Album_Musica.Columns("Año_Lanzamiento").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_AñoLan.Clear()

        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        MostrarMusica()
    End Sub

    Private Sub ButtonRegistro_Click(sender As Object, e As EventArgs) Handles ButtonRegistro.Click
        LabelC.Visible = True
        CodigoMus.Visible = True
        LabelN.Visible = True
        NAlbumMus.Visible = True
        LabelA.Visible = True
        ArtistaMus.Visible = True
        LabelNC.Visible = True
        NoCasMus.Visible = True
        LabelG.Visible = True
        GeneroMus.Visible = True
        LabelL.Visible = True
        AñoLanMus.Visible = True
        Boton_Reiniciar.Visible = True
        ButtonConsulta.Visible = True
        Button_Eliminar.Visible = True
        Button1.Visible = True
        ButtonActualizar.Visible = True

        label_CritBusqueda.Visible = False
        cb_CritBusqueda.Visible = False
    End Sub
End Class