Imports MySql.Data.MySqlClient

Public Class Form1
    'sql varibales declaration
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim sql_conn_status As Boolean
    Public id_cashier As String
    Public ID As String
    Dim attnd_rows As Integer


    Public states As New Dictionary(Of String, Boolean) From {{"login", False}, {"start", False}, {"finish", False}, {"lock", False}}

    'states 
    'ada Login, start shift, finish shift, lock cashier. starting with false boolean.

    Public Function reload(e)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form1_Load(e, e)

        Return 0
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'every Load Check connection dulu
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            sql_conn_status = True
            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try




        If sql_conn_status <> False Then
            Me.CenterToScreen()

            If states("login") = False Then

                MenuStrip1.Enabled = False
                Login_Panel.Show()
                LogedIn_Panel.Hide()
                Console.WriteLine("blm login")
            Else
                MenuStrip1.Enabled = True
                Login_Panel.Hide()
                LogedIn_Panel.Show()
                Console.WriteLine("sudah login")
            End If
        Else
            MessageBox.Show("Please Check Your Device Connection!", "DB Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.ExitThread()
        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
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
                id_cashier = TextBox_ID.Text
                states("login") = True
                FinishShiftToolStripMenuItem.Enabled = False
                LockCashierToolStripMenuItem.Enabled = False
                Form1_Load(sender, e)
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

    Private Sub StartShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartShiftToolStripMenuItem.Click


        'shift state start.
        states("start") = True
        'update to DB start time.
        Dim READER As MySqlDataReader
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            Dim query As String = "select * from vb11store_cashier.cashier_attendance"
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader

            attnd_rows = 0
            While READER.Read
                attnd_rows = attnd_rows + 1
            End While
            Console.WriteLine(attnd_rows)

            ID = id_cashier + attnd_rows.ToString

            Console.WriteLine("ID : " + ID)
            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try





        'insert to DB


        Console.WriteLine(ID)



        Try
            Mysqlconn.Open()
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))


            Dim query2 As String = "insert into cashier_attendance(id,id_cashier,start_time) VALUES ('" & ID & "','" & id_cashier & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            COMMAND = New MySqlCommand(query2, Mysqlconn)
            READER = COMMAND.ExecuteReader



            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        'WITH SQL INJECTION PREVENTION
        '        Try
        '       Dim SqlQuery As String = "INSERT INTO vb11store_cashier.cashier_attendance(id,id_cashier) VALUES (@id,@id_cashier)"
        '      Using con = New MySqlConnection("Server = localhost;Database = vb11store_cashier; Uid=root; Pwd =")
        '    Using SQLcmd = New MySqlCommand(SqlQuery, con)
        '                 Console.WriteLine("CHECKKKKK : " + ID)
        '   SQLcmd.Connection.Open()
        ' SQLcmd.Parameters.Add(New MySqlParameter("@id", ID))
        '      SQLcmd.Parameters.Add(New MySqlParameter("@id_cashier", TextBox_ID.Text))
        '
        '   SQLcmd.ExecuteNonQuery()


        '   SQLcmd.Connection.Close()
        '  End Using


        '  End Using




        '  Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try










        'open Cashiering Form.
        Me.Hide()
        Form_Payment.Show()

        'enable Finish shift menu & Lock Cashier Menu
        '        StartShiftToolStripMenuItem.Enabled = False
        '       FinishShiftToolStripMenuItem.Enabled = True
        '      LockCashierToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'duplicate ofstartshift menu 

        'shift state start.
        states("start") = True
        'update to DB start time.
        Dim READER As MySqlDataReader
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=;database=vb11store_cashier"


        Try
            Mysqlconn.Open()
            Dim query As String = "select * from vb11store_cashier.cashier_attendance"
            COMMAND = New MySqlCommand(query, Mysqlconn)
            READER = COMMAND.ExecuteReader

            attnd_rows = 0
            While READER.Read
                attnd_rows = attnd_rows + 1
            End While
            Console.WriteLine(attnd_rows)

            ID = id_cashier + attnd_rows.ToString

            Console.WriteLine("ID : " + ID)
            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        'insert to DB


        Console.WriteLine(ID)



        Try
            Mysqlconn.Open()
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Dim query2 As String = "insert into cashier_attendance(id,id_cashier,start_time) VALUES ('" & ID & "','" & id_cashier & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            COMMAND = New MySqlCommand(query2, Mysqlconn)
            READER = COMMAND.ExecuteReader





            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

        'open Cashiering Form.
        Me.Hide()
        Form_Payment.Show()
    End Sub
End Class
