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
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        Button18 = New Button()
        Button17 = New Button()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(17, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 23)
        Button1.TabIndex = 0
        Button1.Text = "Compress Deflate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(166, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 23)
        Button2.TabIndex = 1
        Button2.Text = "Decompress Deflate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(17, 51)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 26)
        Button3.TabIndex = 2
        Button3.Text = "Compress Gzip"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(166, 54)
        Button4.Name = "Button4"
        Button4.Size = New Size(143, 23)
        Button4.TabIndex = 3
        Button4.Text = "Decompress Gzip"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(17, 83)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 23)
        Button5.TabIndex = 4
        Button5.Text = "Compress Zlib"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(166, 83)
        Button6.Name = "Button6"
        Button6.Size = New Size(143, 23)
        Button6.TabIndex = 5
        Button6.Text = "Decompress Zlib"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(17, 112)
        Button7.Name = "Button7"
        Button7.Size = New Size(143, 23)
        Button7.TabIndex = 6
        Button7.Text = "Compress Lzma"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(166, 112)
        Button8.Name = "Button8"
        Button8.Size = New Size(143, 23)
        Button8.TabIndex = 7
        Button8.Text = "DeCompress Lzma"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(17, 141)
        Button9.Name = "Button9"
        Button9.Size = New Size(143, 23)
        Button9.TabIndex = 8
        Button9.Text = "Compress Brotli"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(166, 141)
        Button10.Name = "Button10"
        Button10.Size = New Size(143, 23)
        Button10.TabIndex = 9
        Button10.Text = "Decompress Brotli"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(75, 22)
        Button11.Name = "Button11"
        Button11.Size = New Size(172, 23)
        Button11.TabIndex = 10
        Button11.Text = "Try Get Xml"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(75, 51)
        Button12.Name = "Button12"
        Button12.Size = New Size(172, 23)
        Button12.TabIndex = 11
        Button12.Text = "Try Get Json"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button10)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button9)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button8)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 232)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Compress"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button11)
        GroupBox2.Controls.Add(Button12)
        GroupBox2.Location = New Point(12, 250)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(328, 100)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Document"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button18)
        GroupBox3.Controls.Add(Button17)
        GroupBox3.Controls.Add(Button16)
        GroupBox3.Controls.Add(Button15)
        GroupBox3.Controls.Add(Button14)
        GroupBox3.Controls.Add(Button13)
        GroupBox3.Location = New Point(12, 356)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(328, 132)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        GroupBox3.Text = "Serializator"
        ' 
        ' Button18
        ' 
        Button18.Location = New Point(139, 90)
        Button18.Name = "Button18"
        Button18.Size = New Size(170, 23)
        Button18.TabIndex = 5
        Button18.Text = "DeSerializer Xml"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(17, 90)
        Button17.Name = "Button17"
        Button17.Size = New Size(116, 23)
        Button17.TabIndex = 4
        Button17.Text = "Serializer Xml"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(139, 61)
        Button16.Name = "Button16"
        Button16.Size = New Size(170, 23)
        Button16.TabIndex = 3
        Button16.Text = "DeSerializer Json"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(17, 61)
        Button15.Name = "Button15"
        Button15.Size = New Size(116, 23)
        Button15.TabIndex = 2
        Button15.Text = "Serializer Json"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(139, 32)
        Button14.Name = "Button14"
        Button14.Size = New Size(170, 23)
        Button14.TabIndex = 1
        Button14.Text = "DeSerializer Binary"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(17, 32)
        Button13.Name = "Button13"
        Button13.Size = New Size(116, 23)
        Button13.TabIndex = 0
        Button13.Text = "Serializer Binary"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button

End Class
