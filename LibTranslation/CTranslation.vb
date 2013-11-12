Public Class CTranslation
    Public Function FFormTextTranslate(sFormText As String) As String
        Dim sReturns As String = ""
        Dim sCadsqltrad As String = LibSqlServer.CSqlServer.Consulta_SQL_Texto2("execute dbo.formtraduction '" & sFormText & "'")   ' FrEntry'
        If (sCadsqltrad.CompareTo("") = 0) Then    'Si devuelve null o cadena vacia
            sReturns = sFormText + " Untranslated"
            If ((LibSqlServer.CSqlServer.Consulta_SQL_Texto2("execute dbo.FormRowExists 'controlname', 'Form', '" & sFormText & "'")) = "") Then 'Sino existe el control en la tabla crealo
                Dim bResult As Boolean = LibSqlServer.CSqlServer.Escribir_SQL_Exec("execute formInsert '" & sFormText & "'")
            End If
        Else
            sReturns = sCadsqltrad
        End If
        Return sReturns
    End Function

    Public Function FFormLineTextTranslate(sFormText As String, sFormLineText As String) As String
        Dim sReturns As String = ""
        Dim sCadSqlTrad As String = LibSqlServer.CSqlServer.Consulta_SQL_Texto2("execute formlinetraduction('" & sFormText & "', '" & sFormLineText & "')")
        If sCadSqlTrad.CompareTo("") = 0 Then
            sReturns = sFormLineText & "Untranslated"
            If ((LibSqlServer.CSqlServer.Consulta_SQL_Texto2("execute formLineRowExists('controlname','formline', '" & sFormLineText & "', '" & sFormText & "')")) = "") Then
                Dim bResult As Boolean = LibSqlServer.CSqlServer.Escribir_SQL_Exec("execute formLineInsert '" & sFormText & "', '" & sFormLineText & "')")
            End If
        Else
            sReturns = sCadSqlTrad
        End If
        Return sReturns
    End Function
End Class
