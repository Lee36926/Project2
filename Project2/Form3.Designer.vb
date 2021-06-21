<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Me.DgvTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnLog = New System.Windows.Forms.Button()
        CType(Me.DgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTable
        '
        Me.DgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgvTable.Location = New System.Drawing.Point(8, 12)
        Me.DgvTable.Name = "DgvTable"
        Me.DgvTable.RowHeadersWidth = 51
        Me.DgvTable.RowTemplate.Height = 24
        Me.DgvTable.Size = New System.Drawing.Size(472, 217)
        Me.DgvTable.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "ItemName"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(8, 260)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(90, 30)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnLog
        '
        Me.BtnLog.Location = New System.Drawing.Point(395, 260)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(85, 30)
        Me.BtnLog.TabIndex = 2
        Me.BtnLog.Text = "Logout"
        Me.BtnLog.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 349)
        Me.Controls.Add(Me.BtnLog)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DgvTable)
        Me.Name = "FrmAdmin"
        Me.Text = "Admin"
        CType(Me.DgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvTable As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnLog As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
