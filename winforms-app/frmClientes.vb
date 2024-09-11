Imports dominio
Imports lectura_datos

Public Class frmClientes
    Private listaLecturaClientes As List(Of Cliente)
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatos()
            cargarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarClientes.Text = "" Then
            limpiarCampos()
            cargarDatos()
        Else
            filtrarDatos()
        End If
        cargarFiltros()
    End Sub

    Private Sub cbxOrdenarClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrdenarClientes.SelectedIndexChanged
        filtrarDatos()
        ordenarDatos()
        cargarFiltros()
    End Sub

    Private Sub btnLimpiarClientes_Click(sender As Object, e As EventArgs) Handles btnLimpiarClientes.Click
        limpiarCampos()
        cargarDatos()
    End Sub

    Private Sub btnAgregarClientes_Click(sender As Object, e As EventArgs) Handles btnAgregarClientes.Click
        Dim alta As New frmClientesEditar()
        Try
            alta.ShowDialog()
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditarClientes_Click(sender As Object, e As EventArgs) Handles btnEditarClientes.Click
        Try
            If dgvClientes.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un cliente para poder modificarlo")
                Return
            End If
            Dim seleccionado As Cliente = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Cliente)
            Dim editar As New frmClientesEditar(seleccionado)
            editar.ShowDialog()
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEliminarClientes_Click(sender As Object, e As EventArgs) Handles btnEliminarClientes.Click
        Dim lecturaCliente As New LecturaCliente()
        Try
            If dgvClientes.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un cliente para poder modificarlo")
                Return
            End If
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar al Cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                Dim seleccionado As Cliente = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Cliente)
                lecturaCliente.eliminar(seleccionado.id)

                MessageBox.Show("Cliente eliminado correctamente")
                cargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub cargarDatos()
        Dim lecturaCliente As New LecturaCliente()
        Try
            listaLecturaClientes = lecturaCliente.listar()
            dgvClientes.DataSource = listaLecturaClientes
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub cargarCampos()
        cbxOrdenarClientes.Items.Add("Por defecto")
        cbxOrdenarClientes.Items.Add("Ascendente")
        cbxOrdenarClientes.Items.Add("Descendente")
        cbxOrdenarClientes.SelectedIndex = 0
    End Sub

    Private Sub filtrarDatos()
        Dim listaFiltrada As New List(Of Cliente)
        Dim filtro As String = txtBuscarClientes.Text
        If rbIdClientes.Checked Then
            If IsNumeric(filtro) Then
                listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.id = filtro)
            Else
                listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.id.ToString().ToUpper().Contains(filtro))
            End If
        ElseIf rbNombreClientes.Checked Then
            listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.cliente.ToUpper.Contains(filtro.ToUpper()) OrElse x.cliente.ToLower.Contains(filtro.ToLower()))
        ElseIf rbTelefonoClientes.Checked Then
            listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.telefono.ToUpper.Contains(filtro.ToUpper()) OrElse x.telefono.ToLower.Contains(filtro.ToLower()))
        ElseIf rbCorreoClientes.Checked Then
            listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.correo.ToUpper.Contains(filtro.ToUpper()) OrElse x.correo.ToLower.Contains(filtro.ToLower()))
        Else
            listaFiltrada = listaLecturaClientes.FindAll(Function(x) x.id.ToString().ToUpper().Contains(filtro) OrElse
                                                        x.cliente.ToUpper().Contains(filtro) OrElse x.cliente.ToLower.Contains(filtro.ToLower()) OrElse
                                                        x.telefono.ToUpper().Contains(filtro) OrElse x.telefono.ToLower.Contains(filtro.ToLower()) OrElse
                                                        x.correo.ToUpper().Contains(filtro) OrElse x.correo.ToLower.Contains(filtro.ToLower()))
        End If
        listaLecturaClientes = listaFiltrada
    End Sub

    Private Sub ordenarDatos()
        Dim listaFiltrada As List(Of Cliente)
        Dim opcion As String = cbxOrdenarClientes.SelectedItem.ToString()
        If opcion = "Ascendente" Then
            If rbIdClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderBy(Function(x) x.id).ToList()
            ElseIf rbNombreClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderBy(Function(x) x.cliente).ToList()
            ElseIf rbTelefonoClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderBy(Function(x) x.telefono).ToList()
            ElseIf rbCorreoClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderBy(Function(x) x.correo).ToList()
            Else
                listaFiltrada = listaLecturaClientes.OrderBy(Function(x) x.id).ToList()
            End If
        ElseIf opcion = "Descendente" Then
            If rbIdClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderByDescending(Function(x) x.id).ToList()
            ElseIf rbNombreClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderByDescending(Function(x) x.cliente).ToList()
            ElseIf rbTelefonoClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderByDescending(Function(x) x.telefono).ToList()
            ElseIf rbCorreoClientes.Checked Then
                listaFiltrada = listaLecturaClientes.OrderByDescending(Function(x) x.correo).ToList()
            Else
                listaFiltrada = listaLecturaClientes.OrderByDescending(Function(x) x.id).ToList()
            End If
        Else
            Return
        End If
        listaLecturaClientes = listaFiltrada
    End Sub

    Private Sub cargarFiltros()
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = listaLecturaClientes
        dgvClientes.ClearSelection()
        Dim lecturaCliente As New LecturaCliente()
        listaLecturaClientes = lecturaCliente.listar()
    End Sub

    Private Sub limpiarCampos()
        txtBuscarClientes.Text = ""

        rbIdClientes.Checked = False
        rbIdClientes.Checked = False
        rbTelefonoClientes.Checked = False
        rbCorreoClientes.Checked = False
        cbxOrdenarClientes.SelectedIndex = 0
    End Sub
End Class