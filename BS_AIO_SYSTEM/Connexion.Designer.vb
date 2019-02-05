<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BT_OK = New System.Windows.Forms.Button()
        Me.BT_CANCEL = New System.Windows.Forms.Button()
        Me.USER_BOX = New System.Windows.Forms.TextBox()
        Me.PASSWORD_BOX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_OK
        '
        Me.BT_OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BT_OK.Location = New System.Drawing.Point(237, 113)
        Me.BT_OK.Name = "BT_OK"
        Me.BT_OK.Size = New System.Drawing.Size(75, 23)
        Me.BT_OK.TabIndex = 2
        Me.BT_OK.Text = "Lancer"
        Me.BT_OK.UseVisualStyleBackColor = True
        '
        'BT_CANCEL
        '
        Me.BT_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_CANCEL.Location = New System.Drawing.Point(156, 113)
        Me.BT_CANCEL.Name = "BT_CANCEL"
        Me.BT_CANCEL.Size = New System.Drawing.Size(75, 23)
        Me.BT_CANCEL.TabIndex = 3
        Me.BT_CANCEL.Text = "Annuler"
        Me.BT_CANCEL.UseVisualStyleBackColor = True
        Me.BT_CANCEL.Visible = False
        '
        'USER_BOX
        '
        Me.USER_BOX.Location = New System.Drawing.Point(130, 25)
        Me.USER_BOX.Name = "USER_BOX"
        Me.USER_BOX.Size = New System.Drawing.Size(145, 20)
        Me.USER_BOX.TabIndex = 0
        '
        'PASSWORD_BOX
        '
        Me.PASSWORD_BOX.Location = New System.Drawing.Point(130, 62)
        Me.PASSWORD_BOX.Name = "PASSWORD_BOX"
        Me.PASSWORD_BOX.Size = New System.Drawing.Size(145, 20)
        Me.PASSWORD_BOX.TabIndex = 1
        Me.PASSWORD_BOX.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "USER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "PASSWORD"
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PASSWORD_BOX)
        Me.Controls.Add(Me.USER_BOX)
        Me.Controls.Add(Me.BT_CANCEL)
        Me.Controls.Add(Me.BT_OK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Connexion"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_OK As Button
    Friend WithEvents BT_CANCEL As Button
    Friend WithEvents USER_BOX As TextBox
    Friend WithEvents PASSWORD_BOX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
