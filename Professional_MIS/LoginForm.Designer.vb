<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(194, 90)
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(167, 22)
        Me.PasswordMaskedTextBox.TabIndex = 2
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Location = New System.Drawing.Point(194, 50)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(167, 22)
        Me.UserIDTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Committee Member: UserID = 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Program Director: UserID = 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password for both is : WCOBISYS"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 216)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordMaskedTextBox As MaskedTextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
