Option Strict On

Public Class frmMainMenu

    Private Sub btnOhmsLaw_Click(sender As Object, e As EventArgs) Handles btnOhmsLaw.Click

        Dim frm As New frmOhmsLaw

        Me.Hide()

        frm.ShowDialog()

        Me.Show()

    End Sub

    Private Sub btnSHM_Click(sender As Object, e As EventArgs) Handles btnSHM.Click

        Dim frm As New frmSHM

        Me.Hide()

        frm.ShowDialog()

        Me.Show()

    End Sub

    Private Sub btnStandingWaves_Click(sender As Object, e As EventArgs) Handles btnStandingWaves.Click

        Dim frm As New frmStandingWaves

        Me.Hide()

        frm.ShowDialog()

        Me.Show()

    End Sub

    Private Sub btnPercentageError_Click(sender As Object, e As EventArgs) Handles btnPercentageError.Click

        Dim frm As New frmPercentageError

        Me.Hide()

        frm.ShowDialog()

        Me.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class
