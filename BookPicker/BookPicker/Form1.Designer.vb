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
        Me.LstBooks = New System.Windows.Forms.ListBox()
        Me.LabelSelectTitle = New System.Windows.Forms.Label()
        Me.ButtonShowSelection = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstBooks
        '
        Me.LstBooks.FormattingEnabled = True
        Me.LstBooks.ItemHeight = 20
        Me.LstBooks.Location = New System.Drawing.Point(59, 75)
        Me.LstBooks.Name = "LstBooks"
        Me.LstBooks.Size = New System.Drawing.Size(672, 284)
        Me.LstBooks.TabIndex = 0
        '
        'LabelSelectTitle
        '
        Me.LabelSelectTitle.AutoSize = True
        Me.LabelSelectTitle.Location = New System.Drawing.Point(55, 34)
        Me.LabelSelectTitle.Name = "LabelSelectTitle"
        Me.LabelSelectTitle.Size = New System.Drawing.Size(104, 20)
        Me.LabelSelectTitle.TabIndex = 1
        Me.LabelSelectTitle.Text = "Select a Title:"
        '
        'ButtonShowSelection
        '
        Me.ButtonShowSelection.Location = New System.Drawing.Point(59, 391)
        Me.ButtonShowSelection.Name = "ButtonShowSelection"
        Me.ButtonShowSelection.Size = New System.Drawing.Size(672, 30)
        Me.ButtonShowSelection.TabIndex = 2
        Me.ButtonShowSelection.Text = "Show Selection"
        Me.ButtonShowSelection.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonShowSelection)
        Me.Controls.Add(Me.LabelSelectTitle)
        Me.Controls.Add(Me.LstBooks)
        Me.Name = "Form1"
        Me.Text = "BookPicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstBooks As ListBox
    Friend WithEvents LabelSelectTitle As Label
    Friend WithEvents ButtonShowSelection As Button
End Class
