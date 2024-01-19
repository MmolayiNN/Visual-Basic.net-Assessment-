Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        ' List to store words
        Dim wordsList As New List(Of String)
    End Sub
    ' Event handler for Add button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the word from the TextBox
        Dim newWord As String = TextBox1.Text.Trim()

        ' Check if a value has been entered
        If newWord <> "" Then
            ' Check if the word already exists in the list
            If Not ListBox1.Items.Contains(newWord) Then
                ' Add the word to the list
                ListBox1.Items.Add(newWord)

                ' Update the ListBox
                UpdateListBox()

                ' Clear the TextBox
                TextBox1.Clear()
            Else
                MessageBox.Show("Word already exists in the list.", "Duplicate Word", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter a word.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event handler for ListBox selection change
    Private Sub lstWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Update the Label with the selected word
        UpdateLabel()
    End Sub

    ' Event handler for RadioButton clicks
    Private Sub RadioButton_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        ' Update the Label based on the selected RadioButton
        UpdateLabel()
    End Sub

    ' Update the ListBox with the current ListBox

    Private Sub UpdateListBox()
        ' Create a new list and add items from ListBox1
        Dim newList As New List(Of Object)
        newList.AddRange(ListBox1.Items.Cast(Of Object))

        ' Clear and update ListBox1 with the items from the new list
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(newList.ToArray())
    End Sub


    ' Update the Label based on the selected word and RadioButton settings
    Private Sub UpdateLabel()
        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedWord As String = ListBox1.SelectedItem.ToString()

            ' Apply RadioButton settings to the Label text
            If RadioButton1.Checked Then
                selectedWord = selectedWord.ToUpper()
            ElseIf RadioButton1.Checked Then
                selectedWord = selectedWord.ToLower()
            End If

            ' Apply color settings to the Label text
            If RadioButton2.Checked Then
                Label4.ForeColor = Color.Purple

            ElseIf RadioButton4.Checked Then
                Label4.ForeColor = Color.Blue
            End If

            ' Update the Label text
            Label4.Text = selectedWord
        End If
    End Sub



End Class




