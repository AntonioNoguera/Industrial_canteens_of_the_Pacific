Public Class InicioSesion
    Private Sub ElButton5_Click(sender As Object, e As EventArgs) Handles ElButton5.Click
        StartUpForm.Close()
    End Sub
    Private Sub ElButton3_MouseDown(sender As Object, e As MouseEventArgs) Handles ElButton3.MouseDown
        txtContrasena.UseSystemPasswordChar = False
    End Sub
    Private Sub ElButton3_MouseUp(sender As Object, e As MouseEventArgs) Handles ElButton3.MouseUp
        txtContrasena.UseSystemPasswordChar = True
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        CrearNuevoUsuario.Show()

        txtContrasena.Text = ""
        txtUsuario.Text = ""

        Me.Opacity = 0
        Me.Close()
    End Sub
    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        If txtUsuario.Text = "" Then
            AlertaTexto.Left = 95
            AlertaTexto.Text = "     INGRESE UN USUARIO"
            MarcarError(txtUsuario)
        Else
            QuitarError(txtUsuario)
        End If

        If txtContrasena.Text = "" Then
            AlertaTexto.Left = 69
            AlertaTexto.Text = "     INGRESE UNA CONTRASEÑA"
            MarcarError(txtContrasena)
        Else
            QuitarError(txtContrasena)
        End If

        If txtUsuario.Text = "" And txtContrasena.Text = "" Then
            AlertaTexto.Left = 100
            AlertaTexto.Text = "RELLENA TODOS LOS DATOS"
        ElseIf txtUsuario.Text <> "" And txtContrasena.Text <> "" Then
            VerificarUsuario()
        End If


    End Sub

    Public Sub VerificarUsuario()
        Dim Usuario As String = "NOHAY"

        Try
            Usuario = Me.UsuariosComedorTableAdapter.BuscarUsuario(txtUsuario.Text)
        Catch ex As Exception
            Usuario = "NOHAY"
        End Try


        If Usuario = "NOHAY" Then
            AlertaTexto.Text = "        USUARIO INEXISTENTE"
            MarcarError(txtUsuario)
        Else
            ModuloExterno.NumeroCuenta = CInt(Usuario)
            QuitarError(txtUsuario)
            VerificarContra()
        End If
    End Sub

    Public Sub VerificarContra()
        If Me.UsuariosComedorTableAdapter.BuscarContrasena(txtUsuario.Text) <> txtContrasena.Text Then
            AlertaTexto.Text = "CONTRASEÑA INCORRECTA"
            MarcarError(txtContrasena)
        Else
            QuitarError(txtContrasena)
            Arranque()
        End If
    End Sub

    Public Sub Arranque()
        ModuloExterno.NombreUsuario = txtUsuario.Text.ToUpper()
        PantallaPrincipal.Show()
        CrearNuevoUsuario.Close()
        Me.Close()
    End Sub

    'Codigo del Incio Difuminado
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.UsuariosComedor' Puede moverla o quitarla según sea necesario.
        Me.UsuariosComedorTableAdapter.Fill(Me.Comedor_PacificoDataSet.UsuariosComedor)
        ShowFormStart(Me)
    End Sub
    'Fin del Codigo de Difuminado

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        QuitarError(txtUsuario)
    End Sub
    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        QuitarError(txtContrasena)
    End Sub
End Class