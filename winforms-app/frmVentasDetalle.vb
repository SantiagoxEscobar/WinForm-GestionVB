Imports dominio
Imports lectura_datos

Public Class frmVentasDetalle
    Private listaLecturaVentasItems As List(Of VentasItem)
    Private ClienteSeleccionado As Cliente
    Private seleccionado As Venta

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(seleccionado As Venta)
        InitializeComponent()
        Me.seleccionado = seleccionado
    End Sub

    Private Sub frmVentasDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnElminarDetalle.Click
        Dim lecturaVentasItems As New LecturaVentasItem()
        Dim lecturaVentas As New LecturaVenta()
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar la Venta?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                Dim eliminado As Integer = seleccionado.id
                If Not dgvDetalle.CurrentRow Is Nothing Then
                    lecturaVentasItems.eliminar(eliminado)
                End If
                lecturaVentas.eliminar(eliminado)
                MessageBox.Show("Producto eliminado correctamente")
                Dim ventana As New frmVentas()
                mostrarVentana(ventana)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim ventana As New frmVentasEditar(seleccionado)
        ventana.ShowDialog()
        cargarDatos()
    End Sub

    Private Sub btnGenerarDetalle_Click(sender As Object, e As EventArgs) Handles btnReporteVenta.Click

    End Sub

    Private Sub btnVolverDetalle_Click(sender As Object, e As EventArgs) Handles btnVolverDetalle.Click
        Dim ventana As New frmVentas()
        mostrarVentana(ventana)
    End Sub

    Private Sub cargarDatos()
        Dim lecturaCliente As New LecturaCliente()
        Dim lecturaVentasItem As New LecturaVentasItem
        Try
            ClienteSeleccionado = lecturaCliente.listar(seleccionado.Idcliente)
            listaLecturaVentasItems = lecturaVentasItem.listar(seleccionado.id)

            lblVenta.Text = "Venta N° " + seleccionado.id.ToString()
            lblFecha.Text = seleccionado.fecha
            lblTotal.Text = "$" + seleccionado.total.ToString()
            lblNombre.Text = ClienteSeleccionado.cliente
            lblTelefono.Text = ClienteSeleccionado.telefono
            lblCorreo.Text = ClienteSeleccionado.correo

            dgvDetalle.DataSource = listaLecturaVentasItems
            dgvDetalle.Columns("Venta").Visible = False
            dgvDetalle.Columns("ID").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Public Sub mostrarVentana(ventana)
        ventana.MdiParent = frmDefault
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub
End Class