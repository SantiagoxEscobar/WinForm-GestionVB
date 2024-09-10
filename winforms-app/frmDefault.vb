Public Class frmDefault

    Private Sub default_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As New frmHome()
        mostrarVentana(ventana)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim ventana As New frmHome()
        mostrarVentana(ventana)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim ventana As New frmClientes()
        mostrarVentana(ventana)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim ventana As New frmProductos()
        mostrarVentana(ventana)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim ventana As New frmVentas()
        mostrarVentana(ventana)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit
    End Sub

    Public Sub mostrarVentana(ventana)
        ventana.MdiParent = Me
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub
End Class