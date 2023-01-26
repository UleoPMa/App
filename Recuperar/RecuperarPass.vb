Imports System.Runtime.InteropServices
Public Class RecuperarPass
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Enviar_Solicitud_Click(sender As Object, e As EventArgs) Handles Enviar_Solicitud.Click
        MsgBox("Se envió el correo del usuario a *" & Txt_correos.Text & "*", MsgBoxStyle.OkOnly, "Solicitud")
        Cerar.Start()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ComboBoxUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsuarios.SelectedIndexChanged
        App.ComboBoxUsuarios.Text = ComboBoxUsuarios.Text
        Txt_correos.Text = App.Correovar
    End Sub

    Private Sub Abrir_Tick(sender As Object, e As EventArgs) Handles Abrir.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If Me.Opacity = 1 Then
            Abrir.Stop()
        End If
    End Sub

    Private Sub Cerar_Tick(sender As Object, e As EventArgs) Handles Cerar.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Cerar.Stop()
            Me.Close()
            App.Show()
        End If
    End Sub

    Private Sub RecuperarPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Abrir.Start()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Cerar.Start()
    End Sub
End Class