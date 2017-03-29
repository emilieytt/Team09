Imports MySql.Data.MySqlClient
Public Class Form1
    Private brukernavn As String = "g_oops_09"
    Private passord As String = "IxKu1h4H"
    Private databasenavn As String
    Private tjenernavn As String = "mysql.stud.iie.ntnu.no"

    Private tilkobling As New MySqlConnection
    Private connstring As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter bakgrunnsfarge til hvit
        Me.BackColor = Color.White

        'Kobler programmet opp mot databasen
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" &
                                             "Database=g_oops_09;" &
                                             "Uid=g_oops_09;" &
                                             "Pwd=IxKu1h4H;")

        'Gjør det umulig å fylle inn mer enn 8 tall ved utfyllingen av telefonnummer. 
        tlf_nr.MaxLength = 8
        Post_nr.MaxLength = 4
        'Setter en grense på hvor lang adressen kan være 
        Adresse.MaxLength = 30
        ' Fjerner knappen for å fullføre registreringen 
        nyGiverBtn.Hide()
        'Når registreringen starter blir bruker automatisk satt til å velge kjonn først 
        kjonn.Focus()
    End Sub

    'Gir textboxene for tlf og postnr restriksjoner slik at det ikke går an å fylle inn bokstaver 
    Private Sub tlfnrOgpostnr(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tlf_nr.KeyPress, Post_nr.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'setter opp spørringen opp mot databasen 
    Private Function sporring(ByVal sql As String) As DataTable

        Dim tabell As New DataTable
        Try
            tilkobling.Open()

            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter

            da.SelectCommand = kommando
            da.Fill(tabell)

            tilkobling.Close()

        Catch ex As Exception
            MessageBox.Show("En feil har oppstått: " & ex.Message)
            tilkobling.Close()
        End Try

        Return tabell
    End Function

    ' Funksjon som sjekker om alle tekstfeltene er fylt ut
    Private Function Validerskjema() As Boolean
        Dim allTextBoxes() As TextBox = {Fornavn, Etternavn, tlf_nr, Epost, Adresse, Post_nr, Passord1, Passord2}      ' add all your textboxes here  

        Dim TB As TextBox = allTextBoxes.Where(Function(f) f.Text = "").FirstOrDefault

        If TB IsNot Nothing Then

            TB.Select()
            Return False
        Else
            ' All set to go!  
            Return True
        End If
    End Function


    'Sjekker om skjemaet er klart for å sende inn godkjent bruker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Validerskjema() And ValidateMyControls() = True Then
            nyGiverBtn.Show()
        Else
            MsgBox("Registreringen er ikke komplett, venligst fyll ut alle ruter!")
        End If

    End Sub

    'VALIDERING AV SKJEMA 
    ''Validering av comboboxene 
    'Validering av kjønn
    Private Sub validerkjønn() Handles kjonn.Validating
        If kjonn.SelectedItem = "" Then
            Me.Errorkjonn.SetError(kjonn, "Venligst velg kjønn")
            kjonn.Select()
        Else
            Errorkjonn.SetError(kjonn, "")
            Fornavn.Select()
        End If
    End Sub
    ' Sjekker om dag er valgt
    Private Sub validerdag() Handles Dag.Validating
        If Dag.SelectedItem = "" Then
            Me.Errordag.SetError(Dag, "Venligst velg kjønn")
            Dag.Select()
        Else
            Errordag.SetError(Dag, "")
        End If
    End Sub
    'Sjekker om måned er valgt 
    Private Sub validermåned() Handles Måned.Validating
        If Måned.SelectedItem = "" Then
            Me.Errormåned.SetError(Måned, "Venligst velg måned")
            Måned.Select()
        Else
            Errormåned.SetError(Måned, "")

        End If
    End Sub
    'Sjekker om år er valgt 
    Private Sub validerår() Handles År.Validating
        If År.SelectedItem = "" Then
            Me.Errorår.SetError(År, "Venligst velg kjønn")
            År.Select()
        Else
            Errorår.SetError(År, "")

        End If
    End Sub

    ' Validering av FORNAVN
    Private Function Gyldigfnavn(ByVal fnavn As String, ByRef errorMessage As String) As Boolean
        ' Bekrefter at det er skrevet noe tekst i tekstboksen og skrevet inn nok bokstaver
        If Fornavn.Text.Length = 0 Then
            errorMessage = "Vennligst skriv inn ditt fornavn."
            Return False
        ElseIf Fornavn.Text.Length > 1 Then
            Return True
        End If
        Return False
    End Function

    Private Sub Fornavn_Validating(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles Fornavn.Validating

        Dim errorMsg As String = ""
        If Not Gyldigfnavn(Fornavn.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            Fornavn.Select(0, Fornavn.Text.Length)

            ' Setter errorprovideren ved siden av tekstboksen 
            Me.ErrorFornavn.SetError(Fornavn, errorMsg)
        End If
    End Sub

    Private Sub Fornavn_Validated(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles Fornavn.Validated
        'Hvis alle kravene er oppfylt, fjernes errorprovideren
        ErrorFornavn.SetError(Fornavn, "")
    End Sub

    'Validering av ETTERNAVN
    Private Function GyldigEnavn(ByVal fnavn As String, ByRef errorMessage As String) As Boolean
        ' Bekrefter at det er skrevet noe tekst i tekstboksen og skrevet inn nok bokstaver
        If Etternavn.Text.Length = 0 Then
            errorMessage = "Vennligst skriv inn ditt etternavn "
            Return False
        ElseIf Etternavn.Text.Length >= 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub Etternavn_Validating(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles Etternavn.Validating

        Dim errorMsg As String = ""
        If Not GyldigEnavn(Etternavn.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            Etternavn.Select(0, Etternavn.Text.Length)

            ' Setter errorprovideren ved siden av tekstboksen 
            Me.ErrorEtternavn.SetError(Etternavn, errorMsg)
        End If
    End Sub

    Private Sub Etternavn_Validated(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles Etternavn.Validated
        'Hvis alle kravene er oppfylt, fjernes errorprovideren
        ErrorEtternavn.SetError(Etternavn, "")
    End Sub


    'Validerer fødselsdatoen som er valgt 
    Private Function ValidateMyControls() As Boolean

        Dim årstall = Now.Date.Year

        Dim allComboBoxes() As ComboBox = {Dag, Måned, År} ' Legger til alle combobokxene her

        Dim emptyCB As ComboBox = allComboBoxes.Where(Function(f) f.SelectedIndex = -1).FirstOrDefault
        'Sjekker om comoboxene er blitt valgt og fått en verdi
        If emptyCB IsNot Nothing Then
            emptyCB.Select() ' MessageBox.Show("Vennligst velg " & emptyCB.Name)
            Return False
        ElseIf årstall - År.Text <= 18 Then
            MessageBox.Show("Du må være 18 år for å kunne registrere deg som blodgiver")
            'Me.Close()
        Else
            ' Dersom alle krav er oppfylt, lages det en tekststreng som er klar til å sendes inn til databasen
            Dim gyldigfødseldato As String = (År.Text + "/" + Måned.Text + "/" + Dag.Text)

        End If
        Return True


    End Function

    'Validering av EPOST
    Private Function GyldigEpost(ByVal Epostadresse As String, ByRef errorMessage As String) As Boolean
        ' sjekker om det er tekst i tekstfeltet 
        If Epost.Text.Length = 0 Then
            errorMessage = "Venligst fyll in epost-adressen din."
            Return False

        End If

        ' Sjekker om eposten inneholder @ og . og at de er på riktig plass i forhold til hverandre 
        If Epostadresse.IndexOf("@") > -1 Then
            If (Epostadresse.IndexOf(".", Epostadresse.IndexOf("@")) > Epostadresse.IndexOf("@")) Then
                errorMessage = ""
                Return True
            End If
        End If

        errorMessage = "Eposten som er skrevet inn passer ikke til kravene som stilles" + ControlChars.Cr +
          "F.eks'Noen@eksempel.com' "
        Return False
    End Function

    Private Sub Epost_Validating(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles Epost.Validating

        Dim errorMsg As String = ""
        If Not GyldigEpost(Epost.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            Epost.Select(0, Epost.Text.Length)

            'Setter errorprovideren ved siden av tekstfeltet og viser feilen
            Me.ErrorEpost.SetError(Epost, errorMsg)
        End If
    End Sub


    Private Sub Epost_Validated(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles Epost.Validated
        'Hvis alle kravene er tilfredsstilt, fjernes errorprovideren
        ErrorEpost.SetError(Epost, "")
    End Sub

    'Validering av TELEFON NUMMER
    Private Function Gyldigtlf(ByVal tlfnr As String, ByRef errorMessage As String) As Boolean
        'Sjekker om det er tekst i tekstfeltet 

        If tlf_nr.Text.Length = 0 Then
            errorMessage = "Vennligst fyll inn telefonnummeret ditt."
            Return False
        ElseIf tlf_nr.Text.Length = 8 Then
            Return True
        End If
        Return False
    End Function

    Private Sub tlfnr_validering(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles tlf_nr.Validating

        Dim errorMsg As String = ""
        If Not Gyldigtlf(tlf_nr.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            tlf_nr.Select(0, tlf_nr.Text.Length)

            ' Setter errorprovideren ved siden av tekstfeltet og viser feilen
            Me.ErrorTelefon.SetError(tlf_nr, errorMsg)
        End If
    End Sub

    Private Sub tlfnr_validert(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles tlf_nr.Validated
        ' Hvis alle kravene er tilfredsstilt, fjernes errorprovideren
        ErrorTelefon.SetError(tlf_nr, "")
    End Sub


    Private Function Gyldigadresse(ByVal adres As String, ByRef errorMessage As String) As Boolean
        ' Sjekker om det er tekst i tekstfeltet 

        If Adresse.Text.Length = 0 Then
            errorMessage = "Vennligst fyll inn adresse."
            Return False
        ElseIf Adresse.Text.Length > 3 Then
            Return True
        End If
        Return False
    End Function

    Private Sub adresse_validering(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles Adresse.Validating

        Dim errorMsg As String = ""
        If Not Gyldigadresse(Adresse.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            tlf_nr.Select(0, Adresse.Text.Length)

            'Setter errorprovideren ved siden av tekstfeltet og viser feilen
            Me.ErrorAdresse.SetError(Adresse, errorMsg)
        End If
    End Sub

    Private Sub adresse_validert(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles Adresse.Validated
        'Hvis alle kravene er tilfredsstilt, fjernes errorprovideren
        ErrorAdresse.SetError(Adresse, "")
    End Sub

    'Validering av POSTNUMMER

    Private Function Gyldigpostnr(ByVal postnr As String, ByRef errorMessage As String) As Boolean
        'Sjekker om det er tekst i tekstfeltet 

        If Post_nr.Text.Length < 3 Then
            errorMessage = "Vennligst fyll inn postnummer."
            Return False
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub postnr_validering(ByVal sender As Object,
    ByVal e As System.ComponentModel.CancelEventArgs) Handles Post_nr.Validating

        Dim errorMsg As String = ""
        If Not Gyldigpostnr(Post_nr.Text, errorMsg) Then
            'Kansellerer handlingen og tekstboksen blir valgt slik at brukeren må endre til et gyldig navn 
            e.Cancel = True
            Post_nr.Select(0, Post_nr.Text.Length)

            'Setter errorprovideren vedsiden av tekstfeltet og viser feilen
            Me.ErrorPostnr.SetError(Post_nr, errorMsg)
        End If
    End Sub

    Private Sub postnr_validert(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles Post_nr.Validated
        'Hvis alle kravene er tilfredsstilt, fjernes errorprovideren
        ErrorPostnr.SetError(Post_nr, "")
    End Sub


    'VALIDERING AV PASSORD
    ''' <summary>Determines if a password is sufficiently complex.</summary>
    ''' <param name="pwd">Password to validate</param>
    ''' <param name="minLength">Minimum number of password characters.</param>
    ''' <param name="numUpper">Minimum number of uppercase characters.</param>
    ''' <param name="numLower">Minimum number of lowercase characters.</param>
    ''' <param name="numNumbers">Minimum number of numeric characters.</param>
    ''' <returns>True if the password is sufficiently complex.</returns>

    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 1,
        Optional ByVal numLower As Integer = 1,
        Optional ByVal numNumbers As Integer = 2) As Boolean

        ' Erstatter [A-Z] med  \p{Lu}, for å godta Unicode uppercase letters
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")

        ' Sjekker lengde.
        If Len(pwd) < minLength Then Return False
        'Sjekker om miminmumskravet er nådd 
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False

        ' Kravene er oppfylt 
        Return True
    End Function

    Private Sub TestValidatePassword(ByVal sender As Object,
                                     ByVal e As System.ComponentModel.CancelEventArgs
                                     ) Handles Passord1.Validating

        Dim password As String = Passord1.Text
        Dim errormsg As String = ""

        If ValidatePassword(password) = False Then
            Me.ErrorPassord.SetError(Passord1, "Passordet må inneholde minst 8 tegn, store og småbokstaver og to tall.")
            e.Cancel = True
            Passord1.Select()
        ElseIf ValidatePassword(password) = True Then
            ErrorPassord.SetError(Passord1, "")

        End If

    End Sub

    Private Sub sammenlignpassord(ByVal sender As Object,
                                     ByVal e As System.ComponentModel.CancelEventArgs
                                     ) Handles Passord2.Validating
        'Sjekker om passordene er lik 
        If Passord2.Text = Passord1.Text Then
            'Fjerner errorprovideren om passordene er lik
            ErrorPassord2.SetError(Passord2, "")
        ElseIf Passord2.Text IsNot Passord1.Text Then
            'Hvis passordene ikke er lik, settes errorprovideren ved siden av tekstfeltet
            Me.ErrorPassord2.SetError(Passord2, "Passordet stemmer ikke med det første du skrev inn, vennligst gjenta det samme passordet!")
        End If
    End Sub

    'Gir brukeren muligheten til å se hva de har skrevet inn som passord
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Passord1.PasswordChar = ""
        Passord2.PasswordChar = ""
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Passord1.PasswordChar = "*"
        Passord2.PasswordChar = "*"
    End Sub

    'Sender godkjent bruker til databasen
    Private Sub nyGiverBtn_Click(sender As Object, e As EventArgs) Handles nyGiverBtn.Click


        Dim valgt_kjonn = 0
        If kjonn.SelectedItem = "Kvinne" Then
            valgt_kjonn = "1"
        End If

        Try
            sporring("INSERT INTO Bruker (bruker_type, epost_godtatt, f_navn ,e_navn ,fodselsdato ,tlf_nr ,epost ,adresse , postnr,kjonn, passord)
VALUES (1,1 ,'" & Fornavn.Text & "','" & Etternavn.Text & "','" & År.Text + "/" + Måned.Text + "/" + Dag.Text & "','" & tlf_nr.Text & "','" & Epost.Text & "','" & Adresse.Text & "','" & Post_nr.Text & "','" & valgt_kjonn & "','" & Passord1.Text & "')")

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    'Gir brukeren muligheten til å se hvilke krav som stilles til passord
    Private Sub Passordtips(sender As Object, e As EventArgs) Handles label14.MouseHover
        ToolTip1.Active = True
        ToolTip1.SetToolTip(Me.label14, "Passordet må inneholde minst en stor bokstav[A-Å]," & vbCrLf & "minst en liten bokstav[a-å] ogto tall [0-9-]")
    End Sub
End Class

