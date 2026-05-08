Public Class LoginForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Check if the entered credentials match the hardcoded admin credentials
        If txtUsername.Text = "admin" And txtPassword.Text = "level300" Then
            ' Credentials are correct - open the Dashboard
            Dim dashboard As New DashboardForm()
            dashboard.Show()
            Me.Hide()
        Else
            ' Credentials are wrong - show error message
            MessageBox.Show("Invalid Login Credentials")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
