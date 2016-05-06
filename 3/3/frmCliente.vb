Public Class frmCliente
    Private accion_ As String
    Private cliente_ As New clientes
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property cliente() As clientes
        Get
            Return cliente_
        End Get
        Set(ByVal value As clientes)
            cliente_ = value

        End Set
    End Property


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        cliente.Nombre = txtNombre.Text
        cliente.Email = txtEmail.Text
        cliente.Telefono = txtEmail.Text
        cliente.Direccion = txtDireccion.Text
        If accion_ = "insertar" Then
            cliente.insertar(cliente)
        Else
            cliente.Id = txtId.Text
            cliente.modificar(cliente)

        End If
        cliente.ConsultarTodos(lstClientes.dgvClientes)
        Me.Close()

    End Sub

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "insertar" Then
            Me.Text = "agregar cliente"
            txtNombre.Text = ""
            txtEmail.Text = ""
            txtTelefono.Text = ""
            txtDireccion.Text = ""
        Else
            Me.Text = "modificar cliente"
            txtId.Text = cliente.Id
            txtNombre.Text = cliente.Nombre
            txtEmail.Text = cliente.Email
            txtTelefono.Text = cliente.Telefono
            txtDireccion.Text = cliente.Direccion

        End If
    End Sub
End Class