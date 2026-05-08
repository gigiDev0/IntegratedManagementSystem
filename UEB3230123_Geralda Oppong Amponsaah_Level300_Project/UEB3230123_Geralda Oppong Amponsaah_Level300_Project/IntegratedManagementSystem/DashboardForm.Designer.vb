<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        btnHospital = New Button()
        btnLoan = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(265, 44)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(227, 55)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Dashboard"
        ' 
        ' btnHospital
        ' 
        btnHospital.Location = New Point(162, 131)
        btnHospital.Name = "btnHospital"
        btnHospital.Size = New Size(411, 64)
        btnHospital.TabIndex = 1
        btnHospital.Text = "Hospital Billing"
        btnHospital.UseVisualStyleBackColor = True
        ' 
        ' btnLoan
        ' 
        btnLoan.Location = New Point(162, 238)
        btnLoan.Name = "btnLoan"
        btnLoan.Size = New Size(411, 64)
        btnLoan.TabIndex = 2
        btnLoan.Text = "Student Loan"
        btnLoan.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(162, 334)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(411, 60)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1599, 616)
        Controls.Add(btnLogout)
        Controls.Add(btnLoan)
        Controls.Add(btnHospital)
        Controls.Add(lblTitle)
        Name = "DashboardForm"
        Text = "DashboardForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHospital As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnLogout As Button
End Class
