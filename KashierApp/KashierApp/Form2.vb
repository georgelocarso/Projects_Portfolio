Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions


Public Class Form_Payment
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim inputted_id_product As New List(Of String)

    Dim selected_listbox_item As String
    Dim selected_listbox_index As String

    Dim ListBox_format As String = "{0,-2} {1,-13} {2,-40} {3,-7} {4,-4} {5,-9}"
    Dim ListBox_format_total As String = "{0,-70} {1,-9}"
    Dim ListBox_format_fetch_Search As String = "{0,-2} {1,-13} {2,-40} {3,-7} {4,-4}"
    Dim ListBox_format_transaction As String = "{0,-4} {1,-23} {2,-50} {3,-20} {4,-20} {5,-20}"


    'search product feature
    Dim fetched_ID, fetched_Name, fetched_Price, inputted_QTY As String

    'store Cart
    Public Cart_Item As New List(Of List(Of String))
    Dim total_cart As Integer

    Dim MATCHED_ID As String


    Public Sub reload(e)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form2_Load(e, e)
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel_Item_Edit.Hide()
        Panel_Check_Product.Hide()
        Label_ListBox_Header.Text = (String.Format(ListBox_format, "#", "Product Code", "Product Name", "Price", "QTY", "Total"))
        Label_Header_Check_Product.Text = (String.Format(ListBox_format_fetch_Search, "#", "Product Code", "Product Name", "Price", "QTY"))
        Label_Listbox_header_transaction.Text = (String.Format(ListBox_format_transaction, "#", "Date", "Product && QTY", "Total Amount", "Received Amount", "Changes"))

        If ListBox_Bill.Items.Count = 0 Then
            total_cart = 0
        End If
        Label_Total_Cart.Text = (String.Format(ListBox_format_total, "Total", total_cart))
        'ListBox_Bill.Items.Add(String.Format(ListBox_format, "1", "136512013651", "Indomie Goreng rasa Mie Sedap", "3200", "12", "500000"))
        'ListBox_Bill.Items.Add(String.Format(ListBox_format, "13", "136512013651", "Indomie Goreng rasa Mie Sedap", "3200", "12", "500000"))


        TextBox_QTY.Enabled = False

        StartShiftToolStripMenuItem.Enabled = False
        FinishShiftToolStripMenuItem.Enabled = True
        LockCashierToolStripMenuItem.Enabled = True

        If Cart_Item.Count = 0 Then
            Button_Bill.Enabled = False
        Else
            Button_Bill.Enabled = True
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub LockCashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockCashierToolStripMenuItem.Click
        'Locking the program. but litteraly same as finish but. you don't have to insert ID again and show there is someone incahrge on this client program.


        Dim finish As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim READER As MySqlDataReader
        Console.WriteLine(finish)
        'update DB finish time
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"

        Try
            Mysqlconn.Open()
            Dim query As String = "update vb11store_cashier.cashier_attendance set finish_time='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where id='" & Form1.ID & "' AND id_cashier='" & Form1.id_cashier & "'"
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        Form1.states("login") = False


        Me.Hide()
        Lock_Cashier.Show()
    End Sub



    Private Sub FinishShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishShiftToolStripMenuItem.Click
        Dim finish As String = DateTime.Now.ToString("mm/dd/yyyy HH:mm:ss")
        Dim READER As MySqlDataReader
        Console.WriteLine(finish)
        'update DB finish time
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"

        Try
            Mysqlconn.Open()
            Dim query As String = "update vb11store_cashier.cashier_attendance set finish_time='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where id='" & Form1.ID & "' AND id_cashier='" & Form1.id_cashier & "'"
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try




        'show msgbox containing working hours, number of transaction.
        MessageBox.Show("THANK YOU FOR YOUR SERVICE!")
        'then OK show Login Form.
        Me.Hide()
        Form1.states("login") = False
        Console.WriteLine(Form1.states("login"))

        Form1.reload(e)
        Form1.Show()
    End Sub

    Private Sub ListBox_Bill_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Bill.SelectedIndexChanged
        selected_listbox_item = ListBox_Bill.SelectedItem
        selected_listbox_index = ListBox_Bill.SelectedIndex


        Dim regex As Regex = New Regex("\[(.*?)\]")

        Dim match As Match = regex.Match(selected_listbox_item)

        If match.Success Then
            'MessageBox.Show(match.Value.Substring(1, match.Value.Length - 2))
            MATCHED_ID = match.Value.Substring(1, match.Value.Length - 2)
        Else
            MessageBox.Show("NO Matching")
        End If

        Label_Edit_Id.Text = MATCHED_ID

        For Each item As List(Of String) In Cart_Item
            If item(0) = MATCHED_ID Then
                'MessageBox.Show(MATCHED_ID & " Found!")
                TextBox_Edit_pcs.Text = item(3)
            End If
        Next


        Panel_Item_Edit.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_Item_Edit.Hide()
        TextBox_Search.Focus()
    End Sub

    Private Sub TextBox_Search_Click(sender As Object, e As EventArgs) Handles TextBox_Search.Click
        Panel_Item_Edit.Hide()

    End Sub

    Private Sub TextBox_Edit_pcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Edit_pcs.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True


            Dim new_pcs As Integer = TextBox_Edit_pcs.Text
            If new_pcs <> 0 Then


                For Each item As List(Of String) In Cart_Item
                    If item(0) = MATCHED_ID Then
                        Dim new_total_price As Integer = new_pcs * item(2)
                        MessageBox.Show("Total qty : " & new_pcs)
                        MessageBox.Show("Total Price : " & new_total_price)
                        item(3) = new_pcs
                        item(4) = new_total_price


                    End If
                Next

            Else
                'remove dari list
                Button1_Click(sender, e)
            End If


            ListBox_Bill.Items.Clear()

            Dim num As Integer
            total_cart = 0
            For Each i As List(Of String) In Cart_Item
                num = num + 1
                ListBox_Bill.Items.Add(String.Format(ListBox_format, num, "[" & i(0) & "]", i(1), i(2), i(3), i(4)))
                total_cart = i(4) + total_cart
                Label_Total_Cart.Text = (String.Format(ListBox_format_total, "Total", total_cart))

            Next


            TextBox_Search.Focus()
            Panel_Item_Edit.Hide()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim remove_index As Integer = 0

        For Each item As List(Of String) In Cart_Item
            If item(0) = MATCHED_ID Then
                Exit For
            End If
            remove_index = remove_index + 1

        Next
        MessageBox.Show("Before : " & Cart_Item.Count)
        Cart_Item.RemoveAt(remove_index)
        MessageBox.Show("After : " & Cart_Item.Count)


        total_cart = 0
        Dim num As Integer
        ListBox_Bill.Items.Clear()

        For Each i As List(Of String) In Cart_Item
            num = num + 1
            ListBox_Bill.Items.Add(String.Format(ListBox_format, num, "[" & i(0) & "]", i(1), i(2), i(3), i(4)))
            total_cart = i(4) + total_cart
            Label_Total_Cart.Text = (String.Format(ListBox_format_total, "total", total_cart))

        Next

        TextBox_Search.Focus()
        Panel_Item_Edit.Hide()

        If Cart_Item.Count = 0 Then
            Button_Bill.Enabled = False
        Else
            Button_Bill.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button_Bill.Click
        'System.Diagnostics.Process.Start("http://www.yahoo.com")
        Form4.Label_TA.Text = total_cart
        Form4.Show()
    End Sub

    Private Sub Button_CheckOut_Click(sender As Object, e As EventArgs) Handles Button_CheckOut.Click
        Panel_CheckOut.Show()
        Panel_Check_Product.Hide()
        Panel_Transaction.Hide()
    End Sub

    Private Sub Button_Product_Check_Click(sender As Object, e As EventArgs) Handles Button_Product_Check.Click
        Panel_CheckOut.Hide()
        Panel_Transaction.Hide()
        Panel_Check_Product.Show()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Search_Product_Check.KeyPress
        'SEARCHing PRODUCT BUTTON

        Dim fetched_ID_searching As String
        Dim fetched_Name_searching As String
        Dim fetched_price_searching As String

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True



            ListBox_Fetched_Search.Items.Clear()

            Dim READER As MySqlDataReader
            Dim product_searching As String = TextBox_Search_Product_Check.Text
            Dim query As String



            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


            Try
                Mysqlconn.Open()
                query = "select * from product where product_code like '%" & product_searching & "%' or product_name like '%" & product_searching & "%'"

                COMMAND = New MySqlCommand(query, Mysqlconn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                'check result. 
                While READER.Read
                    count = count + 1
                End While

                Mysqlconn.Close()

                Console.WriteLine(count)
                If count = 0 Then
                    MessageBox.Show("There is no product containing """ & product_searching & """")

                ElseIf count > 0 Then
                    Mysqlconn.Open()
                    COMMAND = New MySqlCommand(query, Mysqlconn)
                    READER = COMMAND.ExecuteReader


                    Dim index As Integer = 1
                    While READER.Read
                        fetched_ID_searching = READER.GetString("product_code")
                        fetched_Name_searching = READER.GetString("product_name")
                        fetched_Price_searching = READER.GetString("price")

                        ListBox_Fetched_Search.Items.Add(String.Format(ListBox_format_fetch_Search, index, fetched_ID_searching, fetched_Name_searching, fetched_price_searching, "STOCK"))

                        index = index + 1
                    End While
                    Mysqlconn.Close()


                    Dim i As Integer = 0
                    For Each id As String In inputted_id_product
                        i = i + 1
                        Console.WriteLine(i & " " & id)
                    Next
                    Mysqlconn.Close()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Mysqlconn.Dispose()
            End Try


        End If
    End Sub

    Private Sub Button_clear_All_Click(sender As Object, e As EventArgs) Handles Button_clear_All.Click
        Me.reload(e)
        Cart_Item.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()

        Dim READER As MySqlDataReader

        Dim query As String



        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            query = "select * from transaction"

            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            'check result. 
            While READER.Read
                count = count + 1
            End While

            Mysqlconn.Close()


            If count <> 0 Then

                Mysqlconn.Open()
                query = "select * from transaction"

                COMMAND = New MySqlCommand(query, Mysqlconn)
                READER = COMMAND.ExecuteReader

                'check result. 
                Dim num As Integer = 1
                While READER.Read
                    Dim date_entry As String = Convert.ToDateTime(READER.GetString("date_entry"))
                    Dim Product_QTY = READER.GetString("str_product_qty")
                    Dim total_amount = READER.GetString("total_amount")
                    Dim received_amount = READER.GetString("received_amount")
                    Dim changes_amount = READER.GetString("changes_amount")

                    If Product_QTY.Length > 50 Then
                        Product_QTY = Product_QTY.Substring(0, 50)
                    End If

                    ListBox1.Items.Add(String.Format(ListBox_format_transaction, num, date_entry, Product_QTY, total_amount, received_amount, changes_amount))
                    num = num + 1
                End While

                Mysqlconn.Close()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try


        Panel_Transaction.Show()
        Panel_CheckOut.Hide()
        Panel_Check_Product.Hide()
    End Sub

    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        TextBox_QTY.Text = 1
        TextBox_QTY.Enabled = False
    End Sub

    Private Sub TextBox_Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then


            Search()
            e.Handled = True

        End If
    End Sub



    Private Sub TextBox_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_QTY.KeyPress
        Dim data_exist As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True

            'Input to the list
            inputted_QTY = TextBox_QTY.Text
            'MessageBox.Show(inputted_QTY)
            If inputted_QTY <> 0 Then
                ''cek dulu di LIST cart item ini uda ada belum, kalau uda jangan bikin reocrd baru tpi add di record sebelumnya
                For Each item As List(Of String) In Cart_Item
                    If item(0) = fetched_ID Then
                        data_exist = True
                        MessageBox.Show("item exist before")

                        'if exist brrti kita update di list ini saja tidka tambah baru
                        Dim new_qty As Integer = Convert.ToInt32(item(3)) + Convert.ToInt32(inputted_QTY)
                        Dim new_total_price As Integer = new_qty * fetched_Price
                        ' MessageBox.Show("Total qty : " & new_qty)
                        ' MessageBox.Show("Total Price : " & new_total_price)


                        item(3) = new_qty
                        item(4) = new_total_price


                        'MessageBox.Show(item(0) & " -- " & item(1) & " -- " & item(2) & " -- " & item(3) & " -- " & item(4))
                    End If

                Next

                If data_exist = False Then

                    Dim total_price As Integer = Convert.ToInt32(fetched_Price) * Convert.ToInt32(inputted_QTY)
                    Dim List_Item As New List(Of String)({fetched_ID, fetched_Name, fetched_Price, inputted_QTY, total_price})
                    Cart_Item.Add(List_Item)
                    Dim num As Integer = ListBox_Bill.Items.Count + 1
                    ListBox_Bill.Items.Add(String.Format(ListBox_format, num, "[" & fetched_ID & "]", fetched_Name, fetched_Price, inputted_QTY, total_price))

                    'update total price
                    total_cart = total_cart + total_price
                ElseIf data_exist = True Then
                    ListBox_Bill.Items.Clear()


                    Dim num As Integer
                    total_cart = 0
                    For Each item As List(Of String) In Cart_Item
                        num = num + 1
                        ListBox_Bill.Items.Add(String.Format(ListBox_format, num, "[" & item(0) & "]", item(1), item(2), item(3), item(4)))
                        total_cart = item(4) + total_cart
                    Next

                End If

                Label_Total_Cart.Text = (String.Format(ListBox_format_total, "Total", total_cart))



            End If

            If Cart_Item.Count = 0 Then
                Button_Bill.Enabled = False
            Else
                Button_Bill.Enabled = True
            End If
            Label_Product_Name_Display.Text = "Input Product Code Or Name"
            TextBox_QTY.Enabled = False
            TextBox_QTY.Text = 1
            TextBox_Search.Clear()
            TextBox_Search.Focus()
        End If
    End Sub

    Private Sub Search()
        Dim READER As MySqlDataReader
        Dim product_code_search As String = TextBox_Search.Text
        Dim query As String



        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            query = "select * from product where product_code like '%" & product_code_search & "%' or product_name like '%" & product_code_search & "%'"

            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            'check result. 
            While READER.Read
                count = count + 1
            End While

            Mysqlconn.Close()

            Console.WriteLine(count)
            If count > 1 Then
                MessageBox.Show("Please be More Specific. With Names or Product Code")
            ElseIf count = 0 Then
                MessageBox.Show("There is no product containing """ & product_code_search & """")

            ElseIf count = 1 Then
                'MessageBox.Show("Product Found")
                TextBox_QTY.Enabled = True

                'cocok nih ceritanya.
                Mysqlconn.Open()
                COMMAND = New MySqlCommand(query, Mysqlconn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    fetched_ID = READER.GetString("product_code")
                    fetched_Name = READER.GetString("product_name")
                    fetched_Price = READER.GetString("price")
                    'MessageBox.Show(READER.GetString("product_code"))


                    Label_Product_Name_Display.Text = READER.GetString("product_code") & " - " & READER.GetString("product_name") & " - " & READER.GetString("price")
                End While
                Mysqlconn.Close()


                Dim i As Integer = 0
                For Each id As String In inputted_id_product
                    i = i + 1
                    Console.WriteLine(i & " " & id)
                Next
                Mysqlconn.Close()

                ''''AFTER display nama productnya tab untuk isi jumlahnya
                SendKeys.Send("{TAB}")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

    End Sub

End Class