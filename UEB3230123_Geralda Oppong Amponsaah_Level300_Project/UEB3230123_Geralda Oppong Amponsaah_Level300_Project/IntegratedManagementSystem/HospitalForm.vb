Public Class HospitalForm

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Get patient name
        Dim patientName As String = txtPatientName.Text

        ' Get ward rate based on selection
        Dim wardRate As Decimal = 0
        If cmbWardType.SelectedIndex = 0 Then
            wardRate = 200
        ElseIf cmbWardType.SelectedIndex = 1 Then
            wardRate = 350
        ElseIf cmbWardType.SelectedIndex = 2 Then
            wardRate = 500
        End If

        ' Get number of days
        Dim days As Integer = CInt(txtDays.Text)

        ' Calculate ward charges
        Dim wardCharges As Decimal = wardRate * days

        ' Calculate treatment charges
        Dim treatmentCharges As Decimal = 0
        If chkLab.Checked Then treatmentCharges += 150
        If chkXray.Checked Then treatmentCharges += 100
        If chkSurgery.Checked Then treatmentCharges += 1000

        ' Calculate subtotal, VAT and final bill
        Dim subtotal As Decimal = wardCharges + treatmentCharges
        Dim vat As Decimal = subtotal * 0.12
        Dim finalBill As Decimal = subtotal + vat

        ' Display results
        lblResult.Text = "Patient: " & patientName & vbCrLf &
                         "Ward Charges: GHS " & wardCharges & vbCrLf &
                         "Treatment Charges: GHS " & treatmentCharges & vbCrLf &
                         "Subtotal: GHS " & subtotal & vbCrLf &
                         "VAT (12%): GHS " & vat & vbCrLf &
                         "Final Bill: GHS " & finalBill

        ' Check if premium billing category
        If finalBill > 5000 Then
            MessageBox.Show("Premium Billing Category")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to Dashboard
        Dim dashboard As New DashboardForm()
        dashboard.Show()
        Me.Hide()
    End Sub

End Class