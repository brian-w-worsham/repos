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
        Me.TextBoxFirstNum = New System.Windows.Forms.TextBox()
        Me.TextBoxSecondNum = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.LabelFirstNum = New System.Windows.Forms.Label()
        Me.LabelSecondNum = New System.Windows.Forms.Label()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxFirstNum
        '
        Me.TextBoxFirstNum.Location = New System.Drawing.Point(881, 172)
        Me.TextBoxFirstNum.Name = "TextBoxFirstNum"
        Me.TextBoxFirstNum.Size = New System.Drawing.Size(549, 26)
        Me.TextBoxFirstNum.TabIndex = 0
        '
        'TextBoxSecondNum
        '
        Me.TextBoxSecondNum.Location = New System.Drawing.Point(881, 268)
        Me.TextBoxSecondNum.Name = "TextBoxSecondNum"
        Me.TextBoxSecondNum.Size = New System.Drawing.Size(549, 26)
        Me.TextBoxSecondNum.TabIndex = 1
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(881, 394)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(83, 33)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'LabelFirstNum
        '
        Me.LabelFirstNum.AutoSize = True
        Me.LabelFirstNum.Location = New System.Drawing.Point(730, 172)
        Me.LabelFirstNum.Name = "LabelFirstNum"
        Me.LabelFirstNum.Size = New System.Drawing.Size(104, 20)
        Me.LabelFirstNum.TabIndex = 3
        Me.LabelFirstNum.Text = "First Number:"
        '
        'LabelSecondNum
        '
        Me.LabelSecondNum.AutoSize = True
        Me.LabelSecondNum.Location = New System.Drawing.Point(734, 268)
        Me.LabelSecondNum.Name = "LabelSecondNum"
        Me.LabelSecondNum.Size = New System.Drawing.Size(128, 20)
        Me.LabelSecondNum.TabIndex = 4
        Me.LabelSecondNum.Text = "Second Number:"
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Location = New System.Drawing.Point(1031, 394)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(83, 33)
        Me.ButtonSubtract.TabIndex = 5
        Me.ButtonSubtract.Text = "Subtract"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(1192, 394)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(83, 33)
        Me.ButtonMultiply.TabIndex = 6
        Me.ButtonMultiply.Text = "Multiply"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(1347, 394)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(83, 33)
        Me.ButtonDivide.TabIndex = 7
        Me.ButtonDivide.Text = "Divide"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(738, 491)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(63, 20)
        Me.LabelResult.TabIndex = 8
        Me.LabelResult.Text = "Result: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(2346, 1395)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.LabelSecondNum)
        Me.Controls.Add(Me.LabelFirstNum)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxSecondNum)
        Me.Controls.Add(Me.TextBoxFirstNum)
        Me.Name = "Form1"
        Me.Text = "SimpleCalculator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFirstNum As TextBox
    Friend WithEvents TextBoxSecondNum As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents LabelFirstNum As Label
    Friend WithEvents LabelSecondNum As Label
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents LabelResult As Label
End Class
