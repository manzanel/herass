﻿Public Class lstEmpleados

    Dim empleado As New Empleados
    Private Sub lstEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado.ConsultarTodos(dgvEmpleados)
        Form2.Enabled = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmEmpleado.accion = "insertar"
        frmEmpleado.ShowDialog()



    End Sub

    Private Sub dgvEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick
        empleado.Id = dgvEmpleados.Item("Id", dgvEmpleados.CurrentRow.Index).Value
        empleado.Nombre = dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentRow.Index).Value
        empleado.Telefono = dgvEmpleados.Item("Telefono", dgvEmpleados.CurrentRow.Index).Value
        empleado.Direccion = dgvEmpleados.Item("Direccion", dgvEmpleados.CurrentRow.Index).Value
        empleado.Email = dgvEmpleados.Item("Email", dgvEmpleados.CurrentRow.Index).Value
        frmEmpleado.accion = "modificar"
        frmEmpleado.empleado = empleado
        frmEmpleado.ShowDialog()

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("¿ QUIERE BORRAR?")
        If mensaje = Windows.Forms.DialogResult.OK Then
            empleado.borrar(dgvEmpleados.Item("id", dgvEmpleados.CurrentRow.Index).Value)
            empleado.ConsultarTodos(dgvEmpleados)

        End If


    End Sub
End Class

