<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEmployeePayroll
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvUserInfo = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbSearchType = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnCashAdvance = New System.Windows.Forms.Button()
        CType(Me.dgvUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUserInfo
        '
        Me.dgvUserInfo.AllowUserToAddRows = False
        Me.dgvUserInfo.AllowUserToDeleteRows = False
        Me.dgvUserInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUserInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUserInfo.ColumnHeadersHeight = 25
        Me.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserInfo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUserInfo.EnableHeadersVisualStyles = False
        Me.dgvUserInfo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUserInfo.Location = New System.Drawing.Point(3, 111)
        Me.dgvUserInfo.MultiSelect = False
        Me.dgvUserInfo.Name = "dgvUserInfo"
        Me.dgvUserInfo.ReadOnly = True
        Me.dgvUserInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUserInfo.RowHeadersWidth = 23
        Me.dgvUserInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserInfo.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvUserInfo.RowTemplate.Height = 25
        Me.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserInfo.ShowCellErrors = False
        Me.dgvUserInfo.ShowEditingIcon = False
        Me.dgvUserInfo.ShowRowErrors = False
        Me.dgvUserInfo.Size = New System.Drawing.Size(867, 395)
        Me.dgvUserInfo.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvUserInfo.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "Employee ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
        '
        'Column2
        '
        Me.Column2.HeaderText = "Employee Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Position"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Employment Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Hour Rate"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'cmbSearchType
        '
        Me.cmbSearchType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.ItemHeight = 19
        Me.cmbSearchType.Items.AddRange(New Object() {"Employee ID", "Name"})
        Me.cmbSearchType.Location = New System.Drawing.Point(498, 81)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(151, 25)
        Me.cmbSearchType.TabIndex = 325
        Me.cmbSearchType.UseSelectable = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(654, 81)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(216, 25)
        Me.txtSearch.TabIndex = 324
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayroll.FlatAppearance.BorderSize = 0
        Me.btnPayroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayroll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.ForeColor = System.Drawing.Color.White
        Me.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayroll.Location = New System.Drawing.Point(725, 523)
        Me.btnPayroll.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(113, 35)
        Me.btnPayroll.TabIndex = 326
        Me.btnPayroll.Text = "PAYROLL"
        Me.btnPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'btnCashAdvance
        '
        Me.btnCashAdvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnCashAdvance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashAdvance.FlatAppearance.BorderSize = 0
        Me.btnCashAdvance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnCashAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashAdvance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashAdvance.ForeColor = System.Drawing.Color.White
        Me.btnCashAdvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashAdvance.Location = New System.Drawing.Point(574, 523)
        Me.btnCashAdvance.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCashAdvance.Name = "btnCashAdvance"
        Me.btnCashAdvance.Size = New System.Drawing.Size(135, 35)
        Me.btnCashAdvance.TabIndex = 327
        Me.btnCashAdvance.Text = "CASH ADVANCE"
        Me.btnCashAdvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashAdvance.UseVisualStyleBackColor = False
        '
        'ucEmployeePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCashAdvance)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvUserInfo)
        Me.Name = "ucEmployeePayroll"
        Me.Size = New System.Drawing.Size(873, 601)
        CType(Me.dgvUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgvUserInfo As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbSearchType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Private WithEvents btnPayroll As System.Windows.Forms.Button
    Private WithEvents btnCashAdvance As System.Windows.Forms.Button

End Class
