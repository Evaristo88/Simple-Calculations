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
        lblFnumber = New Label()
        lblSnumber = New Label()
        btnSum = New Button()
        btnDifference = New Button()
        btnProduct = New Button()
        txtFnumber = New TextBox()
        txtSnumber = New TextBox()
        txtSum = New TextBox()
        txtDifference = New TextBox()
        txtProduct = New TextBox()
        SuspendLayout()
        ' 
        ' lblFnumber
        ' 
        lblFnumber.AutoSize = True
        lblFnumber.Location = New Point(152, 78)
        lblFnumber.Name = "lblFnumber"
        lblFnumber.Size = New Size(115, 25)
        lblFnumber.TabIndex = 0
        lblFnumber.Text = "First Number"
        ' 
        ' lblSnumber
        ' 
        lblSnumber.AutoSize = True
        lblSnumber.Location = New Point(152, 173)
        lblSnumber.Name = "lblSnumber"
        lblSnumber.Size = New Size(141, 25)
        lblSnumber.TabIndex = 1
        lblSnumber.Text = "Second Number"
        ' 
        ' btnSum
        ' 
        btnSum.Location = New Point(152, 282)
        btnSum.Name = "btnSum"
        btnSum.Size = New Size(144, 55)
        btnSum.TabIndex = 2
        btnSum.Text = "Calculate Sum"
        btnSum.UseVisualStyleBackColor = True
        ' 
        ' btnDifference
        ' 
        btnDifference.Location = New Point(152, 401)
        btnDifference.Name = "btnDifference"
        btnDifference.Size = New Size(144, 61)
        btnDifference.TabIndex = 3
        btnDifference.Text = "Calculate Difference"
        btnDifference.UseVisualStyleBackColor = True
        ' 
        ' btnProduct
        ' 
        btnProduct.Location = New Point(152, 523)
        btnProduct.Name = "btnProduct"
        btnProduct.Size = New Size(144, 64)
        btnProduct.TabIndex = 4
        btnProduct.Text = "Calculate Product"
        btnProduct.UseVisualStyleBackColor = True
        ' 
        ' txtFnumber
        ' 
        txtFnumber.Location = New Point(429, 78)
        txtFnumber.Name = "txtFnumber"
        txtFnumber.Size = New Size(216, 31)
        txtFnumber.TabIndex = 5
        ' 
        ' txtSnumber
        ' 
        txtSnumber.Location = New Point(429, 173)
        txtSnumber.Name = "txtSnumber"
        txtSnumber.Size = New Size(216, 31)
        txtSnumber.TabIndex = 6
        ' 
        ' txtSum
        ' 
        txtSum.Location = New Point(429, 294)
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(216, 31)
        txtSum.TabIndex = 7
        ' 
        ' txtDifference
        ' 
        txtDifference.Location = New Point(429, 413)
        txtDifference.Name = "txtDifference"
        txtDifference.Size = New Size(216, 31)
        txtDifference.TabIndex = 8
        ' 
        ' txtProduct
        ' 
        txtProduct.Location = New Point(429, 535)
        txtProduct.Name = "txtProduct"
        txtProduct.Size = New Size(216, 31)
        txtProduct.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1218, 707)
        Controls.Add(txtProduct)
        Controls.Add(txtDifference)
        Controls.Add(txtSum)
        Controls.Add(txtSnumber)
        Controls.Add(txtFnumber)
        Controls.Add(btnProduct)
        Controls.Add(btnDifference)
        Controls.Add(btnSum)
        Controls.Add(lblSnumber)
        Controls.Add(lblFnumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFnumber As Label
    Friend WithEvents lblSnumber As Label
    Friend WithEvents btnSum As Button
    Friend WithEvents btnDifference As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents txtFnumber As TextBox
    Friend WithEvents txtSnumber As TextBox
    Friend WithEvents txtSum As TextBox
    Friend WithEvents txtDifference As TextBox
    Friend WithEvents txtProduct As TextBox

End Class
