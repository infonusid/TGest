'Imports HtmlHelp
'Imports HtmlHelpViewer
'Imports hhv = HtmlHelpViewer

Public Class FrSecond
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FrSecond_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbc.Region = New Region(New RectangleF(tbpDetail.Left, tbpDetail.Top, tbpDetail.Top, tbpDetail.Height))
    End Sub

    Public Sub tsButtonList_Click(sender As Object, e As EventArgs)
        'Inheritance level
    End Sub

    Private Sub bnGlobalView_Click(sender As System.Object, e As System.EventArgs) Handles bnGlobalView.Click
        'Be carefull must be enabled bnGlobalView.CheckOnClick=true
        If (bnGlobalView.Checked) Then
            tbc.SelectedTab = tbpList
        Else
            tbc.SelectedTab = tbpDetail
        End If
        msVGlobalView.Checked = bnGlobalView.Checked
    End Sub

    Private Sub msVGlobalView_Click(sender As System.Object, e As System.EventArgs) Handles msVGlobalView.Click
        'Be carefull must be enabled bnGlobalView.CheckOnClick=true
        If (msVGlobalView.Checked) Then
            tbc.SelectedTab = tbpList
        Else
            tbc.SelectedTab = tbpDetail
        End If
        bnGlobalView.Checked = msVGlobalView.Checked
    End Sub

    Private Sub bnLoad_Click(sender As System.Object, e As System.EventArgs) Handles bnLoad.Click
        'Metode sobreescrit a la clase filla.
        'EnableBn(true)
    End Sub

    Private Sub msFExit_Click(sender As System.Object, e As System.EventArgs) Handles msFExit.Click
        Me.Close()
    End Sub

    Private Sub msFPrintersetup_Click(sender As System.Object, e As System.EventArgs) Handles msFPrintersetup.Click
        e = Nothing
    End Sub

    Private Sub bnSave_Click(sender As System.Object, e As System.EventArgs) Handles bnSave.Click
        '    //this.customerTableAdapter.Update(gestdbDS);
        '//this.bnAddNewItem.Checked = false;
        '//enableBn(true);
    End Sub

    Private Sub bnMoveFirstItem_Click(sender As System.Object, e As System.EventArgs) Handles bnMoveFirstItem.Click
        bs.CancelEdit()
    End Sub

    Private Sub msRFirst_Click(sender As System.Object, e As System.EventArgs) Handles msRFirst.Click
        'bs.MoveFirst
    End Sub

    Private Sub bnMovePreviousItem_Click(sender As System.Object, e As System.EventArgs) Handles bnMovePreviousItem.Click
        bs.CancelEdit()
    End Sub

    Private Sub bnMoveNextItem_Click(sender As System.Object, e As System.EventArgs) Handles bnMoveNextItem.Click
        bs.CancelEdit()
    End Sub

    Private Sub tbpDetail_Click(sender As System.Object, e As System.EventArgs) Handles tbpDetail.Click
        '
    End Sub

    Private Sub bnDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles bnDeleteItem.Click
        '
    End Sub

    Private Sub bnSearch_Click(sender As System.Object, e As System.EventArgs) Handles bnSearch.Click
        'Me.msRSearch_Click(Nothing, Nothing)
        '//enableBn(true);

    End Sub

    Private Sub dgvNPrin_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNPrin.CellDoubleClick
        tbc.SelectedTab = tbpDetail
        bnGlobalView.Checked = False
        msVGlobalView.Checked = bnGlobalView.Checked
    End Sub
    Private Sub OpenHelp(sender As Object, e As EventArgs, iSelectedTab As Integer)

        'Dim oV As New HtmlHelpViewer.Viewer
        'Dim sHelpFile As String
        'sHelpFile = Application.StartupPath & "\..\source_helpmaker\help_tmphhp\help.chm"
        'oV.Show()
        'oV.miOpen_Click(sender, e, sHelpFile)
        'oV.tabControl1.SelectTab(iSelectedTab)

    End Sub

    Private Sub msHSearch_Click(sender As System.Object, e As System.EventArgs) Handles msHSearch.Click
        'OpenHelp(sender, e, 2)
    End Sub

    Private Sub msHIndex_Click(sender As System.Object, e As System.EventArgs) Handles msHIndex.Click
        'OpenHelp(sender, e, 1)
    End Sub

    Private Sub msHContents_Click(sender As System.Object, e As System.EventArgs) Handles msHContents.Click
        'OpenHelp(sender, e, 0)
    End Sub

    Private Sub msHAboutThis_Click(sender As System.Object, e As System.EventArgs) Handles msHAboutThis.Click
        Dim oFrAboutThis As New FrAboutThis
        oFrAboutThis.Show()

    End Sub
End Class