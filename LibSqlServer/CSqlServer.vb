Imports System.Windows.Forms
Imports System.Drawing

Public Class CSqlServer
    Public Shared cn As New SqlClient.SqlConnection(MyLibrary.My.TGestGenCS.ToString)
    Public Shared Function Escribir(ByVal Consulta As String, ByVal Conexion As String) As Boolean
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            ' My.MySettings.Default.CONECTADO = My.Computer.Network.Ping( My.MySettings.Default.LOCAL1)
            ' My.MySettings.Default.Save()
            'Application.DoEvents()
            'If  My.MySettings.Default.CONECTADO = False Then Return False : Exit Function
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            Return True
        Catch ex As Exception
            ' MOD TEO 16/06/2012'
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Escribir", , , Consulta)
            ' END MOD TEO 16/06/2012'
            MessageBox.Show(ex.Message)

            Return False
        End Try
    End Function

    Public Shared Function Consultar(ByVal Consulta As String, ByVal Conexion As String) As DataTable
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            Return dt2
        Catch ex As Exception
            ' MOD TEO 16/06/2012'
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Consultar", , , Consulta)
            ' END MOD TEO 16/06/2012'
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Consulta_SQL(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]") As TablaNavegar
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString

            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            Return dtNavegador2
        Catch ex As Exception
            ' MOD TEO 16/06/2012'

            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Consulta_SQL", , , Consulta)
            MessageBox.Show(ex.Message)
            ' END MOD TEO 16/06/2012'
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Consulta_SQL_Texto2(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]") As String
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                dr2 = dtNavegador2.Primera
                dr2 = dtNavegador2.FilaActual
                If dr2(0) Is DBNull.Value Then
                    Return ""
                Else
                    Return CStr(dr2(0))
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            'mod teo 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Consulta_SQL_Texto2", , , Consulta)
            'end mod teo 
            MessageBox.Show(ex.Message)
            Return ""
        End Try
    End Function

    Public Shared Function Consulta_SQL_Texto(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]") As String
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString 'My.Settings.L_CONEXION
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            If dt2.Rows.Count > 0 Then
                dr2 = dtNavegador2.Primera
                dr2 = dtNavegador2.FilaActual
                If dr2(0) Is DBNull.Value Then
                    Return ""
                Else
                    Return CStr(dr2(0))
                End If

            Else
                Return ""
            End If
        Catch ex As Exception
            'mod teo 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Consulta_SQL_Texto", , , Consulta)
            'end mod teo 
            MessageBox.Show(ex.Message)
            Return CStr(False)
        End Try
    End Function

    Public Shared Function Consulta_SQL_Data(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]", Optional ByVal Devolver_Estructura As Boolean = False) As DataTable
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString 'My.Settings.L_CONEXION
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            If Devolver_Estructura Then
                Return dt2
            Else
                If dt2 IsNot Nothing Then
                    If dt2.Rows.Count > 0 Then
                        Return dt2
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            End If

        Catch ex As Exception
            ' mod teo 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Consulta_SQL_Data", , , Consulta)
            ' end mod teo
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Escribir_SQL(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]") As Boolean
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString 'My.Settings.L_CONEXION
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            Return True
        Catch ex As Exception
            'mod teo 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Escribir_SQL", , , Consulta)
            'end mod teo
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Escribir_SQL_Exec(ByVal Consulta As String, Optional ByVal Conexion As String = "[Auto]") As Boolean
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString 'My.Settings.L_CONEXION
            da2 = Nothing
            dtNavegador2 = Nothing
            dr2 = Nothing
            dt2 = Nothing
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            'dr2 = dtNavegador2.Primera
            'dr2 = dtNavegador2.FilaActual
            'If dr2("Result") = 0 Then Return False Else Return True
            Return True
        Catch ex As Exception
            'mod teo 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Escribir_SQL_Exec", , , Consulta)
            'end mod teo
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Escribir_FOTO(ByVal Consulta As String, ByVal Img As Image, ByVal Nom_Img As String, Optional ByVal Conexion As String = "[Auto]") As Boolean
        Dim dt2 As DataTable
        Dim da2 As SqlDataAdapter
        Dim dtNavegador2 As TablaNavegar
        Dim dr2 As DataRow
        Dim Imagen_B As Image = Nothing
        Dim spathOrigen As String = ""
        Dim saveFdlg As New SaveFileDialog
        Dim filtro As Imaging.ImageFormat = Nothing
        If IsNothing(Conexion) Then
            Conexion = MyLibrary.My.TGestGenCS.ToString
        End If
        Try
            Conexion = MyLibrary.My.TGestGenCS.ToString 'My.Settings.L_CONEXION
            dt2 = New DataTable
            da2 = New SqlDataAdapter(Consulta, Conexion)
            dtNavegador2 = New TablaNavegar(dt2)
            da2.Fill(dt2)
            dr2 = dtNavegador2.FilaActual
            If dr2 Is Nothing Then
                Return False
                Exit Function
            End If
            dr2(Nom_Img) = TablaNavegar.Image2Bytes(Img)
            Dim cb2 As New SqlCommandBuilder(da2)
            da2.UpdateCommand = cb2.GetUpdateCommand(True)
            da2.InsertCommand = cb2.GetInsertCommand(True)
            da2.DeleteCommand = cb2.GetDeleteCommand(True)
            da2.Update(dt2)
            dt2.AcceptChanges()
            Return True
        Catch ex As Exception
            'mod teo
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "Escribir_Foto", , , Consulta)
            'end mod teo
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function CrearDataSet(ByVal Columnas() As String, ByVal Tipos() As Type, ByVal Valores() As Object) As DataTable
        CrearDataSet = Nothing
        Dim dataSetArbol As DataSet
        Dim tablaArbol As DataTable = Nothing
        Dim i As Integer
        dataSetArbol = New DataSet("DataSetArbol")

        Try
            tablaArbol = dataSetArbol.Tables.Add("TablaArbol")
            For i = 0 To UBound(Columnas)
                tablaArbol.Columns.Add(Columnas(i), Tipos(i))
            Next
            ' InsertarDataRow(dataSetArbol, Columnas, Valores)
            CrearDataSet = dataSetArbol.Tables("tablaArbol")   ' tablaArbol
        Catch ex As Exception
            'mod teo
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "CrearDataSet")
            'end mod teo
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function InsertarDataRow(ByVal dataSetArbol As DataTable, ByVal Columna() As String, ByVal Valor() As Object) As DataTable
        InsertarDataRow = Nothing
        Dim i As Integer
        Dim nuevaFila As DataRow
        Try
            nuevaFila = dataSetArbol.NewRow()
            For i = 0 To UBound(Columna)
                nuevaFila(Columna(i)) = Valor(i)
            Next
            dataSetArbol.Rows.Add(nuevaFila)
            dataSetArbol.Select()
            Return dataSetArbol
        Catch ex As Exception
            'MOD TEO 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, "Class_SQL", "InsertarDataRow")
            'END MOD TEO
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Escribir_Replica(ByVal Cadena As String) As Boolean
        Try

            Return False
        Catch ex As Exception
            If My.Computer.Name = "t-PC" Then MessageBox.Show(ex.Message)
            'MOD TEO 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, " Class_SQL", "Escribir_Replica")
            'END MOD TEO
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Comparar_Registros(ByVal dt As DataTable, ByVal Campos() As String) As Boolean
        Try
            If dt IsNot Nothing Then
                If Not dt.Rows.Count <= 1 Then
                    For i = 1 To dt.Rows.Count - 1
                        For j = 0 To Campos.Length - 1
                            If Not (dt.Rows(i)(Campos(j)) Is dt.Rows(0)(Campos(j))) Then
                                Return False
                            End If
                        Next
                    Next
                End If
            End If
            Return True
        Catch ex As Exception
            If My.Computer.Name = "t-pc" Then MessageBox.Show(ex.Message)
            'MOD TEO 16/06/2012
            'Dim XErr As New Class_Err
            'XErr.Registrar_XML_Error("", ex, " Class_SQL", "Comparar_Registros")
            'END MOD TEO
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


End Class
