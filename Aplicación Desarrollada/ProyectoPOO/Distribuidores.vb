Public Class Distribuidores

    Public Hojas As Integer = 0
    Public HojaActual As Integer = 1
    Public PseudoHoja As Integer = 0

    Public DistribuidorSeleccionado As Integer = 0

    Private Sub Distribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.Distribuidores' Puede moverla o quitarla según sea necesario.
        Me.DistribuidoresTableAdapter.Fill(Me.Comedor_PacificoDataSet.Distribuidores)
        ShowFormStart(Me)
        LbFecha.Text = getDia()

        Usuario.Text = ModuloExterno.NombreUsuario


        Despliegue()
    End Sub

    Private Sub Distribuidores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Opacity = 0
    End Sub

    Private Sub ElButton23_Click(sender As Object, e As EventArgs)
        PnlLista.Visible = False
        PnlNuevo.Visible = True

        PnlLista.Left = 44
        PnlLista.Top = 110

    End Sub

    Private Sub ElButton4_Click(sender As Object, e As EventArgs) Handles ElButton4.Click
        'Me.Opacity = 0
        Label20.Text = "Nuevo Distribuidor"

        txtNombreDistr.Text = ""
        txtNombreDistr.BackgroundColour = Color.White
        txtNombreDistr.TextColour = Color.Black

        txtNombreDistr.Enabled = True

        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False

        PnlLista.Visible = False
        PnlNuevo.Visible = True

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
        ' ModuloExterno.ShowFormStart(Me)
    End Sub

    Private Sub ElButton24_Click(sender As Object, e As EventArgs) Handles ElButton24.Click
        LimpiarInputs()

        PnlNuevo.Visible = False
        PnlLista.Visible = True

        BtnEliminar.Enabled = False
        BtnEliminar.Visible = False

        PnlLista.Left = 44
        PnlLista.Top = 110
    End Sub

    Private Sub ElButton3_Click(sender As Object, e As EventArgs)
        Label20.Text = "Editar Distribuidor"

        txtNombreDistr.Text = "NombreDistribuidor"
        txtNombreDistr.BackgroundColour = Color.Gainsboro
        txtNombreDistr.TextColour = Color.White

        txtNombreDistr.Enabled = False


        PnlNuevo.Visible = True
        PnlLista.Visible = False

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    'Btn del Dia
    Private Sub ActivarBoton(obj As Object, e As EventArgs) Handles BtnLunes.Click, BtnMartes.Click, BtnMiercoles.Click, BtnMiercoles.Click, BtnJueves.Click, BtnViernes.Click, BtnSabado.Click
        PermaActiva(obj)
    End Sub

    Private Sub ElButton14_Click(sender As Object, e As EventArgs) Handles ElButton14.Click
        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}
        For iterador As Integer = 0 To 5
            Reinicia(Botones(iterador))
        Next
    End Sub

    Private Sub ElButton7_Click(sender As Object, e As EventArgs) Handles ElButton7.Click
        Dim flag As Integer = 0
        Dim Campos() = {txtNombreDistr, txtHora, txtMin, txtMeridiano, txtNombreEmpleado, txtTelefono, txtMonto}

        For iterador As Integer = 0 To 6
            If (Campos(iterador).Text = "") Then
                MarcarError(Campos(iterador))
                flag = 1
            End If
        Next

        If flag Then
            MensajeDeError(ErrorBox, "Rellena todos los campos", 380)
        Else
            SegundaVerificacion()
        End If
    End Sub

    Public Sub SegundaVerificacion()
        Dim Flag As Boolean = False

        If VerificaInts(txtMonto.Text) Then
            MarcarError(txtMonto)
            MensajeDeError(ErrorBox, "Los Valores deben de ser numéricos", 460)
            Flag = True
        ElseIf Integer.Parse(txtMonto.Text) <= 0 Then
            MarcarError(txtMonto)
            MensajeDeError(ErrorBox, "Monto debe de ser mayor a 0", 400)
            Flag = True
        End If

        If VerificaInts(txtTelefono.Text) Then
            MarcarError(txtTelefono)
            MensajeDeError(ErrorBox, "Los Valores deben de ser numéricos", 460)
            Flag = True
        ElseIf (txtTelefono.Text).Length = 9 Then
            MarcarError(txtTelefono)
            MensajeDeError(ErrorBox, "El teléfono debe de ser de 10 dígitos", 490)
            Flag = True
        End If

        If (txtNombreEmpleado.Text).Length <= 10 Then
            MarcarError(txtNombreEmpleado)
            MensajeDeError(ErrorBox, "El Nombre del Empleado debe de ser mayor a 10 caracteres", 760)
            Flag = True
        End If

        If Not (((txtMeridiano.Text).ToUpper() = "AM") Or ((txtMeridiano.Text).ToUpper() = "PM")) Then
            MarcarError(txtMeridiano)
            MensajeDeError(ErrorBox, "El formato del meridiano debe de ser AM o PM", 600)
            Flag = True
        End If

        If VerificaInts(txtMin.Text) Then
            MarcarError(txtMin)
            MensajeDeError(ErrorBox, "Los Valores deben de ser numéricos", 460)
            Flag = True
        ElseIf Integer.Parse(txtMin.Text) <= 0 Or Integer.Parse(txtMin.Text) >= 60 Then
            MarcarError(txtMin)
            MensajeDeError(ErrorBox, "Los minutos deben de ser mayor a 0 y menor a 60", 610)
            Flag = True
        End If

        If VerificaInts(txtHora.Text) Then
            MarcarError(txtHora)
            MensajeDeError(ErrorBox, "Los Valores deben de ser numéricos", 460)
            Flag = True
        ElseIf Integer.Parse(txtHora.Text) <= 0 Or Integer.Parse(txtHora.Text) >= 13 Then
            MarcarError(txtHora)
            MensajeDeError(ErrorBox, "La hora debe ser mayor que 0 y menor que 12", 540)
            Flag = True
        End If

        If (txtNombreDistr.Text).Length <= 7 Then
            MensajeDeError(ErrorBox, "El Nombre del distribuidor debe de ser mayor a 7 caracteres", 800)
            MarcarError(txtNombreDistr)
            Flag = True
        End If

        If Not Flag Then

            If VerificarDiasSemana() Then
                'Proceso de Confirmación
                CreadorDeStringSemanal()
                ErrorBox.Text = ""
                ErrorBoxDias.Text = ""
                Confirmacion()
            Else
                ErrorBoxDias.Text = "ERROR"
                MensajeDeError(ErrorBox, "Seleccione por lo menos un día", 460)
            End If

        End If
    End Sub

    Public Sub Confirmacion()
        Dim Campos() = {txtNombreDistr, txtNombreEmpleado, txtTelefono, txtMonto}
        Dim Labels() = {LblNombreDist, LblNombreEmpl, LblTelefono, LblMonto}

        For iterador As Integer = 0 To 3
            Labels(iterador).Text = Campos(iterador).Text
        Next

        txtHora.Text = VerificaCeros(txtHora.Text)
        txtMin.Text = VerificaCeros(txtMin.Text)

        LblHoraFinal.Text = txtHora.Text + ":" + txtMin.Text + " " + (txtMeridiano.Text).ToUpper()

        If Label20.Text = "Nuevo Distribuidor" Then
            LblTipoRegistro.Text = "Nuevo Distribuidor"
        Else
            LblTipoRegistro.Text = "Edición Distribuidor"
        End If

        'Convierte de array a texto
        LblDiasSemana.Text = CreadorDeStringSemanalTextual()

        PnlConfirmacion.Visible = True
        PnlNuevo.Visible = False

        PnlConfirmacion.Left = 44
        PnlConfirmacion.Top = 110

    End Sub
    Public Function VerificaCeros(Verificar As String)
        Dim NumeroCreado As Integer = Integer.Parse(Verificar)
        If (NumeroCreado <= 9) Then
            Return "0" + NumeroCreado.ToString()
        End If

        Return Verificar
    End Function

    Public Function CreadorDeStringSemanalTextual()
        Dim DiasSemanales As String = ""

        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}
        Dim Dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado"}

        Dim PuntoFinal As Integer = -1

        For iterador As Integer = 0 To 5
            If Botones(iterador).Enabled = False Then
                PuntoFinal = PuntoFinal + 1
            End If
        Next

        Dim ContadorPalPunto = 0

        For iterador As Integer = 0 To 5
            If Botones(iterador).Enabled = False Then
                If ContadorPalPunto <> PuntoFinal Then
                    DiasSemanales += Dias(iterador) + ", "
                Else
                    DiasSemanales += Dias(iterador) + "."
                End If

                ContadorPalPunto += 1

            End If
        Next

        Return DiasSemanales
    End Function

    Public Function VerificarDiasSemana()
        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}
        Dim Flag As Integer = 0

        For iterador As Integer = 0 To 5
            If Botones(iterador).Enabled = False Then
                Flag = 1
            End If
        Next

        Return Flag
    End Function

    Public Function CreadorDeStringSemanal()
        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}
        Dim Cadena As String = ""
        For iterador As Integer = 0 To 5
            If Botones(iterador).Enabled = False Then
                Cadena += "1-"
            Else
                Cadena += "0-"
            End If
        Next

        Return Cadena
    End Function

    'Btn Cambio Texto 
    Private Sub txtNombreDistr_TextChanged(obj As Object, e As EventArgs) Handles txtNombreDistr.TextChanged, txtHora.TextChanged, txtMin.TextChanged, txtMeridiano.TextChanged, txtNombreEmpleado.TextChanged, txtTelefono.TextChanged, txtMonto.TextChanged
        QuitarError(obj)
    End Sub

    Private Sub ElButton8_Click(sender As Object, e As EventArgs) Handles ElButton8.Click
        PnlConfirmacion.Visible = False
        PnlNuevo.Visible = True
    End Sub

    Private Sub ElButton16_Click(sender As Object, e As EventArgs) Handles ElButton16.Click
        PnlConfirmacion.Visible = False
        PnlNuevo.Visible = True
        'Aqui se dade alta el distribudor
        Dim NumeroDistribuidor As Integer = -1
        If Label20.Text = "Ver / Eliminar / Editar Distribuidor" Then
            'Actualizacion

            Me.TableAdapterManager.DistribuidoresTableAdapter.ActualizarDistribuidor(txtNombreDistr.Text, CreadorDeStringSemanal(), LblHoraFinal.Text, LblNombreEmpl.Text, LblTelefono.Text, LblMonto.Text, ModuloExterno.NumeroCuenta, DistribuidorSeleccionado)

        Else
            'Nuevo
            Try
                NumeroDistribuidor = Me.TableAdapterManager.DistribuidoresTableAdapter.ExisteDistribudor(txtNombreDistr.Text)
            Catch ex As Exception
                NumeroDistribuidor = -1
            End Try

            If NumeroDistribuidor = -1 Then
                Me.TableAdapterManager.DistribuidoresTableAdapter.AltaDistribuidor(txtNombreDistr.Text, CreadorDeStringSemanal(), LblHoraFinal.Text, LblNombreEmpl.Text, LblTelefono.Text, LblMonto.Text, ModuloExterno.NumeroCuenta)
                LimpiarInputs()
                CrearPseudoArreglo()
                Despliegue()
            Else
                MensajeDeError(ErrorBox, "El Nombre del distribuidor ya se encuentra ocupado", 780)
            End If
        End If

    End Sub

    Public Sub LimpiarInputs()
        Dim Campos() = {txtNombreDistr, txtHora, txtMin, txtMeridiano, txtNombreEmpleado, txtTelefono, txtMonto}

        For iterador As Integer = 0 To 6
            Campos(iterador).Text = ""
        Next

        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}
        For iterador As Integer = 0 To 5
            Reinicia(Botones(iterador))
        Next
    End Sub

    Private Sub ElButton9_Click(sender As Object, e As EventArgs) Handles ElButton9.Click
        PantallaPrincipal.Show()
        Me.Close()
    End Sub


    Private Sub panelHojas_TextChanged(sender As Object, e As EventArgs) Handles panelHojas.TextChanged
        If HojaActual = Hojas Then
            nextHoja.Enabled = False
        Else
            nextHoja.Enabled = True
        End If

        If HojaActual = 1 Then
            backHoja.Enabled = False
        Else
            backHoja.Enabled = True
        End If
    End Sub

    Dim tDistribuidores As Double = 0
    Public Sub Despliegue()
        HojaActual = 1

        tDistribuidores = Me.TableAdapterManager.DistribuidoresTableAdapter.nDistribuidores()

        If tDistribuidores = 0 Then
            Dim Casillas = {psObjeto1, psObjeto2, psObjeto3, psObjeto4, psObjeto5, psObjeto6}

            For iteradorReal As Integer = 0 To 5

                Casillas(iteradorReal).Visible = False
                Casillas(iteradorReal).Enabled = False

            Next
            psObjeto33.Visible = True
        Else
            psObjeto33.Visible = False
        End If

        nDistribuidores.Text = "# Distribudores: " + tDistribuidores.ToString()

        Hojas = Math.Ceiling(tDistribuidores / 6)
        PseudoHoja = Hojas

        panelHojas.Text = "1/" + Hojas.ToString()

        If HojaActual = Hojas Then
            nextHoja.Enabled = False
        Else
            nextHoja.Enabled = True
        End If

        CrearPseudoArreglo()
        MostrarElementos()
    End Sub

    Private Sub nextHoja_Click(sender As Object, e As EventArgs) Handles nextHoja.Click
        HojaActual = HojaActual + 1
        panelHojas.Text = HojaActual.ToString() + "/" + Hojas.ToString()
        PseudoHoja = PseudoHoja - 1
        MostrarElementos()
    End Sub

    Private Sub backHoja_Click(sender As Object, e As EventArgs) Handles backHoja.Click
        HojaActual = HojaActual - 1
        panelHojas.Text = HojaActual.ToString() + "/" + Hojas.ToString()
        PseudoHoja = PseudoHoja + 1
        MostrarElementos()
    End Sub

    Dim PaquetesPerdidos As Integer = 0

    Dim arregloSinPerdidas As New ArrayList

    Public Sub CrearPseudoArreglo()
        ObtenerPerdidaDePaquetes()

        arregloSinPerdidas.Clear()

        Dim pseudoIterador = 0
        Dim ContadorCasilla = 0


        If tDistribuidores <> 0 Then
            For iteradorReal As Integer = 1 To PaquetesPerdidos + tDistribuidores

                Dim na As String = Me.TableAdapterManager.DistribuidoresTableAdapter.getNombreDistribuidor(iteradorReal)

                If na <> "" Then

                    arregloSinPerdidas.Add(iteradorReal)

                End If
            Next
        End If

    End Sub

    Public Sub MostrarElementos()

        Dim iteradorBase As Integer = (6 * (PseudoHoja - 1)) + 1
        'Fin  
        Dim Casillas = {psObjeto1, psObjeto2, psObjeto3, psObjeto4, psObjeto5, psObjeto6}

        If tDistribuidores <> 0 Then
            For iteradorReal As Integer = 0 To 5

                'Se acabo el ultimo registro
                If (iteradorBase + iteradorReal - 1) >= arregloSinPerdidas.Count Then
                    For neoIterador = iteradorReal To 5
                        Casillas(neoIterador).Visible = False
                        Casillas(neoIterador).Enabled = False
                    Next
                    iteradorReal = 5
                Else
                    Dim nombre As String = Me.TableAdapterManager.DistribuidoresTableAdapter.getNombreDistribuidor(arregloSinPerdidas.Item(iteradorBase + iteradorReal - 1))

                    Casillas(iteradorReal).Visible = True
                    Casillas(iteradorReal).Enabled = True
                    Casillas(iteradorReal).AccessibleName = arregloSinPerdidas.Item(iteradorBase + iteradorReal - 1)
                    Casillas(iteradorReal).Text = (iteradorBase + iteradorReal).ToString() + ".- " + nombre
                End If
            Next
        End If
    End Sub

    Public Sub ObtenerPerdidaDePaquetes()
        Dim LimitePaquete As Integer = 0

        Try
            LimitePaquete = Me.TableAdapterManager.DistribuidoresTableAdapter.PerdidaPaquete()

        Catch ex As Exception
            LimitePaquete = 0
        End Try

        If LimitePaquete <> 0 Then

            For BuscadorPerdidos As Integer = 1 To LimitePaquete
                Dim Hueco As String = Me.TableAdapterManager.DistribuidoresTableAdapter.getNombreDistribuidor(BuscadorPerdidos)
                If Hueco = "" Then
                    PaquetesPerdidos += 1
                End If
            Next
        End If


    End Sub

    Private Sub LanzaVerEditar(sen As Object, e As EventArgs) Handles psObjeto1.Click, psObjeto2.Click, psObjeto6.Click, psObjeto5.Click, psObjeto4.Click, psObjeto3.Click
        DistribuidorSeleccionado = Integer.Parse(sen.AccessibleName)

        Label20.Text = "Ver / Eliminar / Editar Distribuidor"

        BtnEliminar.Enabled = True
        BtnEliminar.Visible = True

        txtNombreDistr.Text = Me.TableAdapterManager.DistribuidoresTableAdapter.getNombreDistribuidor(DistribuidorSeleccionado)
        txtNombreDistr.BackgroundColour = Color.Gainsboro
        txtNombreDistr.TextColour = Color.White

        procesadorDePseudoCadena(Me.TableAdapterManager.DistribuidoresTableAdapter.getAsistencia(DistribuidorSeleccionado))

        Dim NeoCadena As String = Me.TableAdapterManager.DistribuidoresTableAdapter.getHoraAsistencia(DistribuidorSeleccionado)

        txtHora.Text = NeoCadena.Substring(0, 2)
        txtMin.Text = NeoCadena.Substring(3, 2)
        txtMeridiano.Text = NeoCadena.Substring(6, 2)
        txtNombreEmpleado.Text = Me.TableAdapterManager.DistribuidoresTableAdapter.getNombreEmpleado(DistribuidorSeleccionado)
        txtTelefono.Text = Me.TableAdapterManager.DistribuidoresTableAdapter.getNumeroTelefonico(DistribuidorSeleccionado)
        txtMonto.Text = Me.TableAdapterManager.DistribuidoresTableAdapter.getMonto(DistribuidorSeleccionado)

        txtNombreDistr.Enabled = False


        PnlNuevo.Visible = True
        PnlLista.Visible = False

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Public Sub procesadorDePseudoCadena(Cadena As String)
        Dim NeoArray() = Cadena.Split("-")

        Dim Botones() = {BtnLunes, BtnMartes, BtnMiercoles, BtnJueves, BtnViernes, BtnSabado}

        For iterador As Integer = 0 To 5
            If NeoArray(iterador) = "1" Then
                Botones(iterador).Enabled = False
            Else
                Botones(iterador).Enabled = True
            End If
        Next
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Me.TableAdapterManager.DistribuidoresTableAdapter.BorrarDistribuidor(DistribuidorSeleccionado)
        Me.DistribuidoresTableAdapter.Fill(Me.Comedor_PacificoDataSet.Distribuidores)

        CrearPseudoArreglo()
        Despliegue()
        LimpiarInputs()

        PnlNuevo.Visible = False
        PnlConfirmacion.Visible = False
        PnlLista.Visible = True

        BtnEliminar.Enabled = False
        BtnEliminar.Visible = False

        PnlLista.Left = 44
        PnlLista.Top = 110
    End Sub
End Class