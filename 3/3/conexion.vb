
Imports System.Data
Imports System.Data.SqlClient


Public Class conexion
    Private strconexion_ As String
    Private objconexion_ As SqlConnection
    Public Property strconexion() As String
        Get
            Return strconexion_
        End Get
        Set(ByVal value As String)
            strconexion_ = value
        End Set
    End Property

    Public Property objconexion() As SqlConnection
        Get
            Return objconexion_
        End Get
        Set(ByVal value As SqlConnection)
            objconexion_ = value

        End Set
    End Property


    Public Sub Abrir()
        Try
            strconexion_ = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
            objConexion_ = New SqlConnection(strConexion)
            objConexion_.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Cerrar()
        If Data.ConnectionState.Open Then
            objConexion_.Close()
        End If
    End Sub

End Class

