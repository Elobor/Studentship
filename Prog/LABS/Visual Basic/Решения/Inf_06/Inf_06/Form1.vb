Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kolvoN, i, Sum, Cnt As Integer
        Sum = 0
        Cnt = 0
        kolvoN = InputBox("Введите количество элементов")
        Dim Vek(kolvoN) As Integer

        For i = 0 To kolvoN
            Vek(i) = Rnd() * 40
        Next

        For i = 0 To kolvoN
            If (Vek(i).Equals(10) Or ((30 - Vek(i) <= 10) And (30 - Vek(i) >= 0))) Then
                Cnt = Cnt + 1
                Sum = Sum + Vek(i)
            End If
        Next

        For i = 0 To kolvoN
            TextBox1.AppendText(Vek(i) & " ")
        Next

        TextBox1.AppendText(vbCrLf & "Количество элементов " & Cnt & vbCrLf)
        TextBox1.AppendText("Сумма элементов равна " & Sum & vbCrLf)

    End Sub
End Class
