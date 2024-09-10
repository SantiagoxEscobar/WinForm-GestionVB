Imports System.Text.RegularExpressions
Imports dominio
Imports lectura_datos
Public Class frmClientesEditar
    Private cliente As Cliente = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal cliente As Cliente)
        InitializeComponent()
        Me.cliente = cliente
        Text = "Editar Cliente"
    End Sub

    Private Sub frmEditarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not cliente Is Nothing Then
                txtCliente.Text = cliente.cliente
                txtTelefono.Text = cliente.telefono
                txtCorreo.Text = cliente.correo
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditarClientes_Click(sender As Object, e As EventArgs) Handles btnEditarClientes.Click
        Dim lecturaCliente As New LecturaCliente
        Try
            If cliente Is Nothing Then
                cliente = New Cliente()
            End If
            cliente.cliente = txtCliente.Text
            cliente.telefono = txtTelefono.Text
            cliente.correo = txtCorreo.Text

            If txtCliente.Text = "" Then
                lblAdvertencia.Text = "Debe completar el campo Cliente."
                Return
            End If

            Dim validarCliente As String = "^[A-Z][A-Za-z0-9]*$"
            If Not Regex.IsMatch(txtCliente.Text, validarCliente) Then
                lblAdvertencia.Text = "Debe completar con un formato válido el campo Cliente."
                Return
            End If

            Dim regexTel As New Regex("^\+\d{1,3}\s?\d{1,3}\s?\d{3}\s?\d{2}\s?\d{2}$")
            If Not regexTel.IsMatch(txtTelefono.Text) Then
                lblAdvertencia.Text = "Debe completar con números el campo Teléfono."
                Return
            End If

            Dim regexCor As New Regex("^[^\s@]+@[^\s@]+\.[^\s@]+$")
            If Not regexCor.IsMatch(txtCorreo.Text) Then
                lblAdvertencia.Text = "Debe completar con un email válido el campo Correo."
                Return
            End If

            If cliente.id <> -1 Then
                lecturaCliente.editar(cliente)
                MessageBox.Show("Cliente editado correctamente")
            Else
                lecturaCliente.agregar(cliente)
                MessageBox.Show("Cliente agregado correctamente")
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancelarClientes_Click(sender As Object, e As EventArgs) Handles btnCancelarClientes.Click
        Me.Close()
    End Sub
End Class