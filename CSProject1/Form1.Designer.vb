<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        tbUN = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tbPASS = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(221, 38)
        Button1.TabIndex = 0
        Button1.Text = "Check Connection"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tbUN
        ' 
        tbUN.Location = New Point(365, 157)
        tbUN.Name = "tbUN"
        tbUN.Size = New Size(167, 23)
        tbUN.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(251, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 26)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(257, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 26)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' tbPASS
        ' 
        tbPASS.Location = New Point(365, 207)
        tbPASS.Name = "tbPASS"
        tbPASS.PasswordChar = "*"c
        tbPASS.Size = New Size(167, 23)
        tbPASS.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(363, 256)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 35)
        Button2.TabIndex = 0
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbPASS)
        Controls.Add(tbUN)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tbUN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPASS As TextBox
    Friend WithEvents Button2 As Button

End Class
