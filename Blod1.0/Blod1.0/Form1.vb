Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")

        Try
            tilkobling.Open()
            MsgBox("Serveren er tilkoblet.")

            Dim brukernavn As String = TextBox1.Text
            Dim passord As String = TextBox2.Text
            Dim sql As New MySqlCommand("SELECT person_nr, passord FROM Bruker", tilkobling)
            Dim da As New MySqlDataAdapter
            If brukernavn Then
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    Private Sub AvsluttToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AvsluttToolStripMenuItem1.Click
        'Avslutter programmet
        Me.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        'Restarter programmet
        Application.Restart()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
