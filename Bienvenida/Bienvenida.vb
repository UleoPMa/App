Imports System.Runtime.InteropServices
Public Class Bienvenida
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelBienvenida.Click

    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = App.Nombrevar
        correo.Text = App.Correovar
        LabelSector.Text = App.Sector
        LabelEdad.Text = App.Edad
        Me.Opacity = 0
        BarraDeProg.Value = 0
        TimerAbrir.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        App.Show()
        TimerCerrar.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Bienvenida_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Labeltexto.Click

    End Sub

    Private Sub correo_Click(sender As Object, e As EventArgs) Handles correo.Click

    End Sub

    Private Sub LabelNombre_Click(sender As Object, e As EventArgs) Handles LabelNombre.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BotonIniciar.Click
        MsgBox("La contraseña del usuario es: " & App.Contravar, MsgBoxStyle.OkOnly, "Bienvenida")
        App.Show()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles BarraDeProg.Click
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        BarraDeProg.Value += 1
        LabelCargando.Text = BarraDeProg.Value & "%"

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If BarraDeProg.Value = 100 Then
            TimerAbrir.Stop()
            TimerCerrar.Start()
        End If
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerCerrar.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LabelCargando.Click

    End Sub

    Private Sub LabelExpediente_Click(sender As Object, e As EventArgs) Handles LabelEdad.Click

    End Sub
End Class