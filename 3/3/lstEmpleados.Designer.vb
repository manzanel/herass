﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.GridColor = System.Drawing.Color.Magenta
        Me.dgvEmpleados.Location = New System.Drawing.Point(13, 13)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.RowTemplate.Height = 24
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(560, 204)
        Me.dgvEmpleados.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(13, 244)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 48)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(142, 244)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(146, 46)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(306, 244)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(111, 43)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "BORRAR"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(441, 244)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 47)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumVioletRed
        Me.ClientSize = New System.Drawing.Size(620, 316)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "lstEmpleados"
        Me.Text = "Empleados"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
