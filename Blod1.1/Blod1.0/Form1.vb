Imports MySql.Data.MySqlClient



Public Class Form1
<<<<<<< HEAD

=======
    Private tilkobling As MySqlConnection
>>>>>>> origin/master

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '1 = giver
        '2 = ansatt


        Try
            'Spørring for givere
            Dim sqlSporring = "SELECT * from Bruker where type =1 and f_navn='" & TextBox1.Text.Replace("'", "\'") & "' and passord='" & TextBox2.Text.Replace("'", "\'") & "'"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            'Spørring for ansatte
            Dim sqlSporring2 = "SELECT * from Bruker where type =2 and f_navn='" & TextBox1.Text.Replace("'", "\'") & "' and passord='" & TextBox2.Text.Replace("'", "\'") & "'"
            Dim sql2 As New MySqlCommand(sqlSporring2, tilkobling)

            Dim da As New MySqlDataAdapter
            Dim da2 As New MySqlDataAdapter
            Dim interTabell As New DataTable
            Dim interTabell2 As New DataTable
            da.SelectCommand = sql
            da.Fill(interTabell)
            da2.SelectCommand = sql2
            da2.Fill(interTabell2)


            'Innlogging for givere
            If interTabell.Rows.Count > 0 Then
                MsgBox("Logget på")
                Form2.Show()
                Me.Visible = False

                'Innlogging for ansatte
            ElseIf interTabell2.Rows.Count > 0 Then
                MsgBox("Logget på")
                Form3.Show()
                Me.Visible = False
            Else
                MsgBox("Feil brukernavn eller passord")
            End If
        Catch ex As MySqlException
            MsgBox("En feil har oppstått" & ex.Message)
        End Try
        'resetter passordfeltet
        TextBox2.Text = ""

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

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")
        tilkobling.Open()

    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
