Public Class frmEmpleado
    Private accion_ As String
    Private empleado_ As New Empleados

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property empleado() As Empleados

        Get
            Return empleado_

        End Get
        Set(ByVal value As Empleados)
            empleado_ = value

        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        empleado.Nombre = txtNombre.Text
        empleado.Telefono = txtTelefono.Text
        empleado.Direccion = txtDireccion.Text
        empleado.Email = txtEmail.Text
        If accion_ = "insertar" Then
            empleado.insertar(empleado)
        Else
            empleado.Id = txtId.Text
            empleado.modificar(empleado)

        End If

        empleado.ConsultarTodos(lstEmpleados.dgvEmpleados)
        Me.Close()

    End Sub

    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "insertar" Then
            Me.Text = "agregar empleado"
            txtNombre.Text = ""
            txtTelefono.Text = ""
            txtDireccion.Text = ""
            txtEmail.Text = ""
        Else
            Me.Text = "modificar empleado"
            txtId.Text = empleado.Id
            txtNombre.Text = empleado.Nombre
            txtTelefono.Text = empleado.Telefono
            txtDireccion.Text = empleado.Direccion
            txtEmail.Text = empleado.Email

        End If

    End Sub
End Class
