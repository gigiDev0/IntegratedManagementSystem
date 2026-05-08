<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalForm
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
        lblTitle = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        txtPatientName = New TextBox()
        cmbWardType = New ComboBox()
        txtDays = New TextBox()
        chkLab = New CheckBox()
        chkXray = New CheckBox()
        chkSurgery = New CheckBox()
        btnCalculate = New Button()
        btnBack = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = SystemColors.ActiveCaption
        lblTitle.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlDarkDark
        lblTitle.Location = New Point(331, 28)
        lblTitle.Margin = New Padding(4)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(265, 58)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Hospital Billing"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.HighlightText
        TextBox2.Location = New Point(74, 119)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(221, 38)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Patient Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(75, 221)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 38)
        TextBox3.TabIndex = 2
        TextBox3.Text = "Ward Type"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(75, 325)
        TextBox4.Margin = New Padding(4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(194, 38)
        TextBox4.TabIndex = 3
        TextBox4.Text = "Number Of Days"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(74, 428)
        TextBox5.Margin = New Padding(4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(221, 38)
        TextBox5.TabIndex = 4
        TextBox5.Text = "Additional Services"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(75, 163)
        txtPatientName.Margin = New Padding(4)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(478, 38)
        txtPatientName.TabIndex = 5
        ' 
        ' cmbWardType
        ' 
        cmbWardType.FormattingEnabled = True
        cmbWardType.Items.AddRange(New Object() {"General Ward (200/day)", "Semi-Private (350/day)", "Private (500/day)"})
        cmbWardType.Location = New Point(75, 265)
        cmbWardType.Margin = New Padding(4)
        cmbWardType.Name = "cmbWardType"
        cmbWardType.Size = New Size(490, 38)
        cmbWardType.TabIndex = 6
        ' 
        ' txtDays
        ' 
        txtDays.Location = New Point(75, 370)
        txtDays.Margin = New Padding(4)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(490, 38)
        txtDays.TabIndex = 7
        ' 
        ' chkLab
        ' 
        chkLab.AutoSize = True
        chkLab.Location = New Point(75, 473)
        chkLab.Margin = New Padding(4)
        chkLab.Name = "chkLab"
        chkLab.Size = New Size(276, 34)
        chkLab.TabIndex = 8
        chkLab.Text = "Laboratory Tests (150)"
        chkLab.UseVisualStyleBackColor = True
        ' 
        ' chkXray
        ' 
        chkXray.AutoSize = True
        chkXray.Location = New Point(74, 515)
        chkXray.Margin = New Padding(4)
        chkXray.Name = "chkXray"
        chkXray.Size = New Size(159, 34)
        chkXray.TabIndex = 9
        chkXray.Text = "X-Ray (100)"
        chkXray.UseVisualStyleBackColor = True
        ' 
        ' chkSurgery
        ' 
        chkSurgery.AutoSize = True
        chkSurgery.Location = New Point(74, 557)
        chkSurgery.Margin = New Padding(4)
        chkSurgery.Name = "chkSurgery"
        chkSurgery.Size = New Size(192, 34)
        chkSurgery.TabIndex = 10
        chkSurgery.Text = "Surgery (1000)"
        chkSurgery.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.CadetBlue
        btnCalculate.ForeColor = SystemColors.ButtonFace
        btnCalculate.Location = New Point(295, 586)
        btnCalculate.Margin = New Padding(4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(164, 55)
        btnCalculate.TabIndex = 11
        btnCalculate.Text = "Calculate Bill"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ActiveCaptionText
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(518, 586)
        btnBack.Margin = New Padding(4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(164, 55)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(422, 667)
        lblResult.Margin = New Padding(4, 0, 4, 0)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 30)
        lblResult.TabIndex = 13
        ' 
        ' HospitalForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1554, 746)
        Controls.Add(lblResult)
        Controls.Add(btnBack)
        Controls.Add(btnCalculate)
        Controls.Add(chkSurgery)
        Controls.Add(chkXray)
        Controls.Add(chkLab)
        Controls.Add(txtDays)
        Controls.Add(cmbWardType)
        Controls.Add(txtPatientName)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(lblTitle)
        Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(4)
        Name = "HospitalForm"
        Text = "HospitalForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents cmbWardType As ComboBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents chkLab As CheckBox
    Friend WithEvents chkXray As CheckBox
    Friend WithEvents chkSurgery As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblResult As Label
End Class
