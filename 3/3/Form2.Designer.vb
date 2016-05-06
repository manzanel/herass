<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TABLASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LstEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LstProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LstProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LstClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TABLASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(735, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TABLASToolStripMenuItem
        '
        Me.TABLASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LstEmpleadosToolStripMenuItem, Me.LstProveedoresToolStripMenuItem, Me.LstProductosToolStripMenuItem, Me.LstClientesToolStripMenuItem})
        Me.TABLASToolStripMenuItem.Name = "TABLASToolStripMenuItem"
        Me.TABLASToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.TABLASToolStripMenuItem.Text = "TABLAS"
        '
        'LstEmpleadosToolStripMenuItem
        '
        Me.LstEmpleadosToolStripMenuItem.Name = "LstEmpleadosToolStripMenuItem"
        Me.LstEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LstEmpleadosToolStripMenuItem.Text = "lstEmpleados"
        '
        'LstProveedoresToolStripMenuItem
        '
        Me.LstProveedoresToolStripMenuItem.Name = "LstProveedoresToolStripMenuItem"
        Me.LstProveedoresToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LstProveedoresToolStripMenuItem.Text = "lstProveedores"
        '
        'LstProductosToolStripMenuItem
        '
        Me.LstProductosToolStripMenuItem.Name = "LstProductosToolStripMenuItem"
        Me.LstProductosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LstProductosToolStripMenuItem.Text = "lstProductos"
        '
        'LstClientesToolStripMenuItem
        '
        Me.LstClientesToolStripMenuItem.Name = "LstClientesToolStripMenuItem"
        Me.LstClientesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LstClientesToolStripMenuItem.Text = "lstClientes"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 374)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TABLASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
