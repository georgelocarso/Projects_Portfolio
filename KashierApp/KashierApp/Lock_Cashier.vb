Imports MySql.Data.MySqlClient
Public Class Lock_Cashier
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Lock_Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        MenuStrip1.Enabled = False
        TextBox_ID.Text = Form1.id_cashier

    End Sub

    Private Sub Relogin_Button_Click(sender As Object, e As EventArgs) Handles Relogin_Button.Click
        Dim READER As MySqlDataReader
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=myvb_learn"


        Try
            Mysqlconn.Open()
            Dim query As String = "select * from vb11store_cashier.cashier_account where id_cashier ='" & TextBox_ID.Text & "' and password ='" & TextBox_Pass.Text & "' "
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                'MessageBox.Show("Usernem Pass correct")
                Form1.id_cashier = TextBox_ID.Text
                Form1.states("login") = True
                FinishShiftToolStripMenuItem.Enabled = False
                LockCashierToolStripMenuItem.Enabled = False
                Me.Hide()
                Form1.Show()
                Form1.reload(e)
            ElseIf count > 1 Then
                MessageBox.Show("duplicated value UN n P")
            Else
                MessageBox.Show("Wrong Password r ursernem")
            End If

            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Lock_Cashier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub
End Class