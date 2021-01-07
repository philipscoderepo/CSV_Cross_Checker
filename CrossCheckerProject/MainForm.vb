Public Class MainForm

    Dim inputFileName = ""
    Dim checkFileName = ""
    Dim input As Integer
    Dim check As Integer


    'Private Structure load
    '    Public name As String
    '    Public version As String
    'End Structure


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iOneRadioButton.Checked = True
        cOneRadioButton.Checked = True
        AIoneRadioButton.Checked = True
        CIoneRadioButton.Checked = True
        commonRadioButton.Checked = True
    End Sub

    Private Sub CheckInputList()

        checkFileName = "data\" & checkTextBox.Text & ".csv"

        Dim infile As IO.StreamReader
        Dim line As String
        Dim i As String


        infile = IO.File.OpenText(checkFileName)
        Do While infile.Peek() <> -1

            line = infile.ReadLine()

            Try
                i = Split(line)
            Catch e As Exception
                MessageBox.Show("Not enough columns", "You selected to many check columns")
                Exit Sub
            End Try
            outputListBox.Text &=
            FormattedData(i) & ControlChars.Lf
            checkinputListBox.Items.Add(line)
        Loop
        infile.Close()

    End Sub
    Private Sub LoadInputList()

        Dim ex As Boolean = False

        inputFileName = "data\" & filenameTextBox.Text & ".csv"

        Dim infile As IO.StreamReader
        Dim line As String
        Dim i As String


        infile = IO.File.OpenText(inputFileName)
        Do While infile.Peek() <> -1

            line = infile.ReadLine()

            Try
                i = Split(line)
            Catch e As Exception
                MessageBox.Show("Not enough columns", "You selected to many input columns")
                Exit Sub
            End Try

            outputListBox.Text &=
            FormattedData(i) & ControlChars.Lf
            inputListBox.Items.Add(line)
        Loop
        infile.Close()
    End Sub

    Private Function FormattedData(i As String) As String
        Return i
    End Function

    Private Function Split(s As String) As String
        Dim bits() As String
        Dim i As String


        bits = s.Split(","c)

        i = bits(CheckInputColumns())


            Return i

    End Function
    Private Sub InputRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles iOneRadioButton.CheckedChanged, iTwoRadioButton.CheckedChanged, iThreeRadioButton.CheckedChanged,
                                                                                            iFourRadioButton.CheckedChanged, iFiveRadioButton.CheckedChanged
        ClearBoxes()

    End Sub


    Private Function CheckInputColumns() As Integer
        Dim i As Integer = 0

        Select Case i = 0
            Case iOneRadioButton.Checked
                input = 0
            Case iTwoRadioButton.Checked
                input = 1
            Case iThreeRadioButton.Checked
                input = 2
            Case iFourRadioButton.Checked
                input = 3
            Case iFiveRadioButton.Checked
                input = 4
        End Select

        Return input
    End Function
    Private Sub CheckRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles cOneRadioButton.CheckedChanged, cTwoRadioButton.CheckedChanged, cThreeRadioButton.CheckedChanged,
                                                                                            cFourRadioButton.CheckedChanged, cFiveRadioButton.CheckedChanged

        ClearBoxes()

    End Sub

    Private Function CheckCheckColumns() As Integer
        Dim i As Integer = 0

        Select Case i = 0
            Case iOneRadioButton.Checked
                check = 0
            Case iTwoRadioButton.Checked
                check = 1
            Case iThreeRadioButton.Checked
                check = 2
            Case iFourRadioButton.Checked
                check = 3
            Case iFiveRadioButton.Checked
                check = 4
        End Select

        Return check
    End Function

    Private Sub CheckButtons()

        Dim i As Integer = 0

        Select Case i = 0
            Case AIoneRadioButton.Checked
                iOneRadioButton.Enabled = True
                iTwoRadioButton.Enabled = False
                iThreeRadioButton.Enabled = False
                iFourRadioButton.Enabled = False
                iFiveRadioButton.Enabled = False
            Case AItwoRadioButton.Checked
                iOneRadioButton.Enabled = True
                iTwoRadioButton.Enabled = True
                iThreeRadioButton.Enabled = False
                iFourRadioButton.Enabled = False
                iFiveRadioButton.Enabled = False
            Case AIthreeRadioButton.Checked
                iOneRadioButton.Enabled = True
                iTwoRadioButton.Enabled = True
                iThreeRadioButton.Enabled = True
                iFourRadioButton.Enabled = False
                iFiveRadioButton.Enabled = False
            Case AIfourRadioButton.Checked
                iOneRadioButton.Enabled = True
                iTwoRadioButton.Enabled = True
                iThreeRadioButton.Enabled = True
                iFourRadioButton.Enabled = True
                iFiveRadioButton.Enabled = False
            Case AIfiveRadioButton.Checked
                iOneRadioButton.Enabled = True
                iTwoRadioButton.Enabled = True
                iThreeRadioButton.Enabled = True
                iFourRadioButton.Enabled = True
                iFiveRadioButton.Enabled = True
        End Select

        Select Case i = 0
            Case CIoneRadioButton.Checked
                cOneRadioButton.Enabled = True
                cTwoRadioButton.Enabled = False
                cThreeRadioButton.Enabled = False
                cFourRadioButton.Enabled = False
                cFiveRadioButton.Enabled = False
            Case CItwoRadioButton.Checked
                cOneRadioButton.Enabled = True
                cTwoRadioButton.Enabled = True
                cThreeRadioButton.Enabled = False
                cFourRadioButton.Enabled = False
                cFiveRadioButton.Enabled = False
            Case CIthreeRadioButton.Checked
                cOneRadioButton.Enabled = True
                cTwoRadioButton.Enabled = True
                cThreeRadioButton.Enabled = True
                cFourRadioButton.Enabled = False
                cFiveRadioButton.Enabled = False
            Case CIfourRadioButton.Checked
                cOneRadioButton.Enabled = True
                cTwoRadioButton.Enabled = True
                cThreeRadioButton.Enabled = True
                cFourRadioButton.Enabled = True
                cFiveRadioButton.Enabled = False
            Case CIfiveRadioButton.Checked
                cOneRadioButton.Enabled = True
                cTwoRadioButton.Enabled = True
                cThreeRadioButton.Enabled = True
                cFourRadioButton.Enabled = True
                cFiveRadioButton.Enabled = True
        End Select
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles goButton.Click
        Dim s As String


        ClearBoxes()
        LoadInputList()
        CheckInputList()

        outputListBox.Items.Clear()


        For Each word In inputListBox.Items

            s = SplitTwo(word.ToString.ToLower)

            If commonRadioButton.Checked Then
                If MeetsCriteria(s) Then
                    outputListBox.Items.Add(word)
                End If
            ElseIf dupRadioButton.Checked Then
                If MeetsCriteria(s) Then
                Else
                    outputListBox.Items.Add(word)
                End If
            End If

        Next


        WriteWordList()
    End Sub

    Private Sub WriteWordList()
        Dim outFile As IO.StreamWriter
        Dim outputFileName
        Dim name As String

        'CreateText(): blow away existing data and start over
        'AppendText(): add data to the end of the file

        name = InputBox("File Name", "Insert File Name Here:")

        outputFileName = name & ".csv"
        outFile = IO.File.CreateText(outputFileName)


        For Each word In outputListBox.Items
            outFile.WriteLine(word)
        Next


        outFile.Close()

    End Sub

    Private Sub ClearBoxes()
        inputListBox.Items.Clear()
        checkinputListBox.Items.Clear()
        outputListBox.Items.Clear()
    End Sub

    Private Function SplitTwo(s As String) As String
        Dim bits() As String
        Dim i As String



        bits = s.Split(","c)
        i = bits(CheckCheckColumns())


        Return i
    End Function

    Private Function MeetsCriteria(s As String) As Boolean

        Dim name As String

        For Each word In checkinputListBox.Items

            name = SplitTwo(word.ToString.ToLower)
            name.ToLower()

            If dupRadioButton.Checked Then
                If s = name Then
                    Return True

                End If
            ElseIf commonRadioButton.Checked Then
                If s = name Then
                    Return True

                End If
            End If

        Next

    End Function

    Private Sub AIoneRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AIoneRadioButton.CheckedChanged, AItwoRadioButton.CheckedChanged, AIthreeRadioButton.CheckedChanged, AIfourRadioButton.CheckedChanged,
            AIfiveRadioButton.CheckedChanged, CIoneRadioButton.CheckedChanged, CItwoRadioButton.CheckedChanged, CIthreeRadioButton.CheckedChanged, CIfourRadioButton.CheckedChanged,
            CIfiveRadioButton.CheckedChanged

        CheckButtons()
    End Sub

    Private Sub _TextChanged(sender As Object, e As EventArgs) Handles filenameTextBox.TextChanged, checkTextBox.TextChanged
        ClearBoxes()
    End Sub
End Class
