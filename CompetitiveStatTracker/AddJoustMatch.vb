Public Class AddJoustMatch
    Private Sub AddJoustMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.Gods' Puede moverla o quitarla según sea necesario.
        Me.GodsTableAdapter.Fill(Me.SmiteDataSet.Gods)

    End Sub

    Private Sub God1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God1.SelectedIndexChanged

        Dim selV As Integer

        selV = God1.SelectedValue - 1

        If selV = 0 Then

            PictureBox1.Image = My.Resources.MyResources.Uno
        ElseIf selV = 1 Then

            PictureBox1.Image = My.Resources.MyResources.Dos
        Else

            PictureBox1.Image = My.Resources.MyResources.Vacio
        End If



    End Sub
End Class