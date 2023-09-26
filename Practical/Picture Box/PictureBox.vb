Public Class PictureBox

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "B.C.A." Then
            PictureBox1.Image = Image.FromFile("C:\Users\shrut\Downloads\bca-admission-2021.jpeg")
        End If
        If ComboBox1.SelectedItem = "B.B.A." Then
            PictureBox1.Image = Image.FromFile("C:\Users\shrut\Downloads\BBA-Course-Landing.jpg")
        End If
        If ComboBox1.SelectedItem = "B.Ed." Then
            PictureBox1.Image = Image.FromFile("C:\Users\shrut\Downloads\b-ed-bachelor-of-education.png")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
End Class
