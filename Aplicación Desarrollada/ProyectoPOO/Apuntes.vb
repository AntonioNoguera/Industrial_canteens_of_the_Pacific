Public Class Apuntes

    Public Hojas As Integer = 0
    Public HojaActual As Integer = 1
    Public PseudoHoja As Integer = 0

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        PantallaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Apuntes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Comedor_PacificoDataSet.Apuntes' Puede moverla o quitarla según sea necesario.
        Me.ApuntesTableAdapter.Fill(Me.Comedor_PacificoDataSet.Apuntes)
        ShowFormStart(Me)
        LbFecha.Text = getDia()
        Usuario.Text = ModuloExterno.NombreUsuario

        Despliegue()
    End Sub

    Private Sub Apuntes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Opacity = 0
    End Sub

    Private Sub ElButton23_Click(sender As Object, e As EventArgs)
        PnlLista.Visible = False
        PnlNuevo.Visible = True
        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Private Sub ElButton4_Click(sender As Object, e As EventArgs) Handles ElButton4.Click
        Label20.Text = "Nuevo Apunte"

        txtTitulo.Text = ""
        txtContenido.Text = ""
        CheckBoxEditable.Checked = False

        txtTitulo.BackgroundColour = Color.White
        txtTitulo.TextColour = Color.Black

        txtTitulo.Enabled = True

        BtnEliminar.Visible = False
        BtnEliminar.Enabled = False

        PnlLista.Visible = False
        PnlNuevo.Visible = True
        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Private Sub ElButton24_Click(sender As Object, e As EventArgs) Handles ElButton24.Click
        PnlNuevo.Visible = False
        PnlLista.Visible = True
        PnlLista.Left = 44
        PnlLista.Top = 110
    End Sub

    Private Sub ElButton3_Click(sender As Object, e As EventArgs)
        Label20.Text = "Editar Apunte"

        txtTitulo.Text = "TituloApunte"
        txtTitulo.BackgroundColour = Color.Gainsboro
        txtTitulo.TextColour = Color.White

        txtTitulo.Enabled = False

        PnlNuevo.Visible = True
        PnlLista.Visible = False

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Private Sub ElButton7_Click(sender As Object, e As EventArgs) Handles ElButton7.Click
        'Arranca Primer Validacion
        Dim flag As Boolean = False

        If txtContenido.Text = "" Then
            MarcarError(txtContenido)
            flag = True
        End If

        If txtTitulo.Text = "" Then
            MarcarError(txtTitulo)
            flag = True
        End If

        If flag Then
            'Error
            ErrorBox.Text = "             Rellena todos los campos"
        Else
            ErrorBox.Text = ""
            'Confirmacion
            LblAutor.Text = ModuloExterno.NombreUsuario
            LblContenido.Text = txtContenido.Text
            LblTitulo.Text = txtTitulo.Text

            If CheckBoxEditable.Checked Then
                LblPermisos.Text = "Todos los usuarios podrán ver y editar el apunte."
            Else
                LblPermisos.Text = "Solo el autor podra editar el apunte."
            End If

            PnlNuevo.Visible = False
            PnlConfirmacion.Visible = True

            PnlConfirmacion.Left = 44
            PnlConfirmacion.Top = 110
        End If

    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        QuitarError(txtTitulo)
    End Sub

    Private Sub txtContenido_TextChanged(sender As Object, e As EventArgs) Handles txtContenido.TextChanged
        QuitarError(txtContenido)
    End Sub

    Private Sub ElButton8_Click(sender As Object, e As EventArgs) Handles ElButton8.Click
        PnlConfirmacion.Visible = False
        PnlNuevo.Visible = True

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Private Sub ElButton9_Click(sender As Object, e As EventArgs) Handles ElButton9.Click

        Dim paraTodos As Integer
        If CheckBoxEditable.Checked Then
            paraTodos = 1
        Else
            paraTodos = 0
        End If

        If Label20.Text = "Ver / Eliminar / Editar Apunte" Then
            Me.TableAdapterManager.ApuntesTableAdapter.ActualizarApunte(txtTitulo.Text, txtContenido.Text, paraTodos, DistribuidorSeleccionado)
            Despliegue()
            limpiar()

            PnlConfirmacion.Visible = False
            PnlNuevo.Visible = False
            PnlLista.Visible = True
        Else
            'Aqui va la alta del apunte
            Dim ExisteTitulo As String = "NoHay"

            Try
                ExisteTitulo = Me.TableAdapterManager.ApuntesTableAdapter.ExisteTitulo(txtTitulo.Text)
            Catch ex As Exception
                ExisteTitulo = "NoHay"
            End Try
            If ExisteTitulo = "NoHay" Then
                'Alta

                Me.TableAdapterManager.ApuntesTableAdapter.AltaApunte(txtTitulo.Text, ModuloExterno.NumeroCuenta, txtContenido.Text, paraTodos)
                Despliegue()
                limpiar()

                PnlConfirmacion.Visible = False
                PnlNuevo.Visible = True

            Else
                ErrorBox.Text = "No se puede repetir el titulo de un apunte"
                PnlConfirmacion.Visible = False
                PnlNuevo.Visible = True
            End If
        End If

    End Sub

    Public Sub limpiar()
        txtTitulo.Text = ""
        txtContenido.Text = ""
        CheckBoxEditable.Checked = "False"
    End Sub

    Dim tDistribuidores As Double

    Public Sub Despliegue()
        tDistribuidores = Me.TableAdapterManager.ApuntesTableAdapter.nApuntes()

        nDistribuidores.Text = "# Apuntes: " + tDistribuidores.ToString()

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
                    Dim nombre As String = Me.TableAdapterManager.ApuntesTableAdapter.getTitulo(arregloSinPerdidas.Item(iteradorBase + iteradorReal - 1))

                    Casillas(iteradorReal).Visible = True
                    Casillas(iteradorReal).Enabled = True
                    Casillas(iteradorReal).AccessibleName = arregloSinPerdidas.Item(iteradorBase + iteradorReal - 1)
                    Casillas(iteradorReal).Text = (iteradorBase + iteradorReal).ToString() + ".- " + nombre
                End If
            Next
        End If
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

                Dim na As String = Me.TableAdapterManager.ApuntesTableAdapter.getTitulo(iteradorReal)

                If na <> "" Then

                    arregloSinPerdidas.Add(iteradorReal)

                End If
            Next
        End If

    End Sub

    Public Sub ObtenerPerdidaDePaquetes()

        Dim LimitePaquete As Integer = 0

        Try
            LimitePaquete = Me.TableAdapterManager.ApuntesTableAdapter.ApuntesPerdidos()

        Catch ex As Exception
            LimitePaquete = 0
        End Try
        If LimitePaquete <> 0 Then
            For BuscadorPerdidos As Integer = 1 To LimitePaquete
                Dim Hueco As String = Me.TableAdapterManager.ApuntesTableAdapter.getTitulo(BuscadorPerdidos)
                If Hueco = "" Then
                    PaquetesPerdidos += 1
                End If
            Next
        End If
    End Sub

    Dim DistribuidorSeleccionado = -1

    Private Sub LanzaVerEditar(sen As Object, e As EventArgs) Handles psObjeto1.Click, psObjeto2.Click, psObjeto6.Click, psObjeto5.Click, psObjeto4.Click, psObjeto3.Click
        DistribuidorSeleccionado = Integer.Parse(sen.AccessibleName)

        Label20.Text = "Ver / Eliminar / Editar Apunte"

        BtnEliminar.Enabled = True
        BtnEliminar.Visible = True

        txtTitulo.Text = Me.TableAdapterManager.ApuntesTableAdapter.getTitulo(DistribuidorSeleccionado)
        txtTitulo.BackgroundColour = Color.Gainsboro
        txtTitulo.TextColour = Color.White

        txtTitulo.Enabled = False

        Dim paraTodos As Integer = Me.TableAdapterManager.ApuntesTableAdapter.getParaTodos(DistribuidorSeleccionado)

        txtContenido.Text = Me.TableAdapterManager.ApuntesTableAdapter.getTextoApunte(DistribuidorSeleccionado)


        Dim autor As Integer = Me.TableAdapterManager.ApuntesTableAdapter.getAutor(DistribuidorSeleccionado)

        If (ModuloExterno.NumeroCuenta = autor) Then
            ElButton7.Enabled = True
            BtnEliminar.Enabled = True
        Else
            ElButton7.Enabled = False
            BtnEliminar.Enabled = False
        End If

        If paraTodos = 1 Or ModuloExterno.NumeroCuenta = autor Then
            txtContenido.Enabled = True
        Else
            txtContenido.Enabled = False
        End If

        If paraTodos = 1 Then
            CheckBoxEditable.Checked = True
        Else
            CheckBoxEditable.Checked = False
        End If
        PnlNuevo.Visible = True
        PnlLista.Visible = False

        PnlNuevo.Left = 44
        PnlNuevo.Top = 110
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Me.TableAdapterManager.ApuntesTableAdapter.BorrarApunte(DistribuidorSeleccionado)
        Me.ApuntesTableAdapter.Fill(Me.Comedor_PacificoDataSet.Apuntes)

        CrearPseudoArreglo()
        Despliegue()
        limpiar()

        PnlNuevo.Visible = False
        PnlLista.Visible = True

        BtnEliminar.Enabled = False
        BtnEliminar.Visible = False

        PnlLista.Left = 44
        PnlLista.Top = 110
    End Sub
End Class