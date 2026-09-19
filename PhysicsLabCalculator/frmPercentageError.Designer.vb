<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPercentageError
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblExperimental = New System.Windows.Forms.Label()
        Me.lblTheoretical = New System.Windows.Forms.Label()
        Me.txtExperimental = New System.Windows.Forms.TextBox()
        Me.txtTheoretical = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPercentageError = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(378, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(173, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Percentage Error"
        '
        'lblExperimental
        '
        Me.lblExperimental.AutoSize = True
        Me.lblExperimental.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExperimental.Location = New System.Drawing.Point(296, 118)
        Me.lblExperimental.Name = "lblExperimental"
        Me.lblExperimental.Size = New System.Drawing.Size(119, 13)
        Me.lblExperimental.TabIndex = 1
        Me.lblExperimental.Text = "Experimental Value:"
        '
        'lblTheoretical
        '
        Me.lblTheoretical.AutoSize = True
        Me.lblTheoretical.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheoretical.Location = New System.Drawing.Point(296, 169)
        Me.lblTheoretical.Name = "lblTheoretical"
        Me.lblTheoretical.Size = New System.Drawing.Size(118, 13)
        Me.lblTheoretical.TabIndex = 2
        Me.lblTheoretical.Text = "Theorectical Value:"
        '
        'txtExperimental
        '
        Me.txtExperimental.Location = New System.Drawing.Point(437, 111)
        Me.txtExperimental.Name = "txtExperimental"
        Me.txtExperimental.Size = New System.Drawing.Size(100, 20)
        Me.txtExperimental.TabIndex = 3
        '
        'txtTheoretical
        '
        Me.txtTheoretical.Location = New System.Drawing.Point(437, 162)
        Me.txtTheoretical.Name = "txtTheoretical"
        Me.txtTheoretical.Size = New System.Drawing.Size(100, 20)
        Me.txtTheoretical.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(299, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 42)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(520, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 28)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPercentageError
        '
        Me.lblPercentageError.AutoSize = True
        Me.lblPercentageError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentageError.Location = New System.Drawing.Point(296, 299)
        Me.lblPercentageError.Name = "lblPercentageError"
        Me.lblPercentageError.Size = New System.Drawing.Size(114, 16)
        Me.lblPercentageError.TabIndex = 7
        Me.lblPercentageError.Text = "Percentage error: "
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(147, 367)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(173, 35)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmPercentageError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 527)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPercentageError)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTheoretical)
        Me.Controls.Add(Me.txtExperimental)
        Me.Controls.Add(Me.lblTheoretical)
        Me.Controls.Add(Me.lblExperimental)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPercentageError"
        Me.Text = "Percentage Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblExperimental As Label
    Friend WithEvents lblTheoretical As Label
    Friend WithEvents txtExperimental As TextBox
    Friend WithEvents txtTheoretical As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPercentageError As Label
    Friend WithEvents btnBack As Button
End Class
