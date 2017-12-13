Public Class JoustStatsScreen
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click

        RankedJoust.Show()
        Me.Close()


    End Sub

    Private Sub JoustStatsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmiteDataSet.WinRatio' table. You can move, or remove it, as needed.
        Me.WinRatioTableAdapter.Fill(Me.SmiteDataSet.WinRatio)
        'TODO: This line of code loads data into the 'SmiteDataSet.WinRatio' table. You can move, or remove it, as needed.
        Me.WinRatioTableAdapter.Fill(Me.SmiteDataSet.WinRatio)

    End Sub
End Class