<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lock_Cashier
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinishShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockCashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutKashierVB11StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Relogin_Button = New System.Windows.Forms.Button()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cashier Locked"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_ID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Relogin_Button)
        Me.Panel1.Controls.Add(Me.TextBox_Pass)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 384)
        Me.Panel1.TabIndex = 3
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ID.Location = New System.Drawing.Point(390, 215)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(210, 38)
        Me.TextBox_ID.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KashierApp.My.Resources.Resources._6740967_preview
        Me.PictureBox1.Location = New System.Drawing.Point(328, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Relogin_Button
        '
        Me.Relogin_Button.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Relogin_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Relogin_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Relogin_Button.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Relogin_Button.Location = New System.Drawing.Point(390, 324)
        Me.Relogin_Button.Name = "Relogin_Button"
        Me.Relogin_Button.Size = New System.Drawing.Size(210, 48)
        Me.Relogin_Button.TabIndex = 5
        Me.Relogin_Button.Text = "Login"
        Me.Relogin_Button.UseVisualStyleBackColor = False
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pass.Location = New System.Drawing.Point(390, 265)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass.Size = New System.Drawing.Size(210, 38)
        Me.TextBox_Pass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID NUMBER"
        '
        'Lock_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Lock_Cashier"
        Me.Text = "Same name im suppose"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartShiftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinishShiftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockCashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutKashierVB11StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Relogin_Button As Button
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_ID As TextBox
End Class
