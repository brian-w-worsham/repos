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
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(23, 26)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInput.Size = New System.Drawing.Size(657, 101)
        Me.TextBoxInput.TabIndex = 0
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(23, 157)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(657, 34)
        Me.BtnSubmit.TabIndex = 1
        Me.BtnSubmit.Text = "Count Characters Typed"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Name = "Form1"
        Me.Text = "CharacterCounter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents BtnSubmit As Button
End Class
