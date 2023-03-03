Public Class PantallaPrincipal
    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.UsuariosComedor' Puede moverla o quitarla según sea necesario.
        Me.UsuariosComedorTableAdapter.Fill(Me.Comedor_PacificoDataSet.UsuariosComedor)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.Distribuidores' Puede moverla o quitarla según sea necesario.
        Me.DistribuidoresTableAdapter.Fill(Me.Comedor_PacificoDataSet.Distribuidores)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosTotales' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTotalesTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosTotales)
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.RegistrosGV' Puede moverla o quitarla según sea necesario.
        Me.RegistrosGVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosGV)

        ModuloExterno.ShowFormStart(Me)
        ModuloExterno.ShowFormStart(Me)
        LbUsuario.Text = ModuloExterno.NombreUsuario
        ModuloExterno.NumeroCuenta = Me.UsuariosComedorTableAdapter.BuscarUsuario(ModuloExterno.NombreUsuario)

        timer2.Start()
        LbHora.Text = getHora()
        LbFecha.Text = getDia()

        MensajesHorario()

        'SetNuevoDia   
        Dim ExisteDia As String = ""
        Try
            ExisteDia = Me.RegistrosGVTableAdapter.ExisteDia(getClaveDia())
        Catch ex As Exception
            ExisteDia = ""
        End Try


        If ExisteDia = "" Then
            Me.RegistrosGVTableAdapter.IniciarDia(getClaveDia(), getDiaConLetra(), getDiaEspecifico(), 0, 0, 0)
            Me.RegistrosGVTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosGV)

            Me.RegistrosTotalesTableAdapter.InicioDiaRegistros(ModuloExterno.getClaveDia)
            Me.RegistrosTotalesTableAdapter.Fill(Me.Comedor_PacificoDataSet.RegistrosTotales)
        End If

        'Inicia el contador de dias que 
        Dim diaSemanaal() = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado"}

        Dim dia As String = DateTime.Now.ToString("dddd").Substring(0, 1).ToUpper() + DateTime.Now.ToString("dddd").Substring(1)

        Dim posicionDelCodigo As Integer

        For iterador As Integer = 0 To 5
            If diaSemanaal(iterador) = dia Then
                posicionDelCodigo = iterador
            End If
        Next

        Dim numeroDeDistribuidores As Integer

        Try
            numeroDeDistribuidores = Me.DistribuidoresTableAdapter.PerdidaPaquete()
        Catch ex As Exception
            numeroDeDistribuidores = 0
        End Try

        Dim PsObjetos() = {psObjeto1, psObjeto2, psObjeto3, psObjeto4, psObjeto5, psObjeto6, psObjeto7, psObjeto8}
        Dim PsCasillas() = {Hora1, Hora2, Hora3, Hora4, Hora5, Hora6, Hora7, Hora8}

        If numeroDeDistribuidores <> 0 Then
            Dim arregloSinPerdidas As New ArrayList
            arregloSinPerdidas.Clear()

            For NeoIterador As Integer = 1 To numeroDeDistribuidores
                Dim cadenaSemanal As String
                cadenaSemanal = Me.DistribuidoresTableAdapter.getAsistencia(NeoIterador)
                If cadenaSemanal <> "" Then
                    Dim NeoArray() = cadenaSemanal.Split("-")

                    If NeoArray(posicionDelCodigo) = 1 Then
                        'Agregar a la lista semanal
                        arregloSinPerdidas.Add(NeoIterador)
                    End If
                End If
            Next

            'Mandar el arreglo a ordenar 
            For NeoIterador As Integer = 0 To arregloSinPerdidas.Count() - 2
                For IteradorEspecifico As Integer = 0 To (arregloSinPerdidas.Count() - 2)
                    If CodificaHorarios(arregloSinPerdidas.Item(IteradorEspecifico)) > CodificaHorarios(arregloSinPerdidas.Item(IteradorEspecifico + 1)) Then
                        Dim temporal As Integer = arregloSinPerdidas.Item(IteradorEspecifico)
                        arregloSinPerdidas.Item(IteradorEspecifico) = arregloSinPerdidas.Item(IteradorEspecifico + 1)
                        arregloSinPerdidas.Item(IteradorEspecifico + 1) = temporal
                    End If
                Next
            Next

            'Inicio Mostrar en Display

            For IteradorDisplay = 0 To 7

                If (IteradorDisplay + 1) > arregloSinPerdidas.Count Then
                    PsObjetos(IteradorDisplay).Visible = False
                    PsCasillas(IteradorDisplay).Visible = False
                Else

                    Dim Distribuidor = Me.DistribuidoresTableAdapter.getNombreDistribuidor(arregloSinPerdidas.Item(IteradorDisplay))
                    Dim Monto As String = Me.DistribuidoresTableAdapter.getMonto(arregloSinPerdidas.Item(IteradorDisplay))
                    Dim Nombre As String = Me.DistribuidoresTableAdapter.getNombreEmpleado(arregloSinPerdidas.Item(IteradorDisplay))
                    Dim Telefono As String = Me.DistribuidoresTableAdapter.getNumeroTelefonico(arregloSinPerdidas.Item(IteradorDisplay))

                    PsObjetos(IteradorDisplay).Text = Distribuidor
                    PsCasillas(IteradorDisplay).Text = Me.DistribuidoresTableAdapter.getHoraAsistencia(arregloSinPerdidas.Item(IteradorDisplay))


                    PsObjetos(IteradorDisplay).AccessibleDescription = "Datos del Distribuidor: " + Distribuidor + Chr(13) + Chr(13) + "Nombre del Empleado: " + Nombre + Chr(13) + "Número Teléfonico: " + Telefono + Chr(13) + Chr(13) + "Monto Requerido: " + Monto + " $"
                End If
            Next
            psObjeto33.visible = False
        Else
            For NeoIterador As Integer = 0 To 7
                PsObjetos(NeoIterador).Visible = False
                PsCasillas(NeoIterador).Visible = False
            Next

            psObjeto33.visible = True
        End If

    End Sub

    Public Function CodificaHorarios(ByVal ValorBusqueda As Integer)

        Dim Cadena As String = Me.DistribuidoresTableAdapter.getHoraAsistencia(ValorBusqueda)

        Dim strHora As String = Cadena.Substring(0, 2)
        Dim strMin As String = Cadena.Substring(3, 2)
        Dim strMeridiano As String = Cadena.Substring(6, 2)

        Dim resultado As Integer = 0

        If strMeridiano = "AM" Then
            resultado = Integer.Parse(strHora) * 60 + Integer.Parse(strMin)
        Else
            resultado = Integer.Parse(strHora) * 60 + Integer.Parse(strMin) + 720
        End If

        Return resultado
    End Function

    Private Sub ElButton5_Click(sender As Object, e As EventArgs) Handles ElButton5.Click
        StartUpForm.Close()
    End Sub

    Private WithEvents timer2 As New Windows.Forms.Timer With {.Interval = 1000}
    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        LbHora.Text = ModuloExterno.getHora()
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        Distribuidores.Show()
        Me.Close()
    End Sub

    Private Sub ElButton3_Click(sender As Object, e As EventArgs) Handles ElButton3.Click
        Registros.Show()
        Me.Close()
    End Sub

    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        VentasGastos.Show()
        Me.Close()
    End Sub

    Private Sub ElButton4_Click(sender As Object, e As EventArgs) Handles ElButton4.Click
        Apuntes.Show()
        Me.Close()
    End Sub

    Private Sub PantallaPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Opacity = 0
    End Sub

    Private Sub RegistrosGVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RegistrosGVBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comedor_PacificoDataSet)

    End Sub

    Private Sub MuestraPropiedades(sender As Object, e As EventArgs) Handles psObjeto1.Click, psObjeto2.Click, psObjeto3.Click, psObjeto4.Click, psObjeto5.Click, psObjeto6.Click, psObjeto7.Click, psObjeto8.Click, BTN1.Click, BTN2.Click, BTN3.Click, BTN4.Click, BTN5.Click, BTN6.Click, BTN7.Click, BTN8.Click, BTN9.Click, BTN10.Click, BTN11.Click, BTN12.Click, BTN13.Click, BTN14.Click, BTN15.Click, BTN16.Click
        MsgBox(sender.AccessibleDescription)
    End Sub
    Private Sub MensajesHorario()
        Dim Cajitas() = {BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16}
        Dim Descripciones(15) As String

        Descripciones(0) = "Inicio del Día: " + Chr(13) + Chr(13) + "Abrir Caja" + Chr(13) + "Limpiar Mesa de Trabajo" + Chr(13) + "Rellenar Refrigeradores" + Chr(13) + "Preparar Ordenes RH"
        Descripciones(15) = "Final del Día:" + Chr(13) + Chr(13) + "Rellena Refrigeradores" + Chr(13) + "Inicia Cierre de Caja" + Chr(13) + "Limpieza General de Área de Trabajo."
        For NeoIterador As Integer = 0 To 15
            Cajitas(NeoIterador).AccessibleDescription = Descripciones(NeoIterador)
        Next
    End Sub
End Class