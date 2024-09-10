Public Class Venta
    Public Sub New()
        id = -1
        Idcliente = -1
        fecha = DateTime.MinValue
        total = 0.0D
    End Sub

    Public Property id As Integer
    Public Property Idcliente As Integer
    Public Property fecha As DateTime
    Public Property total As Double
End Class
