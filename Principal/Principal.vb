Imports System.Runtime.InteropServices
Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nombre.Text = App.Nombrevar
        Label_Sector.Text = App.Sector
        Try
            Dim path As String = My.Application.Info.DirectoryPath
            Boton1.Image = Image.FromFile("..\..\Resources\inicio.png").GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
            Button4.Image = Image.FromFile("..\..\Resources\logout.png").GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
            Button6.Image = Image.FromFile("..\..\Resources\Libros.png").GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
            Albun.Image = Image.FromFile("..\..\Resources\image.png").GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
        Catch ex As Exception
            MsgBox("Error en cargar las imagenes, Ubicación desconocida ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Application.Exit()
    End Sub

    Private Sub Button_Max_Click(sender As Object, e As EventArgs) Handles Button_Max.Click
        Maximizar()
    End Sub

    Private Sub Button_min_Click(sender As Object, e As EventArgs) Handles Button_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel_MenuLat_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_MenuLat.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Arreglar_Colores()
        Boton1.FlatAppearance.BorderSize = 2
        Boton1.FlatAppearance.BorderColor = Color.Yellow
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        App.Show()

    End Sub

    Dim LocalizacionX As Integer
    Dim LocalizacionY As Integer
    Dim Anchura As Integer
    Dim Altura As Integer

    Private Sub Maximizar()
        LocalizacionX = Me.Location.X
        LocalizacionY = Me.Location.Y
        Anchura = Me.Size.Width
        Altura = Me.Size.Height
        Button_Max.Visible = False
        Restaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point(0, -0.8)
        'Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Me.Size = New Size(Anchura, Altura)
        Me.Location = New Point(LocalizacionX, LocalizacionY)
        Button_Max.Visible = True
        Restaurar.Visible = False
    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        LabelHora.Text = DateTime.Now.ToString("HH:mm:ss")
        LabelFecha.Text = Date.Now.ToLongDateString
    End Sub

    Dim FormularioActivo As Form = Nothing

    Sub Abrir_Fomulario_Panel_Contenedo(ByVal FormularioHijo As Form)
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Close()
        End If
        FormularioActivo = FormularioHijo
        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        Panel_Contenedor.Controls.Add(FormularioHijo)
        Panel_Contenedor.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()
    End Sub

    Sub Arreglar_Colores()
        Boton1.FlatAppearance.BorderSize = 0
        Boton1.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50)

        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50)

        Albun.FlatAppearance.BorderSize = 0
        Albun.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub Panel_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Contenedor.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Abrir_Fomulario_Panel_Contenedo(New Libros)
        Arreglar_Colores()
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatAppearance.BorderColor = Color.Yellow
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Abrir_Fomulario_Panel_Contenedo(New Libros)
        Arreglar_Colores()
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatAppearance.BorderColor = Color.Yellow
    End Sub

    Private Sub Albun_Click(sender As Object, e As EventArgs) Handles Albun.Click
        Abrir_Fomulario_Panel_Contenedo(New Album_Musica)
        Arreglar_Colores()
        Albun.FlatAppearance.BorderSize = 2
        Albun.FlatAppearance.BorderColor = Color.Yellow
    End Sub
End Class