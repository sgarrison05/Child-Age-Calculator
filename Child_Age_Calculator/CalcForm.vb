Public Class frmchildCalculator


    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click

        Dim dteBirthdate As Date = dtpchildDOB.Text
        Dim dteToday As Date = Date.Today
        Dim childage As Integer


        childage = CType(DateDiff(DateInterval.Year, dteBirthdate, dteToday), Integer)

        If Month(dteBirthdate) > Month(dteToday) Then

            childage = childage - 1

        ElseIf Month(dteBirthdate) = Month(dteToday) And DatePart(DateInterval.Day, dteBirthdate) > DatePart(DateInterval.Day, dteToday) Then

            childage = childage - 1

        End If

        lblageOutput.Text = Convert.ToString(childage)
        Me.lblageOutput.ForeColor = Color.Blue

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        dtpchildDOB.Text = Date.Today
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
