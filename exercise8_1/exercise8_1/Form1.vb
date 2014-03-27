Public Class Form1
    Dim hashTable As New Hashtable()
    Dim x

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MsgBox("Please Enter Name")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hashTable.Add(ComboBox1.Text)
        For Each element As DictionaryEntry In hashTable
            MsgBox("Key = " + element.Key + ", Value = " + element.Value)

        Next element
    End Sub

End Class
