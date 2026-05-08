Public Class LoanForm

    Private Sub btnCheckEligibility_Click(sender As Object, e As EventArgs) Handles btnCheckEligibility.Click

        ' Get student details
        Dim studentName As String = txtStudentName.Text
        Dim gpa As Double = CDbl(txtGPA.Text)
        Dim income As Double = CDbl(txtIncome.Text)

        ' Check eligibility criteria
        If gpa >= 2.5 And income < 40000 Then
            ' Student is eligible
            lblResult.Text = studentName & " is eligible for the loan!"
            btnRepayment.Enabled = True
        Else
            ' Student is not eligible
            lblResult.Text = "Loan Application Rejected"
            btnRepayment.Enabled = False
        End If

    End Sub

    Private Sub btnRepayment_Click(sender As Object, e As EventArgs) Handles btnRepayment.Click

        ' Get loan amount
        Dim P As Double = CDbl(txtLoanAmount.Text)

        ' Define loan terms
        Dim r As Double = 0.08 / 12  ' Monthly interest rate
        Dim n As Integer = 60        ' 5 years = 60 months

        ' Calculate monthly repayment using amortization formula
        Dim M As Double = P * r * (1 + r) ^ n / ((1 + r) ^ n - 1)

        ' Calculate total repayment
        Dim totalRepayment As Double = M * n

        ' Display results
        lblResult.Text = lblResult.Text & vbCrLf &
                         "Monthly Repayment: GHS " & Math.Round(M, 2) & vbCrLf &
                         "Total Repayment: GHS " & Math.Round(totalRepayment, 2)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to Dashboard
        Dim dashboard As New DashboardForm()
        dashboard.Show()
        Me.Hide()
    End Sub

End Class