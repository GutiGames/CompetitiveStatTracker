Public Class RankedJoust
    Private Sub RankedJoust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.QueTypes' Puede moverla o quitarla según sea necesario.
        Me.QueTypesTableAdapter.Fill(Me.SmiteDataSet.QueTypes)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.Teams' Puede moverla o quitarla según sea necesario.
        Me.TeamsTableAdapter.Fill(Me.SmiteDataSet.Teams)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.Tiers' Puede moverla o quitarla según sea necesario.
        Me.TiersTableAdapter.Fill(Me.SmiteDataSet.Tiers)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.JoustMatches' Puede moverla o quitarla según sea necesario.
        Me.JoustMatchesTableAdapter.Fill(Me.SmiteDataSet.JoustMatches)

    End Sub

    Public Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim KDA As Single
        Dim K As Integer = Val(Kills.Text)
        Dim D As Integer = Val(Deaths.Text)
        Dim A As Integer = Val(Assists.Text)

        If D = 0 Then

            KDA = ((A / 2) + K)
        Else

            KDA = ((A / 2) + K) / D
        End If


        JoustMatchesTableAdapter.InsertJoustMatch(Tier.SelectedValue, Winner.SelectedValue, Que.SelectedValue, Val(Kills.Text), Val(Deaths.Text), Val(Assists.Text), KDA, Comment.Text)
        JoustMatchesTableAdapter.InsertQuery(Tier.SelectedValue)

        Me.JoustMatchesTableAdapter.Fill(Me.SmiteDataSet.JoustMatches)

    End Sub

    Private Sub siguiente_Click(sender As Object, e As EventArgs) Handles siguiente.Click

        AddJoustMatch.Show()
        Me.Hide()


    End Sub
End Class