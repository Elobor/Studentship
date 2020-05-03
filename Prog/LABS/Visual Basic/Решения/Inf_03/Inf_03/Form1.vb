Public Class Form1

	Dim I As Integer
	Dim R As Single
	Dim str1, str2 As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		I = TextBox1.Text
		R = TextBox2.Text
		Label1.Text = I + R
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		str1 = TextBox3.Text
		str2 = TextBox4.Text
		Label2.Text = str1 + str2
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		str1 = TextBox5.Text
		str2 = TextBox6.Text
		Label3.Text = str1 + str2 + 25
	End Sub

End Class
