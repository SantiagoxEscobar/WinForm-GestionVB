Public Class Producto
    Public Sub New()
        id = -1
        nombre = ""
        precio = 0.0
        categoria = ""
    End Sub

    Public Property id As Integer
    Public Property nombre As String
    Public Property precio As Double
    Public Property categoria As String

    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class
