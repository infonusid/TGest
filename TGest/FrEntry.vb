Public Class FrEntry
    Private inumberOfLoginAttempts As Integer
    Private oCt As CTranslation

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btOk_Click(sender As System.Object, e As System.EventArgs) Handles btOk.Click
        If inumberOfLoginAttempts < 3 Then
            If FVerificausuario(tbUser.Text, tbPassword.Text) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                LibSqlServer.CSqlServer.Escribir_SQL("Update company set runninguser = (select iduser from user where user like'" &
                                                     tbUser.Text & "')")
                Close()
            Else
                tbPassword.Text = ""
                tbUser.Text = ""
                tbUser.Focus()
            End If
        Else
            MessageBox.Show("Numero de intentos superado de 3 se cerrará el programa")
            Application.Exit()
        End If
        inumberOfLoginAttempts += 1
    End Sub

    Private Sub FrEntry_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If (Me.Width > 300) Then
            Width = 300
        End If
        If (Me.Height > 300) Then
            Height = 300
        End If
    End Sub

    Public Sub PTranslateControls(control As Control)
        'Dim contHijo As Control
        For Each contHijo As Control In control.Controls
            If (contHijo.HasChildren) Then
                Me.PTranslateControls(contHijo)
            End If

            If (((contHijo.GetType() Is GetType(Label)) Or _
                 (contHijo.GetType() Is GetType(GroupBox)) Or (contHijo.GetType() Is GetType(Button)) Or (contHijo.GetType() Is GetType(TabPage))) _
                And _
                (Not (contHijo.Name.CompareTo("lStatus") = 0)) _
            And _
                (Not (contHijo.Name.CompareTo("lFind") = 0))) Then
                contHijo.Text = Oct.FFormLineTextTranslate(Me.Name, contHijo.Name)
            End If

        Next
    End Sub

    Private Sub FrEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        oCt = New CTranslation()


        PTranslateControls(Me)

        inumberOfLoginAttempts = 0
        If CheckFirstBoot() Then
            If (MyLibrary.My.AutoStart.CompareTo("True") = 0) Then
                AutoFillFields(MyLibrary.My.AutoUser, MyLibrary.My.AutoPassword)
            End If
            Dim cadsql As String = "update company set firstrun=0"
            Try
                Dim bres = LibSqlServer.CSqlServer.Escribir_SQL(cadsql, Nothing)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            tbUser.Text = ""
            tbPassword.Text = ""
        End If
        Me.Text = oCt.FFormTextTranslate(Me.Name)

    End Sub
    Private Sub AutoFillFields(sUs As String, sPw As String)
        tbUser.Text = sUs.Trim
        tbPassword.Text = sPw.Trim
        btOk_Click(Me, EventArgs.Empty)
    End Sub
    Private Function CheckFirstBoot() As Boolean
        Dim bBo As Boolean = False
        Dim sCadSql As String
        Dim dt As DataTable
        sCadSql = "Select firstrun from company where firstrun=1"
        Try
            dt = LibSqlServer.CSqlServer.Consulta_SQL_Data(sCadSql, Nothing)
            If Not IsNothing(dt) Then
                bBo = True
            Else
                bBo = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return bBo
    End Function

    Private Function FVerificaUsuario(user As String, password As String) As Boolean
        Dim bReturns As Boolean = False
        Dim sCadSql As String
        Dim dt As New DataTable
        sCadSql = "Select * from [user] where " & _
            "[user] like '" & user & "' and password like '" & password & "'"
        dt = LibSqlServer.CSqlServer.Consulta_SQL_Data(sCadSql, Nothing)
        Try
            If Not IsNothing(dt) Then
                bReturns = True
            Else
                If (MyLibrary.My.AutoStart.CompareTo("True") = 0) And (inumberOfLoginAttempts = 0) Then
                    MessageBox.Show("Usuario i/o password incorrecto en el archivo de configuracion")
                Else
                    MessageBox.Show("Usuario i/o password incorrecto " & Chr(13) & _
                                    "Le quedan " & (3 - inumberOfLoginAttempts).ToString & " intentos mas")
                End If
                tbUser.Focus()
                bReturns = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not IsNothing(dt) Then
                dt.Clear()
                dt.Dispose()
            End If
        End Try
        Return bReturns
    End Function
End Class
