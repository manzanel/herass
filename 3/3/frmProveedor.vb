Public Class frmProveedor
    Private accion_ As String
    Private proveedor_ As New proveedores
    Public Property proveedor() As proveedores
        Get
            Return proveedor_
        End Get
        Set(ByVal value As proveedores)
            proveedor_ = value

        End Set
    End Property

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value

        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        proveedor.Nombre = txtNombre.Text
        proveedor.Direccion = txtDireccion.Text
        proveedor.Catalogo = txtCatalogo.Text
        proveedor.Email = txtEmail.Text
        proveedor.Telefono = txtTelefono.Text

        If accion_ = "insertar" Then
            proveedor.insertar(proveedor)

        End If
        proveedor.ConsultarTodos(lstProveedores.dgvProveedores)
        Me.Close()



    End Sub

    Private Sub frmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "insertar" Then
            Me.Text = "agregar proveedor"
            txtNombre.Text = ""
            txtDireccion.Text = ""
            txtCatalogo.Text = ""
            txtEmail.Text = ""
            txtTelefono.Text = ""
        Else
            Me.Text = "modificar proveedor "
            txtId.Text = proveedor.Id
            txtNombre.Text = proveedor.Nombre
            txtDireccion.Text = proveedor.Direccion
            txtCatalogo.Text = proveedor.Catalogo
            txtEmail.Text = proveedor.Email
            txtTelefono.Text = proveedor.Telefono

        End If
    End Sub
End Class