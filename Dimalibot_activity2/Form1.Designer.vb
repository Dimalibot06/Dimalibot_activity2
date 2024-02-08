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
        txtfirstnum = New TextBox()
        Label2 = New Label()
        txtsecondnum = New TextBox()
        btnsubtract = New Button()
        Lblresult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "First number"
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(27, 52)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second number"
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(27, 96)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(100, 23)
        txtsecondnum.TabIndex = 3
        ' 
        ' btnsubtract
        ' 
        btnsubtract.Location = New Point(26, 125)
        btnsubtract.Name = "btnsubtract"
        btnsubtract.Size = New Size(75, 23)
        btnsubtract.TabIndex = 4
        btnsubtract.Text = "subtract"
        btnsubtract.UseVisualStyleBackColor = True
        ' 
        ' Lblresult
        ' 
        Lblresult.AutoSize = True
        Lblresult.Location = New Point(38, 161)
        Lblresult.Name = "Lblresult"
        Lblresult.Size = New Size(41, 15)
        Lblresult.TabIndex = 5
        Lblresult.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 450)
        Controls.Add(Lblresult)
        Controls.Add(btnsubtract)
        Controls.Add(txtsecondnum)
        Controls.Add(Label2)
        Controls.Add(txtfirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents btnsubtract As Button
    Friend WithEvents Lblresult As Label
End Class
