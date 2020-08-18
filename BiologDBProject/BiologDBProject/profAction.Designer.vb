<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profAction
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
    Me.pnlButton = New System.Windows.Forms.Panel()
    Me.btnNewProfessor = New System.Windows.Forms.Button()
    Me.btnUniv = New System.Windows.Forms.Button()
    Me.btnStudent = New System.Windows.Forms.Button()
    Me.btnLabData = New System.Windows.Forms.Button()
    Me.pnlDisp = New System.Windows.Forms.Panel()
    Me.newProfessor = New System.Windows.Forms.GroupBox()
    Me.dgv_University = New System.Windows.Forms.DataGridView()
    Me.UniversityIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CityIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.UniversityNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.UniversityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BiologDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.BiologDataSet = New BiologDBProject.biologDataSet()
    Me.cbbClass = New System.Windows.Forms.ComboBox()
    Me.txtPassword = New System.Windows.Forms.TextBox()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.txtPhone = New System.Windows.Forms.TextBox()
    Me.txtOffice = New System.Windows.Forms.TextBox()
    Me.txtFName = New System.Windows.Forms.TextBox()
    Me.txtLName = New System.Windows.Forms.TextBox()
    Me.txtProfID = New System.Windows.Forms.TextBox()
    Me.btnSubmit = New System.Windows.Forms.Button()
    Me.lblProfPass = New System.Windows.Forms.Label()
    Me.lblEmail = New System.Windows.Forms.Label()
    Me.lblPhone = New System.Windows.Forms.Label()
    Me.lblOffice = New System.Windows.Forms.Label()
    Me.lblLName = New System.Windows.Forms.Label()
    Me.lblFName = New System.Windows.Forms.Label()
    Me.lblClass = New System.Windows.Forms.Label()
    Me.lblProfID = New System.Windows.Forms.Label()
    Me.dgvStudentView = New System.Windows.Forms.DataGridView()
    Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.GradeLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.StudentPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.dgvData = New System.Windows.Forms.DataGridView()
    Me.DataIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.StudentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.SubstrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ReactionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ElectricalOutputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnExit = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.btn_newStudent = New System.Windows.Forms.Button()
    Me.btn_delStudent = New System.Windows.Forms.Button()
    Me.StudentTableAdapter = New BiologDBProject.biologDataSetTableAdapters.studentTableAdapter()
    Me.UniversityTableAdapter = New BiologDBProject.biologDataSetTableAdapters.universityTableAdapter()
    Me.DataTableAdapter = New BiologDBProject.biologDataSetTableAdapters.dataTableAdapter()
    Me.ttp_newProf = New System.Windows.Forms.ToolTip(Me.components)
    Me.pnlButton.SuspendLayout()
    Me.pnlDisp.SuspendLayout()
    Me.newProfessor.SuspendLayout()
    CType(Me.dgv_University, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UniversityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BiologDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BiologDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlButton
    '
    Me.pnlButton.Controls.Add(Me.btnNewProfessor)
    Me.pnlButton.Controls.Add(Me.btnUniv)
    Me.pnlButton.Controls.Add(Me.btnStudent)
    Me.pnlButton.Controls.Add(Me.btnLabData)
    Me.pnlButton.Location = New System.Drawing.Point(18, 18)
    Me.pnlButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.pnlButton.Name = "pnlButton"
    Me.pnlButton.Size = New System.Drawing.Size(300, 446)
    Me.pnlButton.TabIndex = 0
    '
    'btnNewProfessor
    '
    Me.btnNewProfessor.AutoSize = True
    Me.btnNewProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNewProfessor.Location = New System.Drawing.Point(7, 216)
    Me.btnNewProfessor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnNewProfessor.Name = "btnNewProfessor"
    Me.btnNewProfessor.Size = New System.Drawing.Size(274, 60)
    Me.btnNewProfessor.TabIndex = 3
    Me.btnNewProfessor.Text = "New &Professor"
    Me.ttp_newProf.SetToolTip(Me.btnNewProfessor, "Click to create a new Professor in the database")
    Me.btnNewProfessor.UseVisualStyleBackColor = True
    '
    'btnUniv
    '
    Me.btnUniv.AutoSize = True
    Me.btnUniv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnUniv.Location = New System.Drawing.Point(7, 146)
    Me.btnUniv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnUniv.Name = "btnUniv"
    Me.btnUniv.Size = New System.Drawing.Size(273, 60)
    Me.btnUniv.TabIndex = 2
    Me.btnUniv.Text = "&University Data"
    Me.btnUniv.UseVisualStyleBackColor = True
    '
    'btnStudent
    '
    Me.btnStudent.AutoSize = True
    Me.btnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnStudent.Location = New System.Drawing.Point(7, 76)
    Me.btnStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnStudent.Name = "btnStudent"
    Me.btnStudent.Size = New System.Drawing.Size(240, 60)
    Me.btnStudent.TabIndex = 1
    Me.btnStudent.Text = "&Student Data"
    Me.btnStudent.UseVisualStyleBackColor = True
    '
    'btnLabData
    '
    Me.btnLabData.AutoSize = True
    Me.btnLabData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLabData.Location = New System.Drawing.Point(6, 6)
    Me.btnLabData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnLabData.Name = "btnLabData"
    Me.btnLabData.Size = New System.Drawing.Size(177, 60)
    Me.btnLabData.TabIndex = 0
    Me.btnLabData.Text = "&Lab Data"
    Me.btnLabData.UseVisualStyleBackColor = True
    '
    'pnlDisp
    '
    Me.pnlDisp.AutoScroll = True
    Me.pnlDisp.Controls.Add(Me.dgv_University)
    Me.pnlDisp.Controls.Add(Me.dgvStudentView)
    Me.pnlDisp.Controls.Add(Me.dgvData)
    Me.pnlDisp.Controls.Add(Me.newProfessor)
    Me.pnlDisp.Location = New System.Drawing.Point(370, 18)
    Me.pnlDisp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.pnlDisp.Name = "pnlDisp"
    Me.pnlDisp.Size = New System.Drawing.Size(850, 446)
    Me.pnlDisp.TabIndex = 1
    '
    'newProfessor
    '
    Me.newProfessor.Controls.Add(Me.cbbClass)
    Me.newProfessor.Controls.Add(Me.txtPassword)
    Me.newProfessor.Controls.Add(Me.txtEmail)
    Me.newProfessor.Controls.Add(Me.txtPhone)
    Me.newProfessor.Controls.Add(Me.txtOffice)
    Me.newProfessor.Controls.Add(Me.txtFName)
    Me.newProfessor.Controls.Add(Me.txtLName)
    Me.newProfessor.Controls.Add(Me.txtProfID)
    Me.newProfessor.Controls.Add(Me.btnSubmit)
    Me.newProfessor.Controls.Add(Me.lblProfPass)
    Me.newProfessor.Controls.Add(Me.lblEmail)
    Me.newProfessor.Controls.Add(Me.lblPhone)
    Me.newProfessor.Controls.Add(Me.lblOffice)
    Me.newProfessor.Controls.Add(Me.lblLName)
    Me.newProfessor.Controls.Add(Me.lblFName)
    Me.newProfessor.Controls.Add(Me.lblClass)
    Me.newProfessor.Controls.Add(Me.lblProfID)
    Me.newProfessor.Location = New System.Drawing.Point(4, 5)
    Me.newProfessor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.newProfessor.Name = "newProfessor"
    Me.newProfessor.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.newProfessor.Size = New System.Drawing.Size(842, 403)
    Me.newProfessor.TabIndex = 3
    Me.newProfessor.TabStop = False
    Me.newProfessor.Text = "Add New Professor"
    Me.newProfessor.Visible = False
    '
    'dgv_University
    '
    Me.dgv_University.AllowUserToAddRows = False
    Me.dgv_University.AllowUserToDeleteRows = False
    Me.dgv_University.AutoGenerateColumns = False
    Me.dgv_University.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgv_University.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UniversityIDDataGridViewTextBoxColumn, Me.CityIDDataGridViewTextBoxColumn, Me.UniversityNameDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn})
    Me.dgv_University.DataSource = Me.UniversityBindingSource
    Me.dgv_University.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgv_University.Location = New System.Drawing.Point(0, 0)
    Me.dgv_University.Name = "dgv_University"
    Me.dgv_University.RowHeadersWidth = 62
    Me.dgv_University.RowTemplate.Height = 28
    Me.dgv_University.Size = New System.Drawing.Size(850, 446)
    Me.dgv_University.TabIndex = 17
    Me.dgv_University.Visible = False
    '
    'UniversityIDDataGridViewTextBoxColumn
    '
    Me.UniversityIDDataGridViewTextBoxColumn.DataPropertyName = "universityID"
    Me.UniversityIDDataGridViewTextBoxColumn.HeaderText = "universityID"
    Me.UniversityIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.UniversityIDDataGridViewTextBoxColumn.Name = "UniversityIDDataGridViewTextBoxColumn"
    Me.UniversityIDDataGridViewTextBoxColumn.Width = 150
    '
    'CityIDDataGridViewTextBoxColumn
    '
    Me.CityIDDataGridViewTextBoxColumn.DataPropertyName = "cityID"
    Me.CityIDDataGridViewTextBoxColumn.HeaderText = "cityID"
    Me.CityIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.CityIDDataGridViewTextBoxColumn.Name = "CityIDDataGridViewTextBoxColumn"
    Me.CityIDDataGridViewTextBoxColumn.Width = 150
    '
    'UniversityNameDataGridViewTextBoxColumn
    '
    Me.UniversityNameDataGridViewTextBoxColumn.DataPropertyName = "universityName"
    Me.UniversityNameDataGridViewTextBoxColumn.HeaderText = "universityName"
    Me.UniversityNameDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.UniversityNameDataGridViewTextBoxColumn.Name = "UniversityNameDataGridViewTextBoxColumn"
    Me.UniversityNameDataGridViewTextBoxColumn.Width = 150
    '
    'PhoneNoDataGridViewTextBoxColumn
    '
    Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "phoneNo"
    Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "phoneNo"
    Me.PhoneNoDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
    Me.PhoneNoDataGridViewTextBoxColumn.Width = 150
    '
    'UniversityBindingSource
    '
    Me.UniversityBindingSource.DataMember = "university"
    Me.UniversityBindingSource.DataSource = Me.BiologDataSetBindingSource
    '
    'BiologDataSetBindingSource
    '
    Me.BiologDataSetBindingSource.DataSource = Me.BiologDataSet
    Me.BiologDataSetBindingSource.Position = 0
    '
    'BiologDataSet
    '
    Me.BiologDataSet.DataSetName = "biologDataSet"
    Me.BiologDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'cbbClass
    '
    Me.cbbClass.FormattingEnabled = True
    Me.cbbClass.Location = New System.Drawing.Point(159, 78)
    Me.cbbClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.cbbClass.Name = "cbbClass"
    Me.cbbClass.Size = New System.Drawing.Size(180, 28)
    Me.cbbClass.TabIndex = 16
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(159, 340)
    Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(223, 26)
    Me.txtPassword.TabIndex = 15
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(159, 302)
    Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(223, 26)
    Me.txtEmail.TabIndex = 14
    '
    'txtPhone
    '
    Me.txtPhone.Location = New System.Drawing.Point(159, 262)
    Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtPhone.Name = "txtPhone"
    Me.txtPhone.Size = New System.Drawing.Size(223, 26)
    Me.txtPhone.TabIndex = 13
    '
    'txtOffice
    '
    Me.txtOffice.Location = New System.Drawing.Point(159, 211)
    Me.txtOffice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtOffice.Name = "txtOffice"
    Me.txtOffice.Size = New System.Drawing.Size(223, 26)
    Me.txtOffice.TabIndex = 12
    '
    'txtFName
    '
    Me.txtFName.Location = New System.Drawing.Point(159, 128)
    Me.txtFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtFName.Name = "txtFName"
    Me.txtFName.Size = New System.Drawing.Size(223, 26)
    Me.txtFName.TabIndex = 11
    '
    'txtLName
    '
    Me.txtLName.Location = New System.Drawing.Point(159, 168)
    Me.txtLName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtLName.Name = "txtLName"
    Me.txtLName.Size = New System.Drawing.Size(223, 26)
    Me.txtLName.TabIndex = 10
    '
    'txtProfID
    '
    Me.txtProfID.Location = New System.Drawing.Point(159, 32)
    Me.txtProfID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtProfID.Name = "txtProfID"
    Me.txtProfID.Size = New System.Drawing.Size(223, 26)
    Me.txtProfID.TabIndex = 9
    '
    'btnSubmit
    '
    Me.btnSubmit.Location = New System.Drawing.Point(720, 358)
    Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnSubmit.Name = "btnSubmit"
    Me.btnSubmit.Size = New System.Drawing.Size(112, 35)
    Me.btnSubmit.TabIndex = 8
    Me.btnSubmit.Text = "&Submit"
    Me.btnSubmit.UseVisualStyleBackColor = True
    '
    'lblProfPass
    '
    Me.lblProfPass.AutoSize = True
    Me.lblProfPass.Location = New System.Drawing.Point(27, 351)
    Me.lblProfPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblProfPass.Name = "lblProfPass"
    Me.lblProfPass.Size = New System.Drawing.Size(82, 20)
    Me.lblProfPass.TabIndex = 7
    Me.lblProfPass.Text = "Password:"
    '
    'lblEmail
    '
    Me.lblEmail.AutoSize = True
    Me.lblEmail.Location = New System.Drawing.Point(27, 306)
    Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblEmail.Name = "lblEmail"
    Me.lblEmail.Size = New System.Drawing.Size(52, 20)
    Me.lblEmail.TabIndex = 6
    Me.lblEmail.Text = "Email:"
    '
    'lblPhone
    '
    Me.lblPhone.AutoSize = True
    Me.lblPhone.Location = New System.Drawing.Point(26, 266)
    Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblPhone.Name = "lblPhone"
    Me.lblPhone.Size = New System.Drawing.Size(105, 20)
    Me.lblPhone.TabIndex = 5
    Me.lblPhone.Text = "Office Phone:"
    '
    'lblOffice
    '
    Me.lblOffice.AutoSize = True
    Me.lblOffice.Location = New System.Drawing.Point(26, 215)
    Me.lblOffice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblOffice.Name = "lblOffice"
    Me.lblOffice.Size = New System.Drawing.Size(115, 20)
    Me.lblOffice.TabIndex = 4
    Me.lblOffice.Text = "Office Number:"
    '
    'lblLName
    '
    Me.lblLName.AutoSize = True
    Me.lblLName.Location = New System.Drawing.Point(27, 172)
    Me.lblLName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblLName.Name = "lblLName"
    Me.lblLName.Size = New System.Drawing.Size(90, 20)
    Me.lblLName.TabIndex = 3
    Me.lblLName.Text = "Last Name:"
    '
    'lblFName
    '
    Me.lblFName.AutoSize = True
    Me.lblFName.Location = New System.Drawing.Point(27, 132)
    Me.lblFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblFName.Name = "lblFName"
    Me.lblFName.Size = New System.Drawing.Size(90, 20)
    Me.lblFName.TabIndex = 2
    Me.lblFName.Text = "First Name:"
    '
    'lblClass
    '
    Me.lblClass.AutoSize = True
    Me.lblClass.Location = New System.Drawing.Point(27, 83)
    Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblClass.Name = "lblClass"
    Me.lblClass.Size = New System.Drawing.Size(52, 20)
    Me.lblClass.TabIndex = 1
    Me.lblClass.Text = "Class:"
    '
    'lblProfID
    '
    Me.lblProfID.AutoSize = True
    Me.lblProfID.Location = New System.Drawing.Point(27, 37)
    Me.lblProfID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblProfID.Name = "lblProfID"
    Me.lblProfID.Size = New System.Drawing.Size(102, 20)
    Me.lblProfID.TabIndex = 0
    Me.lblProfID.Text = "Professor ID:"
    '
    'dgvStudentView
    '
    Me.dgvStudentView.AllowUserToAddRows = False
    Me.dgvStudentView.AllowUserToDeleteRows = False
    Me.dgvStudentView.AutoGenerateColumns = False
    Me.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvStudentView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.ClassIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GradeLevelDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.StudentPasswordDataGridViewTextBoxColumn})
    Me.dgvStudentView.DataSource = Me.StudentBindingSource
    Me.dgvStudentView.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvStudentView.Location = New System.Drawing.Point(0, 0)
    Me.dgvStudentView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dgvStudentView.Name = "dgvStudentView"
    Me.dgvStudentView.ReadOnly = True
    Me.dgvStudentView.RowHeadersWidth = 62
    Me.dgvStudentView.Size = New System.Drawing.Size(850, 446)
    Me.dgvStudentView.TabIndex = 0
    Me.dgvStudentView.Visible = False
    '
    'StudentIDDataGridViewTextBoxColumn
    '
    Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID"
    Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "studentID"
    Me.StudentIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
    Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
    Me.StudentIDDataGridViewTextBoxColumn.Width = 150
    '
    'ClassIDDataGridViewTextBoxColumn
    '
    Me.ClassIDDataGridViewTextBoxColumn.DataPropertyName = "classID"
    Me.ClassIDDataGridViewTextBoxColumn.HeaderText = "classID"
    Me.ClassIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.ClassIDDataGridViewTextBoxColumn.Name = "ClassIDDataGridViewTextBoxColumn"
    Me.ClassIDDataGridViewTextBoxColumn.ReadOnly = True
    Me.ClassIDDataGridViewTextBoxColumn.Width = 150
    '
    'FirstNameDataGridViewTextBoxColumn
    '
    Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
    Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
    Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
    Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
    Me.FirstNameDataGridViewTextBoxColumn.Width = 150
    '
    'LastNameDataGridViewTextBoxColumn
    '
    Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
    Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
    Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
    Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
    Me.LastNameDataGridViewTextBoxColumn.Width = 150
    '
    'GradeLevelDataGridViewTextBoxColumn
    '
    Me.GradeLevelDataGridViewTextBoxColumn.DataPropertyName = "gradeLevel"
    Me.GradeLevelDataGridViewTextBoxColumn.HeaderText = "gradeLevel"
    Me.GradeLevelDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.GradeLevelDataGridViewTextBoxColumn.Name = "GradeLevelDataGridViewTextBoxColumn"
    Me.GradeLevelDataGridViewTextBoxColumn.ReadOnly = True
    Me.GradeLevelDataGridViewTextBoxColumn.Width = 150
    '
    'EmailDataGridViewTextBoxColumn
    '
    Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
    Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
    Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
    Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
    Me.EmailDataGridViewTextBoxColumn.Width = 150
    '
    'StudentPasswordDataGridViewTextBoxColumn
    '
    Me.StudentPasswordDataGridViewTextBoxColumn.DataPropertyName = "studentPassword"
    Me.StudentPasswordDataGridViewTextBoxColumn.HeaderText = "studentPassword"
    Me.StudentPasswordDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.StudentPasswordDataGridViewTextBoxColumn.Name = "StudentPasswordDataGridViewTextBoxColumn"
    Me.StudentPasswordDataGridViewTextBoxColumn.ReadOnly = True
    Me.StudentPasswordDataGridViewTextBoxColumn.Width = 150
    '
    'StudentBindingSource
    '
    Me.StudentBindingSource.DataMember = "student"
    Me.StudentBindingSource.DataSource = Me.BiologDataSetBindingSource
    '
    'dgvData
    '
    Me.dgvData.AllowUserToAddRows = False
    Me.dgvData.AllowUserToDeleteRows = False
    Me.dgvData.AutoGenerateColumns = False
    Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn1, Me.LocationIDDataGridViewTextBoxColumn, Me.SubstrateDataGridViewTextBoxColumn, Me.ReactionDataGridViewTextBoxColumn, Me.ElectricalOutputDataGridViewTextBoxColumn})
    Me.dgvData.DataSource = Me.DataBindingSource
    Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvData.Location = New System.Drawing.Point(0, 0)
    Me.dgvData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.dgvData.Name = "dgvData"
    Me.dgvData.ReadOnly = True
    Me.dgvData.RowHeadersWidth = 62
    Me.dgvData.Size = New System.Drawing.Size(850, 446)
    Me.dgvData.TabIndex = 2
    Me.dgvData.Visible = False
    '
    'DataIDDataGridViewTextBoxColumn
    '
    Me.DataIDDataGridViewTextBoxColumn.DataPropertyName = "dataID"
    Me.DataIDDataGridViewTextBoxColumn.HeaderText = "dataID"
    Me.DataIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.DataIDDataGridViewTextBoxColumn.Name = "DataIDDataGridViewTextBoxColumn"
    Me.DataIDDataGridViewTextBoxColumn.ReadOnly = True
    Me.DataIDDataGridViewTextBoxColumn.Width = 150
    '
    'StudentIDDataGridViewTextBoxColumn1
    '
    Me.StudentIDDataGridViewTextBoxColumn1.DataPropertyName = "studentID"
    Me.StudentIDDataGridViewTextBoxColumn1.HeaderText = "studentID"
    Me.StudentIDDataGridViewTextBoxColumn1.MinimumWidth = 8
    Me.StudentIDDataGridViewTextBoxColumn1.Name = "StudentIDDataGridViewTextBoxColumn1"
    Me.StudentIDDataGridViewTextBoxColumn1.ReadOnly = True
    Me.StudentIDDataGridViewTextBoxColumn1.Width = 150
    '
    'LocationIDDataGridViewTextBoxColumn
    '
    Me.LocationIDDataGridViewTextBoxColumn.DataPropertyName = "locationID"
    Me.LocationIDDataGridViewTextBoxColumn.HeaderText = "locationID"
    Me.LocationIDDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.LocationIDDataGridViewTextBoxColumn.Name = "LocationIDDataGridViewTextBoxColumn"
    Me.LocationIDDataGridViewTextBoxColumn.ReadOnly = True
    Me.LocationIDDataGridViewTextBoxColumn.Width = 150
    '
    'SubstrateDataGridViewTextBoxColumn
    '
    Me.SubstrateDataGridViewTextBoxColumn.DataPropertyName = "substrate"
    Me.SubstrateDataGridViewTextBoxColumn.HeaderText = "substrate"
    Me.SubstrateDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.SubstrateDataGridViewTextBoxColumn.Name = "SubstrateDataGridViewTextBoxColumn"
    Me.SubstrateDataGridViewTextBoxColumn.ReadOnly = True
    Me.SubstrateDataGridViewTextBoxColumn.Width = 150
    '
    'ReactionDataGridViewTextBoxColumn
    '
    Me.ReactionDataGridViewTextBoxColumn.DataPropertyName = "reaction"
    Me.ReactionDataGridViewTextBoxColumn.HeaderText = "reaction"
    Me.ReactionDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.ReactionDataGridViewTextBoxColumn.Name = "ReactionDataGridViewTextBoxColumn"
    Me.ReactionDataGridViewTextBoxColumn.ReadOnly = True
    Me.ReactionDataGridViewTextBoxColumn.Width = 150
    '
    'ElectricalOutputDataGridViewTextBoxColumn
    '
    Me.ElectricalOutputDataGridViewTextBoxColumn.DataPropertyName = "electricalOutput"
    Me.ElectricalOutputDataGridViewTextBoxColumn.HeaderText = "electricalOutput"
    Me.ElectricalOutputDataGridViewTextBoxColumn.MinimumWidth = 8
    Me.ElectricalOutputDataGridViewTextBoxColumn.Name = "ElectricalOutputDataGridViewTextBoxColumn"
    Me.ElectricalOutputDataGridViewTextBoxColumn.ReadOnly = True
    Me.ElectricalOutputDataGridViewTextBoxColumn.Width = 150
    '
    'DataBindingSource
    '
    Me.DataBindingSource.DataMember = "data"
    Me.DataBindingSource.DataSource = Me.BiologDataSetBindingSource
    '
    'btnExit
    '
    Me.btnExit.AutoSize = True
    Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExit.Location = New System.Drawing.Point(18, 474)
    Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(128, 46)
    Me.btnExit.TabIndex = 2
    Me.btnExit.Text = "E&xit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.AutoSize = True
    Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button1.Location = New System.Drawing.Point(154, 474)
    Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(194, 46)
    Me.Button1.TabIndex = 3
    Me.Button1.Text = "&Return to Login"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'btn_newStudent
    '
    Me.btn_newStudent.AutoSize = True
    Me.btn_newStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_newStudent.Location = New System.Drawing.Point(375, 474)
    Me.btn_newStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btn_newStudent.Name = "btn_newStudent"
    Me.btn_newStudent.Size = New System.Drawing.Size(166, 46)
    Me.btn_newStudent.TabIndex = 9
    Me.btn_newStudent.Text = "N&ew Student"
    Me.btn_newStudent.UseVisualStyleBackColor = True
    Me.btn_newStudent.Visible = False
    '
    'btn_delStudent
    '
    Me.btn_delStudent.AutoSize = True
    Me.btn_delStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_delStudent.Location = New System.Drawing.Point(550, 474)
    Me.btn_delStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btn_delStudent.Name = "btn_delStudent"
    Me.btn_delStudent.Size = New System.Drawing.Size(190, 46)
    Me.btn_delStudent.TabIndex = 10
    Me.btn_delStudent.Text = "&Delete Student"
    Me.btn_delStudent.UseVisualStyleBackColor = True
    Me.btn_delStudent.Visible = False
    '
    'StudentTableAdapter
    '
    Me.StudentTableAdapter.ClearBeforeFill = True
    '
    'UniversityTableAdapter
    '
    Me.UniversityTableAdapter.ClearBeforeFill = True
    '
    'DataTableAdapter
    '
    Me.DataTableAdapter.ClearBeforeFill = True
    '
    'ttp_newProf
    '
    Me.ttp_newProf.Tag = ""
    Me.ttp_newProf.ToolTipTitle = "Create new Professor"
    '
    'profAction
    '
    Me.AccessibleDescription = "The purpose of this form is to allow a professor to add, modify, and view data."
    Me.AccessibleName = "Professor View"
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlDark
    Me.ClientSize = New System.Drawing.Size(1239, 525)
    Me.Controls.Add(Me.btn_delStudent)
    Me.Controls.Add(Me.btn_newStudent)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.pnlDisp)
    Me.Controls.Add(Me.pnlButton)
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "profAction"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Biolog Lab Data - Professor"
    Me.pnlButton.ResumeLayout(False)
    Me.pnlButton.PerformLayout()
    Me.pnlDisp.ResumeLayout(False)
    Me.newProfessor.ResumeLayout(False)
    Me.newProfessor.PerformLayout()
    CType(Me.dgv_University, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UniversityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BiologDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BiologDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents pnlButton As Panel
  Friend WithEvents btnUniv As Button
  Friend WithEvents btnStudent As Button
  Friend WithEvents btnLabData As Button
  Friend WithEvents pnlDisp As Panel
  Friend WithEvents btnExit As Button
  Friend WithEvents Button1 As Button
  Friend WithEvents dgvStudentView As DataGridView
  Friend WithEvents BiologDataSetBindingSource As BindingSource
  Friend WithEvents BiologDataSet As biologDataSet
  Friend WithEvents StudentBindingSource As BindingSource
  Friend WithEvents StudentTableAdapter As biologDataSetTableAdapters.studentTableAdapter
  Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ClassIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents GradeLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents StudentPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents UniversityBindingSource As BindingSource
  Friend WithEvents UniversityTableAdapter As biologDataSetTableAdapters.universityTableAdapter
  Friend WithEvents dgvData As DataGridView
  Friend WithEvents DataBindingSource As BindingSource
  Friend WithEvents DataTableAdapter As biologDataSetTableAdapters.dataTableAdapter
  Friend WithEvents DataIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents LocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents SubstrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ReactionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ElectricalOutputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents newProfessor As GroupBox
  Friend WithEvents lblProfPass As Label
  Friend WithEvents lblEmail As Label
  Friend WithEvents lblPhone As Label
  Friend WithEvents lblOffice As Label
  Friend WithEvents lblLName As Label
  Friend WithEvents lblFName As Label
  Friend WithEvents lblClass As Label
  Friend WithEvents lblProfID As Label
  Friend WithEvents cbbClass As ComboBox
  Friend WithEvents txtPassword As TextBox
  Friend WithEvents txtEmail As TextBox
  Friend WithEvents txtPhone As TextBox
  Friend WithEvents txtOffice As TextBox
  Friend WithEvents txtFName As TextBox
  Friend WithEvents txtLName As TextBox
  Friend WithEvents txtProfID As TextBox
  Friend WithEvents btnSubmit As Button
  Friend WithEvents btnNewProfessor As Button
  Friend WithEvents btn_newStudent As Button
  Friend WithEvents btn_delStudent As Button
  Friend WithEvents dgv_University As DataGridView
  Friend WithEvents UniversityIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniversityNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ttp_newProf As ToolTip
End Class
