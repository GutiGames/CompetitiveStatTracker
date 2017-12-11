Public Class JoustStatsScreen
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click

        RankedJoust.Show()
        Me.Close()


    End Sub

    Private Sub JoustStatsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.WinRate' Puede moverla o quitarla según sea necesario.
        Me.WinRateTableAdapter.Fill(Me.SmiteDataSet.WinRate)

    End Sub
End Class