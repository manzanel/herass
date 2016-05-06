Public Class lstProveedores
    Dim proveedor As New proveedores

    Private Sub lstProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proveedor.ConsultarTodos(dgvProveedores)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmProveedor.accion = "insertar"
        frmProveedor.ShowDialog()

    End Sub

    Private Sub dgvProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
        proveedor.Id = dgvProveedores.Item("Id", dgvProveedores.CurrentRow.Index).Value
        proveedor.Nombre = dgvProveedores.Item("Nombre", dgvProveedores.CurrentRow.Index).Value
        proveedor.Direccion = dgvProveedores.Item("Direccion", dgvProveedores.CurrentRow.Index).Value
        proveedor.Catalogo = dgvProveedores.Item("Catalogo", dgvProveedores.CurrentRow.Index).Value
        proveedor.Email = dgvProveedores.Item("Email", dgvProveedores.CurrentRow.Index).Value
        proveedor.Telefono = dgvProveedores.Item("Telefono", dgvProveedores.CurrentRow.Index).Value

        frmProveedor.accion = "modificar"
        frmProveedor.proveedor = proveedor
        frmProducto.ShowDialog()

    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("QUIERE BORRAR CLIENTE")
        If mensaje = Windows.Forms.DialogResult.OK Then
            proveedor.borrar(dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value)

            proveedor.ConsultarTodos(dgvProveedores)

        End If
    End Sub
End Class