Public Class LoginForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As DataSet
        user = ControlClassSQL.Login(UserIDTextBox.Text, PasswordMaskedTextBox.Text)
        Dim count As Integer = user.Tables(0).Rows.Count
        If count >= 1 Then
            ControlClassSQL.UserID = user.Tables(0).Rows(0).Item(0).ToString
            ControlClassSQL.UserRole = user.Tables(0).Rows(0).Item(1).ToString
            ' The password is correct, so show the main form and close the login form

            Dim mainform As frmApplicationForm
            mainform = New frmApplicationForm
            mainform.Show()
            Me.Hide()
        Else
            ' The password is incorrect, so leave this form on screen
            MsgBox("Invalid Password or UserID entered!", MsgBoxStyle.Exclamation)
        End If
    End Sub

End Class