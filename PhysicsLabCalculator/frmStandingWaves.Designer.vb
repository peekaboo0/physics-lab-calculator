<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandingWaves
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblSegments = New System.Windows.Forms.Label()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtSegments = New System.Windows.Forms.TextBox()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWavelength = New System.Windows.Forms.Label()
        Me.lblWaveSpeed = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(292, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(354, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "STANDING WAVE CALCULATOR"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblLength.Location = New System.Drawing.Point(280, 112)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(101, 16)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "String Length:"
        '
        'lblSegments
        '
        Me.lblSegments.AutoSize = True
        Me.lblSegments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblSegments.Location = New System.Drawing.Point(280, 154)
        Me.lblSegments.Name = "lblSegments"
        Me.lblSegments.Size = New System.Drawing.Size(155, 16)
        Me.lblSegments.TabIndex = 2
        Me.lblSegments.Text = "Number of Segments:"
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblFrequency.Location = New System.Drawing.Point(280, 199)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(84, 16)
        Me.lblFrequency.TabIndex = 3
        Me.lblFrequency.Text = "Frequancy:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(501, 108)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 4
        '
        'txtSegments
        '
        Me.txtSegments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSegments.Location = New System.Drawing.Point(501, 150)
        Me.txtSegments.Name = "txtSegments"
        Me.txtSegments.Size = New System.Drawing.Size(100, 20)
        Me.txtSegments.TabIndex = 5
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(501, 195)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(100, 20)
        Me.txtFrequency.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(283, 252)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(152, 32)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(523, 252)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 32)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblWavelength
        '
        Me.lblWavelength.AutoSize = True
        Me.lblWavelength.Location = New System.Drawing.Point(294, 320)
        Me.lblWavelength.Name = "lblWavelength"
        Me.lblWavelength.Size = New System.Drawing.Size(109, 13)
        Me.lblWavelength.TabIndex = 9
        Me.lblWavelength.Text = "Wavelength:    0.00m"
        '
        'lblWaveSpeed
        '
        Me.lblWaveSpeed.AutoSize = True
        Me.lblWaveSpeed.Location = New System.Drawing.Point(294, 356)
        Me.lblWaveSpeed.Name = "lblWaveSpeed"
        Me.lblWaveSpeed.Size = New System.Drawing.Size(130, 13)
        Me.lblWaveSpeed.TabIndex = 10
        Me.lblWaveSpeed.Text = "Wave Speed:      0.00m/s"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(114, 395)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(140, 32)
        Me.btnback.TabIndex = 11
        Me.btnback.Text = "Back to Main Menu"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frmStandingWaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 527)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblWaveSpeed)
        Me.Controls.Add(Me.lblWavelength)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFrequency)
        Me.Controls.Add(Me.txtSegments)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblFrequency)
        Me.Controls.Add(Me.lblSegments)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmStandingWaves"
        Me.Text = "Standing Waves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblSegments As Label
    Friend WithEvents lblFrequency As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtSegments As TextBox
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblWavelength As Label
    Friend WithEvents lblWaveSpeed As Label
    Friend WithEvents btnback As Button
End Class
