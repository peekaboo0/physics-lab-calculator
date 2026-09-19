<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSHM
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblPeriodUnit = New System.Windows.Forms.Label()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.lblAngularFrequency = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(340, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(264, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Simple Harmonic Motion"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(343, 155)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(127, 42)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(515, 166)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 31)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(446, 85)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriod.TabIndex = 3
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.Location = New System.Drawing.Point(340, 88)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(57, 16)
        Me.lblPeriod.TabIndex = 4
        Me.lblPeriod.Text = "Period:"
        '
        'lblPeriodUnit
        '
        Me.lblPeriodUnit.AutoSize = True
        Me.lblPeriodUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodUnit.Location = New System.Drawing.Point(552, 92)
        Me.lblPeriodUnit.Name = "lblPeriodUnit"
        Me.lblPeriodUnit.Size = New System.Drawing.Size(12, 13)
        Me.lblPeriodUnit.TabIndex = 5
        Me.lblPeriodUnit.Text = "s"
        '
        'lblFrequency
        '
        Me.lblFrequency.Location = New System.Drawing.Point(342, 266)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(262, 23)
        Me.lblFrequency.TabIndex = 6
        Me.lblFrequency.Text = "Frequency:"
        '
        'lblAngularFrequency
        '
        Me.lblAngularFrequency.Location = New System.Drawing.Point(342, 304)
        Me.lblAngularFrequency.Name = "lblAngularFrequency"
        Me.lblAngularFrequency.Size = New System.Drawing.Size(262, 23)
        Me.lblAngularFrequency.TabIndex = 7
        Me.lblAngularFrequency.Text = "Angular Freq. :"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnBack.Location = New System.Drawing.Point(168, 417)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 31)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmSHM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 527)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAngularFrequency)
        Me.Controls.Add(Me.lblFrequency)
        Me.Controls.Add(Me.lblPeriodUnit)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSHM"
        Me.Text = "Simple Harmonic Motion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblPeriodUnit As Label
    Friend WithEvents lblFrequency As Label
    Friend WithEvents lblAngularFrequency As Label
    Friend WithEvents btnBack As Button
End Class
