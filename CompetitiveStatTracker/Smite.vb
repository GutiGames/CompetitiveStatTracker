﻿Public Class SmiteMenu
    Private Sub Conquest_Click(sender As Object, e As EventArgs) Handles Conquest.Click

        Me.Hide()
    End Sub

    Private Sub Joust_Click(sender As Object, e As EventArgs) Handles Joust.Click
        RankedJoust.Show()
        Me.Hide()
    End Sub

    Private Sub Duel_Click(sender As Object, e As EventArgs) Handles Duel.Click

        Me.Hide()
    End Sub

End Class