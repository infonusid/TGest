Module ModMain
    Sub Main()
        Try
            'Dim sAppName As String = System.Reflection.Assembly.GetEntryAssembly.GetName.Name.ToUpper
            'If (Process.GetCurrentProcess.ProcessName.ToUpper.Equals(sAppName & ".VSHOST")) Then
            '    Dim assembly As Assembly = assembly.GetExecutingAssembly
            '    Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location)

            '    MyLibrary.My.DtRelease = DateTime.Now.ToString
            '    MyLibrary.My.ProductMajorPart = versionInfo.ProductMajorPart.ToString
            '    MyLibrary.My.ProductMinorPart = versionInfo.ProductMinorPart.ToString
            '    MyLibrary.My.ProductBuildPart = versionInfo.ProductBuildPart.ToString

            '    MyLibrary.My.SaveXml()
            'End If

            StartProgram()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Sub StartProgram()


        Application.EnableVisualStyles()
        Dim fEntry As New FrEntry
        Dim dr As DialogResult = DialogResult.OK

        While (fEntry.ShowDialog = DialogResult.OK)
            Dim fMain As New FrMain
            dr = fMain.ShowDialog
            If (dr = DialogResult.OK) Then
                fMain.Close()
            End If





        End While

        'Application.Run(New FrMain)

    End Sub
End Module
