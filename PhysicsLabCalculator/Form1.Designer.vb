<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnOhmsLaw = New System.Windows.Forms.Button()
        Me.btnSHM = New System.Windows.Forms.Button()
        Me.btnStandingWaves = New System.Windows.Forms.Button()
        Me.btnPercentageError = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(300, 68)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(308, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "PHYSICS LAB CALCULATOR"
        '
        'btnOhmsLaw
        '
        Me.btnOhmsLaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOhmsLaw.Location = New System.Drawing.Point(263, 142)
        Me.btnOhmsLaw.Name = "btnOhmsLaw"
        Me.btnOhmsLaw.Size = New System.Drawing.Size(407, 49)
        Me.btnOhmsLaw.TabIndex = 1
        Me.btnOhmsLaw.Text = "Ohm's Law"
        Me.btnOhmsLaw.UseVisualStyleBackColor = True
        '
        'btnSHM
        '
        Me.btnSHM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSHM.Location = New System.Drawing.Point(263, 206)
        Me.btnSHM.Name = "btnSHM"
        Me.btnSHM.Size = New System.Drawing.Size(407, 49)
        Me.btnSHM.TabIndex = 2
        Me.btnSHM.Text = "Simple Harmonic Motion"
        Me.btnSHM.UseVisualStyleBackColor = True
        '
        'btnStandingWaves
        '
        Me.btnStandingWaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStandingWaves.Location = New System.Drawing.Point(263, 271)
        Me.btnStandingWaves.Name = "btnStandingWaves"
        Me.btnStandingWaves.Size = New System.Drawing.Size(407, 49)
        Me.btnStandingWaves.TabIndex = 3
        Me.btnStandingWaves.Text = "Standing Waves"
        Me.btnStandingWaves.UseVisualStyleBackColor = True
        '
        'btnPercentageError
        '
        Me.btnPercentageError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPercentageError.Location = New System.Drawing.Point(263, 336)
        Me.btnPercentageError.Name = "btnPercentageError"
        Me.btnPercentageError.Size = New System.Drawing.Size(407, 49)
        Me.btnPercentageError.TabIndex = 4
        Me.btnPercentageError.Text = "Percentage Error"
        Me.btnPercentageError.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(783, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 527)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPercentageError)
        Me.Controls.Add(Me.btnStandingWaves)
        Me.Controls.Add(Me.btnSHM)
        Me.Controls.Add(Me.btnOhmsLaw)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmMainMenu"
        Me.Text = "Physics Lab Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnOhmsLaw As Button
    Friend WithEvents btnSHM As Button
    Friend WithEvents btnStandingWaves As Button
    Friend WithEvents btnPercentageError As Button
    Friend WithEvents btnExit As Button
End Class
