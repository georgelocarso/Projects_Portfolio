<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinishShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockCashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutKashierVB11StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogedIn_Panel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Login_Panel.SuspendLayout()
        Me.LogedIn_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartShiftToolStripMenuItem, Me.FinishShiftToolStripMenuItem, Me.LockCashierToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'StartShiftToolStripMenuItem
        '
        Me.StartShiftToolStripMenuItem.Name = "StartShiftToolStripMenuItem"
        Me.StartShiftToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StartShiftToolStripMenuItem.Text = "Start Shift"
        '
        'FinishShiftToolStripMenuItem
        '
        Me.FinishShiftToolStripMenuItem.Name = "FinishShiftToolStripMenuItem"
        Me.FinishShiftToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FinishShiftToolStripMenuItem.Text = "Finish Shift"
        '
        'LockCashierToolStripMenuItem
        '
        Me.LockCashierToolStripMenuItem.Name = "LockCashierToolStripMenuItem"
        Me.LockCashierToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.LockCashierToolStripMenuItem.Text = "Lock Cashier"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AboutToolStripMenuItem.Text = "Setting"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.AboutKashierVB11StoreToolStripMenuItem})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem1.Text = "Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'AboutKashierVB11StoreToolStripMenuItem
        '
        Me.AboutKashierVB11StoreToolStripMenuItem.Name = "AboutKashierVB11StoreToolStripMenuItem"
        Me.AboutKashierVB11StoreToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AboutKashierVB11StoreToolStripMenuItem.Text = "About Kashier VB11 Store"
        '
        'Login_Panel
        '
        Me.Login_Panel.Controls.Add(Me.Login_Button)
        Me.Login_Panel.Controls.Add(Me.TextBox_Pass)
        Me.Login_Panel.Controls.Add(Me.TextBox_ID)
        Me.Login_Panel.Controls.Add(Me.Label3)
        Me.Login_Panel.Controls.Add(Me.Label2)
        Me.Login_Panel.Controls.Add(Me.Label1)
        Me.Login_Panel.Location = New System.Drawing.Point(139, 65)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(552, 318)
        Me.Login_Panel.TabIndex = 1
        '
        'Login_Button
        '
        Me.Login_Button.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Login_Button.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(274, 212)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(210, 48)
        Me.Login_Button.TabIndex = 2
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = False
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pass.Location = New System.Drawing.Point(274, 153)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass.Size = New System.Drawing.Size(210, 38)
        Me.TextBox_Pass.TabIndex = 1
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ID.Location = New System.Drawing.Point(274, 103)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(210, 38)
        Me.TextBox_ID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CASHIER LOGIN"
        '
        'LogedIn_Panel
        '
        Me.LogedIn_Panel.Controls.Add(Me.Button2)
        Me.LogedIn_Panel.Controls.Add(Me.Label5)
        Me.LogedIn_Panel.Controls.Add(Me.Label4)
        Me.LogedIn_Panel.Location = New System.Drawing.Point(139, 45)
        Me.LogedIn_Panel.Name = "LogedIn_Panel"
        Me.LogedIn_Panel.Size = New System.Drawing.Size(552, 318)
        Me.LogedIn_Panel.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Book", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(56, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 62)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Start Shift"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(395, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To Start your shift press button down below."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 43)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hi, Cashier."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Login_Panel)
        Me.Controls.Add(Me.LogedIn_Panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Kashier VB11 Store"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Login_Panel.ResumeLayout(False)
        Me.Login_Panel.PerformLayout()
        Me.LogedIn_Panel.ResumeLayout(False)
        Me.LogedIn_Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartShiftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinishShiftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockCashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutKashierVB11StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Login_Button As Button
    Friend WithEvents LogedIn_Panel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
