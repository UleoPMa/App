Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Public Class App
    Public Nombrevar As String
    Public Correovar As String
    Public Contravar As String
    Public Generovar As String
    Public Sector As String
    Public Edad As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        TimerCerrar.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub App_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlace()
        CargarUsuarios()
        ComboBoxUsuarios.Text = "Ulises Leonardo"
        Txt_passwords.Text = "leo1017"
        Me.Opacity = 0
        TimerAbrir.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsuarios.SelectedIndexChanged
        CargarDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Iniciar_sesion.Click
        BotonIniciar()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxUsuarios.KeyPress
        e.KeyChar = ""
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_passwords.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BotonIniciar()
        End If
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If Me.Opacity = 1 Then
            TimerAbrir.Stop()
        End If
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerCerrar.Stop()
            Application.Exit()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        RecuperarPass.Show()
    End Sub

    Private Sub Boton_Ocultar_MouseDown(sender As Object, e As MouseEventArgs) Handles Boton_Ocultar.MouseDown
        Txt_passwords.PasswordChar = ""
    End Sub

    Private Sub Boton_Ocultar_MouseUp(sender As Object, e As MouseEventArgs) Handles Boton_Ocultar.MouseUp
        Txt_passwords.PasswordChar = "•"
    End Sub

    Private Sub CargarUsuarios()
        Try
            Dim tabla As New DataTable
            Dim ConsultaSQL As String = "SELECT Nombre FROM Usuarios"
            Dim Adaptador As New OleDbDataAdapter(ConsultaSQL, conexion)
            Adaptador.fill(tabla)
            ComboBoxUsuarios.DataSource = tabla
            ComboBoxUsuarios.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BotonIniciar()

        Try
            Dim ConsultaSQL As String
            Dim Adaptador As New OleDb.OleDbDataAdapter
            Dim Comando As New OleDb.OleDbCommand
            Dim Lector As OleDb.OleDbDataReader

            ConsultaSQL = "SELECT * FROM Usuarios WHERE Nombre = '" & ComboBoxUsuarios.Text & "' AND Clave = '" & Txt_passwords.Text & "' "
            Comando = New OleDbCommand(ConsultaSQL, conexion)
            Adaptador.SelectCommand = Comando
            Lector = Comando.ExecuteReader

            If Lector.Read = True Then
                Me.Hide()
                Bienvenida.ShowDialog()
                Principal.Show()
            Else
                MsgBox("Contraseña incorrecta:, intente nuevamente", MsgBoxStyle.Critical, "Login")
                Txt_passwords.Clear()
            End If


        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargarDatos()
        Try
            Dim ConsultaSQL As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSQL = "SELECT Nombre, Clave, Correo, Edad, Genero, Sector FROM Usuarios WHERE Nombre = '" & ComboBoxUsuarios.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "Usuarios")

            Lista = Registro.Tables("Usuarios").Rows.Count

            If Lista <> 0 Then
                Nombrevar = Registro.Tables("Usuarios").Rows(0).Item("Nombre")
                Contravar = Registro.Tables("Usuarios").Rows(0).Item("Clave")
                Correovar = Registro.Tables("Usuarios").Rows(0).Item("Correo")
                Edad = Registro.Tables("Usuarios").Rows(0).Item("Edad")
                Generovar = Registro.Tables("Usuarios").Rows(0).Item("Genero")
                Sector = Registro.Tables("Usuarios").Rows(0).Item("Sector")
            Else

            End If

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class