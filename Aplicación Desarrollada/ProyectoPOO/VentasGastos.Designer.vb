<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentasGastos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasGastos))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTipoRegistro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMotivo = New UIDC.UI_TextBox()
        Me.txtCantidad = New UIDC.UI_TextBox()
        Me.ElButton4 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton5 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlCajas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorBox = New System.Windows.Forms.Label()
        Me.PnlConfirmacion = New System.Windows.Forms.Panel()
        Me.ElButton7 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton6 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlRegistros = New System.Windows.Forms.Panel()
        Me.TablaGastos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.NCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrosGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comedor_PacificoDataSet = New ProyectoPOO.Comedor_PacificoDataSet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.VentaLblRegistro = New System.Windows.Forms.Label()
        Me.GastoLblRegistro = New System.Windows.Forms.Label()
        Me.ElButton3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.TablaVentas = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrosVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoHayRegistros = New System.Windows.Forms.Label()
        Me.SelectorFecha = New System.Windows.Forms.Panel()
        Me.ElButton9 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton8 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SelectorDeFecha = New UIDC.UI_CustomDateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RegistrosGTableAdapter = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.RegistrosGTableAdapter()
        Me.RegistrosGVTableAdapter = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.RegistrosGVTableAdapter()
        Me.RegistrosVTableAdapter = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.RegistrosVTableAdapter()
        Me.TableAdapterManager = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.TableAdapterManager()
        Me.RegistrosGVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCajas.SuspendLayout()
        Me.PnlConfirmacion.SuspendLayout()
        CType(Me.ElButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRegistros.SuspendLayout()
        CType(Me.TablaGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectorFecha.SuspendLayout()
        CType(Me.ElButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosGVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'ElButton1
        '
        Me.ElButton1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton1.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.Location = New System.Drawing.Point(110, 549)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(208, 41)
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton1.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton1.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton1.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton1.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton1.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton1.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton1.TabIndex = 19
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton1.TextStyle.Text = "Volver"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'lblTipoRegistro
        '
        Me.lblTipoRegistro.AutoSize = True
        Me.lblTipoRegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoRegistro.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTipoRegistro.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoRegistro.ForeColor = System.Drawing.Color.Black
        Me.lblTipoRegistro.Location = New System.Drawing.Point(319, 39)
        Me.lblTipoRegistro.Name = "lblTipoRegistro"
        Me.lblTipoRegistro.Size = New System.Drawing.Size(109, 38)
        Me.lblTipoRegistro.TabIndex = 23
        Me.lblTipoRegistro.Text = "Gasto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(327, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 58)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Gastos y Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(15, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 40)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(62, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 40)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Motivo:"
        '
        'txtMotivo
        '
        Me.txtMotivo.BackColor = System.Drawing.Color.Transparent
        Me.txtMotivo.BackgroundColour = System.Drawing.Color.White
        Me.txtMotivo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMotivo.BorderSize = 2
        Me.txtMotivo.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtMotivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtMotivo.Location = New System.Drawing.Point(207, 119)
        Me.txtMotivo.MaxLength = 32767
        Me.txtMotivo.Multiline = False
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ReadOnly = False
        Me.txtMotivo.Size = New System.Drawing.Size(403, 45)
        Me.txtMotivo.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtMotivo.TabIndex = 29
        Me.txtMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMotivo.TextColour = System.Drawing.Color.Black
        Me.txtMotivo.UseSystemPasswordChar = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidad.BackgroundColour = System.Drawing.Color.White
        Me.txtCantidad.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtCantidad.BorderSize = 2
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCantidad.Location = New System.Drawing.Point(207, 203)
        Me.txtCantidad.MaxLength = 32767
        Me.txtCantidad.Multiline = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = False
        Me.txtCantidad.Size = New System.Drawing.Size(403, 45)
        Me.txtCantidad.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtCantidad.TabIndex = 30
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCantidad.TextColour = System.Drawing.Color.Black
        Me.txtCantidad.UseSystemPasswordChar = False
        '
        'ElButton4
        '
        Me.ElButton4.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton4.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton4.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton4.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton4.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton4.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton4.Location = New System.Drawing.Point(234, 297)
        Me.ElButton4.Name = "ElButton4"
        Me.ElButton4.Size = New System.Drawing.Size(208, 41)
        Me.ElButton4.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton4.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton4.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton4.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton4.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton4.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton4.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton4.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton4.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton4.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton4.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton4.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton4.TabIndex = 31
        Me.ElButton4.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton4.TextStyle.Text = "Continuar"
        Me.ElButton4.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton4.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton5
        '
        Me.ElButton5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton5.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton5.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton5.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton5.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.Location = New System.Drawing.Point(718, 554)
        Me.ElButton5.Name = "ElButton5"
        Me.ElButton5.Size = New System.Drawing.Size(208, 41)
        Me.ElButton5.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton5.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton5.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton5.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton5.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton5.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton5.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton5.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton5.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton5.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton5.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton5.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton5.TabIndex = 32
        Me.ElButton5.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton5.TextStyle.Text = "Ver Detalles"
        Me.ElButton5.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.BackColor = System.Drawing.Color.Transparent
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LbFecha.Location = New System.Drawing.Point(776, 57)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(261, 30)
        Me.LbFecha.TabIndex = 34
        Me.LbFecha.Text = "-------------------------------"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Usuario.Location = New System.Drawing.Point(157, 57)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(117, 30)
        Me.Usuario.TabIndex = 35
        Me.Usuario.Text = "-------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(831, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 30)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(62, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 38)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Opciones → "
        '
        'PnlCajas
        '
        Me.PnlCajas.BackColor = System.Drawing.Color.Transparent
        Me.PnlCajas.Controls.Add(Me.Label3)
        Me.PnlCajas.Controls.Add(Me.ErrorBox)
        Me.PnlCajas.Controls.Add(Me.Label7)
        Me.PnlCajas.Controls.Add(Me.lblTipoRegistro)
        Me.PnlCajas.Controls.Add(Me.Label2)
        Me.PnlCajas.Controls.Add(Me.Label1)
        Me.PnlCajas.Controls.Add(Me.txtCantidad)
        Me.PnlCajas.Controls.Add(Me.txtMotivo)
        Me.PnlCajas.Controls.Add(Me.ElButton4)
        Me.PnlCajas.Location = New System.Drawing.Point(227, 135)
        Me.PnlCajas.Name = "PnlCajas"
        Me.PnlCajas.Size = New System.Drawing.Size(645, 355)
        Me.PnlCajas.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(465, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 38)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Venta"
        '
        'ErrorBox
        '
        Me.ErrorBox.AutoSize = True
        Me.ErrorBox.BackColor = System.Drawing.Color.Transparent
        Me.ErrorBox.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorBox.ForeColor = System.Drawing.Color.Red
        Me.ErrorBox.Location = New System.Drawing.Point(321, 255)
        Me.ErrorBox.Name = "ErrorBox"
        Me.ErrorBox.Size = New System.Drawing.Size(0, 30)
        Me.ErrorBox.TabIndex = 41
        '
        'PnlConfirmacion
        '
        Me.PnlConfirmacion.BackColor = System.Drawing.Color.Transparent
        Me.PnlConfirmacion.Controls.Add(Me.ElButton7)
        Me.PnlConfirmacion.Controls.Add(Me.ElButton6)
        Me.PnlConfirmacion.Controls.Add(Me.lblUsuario)
        Me.PnlConfirmacion.Controls.Add(Me.lblCantidad)
        Me.PnlConfirmacion.Controls.Add(Me.lblMotivo)
        Me.PnlConfirmacion.Controls.Add(Me.lblRegistro)
        Me.PnlConfirmacion.Controls.Add(Me.Label12)
        Me.PnlConfirmacion.Controls.Add(Me.Label11)
        Me.PnlConfirmacion.Controls.Add(Me.Label10)
        Me.PnlConfirmacion.Controls.Add(Me.Label9)
        Me.PnlConfirmacion.Controls.Add(Me.Label8)
        Me.PnlConfirmacion.Location = New System.Drawing.Point(1020, 111)
        Me.PnlConfirmacion.Name = "PnlConfirmacion"
        Me.PnlConfirmacion.Size = New System.Drawing.Size(634, 355)
        Me.PnlConfirmacion.TabIndex = 40
        Me.PnlConfirmacion.Visible = False
        '
        'ElButton7
        '
        Me.ElButton7.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton7.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton7.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton7.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton7.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton7.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton7.Location = New System.Drawing.Point(353, 297)
        Me.ElButton7.Name = "ElButton7"
        Me.ElButton7.Size = New System.Drawing.Size(218, 41)
        Me.ElButton7.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton7.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton7.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton7.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton7.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton7.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton7.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton7.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton7.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton7.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton7.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton7.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton7.TabIndex = 42
        Me.ElButton7.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton7.TextStyle.Text = "Finalizar"
        Me.ElButton7.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton7.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton6
        '
        Me.ElButton6.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton6.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton6.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton6.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton6.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton6.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton6.Location = New System.Drawing.Point(91, 297)
        Me.ElButton6.Name = "ElButton6"
        Me.ElButton6.Size = New System.Drawing.Size(218, 41)
        Me.ElButton6.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton6.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton6.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton6.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton6.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton6.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton6.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton6.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton6.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton6.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton6.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton6.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton6.TabIndex = 41
        Me.ElButton6.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton6.TextStyle.Text = "Corregir Datos"
        Me.ElButton6.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton6.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUsuario.Location = New System.Drawing.Point(333, 225)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(156, 40)
        Me.lblUsuario.TabIndex = 35
        Me.lblUsuario.Text = "Registro:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCantidad.Location = New System.Drawing.Point(333, 171)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(156, 40)
        Me.lblCantidad.TabIndex = 34
        Me.lblCantidad.Text = "Registro:"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.BackColor = System.Drawing.Color.Transparent
        Me.lblMotivo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMotivo.Location = New System.Drawing.Point(333, 122)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(156, 40)
        Me.lblMotivo.TabIndex = 33
        Me.lblMotivo.Text = "Registro:"
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistro.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRegistro.Location = New System.Drawing.Point(333, 67)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(156, 40)
        Me.lblRegistro.TabIndex = 32
        Me.lblRegistro.Text = "Registro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(188, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 40)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(171, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 40)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Registro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(188, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 40)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Motivo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(141, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 40)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(220, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 40)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Confirmación"
        '
        'PnlRegistros
        '
        Me.PnlRegistros.BackColor = System.Drawing.Color.Transparent
        Me.PnlRegistros.Controls.Add(Me.TablaGastos)
        Me.PnlRegistros.Controls.Add(Me.Label16)
        Me.PnlRegistros.Controls.Add(Me.VentaLblRegistro)
        Me.PnlRegistros.Controls.Add(Me.GastoLblRegistro)
        Me.PnlRegistros.Controls.Add(Me.ElButton3)
        Me.PnlRegistros.Controls.Add(Me.Label15)
        Me.PnlRegistros.Controls.Add(Me.ElButton2)
        Me.PnlRegistros.Controls.Add(Me.TablaVentas)
        Me.PnlRegistros.Controls.Add(Me.NoHayRegistros)
        Me.PnlRegistros.Location = New System.Drawing.Point(986, 588)
        Me.PnlRegistros.Name = "PnlRegistros"
        Me.PnlRegistros.Size = New System.Drawing.Size(908, 503)
        Me.PnlRegistros.TabIndex = 43
        '
        'TablaGastos
        '
        Me.TablaGastos.AllowUserToAddRows = False
        Me.TablaGastos.AllowUserToDeleteRows = False
        Me.TablaGastos.AllowUserToOrderColumns = True
        Me.TablaGastos.AllowUserToResizeColumns = False
        Me.TablaGastos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaGastos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaGastos.AutoGenerateColumns = False
        Me.TablaGastos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TablaGastos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablaGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TablaGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TablaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCuentaDataGridViewTextBoxColumn, Me.MotivoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.TablaGastos.DataSource = Me.RegistrosGBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaGastos.DefaultCellStyle = DataGridViewCellStyle4
        Me.TablaGastos.DoubleBuffered = True
        Me.TablaGastos.Enabled = False
        Me.TablaGastos.EnableHeadersVisualStyles = False
        Me.TablaGastos.HeaderBgColor = System.Drawing.Color.DarkSalmon
        Me.TablaGastos.HeaderForeColor = System.Drawing.Color.White
        Me.TablaGastos.Location = New System.Drawing.Point(50, 123)
        Me.TablaGastos.MultiSelect = False
        Me.TablaGastos.Name = "TablaGastos"
        Me.TablaGastos.ReadOnly = True
        Me.TablaGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.TablaGastos.RowHeadersVisible = False
        Me.TablaGastos.RowHeadersWidth = 100
        Me.TablaGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.NullValue = "-"
        Me.TablaGastos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.TablaGastos.RowTemplate.Height = 30
        Me.TablaGastos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TablaGastos.Size = New System.Drawing.Size(820, 82)
        Me.TablaGastos.TabIndex = 43
        Me.TablaGastos.Visible = False
        '
        'NCuentaDataGridViewTextBoxColumn
        '
        Me.NCuentaDataGridViewTextBoxColumn.DataPropertyName = "nCuenta"
        Me.NCuentaDataGridViewTextBoxColumn.DividerWidth = 1
        Me.NCuentaDataGridViewTextBoxColumn.HeaderText = "nCuenta"
        Me.NCuentaDataGridViewTextBoxColumn.Name = "NCuentaDataGridViewTextBoxColumn"
        Me.NCuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NCuentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NCuentaDataGridViewTextBoxColumn.Width = 200
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.MotivoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MotivoDataGridViewTextBoxColumn.DividerWidth = 1
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "Motivo"
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MotivoDataGridViewTextBoxColumn.Width = 350
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.DividerWidth = 1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MontoDataGridViewTextBoxColumn.Width = 150
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HoraDataGridViewTextBoxColumn.Width = 120
        '
        'RegistrosGBindingSource
        '
        Me.RegistrosGBindingSource.DataMember = "RegistrosG"
        Me.RegistrosGBindingSource.DataSource = Me.Comedor_PacificoDataSet
        '
        'Comedor_PacificoDataSet
        '
        Me.Comedor_PacificoDataSet.DataSetName = "Comedor_PacificoDataSet"
        Me.Comedor_PacificoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.No
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(299, 389)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 38)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Balance: "
        '
        'VentaLblRegistro
        '
        Me.VentaLblRegistro.AutoSize = True
        Me.VentaLblRegistro.BackColor = System.Drawing.Color.Transparent
        Me.VentaLblRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VentaLblRegistro.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaLblRegistro.ForeColor = System.Drawing.Color.DarkGray
        Me.VentaLblRegistro.Location = New System.Drawing.Point(499, 69)
        Me.VentaLblRegistro.Name = "VentaLblRegistro"
        Me.VentaLblRegistro.Size = New System.Drawing.Size(109, 38)
        Me.VentaLblRegistro.TabIndex = 41
        Me.VentaLblRegistro.Text = "Venta"
        '
        'GastoLblRegistro
        '
        Me.GastoLblRegistro.AutoSize = True
        Me.GastoLblRegistro.BackColor = System.Drawing.Color.Transparent
        Me.GastoLblRegistro.Cursor = System.Windows.Forms.Cursors.No
        Me.GastoLblRegistro.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GastoLblRegistro.ForeColor = System.Drawing.Color.Black
        Me.GastoLblRegistro.Location = New System.Drawing.Point(330, 69)
        Me.GastoLblRegistro.Name = "GastoLblRegistro"
        Me.GastoLblRegistro.Size = New System.Drawing.Size(109, 38)
        Me.GastoLblRegistro.TabIndex = 40
        Me.GastoLblRegistro.Text = "Gasto"
        '
        'ElButton3
        '
        Me.ElButton3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton3.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton3.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton3.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.Location = New System.Drawing.Point(524, 438)
        Me.ElButton3.Name = "ElButton3"
        Me.ElButton3.Size = New System.Drawing.Size(208, 41)
        Me.ElButton3.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton3.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton3.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton3.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton3.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton3.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton3.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton3.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton3.TabIndex = 39
        Me.ElButton3.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton3.TextStyle.Text = "Fecha en Específico"
        Me.ElButton3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(265, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(400, 38)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Registros del día de hoy:"
        '
        'ElButton2
        '
        Me.ElButton2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton2.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.Location = New System.Drawing.Point(182, 442)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(208, 41)
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton2.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton2.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton2.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton2.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton2.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton2.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton2.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton2.TabIndex = 31
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton2.TextStyle.Text = "Volver"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'TablaVentas
        '
        Me.TablaVentas.AllowUserToAddRows = False
        Me.TablaVentas.AllowUserToDeleteRows = False
        Me.TablaVentas.AllowUserToOrderColumns = True
        Me.TablaVentas.AllowUserToResizeColumns = False
        Me.TablaVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TablaVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.TablaVentas.AutoGenerateColumns = False
        Me.TablaVentas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.TablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TablaVentas.DataSource = Me.RegistrosVBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaVentas.DefaultCellStyle = DataGridViewCellStyle9
        Me.TablaVentas.DoubleBuffered = True
        Me.TablaVentas.Enabled = False
        Me.TablaVentas.EnableHeadersVisualStyles = False
        Me.TablaVentas.HeaderBgColor = System.Drawing.Color.DarkSeaGreen
        Me.TablaVentas.HeaderForeColor = System.Drawing.Color.White
        Me.TablaVentas.Location = New System.Drawing.Point(738, 332)
        Me.TablaVentas.MultiSelect = False
        Me.TablaVentas.Name = "TablaVentas"
        Me.TablaVentas.ReadOnly = True
        Me.TablaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.TablaVentas.RowHeadersVisible = False
        Me.TablaVentas.RowHeadersWidth = 100
        Me.TablaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.NullValue = "-"
        Me.TablaVentas.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.TablaVentas.RowTemplate.Height = 30
        Me.TablaVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TablaVentas.Size = New System.Drawing.Size(820, 216)
        Me.TablaVentas.TabIndex = 44
        Me.TablaVentas.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nCuenta"
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.HeaderText = "nCuenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Motivo"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.DividerWidth = 1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn3.DividerWidth = 1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn4.DividerWidth = 1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'RegistrosVBindingSource
        '
        Me.RegistrosVBindingSource.DataMember = "RegistrosV"
        Me.RegistrosVBindingSource.DataSource = Me.Comedor_PacificoDataSet
        '
        'NoHayRegistros
        '
        Me.NoHayRegistros.AutoSize = True
        Me.NoHayRegistros.BackColor = System.Drawing.Color.Transparent
        Me.NoHayRegistros.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoHayRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NoHayRegistros.Location = New System.Drawing.Point(291, 157)
        Me.NoHayRegistros.Name = "NoHayRegistros"
        Me.NoHayRegistros.Size = New System.Drawing.Size(343, 24)
        Me.NoHayRegistros.TabIndex = 45
        Me.NoHayRegistros.Text = "¡No has realizado ningun registro!"
        Me.NoHayRegistros.Visible = False
        '
        'SelectorFecha
        '
        Me.SelectorFecha.BackColor = System.Drawing.Color.Transparent
        Me.SelectorFecha.Controls.Add(Me.ElButton9)
        Me.SelectorFecha.Controls.Add(Me.ElButton8)
        Me.SelectorFecha.Controls.Add(Me.Label20)
        Me.SelectorFecha.Controls.Add(Me.SelectorDeFecha)
        Me.SelectorFecha.Controls.Add(Me.Label18)
        Me.SelectorFecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectorFecha.Location = New System.Drawing.Point(18, 601)
        Me.SelectorFecha.Name = "SelectorFecha"
        Me.SelectorFecha.Size = New System.Drawing.Size(908, 503)
        Me.SelectorFecha.TabIndex = 44
        '
        'ElButton9
        '
        Me.ElButton9.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton9.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton9.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton9.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton9.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton9.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton9.Location = New System.Drawing.Point(459, 273)
        Me.ElButton9.Name = "ElButton9"
        Me.ElButton9.Size = New System.Drawing.Size(208, 41)
        Me.ElButton9.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton9.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton9.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton9.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton9.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton9.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton9.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton9.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton9.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton9.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton9.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton9.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton9.TabIndex = 45
        Me.ElButton9.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton9.TextStyle.Text = "Aceptar"
        Me.ElButton9.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton9.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton8
        '
        Me.ElButton8.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton8.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton8.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton8.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton8.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton8.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton8.Location = New System.Drawing.Point(221, 273)
        Me.ElButton8.Name = "ElButton8"
        Me.ElButton8.Size = New System.Drawing.Size(208, 41)
        Me.ElButton8.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton8.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton8.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton8.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton8.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton8.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton8.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton8.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton8.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton8.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton8.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton8.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton8.TabIndex = 44
        Me.ElButton8.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton8.TextStyle.Text = "Volver"
        Me.ElButton8.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton8.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(289, 190)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 36)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Fecha:"
        '
        'SelectorDeFecha
        '
        Me.SelectorDeFecha.BackColor = System.Drawing.Color.Transparent
        Me.SelectorDeFecha.CollapseColor = System.Drawing.Color.Transparent
        Me.SelectorDeFecha.CustomFormat = Nothing
        Me.SelectorDeFecha.Font = New System.Drawing.Font("Century Gothic", 22.0!)
        Me.SelectorDeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SelectorDeFecha.HeightBase = 30
        Me.SelectorDeFecha.LineColor = System.Drawing.Color.DodgerBlue
        Me.SelectorDeFecha.LineSize = 0
        Me.SelectorDeFecha.Location = New System.Drawing.Point(419, 190)
        Me.SelectorDeFecha.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.SelectorDeFecha.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.SelectorDeFecha.Name = "SelectorDeFecha"
        Me.SelectorDeFecha.Padding = New System.Windows.Forms.Padding(0, 0, 32, 0)
        Me.SelectorDeFecha.Radius = False
        Me.SelectorDeFecha.Size = New System.Drawing.Size(214, 36)
        Me.SelectorDeFecha.SolidColor = System.Drawing.Color.DodgerBlue
        Me.SelectorDeFecha.TabIndex = 42
        Me.SelectorDeFecha.Text = "31/05/2022"
        Me.SelectorDeFecha.TextColor = System.Drawing.Color.White
        Me.SelectorDeFecha.Value = New Date(2022, 5, 31, 14, 49, 40, 16)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(303, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(312, 36)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Seleccione su fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(167, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 30)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Usuario:"
        '
        'RegistrosGTableAdapter
        '
        Me.RegistrosGTableAdapter.ClearBeforeFill = True
        '
        'RegistrosGVTableAdapter
        '
        Me.RegistrosGVTableAdapter.ClearBeforeFill = True
        '
        'RegistrosVTableAdapter
        '
        Me.RegistrosVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApuntesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DistribuidoresTableAdapter = Nothing
        Me.TableAdapterManager.RegCenasTableAdapter = Nothing
        Me.TableAdapterManager.RegComidasTableAdapter = Nothing
        Me.TableAdapterManager.RegDesayunosTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosGTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosGVTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosTotalesTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoPOO.Comedor_PacificoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosComedorTableAdapter = Nothing
        '
        'RegistrosGVBindingSource
        '
        Me.RegistrosGVBindingSource.DataMember = "RegistrosGV"
        Me.RegistrosGVBindingSource.DataSource = Me.Comedor_PacificoDataSet
        '
        'VentasGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1047, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.SelectorFecha)
        Me.Controls.Add(Me.PnlRegistros)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PnlCajas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.ElButton5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ElButton1)
        Me.Controls.Add(Me.PnlConfirmacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentasGastos"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCajas.ResumeLayout(False)
        Me.PnlCajas.PerformLayout()
        Me.PnlConfirmacion.ResumeLayout(False)
        Me.PnlConfirmacion.PerformLayout()
        CType(Me.ElButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRegistros.ResumeLayout(False)
        Me.PnlRegistros.PerformLayout()
        CType(Me.TablaGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectorFecha.ResumeLayout(False)
        Me.SelectorFecha.PerformLayout()
        CType(Me.ElButton9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosGVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTipoRegistro As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As UIDC.UI_TextBox
    Friend WithEvents txtMotivo As UIDC.UI_TextBox
    Private WithEvents ElButton5 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton4 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents LbFecha As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlCajas As Panel
    Friend WithEvents PnlConfirmacion As Panel
    Private WithEvents ElButton7 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton6 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblMotivo As Label
    Friend WithEvents lblRegistro As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorBox As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RegistrosGBindingSource As BindingSource
    Friend WithEvents Comedor_PacificoDataSet As Comedor_PacificoDataSet
    Friend WithEvents RegistrosGTableAdapter As Comedor_PacificoDataSetTableAdapters.RegistrosGTableAdapter
    Friend WithEvents TableAdapterManager As Comedor_PacificoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrosVTableAdapter As Comedor_PacificoDataSetTableAdapters.RegistrosVTableAdapter
    Friend WithEvents RegistrosVBindingSource As BindingSource
    Friend WithEvents RegistrosGVTableAdapter As Comedor_PacificoDataSetTableAdapters.RegistrosGVTableAdapter
    Friend WithEvents RegistrosGVBindingSource As BindingSource
    Friend WithEvents PnlRegistros As Panel
    Friend WithEvents Label15 As Label
    Private WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label16 As Label
    Friend WithEvents VentaLblRegistro As Label
    Friend WithEvents GastoLblRegistro As Label
    Private WithEvents ElButton3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents TablaGastos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TablaVentas As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoHayRegistros As Label
    Friend WithEvents SelectorFecha As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents SelectorDeFecha As UIDC.UI_CustomDateTimePicker
    Friend WithEvents Label18 As Label
    Private WithEvents ElButton9 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton8 As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
