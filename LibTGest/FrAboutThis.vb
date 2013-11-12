Public Class FrAboutThis

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '//Multiline on label --> lbDescription.
        lbDescription.Text = "Management software fast, " & Environment.NewLine & "simple and universal."
        '//End Multiline on label --> lbDescription.


        Dim sVersion As String = String.Format("{0}.{1}.{2} del {3}",
                MyLibrary.My.ProductMajorPart,
                MyLibrary.My.ProductMinorPart,
                MyLibrary.My.ProductBuildPart,
                MyLibrary.My.DtRelease)

        lbVersion.Text = sVersion

        '    //lbBuildDate.Text = assemblyDate.ToShortDateString()
        lbBuildDate.Text = MyLibrary.My.DtRelease
    End Sub
    Private Sub btContinue_Click(sender As System.Object, e As System.EventArgs) Handles btContinue.Click
        Me.Close()
    End Sub
End Class