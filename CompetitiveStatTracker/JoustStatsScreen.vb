Public Class JoustStatsScreen
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        RankedJoust.Show()
        Me.Close()


    End Sub

    Private Sub JoustStatsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.JoustWinRatio' Puede moverla o quitarla según sea necesario.
        Me.JoustWinRatioTableAdapter.Fill(Me.SmiteDataSet.JoustWinRatio)

    End Sub
End Class