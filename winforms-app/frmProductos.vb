Imports dominio
Imports lectura_datos

Public Class frmProductos
    Private listaLecturaProductos As List(Of Producto)
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatos()
            cargarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarProductos.Text = "" Then
            limpiarCampos()
            cargarDatos()
        Else
            filtrarDatos()
        End If
        cargarFiltros()
    End Sub

    Private Sub cbxOrdenarProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrdenarProductos.SelectedIndexChanged
        filtrarDatos()
        ordenarDatos()
        cargarFiltros()
    End Sub

    Private Sub btnLimpiarProductos_Click(sender As Object, e As EventArgs) Handles btnLimpiarProductos.Click
        limpiarCampos()
        cargarDatos()
    End Sub

    Private Sub btnAgregarProductos_Click(sender As Object, e As EventArgs) Handles btnAgregarProductos.Click
        Dim alta As New frmProductosEditar()
        Try
            alta.ShowDialog()
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditarProductos_Click(sender As Object, e As EventArgs) Handles btnEditarProductos.Click
        Try
            If dgvProductos.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un Producto para poder modificarlo")
                Return
            End If
            Dim seleccionado As Producto = DirectCast(dgvProductos.CurrentRow.DataBoundItem, Producto)
            Dim editar As New frmProductosEditar(seleccionado)
            editar.ShowDialog()
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEliminarProductos_Click(sender As Object, e As EventArgs) Handles btnEliminarProductos.Click
        Dim lecturaProducto As New LecturaProducto()
        Try
            If dgvProductos.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un cliente para poder modificarlo")
                Return
            End If
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el Producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                Dim seleccionado As Producto = DirectCast(dgvProductos.CurrentRow.DataBoundItem, Producto)
                lecturaProducto.eliminar(seleccionado.id)

                MessageBox.Show("Producto eliminado correctamente")
                cargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub cargarDatos()
        Dim lecturaProducto As New LecturaProducto()
        Try
            listaLecturaProductos = LecturaProducto.listar()
            dgvProductos.DataSource = listaLecturaProductos
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub cargarCampos()
        cbxOrdenarProductos.Items.Add("Por defecto")
        cbxOrdenarProductos.Items.Add("Ascendente")
        cbxOrdenarProductos.Items.Add("Descendente")
        cbxOrdenarProductos.SelectedIndex = 0
    End Sub

    Private Sub filtrarDatos()
        Dim listaFiltrada As New List(Of Producto)
        Dim filtro As String = txtBuscarProductos.Text
        If rbIdProductos.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaProductos.FindAll(Function(x) x.id = filtro)
            End If
        ElseIf rbIdProductos.Checked Then
            listaFiltrada = listaLecturaProductos.FindAll(Function(x) x.nombre.ToUpper.Contains(filtro.ToUpper()) OrElse x.nombre.ToLower.Contains(filtro.ToLower()))
        ElseIf rbPrecioProductos.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaProductos.FindAll(Function(x) x.precio = filtro)
            End If
        ElseIf rbCategoriaProductos.Checked Then
            listaFiltrada = listaLecturaProductos.FindAll(Function(x) x.categoria.ToUpper.Contains(filtro.ToUpper()) OrElse x.categoria.ToLower.Contains(filtro.ToLower()))
        Else
            listaFiltrada = listaLecturaProductos.FindAll(Function(x) x.id.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.nombre.ToUpper().Contains(filtro) OrElse
                                                        x.precio.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.categoria.ToUpper().Contains(filtro))
        End If
        listaLecturaProductos = listaFiltrada
    End Sub

    Private Sub ordenarDatos()
        Dim listaFiltrada As List(Of Producto)
        Dim opcion As String = cbxOrdenarProductos.SelectedItem.ToString()
        If opcion = "Ascendente" Then
            listaFiltrada = listaLecturaProductos.OrderBy(Function(x) x.id).ToList()
        ElseIf opcion = "Descendente" Then
            listaFiltrada = listaLecturaProductos.OrderByDescending(Function(x) x.id).ToList()
        Else
            Return
        End If
        listaLecturaProductos = listaFiltrada
    End Sub

    Private Sub cargarFiltros()
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = listaLecturaProductos
        dgvProductos.ClearSelection()
        Dim lecturaProducto As New LecturaProducto()
        listaLecturaProductos = lecturaProducto.listar()
    End Sub

    Private Sub limpiarCampos()
        txtBuscarProductos.Text = ""

        rbIdProductos.Checked = False
        rbIdProductos.Checked = False
        rbPrecioProductos.Checked = False
        rbCategoriaProductos.Checked = False
        cbxOrdenarProductos.SelectedIndex = 0
    End Sub
End Class