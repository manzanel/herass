
Imports System.Data
Imports System.Data.SqlClient


Public Class clientes
    Private Id_ As Integer
    Private Nombre_ As String
    Private Email_ As String
    Private Telefono_ As String
    Private Direccion_ As String

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


    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS; Database = DistribuidoraHerass; Trusted_Connection=True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "SELECT * FROM cliente"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objcomando)

        objconexion.Open()
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable
        objconexion.Close()

    End Sub


    Public Sub insertar(ByVal cliente As clientes)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection=True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "INSERT INTO cliente (Nombre,Email,Telefono,Direccion) values (@Nombre,@Email,@Telefono,@Direccion)"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Email", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Telefono", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Direccion", SqlDbType.VarChar)
        objcomando.Parameters("@Nombre").Value = cliente.Nombre
        objcomando.Parameters("@Email").Value = cliente.Telefono
        objcomando.Parameters("@Telefono").Value = cliente.Direccion
        objcomando.Parameters("@Direccion").Value = cliente.Email

        objconexion.Open()
        objcomando.ExecuteNonQuery()
        objconexion.Close()



    End Sub


    Public Sub modificar(ByVal cliente As clientes)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "UPDATE cliente SET Nombre= @Nombre,Telefono = @Telefono,Direccion = @Direccion, Email=@Email WHERE Id=@Id"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        objcomando.Parameters.Add("@Id", SqlDbType.Int)
        objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Email", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Telefono", SqlDbType.VarChar)
        objcomando.Parameters.Add("@Direccion", SqlDbType.VarChar)
        objcomando.Parameters("@Id").Value = cliente.Id
        objcomando.Parameters("@Nombre").Value = cliente.Nombre
        objcomando.Parameters("@Email").Value = cliente.Telefono
        objcomando.Parameters("@Telefono").Value = cliente.Direccion
        objcomando.Parameters("@Direccion").Value = cliente.Email

        objconexion.Open()
        objcomando.ExecuteNonQuery()
        objconexion.Close()

    End Sub


    Public Sub borrar(ByVal Idcliente As Integer)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = " DELETE cliente WHERE Id=@Id"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        objcomando.Parameters.Add("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idcliente
        objconexion.Open()
        objcomando.ExecuteNonQuery()
        objconexion.Close()

    End Sub






End Class
