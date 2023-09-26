<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ODBC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ODBC))
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VBStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KrishnkantDataSet = New DataBaseCon.KrishnkantDataSet()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.VB_StudentsTableAdapter = New DataBaseCon.KrishnkantDataSetTableAdapters.VB_StudentsTableAdapter()
        Me.panel3.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KrishnkantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.Orange
        Me.panel3.Controls.Add(Me.panel6)
        Me.panel3.Controls.Add(Me.panel5)
        Me.panel3.Controls.Add(Me.panel4)
        Me.panel3.Location = New System.Drawing.Point(111, 122)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1000, 555)
        Me.panel3.TabIndex = 7
        '
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.SystemColors.Control
        Me.panel6.Controls.Add(Me.panel7)
        Me.panel6.Location = New System.Drawing.Point(581, 12)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(405, 124)
        Me.panel6.TabIndex = 1
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.BackgroundImage = CType(resources.GetObject("panel7.BackgroundImage"), System.Drawing.Image)
        Me.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel7.Location = New System.Drawing.Point(6, 11)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(386, 98)
        Me.panel7.TabIndex = 0
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.SystemColors.Control
        Me.panel5.Controls.Add(Me.btnExit)
        Me.panel5.Controls.Add(Me.button8)
        Me.panel5.Controls.Add(Me.button7)
        Me.panel5.Controls.Add(Me.button2)
        Me.panel5.Controls.Add(Me.button1)
        Me.panel5.Location = New System.Drawing.Point(581, 142)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(405, 397)
        Me.panel5.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(3, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(389, 73)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(6, 237)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(386, 65)
        Me.button8.TabIndex = 9
        Me.button8.Text = "Reset"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.Location = New System.Drawing.Point(6, 166)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(386, 59)
        Me.button7.TabIndex = 8
        Me.button7.Text = "Delete"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(1, 91)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(391, 63)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Update"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(3, 26)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(389, 59)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Add New"
        Me.button1.UseVisualStyleBackColor = True
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.SystemColors.Control
        Me.panel4.Controls.Add(Me.richTextBox1)
        Me.panel4.Controls.Add(Me.comboBox1)
        Me.panel4.Controls.Add(Me.dataGridView1)
        Me.panel4.Controls.Add(Me.textBox6)
        Me.panel4.Controls.Add(Me.textBox2)
        Me.panel4.Controls.Add(Me.label7)
        Me.panel4.Controls.Add(Me.textBox5)
        Me.panel4.Controls.Add(Me.label5)
        Me.panel4.Controls.Add(Me.textBox3)
        Me.panel4.Controls.Add(Me.label6)
        Me.panel4.Controls.Add(Me.label3)
        Me.panel4.Controls.Add(Me.label4)
        Me.panel4.Controls.Add(Me.label2)
        Me.panel4.Location = New System.Drawing.Point(10, 12)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(565, 530)
        Me.panel4.TabIndex = 1
        '
        'richTextBox1
        '
        Me.richTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(209, 132)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(335, 62)
        Me.richTextBox1.TabIndex = 3
        Me.richTextBox1.Text = ""
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(209, 18)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(334, 24)
        Me.comboBox1.TabIndex = 0
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.VBStudentsBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(23, 296)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.Size = New System.Drawing.Size(521, 221)
        Me.dataGridView1.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        Me.PincodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VBStudentsBindingSource
        '
        Me.VBStudentsBindingSource.DataMember = "VB Students"
        Me.VBStudentsBindingSource.DataSource = Me.KrishnkantDataSet
        '
        'KrishnkantDataSet
        '
        Me.KrishnkantDataSet.DataSetName = "KrishnkantDataSet"
        Me.KrishnkantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'textBox6
        '
        Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.textBox6.Location = New System.Drawing.Point(209, 245)
        Me.textBox6.MaxLength = 10
        Me.textBox6.Multiline = True
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(334, 39)
        Me.textBox6.TabIndex = 5
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(209, 48)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(334, 39)
        Me.textBox2.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(8, 252)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(160, 32)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Telephone"
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.textBox5.Location = New System.Drawing.Point(209, 200)
        Me.textBox5.MaxLength = 6
        Me.textBox5.Multiline = True
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(334, 39)
        Me.textBox5.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(8, 140)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(126, 32)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Address"
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.textBox3.Location = New System.Drawing.Point(209, 90)
        Me.textBox3.Multiline = True
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(334, 39)
        Me.textBox3.TabIndex = 2
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(8, 205)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(156, 32)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Post Code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(8, 48)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(162, 32)
        Me.label3.TabIndex = 0
        Me.label3.Text = "First Name"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(8, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(137, 32)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Surname"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(8, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(154, 32)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Student id"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Orange
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Location = New System.Drawing.Point(111, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1000, 104)
        Me.panel1.TabIndex = 6
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.Control
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(10, 7)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(973, 85)
        Me.panel2.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 34.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Orange
        Me.label1.Location = New System.Drawing.Point(-15, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(952, 76)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Database Connection in VB.Net"
        '
        'VB_StudentsTableAdapter
        '
        Me.VB_StudentsTableAdapter.ClearBeforeFill = True
        '
        'ODBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 696)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel1)
        Me.Name = "ODBC"
        Me.Text = "Form1"
        Me.panel3.ResumeLayout(False)
        Me.panel6.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KrishnkantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents panel6 As System.Windows.Forms.Panel
    Private WithEvents panel7 As System.Windows.Forms.Panel
    Private WithEvents panel5 As System.Windows.Forms.Panel
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents button8 As System.Windows.Forms.Button
    Private WithEvents button7 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents textBox6 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents textBox5 As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents KrishnkantDataSet As DataBaseCon.KrishnkantDataSet
    Friend WithEvents VBStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VB_StudentsTableAdapter As DataBaseCon.KrishnkantDataSetTableAdapters.VB_StudentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
