Option Strict On

Public Class frmSHM

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblPeriod As Double
        Dim dblFrequency As Double
        Dim dblAngularFrequency As Double

        If Not Double.TryParse(txtPeriod.Text, dblPeriod) Then

            MessageBox.Show("Enter a valid period.")

            txtPeriod.Focus()

            Exit Sub

        End If

        If dblPeriod <= 0 Then

            MessageBox.Show("Period must be greater than zero.")

            txtPeriod.Focus()

            Exit Sub

        End If

        dblFrequency = 1 / dblPeriod

        dblAngularFrequency = 2 * Math.PI * dblFrequency

        lblFrequency.Text = "Frequeny:       " & dblFrequency.ToString("N2") & " Hz"

        lblAngularFrequency.Text = "Angular Freq:       " & dblAngularFrequency.ToString("N2") & " rad/s"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPeriod.Clear()

        lblFrequency.Text = "0.00 Hz"

        lblAngularFrequency.Text = "0.00 rad/s"

        txtPeriod.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

End Class