Public Class StartUpForm

    Private WithEvents timer1 As New Windows.Forms.Timer With {.Interval = 1}
    Private Sub StartUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Start()
    End Sub
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Static y As Integer = -1

        y += 4

        Me.Opacity = y / 100

        If y >= 150 Then
            timer1.Stop()
            InicioSesion.Show()
            Me.Hide()
        End If

    End Sub
End Class