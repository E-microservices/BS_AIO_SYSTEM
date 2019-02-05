Public Class Connexion
    Private Sub USER_BOX_TextChanged(sender As Object, e As EventArgs) Handles USER_BOX.TextChanged
        If USER_BOX.Text = "" Then
            USER_BOX.BackColor = Color.Red
            BT_OK.Enabled = False
            KeyPreview = False
        Else
            USER_BOX.BackColor = Color.White
            If USER_BOX.Text = "" Or PASSWORD_BOX.Text = "" Then
                BT_OK.Enabled = False
                KeyPreview = False
            Else
                BT_OK.Enabled = True
                KeyPreview = True
            End If
        End If
    End Sub

    Private Sub PASSWORD_BOX_TextChanged(sender As Object, e As EventArgs) Handles PASSWORD_BOX.TextChanged
        If PASSWORD_BOX.Text = "" Then
            PASSWORD_BOX.BackColor = Color.Red
            BT_OK.Enabled = False
            KeyPreview = False
        Else
            PASSWORD_BOX.BackColor = Color.White
            If USER_BOX.Text = "" Or PASSWORD_BOX.Text = "" Then
                BT_OK.Enabled = False
                KeyPreview = False
            Else
                BT_OK.Enabled = True
                KeyPreview = True
            End If
        End If
    End Sub
    Private Sub KEY_EVENT(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Case Else

        End Select
    End Sub
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_OK.Enabled = False
        KeyPreview = False
    End Sub
End Class