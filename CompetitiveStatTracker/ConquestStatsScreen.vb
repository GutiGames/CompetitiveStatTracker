Public Class ConquestStatsScreen
    Private Sub ConquestStatsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.ConquestWinRatio' Puede moverla o quitarla según sea necesario.
        Me.ConquestWinRatioTableAdapter.Fill(Me.SmiteDataSet.ConquestWinRatio)

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        RankedConquest.Show()
        Me.Close()

    End Sub
End Class