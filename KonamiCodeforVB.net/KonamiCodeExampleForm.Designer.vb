<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KonamiCodeExampleForm
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
        Me.AboutRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SecretLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AboutRichTextBox
        '
        Me.AboutRichTextBox.Enabled = False
        Me.AboutRichTextBox.Location = New System.Drawing.Point(13, 13)
        Me.AboutRichTextBox.Name = "AboutRichTextBox"
        Me.AboutRichTextBox.Size = New System.Drawing.Size(262, 156)
        Me.AboutRichTextBox.TabIndex = 0
        Me.AboutRichTextBox.Text = "Konami Code for VB .net" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Also known as a way to spice up class projects." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "https:/" & _
    "/github.com/deplicator/KonamiCodeforVB.net"
        '
        'SecretLabel
        '
        Me.SecretLabel.AutoSize = True
        Me.SecretLabel.Location = New System.Drawing.Point(61, 172)
        Me.SecretLabel.Name = "SecretLabel"
        Me.SecretLabel.Size = New System.Drawing.Size(0, 13)
        Me.SecretLabel.TabIndex = 1
        '
        'KonamiCodeExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 200)
        Me.Controls.Add(Me.SecretLabel)
        Me.Controls.Add(Me.AboutRichTextBox)
        Me.Name = "KonamiCodeExampleForm"
        Me.Text = "Konami Code for VB .net Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AboutRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SecretLabel As System.Windows.Forms.Label

End Class
