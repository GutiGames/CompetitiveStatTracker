Imports System.Data.OleDb

Public Class RankedJoust

    Private Sub RankedJoust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmiteDataSet.SmiteJoust' table. You can move, or remove it, as needed.
        Me.SmiteJoustTableAdapter.Fill(Me.SmiteDataSet.SmiteJoust)


    End Sub
End Class