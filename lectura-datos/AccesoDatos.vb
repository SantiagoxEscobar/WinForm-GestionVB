Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class AccesoDatos
    Private _conexion As SqlConnection
    Private _comando As SqlCommand
    Private _lector As SqlDataReader

    Public ReadOnly Property Lector() As SqlDataReader
        Get
            Return _lector
        End Get
    End Property

    Public Sub New()
        _conexion = New SqlConnection("Server=SR-CPU\MSSQLSERVER2008;database=pruebademo;Integrated Security=True")
        _comando = New SqlCommand()
    End Sub

    Public Sub SetearConsulta(consulta As String)
        _comando.CommandType = CommandType.Text
        _comando.CommandText = consulta
    End Sub

    Public Sub SetearParametro(nombre As String, valor As Object)
        _comando.Parameters.AddWithValue(nombre, valor)
    End Sub

    Public Sub EjecutarLectura()
        _comando.Connection = _conexion
        Try
            _conexion.Open()
            _lector = _comando.ExecuteReader()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EjecutarAccion()
        _comando.Connection = _conexion
        Try
            _conexion.Open()
            _comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub CerrarConexion()
        If Not _lector Is Nothing Then
            _lector.Close()
        End If
        _conexion.Close()
    End Sub
End Class