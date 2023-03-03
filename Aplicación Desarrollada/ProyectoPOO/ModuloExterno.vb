Module ModuloExterno
    Public NombreUsuario As String
    Public NumeroCuenta As Integer

    Public Function MarcarError(ByVal Objeto)
        Objeto.BorderColour = Color.Red
        Objeto.TextColour = Color.Red

        Return 0
    End Function

    Public Function QuitarError(ByVal Objeto)
        Objeto.BorderColour = Color.DimGray
        Objeto.TextColour = Color.Black
        Return 0
    End Function

    Public Function VerificaInts(ByVal Cadena As String)
        Try
            Convert.ToInt64(Cadena)
            Return 0
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Public Function MensajeDeError(ByVal Objeto As Object, Cadena As String, Longitud As Integer)
        Objeto.Visible = True
        Objeto.left = (1049 - Longitud) / 2
        Objeto.text = Cadena
        Return 0
    End Function

    'Difuminado Global
    Public y As Integer
    Public ObjetoAparecedor As Object

    Private WithEvents ShowForm As New Windows.Forms.Timer With {.Interval = 10}
    Public Function ShowFormStart(ByVal Objeto As Object)
        ShowForm.Start()
        ObjetoAparecedor = Objeto
        y = -1
        Return 0
    End Function

    Private Sub ShowForm_Tick(sender As Object, e As EventArgs) Handles ShowForm.Tick
        y += 20

        ObjetoAparecedor.Opacity = y / 100

        If y >= 100 Then
            ShowForm.Stop()
        End If
    End Sub
    'Fin Difuminado Global

    'Creacion Hora
    Public Function getHora()
        Dim Hora As String = DateTime.Now.ToString("HH")
        Dim Min As String = Format(DateAndTime.TimeOfDay, "mm")
        Dim Estatus As String = "-"

        If Hora < 13 Then
            Estatus = " am"
        Else
            Hora = Hora - 12
            Estatus = " pm"

            If CInt(Hora) < 10 Then
                Hora = "0" + Hora
            End If

        End If

        Dim Resultado As String = Hora + ":" + Min + Estatus
        Return Resultado
    End Function

    'Creacion Fecha
    Public Function getDia()

        Dim nDia As String = DateTime.Now.ToString("dd")
        Dim Mes As String = DateTime.Now.ToString("MMM").Substring(0, 1).ToUpper() + DateTime.Now.ToString("MMM").Substring(1)
        Dim Year As String = DateTime.Now.ToString("yyyy")

        Dim Fecha As String = nDia + "/" + Mes + "/" + Year

        Dim dia As String = DateTime.Now.ToString("ddd").Substring(0, 1).ToUpper() + DateTime.Now.ToString("ddd").Substring(1)

        Dim DiaTotal As String = Dia + " - " + Fecha

        Return DiaTotal.Replace(".", "")

    End Function

    Public Sub Desabilita(ByVal Objeto)
        Objeto.ForeColor = Color.DarkGray
        Objeto.Cursor = Cursors.Hand
    End Sub

    Public Sub Habilita(ByVal Objeto)
        Objeto.ForeColor = Color.Black
        Objeto.Cursor = Cursors.No
    End Sub

    Public Sub PermaActiva(ByVal Objeto)
        Objeto.enabled = False
    End Sub

    Public Sub Reinicia(ByVal Objeto)
        Objeto.enabled = True
        Objeto.Cursor = Cursors.Hand
    End Sub

    Public Function getClaveDia()
        Dim Fecha As String = DateTime.Now.ToString("ddMMyy")
        Return Fecha
    End Function

    Public Function getDiaEspecifico()
        Dim DiaEspecifico As String = DateTime.Now.ToString("dddd").Substring(0, 1).ToUpper() + DateTime.Now.ToString("dddd").Substring(1, DateTime.Now.ToString("dddd").Length - 1)

        Return DiaEspecifico
    End Function

    Public Function getDiaConLetra()
        Dim nDia As String = DateTime.Now.ToString("dd")
        Dim Mes As String = DateTime.Now.ToString("MMM").Substring(0, 1).ToUpper() + DateTime.Now.ToString("MMM").Substring(1)
        Dim Year As String = DateTime.Now.ToString("yyyy")


        Return nDia + "/" + Mes + "/" + Year
    End Function

End Module