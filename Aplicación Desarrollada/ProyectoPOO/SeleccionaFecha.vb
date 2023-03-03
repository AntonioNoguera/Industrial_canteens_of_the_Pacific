Public Class SeleccionaFecha
    Private Sub UI_Calendar1_Click(sender As Object, e As EventArgs) Handles UI_Calendar1.Click
        MsgBox("sss")
    End Sub

    Private Sub UI_Calendar1_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles UI_Calendar1.ChangeUICues

    End Sub

    Private Sub UI_Calendar1_TextChanged(sender As Object, e As EventArgs) Handles UI_Calendar1.TextChanged
        MsgBox("cambieeee")
    End Sub
End Class