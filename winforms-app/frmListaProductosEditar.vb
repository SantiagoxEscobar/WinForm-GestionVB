Imports System.Text.RegularExpressions
Imports dominio
Imports lectura_datos
Public Class frmListaProductosEditar
    Private listaLecturaProductos As List(Of Producto)
    Dim total As Double = 0
    Public Shared nuevoProducto As VentasItem
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarProductos()
            nupCantidad.Minimum = 1
            nupCantidad.Value = 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged
        If txtIdProducto.Text = "" Then
            txtNombre.Text = Nothing
            txtCategoria.Text = Nothing
            txtPrecioUnitario.Text = 0
            txtPrecioTotal.Text = 0
        Else
            filtrarCliente()
            calcularProductos()
        End If
    End Sub

    Private Sub nupCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nupCantidad.ValueChanged
        If Not txtIdProducto.Text = "" Then
            calcularProductos()
        End If
    End Sub

    Private Sub btnConfirmarProductos_Click(sender As Object, e As EventArgs) Handles btnConfirmarProductos.Click
        Try
            If txtIdProducto.Text = "" Then
                lblAdvertencia.Text = "Debe completar el campo ID."
                Return
            End If
            Dim validarIDProducto As String = "^\d+(\.\d{2})?$"
            If Not Regex.IsMatch(txtIdProducto.Text, validarIDProducto) Then
                lblAdvertencia.Text = "Debe completar solo con números el campo Precio."
                Return
            End If

            If txtNombre.Text = "" Then
                lblAdvertencia.Text = "No existe registro del Cliente buscado."
                Return
            End If

            Dim nuevo As New VentasItem
            nuevo.cantidad = nupCantidad.Value
            nuevo.preciounitario = txtPrecioUnitario.Text
            nuevo.preciototal = txtPrecioTotal.Text

            nuevo.Producto = New Producto()
            nuevo.Producto.id = txtIdProducto.Text
            nuevo.Producto.nombre = txtNombre.Text
            nuevo.Producto.categoria = txtCategoria.Text

            nuevoProducto = nuevo
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancelarProductos_Click(sender As Object, e As EventArgs) Handles btnCancelarProductos.Click
        Me.Close()
    End Sub

    Private Sub cargarProductos()
        Dim lecturaProducto As New LecturaProducto
        Try
            listaLecturaProductos = lecturaProducto.listar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub filtrarCliente()
        Dim productoFiltrado As Producto
        Dim filtro As String = txtIdProducto.Text

        If Not txtIdProducto.Text = "" Then
            productoFiltrado = listaLecturaProductos.FirstOrDefault(Function(x) x.id.ToString().ToUpper().Contains(filtro.ToUpper()))

            If productoFiltrado IsNot Nothing Then
                txtNombre.Text = productoFiltrado.nombre
                txtCategoria.Text = productoFiltrado.categoria
                txtPrecioUnitario.Text = productoFiltrado.precio
                Return
            End If
        End If
        txtNombre.Text = Nothing
        txtCategoria.Text = Nothing
        txtPrecioUnitario.Text = 0
    End Sub

    Private Sub calcularProductos()
        total = 0
        total = txtPrecioUnitario.Text * (nupCantidad.Value)
        txtPrecioTotal.Text = total
    End Sub
End Class