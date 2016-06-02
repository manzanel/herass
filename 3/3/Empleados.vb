
Imports System.Data
Imports System.Data.SqlClient



Public Class Empleados
    Inherits conexion
    Private Id_ As Integer
    Private Nombre_ As String
    Private Telefono_ As Integer
    Private Direccion_ As String
    Private Email_ As String

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
    Public Property Telefono() As Integer
        Get
            Return Telefono_
        End Get
        Set(ByVal value As Integer)
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
    Public Property Email()
        Get
            Return Email_
        End Get
        Set(ByVal value)
            Email_ = value

        End Set
    End Property
    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS; Database = DistribuidoraHerass; Trusted_Connection=True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "SELECT * FROM empleado"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objcomando)

        objconexion.Open()
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable
        objconexion.Close()

    End Sub
    Public Sub insertar(ByVal empleado As Empleados)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection=True;"
        'Dim objconexion As New SqlConnection(strconexion)
        ''Dim strcomando As String = "INSERT INTO empleado (Nombre,Telefono,Direccion,Email) values (@Nombre,@Telefono,@Direccion,@Email)"
        Dim objcomando As New SqlCommand("InsertarEmpleado", objconexion)


        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", empleado.Nombre)



        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Telefono", empleado.Telefono)
        objcomando.Parameters.AddWithValue("@Direccion", empleado.Direccion)
        objcomando.Parameters.AddWithValue("@Email", empleado.Email)
        'objcomando.Parameters("@Nombre").Value = empleado.Nombre
        'objcomando.Parameters("@Telefono").Value = empleado.Telefono
        'objcomando.Parameters("@Direccion").Value = empleado.Direccion
        'objcomando.Parameters("@Email").Value = empleado.Email


        objcomando.ExecuteNonQuery()

        Cerrar()


    End Sub
    Public Sub modificar(ByVal empleado As Empleados)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "UPDATE empleado SET Nombre= @Nombre,Telefono = @Telefono,Direccion = @Direccion, Email=@Email WHERE Id=@Id"
        Dim objcomando As New SqlCommand("ModificarEmpleado", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", empleado.Nombre)



        'objcomando.Parameters.Add("@Id", SqlDbType.Int)
        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Telefono", empleado.Telefono)
        objcomando.Parameters.AddWithValue("@Direccion", empleado.Direccion)
        objcomando.Parameters.AddWithValue("@Email", empleado.Email)

        objcomando.Parameters.AddWithValue("@Id", empleado.Id)

        'objcomando.Parameters("@Id").Value = empleado.Id
        'objcomando.Parameters("@Nombre").Value = empleado.Nombre
        'objcomando.Parameters("@Telefono").Value = empleado.Telefono
        'objcomando.Parameters("@Direccion").Value = empleado.Direccion
        'objcomando.Parameters("@Email").Value = empleado.Email


        objcomando.ExecuteNonQuery()

        Cerrar()
    End Sub

    Public Sub borrar(ByVal Idempleado As Integer)
        Abrir()
        'Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        'Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = " DELETE empleado WHERE Id=@Id"

        Dim objcomando As New SqlCommand("EliminarEmpleado", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.Add("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idempleado
        objcomando.ExecuteNonQuery()

        Cerrar()
    End Sub
End Class


