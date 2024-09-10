Imports dominio

Public Class LecturaCliente
    Public Function listar() As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("SELECT ID, cliente as Cliente, Telefono AS Teléfono, Correo FROM clientes")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim aux As New Cliente()
                aux.id = CInt(datos.Lector("ID"))
                aux.cliente = CStr(datos.Lector("Cliente"))
                aux.telefono = CStr(datos.Lector("Teléfono"))
                aux.correo = CStr(datos.Lector("Correo"))
                lista.Add(aux)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Function listar(seleccionado As Integer) As Cliente
        Dim cliente As New Cliente
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("SELECT ID, cliente as Cliente, Telefono AS Teléfono, Correo FROM clientes WHERE id=@ID")
            datos.SetearParametro("@ID", seleccionado)
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim aux As New Cliente()
                aux.cliente = CStr(datos.Lector("Cliente"))
                aux.telefono = CStr(datos.Lector("Teléfono"))
                aux.correo = CStr(datos.Lector("Correo"))
                cliente = aux
            End While

            Return cliente
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Sub agregar(nuevo As Cliente)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("INSERT INTO Clientes (cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)")
            datos.SetearParametro("@Cliente", nuevo.cliente)
            datos.SetearParametro("@Telefono", nuevo.telefono)
            datos.SetearParametro("@Correo", nuevo.correo)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub editar(editado As Cliente)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("UPDATE clientes SET Cliente=@Cliente, Telefono=@Telefono, Correo=@Correo WHERE ID=@ID")
            datos.SetearParametro("@ID", editado.id)
            datos.SetearParametro("@Cliente", editado.cliente)
            datos.SetearParametro("@Telefono", editado.telefono)
            datos.SetearParametro("@Correo", editado.correo)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub eliminar(id As Integer)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("DELETE FROM clientes WHERE Id = @ID")
            datos.SetearParametro("@ID", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub
End Class