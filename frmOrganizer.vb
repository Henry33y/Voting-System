Public Class frmOrganizer
    Private Sub picOrganizer1_DoubleClick(sender As Object, e As EventArgs) Handles picOrganizer1.DoubleClick
        VoteVariables.organizerCand = 1
        frmSubmit.Show()
        Me.Hide()
    End Sub
    Private Sub picOrganizer2_DoubleClick(sender As Object, e As EventArgs) Handles picOrganizer2.DoubleClick
        VoteVariables.organizerCand = 2
        frmSubmit.Show()
        Me.Hide()
    End Sub
    Private Sub picOrganizer3_DoubleClick(sender As Object, e As EventArgs) Handles picOrganizer3.DoubleClick
        VoteVariables.organizerCand = 3
        frmSubmit.Show()
        Me.Hide()
    End Sub

End Class