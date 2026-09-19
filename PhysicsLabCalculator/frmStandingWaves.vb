Option Strict On

Public Class frmStandingWaves

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblLength As Double
        Dim intSegments As Integer
        Dim dblFrequency As Double
        Dim dblWavelength As Double
        Dim dblWaveSpeed As Double

        If Not Double.TryParse(txtLength.Text, dblLength) Then

            MessageBox.Show("Enter a valid string length.")

            txtLength.Focus()

            Exit Sub

        End If

        If Not Integer.TryParse(txtSegments.Text, intSegments) Then

            MessageBox.Show("Enter a valid number of segments.")

            txtSegments.Focus()

            Exit Sub

        End If

        If Not Double.TryParse(txtFrequency.Text, dblFrequency) Then

            MessageBox.Show("Enter a valid frequency.")

            txtFrequency.Focus()

            Exit Sub

        End If

        If dblLength <= 0 Or intSegments <= 0 Or dblFrequency <= 0 Then

            MessageBox.Show("All values must be greater than zero.")

            Exit Sub

        End If

        dblWavelength = (2 * dblLength) / intSegments

        dblWaveSpeed = dblFrequency * dblWavelength

        lblWavelength.Text = "Wave length:      " & dblWavelength.ToString("N2") & " m"

        lblWaveSpeed.Text = "Wave Speed:        " & dblWaveSpeed.ToString("N2") & " m/s"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtLength.Clear()

        txtSegments.Clear()

        txtFrequency.Clear()

        lblWavelength.Text = "0.00 m"

        lblWaveSpeed.Text = "0.00 m/s"

        txtLength.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click

        Me.Close()

    End Sub

End Class