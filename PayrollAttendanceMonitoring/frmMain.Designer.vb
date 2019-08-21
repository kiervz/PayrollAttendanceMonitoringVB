<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnEmployeeManagement = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnMonitoring = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.txtUserType = New System.Windows.Forms.TextBox()
        Me.UcUserManagement1 = New PayrollAttendanceMonitoring.ucUserManagement()
        Me.UcEmployeePayroll1 = New PayrollAttendanceMonitoring.ucEmployeePayroll()
        Me.UcDashboard1 = New PayrollAttendanceMonitoring.ucDashboard()
        Me.UcEmployeeInfo1 = New PayrollAttendanceMonitoring.ucEmployeeManagement()
        Me.UcDailyAttendance1 = New PayrollAttendanceMonitoring.ucDailyAttendance()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 30)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtUserType)
        Me.Panel2.Controls.Add(Me.btnSettings)
        Me.Panel2.Controls.Add(Me.btnUserManagement)
        Me.Panel2.Controls.Add(Me.btnEmployeeManagement)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.btnPayroll)
        Me.Panel2.Controls.Add(Me.btnMonitoring)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 601)
        Me.Panel2.TabIndex = 1
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 469)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(239, 42)
        Me.btnSettings.TabIndex = 31
        Me.btnSettings.Text = "   Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.White
        Me.btnUserManagement.Image = CType(resources.GetObject("btnUserManagement.Image"), System.Drawing.Image)
        Me.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.Location = New System.Drawing.Point(0, 385)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(239, 42)
        Me.btnUserManagement.TabIndex = 30
        Me.btnUserManagement.Text = "   User Management"
        Me.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnEmployeeManagement
        '
        Me.btnEmployeeManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnEmployeeManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployeeManagement.FlatAppearance.BorderSize = 0
        Me.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeManagement.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeManagement.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeManagement.Image = CType(resources.GetObject("btnEmployeeManagement.Image"), System.Drawing.Image)
        Me.btnEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployeeManagement.Location = New System.Drawing.Point(0, 343)
        Me.btnEmployeeManagement.Name = "btnEmployeeManagement"
        Me.btnEmployeeManagement.Size = New System.Drawing.Size(239, 42)
        Me.btnEmployeeManagement.TabIndex = 29
        Me.btnEmployeeManagement.Text = "   Employee Management"
        Me.btnEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployeeManagement.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 427)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(239, 42)
        Me.btnReports.TabIndex = 28
        Me.btnReports.Text = "   Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayroll.FlatAppearance.BorderSize = 0
        Me.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayroll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.ForeColor = System.Drawing.Color.White
        Me.btnPayroll.Image = CType(resources.GetObject("btnPayroll.Image"), System.Drawing.Image)
        Me.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayroll.Location = New System.Drawing.Point(0, 301)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(239, 42)
        Me.btnPayroll.TabIndex = 27
        Me.btnPayroll.Text = "   Payroll"
        Me.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'btnMonitoring
        '
        Me.btnMonitoring.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonitoring.ForeColor = System.Drawing.Color.White
        Me.btnMonitoring.Image = CType(resources.GetObject("btnMonitoring.Image"), System.Drawing.Image)
        Me.btnMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.Location = New System.Drawing.Point(0, 259)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(239, 42)
        Me.btnMonitoring.TabIndex = 26
        Me.btnMonitoring.Text = "   Monitoring"
        Me.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMonitoring.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 217)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(239, 42)
        Me.btnDashboard.TabIndex = 25
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1086, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1057, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 23)
        Me.btnMinimize.TabIndex = 10
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'txtUserType
        '
        Me.txtUserType.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtUserType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserType.ForeColor = System.Drawing.Color.White
        Me.txtUserType.Location = New System.Drawing.Point(48, 129)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.ReadOnly = True
        Me.txtUserType.Size = New System.Drawing.Size(132, 20)
        Me.txtUserType.TabIndex = 7
        Me.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UcUserManagement1
        '
        Me.UcUserManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUserManagement1.Location = New System.Drawing.Point(239, 30)
        Me.UcUserManagement1.Name = "UcUserManagement1"
        Me.UcUserManagement1.Size = New System.Drawing.Size(873, 601)
        Me.UcUserManagement1.TabIndex = 6
        '
        'UcEmployeePayroll1
        '
        Me.UcEmployeePayroll1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcEmployeePayroll1.Location = New System.Drawing.Point(239, 30)
        Me.UcEmployeePayroll1.Name = "UcEmployeePayroll1"
        Me.UcEmployeePayroll1.Size = New System.Drawing.Size(873, 601)
        Me.UcEmployeePayroll1.TabIndex = 5
        '
        'UcDashboard1
        '
        Me.UcDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDashboard1.Location = New System.Drawing.Point(239, 30)
        Me.UcDashboard1.Name = "UcDashboard1"
        Me.UcDashboard1.Size = New System.Drawing.Size(873, 601)
        Me.UcDashboard1.TabIndex = 4
        '
        'UcEmployeeInfo1
        '
        Me.UcEmployeeInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcEmployeeInfo1.Location = New System.Drawing.Point(239, 30)
        Me.UcEmployeeInfo1.Name = "UcEmployeeInfo1"
        Me.UcEmployeeInfo1.Size = New System.Drawing.Size(873, 601)
        Me.UcEmployeeInfo1.TabIndex = 3
        '
        'UcDailyAttendance1
        '
        Me.UcDailyAttendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDailyAttendance1.Location = New System.Drawing.Point(239, 30)
        Me.UcDailyAttendance1.Name = "UcDailyAttendance1"
        Me.UcDailyAttendance1.Size = New System.Drawing.Size(873, 601)
        Me.UcDailyAttendance1.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 631)
        Me.Controls.Add(Me.UcUserManagement1)
        Me.Controls.Add(Me.UcEmployeePayroll1)
        Me.Controls.Add(Me.UcDashboard1)
        Me.Controls.Add(Me.UcEmployeeInfo1)
        Me.Controls.Add(Me.UcDailyAttendance1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnUserManagement As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeManagement As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnPayroll As System.Windows.Forms.Button
    Friend WithEvents btnMonitoring As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents UcDailyAttendance1 As PayrollAttendanceMonitoring.ucDailyAttendance
    Friend WithEvents UcEmployeeInfo1 As PayrollAttendanceMonitoring.ucEmployeeManagement
    Friend WithEvents UcDashboard1 As PayrollAttendanceMonitoring.ucDashboard
    Friend WithEvents UcEmployeePayroll1 As PayrollAttendanceMonitoring.ucEmployeePayroll
    Friend WithEvents UcUserManagement1 As PayrollAttendanceMonitoring.ucUserManagement
    Friend WithEvents txtUserType As System.Windows.Forms.TextBox
End Class
