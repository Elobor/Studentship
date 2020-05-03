Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer, s As Single, x As String
        x = InputBox("Пожалуйста, введите Ваше имя и отчество")
        i = InputBox("Задайте значение i")
        s = InputBox("Задайте значение s")
        TextBox1.Clear()
        TextBox1.AppendText("x=" & x & vbCrLf)
        TextBox1.AppendText("i=" & i & vbCrLf)
        TextBox1.AppendText("s=" & s)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer, s As Single, d As Date
        i = InputBox("Задайте значение i")
        s = Rnd()
        d = InputBox("Задайте дату в формате дд.мм.гг")
        TextBox1.Clear()
        TextBox1.AppendText("i = " & i & vbCrLf)
        TextBox1.AppendText("s = " &
        Format(s, "+0.0000000000") & vbCrLf)
        TextBox1.AppendText("d = " &
        Format(d, "dddd, dd MMMM, yyyy год") & vbCrLf)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer, s As Single, d As Date
        i = InputBox("Задайте значение i")
        s = Rnd()
        d = InputBox("Задайте дату в формате дд.мм.гг")
        TextBox1.Clear()
        MsgBox("i = " & i, , "Вывод переменной i")
        MsgBox("s = " & Format(s, "+0.####"),  , "Вывод переменной s")
        MsgBox("d = " & Format(d, "dddd dd MMMM yyyy год"),  , "Вывод переменной d")
    End Sub
End Class
