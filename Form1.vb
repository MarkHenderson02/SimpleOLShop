Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim Harga, Jumlah As Integer
        Dim Total, Diskon, Bayar As Double
        Dim Bonus As String

        Harga = txtHS.Text
        Jumlah = txtJB.Text

        Total = Harga * Jumlah
        txtTH.Text = Harga
        If Total >= 500000 Then
            Diskon = 0.2 * Total
            Bonus = "Tas Pinggang"

        ElseIf Total >= 200000 And Total < 500000 Then
            Diskon = 0.15 * Total
            Bonus = "Payung"

        ElseIf Total >= 100000 And Total < 200000 Then
            Diskon = 0.1 * Total
            Bonus = "Kaos"

        ElseIf Total >= 50000 And Total < 100000 Then
            Diskon = 0.05 * Total
            Bonus = "Cangkir"

        Else
            Diskon = 0
            Bonus = "Tidak Ada"
        End If

        txtDisk.Text = Diskon
        txtBNS.Text = Bonus

        txtTB.Text = Total - Diskon
    End Sub

    Private Sub btnUlng_Click(sender As Object, e As EventArgs) Handles btnUlng.Click
        For Each txt As Control In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class
