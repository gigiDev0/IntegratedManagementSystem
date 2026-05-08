<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblResult = New Label()
        txtStudentName = New TextBox()
        txtGPA = New TextBox()
        txtIncome = New TextBox()
        txtLoanAmount = New TextBox()
        btnCheckEligibility = New Button()
        btnRepayment = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlDarkDark
        lblTitle.Location = New Point(336, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(254, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Student Loan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 30)
        Label1.TabIndex = 1
        Label1.Text = "Student Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 30)
        Label2.TabIndex = 2
        Label2.Text = "GPA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 30)
        Label3.TabIndex = 3
        Label3.Text = "Family Annual Income"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(258, 30)
        Label4.TabIndex = 4
        Label4.Text = "Loan Amount Requested"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(482, 847)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 30)
        lblResult.TabIndex = 5
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(69, 161)
        txtStudentName.Margin = New Padding(3, 5, 3, 5)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(427, 38)
        txtStudentName.TabIndex = 6
        ' 
        ' txtGPA
        ' 
        txtGPA.Location = New Point(69, 267)
        txtGPA.Margin = New Padding(3, 5, 3, 5)
        txtGPA.Name = "txtGPA"
        txtGPA.Size = New Size(427, 38)
        txtGPA.TabIndex = 7
        ' 
        ' txtIncome
        ' 
        txtIncome.Location = New Point(69, 379)
        txtIncome.Margin = New Padding(3, 5, 3, 5)
        txtIncome.Name = "txtIncome"
        txtIncome.Size = New Size(427, 38)
        txtIncome.TabIndex = 8
        ' 
        ' txtLoanAmount
        ' 
        txtLoanAmount.Location = New Point(69, 498)
        txtLoanAmount.Margin = New Padding(3, 5, 3, 5)
        txtLoanAmount.Name = "txtLoanAmount"
        txtLoanAmount.Size = New Size(427, 38)
        txtLoanAmount.TabIndex = 9
        ' 
        ' btnCheckEligibility
        ' 
        btnCheckEligibility.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCheckEligibility.ForeColor = SystemColors.ButtonFace
        btnCheckEligibility.Location = New Point(128, 625)
        btnCheckEligibility.Margin = New Padding(3, 5, 3, 5)
        btnCheckEligibility.Name = "btnCheckEligibility"
        btnCheckEligibility.Size = New Size(165, 93)
        btnCheckEligibility.TabIndex = 10
        btnCheckEligibility.Text = "Check Eligibility"
        btnCheckEligibility.UseVisualStyleBackColor = False
        ' 
        ' btnRepayment
        ' 
        btnRepayment.BackColor = Color.Green
        btnRepayment.Enabled = False
        btnRepayment.ForeColor = SystemColors.ButtonFace
        btnRepayment.Location = New Point(350, 625)
        btnRepayment.Margin = New Padding(3, 5, 3, 5)
        btnRepayment.Name = "btnRepayment"
        btnRepayment.Size = New Size(146, 93)
        btnRepayment.TabIndex = 11
        btnRepayment.Text = "Calculate Repayment"
        btnRepayment.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ActiveCaptionText
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(555, 625)
        btnBack.Margin = New Padding(3, 5, 3, 5)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(146, 93)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' LoanForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1566, 910)
        Controls.Add(btnBack)
        Controls.Add(btnRepayment)
        Controls.Add(btnCheckEligibility)
        Controls.Add(txtLoanAmount)
        Controls.Add(txtIncome)
        Controls.Add(txtGPA)
        Controls.Add(txtStudentName)
        Controls.Add(lblResult)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "LoanForm"
        Text = "LoanForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents btnCheckEligibility As Button
    Friend WithEvents btnRepayment As Button
    Friend WithEvents btnBack As Button
End Class
