Imports MySql.Data.MySqlClient

Public Class Form3
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim fetched_ID, fetched_Name, fetched_Price, inputted_QTY As String
    Dim cart_items As New List(Of List(Of String))


    Private Sub TextBox_Tabbed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Tabbed.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            inputted_QTY = TextBox_Tabbed.Text

            Dim list As New List(Of String)
            list.Add(fetched_ID)
            list.Add(fetched_Name)
            list.Add(fetched_Price)
            list.Add(inputted_QTY)


            cart_items.Add(list)
            MessageBox.Show("Succesly added to List i suppose")
            ListBox1.Items.Clear()
            For Each i As List(Of String) In cart_items
                Dim text As String = ""
                For Each j As String In i
                    text = text & " - " & j
                Next

                Label1.Text = text
                ListBox1.Items.Add(text)
            Next

            For Each item As List(Of String) In cart_items
                For i As Integer = 0 To 3 Step 1
                    MessageBox.Show(item(i))
                Next
            Next

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim READER As MySqlDataReader
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            Dim product_code_search As String = TextBox1.Text
            Dim query As String
            query = "select * from product where product_code like '%" & product_code_search & "%'"

            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            While READER.Read
                Label1.Text = READER.GetString("product_code") & " - " & READER.GetString("product_name") & " - " & READER.GetString("price")

                fetched_ID = READER.GetString("product_code")
                fetched_Name = READER.GetString("product_name")
                fetched_Price = READER.GetString("price")

                count = count + 1
            End While

            If count <> 1 Then
                MessageBox.Show("Product Code is not valid")
            End If


            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            MessageBox.Show("Enter key pressed")
            Button1_Click(sender, e)

            SendKeys.Send("{TAB}")
        End If
    End Sub


End Class