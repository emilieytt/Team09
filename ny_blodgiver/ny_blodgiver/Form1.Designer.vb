<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Fornavn = New System.Windows.Forms.TextBox()
        Me.Etternavn = New System.Windows.Forms.TextBox()
        Me.tlf_nr = New System.Windows.Forms.TextBox()
        Me.Epost = New System.Windows.Forms.TextBox()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.Post_nr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.nyGiverBtn = New System.Windows.Forms.Button()
        Me.Passord1 = New System.Windows.Forms.TextBox()
        Me.Passord2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.kjonn = New System.Windows.Forms.ComboBox()
        Me.ErrorEpost = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFornavn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorEtternavn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFodslesnr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorTelefon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorAdresse = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPostnr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPassord = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPassord2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Dag = New System.Windows.Forms.ComboBox()
        Me.Måned = New System.Windows.Forms.ComboBox()
        Me.År = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.label14 = New System.Windows.Forms.Label()
        Me.Errorkjonn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errordag = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errormåned = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errorår = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorEpost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFornavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEtternavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFodslesnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTelefon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPostnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPassord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPassord2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errorkjonn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errordag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errormåned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errorår, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fornavn
        '
        Me.Fornavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornavn.Location = New System.Drawing.Point(1173, 106)
        Me.Fornavn.Margin = New System.Windows.Forms.Padding(4)
        Me.Fornavn.Name = "Fornavn"
        Me.Fornavn.Size = New System.Drawing.Size(511, 34)
        Me.Fornavn.TabIndex = 0
        Me.Fornavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Etternavn
        '
        Me.Etternavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etternavn.Location = New System.Drawing.Point(1171, 162)
        Me.Etternavn.Margin = New System.Windows.Forms.Padding(4)
        Me.Etternavn.Name = "Etternavn"
        Me.Etternavn.Size = New System.Drawing.Size(513, 34)
        Me.Etternavn.TabIndex = 1
        Me.Etternavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tlf_nr
        '
        Me.tlf_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlf_nr.Location = New System.Drawing.Point(1175, 291)
        Me.tlf_nr.Margin = New System.Windows.Forms.Padding(4)
        Me.tlf_nr.Name = "tlf_nr"
        Me.tlf_nr.Size = New System.Drawing.Size(511, 34)
        Me.tlf_nr.TabIndex = 3
        Me.tlf_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Epost
        '
        Me.Epost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Epost.Location = New System.Drawing.Point(1175, 352)
        Me.Epost.Margin = New System.Windows.Forms.Padding(4)
        Me.Epost.Name = "Epost"
        Me.Epost.Size = New System.Drawing.Size(511, 34)
        Me.Epost.TabIndex = 4
        Me.Epost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Adresse
        '
        Me.Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adresse.Location = New System.Drawing.Point(1175, 411)
        Me.Adresse.Margin = New System.Windows.Forms.Padding(4)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(511, 34)
        Me.Adresse.TabIndex = 5
        Me.Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Post_nr
        '
        Me.Post_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Post_nr.Location = New System.Drawing.Point(1175, 471)
        Me.Post_nr.Margin = New System.Windows.Forms.Padding(4)
        Me.Post_nr.Name = "Post_nr"
        Me.Post_nr.Size = New System.Drawing.Size(511, 34)
        Me.Post_nr.TabIndex = 6
        Me.Post_nr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(943, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fornavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(943, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Etternavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(945, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fødselsdato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(945, 300)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mobilnummer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(945, 359)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Epost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(945, 418)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Adresse"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(945, 477)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Postnummer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(998, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 44)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Ny blodgiver"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1219, 858)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(169, 25)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Avbryt registrering"
        '
        'nyGiverBtn
        '
        Me.nyGiverBtn.Location = New System.Drawing.Point(155, 207)
        Me.nyGiverBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.nyGiverBtn.Name = "nyGiverBtn"
        Me.nyGiverBtn.Size = New System.Drawing.Size(570, 405)
        Me.nyGiverBtn.TabIndex = 21
        Me.nyGiverBtn.Text = "Fullfør Registrering"
        Me.nyGiverBtn.UseVisualStyleBackColor = True
        '
        'Passord1
        '
        Me.Passord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passord1.Location = New System.Drawing.Point(1173, 572)
        Me.Passord1.Margin = New System.Windows.Forms.Padding(4)
        Me.Passord1.Name = "Passord1"
        Me.Passord1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passord1.Size = New System.Drawing.Size(511, 34)
        Me.Passord1.TabIndex = 23
        Me.Passord1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passord2
        '
        Me.Passord2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passord2.Location = New System.Drawing.Point(1173, 620)
        Me.Passord2.Margin = New System.Windows.Forms.Padding(4)
        Me.Passord2.Name = "Passord2"
        Me.Passord2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passord2.Size = New System.Drawing.Size(511, 34)
        Me.Passord2.TabIndex = 24
        Me.Passord2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(943, 579)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 29)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Passord"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(943, 627)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 29)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Gjenta passord"
        '
        'kjonn
        '
        Me.kjonn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kjonn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kjonn.FormattingEnabled = True
        Me.kjonn.Items.AddRange(New Object() {"Kvinne", "Mann"})
        Me.kjonn.Location = New System.Drawing.Point(1348, 41)
        Me.kjonn.Margin = New System.Windows.Forms.Padding(4)
        Me.kjonn.Name = "kjonn"
        Me.kjonn.Size = New System.Drawing.Size(182, 40)
        Me.kjonn.TabIndex = 27
        '
        'ErrorEpost
        '
        Me.ErrorEpost.ContainerControl = Me
        '
        'ErrorFornavn
        '
        Me.ErrorFornavn.ContainerControl = Me
        '
        'ErrorEtternavn
        '
        Me.ErrorEtternavn.ContainerControl = Me
        '
        'ErrorFodslesnr
        '
        Me.ErrorFodslesnr.ContainerControl = Me
        '
        'ErrorTelefon
        '
        Me.ErrorTelefon.ContainerControl = Me
        '
        'ErrorAdresse
        '
        Me.ErrorAdresse.ContainerControl = Me
        '
        'ErrorPostnr
        '
        Me.ErrorPostnr.ContainerControl = Me
        '
        'ErrorPassord
        '
        Me.ErrorPassord.ContainerControl = Me
        '
        'ErrorPassord2
        '
        Me.ErrorPassord2.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Dag
        '
        Me.Dag.AccessibleName = ""
        Me.Dag.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Dag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dag.FormattingEnabled = True
        Me.Dag.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Dag.Location = New System.Drawing.Point(1175, 238)
        Me.Dag.Margin = New System.Windows.Forms.Padding(6)
        Me.Dag.Name = "Dag"
        Me.Dag.Size = New System.Drawing.Size(124, 37)
        Me.Dag.TabIndex = 31
        '
        'Måned
        '
        Me.Måned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Måned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Måned.FormattingEnabled = True
        Me.Måned.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Måned.Location = New System.Drawing.Point(1348, 238)
        Me.Måned.Margin = New System.Windows.Forms.Padding(6)
        Me.Måned.Name = "Måned"
        Me.Måned.Size = New System.Drawing.Size(141, 37)
        Me.Måned.TabIndex = 32
        '
        'År
        '
        Me.År.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.År.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.År.FormatString = "d"
        Me.År.FormattingEnabled = True
        Me.År.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900"})
        Me.År.Location = New System.Drawing.Point(1521, 238)
        Me.År.Margin = New System.Windows.Forms.Padding(6)
        Me.År.Name = "År"
        Me.År.Size = New System.Drawing.Size(163, 37)
        Me.År.TabIndex = 33
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(1224, 680)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(164, 33)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Vis passord"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(1445, 680)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(184, 33)
        Me.RadioButton2.TabIndex = 37
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Skjul passord"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1170, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 25)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Dag"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1516, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 25)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "År"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1333, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 25)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Måned"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(1223, 763)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(325, 84)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Neste"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(1691, 572)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(28, 31)
        Me.label14.TabIndex = 42
        Me.label14.Text = "?"
        '
        'Errorkjonn
        '
        Me.Errorkjonn.ContainerControl = Me
        '
        'Errordag
        '
        Me.Errordag.ContainerControl = Me
        '
        'Errormåned
        '
        Me.Errormåned.ContainerControl = Me
        '
        'Errorår
        '
        Me.Errorår.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1990, 935)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.År)
        Me.Controls.Add(Me.Måned)
        Me.Controls.Add(Me.Dag)
        Me.Controls.Add(Me.kjonn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Passord2)
        Me.Controls.Add(Me.Passord1)
        Me.Controls.Add(Me.nyGiverBtn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Post_nr)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.Epost)
        Me.Controls.Add(Me.tlf_nr)
        Me.Controls.Add(Me.Etternavn)
        Me.Controls.Add(Me.Fornavn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorEpost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFornavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEtternavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFodslesnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTelefon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorAdresse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPostnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPassord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPassord2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errorkjonn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errordag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errormåned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errorår, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fornavn As TextBox
    Friend WithEvents Etternavn As TextBox
    Friend WithEvents tlf_nr As TextBox
    Friend WithEvents Epost As TextBox
    Friend WithEvents Adresse As TextBox
    Friend WithEvents Post_nr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents nyGiverBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Passord1 As TextBox
    Friend WithEvents Passord2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents kjonn As ComboBox
    Friend WithEvents ErrorEpost As ErrorProvider
    Friend WithEvents ErrorFornavn As ErrorProvider
    Friend WithEvents ErrorEtternavn As ErrorProvider
    Friend WithEvents ErrorFodslesnr As ErrorProvider
    Friend WithEvents ErrorTelefon As ErrorProvider
    Friend WithEvents ErrorAdresse As ErrorProvider
    Friend WithEvents ErrorPostnr As ErrorProvider
    Friend WithEvents ErrorPassord As ErrorProvider
    Friend WithEvents ErrorPassord2 As ErrorProvider
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents År As ComboBox
    Friend WithEvents Måned As ComboBox
    Friend WithEvents Dag As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents label14 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Errorkjonn As ErrorProvider
    Friend WithEvents Errordag As ErrorProvider
    Friend WithEvents Errormåned As ErrorProvider
    Friend WithEvents Errorår As ErrorProvider
End Class
