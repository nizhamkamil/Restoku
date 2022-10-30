Imports System.Data
Imports System.Data.SqlClient
Public Class CreateAccountForm
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = TextBox6.Text Then
            MessageBox.Show("Account Created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim con As SqlConnection = New SqlConnection("Data Source=Desktop-QHK8K94;Initial Catalog=PointOfSales;Integrated Security=True")
            Dim cmdInsertEmployee As SqlCommand = New SqlCommand("INSERT INTO Employees (firstName,lastName,address,username,password,telpNo) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "')", con)
            con.Open()
            cmdInsertEmployee.ExecuteNonQuery()
            Dim frm1 As New Form1
            frm1.Show()
            Me.Close()
        Else
            MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox5.UseSystemPasswordChar = False
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox5.UseSystemPasswordChar = True
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class