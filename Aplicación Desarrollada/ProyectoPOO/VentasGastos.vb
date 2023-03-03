Public Class VentasGastos
    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        PantallaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub VentasGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosGV' Puede moverla o quitarla según sea necesario.
        Me.RegistrosGVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosGV)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosV' Puede moverla o quitarla según sea necesario.
        Me.RegistrosVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosV)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosG' Puede moverla o quitarla según sea necesario.
        Me.RegistrosGTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosG)
        ShowFormStart(Me)
        LbFecha.Text = getDia()
        Usuario.Text = ModuloExterno.NombreUsuario

        txtMotivo.Text = ""
        txtCantidad.Text = ""
        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False

    End Sub

    Private Sub VentasGastos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Opacity = 0
    End Sub

    Private Sub ElButton4_Click(sender As Object, e As EventArgs) Handles ElButton4.Click
        'Validacion de Si Estan rellenos
        Dim flag As Boolean = False

        If txtMotivo.Text = "" Then
            MarcarError(txtMotivo)
            flag = True
        End If

        If txtCantidad.Text = "" Then
            MarcarError(txtCantidad)
            flag = True
        End If

        If flag Then
            MensajeDeError(ErrorBox, "Rellene todos los campos", 700)
        Else
            SegundaValidacion()
        End If
    End Sub
    Public Sub SegundaValidacion()
        Dim flag As Boolean

        If VerificaInts(txtCantidad.Text) Then
            MensajeDeError(ErrorBox, "Ingrese un valor numérico", 700)
            MarcarError(txtCantidad)
            flag = True

        ElseIf Integer.Parse(txtCantidad.Text) <= 0 Then
            MensajeDeError(ErrorBox, "Ingrese un valor numérico mayor a 0", 730)
            MarcarError(txtCantidad)
            flag = True
        End If

        If (txtMotivo.Text).Length <= 5 Then
            MensajeDeError(ErrorBox, "El Motivo debe de ser mayor a 5 caracteres", 860)
            MarcarError(txtMotivo)
            flag = True
        End If

        If Not flag Then
            Confirmacion()
        End If
    End Sub
    Public Sub Confirmacion()

        lblMotivo.Text = txtMotivo.Text
        lblCantidad.Text = txtCantidad.Text + "$ m.n"
        lblUsuario.Text = Usuario.Text

        If lblTipoRegistro.ForeColor = Color.Black Then
            lblRegistro.Text = "Gasto"
        Else
            lblRegistro.Text = "Venta"
        End If

        PnlConfirmacion.Left = 212
        PnlCajas.Visible = False
        PnlConfirmacion.Visible = True

        ErrorBox.Text = ""
    End Sub

    Private Sub ElButton6_Click(sender As Object, e As EventArgs) Handles ElButton6.Click
        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False
    End Sub

    Private Sub ElButton7_Click(sender As Object, e As EventArgs) Handles ElButton7.Click
        'Balanceo
        Dim tGasto As Integer = Me.RegistrosGVTableAdapter.getGasto(getClaveDia)


        Dim tVenta As Integer = Me.RegistrosGVTableAdapter.getVenta(getClaveDia)
        Dim Balance As Integer = Me.RegistrosGVTableAdapter.getBalance(getClaveDia)

        'Aqui va el codigo de alta en gasto, o venta 

        If lblTipoRegistro.ForeColor = Color.Black Then
            Me.RegistrosGTableAdapter.AltaGasto(getClaveDia, ModuloExterno.NumeroCuenta, txtMotivo.Text, txtCantidad.Text, getHora())
            tGasto += CInt(txtCantidad.Text)
            Balance = Balance - CInt(txtCantidad.Text)
            Me.RegistrosGTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosG)
        Else
            Me.RegistrosVTableAdapter.AltaVenta(getClaveDia, ModuloExterno.NumeroCuenta, txtMotivo.Text, txtCantidad.Text, getHora())
            tVenta += CInt(txtCantidad.Text)
            Balance = Balance + CInt(txtCantidad.Text)
            Me.RegistrosVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosV)
        End If

        Me.RegistrosGVTableAdapter.ActualizarDia(tGasto, tVenta, Balance, getClaveDia)

        'Codigo de Refrescar tablas ambas
        Me.RegistrosGVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosGV)

        txtMotivo.Text = ""
        txtCantidad.Text = ""
        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False

        Desabilita(Label3)
        Habilita(lblTipoRegistro)
    End Sub

    Private Sub QuitarMarcas(sender As Object, e As EventArgs) Handles txtMotivo.TextChanged, txtCantidad.TextChanged
        QuitarError(sender)
    End Sub

    Private Sub lblTipoRegistro_Click(sender As Object, e As EventArgs) Handles lblTipoRegistro.Click
        Desabilita(Label3)
        Habilita(lblTipoRegistro)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Habilita(Label3)
        Desabilita(lblTipoRegistro)
    End Sub

    Private Sub EfectoHover(sender As Object, e As EventArgs) Handles Label3.MouseEnter, lblTipoRegistro.MouseEnter, VentaLblRegistro.MouseEnter, GastoLblRegistro.MouseEnter
        If sender.ForeColor = Color.DarkGray Then
            sender.ForeColor = Color.PowderBlue
        End If
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave, lblTipoRegistro.MouseLeave, VentaLblRegistro.MouseLeave, GastoLblRegistro.MouseLeave
        If sender.ForeColor = Color.PowderBlue Then
            sender.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub VentaLblRegistro_Click(sender As Object, e As EventArgs) Handles VentaLblRegistro.Click
        Habilita(VentaLblRegistro)
        Desabilita(GastoLblRegistro)

        If nRegistrosV = 0 Then
            NoHayRegistros.Visible = True
        Else
            NoHayRegistros.Visible = False
        End If

        TablaVentas.Visible = True
        TablaGastos.Visible = False

        TablaVentas.Left = 45
        TablaVentas.Top = 123

        TablaGastos.Left = 1200
        TablaGastos.Top = 700
    End Sub

    Private Sub GastoLblRegistro_Click(sender As Object, e As EventArgs) Handles GastoLblRegistro.Click
        Habilita(GastoLblRegistro)
        Desabilita(VentaLblRegistro)

        If nRegistrosG = 0 Then
            NoHayRegistros.Visible = True
        Else
            NoHayRegistros.Visible = False
        End If

        TablaGastos.Left = 45
        TablaGastos.Top = 123

        TablaVentas.Left = 1200
        TablaVentas.Top = 700

        TablaVentas.Visible = False
        TablaGastos.Visible = True
    End Sub

    Dim nRegistrosG As Integer = 0
    Dim nRegistrosV As Integer = 0

    Private Sub ElButton5_Click(sender As Object, e As EventArgs) Handles ElButton5.Click
        PnlCajas.Visible = False
        PnlConfirmacion.Visible = False
        PnlRegistros.Visible = True

        PnlRegistros.Left = 67
        PnlRegistros.Top = 95

        GastoLblRegistro_Click(GastoLblRegistro, EventArgs.Empty)
        'Aqui se llenaran ambos dataGrip con los datos del dia de hoy 

        Try
            nRegistrosG = Me.RegistrosGTableAdapter.getRegistrosGastos(getClaveDia())
        Catch ex As Exception
            nRegistrosG = 0
        End Try

        Me.RegistrosGTableAdapter.FillBy(Me.Comedor_PacificoDataSet.RegistrosG, getClaveDia())
        Me.RegistrosVTableAdapter.FillBy(Me.Comedor_PacificoDataSet.RegistrosV, getClaveDia())

        'CreadorDeEspacio 
        Try
            nRegistrosV = Me.RegistrosVTableAdapter.getRegistrosVentas(getClaveDia())
        Catch ex As Exception
            nRegistrosG = 0
        End Try

        TablaGastos.Height = 32 + 30 * nRegistrosG
        TablaVentas.Height = 32 + 30 * nRegistrosV

        If nRegistrosG = 0 Then
            NoHayRegistros.Visible = True
        Else
            NoHayRegistros.Visible = True
        End If

        Dim Balance As Integer = 0
        Try
            Balance = Me.RegistrosGVTableAdapter.getBalance(getClaveDia())
        Catch ex As Exception
            Balance = 0
        End Try

        Label16.Text = "Balance: " + Balance.ToString()

        TablaGastos.Visible = True
    End Sub

    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        TablaGastos.Visible = False
        TablaVentas.Visible = False

        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False
        PnlRegistros.Visible = False

        PnlCajas.Left = 172
        PnlCajas.Top = 149
    End Sub

    Private Sub ElButton3_Click(sender As Object, e As EventArgs) Handles ElButton3.Click
        'Mostrar Selector defecah
        PnlRegistros.Visible = False

        SelectorFecha.Visible = True

        SelectorFecha.Left = 67
        SelectorFecha.Top = 95
    End Sub

    Private Sub ElButton8_Click(sender As Object, e As EventArgs) Handles ElButton8.Click, ElButton9.Click
        '
        GastoLblRegistro_Click(GastoLblRegistro, EventArgs.Empty)
        PnlRegistros.Visible = True

        SelectorFecha.Visible = False

        PnlRegistros.Visible = True

        PnlRegistros.Left = 67
        PnlRegistros.Top = 95

        SelectorFecha.Visible = False

        If sender.text = "Aceptar" Then
            'Poner de titulo el nuevo 

            Dim claveBusqueda As String = SelectorDeFecha.Value
            Label15.Text = "Registros del: " + claveBusqueda.Substring(0, 10)
            claveBusqueda = claveBusqueda.Replace("/", "")

            Dim claveBusquedaA As String = claveBusqueda.Substring(0, 4)
            Dim claveBusquedaB As String = claveBusqueda.Substring(6, 2)

            claveBusqueda = claveBusquedaA + claveBusquedaB
            GastoLblRegistro_Click(GastoLblRegistro, EventArgs.Empty)
            'Aqui se llenaran ambos dataGrip con los datos del dia de hoy 

            Try
                nRegistrosG = Me.RegistrosGTableAdapter.getRegistrosGastos(claveBusqueda)
            Catch ex As Exception
                nRegistrosG = 0
            End Try

            Me.RegistrosGTableAdapter.FillBy(Me.Comedor_PacificoDataSet.RegistrosG, claveBusqueda)
            Me.RegistrosVTableAdapter.FillBy(Me.Comedor_PacificoDataSet.RegistrosV, claveBusqueda)

            'CreadorDeEspacio 
            Try
                nRegistrosV = Me.RegistrosVTableAdapter.getRegistrosVentas(claveBusqueda)
            Catch ex As Exception
                nRegistrosG = 0
            End Try

            TablaGastos.Height = 32 + 30 * nRegistrosG
            TablaVentas.Height = 32 + 30 * nRegistrosV

            If nRegistrosG = 0 Then
                NoHayRegistros.Visible = True
            Else
                NoHayRegistros.Visible = True
            End If

            Dim Balance As Integer = 0
            Try
                Balance = Me.RegistrosGVTableAdapter.getBalance(claveBusqueda)
            Catch ex As Exception
                Balance = 0
            End Try

            Label16.Text = "Balance: " + Balance.ToString()
        End If
    End Sub

End Class