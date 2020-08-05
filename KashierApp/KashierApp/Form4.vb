Imports MySql.Data.MySqlClient
Public Class Form4
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Panel_Changes.Hide()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Form_Payment.Enabled = False
        TextBox_Receive.Focus()
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Payment.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Payment.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Print.Click
        'ketika printbill nih, update stok. insert table penjualan 

        Dim received_amount As Integer = Convert.ToInt32(TextBox_Receive.Text)
        Dim transaction_amount As Integer = Convert.ToInt32(Label_TA.Text)
        Dim changes_amount As Integer = received_amount - transaction_amount


        Dim str_product_qty As String = ""

        For Each item As List(Of String) In Form_Payment.Cart_Item
            If str_product_qty = "" Then
                str_product_qty = "(" & item(0) & "," & item(3) & ")"
            Else
                str_product_qty = str_product_qty & ",(" & item(0) & "," & item(3) & ")"
            End If
            'MessageBox.Show(str_product_qty)
        Next

        ''connection insert transaction.
        Dim READER As MySqlDataReader
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"

        Try
            Mysqlconn.Open()
            Dim date_entry As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            Dim query As String = "insert into transaction VALUES ('" & date_entry & "','" & str_product_qty & "','" & transaction_amount & "','" & received_amount & "','" & changes_amount & "')"
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = Command.ExecuteReader

            ' MessageBox.Show("SuCCES")

            Mysqlconn.Close()


            'MessageBox.Show(Form_Payment.Cart_Item.Count)
            'MessageBox.Show(Form_Payment.Cart_Item(0)(0))
            Form_Payment.Cart_Item.Clear()
            'MessageBox.Show(Form_Payment.Cart_Item.Count)
            'MessageBox.Show(Form_Payment.Cart_Item(0)(0))

            Form_Payment.reload(e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try











        Label_Changes.Text = changes_amount

        Panel_Main.Hide()
        Panel_Changes.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_Payment.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label_Changes_Click(sender As Object, e As EventArgs) Handles Label_Changes.Click

    End Sub
End Class