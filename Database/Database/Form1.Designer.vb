<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLastUpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseGridDataSet = New Database.CourseGridDataSet()
        Me.CourseTableAdapter = New Database.CourseGridDataSetTableAdapters.CourseTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseGridDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.CreditHoursDataGridViewTextBoxColumn, Me.TuitionDataGridViewTextBoxColumn, Me.CourseFeesDataGridViewTextBoxColumn, Me.DateLastUpdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CourseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1193, 603)
        Me.DataGridView1.TabIndex = 0
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseIDDataGridViewTextBoxColumn.Width = 75
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 75
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentDataGridViewTextBoxColumn.Width = 87
        '
        'CreditHoursDataGridViewTextBoxColumn
        '
        Me.CreditHoursDataGridViewTextBoxColumn.DataPropertyName = "CreditHours"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CreditHoursDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CreditHoursDataGridViewTextBoxColumn.HeaderText = "CreditHours"
        Me.CreditHoursDataGridViewTextBoxColumn.Name = "CreditHoursDataGridViewTextBoxColumn"
        Me.CreditHoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditHoursDataGridViewTextBoxColumn.Width = 87
        '
        'TuitionDataGridViewTextBoxColumn
        '
        Me.TuitionDataGridViewTextBoxColumn.DataPropertyName = "Tuition"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TuitionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TuitionDataGridViewTextBoxColumn.HeaderText = "Tuition"
        Me.TuitionDataGridViewTextBoxColumn.Name = "TuitionDataGridViewTextBoxColumn"
        Me.TuitionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TuitionDataGridViewTextBoxColumn.Width = 64
        '
        'CourseFeesDataGridViewTextBoxColumn
        '
        Me.CourseFeesDataGridViewTextBoxColumn.DataPropertyName = "CourseFees"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CourseFeesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CourseFeesDataGridViewTextBoxColumn.HeaderText = "CourseFees"
        Me.CourseFeesDataGridViewTextBoxColumn.Name = "CourseFeesDataGridViewTextBoxColumn"
        Me.CourseFeesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseFeesDataGridViewTextBoxColumn.Width = 88
        '
        'DateLastUpdateDataGridViewTextBoxColumn
        '
        Me.DateLastUpdateDataGridViewTextBoxColumn.DataPropertyName = "DateLastUpdate"
        Me.DateLastUpdateDataGridViewTextBoxColumn.HeaderText = "DateLastUpdate"
        Me.DateLastUpdateDataGridViewTextBoxColumn.Name = "DateLastUpdateDataGridViewTextBoxColumn"
        Me.DateLastUpdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateLastUpdateDataGridViewTextBoxColumn.Width = 110
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.CourseGridDataSet
        '
        'CourseGridDataSet
        '
        Me.CourseGridDataSet.DataSetName = "CourseGridDataSet"
        Me.CourseGridDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 603)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseGridDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CourseGridDataSet As Database.CourseGridDataSet
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter As Database.CourseGridDataSetTableAdapters.CourseTableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditHoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TuitionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateLastUpdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
