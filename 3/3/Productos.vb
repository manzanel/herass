﻿
Imports System.Data
Imports System.Data.SqlClient

Public Class Productos
    Inherits conexion
    Private Id_ As Integer
    Private Nombre_ As String
    Private Cantidad_ As String
    Private Unidad_ As String
    Private Minimo_ As String
    Private Apedir_ As String


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

    Public Property Cantidad() As String
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As String)
            Cantidad_ = value

        End Set
    End Property
    Public Property Unidad() As String
        Get
            Return Unidad_
        End Get
        Set(ByVal value As String)
            Unidad_ = value
        End Set
    End Property
    Public Property Minimo() As String
        Get
            Return Minimo_
        End Get
        Set(ByVal value As String)
            Minimo_ = value
        End Set
    End Property
    Public Property Apedir() As String
        Get
            Return Apedir_
        End Get
        Set(ByVal value As String)
            Apedir_ = value

        End Set
    End Property

    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Dim strconexion As String = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "SELECT * FROM productos"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        Dim objdatatable As New Data.DataTable
        Dim objdataadapter As New SqlDataAdapter(objcomando)

        objconexion.Open()
        objdataadapter.Fill(objdatatable)
        tabla.DataSource = objdatatable
        objconexion.Close()



    End Sub
    Public Sub insertar(ByVal producto As Productos)
        Abrir()
        'Dim strconexion As String = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection=true;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "INSERT INTO productos (Nombre,Cantidad,Unidad,Minimo,Apedir)  VALUES (@Nombre,@Cantidad,@Unidad, @Minimo,@Apedir) "
        Dim objcomando As New SqlCommand("InsertarProducto", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", producto.Nombre)


        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
        objcomando.Parameters.AddWithValue("@Unidad", producto.Unidad)
        objcomando.Parameters.AddWithValue("@Minimo", producto.Minimo)
        objcomando.Parameters.AddWithValue("@Apedir", producto.Apedir)
        'objcomando.Parameters("@Nombre").Value = producto.Nombre
        'objcomando.Parameters("@Cantidad").Value = producto.Cantidad
        'objcomando.Parameters("@Unidad").Value = producto.Unidad
        'objcomando.Parameters("@Minimo").Value = producto.Minimo
        'objcomando.Parameters("@Apedir").Value = producto.Apedir


        objcomando.ExecuteNonQuery()
        Cerrar()

    End Sub
    Public Sub modificar(ByVal producto As Productos)
        Abrir()
        'Dim strconexion As String = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "UPDATE productos SET Nombre=@Nombre,Cantidad=@Cantidad,Unidad=@Unidad, Minimo =@Minimo, Apedir= @Apedir WHERE Id=@Id"
        Dim objcomando As New SqlCommand("ModificarProductos", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", producto.Nombre)






        'objcomando.Parameters.Add("@Id", SqlDbType.Int)
        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
        objcomando.Parameters.AddWithValue("@Unidad", producto.Unidad)
        objcomando.Parameters.AddWithValue("@Minimo", producto.Minimo)
        objcomando.Parameters.AddWithValue("@Apedir", producto.Apedir)
        objcomando.Parameters.AddWithValue("@Id", producto.Id)

        'objcomando.Parameters("@Id").Value = producto.Id
        'objcomando.Parameters("@Nombre").Value = producto.Nombre
        'objcomando.Parameters("@Cantidad").Value = producto.Cantidad
        'objcomando.Parameters("@Unidad").Value = producto.Unidad
        'objcomando.Parameters("@Minimo").Value = producto.Minimo
        'objcomando.Parameters("@Apedir").Value = producto.Apedir


        objcomando.ExecuteNonQuery()
        Cerrar()

    End Sub

    Public Sub borrar(ByVal Idproducto As Integer)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_connection =True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "DELETE productos WHERE Id =@Id"

        Dim objcomando As New SqlCommand("EliminarProducto", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.Add("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idproducto
        objcomando.ExecuteNonQuery()

        Cerrar()


    End Sub

End Class
