Public Class DuelStatScreen
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        RankedDuel.Show()
        Me.Hide()
    End Sub

    Private Sub DuelStatScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.DuelWinRatio' Puede moverla o quitarla según sea necesario.
        Me.DuelWinRatioTableAdapter.Fill(Me.SmiteDataSet.DuelWinRatio)

    End Sub
End Class