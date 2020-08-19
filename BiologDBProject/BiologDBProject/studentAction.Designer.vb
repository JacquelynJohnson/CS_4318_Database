<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentAction
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ttpNewData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpModData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpViewData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpQuery = New System.Windows.Forms.ToolTip(Me.components)
        Me.rbtn_newData = New System.Windows.Forms.RadioButton()
        Me.rbtn_modData = New System.Windows.Forms.RadioButton()
        Me.rbtn_viewData = New System.Windows.Forms.RadioButton()
        Me.rbtn_query = New System.Windows.Forms.RadioButton()
        Me.rbtn_return = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.ttpReturn = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(81, 139)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(69, 30)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'rbtn_newData
        '
        Me.rbtn_newData.AutoSize = True
        Me.rbtn_newData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_newData.Location = New System.Drawing.Point(30, 19)
        Me.rbtn_newData.Name = "rbtn_newData"
        Me.rbtn_newData.Size = New System.Drawing.Size(119, 22)
        Me.rbtn_newData.TabIndex = 6
        Me.rbtn_newData.Text = "New Lab Data"
        Me.ttpNewData.SetToolTip(Me.rbtn_newData, "Select to add a new entry to lab data table")
        Me.rbtn_newData.UseMnemonic = False
        Me.rbtn_newData.UseVisualStyleBackColor = True
        '
        'rbtn_modData
        '
        Me.rbtn_modData.AutoSize = True
        Me.rbtn_modData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_modData.Location = New System.Drawing.Point(30, 42)
        Me.rbtn_modData.Name = "rbtn_modData"
        Me.rbtn_modData.Size = New System.Drawing.Size(133, 22)
        Me.rbtn_modData.TabIndex = 7
        Me.rbtn_modData.TabStop = True
        Me.rbtn_modData.Text = "Modify Lab Data"
        Me.ttpModData.SetToolTip(Me.rbtn_modData, "Select to modify existing lab record")
        Me.rbtn_modData.UseVisualStyleBackColor = True
        '
        'rbtn_viewData
        '
        Me.rbtn_viewData.AutoSize = True
        Me.rbtn_viewData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_viewData.Location = New System.Drawing.Point(30, 65)
        Me.rbtn_viewData.Name = "rbtn_viewData"
        Me.rbtn_viewData.Size = New System.Drawing.Size(120, 22)
        Me.rbtn_viewData.TabIndex = 8
        Me.rbtn_viewData.TabStop = True
        Me.rbtn_viewData.Text = "View Lab Data"
        Me.ttpViewData.SetToolTip(Me.rbtn_viewData, "Select to only view selected lab data")
        Me.rbtn_viewData.UseVisualStyleBackColor = True
        '
        'rbtn_query
        '
        Me.rbtn_query.AutoSize = True
        Me.rbtn_query.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_query.Location = New System.Drawing.Point(30, 88)
        Me.rbtn_query.Name = "rbtn_query"
        Me.rbtn_query.Size = New System.Drawing.Size(101, 22)
        Me.rbtn_query.TabIndex = 9
        Me.rbtn_query.TabStop = True
        Me.rbtn_query.Text = "Query Data"
        Me.ttpQuery.SetToolTip(Me.rbtn_query, "Select to query data across records")
        Me.rbtn_query.UseVisualStyleBackColor = True
        '
        'rbtn_return
        '
        Me.rbtn_return.AutoSize = True
        Me.rbtn_return.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_return.Location = New System.Drawing.Point(30, 112)
        Me.rbtn_return.Name = "rbtn_return"
        Me.rbtn_return.Size = New System.Drawing.Size(127, 22)
        Me.rbtn_return.TabIndex = 10
        Me.rbtn_return.TabStop = True
        Me.rbtn_return.Text = "Return to Login"
        Me.ttpReturn.SetToolTip(Me.rbtn_return, "Return to login screen")
        Me.rbtn_return.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_modData)
        Me.GroupBox1.Controls.Add(Me.rbtn_return)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.rbtn_newData)
        Me.GroupBox1.Controls.Add(Me.rbtn_query)
        Me.GroupBox1.Controls.Add(Me.rbtn_viewData)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an action"
        '
        'btn_exit
        '
        Me.btn_exit.AutoSize = True
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(146, 193)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(69, 30)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'studentAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(366, 240)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "studentAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biolog Lab Data - Student View"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ttpNewData As ToolTip
    Friend WithEvents ttpModData As ToolTip
    Friend WithEvents ttpViewData As ToolTip
    Friend WithEvents ttpQuery As ToolTip
    Friend WithEvents rbtn_newData As RadioButton
    Friend WithEvents rbtn_modData As RadioButton
    Friend WithEvents rbtn_viewData As RadioButton
    Friend WithEvents rbtn_query As RadioButton
    Friend WithEvents rbtn_return As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents ttpReturn As ToolTip
End Class
