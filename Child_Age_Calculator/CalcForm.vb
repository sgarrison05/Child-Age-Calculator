Public Class frmchildCalculator

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click

        Dim dteBirthdate As Date = dtpchildDOB.Value
        Dim dteToday As Date = Date.Today
        Dim childage As Integer

        childage = dteToday.Year - dteBirthdate.Year

        If dteBirthdate.Date > dteToday.AddYears(-childage) Then

            childage -= 1

        End If

        lblageOutput.Text = childage.ToString

        lblageOutput.ForeColor = If(childage >= 17, Color.Red, Color.Blue)

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        dtpchildDOB.Value = Date.Today
        lblageOutput.Text = ""
        dtpchildDOB.Focus()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub dtpchildDOB_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpchildDOB.ValueChanged

        lblageOutput.Text = ""

    End Sub
End Class
