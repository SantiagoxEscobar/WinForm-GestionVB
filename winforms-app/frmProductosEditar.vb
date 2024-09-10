Imports System.Text.RegularExpressions
Imports dominio
Imports lectura_datos
Public Class frmProductosEditar
    Private Producto As Producto = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Producto As Producto)
        InitializeComponent()
        Me.Producto = Producto
        Text = "Editar Producto"
    End Sub

    Private Sub frmEditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not Producto Is Nothing Then
                txtNombre.Text = Producto.nombre
                txtPrecio.Text = Producto.precio
                txtCategoria.Text = Producto.categoria
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditarProductos_Click(sender As Object, e As EventArgs) Handles btnEditarProductos.Click
        Dim lecturaProducto As New LecturaProducto
        Try
            If Producto Is Nothing Then
                Producto = New Producto()
            End If
            Producto.nombre = txtNombre.Text
            Producto.precio = txtPrecio.Text
            Producto.categoria = txtCategoria.Text

            If txtNombre.Text = "" Then
                lblAdvertencia.Text = "Debe completar el campo Nombre."
                Return
            End If

            Dim validarNombre As String = "^[A-Z][A-Za-z0-9]*$"
            If Not Regex.IsMatch(txtCategoria.Text, validarNombre) Then
                lblAdvertencia.Text = "Debe completar con un formato válido el campo Nombre."
                Return
            End If

            Dim validarPrecio As String = "^\d+(\.\d{2})?$"
            If Not Regex.IsMatch(txtPrecio.Text, validarPrecio) Then
                lblAdvertencia.Text = "Debe completar con números el campo Precio."
                Return
            End If

            Dim validarCategoria As String = "^[A-Z][A-Za-z0-9]*$"
            If Not Regex.IsMatch(txtCategoria.Text, validarCategoria) Then
                lblAdvertencia.Text = "Debe completar con un formato válido el campo Categoría."
                Return
            End If

            If Producto.id <> -1 Then
                lecturaProducto.editar(Producto)
                MessageBox.Show("Producto editado correctamente")
            Else
                lecturaProducto.agregar(Producto)
                MessageBox.Show("Producto agregado correctamente")
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancelarProductos_Click(sender As Object, e As EventArgs) Handles btnCancelarProductos.Click
        Me.Close()
    End Sub
End Class