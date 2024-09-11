Imports System.Configuration
Imports System.Data.SqlClient

Public Class AccesoDatos
    Private _conexion As SqlConnection
    Private _comando As SqlCommand
    Private _lector As SqlDataReader
    Private _connectionString As String = String.Empty

    Public ReadOnly Property Lector() As SqlDataReader
        Get
            Return _lector
        End Get
    End Property

    Public Sub New()
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        _connectionString = config.ConnectionStrings.ConnectionStrings("pruebademo").ConnectionString

        _conexion = New SqlConnection(_connectionString)
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