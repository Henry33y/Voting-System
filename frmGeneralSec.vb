Public Class frmGeneralSec
    Private Sub frmGeneralSec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmPresidentials.Show()
    End Sub


    Private Sub picSecretary1_DoubleClick(sender As Object, e As EventArgs) Handles picSecretary1.DoubleClick
        VoteVariables.secretaryCand = 1
        Me.Hide()
        frmOrganizer.Show()
    End Sub
    Private Sub picSecretary2_DoubleClick(sender As Object, e As EventArgs) Handles picSecretary2.DoubleClick
        VoteVariables.secretaryCand = 2
        Me.Hide()
        frmOrganizer.Show()
    End Sub
    Private Sub picSecretary3_DoubleClick(sender As Object, e As EventArgs) Handles picSecretary3.DoubleClick
        VoteVariables.secretaryCand = 3
        Me.Hide()
        frmOrganizer.Show()
    End Sub

End Class