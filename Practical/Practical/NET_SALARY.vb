Public Class NET_SALARY

    Dim bs, da, hra, ta, ot, pf, net As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bs = TextBox1.Text
        da = TextBox2.Text
        hra = TextBox3.Text
        ta = TextBox4.Text
        ot = TextBox5.Text
        pf = TextBox6.Text
        net = (bs + da + hra + ta + ot) - pf
        Label9.Text = net
        Label9.Visible = True
        Label8.Visible = True
    End Sub

    Private Sub NET_SALARY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) or e.KeyChar = ChrW(Keys.tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBox4.Select()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBox5.Select()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBox6.Select()
        End If
    End Sub
End Class
