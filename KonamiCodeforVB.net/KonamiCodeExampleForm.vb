' Konami Code <http://en.wikipedia.org/wiki/Konami_Code> for vb .net as 
' implemented by James Pryor <https://github.com/deplicator/KonamiCodeforVB.net>.
' No doubt there are more efficient methods, but this one is mine.

Public Class KonamiCodeExampleForm

    ' The key press order used in the code is stored in this array of objects.
    Dim keyorder() As Object = {System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up, _
                                    System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down, _
                                    System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, _
                                    System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, _
                                    System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A}

    ' Index variable to keep track of key presses.
    Dim index As Integer = 0

    ' This array of booleans will verify the sequence is going well.
    Dim sequence() As Boolean = {False, False, False, False, False, False, False, False, False, False}

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' This allows for key presses to be recognized while the form is in focus.
        Me.KeyPreview = True

    End Sub

    ' This sub handles the key presses.
    Private Sub CalculatorAboutForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        ' The key press loop changes the sequence array elements to true if the key pressed matches the keyorder() array. 
        If index < 9 And sequence(index) = False And e.KeyCode = keyorder(index) Then
            sequence(index) = True
            index += 1

        ElseIf index = 9 And e.KeyCode = keyorder(index) Then
            ' On the last key press unlock a secret.
            AboutRichTextBox.Enabled() = True
            SecretLabel.Text = "Hey you know the Konami Code!"

        Else
            ' If the keys are not pressed in the correct order, reset the sequence.
            index = 0
            For i As Integer = 0 To sequence.Length - 1
                sequence(i) = False

            Next

        End If

    End Sub

End Class
