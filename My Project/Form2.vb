Public Class frmPresidentials

    Private Sub picPresidential1_Click(sender As Object, e As EventArgs) Handles picPresidential1.DoubleClick
        VoteVariables.presidentialCand = 1
        frmGeneralSec.Show()
        Me.Hide()
    End Sub

    Private Sub picPresidential2_Click(sender As Object, e As EventArgs) Handles picPresidential2.DoubleClick
        VoteVariables.presidentialCand = 2
        frmGeneralSec.Show()
        Me.Hide()

    End Sub

    Private Sub picPresidential3_Click(sender As Object, e As EventArgs) Handles picPresidential3.DoubleClick
        VoteVariables.presidentialCand = 3
        frmGeneralSec.Show()
        Me.Hide()
    End Sub

End Class