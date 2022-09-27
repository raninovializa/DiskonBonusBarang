Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String

        harga = TextBox2.Text
        jumlah = TextBox3.Text
        total = harga * jumlah
        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Cangkir"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If
        bayar = total - diskon
        TextBox4.Text = total
        TextBox5.Text = diskon
        TextBox6.Text = bayar
        TextBox7.Text = bonus
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class