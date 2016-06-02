
Imports System.Data
Imports System.Data.SqlClient


Public Class clientes
    Inherits conexion
    Private Id_ As Integer
    Private Nombre_ As String
    Private Email_ As String
    Private Telefono_ As String
    Private Direccion_ As String
    Private IdProvincia_ As Integer


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

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value

        End Set
    End Property
    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_

        End Get
        Set(ByVal value As Integer)
            IdProvincia_ = value


        End Set
    End Property

    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS; Database = DistribuidoraHerass; Trusted_Connection=True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "SELECT * FROM cliente"

        Dim objcomando As New SqlCommand("pConsultaCliente", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objcomando)

        'objconexion.Open()
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable
        tabla.Columns("IdProvincia").Visible = False
        tabla.Columns("IdProvincia1").Visible = False


        Cerrar()

    End Sub


    Public Sub insertar(ByVal cliente As clientes)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection=True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "INSERT INTO cliente (Nombre,Email,Telefono,Direccion) values (@Nombre,@Email,@Telefono,@Direccion)"
        Dim objcomando As New SqlCommand("InsertarCliente", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", cliente.Nombre)





        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Email", cliente.Email)
        objcomando.Parameters.AddWithValue("@Telefono", cliente.Telefono)
        objcomando.Parameters.AddWithValue("@Direccion", cliente.Direccion)
        objcomando.Parameters.AddWithValue("@IdProvincia", cliente.IdProvincia)
        'objcomando.Parameters("@Nombre").Value = cliente.Nombre
        'objcomando.Parameters("@Email").Value = cliente.Telefono
        'objcomando.Parameters("@Telefono").Value = cliente.Direccion
        'objcomando.Parameters("@Direccion").Value = cliente.Email


        objcomando.ExecuteNonQuery()
        Cerrar()



    End Sub


    Public Sub modificar(ByVal cliente As clientes)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "UPDATE cliente SET Nombre= @Nombre,Telefono = @Telefono,Direccion = @Direccion, Email=@Email WHERE Id=@Id"


        Dim objcomando As New SqlCommand("ModificarCliente", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure

        objcomando.Parameters.AddWithValue("@Nombre", cliente.Nombre)

        'objcomando.Parameters.Add("@Id", SqlDbType.Int)
        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)

        objcomando.Parameters.AddWithValue("@Email", cliente.Email)
        objcomando.Parameters.AddWithValue("@Telefono", cliente.Telefono)
        objcomando.Parameters.AddWithValue("@Direccion", cliente.Direccion)
        objcomando.Parameters.AddWithValue("@id", cliente.Id)
        objcomando.Parameters.AddWithValue("@IdProvincia", cliente.IdProvincia)
        'objcomando.Parameters("@Id").Value = cliente.Id
        'objcomando.Parameters("@Nombre").Value = cliente.Nombre
        'objcomando.Parameters("@Email").Value = cliente.Telefono
        'objcomando.Parameters("@Telefono").Value = cliente.Direccion
        'objcomando.Parameters("@Direccion").Value = cliente.Email


        objcomando.ExecuteNonQuery()
        Cerrar()

    End Sub


    Public Sub borrar(ByVal Idcliente As Integer)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        ''Dim strcomando As String = " DELETE cliente WHERE Id=@Id"

        Dim objcomando As New SqlCommand("EliminarCliente", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idcliente
        objcomando.ExecuteNonQuery()

        Cerrar()
    End Sub






End Class
