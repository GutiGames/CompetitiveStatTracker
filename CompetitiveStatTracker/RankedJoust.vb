Public Class RankedJoust
    Private Sub RankedJoust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmiteJoustDataSet.SmiteJoust' table. You can move, or remove it, as needed.
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        SmiteJoustTableAdapter.AddMatch(Result.Text, EloBalance.Text, TotalElo.Text)
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click

        SmiteJoustTableAdapter.EditMatch(Result.Text, EloBalance.Text, Val(TotalElo.Text), Val(MatchID.Text))
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteJoustDataSet.SmiteJoust)
    End Sub


End Class