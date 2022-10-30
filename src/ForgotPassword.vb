Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm1 As New Form3
        Dim con As SqlConnection = New SqlConnection("Data Source=Desktop-QHK8K94;Initial Catalog=PointOfSales;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT telpNo from Employees WHERE telpNo = '" + TextBox1.Text + "'", con)
        con.Open()
        forgotPassword = Convert.ToString(cmd.ExecuteScalar)
        If forgotPassword Like "" Then
            MessageBox.Show("Username Yang anda masukan tidak ada", "Notification", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            frm1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class