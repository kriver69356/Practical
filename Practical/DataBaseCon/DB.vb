Imports System.Data.SqlClient
Public Class ODBC


    Private Sub ODBC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KrishnkantDataSet.VB_Students' table. You can move, or remove it, as needed.
        Me.VB_StudentsTableAdapter.Fill(Me.KrishnkantDataSet.VB_Students)
        Dim con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Krishnkant;Integrated Security=True")
        con.Open()
        Dim cmd2 As SqlCommand = New SqlCommand("select * from [VB Students]", con)
        Dim dr As SqlDataReader = cmd2.ExecuteReader()
        While dr.Read()
            comboBox1.Items.Add(dr(0))
        End While
        con.Close()

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            If Not (textBox2.Text.Trim() = "" Or textBox3.Text.Trim() = "" Or textBox5.Text.Trim() = "" Or richTextBox1.Text.Trim() = "" Or textBox6.Text.Trim() = "") Then
                Dim con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Krishnkant;Integrated Security=True")
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("insert into [VB Students] values(@id,@nm,@sn,@add,@post,@tel)", con)
                cmd.Parameters.AddWithValue("@id", comboBox1.Text)
                cmd.Parameters.AddWithValue("@nm", textBox2.Text)
                cmd.Parameters.AddWithValue("@sn", textBox3.Text)
                cmd.Parameters.AddWithValue("@add", richTextBox1.Text)
                cmd.Parameters.AddWithValue("@post", textBox5.Text)
                cmd.Parameters.AddWithValue("@tel", textBox6.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Submitted successfully")
                textBox2.Clear()
                textBox3.Clear()
                richTextBox1.Clear()
                textBox5.Clear()
                textBox6.Clear()
                comboBox1.Items.Clear()
                comboBox1.Text = ""
                Dim da As SqlDataAdapter = New SqlDataAdapter("select * from [VB Students]", con)
                Dim dtbl As DataTable = New DataTable()
                da.Fill(dtbl)
                dataGridView1.DataSource = dtbl
                Dim cmd2 As SqlCommand = New SqlCommand("select * from [VB Students]", con)
                Dim dr As SqlDataReader = cmd2.ExecuteReader()
                While dr.Read()
                    comboBox1.Items.Add(dr(0))
                End While
                con.Close()
            Else
                MessageBox.Show("Do not keep any Box Empty")
            End If
        Catch
            MessageBox.Show("ID Already Exist")

        End Try


    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        If Not (textBox2.Text.Trim() = "" Or textBox3.Text.Trim() = "" Or textBox5.Text.Trim() = "" Or richTextBox1.Text.Trim() = "" Or textBox6.Text.Trim() = "") Then
            Dim con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Krishnkant;Integrated Security=True")
            con.Open()
            Dim cmd3 As SqlCommand = New SqlCommand("delete from [VB Students] where ID='" + comboBox1.Text + "'", con)
            cmd3.ExecuteNonQuery()
            Dim cmd As SqlCommand = New SqlCommand("insert into [VB Students] values(@id,@nm,@sn,@add,@post,@tel)", con)
            cmd.Parameters.AddWithValue("@id", comboBox1.Text)
            cmd.Parameters.AddWithValue("@nm", textBox2.Text)
            cmd.Parameters.AddWithValue("@sn", textBox3.Text)
            cmd.Parameters.AddWithValue("@add", richTextBox1.Text)
            cmd.Parameters.AddWithValue("@post", textBox5.Text)
            cmd.Parameters.AddWithValue("@tel", textBox6.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated successfully")
            textBox2.Clear()
            textBox3.Clear()
            richTextBox1.Clear()
            textBox5.Clear()
            textBox6.Clear()
            comboBox1.Items.Clear()
            comboBox1.Text = ""
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from [VB Students]", con)
            Dim dtbl As DataTable = New DataTable()
            da.Fill(dtbl)
            dataGridView1.DataSource = dtbl
            Dim cmd2 As SqlCommand = New SqlCommand("select * from [VB Students]", con)
            Dim dr As SqlDataReader = cmd2.ExecuteReader()
            While dr.Read()
                comboBox1.Items.Add(dr(0))
            End While
            con.Close()
        Else
            MessageBox.Show("Do not keep any Box Empty")
        End If

    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to delete", "Database Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Dim con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Krishnkant;Integrated Security=True")
            con.Open()
            Dim cmd3 As SqlCommand = New SqlCommand("delete from [VB Students] where ID='" + comboBox1.Text + "'", con)
            cmd3.ExecuteNonQuery()
            MessageBox.Show("Deleted successfully")
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from [VB Students]", con)
            Dim dtbl As DataTable = New DataTable()
            da.Fill(dtbl)
            dataGridView1.DataSource = dtbl
            comboBox1.Text = ""
            comboBox1.Items.Clear()
            Dim cmd2 As SqlCommand = New SqlCommand("select * from [VB Students]", con)
            Dim dr As SqlDataReader = cmd2.ExecuteReader()
            While dr.Read()
                comboBox1.Items.Add(dr(0))
            End While
            con.Close()
        End If
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        comboBox1.Text = ""
        textBox2.Clear()
        textBox3.Clear()
        textBox5.Clear()
        textBox6.Clear()
        richTextBox1.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to exit", "Database Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub comboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub

    Private Sub textBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox2.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Alphabets Are Allowed")
        End If
    End Sub

    Private Sub textBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox3.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Alphabets Are Allowed")
        End If
    End Sub

    Private Sub textBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox5.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub

    Private Sub textBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox6.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Are Allowed")
        End If
    End Sub
End Class
