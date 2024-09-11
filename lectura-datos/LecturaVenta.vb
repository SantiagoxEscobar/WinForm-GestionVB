Imports dominio
Public Class LecturaVenta
    Public Function listar() As List(Of Venta)
        Dim lista As New List(Of Venta)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("SELECT ID, IDCliente, Fecha, Total FROM ventas")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim aux As New Venta()
                aux.id = CInt(datos.Lector("ID"))
                aux.Idcliente = CInt(datos.Lector("IDCliente"))
                aux.fecha = CDate(datos.Lector("Fecha"))
                aux.total = CStr(datos.Lector("Total"))

                lista.Add(aux)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Function listarUltimo() As Integer
        Dim datos As New AccesoDatos()
        Dim ultimoId As Integer = 0
        Try
            datos.SetearConsulta("SELECT TOP(1) ID FROM ventas ORDER BY ID DESC")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                ultimoId = CInt(datos.Lector("ID"))
            End While

            Return ultimoId
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Function

    Public Sub agregar(nuevo As Venta)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total)")
            datos.SetearParametro("@IDCliente", nuevo.Idcliente)
            datos.SetearParametro("@Fecha", nuevo.fecha)
            datos.SetearParametro("@Total", nuevo.total)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub editar(editado As Venta)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("UPDATE ventas SET IDCliente=@IDCliente, Fecha=@Fecha, Total=@Total WHERE ID = @ID")
            datos.SetearParametro("@ID", editado.id)
            datos.SetearParametro("@IDCliente", editado.Idcliente)
            datos.SetearParametro("@Fecha", editado.fecha)
            datos.SetearParametro("@Total", editado.total)
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
            datos.SetearConsulta("DELETE FROM ventas WHERE Id = @ID")
            datos.SetearParametro("@ID", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub
End Class
