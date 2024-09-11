Imports dominio
Imports lectura_datos

Public Class frmVentas
    Private listaLecturaVentas As List(Of Venta)
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatos()
            cargarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarVentas.Text = "" Then
            limpiarCampos()
            cargarDatos()
        Else
            filtrarDatos()
        End If
        cargarFiltros()
    End Sub

    Private Sub cbxOrdenarProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrdenarVentas.SelectedIndexChanged
        filtrarDatos()
        ordenarDatos()
        cargarFiltros()
    End Sub

    Private Sub btnLimpiarVentas_Click(sender As Object, e As EventArgs) Handles btnLimpiarVentas.Click
        limpiarCampos()
        cargarDatos()
    End Sub

    Private Sub btnAgregarVentas_Click(sender As Object, e As EventArgs) Handles btnAgregarVentas.Click
        Dim alta As New frmVentasEditar()
        alta.ShowDialog()
        cargarDatos()
    End Sub

    Private Sub btnDetalleVentas_Click(sender As Object, e As EventArgs) Handles btnDetalleVentas.Click
        If dgvVentas.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una Venta para poder ver los detalles")
            Return
        End If
        Dim seleccionado As Venta = DirectCast(dgvVentas.CurrentRow.DataBoundItem, Venta)
        Dim ventana As New frmVentasDetalle(seleccionado)
        mostrarVentana(ventana)
    End Sub

    Private Sub cargarDatos()
        Dim lecturaVenta As New LecturaVenta()
        Try
            listaLecturaVentas = lecturaVenta.listar()
            dgvVentas.DataSource = listaLecturaVentas
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub cargarCampos()
        cbxOrdenarVentas.Items.Add("Por defecto")
        cbxOrdenarVentas.Items.Add("Ascendente")
        cbxOrdenarVentas.Items.Add("Descendente")
        cbxOrdenarVentas.SelectedIndex = 0
    End Sub

    Private Sub filtrarDatos()
        Dim listaFiltrada As New List(Of Venta)
        Dim filtro As String = txtBuscarVentas.Text
        If rbIdVentas.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.id = filtro)
            Else
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.id.ToString().ToUpper().Contains(filtro))
            End If
        ElseIf rbClienteVentas.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.Idcliente = filtro)
            Else
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.Idcliente.ToString().ToUpper().Contains(filtro))
            End If
        ElseIf rbFechaVentas.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.fecha = filtro)
            Else
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.fecha.ToString().ToUpper().Contains(filtro))
            End If
        ElseIf rbTotalVentas.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.total = filtro)
            Else
                listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.total.ToString.ToUpper().Contains(filtro))
            End If
        Else
            listaFiltrada = listaLecturaVentas.FindAll(Function(x) x.id.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.Idcliente.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.fecha.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.total.ToString().ToUpper().Contains(filtro))
        End If
        listaLecturaVentas = listaFiltrada
    End Sub

    Private Sub ordenarDatos()
        Dim listaFiltrada As List(Of Venta)
        Dim opcion As String = cbxOrdenarVentas.SelectedItem.ToString()
        If opcion = "Ascendente" Then
            If rbIdVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderBy(Function(x) x.id).ToList()
            ElseIf rbClienteVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderBy(Function(x) x.Idcliente).ToList()
            ElseIf rbFechaVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderBy(Function(x) x.fecha).ToList()
            ElseIf rbTotalVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderBy(Function(x) x.total).ToList()
            Else
                listaFiltrada = listaLecturaVentas.OrderBy(Function(x) x.id).ToList()
            End If
        ElseIf opcion = "Descendente" Then
            If rbIdVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderByDescending(Function(x) x.id).ToList()
            ElseIf rbClienteVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderByDescending(Function(x) x.Idcliente).ToList()
            ElseIf rbFechaVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderByDescending(Function(x) x.fecha).ToList()
            ElseIf rbTotalVentas.Checked Then
                listaFiltrada = listaLecturaVentas.OrderByDescending(Function(x) x.total).ToList()
            Else
                listaFiltrada = listaLecturaVentas.OrderByDescending(Function(x) x.id).ToList()
            End If
        Else
            Return
        End If
        listaLecturaVentas = listaFiltrada
    End Sub

    Private Sub cargarFiltros()
        dgvVentas.DataSource = Nothing
        dgvVentas.DataSource = listaLecturaVentas
        dgvVentas.ClearSelection()
        Dim lecturaVenta As New LecturaVenta()
        listaLecturaVentas = lecturaVenta.listar()
    End Sub

    Private Sub limpiarCampos()
        txtBuscarVentas.Text = ""

        rbIdVentas.Checked = False
        rbIdVentas.Checked = False
        rbFechaVentas.Checked = False
        rbTotalVentas.Checked = False
        cbxOrdenarVentas.SelectedIndex = 0
    End Sub

    Public Sub mostrarVentana(ventana)
        ventana.MdiParent = frmDefault
        ventana.Dock = DockStyle.Fill
        ventana.Show()
    End Sub
End Class