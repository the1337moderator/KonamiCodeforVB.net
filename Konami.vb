Public Class Konami
    ' Here is the pattern to match
    Property KonamiOrder As List(Of Keys) = New List(Of Keys) From {Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A}

    ' Just calling these out ahead of time
    Property sequence As List(Of Boolean)
    Property ix As Integer = 0

    ' Hey new object, better set the important bits
    Public Sub New()
        me.reset()
    End Sub

    ' Reset on pattern failure, or completion
    Public Function reset() As Boolean
        Me.sequence = New List(Of Boolean) From {False, False, False, False, False, False, False, False, False, False}
        ix = 0

    End Function



    ' Here's where all the action happens
    Public Function checkKey(keycode As Keys)
        'Check to see what they pressed
        If sequence(ix) = False And keycode = KonamiOrder(ix) Then
            ' Hurray, they pressed the right key, better keep track of it
            sequence(ix) = True
            ix = ix + 1
        Else
            ' Nope, reset
            Me.reset()
        End If

        'Is the code complete and correct?
        If sequence.Contains(False) Then
            ' Nope, send back failure
            Return False
        Else
            'Yep, reset so it can be used again and send back a success
            Me.reset()
            Return True
        End If
    End Function

End Class
