Public Class Registros
    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        PantallaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosTotales' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTotalesTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosTotales)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegCenas' Puede moverla o quitarla según sea necesario.
        Me.RegCenasTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegCenas)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegComidas' Puede moverla o quitarla según sea necesario.
        Me.RegComidasTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegComidas)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegDesayunos' Puede moverla o quitarla según sea necesario.
        Me.RegDesayunosTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegDesayunos)
        ShowFormStart(Me)
        LbFecha.Text = getDia()
        Usuario.Text = ModuloExterno.NombreUsuario
        VerificarRegistros()
    End Sub

    Private Sub Registros_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Opacity = 0
    End Sub

    'Habilitar Y Desabilitar Opciones
    Private Sub LblDesayunos_Click(sender As Object, e As EventArgs) Handles LblDesayunos.Click
        Desaparece(0)
    End Sub
    Private Sub LblComidas_Click(sender As Object, e As EventArgs) Handles LblComidas.Click
        Desaparece(1)
    End Sub
    Private Sub LblCenas_Click(sender As Object, e As EventArgs) Handles LblCenas.Click
        Desaparece(2)
    End Sub

    'Flag = 0→Desayuno, 1→Comida, 2→Cena
    Public FlagGlobal As Integer = 0

    Public Sub Desaparece(ByVal Elemento As Integer)
        Dim Opciones() = {LblDesayunos, LblComidas, LblCenas}

        For iterador As Integer = 0 To 2
            If iterador = Elemento Then
                FlagGlobal = Elemento
                Habilita(Opciones(iterador))
            Else
                Desabilita(Opciones(iterador))
            End If
        Next

    End Sub

    Private Sub ElButton3_Click(sender As Object, e As EventArgs) Handles ElButton3.Click
        Dim Campos() = {txtLaptop, txtCredencial, txtEco, txtProducto}

        Dim flag As Boolean = False

        For iterador As Integer = 0 To 3
            If Campos(iterador).Text = "" Then
                MarcarError(Campos(iterador))
                flag = True
            End If
        Next

        If flag Then
            MensajeDeError(ErrorBox, "Rellena todos los campos", 500)
        Else
            If LblDesayunos.Visible = False And LblComidas.Visible = False And LblCenas.Visible = False Then
                MensajeDeError(ErrorBox, "Ya se han dado de alta todos los registros", 670)
            Else
                SegundaValidacion()
            End If
        End If

    End Sub

    Private Sub SegundaValidacion()
        Dim Campos() = {txtLaptop, txtCredencial, txtEco, txtProducto}
        Dim Labels() = {LblLaptop, LblCredencial, LblECO, LblProducto}

        Dim flag As Boolean = False

        For iterador As Integer = 0 To 3
            If VerificaInts(Campos(iterador).Text) Then
                MarcarError(Campos(iterador))
                flag = True
            ElseIf Integer.Parse(Campos(iterador).Text) <= 0 Then
                MarcarError(Campos(iterador))
                flag = True
            End If
        Next

        If flag Then
            MensajeDeError(ErrorBox, "Todos los valores deberán ser numéricos y mayores de 0", 850)
        Else
            ErrorBox.Text = ""
            PnlCajas.Visible = False
            PnlConfirmacion.Visible = True
            PnlConfirmacion.Left = 95

            For iterador As Integer = 0 To 3
                Labels(iterador).Text = Campos(iterador).Text
            Next

            Dim Opciones() = {LblDesayunos, LblComidas, LblCenas}

            For iterador As Integer = 0 To 2
                If Opciones(iterador).ForeColor = Color.Black Then
                    lblRegistro.Text = Opciones(iterador).Text
                End If
            Next

        End If
    End Sub

    'Codigo TextChange
    Private Sub txtLaptop_TextChanged(sender As Object, e As EventArgs) Handles txtLaptop.TextChanged
        QuitarError(txtLaptop)
    End Sub
    Private Sub txtCredencial_TextChanged(sender As Object, e As EventArgs) Handles txtCredencial.TextChanged
        QuitarError(txtCredencial)
    End Sub
    Private Sub txtEco_TextChanged(sender As Object, e As EventArgs) Handles txtEco.TextChanged
        QuitarError(txtEco)
    End Sub
    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        QuitarError(txtProducto)
    End Sub
    Private Sub ElButton4_Click(sender As Object, e As EventArgs) Handles ElButton4.Click
        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False
    End Sub

    Private Sub ElButton5_Click(sender As Object, e As EventArgs) Handles ElButton5.Click

        Dim TotalTurno As Integer = 0
        TotalTurno = CInt(txtLaptop.Text) + CInt(txtCredencial.Text) + CInt(txtEco.Text) + CInt(txtProducto.Text)

        Dim Flag As Integer = -1

        If LblDesayunos.ForeColor = Color.Black And LblDesayunos.ForeColor <> Color.Yellow Then

            Try
                Flag = Me.TableAdapterManager.RegDesayunosTableAdapter.ExisteDesayuno(ModuloExterno.getClaveDia)
            Catch ex As Exception
                Flag = -1
            End Try

            If Flag = -1 Then
                Me.TableAdapterManager.RegDesayunosTableAdapter.AltaDesayuno(ModuloExterno.getClaveDia, ModuloExterno.NumeroCuenta, txtEco.Text, txtLaptop.Text, txtCredencial.Text, txtProducto.Text, TotalTurno, getHora)
                Me.RegDesayunosTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegDesayunos)
            Else
                MensajeDeError(ErrorBox, "Ya se ha dado de alta el registro", 850)
            End If


        ElseIf LblComidas.ForeColor = Color.Black And LblComidas.ForeColor <> Color.Yellow Then

            Try
                Flag = Me.TableAdapterManager.RegComidasTableAdapter.ExisteComida(ModuloExterno.getClaveDia)
            Catch ex As Exception
                Flag = -1
            End Try

            If Flag = -1 Then
                Me.TableAdapterManager.RegComidasTableAdapter.AltaComida(ModuloExterno.getClaveDia, ModuloExterno.NumeroCuenta, txtEco.Text, txtLaptop.Text, txtCredencial.Text, txtProducto.Text, TotalTurno, getHora)
                Me.RegComidasTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegComidas)
            Else
                MensajeDeError(ErrorBox, "Ya se ha dado de alta el registro", 850)
            End If

        ElseIf LblCenas.ForeColor = Color.Black And LblCenas.ForeColor <> Color.Yellow Then

            Try
                Flag = Me.TableAdapterManager.RegCenasTableAdapter.ExisteCena(ModuloExterno.getClaveDia)
            Catch ex As Exception
                Flag = -1
            End Try

            If Flag = -1 Then
                Me.TableAdapterManager.RegCenasTableAdapter.AltaCena(ModuloExterno.getClaveDia, ModuloExterno.NumeroCuenta, txtEco.Text, txtLaptop.Text, txtCredencial.Text, txtProducto.Text, TotalTurno, getHora)
                Me.RegCenasTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegCenas)
            Else
                MensajeDeError(ErrorBox, "Ya se ha dado de alta el registro", 850)
            End If
        Else
            MensajeDeError(ErrorBox, "Ya se ha dado de alta el registro", 850)
        End If

        'Actualizar El Registro Diario
        If Flag = -1 Then

            Dim Eco As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.getEco(ModuloExterno.getClaveDia)
            Dim Laptop As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.getLaptop(ModuloExterno.getClaveDia)
            Dim Credencial As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.getSinCredencial(ModuloExterno.getClaveDia)
            Dim Producto As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.getProducto(ModuloExterno.getClaveDia)
            Dim TotalDia As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.getTotal(ModuloExterno.getClaveDia)

            Me.RegistrosTotalesTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosTotales)

            Eco += CInt(txtEco.Text)
            Laptop += CInt(txtLaptop.Text)
            Credencial += CInt(txtCredencial.Text)
            Producto += CInt(txtProducto.Text)
            TotalDia += TotalTurno

            Dim Total As Integer = Me.TableAdapterManager.RegistrosTotalesTableAdapter.ActualizarDia(Eco, Laptop, Credencial, Producto, TotalDia, ModuloExterno.getClaveDia)
        End If

        'Si todo sale bien
        Dim Campos() = {txtLaptop, txtCredencial, txtEco, txtProducto}

        For iterador As Integer = 0 To 3
            Campos(iterador).Text = ""
        Next

        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False

        Desaparece(0)
        VerificarRegistros()
        'Aqui va el codigo de alta
    End Sub

    'Codigo Hover
    Private Sub LblDesayunos_MouseEnter(sender As Object, e As EventArgs) Handles LblDesayunos.MouseEnter
        If Not FlagGlobal = 0 Then
            LblDesayunos.ForeColor = Color.PowderBlue
        End If
    End Sub
    Private Sub LblDesayunos_MouseLeave(sender As Object, e As EventArgs) Handles LblDesayunos.MouseLeave
        If Not FlagGlobal = 0 Then
            LblDesayunos.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub LblComidas_MouseEnter(sender As Object, e As EventArgs) Handles LblComidas.MouseEnter
        If Not FlagGlobal = 1 Then
            LblComidas.ForeColor = Color.PowderBlue
        End If
    End Sub
    Private Sub LblComidas_MouseLeave(sender As Object, e As EventArgs) Handles LblComidas.MouseLeave
        If Not FlagGlobal = 1 Then
            LblComidas.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub LblCenas_MouseEnter(sender As Object, e As EventArgs) Handles LblCenas.MouseEnter
        If Not FlagGlobal = 2 Then
            LblCenas.ForeColor = Color.PowderBlue
        End If
    End Sub
    Private Sub LblCenas_MouseLeave(sender As Object, e As EventArgs) Handles LblCenas.MouseLeave
        If Not FlagGlobal = 2 Then
            LblCenas.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        'MuestraLosRegistros
        MostrarDatos(getClaveDia())
    End Sub

    Private Sub ElButton6_Click(sender As Object, e As EventArgs) Handles ElButton6.Click
        PnlCajas.Visible = True
        PnlConfirmacion.Visible = False
        PnlRegistros.Visible = False
    End Sub

    Private Sub ElButton7_Click(sender As Object, e As EventArgs) Handles ElButton7.Click
        'Desplegar Fecha
        PnlRegistros.Visible = False

        SelectorFecha.Visible = True

        SelectorFecha.Left = 67
        SelectorFecha.Top = 95
    End Sub

    Private Sub ElButton8_Click(sender As Object, e As EventArgs) Handles ElButton8.Click
        'Mostrar Selector defecah
        PnlRegistros.Visible = True

        SelectorFecha.Visible = False

        SelectorFecha.Left = 67
        SelectorFecha.Top = 95
    End Sub

    Private Sub ElButton9_Click(sender As Object, e As EventArgs) Handles ElButton9.Click
        'Desplegar de la nueva fecha
        Dim claveBusqueda As String = SelectorDeFecha.Value

        Dim NeoClaveBusqueda As String = claveBusqueda.Replace("/", "")

        Dim claveBusquedaA As String = NeoClaveBusqueda.Substring(0, 4)
        Dim claveBusquedaB As String = NeoClaveBusqueda.Substring(6, 2)

        Dim FinalclaveBusqueda As String = claveBusquedaA + claveBusquedaB

        If FinalclaveBusqueda = getClaveDia() Then
            Label15.Text = "Registros del día de Hoy"
        Else
            Label15.Text = "Registros del: " + claveBusqueda.Substring(0, 10)
        End If

        MostrarDatos(FinalclaveBusqueda)

        SelectorFecha.Visible = False
    End Sub

    Public Sub MostrarDatos(ByVal CadenaEnviada)
        TablaRegistros.Height = 32 + 30 * 5

        Me.RegDesayunosTableAdapter.RellenaDesayuno(Me.Comedor_PacificoDataSet.RegDesayunos, CadenaEnviada)
        Me.RegComidasTableAdapter.RellenaComidas(Me.Comedor_PacificoDataSet.RegComidas, CadenaEnviada)
        Me.RegCenasTableAdapter.RellenaCenas(Me.Comedor_PacificoDataSet.RegCenas, CadenaEnviada)

        Me.RegistrosTotalesTableAdapter.RellenaTotales(Me.Comedor_PacificoDataSet.RegistrosTotales, CadenaEnviada)

        PnlCajas.Visible = False
        PnlConfirmacion.Visible = False
        PnlRegistros.Visible = True

        PnlRegistros.Left = 24
        PnlRegistros.Top = 98

        TablaRegistros.Rows.Clear()

        Dim Textos() As String = {"ECO", "Laptop", "Sin Credencial", "Por Producto", "Total"}
        For iterador As Integer = 0 To 4
            TablaRegistros.Rows.Add()
            TablaRegistros.Item(0, iterador).Value = Textos(iterador)

            TablaRegistros.Item(1, iterador).Value = DataGridView1.Item(iterador, 0).Value
            TablaRegistros.Columns(iterador).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            TablaRegistros.Item(2, iterador).Value = DataGridView2.Item(iterador, 0).Value
            TablaRegistros.Item(3, iterador).Value = DataGridView3.Item(iterador, 0).Value
            TablaRegistros.Item(4, iterador).Value = DataGridView4.Item(iterador, 0).Value
        Next

        TablaRegistros.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

        For iterador As Integer = 0 To 4
            TablaRegistros.Rows.Add()
            TablaRegistros.Item(0, iterador).Value = Textos(iterador)

            TablaRegistros.Rows(4).DefaultCellStyle.BackColor = Color.LightSteelBlue
            TablaRegistros.Rows(4).DefaultCellStyle.Font = New Drawing.Font("Century Gothic", 17, FontStyle.Regular, GraphicsUnit.Point)
            TablaRegistros.Rows(4).DefaultCellStyle.ForeColor = Color.DarkSlateBlue
        Next
    End Sub

    Public Sub VerificarRegistros()
        Dim Desayunos As Integer = -1
        Try
            Desayunos = Me.RegDesayunosTableAdapter.ExisteDesayuno(getClaveDia)
        Catch ex As Exception
            Desayunos = -1
        End Try

        If Desayunos <> -1 Then
            LblDesayunos.Visible = False
            LblDesayunos.ForeColor = Color.Yellow
            LblNoDesayuno.Visible = True
        End If


        Dim Comidas As Integer = -1
        Try
            Comidas = Me.RegComidasTableAdapter.ExisteComida(getClaveDia)
        Catch ex As Exception
            Comidas = -1
        End Try

        If Comidas <> -1 Then
            LblComidas.Visible = False
            LblComidas.ForeColor = Color.Yellow
            LblNoComida.Visible = True
        End If

        Dim Cenas As Integer = -1
        Try
            Cenas = Me.RegCenasTableAdapter.ExisteCena(getClaveDia)
        Catch ex As Exception
            Cenas = -1
        End Try

        If Cenas <> -1 Then
            LblCenas.Visible = False
            LblCenas.ForeColor = Color.Yellow
            LblNoCena.Visible = True
        End If
    End Sub
End Class