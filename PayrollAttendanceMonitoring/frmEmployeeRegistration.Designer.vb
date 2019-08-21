<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeRegistration
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeRegistration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New MetroFramework.Controls.MetroComboBox()
        Me.cmbEmpType = New MetroFramework.Controls.MetroComboBox()
        Me.cmbGender = New MetroFramework.Controls.MetroComboBox()
        Me.dtBday = New MetroFramework.Controls.MetroDateTime()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtPositionTypeNo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPHILHEALTH = New System.Windows.Forms.MaskedTextBox()
        Me.txtPAGIBIG = New System.Windows.Forms.MaskedTextBox()
        Me.txtSSS = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pbEmployeePhoto = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pbFingerPrint = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbEmployeePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFingerPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPosition)
        Me.GroupBox1.Controls.Add(Me.cmbEmpType)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.dtBday)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Controls.Add(Me.txtPositionTypeNo)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(493, 480)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'cmbPosition
        '
        Me.cmbPosition.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.ItemHeight = 19
        Me.cmbPosition.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPosition.Location = New System.Drawing.Point(157, 395)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(238, 25)
        Me.cmbPosition.TabIndex = 322
        Me.cmbPosition.UseSelectable = True
        '
        'cmbEmpType
        '
        Me.cmbEmpType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbEmpType.FormattingEnabled = True
        Me.cmbEmpType.ItemHeight = 19
        Me.cmbEmpType.Items.AddRange(New Object() {"Contractual", "Regular"})
        Me.cmbEmpType.Location = New System.Drawing.Point(157, 435)
        Me.cmbEmpType.Name = "cmbEmpType"
        Me.cmbEmpType.Size = New System.Drawing.Size(238, 25)
        Me.cmbEmpType.TabIndex = 321
        Me.cmbEmpType.UseSelectable = True
        '
        'cmbGender
        '
        Me.cmbGender.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 19
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(157, 191)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(238, 25)
        Me.cmbGender.TabIndex = 320
        Me.cmbGender.UseSelectable = True
        '
        'dtBday
        '
        Me.dtBday.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtBday.Location = New System.Drawing.Point(157, 231)
        Me.dtBday.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Size = New System.Drawing.Size(238, 25)
        Me.dtBday.TabIndex = 74
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(31, 203)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 317
        Me.Label18.Text = "Gender"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 447)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 15)
        Me.Label16.TabIndex = 315
        Me.Label16.Text = "Type of Employment"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 317)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(157, 312)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(238, 25)
        Me.txtCity.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 403)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 15)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 359)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cell Number:"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(157, 355)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(238, 25)
        Me.txtPhone.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(157, 271)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(238, 25)
        Me.txtAddress.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Birthdate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Middle Name"
        '
        'txtMname
        '
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(157, 151)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMname.MaxLength = 30
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(238, 25)
        Me.txtMname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name"
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(158, 110)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFname.MaxLength = 30
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(238, 25)
        Me.txtFname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(157, 71)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLname.MaxLength = 30
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(238, 25)
        Me.txtLname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.Color.White
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(158, 31)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(116, 25)
        Me.txtEmpID.TabIndex = 0
        '
        'txtPositionTypeNo
        '
        Me.txtPositionTypeNo.BackColor = System.Drawing.Color.White
        Me.txtPositionTypeNo.Location = New System.Drawing.Point(159, 395)
        Me.txtPositionTypeNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPositionTypeNo.Name = "txtPositionTypeNo"
        Me.txtPositionTypeNo.ReadOnly = True
        Me.txtPositionTypeNo.Size = New System.Drawing.Size(60, 20)
        Me.txtPositionTypeNo.TabIndex = 319
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPHILHEALTH)
        Me.GroupBox3.Controls.Add(Me.txtPAGIBIG)
        Me.GroupBox3.Controls.Add(Me.txtSSS)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(544, 413)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(371, 159)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mandatory Benifits"
        '
        'txtPHILHEALTH
        '
        Me.txtPHILHEALTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPHILHEALTH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHILHEALTH.Location = New System.Drawing.Point(128, 101)
        Me.txtPHILHEALTH.Mask = "0000-0000-0000"
        Me.txtPHILHEALTH.Name = "txtPHILHEALTH"
        Me.txtPHILHEALTH.Size = New System.Drawing.Size(214, 25)
        Me.txtPHILHEALTH.TabIndex = 2
        '
        'txtPAGIBIG
        '
        Me.txtPAGIBIG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPAGIBIG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAGIBIG.Location = New System.Drawing.Point(128, 66)
        Me.txtPAGIBIG.Mask = "0000-0000-0000"
        Me.txtPAGIBIG.Name = "txtPAGIBIG"
        Me.txtPAGIBIG.Size = New System.Drawing.Size(214, 25)
        Me.txtPAGIBIG.TabIndex = 1
        '
        'txtSSS
        '
        Me.txtSSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSSS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(128, 34)
        Me.txtSSS.Mask = "00-0000000-0"
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(214, 25)
        Me.txtSSS.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "PHILHEALTH"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 78)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "PAGIBIG"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 46)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 17)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "SSS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtContactNo)
        Me.GroupBox2.Controls.Add(Me.txtContactPerson)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 270)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(371, 120)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "In Case of Emergency"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(126, 75)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactNo.MaxLength = 30
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(216, 25)
        Me.txtContactNo.TabIndex = 79
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.Location = New System.Drawing.Point(126, 37)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactPerson.MaxLength = 30
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(216, 25)
        Me.txtContactPerson.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 47)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Contact Person"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Contact Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(582, 66)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "UPLOAD PHOTO"
        '
        'pbEmployeePhoto
        '
        Me.pbEmployeePhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEmployeePhoto.Image = Global.PayrollAttendanceMonitoring.My.Resources.Resources.no_image
        Me.pbEmployeePhoto.Location = New System.Drawing.Point(544, 83)
        Me.pbEmployeePhoto.Margin = New System.Windows.Forms.Padding(2)
        Me.pbEmployeePhoto.Name = "pbEmployeePhoto"
        Me.pbEmployeePhoto.Size = New System.Drawing.Size(169, 163)
        Me.pbEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmployeePhoto.TabIndex = 79
        Me.pbEmployeePhoto.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(775, 66)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "FINGERPRINT"
        '
        'pbFingerPrint
        '
        Me.pbFingerPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFingerPrint.Image = CType(resources.GetObject("pbFingerPrint.Image"), System.Drawing.Image)
        Me.pbFingerPrint.Location = New System.Drawing.Point(749, 93)
        Me.pbFingerPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.pbFingerPrint.Name = "pbFingerPrint"
        Me.pbFingerPrint.Size = New System.Drawing.Size(137, 136)
        Me.pbFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFingerPrint.TabIndex = 81
        Me.pbFingerPrint.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Image = CType(resources.GetObject("btnRegister.Image"), System.Drawing.Image)
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(778, 599)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(137, 35)
        Me.btnRegister.TabIndex = 83
        Me.btnRegister.Text = "   REGISTER"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(661, 599)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 35)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEmployeeRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 654)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.pbFingerPrint)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.pbEmployeePhoto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmEmployeeRegistration"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Employee Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbEmployeePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFingerPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents txtPositionTypeNo As System.Windows.Forms.TextBox
    Friend WithEvents dtBday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbEmpType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbPosition As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPHILHEALTH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPAGIBIG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSSS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pbEmployeePhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pbFingerPrint As System.Windows.Forms.PictureBox
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class
