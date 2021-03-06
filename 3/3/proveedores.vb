﻿
Imports System.Data
Imports System.Data.SqlClient



Public Class proveedores
    Inherits conexion
    Private Id_ As Integer
    Private Nombre_ As String
    Private Direccion_ As String
    Private Catalogo_ As String
    Private Email_ As String
    Private Telefono_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value

        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value

        End Set
    End Property
    Public Property Catalogo() As String
        Get
            Return Catalogo_
        End Get
        Set(ByVal value As String)
            Catalogo_ = value

        End Set
    End Property
    Public Property Email() As String
        Get
            Return Email_
        End Get
        Set(ByVal value As String)
            Email_ = value

        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value

        End Set
    End Property

    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Dim strconexion As String = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "SELECT * FROM proveedor"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        Dim objdatatable As New Data.DataTable
        Dim objdataadapter As New SqlDataAdapter(objcomando)

        objconexion.Open()
        objdataadapter.Fill(objdatatable)
        tabla.DataSource = objdatatable
        objconexion.Close()

    End Sub

    Public Sub insertar(ByVal proveedor As proveedores)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "INSERT INTO proveedor (Nombre,Direccion,Catalogo,Email,Telefono) VALUES (@Nombre,@Direccion,@Catalogo,@Email,@Telefono)"
        Dim objcomando As New SqlCommand("InsertarProveedor", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)

        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)

        objcomando.Parameters.AddWithValue("@Catalogo", proveedor.Catalogo)
        objcomando.Parameters.AddWithValue("@Email", proveedor.Email)
        objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
        'objcomando.Parameters("@Nombre").Value = proveedor.Nombre
        'objcomando.Parameters("@Direccion").Value = proveedor.Direccion
        'objcomando.Parameters("@Catalogo").Value = proveedor.Catalogo
        'objcomando.Parameters("@Email").Value = proveedor.Email
        'objcomando.Parameters("@Telefono").Value = proveedor.Telefono


        objcomando.ExecuteNonQuery()
        Cerrar()



    End Sub
    Public Sub modificar(ByVal proveedor As proveedores)
        Abrir()
        'Dim strconexion As String = "Server =CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection = True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "UPDATE proveedor SET Nombre=@Nombre,Direccion=@Direccion,Catalogo=@Catalogo,Email=@Email,Telefono=@Telefono WHERE Id =@Id"
        Dim objcomando As New SqlCommand("ModificarProveedor", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)

        'objcomando.Parameters.Add("@Id", SqlDbType.Int)
        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)

        objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
        objcomando.Parameters.AddWithValue("@Catalogo", proveedor.Catalogo)
        objcomando.Parameters.AddWithValue("@Email", proveedor.Email)
        objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
        objcomando.Parameters.AddWithValue("@Id", proveedor.Id)
        'objcomando.Parameters("@Id").Value = proveedor.Id
        'objcomando.Parameters("@Nombre").Value = proveedor.Nombre
        'objcomando.Parameters("@Direccion").Value = proveedor.Direccion
        'objcomando.Parameters("@Catalogo").Value = proveedor.Catalogo
        'objcomando.Parameters("@Email").Value = proveedor.Email
        'objcomando.Parameters("@Telefono").Value = proveedor.Telefono


        objcomando.ExecuteNonQuery()
        Cerrar()

    End Sub

    Public Sub borrar(ByVal Idproveedor As Integer)
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection =True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "DELETE proveedor WHERE Id =@Id"

        Dim objcomando As New SqlCommand("EliminarProveedor", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure

        objcomando.Parameters.Add("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idproveedor
        objcomando.ExecuteNonQuery()
        Cerrar()

    End Sub
End Class
