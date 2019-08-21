<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUserManagement
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUserManagement))
        Me.dgvUserInfo = New MetroFramework.Controls.MetroGrid()
        Me.cmbSearchType = New MetroFramework.Controls.MetroComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        CType(Me.dgvUserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUserInfo
        '
        Me.dgvUserInfo.AllowUserToAddRows = False
        Me.dgvUserInfo.AllowUserToDeleteRows = False
        Me.dgvUserInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUserInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvUserInfo.ColumnHeadersHeight = 25
        Me.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserInfo.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvUserInfo.EnableHeadersVisualStyles = False
        Me.dgvUserInfo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUserInfo.Location = New System.Drawing.Point(3, 111)
        Me.dgvUserInfo.MultiSelect = False
        Me.dgvUserInfo.Name = "dgvUserInfo"
        Me.dgvUserInfo.ReadOnly = True
        Me.dgvUserInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvUserInfo.RowHeadersWidth = 23
        Me.dgvUserInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserInfo.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvUserInfo.RowTemplate.Height = 25
        Me.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserInfo.ShowCellErrors = False
        Me.dgvUserInfo.ShowEditingIcon = False
        Me.dgvUserInfo.ShowRowErrors = False
        Me.dgvUserInfo.Size = New System.Drawing.Size(867, 395)
        Me.dgvUserInfo.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvUserInfo.TabIndex = 51
        '
        'cmbSearchType
        '
        Me.cmbSearchType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.ItemHeight = 19
        Me.cmbSearchType.Items.AddRange(New Object() {"User ID", "Name"})
        Me.cmbSearchType.Location = New System.Drawing.Point(487, 81)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(151, 25)
        Me.cmbSearchType.TabIndex = 325
        Me.cmbSearchType.UseSelectable = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(643, 81)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(216, 25)
        Me.txtSearch.TabIndex = 324
        '
        'Column1
        '
        Me.Column1.HeaderText = "User ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
        '
        'Column2
        '
        Me.Column2.HeaderText = "User Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 110
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column6
        '
        Me.Column6.HeaderText = "Username"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gender"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Column5
        '
        Me.Column5.HeaderText = "Birthday"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 110
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(746, 525)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 35)
        Me.btnDelete.TabIndex = 326
        Me.btnDelete.Text = "   DELETE"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(3, 525)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(155, 35)
        Me.btnAddNew.TabIndex = 327
        Me.btnAddNew.Text = "   ADD NEW USER"
        Me.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'ucUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvUserInfo)
        Me.Name = "ucUserManagement"
        Me.Size = New System.Drawing.Size(873, 601)
        CType(Me.dgvUserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgvUserInfo As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmbSearchType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnAddNew As System.Windows.Forms.Button

End Class
