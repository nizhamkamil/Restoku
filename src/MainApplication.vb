Imports System.Data
Imports System.Data.SqlClient
Public Class MainApplication
    Dim Kopi As Integer
    Dim Teh As Integer
    Dim Mie As Integer
    Dim SupAyam As Integer
    Dim Kentang As Integer

    Dim B01 As Integer
    Dim B02 As Integer
    Dim B03 As Integer
    Dim B04 As Integer
    Dim B05 As Integer
    Dim B06 As Integer
    Dim F01 As Integer
    Dim F02 As Integer
    Dim F03 As Integer
    Dim F04 As Integer
    Dim F05 As Integer
    Dim F06 As Integer
    Dim discount As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim j As Integer
        Dim i As Integer
        Dim gaketemu As Boolean = False
        Dim sum As Integer
        Dim selectedItems As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
        Dim ItemList As New ArrayList()
        Dim totalprice As Integer
        For Each item As DataGridViewRow In selectedItems
            ItemList.Clear()
            ItemList.Add(item.Cells(0).Value)
            ItemList.Add(item.Cells(1).Value)
            ItemList.Add(item.Cells(3).Value)
            ItemList.Add(item.Cells(2).Value)
            ItemList.Add(1)


            For j = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item(0, j).Value = ItemList(0) Then
                    DataGridView2.Item(4, j).Value += 1

                    gaketemu = False
                    Exit For
                Else
                    gaketemu = True
                End If
            Next

            If gaketemu Then
                DataGridView2.Rows.Add(ItemList.ToArray())
            End If

            For i = 0 To DataGridView2.Rows.Count - 1
                DataGridView2.Item(5, i).Value = (DataGridView2.Item(3, i).Value * DataGridView2.Item(4, i).Value)
                sum = sum + DataGridView2.Item(5, i).Value
            Next

            totalprice = sum

        Next


        If totalprice < 100000 Then
            TextBox7.Text = 0
            discount = 0
        ElseIf totalprice >= 100000 And totalprice < 200000 Then
            TextBox7.Text = totalprice * 0.05
            discount = totalprice * 0.05
        ElseIf totalprice >= 200000 Then
            TextBox7.Text = totalprice * 0.1
            discount = totalprice * 0.1
        End If

        TextBox3.Text = totalprice
        TextBox4.Text = totalprice * 0.1
        TextBox6.Text = (totalprice * 1.1) - discount
    End Sub




    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Gray
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To DataGridView2.Rows.Count - 2
            ProductTableAdapter.UpdateQuantity(CLng(DataGridView2.Item(4, i).Value), DataGridView2.Item(0, i).Value)
        Next
        Me.ProductTableAdapter.Fill(Me.PointOfSalesDataSet1.Product)
        DataGridView2.Rows.Clear()


        Integer.TryParse(TextBox1.Text, int)
        TextBox1.Text = (int + 1)


        If RadioButton1.Checked Then
            PaymentTableAdapter1.InsertPay(employeeID, RadioButton1.Text, DateTimePicker1.Text, Convert.ToInt32(TextBox6.Text), Convert.ToInt32(TextBox1.Text))
        ElseIf RadioButton2.Checked Then
            PaymentTableAdapter1.InsertPay(employeeID, RadioButton2.Text, DateTimePicker1.Text, Convert.ToInt32(TextBox6.Text), Convert.ToInt32(TextBox1.Text))
        ElseIf RadioButton3.Checked Then
            PaymentTableAdapter1.InsertPay(employeeID, RadioButton3.Text, DateTimePicker1.Text, Convert.ToInt32(TextBox6.Text), Convert.ToInt32(TextBox1.Text))
        ElseIf RadioButton4.Checked Then
            PaymentTableAdapter1.InsertPay(employeeID, RadioButton4.Text, DateTimePicker1.Text, Convert.ToInt32(TextBox6.Text), Convert.ToInt32(TextBox1.Text))
        End If




        KopiModule = KopiModule + Kopi
        TehModule = TehModule + Teh
        MieModule = MieModule + Mie
        SupAyamModule = SupAyamModule + SupAyam
        KentangModule = KentangModule + Kentang

        beverages = KopiModule + TehModule
        food = SupAyamModule + KentangModule + MieModule

        B01 = ProductTableAdapter.getQuantity("B01")
        B02 = ProductTableAdapter.getQuantity("B02")
        B03 = ProductTableAdapter.getQuantity("B03")
        B04 = ProductTableAdapter.getQuantity("B04")
        B05 = ProductTableAdapter.getQuantity("B05")
        B06 = ProductTableAdapter.getQuantity("B06")
        F01 = ProductTableAdapter.getQuantity("F01")
        F02 = ProductTableAdapter.getQuantity("F02")
        F03 = ProductTableAdapter.getQuantity("F03")
        F04 = ProductTableAdapter.getQuantity("F04")
        F05 = ProductTableAdapter.getQuantity("F05")
        F06 = ProductTableAdapter.getQuantity("F06")

        'ini chart buat beverages
        Chart2.Series("Beverages Sold").Points.Clear()
        Chart2.Series("Beverages Sold").Points.AddXY("Kopi", B01)
        Chart2.Series("Beverages Sold").Points.AddXY("Teh", B02)
        Chart2.Series("Beverages Sold").Points.AddXY("Orange", B03)
        Chart2.Series("Beverages Sold").Points.AddXY("Strawberry", B04)
        Chart2.Series("Beverages Sold").Points.AddXY("Green Tea", B05)
        Chart2.Series("Beverages Sold").Points.AddXY("Water", B06)

        'ini chart buat food
        B04Food.Series("Food Sold").Points.Clear()
        B04Food.Series("Food Sold").Points.AddXY("Mie", F01)
        B04Food.Series("Food Sold").Points.AddXY("Pizza", F02)
        B04Food.Series("Food Sold").Points.AddXY("Sup Ayam", F03)
        B04Food.Series("Food Sold").Points.AddXY("Steak", F04)
        B04Food.Series("Food Sold").Points.AddXY("Kentang", F05)
        B04Food.Series("Food Sold").Points.AddXY("Nasi Goreng", F06)

        'ini chart buat total sales
        Chart3.Series("Product Sold").Points.Clear()
        Chart3.Series("Product Sold").Points.AddXY("Mie", F01)
        Chart3.Series("Product Sold").Points.AddXY("Pizza", F02)
        Chart3.Series("Product Sold").Points.AddXY("Sup Ayam", F03)
        Chart3.Series("Product Sold").Points.AddXY("Steak", F04)
        Chart3.Series("Product Sold").Points.AddXY("Kentang", F05)
        Chart3.Series("Product Sold").Points.AddXY("Nasi Goreng", F06)
        Chart3.Series("Product Sold").Points.AddXY("Kopi", B01)
        Chart3.Series("Product Sold").Points.AddXY("Teh", B02)
        Chart3.Series("Product Sold").Points.AddXY("Orange", B03)
        Chart3.Series("Product Sold").Points.AddXY("Strawberry", B04)
        Chart3.Series("Product Sold").Points.AddXY("Green Tea", B05)
        Chart3.Series("Product Sold").Points.AddXY("Water", B06)
        Chart3.ChartAreas(0).AxisX.Interval = 1


        income = income + Val(TextBox6.Text)

        'ini buat nampilin label di chart
        F01Food.Text = F01
        F02Food.Text = F02
        F03Food.Text = F03
        F04Food.Text = F04
        F05Food.Text = F05
        F06Food.Text = F06

        B01Drink.Text = B01
        B02Drink.Text = B02
        B03Drink.Text = B03
        B04Drink.Text = B04
        B05Drink.Text = B05
        B06Drink.Text = B06

        LabelB01.Text = B01
        LabelB02.Text = B02
        LabelB03.Text = B03
        LabelB04.Text = B04
        LabelB05.Text = B05
        LabelB06.Text = B06

        LabelF01.Text = F01
        LabelF02.Text = F02
        LabelF03.Text = F03
        LabelF04.Text = F04
        LabelF05.Text = F05
        LabelF06.Text = F06



        TextBox3.Text = ""
        TextBox7.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dgv As DataGridViewRow
        For Each dgv In DataGridView2.SelectedRows
            DataGridView2.Rows.Remove(dgv)
        Next


        TextBox3.Text = ""
        TextBox7.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm1 As New Form1
        frm1.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Show()
        Panel2.Hide()
        Button4.ForeColor = Color.Coral
        Button5.ForeColor = Color.White
    End Sub

    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PointOfSalesDataSet1.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.PointOfSalesDataSet1.Member)
        'TODO: This line of code loads data into the 'PointOfSalesDataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.PointOfSalesDataSet1.Product)
        'TODO: This line of code loads data into the 'PointOfSalesDataSet1.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.PointOfSalesDataSet1.Employees)
        'TODO: This line of code loads data into the 'PointOfSalesDataSet.Employees' table. You can move, or remove it, as needed.
        Panel11.Hide()
        Panel2.Hide()
        TextBox8.Text = addressSession
        TextBox12.Text = phoneNumSession
        TextBox13.Text = positionSession
        TextBox14.Text = citySession
        TextBox15.Text = stateSession
        TextBox16.Text = zipcodeSession
        TextBox20.Text = countrySession
        Label47.Text = firstNameSession
        Label61.Text = lastNameSession
        Button4.ForeColor = Color.Coral
        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.FromArgb(0, 120, 215)
        Button6.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox16.BackColor = Color.FromArgb(25, 29, 40)

        'Mendapatkan kuantitas dan menaruhnya dalam variabel agar dapat ditampilkan ke chart
        B01 = ProductTableAdapter.getQuantity("B01")
        B02 = ProductTableAdapter.getQuantity("B02")
        B03 = ProductTableAdapter.getQuantity("B03")
        B04 = ProductTableAdapter.getQuantity("B04")
        B05 = ProductTableAdapter.getQuantity("B05")
        B06 = ProductTableAdapter.getQuantity("B06")
        F01 = ProductTableAdapter.getQuantity("F01")
        F02 = ProductTableAdapter.getQuantity("F02")
        F03 = ProductTableAdapter.getQuantity("F03")
        F04 = ProductTableAdapter.getQuantity("F04")
        F05 = ProductTableAdapter.getQuantity("F05")
        F06 = ProductTableAdapter.getQuantity("F06")

        Chart2.Series("Beverages Sold").Points.Clear()
        Chart2.Series("Beverages Sold").Points.AddXY("Kopi", B01)
        Chart2.Series("Beverages Sold").Points.AddXY("Teh", B02)
        Chart2.Series("Beverages Sold").Points.AddXY("Orange", B03)
        Chart2.Series("Beverages Sold").Points.AddXY("Strawberry", B04)
        Chart2.Series("Beverages Sold").Points.AddXY("Green Tea", B05)
        Chart2.Series("Beverages Sold").Points.AddXY("Water", B06)

        'ini chart buat food
        B04Food.Series("Food Sold").Points.Clear()
        B04Food.Series("Food Sold").Points.AddXY("Mie", F01)
        B04Food.Series("Food Sold").Points.AddXY("Pizza", F02)
        B04Food.Series("Food Sold").Points.AddXY("Sup Ayam", F03)
        B04Food.Series("Food Sold").Points.AddXY("Steak", F04)
        B04Food.Series("Food Sold").Points.AddXY("Kentang", F05)
        B04Food.Series("Food Sold").Points.AddXY("Nasi Goreng", F06)

        'ini chart buat total
        Chart3.Series("Product Sold").Points.Clear()
        Chart3.Series("Product Sold").Points.AddXY("Mie", F01)
        Chart3.Series("Product Sold").Points.AddXY("Pizza", F02)
        Chart3.Series("Product Sold").Points.AddXY("Sup Ayam", F03)
        Chart3.Series("Product Sold").Points.AddXY("Steak", F04)
        Chart3.Series("Product Sold").Points.AddXY("Kentang", F05)
        Chart3.Series("Product Sold").Points.AddXY("Nasi Goreng", F06)
        Chart3.Series("Product Sold").Points.AddXY("Kopi", B01)
        Chart3.Series("Product Sold").Points.AddXY("Teh", B02)
        Chart3.Series("Product Sold").Points.AddXY("Orange", B03)
        Chart3.Series("Product Sold").Points.AddXY("Strawberry", B04)
        Chart3.Series("Product Sold").Points.AddXY("Green Tea", B05)
        Chart3.Series("Product Sold").Points.AddXY("Water", B06)
        Chart3.ChartAreas(0).AxisX.Interval = 1
        Panel14.Hide()
        Panel15.Hide()

        F01Food.Text = F01
        F02Food.Text = F02
        F03Food.Text = F03
        F04Food.Text = F04
        F05Food.Text = F05
        F06Food.Text = F06

        B01Drink.Text = B01
        B02Drink.Text = B02
        B03Drink.Text = B03
        B04Drink.Text = B04
        B05Drink.Text = B05
        B06Drink.Text = B06

        LabelB01.Text = B01
        LabelB02.Text = B02
        LabelB03.Text = B03
        LabelB04.Text = B04
        LabelB05.Text = B05
        LabelB06.Text = B06

        LabelF01.Text = F01
        LabelF02.Text = F02
        LabelF03.Text = F03
        LabelF04.Text = F04
        LabelF05.Text = F05
        LabelF06.Text = F06

        TextBox1.Text = int



        Button13.BackColor = Color.FromArgb(48, 54, 76)
        Button13.ForeColor = Color.White

        Button12.BackColor = Color.FromArgb(48, 54, 76)
        Button12.ForeColor = Color.White

        'ini yang dipilih
        Button11.BackColor = Color.FromArgb(25, 29, 40)
        Button11.ForeColor = Color.FromArgb(0, 120, 215)

        'ini yang dipilih
        PictureBox19.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox21.BackColor = Color.FromArgb(48, 54, 76)
        PictureBox20.BackColor = Color.FromArgb(48, 54, 76)

        TextBox10.Text = profileID
        TextBox11.Text = firstNameSession + lastNameSession
        ReceiptBox.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Show()
        Panel1.Hide()
        Button5.ForeColor = Color.Coral
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.BackColor = Color.FromArgb(48, 54, 76)
        Button6.ForeColor = Color.White
        Button7.BackColor = Color.FromArgb(25, 29, 40)
        Button7.ForeColor = Color.FromArgb(0, 120, 215)
        PictureBox17.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox16.BackColor = Color.FromArgb(48, 54, 76)
        Panel11.Show()
        Panel10.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel10.Show()
        Panel11.Hide()
        Button7.BackColor = Color.FromArgb(48, 54, 76)
        Button6.ForeColor = Color.FromArgb(0, 120, 215)
        Button6.BackColor = Color.FromArgb(25, 29, 40)
        Button7.ForeColor = Color.White
        PictureBox16.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox17.BackColor = Color.FromArgb(48, 54, 76)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to logout", "Notification", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim frm1 As New Form1
            Me.Hide()
            frm1.Show()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox18.Text = "admin" Or TextBox18.Text = passwordSession Then
            If TextBox17.Text = TextBox19.Text Then
                MessageBox.Show("Password Changed", "Notification", MessageBoxButtons.OK)
                Dim con As SqlConnection = New SqlConnection("Data Source=Desktop-QHK8K94;Initial Catalog=PointOfSales;Integrated Security=True")
                Dim str As String
                str = "UPDATE Employees SET password =  '" + TextBox19.Text + "'WHERE employeeNo = '" + profileID + "'"
                Dim cmd As New SqlCommand(str, con)
                con.Open()
                cmd.ExecuteNonQuery()
                password = TextBox17.Text
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
            Else
                MessageBox.Show("Password Does Not Match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter the correct Password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Changes Saved", "Notification")
        Dim con As SqlConnection = New SqlConnection("Data Source=Desktop-QHK8K94;Initial Catalog=PointOfSales;Integrated Security=True")
        Dim str As String
        str = "UPDATE Employees SET address =  '" + TextBox8.Text + "', telpNo = '" + TextBox12.Text + "', position = '" + TextBox13.Text + "', city = '" + TextBox14.Text + "', state = '" + TextBox15.Text + "', zipcode = '" + TextBox16.Text + "', country = '" + TextBox20.Text + "'WHERE employeeNo = '" + profileID + "'"
        Dim cmd As New SqlCommand(str, con)
        con.Open()
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox17.UseSystemPasswordChar = False
            TextBox18.UseSystemPasswordChar = False
            TextBox19.UseSystemPasswordChar = False
        Else
            TextBox17.UseSystemPasswordChar = True
            TextBox18.UseSystemPasswordChar = True
            TextBox19.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel13.Show()
        Panel14.Hide()
        Panel15.Hide()

        Button13.BackColor = Color.FromArgb(48, 54, 76)
        Button13.ForeColor = Color.White

        Button12.BackColor = Color.FromArgb(48, 54, 76)
        Button12.ForeColor = Color.White

        'ini yang dipilih
        Button11.BackColor = Color.FromArgb(25, 29, 40)
        Button11.ForeColor = Color.FromArgb(0, 120, 215)

        'ini yang dipilih
        PictureBox19.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox21.BackColor = Color.FromArgb(48, 54, 76)
        PictureBox20.BackColor = Color.FromArgb(48, 54, 76)
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Panel15.Show()
        Panel13.Hide()
        Panel14.Hide()
        Button11.BackColor = Color.FromArgb(48, 54, 76)
        Button11.ForeColor = Color.White

        Button13.BackColor = Color.FromArgb(48, 54, 76)
        Button13.ForeColor = Color.White

        'ini yang dipilih
        Button12.BackColor = Color.FromArgb(25, 29, 40)
        Button12.ForeColor = Color.FromArgb(0, 120, 215)

        'ini yang dipilih
        PictureBox21.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox19.BackColor = Color.FromArgb(48, 54, 76)
        PictureBox20.BackColor = Color.FromArgb(48, 54, 76)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel14.Show()
        Panel13.Hide()
        Panel15.Hide()
        Button11.BackColor = Color.FromArgb(48, 54, 76)
        Button11.ForeColor = Color.White

        Button12.BackColor = Color.FromArgb(48, 54, 76)
        Button12.ForeColor = Color.White

        'ini yang dipilih
        Button13.BackColor = Color.FromArgb(25, 29, 40)
        Button13.ForeColor = Color.FromArgb(0, 120, 215)

        'ini yang dipilih
        PictureBox20.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox19.BackColor = Color.FromArgb(48, 54, 76)
        PictureBox21.BackColor = Color.FromArgb(48, 54, 76)

    End Sub

End Class