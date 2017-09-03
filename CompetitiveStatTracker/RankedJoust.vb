Public Class RankedJoust
    Private Sub RankedJoust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)

    End Sub

    Public Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim KDA As Double
        Dim K As Integer
        Dim D As Integer
        Dim A As Integer

        K = Val(Kills.Text)
        D = Val(Deads.Text)
        A = Val(Assists.Text)

        If Val(Deads.Text = 0) Then

            KDA = (K + (A / 2))
        Else

            KDA = ((K + (A / 2)) / D)
        End If

        SmiteJoustTableAdapter.AddMatch(Tier.SelectedItem, Result.SelectedItem, Val(EloBalance.Text), Val(TotalElo.Text), Role.SelectedItem, God.SelectedItem, KDA, Que.SelectedItem, Comment.Text)
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)
    End Sub

    Public Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click

        Dim KDA As Double
        Dim K As Integer
        Dim D As Integer
        Dim A As Integer

        K = Val(Kills.Text)
        D = Val(Deads.Text)
        A = Val(Assists.Text)

        If Val(Deads.Text = 0) Then

            KDA = (K + (A / 2))
        Else

            KDA = ((K + (A / 2)) / D)
        End If

        SmiteJoustTableAdapter.EditMatch(Tier.SelectedItem, Result.SelectedItem, Val(EloBalance.Text), Val(TotalElo.Text), Role.SelectedItem, God.SelectedItem, KDA, Que.SelectedItem, Comment.Text, MatchID.Text)
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)

    End Sub

End Class