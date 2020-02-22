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
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelCustomer
        '
        Me.LabelCustomer.AutoSize = True
        Me.LabelCustomer.Location = New System.Drawing.Point(13, 13)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(100, 20)
        Me.LabelCustomer.TabIndex = 0
        Me.LabelCustomer.Text = "CUSTOMER"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(17, 67)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(55, 20)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Name:"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(17, 116)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(72, 20)
        Me.LabelAddress.TabIndex = 2
        Me.LabelAddress.Text = "Address:"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Location = New System.Drawing.Point(17, 174)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(59, 20)
        Me.LabelPhone.TabIndex = 3
        Me.LabelPhone.Text = "Phone:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(98, 61)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(646, 26)
        Me.TextBoxName.TabIndex = 4
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(98, 110)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(646, 26)
        Me.TextBoxAddress.TabIndex = 5
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Location = New System.Drawing.Point(98, 168)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(646, 26)
        Me.TextBoxPhone.TabIndex = 6
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(98, 285)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(165, 34)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonCustomer
        '
        Me.ButtonCustomer.Location = New System.Drawing.Point(305, 285)
        Me.ButtonCustomer.Name = "ButtonCustomer"
        Me.ButtonCustomer.Size = New System.Drawing.Size(165, 34)
        Me.ButtonCustomer.TabIndex = 8
        Me.ButtonCustomer.Text = "Customer"
        Me.ButtonCustomer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCustomer)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.TextBoxPhone)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Name = "Form1"
        Me.Text = "SubMethod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCustomer As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonCustomer As Button
End Class
