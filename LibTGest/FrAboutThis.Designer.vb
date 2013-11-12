<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrAboutThis
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrAboutThis))
        Me.lbDescription = New System.Windows.Forms.Label()
        Me.btContinue = New System.Windows.Forms.Button()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbBuildDate = New System.Windows.Forms.Label()
        Me.lbV = New System.Windows.Forms.Label()
        Me.lbBD = New System.Windows.Forms.Label()
        Me.lbFastGest = New System.Windows.Forms.Label()
        Me.pctFrEntry = New System.Windows.Forms.PictureBox()
        CType(Me.pctFrEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbDescription
        '
        Me.lbDescription.AutoSize = True
        Me.lbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescription.Location = New System.Drawing.Point(213, 243)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(283, 13)
        Me.lbDescription.TabIndex = 29
        Me.lbDescription.Text = "Management software fast, simple and universal."
        '
        'btContinue
        '
        Me.btContinue.Location = New System.Drawing.Point(35, 243)
        Me.btContinue.Name = "btContinue"
        Me.btContinue.Size = New System.Drawing.Size(163, 31)
        Me.btContinue.TabIndex = 28
        Me.btContinue.Text = "Continue"
        Me.btContinue.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.Location = New System.Drawing.Point(139, 93)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(53, 13)
        Me.lbVersion.TabIndex = 27
        Me.lbVersion.Text = "Version:"
        '
        'lbBuildDate
        '
        Me.lbBuildDate.AutoSize = True
        Me.lbBuildDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBuildDate.Location = New System.Drawing.Point(139, 60)
        Me.lbBuildDate.Name = "lbBuildDate"
        Me.lbBuildDate.Size = New System.Drawing.Size(70, 13)
        Me.lbBuildDate.TabIndex = 26
        Me.lbBuildDate.Text = "Build Date:"
        '
        'lbV
        '
        Me.lbV.AutoSize = True
        Me.lbV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbV.Location = New System.Drawing.Point(38, 93)
        Me.lbV.Name = "lbV"
        Me.lbV.Size = New System.Drawing.Size(53, 13)
        Me.lbV.TabIndex = 25
        Me.lbV.Text = "Version:"
        '
        'lbBD
        '
        Me.lbBD.AutoSize = True
        Me.lbBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBD.Location = New System.Drawing.Point(38, 60)
        Me.lbBD.Name = "lbBD"
        Me.lbBD.Size = New System.Drawing.Size(70, 13)
        Me.lbBD.TabIndex = 24
        Me.lbBD.Text = "Build Date:"
        '
        'lbFastGest
        '
        Me.lbFastGest.AutoSize = True
        Me.lbFastGest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFastGest.Location = New System.Drawing.Point(38, 27)
        Me.lbFastGest.Name = "lbFastGest"
        Me.lbFastGest.Size = New System.Drawing.Size(57, 13)
        Me.lbFastGest.TabIndex = 23
        Me.lbFastGest.Text = "FastGest"
        '
        'pctFrEntry
        '
        Me.pctFrEntry.Image = CType(resources.GetObject("pctFrEntry.Image"), System.Drawing.Image)
        Me.pctFrEntry.Location = New System.Drawing.Point(35, 112)
        Me.pctFrEntry.Name = "pctFrEntry"
        Me.pctFrEntry.Size = New System.Drawing.Size(376, 125)
        Me.pctFrEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFrEntry.TabIndex = 30
        Me.pctFrEntry.TabStop = False
        '
        'FrAbouThis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 300)
        Me.Controls.Add(Me.pctFrEntry)
        Me.Controls.Add(Me.lbDescription)
        Me.Controls.Add(Me.btContinue)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.lbBuildDate)
        Me.Controls.Add(Me.lbV)
        Me.Controls.Add(Me.lbBD)
        Me.Controls.Add(Me.lbFastGest)
        Me.Name = "FrAbouThis"
        Me.Text = "FrAbouThis"
        CType(Me.pctFrEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pctFrEntry As System.Windows.Forms.PictureBox
    Private WithEvents lbDescription As System.Windows.Forms.Label
    Private WithEvents btContinue As System.Windows.Forms.Button
    Private WithEvents lbVersion As System.Windows.Forms.Label
    Private WithEvents lbBuildDate As System.Windows.Forms.Label
    Private WithEvents lbV As System.Windows.Forms.Label
    Private WithEvents lbBD As System.Windows.Forms.Label
    Private WithEvents lbFastGest As System.Windows.Forms.Label
End Class
