Public Class Cliente
    Public Sub New()
        id = -1
        cliente = ""
        telefono = ""
        correo = ""
    End Sub

    Public Property id As Integer
    Public Property cliente As String
    Public Property telefono As String
    Public Property correo As String

    Public Overrides Function ToString() As String
        Return cliente
    End Function
End Class
