Option Strict On

Public Class frmPercentageError

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblExperimental As Double
        Dim dblTheoretical As Double
        Dim dblError As Double

        If Not Double.TryParse(txtExperimental.Text, dblExperimental) Then

            MessageBox.Show("Enter a valid experimental value.")

            txtExperimental.Focus()

            Exit Sub

        End If

        If Not Double.TryParse(txtTheoretical.Text, dblTheoretical) Then

            MessageBox.Show("Enter a valid theoretical value.")

            txtTheoretical.Focus()

            Exit Sub

        End If

        If dblTheoretical = 0 Then

            MessageBox.Show("The theoretical value cannot be zero.")

            txtTheoretical.Focus()

            Exit Sub

        End If

        dblError = Math.Abs(dblExperimental - dblTheoretical) / Math.Abs(dblTheoretical) * 100

        lblPercentageError.Text = dblError.ToString("N2") & " %"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtExperimental.Clear()

        txtTheoretical.Clear()

        lblPercentageError.Text = "0.00 %"

        txtExperimental.Focus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

End Class