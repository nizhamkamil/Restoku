Imports System.Data
Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(375, 215)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(292, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(375, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(312, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(703, 269)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(345, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Point of Sales Application"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(570, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Forgot Password?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(372, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Create Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tugas_Visual_Basic_1.My.Resources.Resources.icons8_user_50px
        Me.PictureBox1.Location = New System.Drawing.Point(474, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 607)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button



    Dim user As String = username
    Dim pass As String = password


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=Desktop-QHK8K94;Initial Catalog=PointOfSales;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim phoneNum As SqlCommand = New SqlCommand("SELECT telpNo FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim position As SqlCommand = New SqlCommand("SELECT position FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim address As SqlCommand = New SqlCommand("SELECT address FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim city As SqlCommand = New SqlCommand("SELECT city FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim zipcode As SqlCommand = New SqlCommand("SELECT zipcode FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim country As SqlCommand = New SqlCommand("SELECT country FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim state As SqlCommand = New SqlCommand("SELECT state FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim firstName As SqlCommand = New SqlCommand("SELECT firstName FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim lastName As SqlCommand = New SqlCommand("SELECT lastName FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim password As SqlCommand = New SqlCommand("SELECT Password FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim employeeID1 As SqlCommand = New SqlCommand("SELECT employeeNo FROM Employees WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim datatable As DataTable = New DataTable()
        adapter.Fill(datatable)
        If datatable.Rows.Count > 0 Then
            MessageBox.Show("Berhasil Login", "Notification")
            con.Open()
            profileID = Convert.ToString(cmd.ExecuteScalar())
            employeeID = employeeID1.ExecuteScalar()
            phoneNumSession = Convert.ToString(phoneNum.ExecuteScalar())
            positionSession = Convert.ToString(position.ExecuteScalar())
            addressSession = Convert.ToString(address.ExecuteScalar())
            citySession = Convert.ToString(city.ExecuteScalar())
            zipcodeSession = Convert.ToString(zipcode.ExecuteScalar())
            countrySession = Convert.ToString(country.ExecuteScalar())
            stateSession = Convert.ToString(state.ExecuteScalar())
            firstNameSession = Convert.ToString(firstName.ExecuteScalar())
            lastNameSession = Convert.ToString(lastName.ExecuteScalar())
            firstNameSession = Convert.ToString(firstName.ExecuteScalar())
            lastNameSession = Convert.ToString(lastName.ExecuteScalar())
            passwordSession = Convert.ToString(password.ExecuteScalar())
            Dim frm2 As New MainApplication
            frm2.Show()
            Me.Close()
        ElseIf TextBox1.Text = user And TextBox2.Text = pass Then
            MessageBox.Show("Berhasil Login", "Notification")
            Dim frm2 As New MainApplication
            frm2.Show()
            Me.Close()
        Else
            MessageBox.Show("Data yang anda masukan salah", "Notification", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = username
        pass = password

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DeepSkyBlue

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
    End Sub

    Friend WithEvents CheckBox1 As CheckBox

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label



    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        Label5.ForeColor = Color.BlueViolet

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.BlueViolet
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Gray
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Gray
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim frm3 As New CreateAccountForm
        frm3.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim frm4 As New Form2
        frm4.Show()
        Me.Close()

    End Sub
End Class

