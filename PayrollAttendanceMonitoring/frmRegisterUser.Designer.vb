<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterUser
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.cmbPosition = New MetroFramework.Controls.MetroComboBox()
        Me.cmbGender = New MetroFramework.Controls.MetroComboBox()
        Me.dtBday = New MetroFramework.Controls.MetroDateTime()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Firstname"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(159, 197)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstname.MaxLength = 30
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(238, 25)
        Me.txtFirstname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "User ID"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.Color.White
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(159, 104)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(116, 25)
        Me.txtEmpID.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Middlename"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(159, 241)
        Me.txtMiddlename.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddlename.MaxLength = 30
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(238, 25)
        Me.txtMiddlename.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 299)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lastname"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(159, 287)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(238, 25)
        Me.txtLastname.TabIndex = 10
        '
        'cmbPosition
        '
        Me.cmbPosition.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.ItemHeight = 19
        Me.cmbPosition.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cmbPosition.Location = New System.Drawing.Point(159, 155)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(238, 25)
        Me.cmbPosition.TabIndex = 328
        Me.cmbPosition.UseSelectable = True
        '
        'cmbGender
        '
        Me.cmbGender.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 19
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(159, 330)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(238, 25)
        Me.cmbGender.TabIndex = 327
        Me.cmbGender.UseSelectable = True
        '
        'dtBday
        '
        Me.dtBday.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtBday.Location = New System.Drawing.Point(159, 373)
        Me.dtBday.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Size = New System.Drawing.Size(238, 25)
        Me.dtBday.TabIndex = 325
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 340)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 326
        Me.Label18.Text = "Gender"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 163)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 324
        Me.Label15.Text = "User Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 383)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 323
        Me.Label5.Text = "Birthdate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 426)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 330
        Me.Label6.Text = "Contact Number"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(159, 416)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactNo.MaxLength = 30
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(238, 25)
        Me.txtContactNo.TabIndex = 329
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(468, 318)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 332
        Me.Label7.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(596, 308)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(238, 25)
        Me.txtUsername.TabIndex = 331
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(468, 383)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 334
        Me.Label8.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(596, 373)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(238, 25)
        Me.txtPassword.TabIndex = 333
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(468, 426)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 336
        Me.Label9.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(596, 416)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmPassword.MaxLength = 30
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(238, 25)
        Me.txtConfirmPassword.TabIndex = 335
        '
        'pbProfile
        '
        Me.pbProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProfile.Image = Global.PayrollAttendanceMonitoring.My.Resources.Resources.no_image
        Me.pbProfile.Location = New System.Drawing.Point(629, 84)
        Me.pbProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(162, 140)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 337
        Me.pbProfile.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(629, 226)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(162, 33)
        Me.btnBrowse.TabIndex = 338
        Me.btnBrowse.Text = "BROWSE IMAGE"
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
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
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(702, 474)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(132, 33)
        Me.btnRegister.TabIndex = 340
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(568, 474)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 33)
        Me.btnCancel.TabIndex = 339
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.dtBday)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmRegisterUser"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "User Registration"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents cmbPosition As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtBday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
