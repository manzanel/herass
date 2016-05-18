Public Class Form2

    

    Private Sub LstEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpleadosToolStripMenuItem.Click
        lstEmpleados.Show()

    End Sub

   
    Private Sub LstProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstProveedoresToolStripMenuItem.Click
        lstProveedores.Show()

    End Sub

    Private Sub LstProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstProductosToolStripMenuItem.Click
        lstProductos.Show()

    End Sub

   


    Private Sub LstClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstClientesToolStripMenuItem.Click
        lstClientes.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    

End Class