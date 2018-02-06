Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decClassATickets As Decimal
        Dim decClassBTickets As Decimal
        Dim decClassCTickets As Decimal
        Dim decTotal As Decimal

        Try
            decClassATickets = CDec(txtClassA.Text) * 15
            lblClassA.Text = decClassATickets.ToString("c")

            decClassBTickets = CDec(txtClassB.Text) * 12
            lblClassB.Text = decClassBTickets.ToString("c")

            decClassCTickets = CDec(txtClassC.Text) * 9
            lblClassC.Text = decClassCTickets.ToString("c")

            decTotal = decClassATickets + decClassBTickets +
                decClassCTickets
            lblTotal.Text = decTotal.ToString("c")

            lblTotal.BackColor = Color.Blue
            lblTotal.ForeColor = Color.White

        Catch
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotal.Text = String.Empty

        lblTotal.BackColor = SystemColors.Control
        lblTotal.ForeColor = SystemColors.ControlText

        txtClassA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class