Imports dominio
Public Class LecturaProducto
    Public Function listar() As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("SELECT ID, Nombre, Precio, Categoria AS Categoría FROM productos")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim aux As New Producto()
                aux.id = CInt(datos.Lector("ID"))
                aux.nombre = CStr(datos.Lector("Nombre"))
                aux.precio = CDec(datos.Lector("Precio"))
                aux.categoria = CStr(datos.Lector("Categoría"))
                lista.Add(aux)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    Public Sub agregar(nuevo As Producto)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("INSERT INTO productos(Nombre, Precio, Categoria) VALUES(@Nombre, @Precio, @Categoria)")
            datos.SetearParametro("@Nombre", nuevo.nombre)
            datos.SetearParametro("@Precio", nuevo.precio)
            datos.SetearParametro("@Categoria", nuevo.categoria)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub editar(editado As Producto)
        Dim datos As New AccesoDatos()
        Try
            datos.SetearConsulta("UPDATE productos SET Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria WHERE ID = @ID")
            datos.SetearParametro("@ID", editado.id)
            datos.SetearParametro("@Nombre", editado.nombre)
            datos.SetearParametro("@Precio", editado.precio)
            datos.SetearParametro("@Categoria", editado.categoria)
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
            datos.SetearConsulta("DELETE FROM productos WHERE Id = @ID")
            datos.SetearParametro("@ID", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Sub
End Class