Option Strict On

Public Class frmOhmsLaw

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblVoltage As Double
        Dim dblCurrent As Double
        Dim dblResistance As Double

        If Not Double.TryParse(txtVoltage.Text, dblVoltage) Then

            MessageBox.Show("Enter a valid voltage.")

            txtVoltage.Focus()

            Exit Sub

        End If

        If Not Double.TryParse(txtCurrent.Text, dblCurrent) Then

            MessageBox.Show("Enter a valid current.")

            txtCurrent.Focus()

            Exit Sub

        End If

        If dblCurrent <= 0 Then

            MessageBox.Show("Current must be greater than zero.")

            txtCurrent.Focus()

            Exit Sub

        End If

        dblResistance = dblVoltage / dblCurrent

        lblResistance.Text = dblResistance.ToString("N2") & " Ω"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtVoltage.Clear()

        txtCurrent.Clear()

        lblResistance.Text = "0.00 Ω"

        txtVoltage.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

End Class