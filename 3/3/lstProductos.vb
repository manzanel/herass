Public Class lstProductos
    Dim producto As New Productos

    Private Sub lstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        producto.ConsultarTodos(dgvProductos)


    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmProducto.accion = "insertar"
        frmProducto.ShowDialog()

    End Sub


    Private Sub dgvProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        producto.Id = dgvProductos.Item("Id", dgvProductos.CurrentRow.Index).Value
        producto.Nombre = dgvProductos.Item("Nombre", dgvProductos.CurrentRow.Index).Value
        producto.Cantidad = dgvProductos.Item("Cantidad", dgvProductos.CurrentRow.Index).Value
        producto.Unidad = dgvProductos.Item("Unidad", dgvProductos.CurrentRow.Index).Value
        producto.Minimo = dgvProductos.Item("Minimo", dgvProductos.CurrentRow.Index).Value
        producto.Apedir = dgvProductos.Item("Apedir", dgvProductos.CurrentRow.Index).Value

        frmProducto.accion = "modificar"
        frmProducto.producto = producto
        frmProducto.ShowDialog()


    End Sub





    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("¿quiere borrar?")
        If mensaje = Windows.Forms.DialogResult.OK Then
            producto.borrar(dgvProductos.Item("id", dgvProductos.CurrentRow.Index).Value)
            producto.ConsultarTodos(dgvProductos)

        End If

    End Sub
End Class