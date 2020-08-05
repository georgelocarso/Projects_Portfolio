<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_TA = New System.Windows.Forms.Label()
        Me.Button_Print = New System.Windows.Forms.Button()
        Me.TextBox_Receive = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_Changes = New System.Windows.Forms.Panel()
        Me.Label_Changes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Main.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_Changes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel_Main.Controls.Add(Me.Label5)
        Me.Panel_Main.Controls.Add(Me.Label_TA)
        Me.Panel_Main.Controls.Add(Me.Button_Print)
        Me.Panel_Main.Controls.Add(Me.TextBox_Receive)
        Me.Panel_Main.Controls.Add(Me.Label2)
        Me.Panel_Main.Controls.Add(Me.Label1)
        Me.Panel_Main.Controls.Add(Me.Button1)
        Me.Panel_Main.Location = New System.Drawing.Point(15, 14)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(780, 426)
        Me.Panel_Main.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumBlue
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(293, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 61)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rp."
        '
        'Label_TA
        '
        Me.Label_TA.AutoSize = True
        Me.Label_TA.BackColor = System.Drawing.Color.MediumBlue
        Me.Label_TA.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TA.Location = New System.Drawing.Point(379, 72)
        Me.Label_TA.Name = "Label_TA"
        Me.Label_TA.Size = New System.Drawing.Size(55, 61)
        Me.Label_TA.TabIndex = 7
        Me.Label_TA.Text = "0"
        '
        'Button_Print
        '
        Me.Button_Print.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Print.Location = New System.Drawing.Point(255, 232)
        Me.Button_Print.Name = "Button_Print"
        Me.Button_Print.Size = New System.Drawing.Size(261, 75)
        Me.Button_Print.TabIndex = 6
        Me.Button_Print.Text = "Print Bill"
        Me.Button_Print.UseVisualStyleBackColor = True
        '
        'TextBox_Receive
        '
        Me.TextBox_Receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Receive.Location = New System.Drawing.Point(292, 141)
        Me.TextBox_Receive.Name = "TextBox_Receive"
        Me.TextBox_Receive.Size = New System.Drawing.Size(421, 49)
        Me.TextBox_Receive.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 61)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Received : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaction Amount"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImage = Global.KashierApp.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Book", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Panel_Main)
        Me.Panel2.Controls.Add(Me.Panel_Changes)
        Me.Panel2.Location = New System.Drawing.Point(-6, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 470)
        Me.Panel2.TabIndex = 1
        '
        'Panel_Changes
        '
        Me.Panel_Changes.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel_Changes.Controls.Add(Me.Label_Changes)
        Me.Panel_Changes.Controls.Add(Me.Label3)
        Me.Panel_Changes.Controls.Add(Me.Button3)
        Me.Panel_Changes.Controls.Add(Me.Label4)
        Me.Panel_Changes.Location = New System.Drawing.Point(15, 14)
        Me.Panel_Changes.Name = "Panel_Changes"
        Me.Panel_Changes.Size = New System.Drawing.Size(780, 426)
        Me.Panel_Changes.TabIndex = 7
        '
        'Label_Changes
        '
        Me.Label_Changes.AutoSize = True
        Me.Label_Changes.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label_Changes.Font = New System.Drawing.Font("Franklin Gothic Book", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Changes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Changes.Location = New System.Drawing.Point(291, 113)
        Me.Label_Changes.Name = "Label_Changes"
        Me.Label_Changes.Size = New System.Drawing.Size(225, 81)
        Me.Label_Changes.TabIndex = 7
        Me.Label_Changes.Text = "10000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(181, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 81)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rp."
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Franklin Gothic Book", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(230, 287)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(261, 75)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Okay"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 81)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Changes"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_Changes.ResumeLayout(False)
        Me.Panel_Changes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Print As Button
    Friend WithEvents TextBox_Receive As TextBox
    Friend WithEvents Panel_Changes As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_Changes As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label_TA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
