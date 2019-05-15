Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrades.SelectedIndex = 0

    End Sub

    Private Sub lstGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrades.SelectedIndexChanged
        lstNames.Items.Clear()
        lblNumber.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim selectedLetter As String = lstGrades.Text
        Dim inFile As IO.StreamReader
        Dim strNames As String
        Dim letterGrade As Char
        Dim count As Integer

        If IO.File.Exists("NamesAndGrades.txt") Then
            inFile = IO.File.OpenText("NamesAndGrades.txt")
            Do Until inFile.Peek = -1
                ' Store name
                strNames = inFile.ReadLine
                ' Store letter grade
                letterGrade = inFile.ReadLine
                ' Check if selected letter and letter grade in inFile equal
                ' if they are equal then add name to list box
                If selectedLetter = letterGrade Then
                    count += 1
                    lstNames.Items.Add(strNames)
                    lblNumber.Text = count
                End If
            Loop
        End If
    End Sub
End Class
