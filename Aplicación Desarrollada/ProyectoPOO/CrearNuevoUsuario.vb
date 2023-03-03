Public Class CrearNuevoUsuario
    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        InicioSesion.Show()

        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtTelefono.Text = ""
        txtRol.Text = ""
        txtContrasena.Text = ""
        txtOtraContra.Text = ""

        Me.Opacity = 0
        Me.Close()
    End Sub

    Private Sub ElButton5_Click(sender As Object, e As EventArgs) Handles ElButton5.Click
        StartUpForm.Close()
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        Dim Campos() = {txtNombre, txtApellidos, txtTelefono, txtRol, txtContrasena, txtOtraContra}

        For iterador As Integer = 0 To 5
            If Campos(iterador).Text = "xd" Then
                MarcarError(Campos(iterador))
            End If
        Next
    End Sub

    Public Sub Arranque()
        PantallaPrincipal.Show()
        InicioSesion.Close()
        Me.Close()
    End Sub

    'Codigo del Incio Difuminado'
    Private y As Integer

    Private Sub CrearNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        y = -1
        ShowForm.Start()
    End Sub

    Private WithEvents ShowForm As New Windows.Forms.Timer With {.Interval = 10}
    Private Sub ShowForm_Tick(sender As Object, e As EventArgs) Handles ShowForm.Tick
        y += 20

        Me.Opacity = y / 100

        If y >= 100 Then
            ShowForm.Stop()
        End If
    End Sub


    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        QuitarError(txtNombre)
    End Sub
End Class