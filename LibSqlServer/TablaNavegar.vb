Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class TablaNavegar

    Private laTabla As DataTable
    Private laFila As Integer

    Private ReadOnly Property totalFilas() As Integer
        Get
            Return laTabla.Rows.Count - 1
        End Get
    End Property

    Public Sub New(ByVal tabla As DataTable)
        laTabla = tabla
        laFila = 0
        Dim totalFilas As Integer = tabla.Rows.Count - 1
    End Sub

    Public Sub ActualizarTabla(ByVal tabla As DataTable)
        laTabla = tabla
        'totalFilas = tabla.Rows.Count - 1
        If laFila > totalFilas Then
            laFila = totalFilas
        End If
        If laFila < 0 Then
            laFila = 0
        End If
    End Sub

    ' Los cuatro métodos para navegar por las filas
    Public Function Primera() As DataRow
        laFila = 0
        Return laTabla.Rows(laFila)
    End Function

    Public Function Ultima() As DataRow
        laFila = totalFilas
        Return laTabla.Rows(laFila)
    End Function

    Public Function Siguiente() As DataRow
        laFila += 1
        If laFila > totalFilas Then
            laFila = totalFilas
        End If
        Return laTabla.Rows(laFila)

    End Function

    Public Function Anterior() As DataRow
        laFila -= 1
        If laFila < 0 Then
            laFila = 0
        End If
        Return laTabla.Rows(laFila)
    End Function

    Public ReadOnly Property FilaActual() As DataRow
        Get
            If Me.totalFilas >= 0 Then
                Return laTabla.Rows(laFila)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property NumeroFilaActual() As Integer
        Get
            Return laFila
        End Get
    End Property

    Public ReadOnly Property NumeroUltimaFila() As Integer
        Get
            Return totalFilas
        End Get
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As DataRow
        Get
            If index < 0 Then
                index = 0
            End If
            If index > totalFilas Then
                index = totalFilas
            End If
            Return laTabla.Rows(index)
        End Get
    End Property

    ' Métodos compartidos 
    Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        ' Cerrarlo y volverlo a abrir
        ' o posicionarlo en el primer byte
        'fs.Close()
        'fs = New FileStream(sTemp, FileMode.Open, FileAccess.Read)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

End Class

