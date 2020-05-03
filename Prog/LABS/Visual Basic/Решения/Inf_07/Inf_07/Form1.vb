Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Dim vvodN, i, j As Integer
        vvodN = InputBox("Введите размерность N")
        TextBox1.AppendText("N = " & vvodN)
        TextBox1.AppendText(vbCrLf)
        Dim A(vvodN, vvodN) As Integer
        Dim C(vvodN) As Integer

        For i = 0 To vvodN
            C(i) = Rnd() * 10
            For j = 0 To vvodN
                A(i, j) = Rnd() * 10
            Next
        Next

        For i = 0 To vvodN
            For j = 0 To vvodN
                TextBox1.AppendText(A(i, j) & "  ")
            Next
            TextBox1.AppendText(vbCrLf)
        Next
        TextBox1.AppendText(vbCrLf)

        For i = 0 To vvodN
            TextBox1.AppendText(C(i) & "  ")
        Next
        TextBox1.AppendText(vbCrLf)
        TextBox1.AppendText(vbCrLf)

        For i = 0 To vvodN
            For j = 0 To vvodN
                If (A(i, j) < A(i, i)) Then
                    A(i, j) += C(j)
                End If
            Next
        Next

        For i = 0 To vvodN
            For j = 0 To vvodN
                TextBox1.AppendText(A(i, j) & "  ")
            Next
            TextBox1.AppendText(vbCrLf)
        Next
        TextBox1.AppendText(vbCrLf)

    End Sub
End Class
