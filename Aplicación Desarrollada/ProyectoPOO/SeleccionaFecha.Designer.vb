<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionaFecha
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UI_Calendar1 = New UIDC.UI_Calendar()
        Me.SuspendLayout()
        '
        'UI_Calendar1
        '
        Me.UI_Calendar1.BackColor = System.Drawing.Color.White
        Me.UI_Calendar1.ButtonCollapse = False
        Me.UI_Calendar1.ButtonDay = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_Calendar1.ButtonDayFont = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.ButtonDownColor = System.Drawing.Color.WhiteSmoke
        Me.UI_Calendar1.ButtonOverColor = System.Drawing.Color.RosyBrown
        Me.UI_Calendar1.ButtonTextFormat = True
        Me.UI_Calendar1.DayFont = New System.Drawing.Font("Arial Rounded MT Bold", 65.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.DayForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UI_Calendar1.DayFormat = UIDC.UI_Calendar.DiaLetra.Abbreviation
        Me.UI_Calendar1.DayMonthFollowForeColor = System.Drawing.Color.Gray
        Me.UI_Calendar1.DayMonthForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.UI_Calendar1.DayMonthPassedForeColor = System.Drawing.Color.Gray
        Me.UI_Calendar1.DaySemanaFont = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.DaysForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_Calendar1.DayWeekForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.UI_Calendar1.ElipceSize = 5
        Me.UI_Calendar1.HourFont = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.Location = New System.Drawing.Point(12, 7)
        Me.UI_Calendar1.MonthFont = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.MonthForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UI_Calendar1.MoveCalendar = False
        Me.UI_Calendar1.Name = "UI_Calendar1"
        Me.UI_Calendar1.PanelBottonBackColor = System.Drawing.Color.White
        Me.UI_Calendar1.PanelDateBackColor = System.Drawing.Color.White
        Me.UI_Calendar1.PanelDateHeight = 100
        Me.UI_Calendar1.PanelDayBackColor = System.Drawing.Color.White
        Me.UI_Calendar1.PanelLowerBackColor = System.Drawing.Color.White
        Me.UI_Calendar1.SemanaFont = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.Size = New System.Drawing.Size(350, 455)
        Me.UI_Calendar1.TabIndex = 4
        Me.UI_Calendar1.Text = "a"
        Me.UI_Calendar1.TimeForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.UI_Calendar1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.UI_Calendar1.TitleFont = New System.Drawing.Font("Arial Rounded MT Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.TitleForeColor = System.Drawing.Color.White
        Me.UI_Calendar1.TitleFormat = UIDC.UI_Calendar.TextHora.Text
        Me.UI_Calendar1.TitleHeight = 40
        Me.UI_Calendar1.TitleText = "Calendario"
        Me.UI_Calendar1.TitleVisible = True
        Me.UI_Calendar1.YearFont = New System.Drawing.Font("Arial Rounded MT Bold", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendar1.YearForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        '
        'SeleccionaFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 474)
        Me.Controls.Add(Me.UI_Calendar1)
        Me.Name = "SeleccionaFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeleccionaFecha"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_Calendar1 As UIDC.UI_Calendar
End Class
