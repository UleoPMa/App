Imports System.Data
Imports System.Data.OleDb
Module Conexion_Bse
    Dim Ruta As String = Application.StartupPath
    Public conexion As New OleDbConnection

    Sub Enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & vbLf &
            Ruta + "\Recursos\Base_principal.accdb"
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Module
