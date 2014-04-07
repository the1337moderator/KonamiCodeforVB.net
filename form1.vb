' This is just a sample form's code behind on the usage of the konami class.

Public Class Form1
    Private oKonami As New Konami


    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        ' Send the Key press on its way, and get some logic going
        If oKonami.checkKey(e.KeyCode) Then
            ' Congrats, pattern match
            MsgBox("Konami Code Entered")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' This will intercept the key events on this form
        Me.KeyPreview = True
    End Sub
End Class
