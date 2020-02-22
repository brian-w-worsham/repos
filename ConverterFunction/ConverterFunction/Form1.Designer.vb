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
        Me.LabelCentimeters = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelEquals = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelCentimeters
        '
        Me.LabelCentimeters.AutoSize = True
        Me.LabelCentimeters.Location = New System.Drawing.Point(33, 34)
        Me.LabelCentimeters.Name = "LabelCentimeters"
        Me.LabelCentimeters.Size = New System.Drawing.Size(95, 20)
        Me.LabelCentimeters.TabIndex = 0
        Me.LabelCentimeters.Text = "Centimeters"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(37, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        '
        'LabelEquals
        '
        Me.LabelEquals.AutoSize = True
        Me.LabelEquals.Location = New System.Drawing.Point(163, 91)
        Me.LabelEquals.Name = "LabelEquals"
        Me.LabelEquals.Size = New System.Drawing.Size(18, 20)
        Me.LabelEquals.TabIndex = 2
        Me.LabelEquals.Text = "="
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(199, 91)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(18, 20)
        Me.LabelResult.TabIndex = 3
        Me.LabelResult.Text = "?"
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Location = New System.Drawing.Point(37, 153)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(182, 32)
        Me.ButtonConvert.TabIndex = 4
        Me.ButtonConvert.Text = "Convert to Inches"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 249)
        Me.Controls.Add(Me.ButtonConvert)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.LabelEquals)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelCentimeters)
        Me.Name = "Form1"
        Me.Text = "ConverterFunction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCentimeters As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelEquals As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents ButtonConvert As Button
End Class
