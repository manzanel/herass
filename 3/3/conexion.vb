
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

    Public Sub abrir()
        strconexion_ = "server=CI7427EA91ADCA\SQLEXPRESS; Database = DistribuidoraHerass; Trusted_Connection=True;"
        Dim objconexion As New SqlConnection
        objconexion.Open()



    End Sub
    Public Sub salir()
        strconexion_ = "server=CI7427EA91ADCA\SQLEXPRESS; Database = DistribuidoraHerass; Trusted_Connection=True;"
        Dim objconexion As New SqlConnection
        objconexion.Close()


    End Sub





End Class
