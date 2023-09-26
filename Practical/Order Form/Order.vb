Public Class Order

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub


    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            TextBox3.Enabled = True
            Label11.Visible = True
            Label16.Visible = True

        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            TextBox3.Enabled = False
            Label11.Visible = False
            Label16.Visible = False
            Label16.Text = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            TextBox4.Enabled = True
            Label12.Visible = True
            Label17.Visible = True

        Else
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            TextBox4.Enabled = False
            Label17.Visible = False
            Label12.Visible = False
            Label17.Text = 0
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True
            RadioButton9.Enabled = True
            TextBox5.Enabled = True
            Label13.Visible = True
            Label18.Visible = True

        Else
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Enabled = False
            TextBox5.Enabled = False
            Label18.Visible = False
            Label13.Visible = False
            Label18.Text = 0
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            RadioButton10.Enabled = True
            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            TextBox6.Enabled = True
            Label14.Visible = True
            Label19.Visible = True

        Else
            RadioButton10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            TextBox6.Enabled = False
            Label19.Visible = False
            Label14.Visible = False
            Label19.Text = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label11.Text = 20
            Label16.Text = 20 * TextBox3.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label11.Text = 40
            Label16.Text = 40 * TextBox3.Text
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label11.Text = 60
            Label16.Text = 60 * TextBox3.Text
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Label12.Text = 10
            Label17.Text = 10 * TextBox4.Text
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Label12.Text = 20
            Label17.Text = 20 * TextBox4.Text
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Label12.Text = 25
            Label17.Text = 25 * TextBox4.Text
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Label13.Text = 40
            Label18.Text = 40 * TextBox5.Text
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Label13.Text = 50
            Label18.Text = 50 * TextBox5.Text
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Label13.Text = 90
            Label18.Text = 90 * TextBox5.Text
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Label14.Text = 100
            Label19.Text = 100 * TextBox6.Text
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Label14.Text = 120
            Label19.Text = 120 * TextBox6.Text
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Label14.Text = 150
            Label19.Text = 150 * TextBox6.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Label16.Text = Label11.Text * TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Label17.Text = Label12.Text * TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Label18.Text = Label13.Text * TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Label19.Text = Label14.Text * TextBox6.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label20.Visible = True
        Dim cof, tea, bur, piz As Integer
        cof = Label16.Text
        tea = Label17.Text
        bur = Label18.Text
        piz = Label19.Text
        Label20.Text = cof + tea + bur + piz
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub
End Class
