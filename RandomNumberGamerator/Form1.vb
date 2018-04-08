Imports System.IO
Imports System
Imports System.Text

Public Class Form1
    Public GameList() As String
    Dim filePath As String

    'Get file input, then use LoadGames to read file into array
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.FileLocation = OpenFileDialog1.FileName
            LoadGames(My.Settings.FileLocation)
        End If
    End Sub

    Dim FastClockCount As Integer = 0
    Dim SlowClockCount As Integer = 0
    Dim FastClockReps As Integer = 0
    Dim SlowClockReps As Integer = 0
    Dim firstclick As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblColor = GameText.lblText.ForeColor
        If My.Settings.FileLocation <> Nothing Then
            tmrRNG.Start()
            If firstclick Then
                firstclick = Not firstclick
            Else
                'ToDo: Change this to a setting rather than a static location
                My.Computer.FileSystem.WriteAllText("D:\RandomNumberGamerator\LastGame.txt", "Previous Game:" & vbCrLf & lblGame.Text, False)
            End If
        End If
    End Sub

    Dim flashes As Integer = 0
    Dim totalFlashes As Integer = 8
    Dim isBlack As Boolean = True
    Public lblColor As Color
    Public flashColor As Color
    Private Sub tmrFlashText_Tick(sender As Object, e As EventArgs) Handles tmrFlashText.Tick
        If isBlack Then
            lblGame.ForeColor = flashColor
            GameText.lblText.ForeColor = flashColor
        Else
            lblGame.ForeColor = Color.Black
            GameText.lblText.ForeColor = lblColor
        End If
        isBlack = Not isBlack
        flashes += 1
        If flashes = totalFlashes Then
            tmrFlashText.Stop()
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameText.Show()

        'Load previous file from settings
        If My.Settings.FileLocation <> Nothing Then
            If File.Exists(My.Settings.FileLocation) Then
                LoadGames(My.Settings.FileLocation)
            End If
        End If

        'Load flash color from settings, if not set default to red
        If My.Settings.FlashColor <> Nothing Then
            flashColor = My.Settings.FlashColor
        Else
            flashColor = Color.Red
        End If
    End Sub

    Private Sub btnChangeFont_Click(sender As Object, e As EventArgs) Handles btnChangeFont.Click
        'Open the Font Dialog for user input, wait for OK result
        FontDialog1.Font = My.Settings.UserFont
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.UserFont = FontDialog1.Font
            GameText.lblText.Font = My.Settings.UserFont
        End If
    End Sub

    Private Sub btnForecolor_Click(sender As Object, e As EventArgs) Handles btnForecolor.Click
        ColorDialog1.Color = My.Settings.ForeColor
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.ForeColor = ColorDialog1.Color
            GameText.lblText.ForeColor = My.Settings.ForeColor
        End If
    End Sub

    Private Sub btnBackcolor_Click(sender As Object, e As EventArgs) Handles btnBackcolor.Click
        ColorDialog1.Color = My.Settings.BackColor
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.BackColor = ColorDialog1.Color
            GameText.lblText.BackColor = My.Settings.BackColor
        End If
    End Sub

    Private Sub btnFlashColor_Click(sender As Object, e As EventArgs) Handles btnFlashColor.Click
        ColorDialog1.Color = My.Settings.FlashColor
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.FlashColor = ColorDialog1.Color
            flashColor = My.Settings.FlashColor
        End If
    End Sub

    'Loads games from text file
    Public Sub LoadGames(Location As String)
        lblLocation.Text = Location
        Dim comment As Boolean = False
        If System.IO.File.Exists(Location) Then
            Dim objReader As New System.IO.StreamReader(Location)
            Dim count As Integer = 0
            Dim first As Boolean = True
            Do While objReader.Peek() <> -1
                Dim temptext As String = objReader.ReadLine()
                'Ignore blank and single comment line
                If temptext <> "" Then
                    If temptext.Substring(0, 1) <> ";" Then
                        'Ignore block comments
                        If temptext = "/" Then
                            comment = Not comment
                        Else
                            If Not comment Then
                                If first Then
                                    ReDim GameList(0)
                                    first = Not first
                                Else
                                    ReDim Preserve GameList(UBound(GameList) + 1)
                                End If
                                GameList(UBound(GameList)) = temptext
                                'count += 1
                            End If
                        End If
                    End If
                End If
            Loop
            'Set label to indicated total games in GameList
            lblGamesAmount.Text = "Games: " & GameList.Length
        End If
    End Sub

    Dim goFast As Integer = 0
    Private Sub tmrRNG_Tick(sender As Object, e As EventArgs) Handles tmrRNG.Tick
        Randomize()
        Dim temparray As Integer = CInt(Int(GameList.Length * Rnd() + 1))
        lblGame.Text = GameList(temparray - 1)
        GameText.lblText.Text = lblGame.Text
        goFast += 1
        If goFast > 20 Then
            tmrRNG.Interval += 10
        End If

        If tmrRNG.Interval > 300 Then
            flashes = 0
            My.Computer.Audio.Play(My.Resources.final, AudioPlayMode.Background)
            tmrFlashText.Start()
            My.Computer.FileSystem.WriteAllText("D:\RandomNumberGamerator\RNGHistory.txt", lblGame.Text & vbCrLf, True)
            tmrRNG.Interval = 25
            goFast = 0
            tmrRNG.Stop()

            For X As Integer = temparray To GameList.Length - 1
                GameList(X - 1) = GameList(X)
            Next
            ReDim Preserve GameList(UBound(GameList) - 1)
            lblGamesAmount.Text = "Games: " & GameList.Length
        End If
    End Sub
End Class
