Public Class FormDatabase
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentDataSet.vuz". При необходимости она может быть перемещена или удалена.
        Me.VuzTableAdapter.Fill(Me.StudentDataSet.vuz)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentDataSet.kat_obuch". При необходимости она может быть перемещена или удалена.
        Me.Kat_obuchTableAdapter.Fill(Me.StudentDataSet.kat_obuch)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentDataSet.poss". При необходимости она может быть перемещена или удалена.
        Me.PossTableAdapter.Fill(Me.StudentDataSet.poss)
    End Sub

    Private Sub comboxKatObuch_TextChanged(sender As Object, e As EventArgs) Handles comboxKatObuch.SelectedIndexChanged
        If comboxKatObuch.Text = String.Empty Then
            PossBindingSource.RemoveFilter()
        Else
            PossBindingSource.Filter = "kat_obuch_k =" & comboxKatObuch.SelectedValue.ToString
        End If
    End Sub

    Private Sub comboxVUZ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxVUZ.SelectedIndexChanged
        If comboxVUZ.Text = String.Empty Then
            PossBindingSource.RemoveFilter()
        Else
            PossBindingSource.Filter = "vuz_k =" & comboxVUZ.SelectedValue.ToString
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = String.Empty Then
            PossBindingSource.RemoveFilter()
        Else
            PossBindingSource.Filter = "fio LIKE '%" & TextBox1.Text.ToString + "%'"
        End If
    End Sub

End Class
