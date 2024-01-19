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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 23)
        Label1.TabIndex = 0
        Label1.Text = "Enter a word:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(72, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(528, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(75, 110)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(462, 88)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 104)
        ListBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 6
        Label2.Text = "Case"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(224, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 7
        Label3.Text = "Colour"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(205, 72)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(72, 24)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Purple"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(205, 115)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(59, 24)
        RadioButton4.TabIndex = 9
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 72)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(91, 24)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.Text = "To Upper"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 115)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(90, 24)
        RadioButton2.TabIndex = 11
        RadioButton2.TabStop = True
        RadioButton2.Text = "To Lower"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(398, 217)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(351, 222)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(109, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 13
        Label4.Text = "Label for display"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label

End Class
