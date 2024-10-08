﻿Imports System.Text.RegularExpressions
Imports dominio
Imports lectura_datos
Imports winforms_app
Public Class frmVentasEditar
    Private seleccionado As Venta = Nothing
    Private listaLecturaClientes As List(Of Cliente)
    Private listaLecturaVentas As List(Of Venta)
    Private listaLecturaVentasItem As List(Of VentasItem)
    Private listaLecturaNueva As New List(Of VentasItem)
    Dim total As Double = 0

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
            cargarClientes()
            If Not seleccionado Is Nothing Then
                txtIdCliente.Text = seleccionado.Idcliente
                dtpFecha.Text = seleccionado.fecha
                txtTotal.Text = seleccionado.total
                cargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged
        filtrarCliente()
    End Sub

    Private Sub btnConfirmarVentas_Click(sender As Object, e As EventArgs) Handles btnEditarVentas.Click
        Try
            If seleccionado Is Nothing Then
                seleccionado = New Venta()
            End If

            If txtIdCliente.Text = "" Then
                lblAdvertencia.Text = "Debe completar el campo IDCliente."
                Return
            End If

            Dim validarIdCliente As String = "^\d+$"
            If Not Regex.IsMatch(txtIdCliente.Text, validarIdCliente) Then
                lblAdvertencia.Text = "El campo IDCliente debe contener solo números."
                Return
            End If

            If listaLecturaNueva Is Nothing Then
                lblAdvertencia.Text = "La lista de productos esta vacia."
                Return
            End If

            seleccionado.Idcliente = txtIdCliente.Text
            seleccionado.fecha = dtpFecha.Text
            seleccionado.total = total

            ConfirmacionDatos()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancelarVentas_Click(sender As Object, e As EventArgs) Handles btnCancelarVentas.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarListaProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarListaProducto.Click
        Dim alta As New frmListaProductosEditar()
        alta.ShowDialog()
        Dim nuevo As New VentasItem()
        nuevo = frmListaProductosEditar.nuevoProducto
        listaLecturaNueva.Add(nuevo)

        Dim listaNueva As New List(Of VentasItem)
        For Each producto As VentasItem In listaLecturaNueva.ToList()
            listaNueva.Add(producto)
        Next
        listaLecturaNueva = listaNueva
        dgvProductos.DataSource = listaLecturaNueva
        calcularProductos()

        dgvProductos.Columns("Venta").Visible = False
        dgvProductos.Columns("ID").Visible = False
    End Sub

    Private Sub btnEliminarListaProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarListaProducto.Click
        If dgvProductos.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un producto para poder modificarlo")
            Return
        End If
        Dim eliminado As Integer = dgvProductos.CurrentRow.Index
        listaLecturaNueva.RemoveAt(eliminado)

        Dim listaNueva As New List(Of VentasItem)
        For Each producto As VentasItem In listaLecturaNueva.ToList()
            listaNueva.Add(producto)
        Next
        listaLecturaNueva = listaNueva
        dgvProductos.DataSource = listaLecturaNueva
        calcularProductos()

        dgvProductos.Columns("Venta").Visible = False
        dgvProductos.Columns("ID").Visible = False
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
            listaLecturaNueva = listaLecturaVentasItem
            calcularProductos()

            dgvProductos.Columns("Venta").Visible = False
            dgvProductos.Columns("ID").Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub calcularProductos()
        total = 0
        For Each producto As VentasItem In listaLecturaNueva.ToList()
            total += producto.preciototal
        Next
        txtTotal.Text = String.Format("${0:0.00}", total)
    End Sub

    Private Sub ConfirmacionDatos()
        Dim lecturaVenta As New LecturaVenta()
        Dim lecturaVentasItem As New LecturaVentasItem()
        Dim idVenta As Integer

        If seleccionado.id <> -1 Then
            lecturaVenta.editar(seleccionado)
            For Each lista In listaLecturaVentasItem
                lecturaVentasItem.eliminar(lista.id)
            Next
            For Each lista In listaLecturaNueva
                lecturaVentasItem.agregar(lista, seleccionado.id)
            Next
            MessageBox.Show("Venta editada correctamente")
        Else
            lecturaVenta.agregar(seleccionado)
            idVenta = lecturaVenta.listarUltimo()

            For Each lista In listaLecturaNueva
                lecturaVentasItem.agregar(lista, idVenta)
            Next
            MessageBox.Show("Venta agregada correctamente")
        End If
    End Sub
End Class