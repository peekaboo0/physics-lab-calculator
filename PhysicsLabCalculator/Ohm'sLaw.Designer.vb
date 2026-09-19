<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOhmsLaw
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
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.lblvoltageUnit = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.lblCurrentUnit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResistanceText = New System.Windows.Forms.Label()
        Me.lblResistance = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(324, 18)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(294, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "OHM'S LAW CALCULATOR"
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoltage.Location = New System.Drawing.Point(302, 97)
        Me.lblVoltage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(65, 16)
        Me.lblVoltage.TabIndex = 1
        Me.lblVoltage.Text = "Voltage:"
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(408, 91)
        Me.txtVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(132, 22)
        Me.txtVoltage.TabIndex = 2
        '
        'lblvoltageUnit
        '
        Me.lblvoltageUnit.AutoSize = True
        Me.lblvoltageUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvoltageUnit.Location = New System.Drawing.Point(539, 97)
        Me.lblvoltageUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvoltageUnit.Name = "lblvoltageUnit"
        Me.lblvoltageUnit.Size = New System.Drawing.Size(14, 13)
        Me.lblvoltageUnit.TabIndex = 3
        Me.lblvoltageUnit.Text = "V"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCurrent.Location = New System.Drawing.Point(302, 169)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(60, 16)
        Me.lblCurrent.TabIndex = 4
        Me.lblCurrent.Text = "Current:"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(408, 163)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(132, 22)
        Me.txtCurrent.TabIndex = 5
        '
        'lblCurrentUnit
        '
        Me.lblCurrentUnit.AutoSize = True
        Me.lblCurrentUnit.Location = New System.Drawing.Point(539, 169)
        Me.lblCurrentUnit.Name = "lblCurrentUnit"
        Me.lblCurrentUnit.Size = New System.Drawing.Size(16, 16)
        Me.lblCurrentUnit.TabIndex = 6
        Me.lblCurrentUnit.Text = "A"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(305, 216)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(166, 49)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(521, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 32)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResistanceText
        '
        Me.lblResistanceText.AutoSize = True
        Me.lblResistanceText.Location = New System.Drawing.Point(302, 318)
        Me.lblResistanceText.Name = "lblResistanceText"
        Me.lblResistanceText.Size = New System.Drawing.Size(78, 16)
        Me.lblResistanceText.TabIndex = 9
        Me.lblResistanceText.Text = "Resistance:"
        '
        'lblResistance
        '
        Me.lblResistance.AutoSize = True
        Me.lblResistance.Location = New System.Drawing.Point(493, 318)
        Me.lblResistance.Name = "lblResistance"
        Me.lblResistance.Size = New System.Drawing.Size(44, 16)
        Me.lblResistance.TabIndex = 10
        Me.lblResistance.Text = "0.00 Ω"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(168, 417)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(146, 31)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmOhmsLaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 527)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblResistance)
        Me.Controls.Add(Me.lblResistanceText)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCurrentUnit)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblvoltageUnit)
        Me.Controls.Add(Me.txtVoltage)
        Me.Controls.Add(Me.lblVoltage)
        Me.Controls.Add(Me.lblHeading)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOhmsLaw"
        Me.Text = "Ohm's Law"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblVoltage As Label
    Friend WithEvents txtVoltage As TextBox
    Friend WithEvents lblvoltageUnit As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents lblCurrentUnit As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResistanceText As Label
    Friend WithEvents lblResistance As Label
    Friend WithEvents btnBack As Button
End Class
