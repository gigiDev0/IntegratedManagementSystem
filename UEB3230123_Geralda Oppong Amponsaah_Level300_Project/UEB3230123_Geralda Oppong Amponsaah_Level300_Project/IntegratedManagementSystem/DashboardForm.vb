Public Class DashboardForm

    Private Sub btnHospital_Click(sender As Object, e As EventArgs) Handles btnHospital.Click
        ' Open the Hospital Billing Form
        Dim hospital As New HospitalForm()
        hospital.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        ' Open the Student Loan Form
        Dim loan As New LoanForm()
        loan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Return to Login Form
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub

End Class