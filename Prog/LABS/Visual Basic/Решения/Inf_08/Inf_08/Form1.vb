Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Dim i, N As Integer
        Dim SA As Double
        N = InputBox("Введите размерность векторов") - 1
        Dim C1(N), C2(N) As Integer
        For i = 0 To N
            C1(i) = ((Rnd() * 19) - 9)
            TextBox1.AppendText(C1(i) & " ")
        Next

        TextBox1.AppendText(vbCrLf)

        For i = 0 To N
            C2(i) = ((Rnd() * 19) - 9)
            TextBox1.AppendText(C2(i) & " ")
        Next

        TextBox1.AppendText(vbCrLf)

        SA = 0
        If (GetInd(C:=C1) < 0 Or GetInd(C:=C2) < 0) Then
            TextBox1.AppendText("Нет отрицательных элементов")
        ElseIf (GetInd(C1) > GetInd(C2)) Then
            For i = 0 To N
                SA = SA + C2(i)
            Next
            SA = SA / N
            TextBox1.AppendText("Среднее арифметическое второго вектора равно " & SA)
            SA = 0
        ElseIf (GetInd(C:=C2) > GetInd(C:=C1)) Then
            For i = 0 To N
                SA = SA + C1(i)
            Next
            SA = SA / N
            TextBox1.AppendText("Среднее арифметическое первого вектора равно " & SA)
            SA = 0
        ElseIf (GetInd(C:=C2) = GetInd(C:=C1)) Then
            For i = 0 To N
                SA = SA + C1(i)
            Next
            SA = SA / N
            TextBox1.AppendText("Среднее арифметическое первого вектора равно " & SA)
            SA = 0
            For i = 0 To N
                SA = SA + C2(i)
            Next
            SA = SA / N
            TextBox1.AppendText("Среднее арифметическое второго вектора равно " & SA)
            SA = 0
        End If

    End Sub

    Public Function GetInd(ByVal C() As Integer) As Integer
        Dim ii, ind As Integer
        ind = -1
        For ii = 0 To (C.Length - 1)
            If (C(ii) < 0 And ind = -1) Then
                ind = ii
            End If
        Next
        GetInd = ind
    End Function

End Class
