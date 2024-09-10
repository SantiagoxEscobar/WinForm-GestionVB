Public Class VentasItem
    Public Sub New()
        id = -1
        venta = Nothing
        Producto = Nothing
        preciounitario = 0.0D
        cantidad = 0
        preciototal = 0.0D
    End Sub
    Public Property id As Integer
    Public Property venta As Venta
    Public Property Producto As Producto
    Public Property preciounitario As Double
    Public Property cantidad As Integer
    Public Property preciototal As Double
End Class
