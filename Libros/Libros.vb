Imports System.Data
Imports System.Data.OleDb

Public Class Libros
    Private Sub Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostarProductos()
        Limpiar_txt()
    End Sub

    Public comandos As New OleDbCommand

    Private Sub Registrar_Libros()
        Try
            comandos.Connection = conexion
            comandos = New OleDbCommand("INSERT INTO Libros(Folio, Nombre, Autor, Descripcion, Sucursal_Venta)" & Chr(13) &
        "VALUES(Folio, Nombre, Autor, Descripcion, Sucursal_Venta)", conexion)
            comandos.Parameters.AddWithValue("@Folio", txt_fol.Text)
            comandos.Parameters.AddWithValue("@Nombre", txt_nom.Text)
            comandos.Parameters.AddWithValue("@Autor", txt_au.Text)
            comandos.Parameters.AddWithValue("@Descripcion", txt_descrip.Text)
            comandos.Parameters.AddWithValue("@Sucursal_Venta", ComboBox_suc.Text)

            comandos.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MostarProductos()
        Try
            Dim paquete As New DataSet
            Dim ConsultaSQL As String
            Dim Adaptador As OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM Libros"

            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

            paquete.Tables.Add("Libros")

            Adaptador.Fill(paquete.Tables("Libros"))

            Grid_Libros.DataSource = paquete.Tables("Libros")
            TXT_registro.Text = Grid_Libros.Rows.Count

            Grid_Libros.Columns("Folio").Width = 120
            Grid_Libros.Columns("Nombre").Width = 120
            Grid_Libros.Columns("Autor").Width = 120
            Grid_Libros.Columns("Descripcion").Width = 120
            Grid_Libros.Columns("Sucursal_Venta").Width = 120

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txt_fol.Text = Nothing Or
                txt_nom.Text = Nothing Or
                txt_au.Text = Nothing Or
                txt_descrip.Text = Nothing Or
                ComboBox_suc.Text = "Seleccion Sucursal" Then
            MsgBox("Espacios vacios o incorrectos, vuelva a ingresarlos", MsgBoxStyle.Critical, "Nuevo Registro")
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Se agregara un nuevo registro de libros, ¿Deseas continuar?", "Nuevo Registro", MessageBoxButtons.YesNo)

            If respuesta = DialogResult.Yes Then
                Registrar_Libros()
                MostarProductos()
                Limpiar_txt()

            ElseIf respuesta = DialogResult.No Then


            End If
        End If
    End Sub

    Private Sub Buscar_Folio_Repetido()
        Try

            Dim adaptador As New OleDbDataAdapter
            Dim paquete As New DataSet
            Dim ConsultaSQL As String
            Dim registro As Long

            ConsultaSQL = "SELECT * FROM Libros WHERE Folio = " & txt_fol.Text
            adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            paquete = New DataSet

            adaptador.Fill(paquete, "Libros")
            registro = paquete.Tables("Libros").Rows.Count

            If registro <> 0 Then
                MsgBox("Este folio ya exite, intenta nuevamente", MsgBoxStyle.Critical, "Nuevo Registro")
                txt_fol.Focus()

            End If
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txt_folio_Leave(sender As Object, e As EventArgs) Handles txt_fol.Leave
        Buscar_Folio_Repetido()
    End Sub

    Private Sub Limpiar_txt()
        txt_nom.Clear()
        txt_fol.Clear()
        txt_descrip.Clear()
        txt_au.Clear()
        ComboBox_suc.Text = "Seleccion Sucursal"
        Grid_Libros.ClearSelection()
        Boton_Actualizar.Visible = False
        Button1.Visible = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click
        Try
            If Grid_Libros.SelectedRows.Count = 0 Then
                MsgBox("No existe fila seleccionada, Selecciona un registro a eliminar", MsgBoxStyle.Critical, "Eliminar registro")
            Else
                Dim respuesta As DialogResult = MessageBox.Show("Se eliminara el registro seleccionado", "Eliminar Registro", MessageBoxButtons.YesNo)

                If respuesta = DialogResult.Yes Then
                    Dim Comando_Eliminar As New OleDbCommand
                    For Each Fila As DataGridViewRow In Grid_Libros.SelectedRows
                        Dim Folio As Double = Fila.Cells("Folio").Value
                        Comando_Eliminar.Connection = conexion
                        Comando_Eliminar.CommandText = "DELETE FROM Libros WHERE Folio = " & Folio
                        Comando_Eliminar.ExecuteNonQuery()
                    Next

                    MostarProductos()

                ElseIf respuesta = DialogResult.No Then


                End If
            End If
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Doble_Click_Fila()
        Try

            For Each Fila As DataGridViewRow In Grid_Libros.SelectedRows
                Dim Folio As Double = Fila.Cells("Folio").Value
                Dim Nombre As String = Fila.Cells("Nombre").Value
                Dim Autor As String = Fila.Cells("Autor").Value
                Dim Descripcion As String = Fila.Cells("Descripcion").Value
                Dim Sucursal_Venta As String = Fila.Cells("Sucursal_venta").Value

                txt_fol.Text = Folio
                txt_nom.Text = Nombre
                txt_au.Text = Autor
                txt_descrip.Text = Descripcion
                ComboBox_suc.Text = Sucursal_Venta

            Next


        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Grid_Libros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Libros.CellDoubleClick
        Doble_Click_Fila()
        Boton_Actualizar.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub Actualizar_Libros()
        Try
            Dim Comando_Actualizar As New OleDbCommand
            Dim Folio As Double

            Folio = txt_fol.Text
            Comando_Actualizar.Connection = conexion

            Comando_Actualizar.CommandText = "UPDATE Libros SET Nombre = '" & txt_nom.Text &
                "', Autor = '" & txt_au.Text &
                "', Descripcion= '" & txt_descrip.Text &
                "', Sucursal_Venta = '" & ComboBox_suc.Text &
                "'WHERE Folio = " & Folio

            Comando_Actualizar.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BotonActualizar_Click(sender As Object, e As EventArgs) Handles Boton_Actualizar.Click
        If txt_nom.Text = Nothing Or
                txt_au.Text = Nothing Or
                txt_descrip.Text = Nothing Or
                ComboBox_suc.Text = Nothing Or
                ComboBox_suc.Text = "Seleccion Sucursal" Then

            MsgBox("No existe informacion para actualizar, !Revisa¡", MsgBoxStyle.Critical, "Actualizar")
        Else
            Dim respuesta As DialogResult = MessageBox.Show("Se actualizara el registro seleccionado, ¿desea continuar?", "Actualizar Registro", MessageBoxButtons.YesNo)

            If respuesta = DialogResult.Yes Then
                Actualizar_Libros()
                MostarProductos()
                Limpiar_txt()

            ElseIf respuesta = DialogResult.No Then


            End If
        End If

    End Sub

    Private Sub Boton_Reiniciar_Click(sender As Object, e As EventArgs) Handles Boton_Reiniciar.Click
        Limpiar_txt()
    End Sub

    Private Sub txt_folio_TextChanged(sender As Object, e As EventArgs) Handles txt_fol.TextChanged

    End Sub

    Private Sub ConsultaBus()
        Boton_Reiniciar.Visible = False
        Button_Eliminar.Visible = False
        Boton_Actualizar.Visible = False
        Button1.Visible = False
        ButtonConsulta.Visible = False

        ButtonBuscar.Visible = True
        ButtonRegistro.Visible = True

        Label2.Visible = False
        txt_fol.Visible = False
        Label3.Visible = False
        txt_nom.Visible = False
        Label4.Visible = False
        txt_au.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        txt_descrip.Visible = False
        ComboBox_suc.Visible = False

        label_BuscarPor.Visible = True
        cb_CriterioBusqueda.Visible = True
    End Sub

    Private Sub ButtonConsulta_Click(sender As Object, e As EventArgs) Handles ButtonConsulta.Click
        ConsultaBus()
    End Sub

    Private Sub Selec_CriterioBus(sender As Object, e As EventArgs) Handles cb_CriterioBusqueda.SelectedIndexChanged
        MostarProductos()
        Dim seleccionBus = cb_CriterioBusqueda.Text

        If seleccionBus = "Folio" Then
            label_CFolio.Visible = True
            txt_CFolio.Visible = True

            label_CNombre.Visible = False
            txt_CNombre.Visible = False
            label_CAutor.Visible = False
            txt_CAutor.Visible = False
            label_CDescrip.Visible = False
            txt_CDescrip.Visible = False
            label_CSuc.Visible = False
            cb_CSuc.Visible = False

        ElseIf seleccionBus = "Nombre" Then
            label_CNombre.Visible = True
            txt_CNombre.Visible = True

            label_CFolio.Visible = False
            txt_CFolio.Visible = False
            label_CAutor.Visible = False
            txt_CAutor.Visible = False
            label_CDescrip.Visible = False
            txt_CDescrip.Visible = False
            label_CSuc.Visible = False
            cb_CSuc.Visible = False

        ElseIf seleccionBus = "Autor" Then
            label_CAutor.Visible = True
            txt_CAutor.Visible = True

            label_CFolio.Visible = False
            txt_CFolio.Visible = False
            label_CNombre.Visible = False
            txt_CNombre.Visible = False
            label_CDescrip.Visible = False
            txt_CDescrip.Visible = False
            label_CSuc.Visible = False
            cb_CSuc.Visible = False

        ElseIf seleccionBus = "Descripcion" Then
            label_CDescrip.Visible = True
            txt_CDescrip.Visible = True

            label_CFolio.Visible = False
            txt_CFolio.Visible = False
            label_CNombre.Visible = False
            txt_CNombre.Visible = False
            label_CAutor.Visible = False
            txt_CAutor.Visible = False
            label_CSuc.Visible = False
            cb_CSuc.Visible = False

        ElseIf seleccionBus = "Sucursal_venta" Then
            label_CSuc.Visible = True
            cb_CSuc.Visible = True

            label_CFolio.Visible = False
            txt_CFolio.Visible = False
            label_CNombre.Visible = False
            txt_CNombre.Visible = False
            label_CAutor.Visible = False
            txt_CAutor.Visible = False
            label_CDescrip.Visible = False
            txt_CDescrip.Visible = False

        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim busqueda

        If txt_CFolio.Text <> Nothing Then
            busqueda = txt_CFolio.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Libros WHERE Folio = " + busqueda + ""

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Libros")

                Adaptador.Fill(paquete.Tables("Libros"))

                Grid_Libros.DataSource = paquete.Tables("Libros")
                TXT_registro.Text = Grid_Libros.Rows.Count

                Grid_Libros.Columns("Folio").Width = 120
                Grid_Libros.Columns("Nombre").Width = 120
                Grid_Libros.Columns("Autor").Width = 120
                Grid_Libros.Columns("Descripcion").Width = 120
                Grid_Libros.Columns("Sucursal_Venta").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_CFolio.Clear()

        ElseIf txt_CNombre.Text <> Nothing Then
            busqueda = txt_CNombre.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Libros WHERE Nombre Like '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Libros")

                Adaptador.Fill(paquete.Tables("Libros"))

                Grid_Libros.DataSource = paquete.Tables("Libros")
                TXT_registro.Text = Grid_Libros.Rows.Count

                Grid_Libros.Columns("Folio").Width = 120
                Grid_Libros.Columns("Nombre").Width = 120
                Grid_Libros.Columns("Autor").Width = 120
                Grid_Libros.Columns("Descripcion").Width = 120
                Grid_Libros.Columns("Sucursal_Venta").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_CNombre.Clear()

        ElseIf txt_CAutor.Text <> Nothing Then
            busqueda = txt_CAutor.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Libros WHERE Autor Like '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Libros")

                Adaptador.Fill(paquete.Tables("Libros"))

                Grid_Libros.DataSource = paquete.Tables("Libros")
                TXT_registro.Text = Grid_Libros.Rows.Count

                Grid_Libros.Columns("Folio").Width = 120
                Grid_Libros.Columns("Nombre").Width = 120
                Grid_Libros.Columns("Autor").Width = 120
                Grid_Libros.Columns("Descripcion").Width = 120
                Grid_Libros.Columns("Sucursal_Venta").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_CAutor.Clear()

        ElseIf txt_CDescrip.Text <> Nothing Then
            busqueda = txt_CDescrip.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Libros WHERE Descripcion Like '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Libros")

                Adaptador.Fill(paquete.Tables("Libros"))

                Grid_Libros.DataSource = paquete.Tables("Libros")
                TXT_registro.Text = Grid_Libros.Rows.Count

                Grid_Libros.Columns("Folio").Width = 120
                Grid_Libros.Columns("Nombre").Width = 120
                Grid_Libros.Columns("Autor").Width = 120
                Grid_Libros.Columns("Descripcion").Width = 120
                Grid_Libros.Columns("Sucursal_Venta").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            txt_CDescrip.Clear()

        ElseIf cb_CSuc.Text <> "Seleccion Sucursal" Then
            busqueda = cb_CSuc.Text

            Try
                Dim paquete As New DataSet
                Dim ConsultaSQL As String
                Dim Adaptador As OleDbDataAdapter

                ConsultaSQL = "SELECT * FROM Libros WHERE Sucursal_Venta Like '%" + busqueda + "%'"

                Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)

                paquete.Tables.Add("Libros")

                Adaptador.Fill(paquete.Tables("Libros"))

                Grid_Libros.DataSource = paquete.Tables("Libros")
                TXT_registro.Text = Grid_Libros.Rows.Count

                Grid_Libros.Columns("Folio").Width = 120
                Grid_Libros.Columns("Nombre").Width = 120
                Grid_Libros.Columns("Autor").Width = 120
                Grid_Libros.Columns("Descripcion").Width = 120
                Grid_Libros.Columns("Sucursal_Venta").Width = 120

            Catch ex As Exception
                MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            cb_CSuc.Text = "Seleccion Sucursal"
        End If
    End Sub

    Private Sub ButtonMostar_Click(sender As Object, e As EventArgs) Handles ButtonMostar.Click
        MostarProductos()
    End Sub

    Private Sub ButtonRegistro_Click(sender As Object, e As EventArgs) Handles ButtonRegistro.Click
        MostarProductos()

        Boton_Reiniciar.Visible = True
        Button_Eliminar.Visible = True
        Boton_Actualizar.Visible = True
        Button1.Visible = True
        ButtonConsulta.Visible = True

        ButtonBuscar.Visible = False
        ButtonRegistro.Visible = False

        Label2.Visible = True
        txt_fol.Visible = True
        Label3.Visible = True
        txt_nom.Visible = True
        Label4.Visible = True
        txt_au.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        txt_descrip.Visible = True
        ComboBox_suc.Visible = True

        label_BuscarPor.Visible = False
        cb_CriterioBusqueda.Visible = False
    End Sub
End Class