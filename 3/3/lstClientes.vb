Public Class lstClientes

    Dim cliente As New clientes


    Private Sub lstClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.ConsultarTodos(dgvClientes)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmCliente.accion = "insertar"
        frmCliente.ShowDialog()

    End Sub


    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        cliente.Id = dgvClientes.Item("Id", dgvClientes.CurrentRow.Index).Value
        cliente.Nombre = dgvClientes.Item("Nombre", dgvClientes.CurrentRow.Index).Value
        cliente.Email = dgvClientes.Item("Email", dgvClientes.CurrentRow.Index).Value
        cliente.Telefono = dgvClientes.Item("Telefono", dgvClientes.CurrentRow.Index).Value
        cliente.Direccion = dgvClientes.Item("Direccion", dgvClientes.CurrentRow.Index).Value
        frmCliente.accion = "modificar"
        frmCliente.cliente = cliente
        frmCliente.ShowDialog()


    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("¿quiere borrar")
        If mensaje = Windows.Forms.DialogResult.OK Then
            cliente.borrar(dgvClientes.Item("Id", dgvClientes.CurrentRow.Index).Value)

            cliente.ConsultarTodos(dgvClientes)

        End If
    End Sub
End Class