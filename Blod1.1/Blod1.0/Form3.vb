Public Class Form3
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub AvsluttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem.Click
        'Avslutter programmet
        Me.Close()
    End Sub
End Class