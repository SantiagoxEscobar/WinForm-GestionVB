Imports System.Text.RegularExpressions
Imports dominio
Imports lectura_datos
Public Class frmVentasEditar
    Private seleccionado As Venta = Nothing
    Private listaLecturaClientes As List(Of Cliente)
    Private listaLecturaVentasItem As List(Of VentasItem)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Venta As Venta)
        InitializeComponent()
        Me.seleccionado = Venta
        Text = "Editar Venta"
    End Sub

    Private Sub frmVentasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not seleccionado Is Nothing Then
                txtIdCliente.Text = seleccionado.Idcliente
                dtpFecha.Text = seleccionado.fecha
                txtTotal.Text = seleccionado.total 'COLOCAR EL CALCULO DE LOS PRODUCTOS
                cargarDatos()
            End If
            cargarClientes()
            filtrarCliente()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs)
        filtrarCliente()
    End Sub

    Private Sub btnEditarVentas_Click(sender As Object, e As EventArgs) Handles btnEditarVentas.Click

    End Sub

    Private Sub btnCancelarVentas_Click(sender As Object, e As EventArgs) Handles btnCancelarVentas.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click

    End Sub

    Private Sub cargarClientes()
        Dim lecturaCliente As New LecturaCliente
        Try
            listaLecturaClientes = lecturaCliente.listar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub filtrarCliente()
        Dim clienteFiltrado As Cliente
        Dim filtro As String = txtIdCliente.Text

        If Not txtIdCliente.Text = "" Then
            clienteFiltrado = listaLecturaClientes.FirstOrDefault(Function(x) x.id.ToString().ToUpper().Contains(filtro.ToUpper()))

            If clienteFiltrado IsNot Nothing Then
                txtCliente.Text = clienteFiltrado.cliente
                txtTelefono.Text = clienteFiltrado.telefono
                txtCorreo.Text = clienteFiltrado.correo

                Return
            End If
        End If
        txtCliente.Text = Nothing
        txtTelefono.Text = Nothing
        txtCorreo.Text = Nothing
    End Sub

    Private Sub cargarDatos()
        Dim lecturaVentasItem As New LecturaVentasItem()
        Try
            listaLecturaVentasItem = lecturaVentasItem.listar(seleccionado.id)
            dgvProductos.DataSource = listaLecturaVentasItem

            dgvProductos.Columns("Venta").Visible = False
            dgvProductos.Columns("ID").Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class