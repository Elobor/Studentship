Public Class Form1

	Dim count As Single
	Dim arg As Single

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim n As Integer
		TextBox1.Clear()
		n = InputBox("Введите количество аргументов")
		TextBox1.AppendText("Считаем для " & n & " значений аргумента" & vbCrLf)
		TextBox1.AppendText("Аргумент " & vbTab & " Функция" & vbCrLf)
		For arg = 0 To 1 Step (1 / n)
			count = Math.Pow(Math.E, arg) - Math.Pow(Math.E, -arg) - 2
			TextBox1.AppendText(arg & vbTab & vbTab & count & vbCrLf)
		Next
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
