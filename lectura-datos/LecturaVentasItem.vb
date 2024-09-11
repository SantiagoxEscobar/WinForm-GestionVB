Imports dominio
Public Class LecturaVentasItem
    Public Function listar(seleccionado As Integer) As List(Of VentasItem)
        Dim lista As New List(Of VentasItem)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("SELECT P.ID AS 'IDProducto', P.Nombre, VI.ID AS 'ID', VI.PrecioUnitario, VI.Cantidad, VI.PrecioTotal FROM ventasItems VI INNER JOIN productos P ON P.ID = VI.IDProducto WHERE VI.IDVenta = @ID")
            datos.SetearParametro("@ID", seleccionado)
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim aux As New VentasItem()
                aux.id = CInt(datos.Lector("ID"))
                aux.preciounitario = CDec(datos.Lector("PrecioUnitario"))
                aux.cantidad = CDec(datos.Lector("Cantidad"))
                aux.preciototal = CDec(datos.Lector("PrecioTotal"))

                aux.Producto = New Producto()
                If Not IsDBNull(datos.Lector("IDProducto")) Then
                    aux.Producto.id = CInt(datos.Lector("IDProducto"))
                End If
                If Not IsDBNull(datos.Lector("Nombre")) Then
                    aux.Producto.nombre = CStr(datos.Lector("Nombre"))
                End If

                lista.Add(aux)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Sub agregar(nuevo As VentasItem, idVenta As Integer)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("INSERT INTO ventasitems(IDVenta, IDProducto, PrecioUnitario, Cantidad ,PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)")
            datos.SetearParametro("@IDVenta", idVenta)
            datos.SetearParametro("@IDProducto", nuevo.Producto.id)
            datos.SetearParametro("@PrecioUnitario", nuevo.preciounitario)
            datos.SetearParametro("@Cantidad", nuevo.cantidad)
            datos.SetearParametro("@PrecioTotal", nuevo.preciototal)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub editar(editado As VentasItem)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("UPDATE ventasitems SET IDVenta=@IDVenta, IDProducto=@IDProducto, PrecioUnitario=@PrecioUnitario, Cantidad=@Cantidad WHERE ID = @ID")
            datos.SetearParametro("@ID", editado.id)
            datos.SetearParametro("@IDVenta", editado.venta.id)
            datos.SetearParametro("@IDProducto", editado.Producto.id)
            datos.SetearParametro("@PrecioUnitario", editado.preciounitario)
            datos.SetearParametro("@Cantidad", editado.cantidad)
            datos.SetearParametro("@PrecioTotal", editado.preciototal)
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
            datos.SetearConsulta("DELETE FROM ventasitems WHERE Id = @ID")
            datos.SetearParametro("@ID", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub
End Class
