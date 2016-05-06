Public Class frmProducto
    Private accion_ As String
    Private producto_ As New Productos
    Public Property producto() As Productos
        Get
            Return producto_
        End Get
        Set(ByVal value As Productos)
            producto_ = value

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
        producto.Nombre = txtNombre.Text
        producto.Cantidad = txtCantidad.Text
        producto.Unidad = txtUnidad.Text
        producto.Minimo = txtMinimo.Text
        producto.Apedir = txtMinimo.Text

        If accion_ = "insertar" Then
            producto.insertar(producto)
        Else
            producto.Id = txtId.Text
            producto.modificar(producto)

        End If

        producto.ConsultarTodos(lstProductos.dgvProductos)
        Me.Close()

    End Sub


    Private Sub frmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "insertar" Then
            Me.Text = "agregar producto"
            txtNombre.Text = ""
            txtCantidad.Text = ""
            txtUnidad.Text = ""
            txtMinimo.Text = ""
            txtApedir.Text = ""
        Else
            Me.Text = "modificar producto"
            txtId.Text = producto.Id
            txtNombre.Text = producto.Nombre
            txtCantidad.Text = producto.Cantidad
            txtUnidad.Text = producto.Unidad
            txtMinimo.Text = producto.Minimo
            txtApedir.Text = producto.Apedir



        End If
    End Sub
End Class