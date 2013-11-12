<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrEntry
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
        Me.pctFrEntry = New System.Windows.Forms.PictureBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btOk = New System.Windows.Forms.Button()
        CType(Me.pctFrEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctFrEntry
        '
        Me.pctFrEntry.Location = New System.Drawing.Point(35, 36)
        Me.pctFrEntry.Name = "pctFrEntry"
        Me.pctFrEntry.Size = New System.Drawing.Size(210, 58)
        Me.pctFrEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFrEntry.TabIndex = 20
        Me.pctFrEntry.TabStop = False
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(126, 160)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(119, 20)
        Me.tbPassword.TabIndex = 19
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(126, 128)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(119, 20)
        Me.tbUser.TabIndex = 18
        Me.tbUser.Text = "Administrador"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassword.Location = New System.Drawing.Point(32, 162)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(75, 18)
        Me.lbPassword.TabIndex = 17
        Me.lbPassword.Text = "Password"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.Location = New System.Drawing.Point(32, 127)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(40, 18)
        Me.lbUser.TabIndex = 16
        Me.lbUser.Text = "User"
        '
        'btCancel
        '
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(154, 194)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(63, 37)
        Me.btCancel.TabIndex = 15
        Me.btCancel.Text = "btCancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(67, 194)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(63, 37)
        Me.btOk.TabIndex = 14
        Me.btOk.Text = "btOk"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'FrEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pctFrEntry)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOk)
        Me.Name = "FrEntry"
        Me.Text = "Form1"
        CType(Me.pctFrEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pctFrEntry As System.Windows.Forms.PictureBox
    Private WithEvents tbPassword As System.Windows.Forms.TextBox
    Private WithEvents tbUser As System.Windows.Forms.TextBox
    Private WithEvents lbPassword As System.Windows.Forms.Label
    Private WithEvents lbUser As System.Windows.Forms.Label
    Private WithEvents btCancel As System.Windows.Forms.Button
    Private WithEvents btOk As System.Windows.Forms.Button

End Class
