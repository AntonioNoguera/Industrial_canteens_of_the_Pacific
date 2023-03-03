<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Apuntes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Apuntes))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlNuevo = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ErrorBox = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxEditable = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.ElButton24 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtContenido = New UIDC.UI_TextBox()
        Me.txtTitulo = New UIDC.UI_TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ElButton7 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.PnlLista = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.psObjeto33 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto6 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto5 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto4 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.psObjeto1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.panelHojas = New System.Windows.Forms.Label()
        Me.nDistribuidores = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backHoja = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.nextHoja = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElButton4 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PnlConfirmacion = New System.Windows.Forms.Panel()
        Me.LblContenido = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblPermisos = New System.Windows.Forms.Label()
        Me.ElButton8 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ElButton9 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Comedor_PacificoDataSet = New ProyectoPOO.Comedor_PacificoDataSet()
        Me.ApuntesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApuntesTableAdapter = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.ApuntesTableAdapter()
        Me.TableAdapterManager = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.TableAdapterManager()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNuevo.SuspendLayout()
        CType(Me.BtnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLista.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.psObjeto33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psObjeto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextHoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlConfirmacion.SuspendLayout()
        CType(Me.ElButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApuntesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ElButton1.Location = New System.Drawing.Point(423, 528)
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
        Me.ElButton1.TabIndex = 20
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton1.TextStyle.Text = "Volver"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(826, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 30)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(162, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 30)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Usuario:"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Usuario.Location = New System.Drawing.Point(152, 57)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(117, 30)
        Me.Usuario.TabIndex = 45
        Me.Usuario.Text = "-------------"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.BackColor = System.Drawing.Color.Transparent
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LbFecha.Location = New System.Drawing.Point(771, 57)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(205, 30)
        Me.LbFecha.TabIndex = 44
        Me.LbFecha.Text = "------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(385, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 58)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Apuntes"
        '
        'PnlNuevo
        '
        Me.PnlNuevo.BackColor = System.Drawing.Color.Transparent
        Me.PnlNuevo.Controls.Add(Me.BtnEliminar)
        Me.PnlNuevo.Controls.Add(Me.ErrorBox)
        Me.PnlNuevo.Controls.Add(Me.Label13)
        Me.PnlNuevo.Controls.Add(Me.CheckBoxEditable)
        Me.PnlNuevo.Controls.Add(Me.ElButton24)
        Me.PnlNuevo.Controls.Add(Me.txtContenido)
        Me.PnlNuevo.Controls.Add(Me.txtTitulo)
        Me.PnlNuevo.Controls.Add(Me.Label15)
        Me.PnlNuevo.Controls.Add(Me.Label19)
        Me.PnlNuevo.Controls.Add(Me.Label20)
        Me.PnlNuevo.Controls.Add(Me.ElButton7)
        Me.PnlNuevo.Location = New System.Drawing.Point(1029, 12)
        Me.PnlNuevo.Name = "PnlNuevo"
        Me.PnlNuevo.Size = New System.Drawing.Size(972, 520)
        Me.PnlNuevo.TabIndex = 68
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEliminar.BackgroundStyle.GradientStartColor = System.Drawing.Color.IndianRed
        Me.BtnEliminar.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.BorderStyle.GradientEndColor = System.Drawing.Color.IndianRed
        Me.BtnEliminar.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEliminar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.BtnEliminar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnEliminar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(427, 453)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(139, 41)
        Me.BtnEliminar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnEliminar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnEliminar.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.BtnEliminar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnEliminar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnEliminar.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.BtnEliminar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnEliminar.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.BtnEliminar.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.BtnEliminar.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnEliminar.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnEliminar.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.BtnEliminar.TabIndex = 78
        Me.BtnEliminar.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnEliminar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.TextStyle.Text = "Eliminar"
        Me.BtnEliminar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEliminar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ErrorBox
        '
        Me.ErrorBox.AutoSize = True
        Me.ErrorBox.BackColor = System.Drawing.Color.Transparent
        Me.ErrorBox.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorBox.ForeColor = System.Drawing.Color.Red
        Me.ErrorBox.Location = New System.Drawing.Point(294, 428)
        Me.ErrorBox.Name = "ErrorBox"
        Me.ErrorBox.Size = New System.Drawing.Size(0, 30)
        Me.ErrorBox.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(324, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(257, 30)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "¿Editable por todos?"
        '
        'CheckBoxEditable
        '
        Me.CheckBoxEditable.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckBoxEditable.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckBoxEditable.Checked = False
        Me.CheckBoxEditable.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckBoxEditable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxEditable.ForeColor = System.Drawing.Color.White
        Me.CheckBoxEditable.Location = New System.Drawing.Point(600, 397)
        Me.CheckBoxEditable.Name = "CheckBoxEditable"
        Me.CheckBoxEditable.Size = New System.Drawing.Size(20, 20)
        Me.CheckBoxEditable.TabIndex = 70
        '
        'ElButton24
        '
        Me.ElButton24.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton24.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton24.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton24.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton24.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton24.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton24.Location = New System.Drawing.Point(265, 453)
        Me.ElButton24.Name = "ElButton24"
        Me.ElButton24.Size = New System.Drawing.Size(139, 41)
        Me.ElButton24.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton24.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ElButton24.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton24.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton24.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ElButton24.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton24.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton24.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ElButton24.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.ElButton24.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton24.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ElButton24.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.ElButton24.TabIndex = 69
        Me.ElButton24.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton24.TextStyle.Text = "Volver"
        Me.ElButton24.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton24.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'txtContenido
        '
        Me.txtContenido.BackColor = System.Drawing.Color.Transparent
        Me.txtContenido.BackgroundColour = System.Drawing.Color.White
        Me.txtContenido.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtContenido.BorderSize = 2
        Me.txtContenido.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtContenido.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtContenido.Location = New System.Drawing.Point(32, 169)
        Me.txtContenido.MaxLength = 32767
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.ReadOnly = False
        Me.txtContenido.Size = New System.Drawing.Size(909, 213)
        Me.txtContenido.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtContenido.TabIndex = 60
        Me.txtContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContenido.TextColour = System.Drawing.Color.Black
        Me.txtContenido.UseSystemPasswordChar = False
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.BackgroundColour = System.Drawing.Color.White
        Me.txtTitulo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtTitulo.BorderSize = 2
        Me.txtTitulo.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtTitulo.Location = New System.Drawing.Point(205, 77)
        Me.txtTitulo.MaxLength = 32767
        Me.txtTitulo.Multiline = False
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = False
        Me.txtTitulo.Size = New System.Drawing.Size(582, 45)
        Me.txtTitulo.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtTitulo.TabIndex = 55
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTitulo.TextColour = System.Drawing.Color.Black
        Me.txtTitulo.UseSystemPasswordChar = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(389, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(222, 30)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Texto del Apunte:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(396, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(220, 30)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Título del apunte:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(405, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 28)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Nuevo Apunte:"
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
        Me.ElButton7.Location = New System.Drawing.Point(589, 453)
        Me.ElButton7.Name = "ElButton7"
        Me.ElButton7.Size = New System.Drawing.Size(139, 41)
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
        Me.ElButton7.TabIndex = 22
        Me.ElButton7.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton7.TextStyle.Text = "Continuar"
        Me.ElButton7.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton7.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'PnlLista
        '
        Me.PnlLista.BackColor = System.Drawing.Color.Transparent
        Me.PnlLista.Controls.Add(Me.Panel1)
        Me.PnlLista.Controls.Add(Me.Label1)
        Me.PnlLista.Controls.Add(Me.ElButton4)
        Me.PnlLista.Controls.Add(Me.PictureBox2)
        Me.PnlLista.Location = New System.Drawing.Point(44, 110)
        Me.PnlLista.Name = "PnlLista"
        Me.PnlLista.Size = New System.Drawing.Size(950, 414)
        Me.PnlLista.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.psObjeto33)
        Me.Panel1.Controls.Add(Me.psObjeto6)
        Me.Panel1.Controls.Add(Me.psObjeto5)
        Me.Panel1.Controls.Add(Me.psObjeto2)
        Me.Panel1.Controls.Add(Me.psObjeto3)
        Me.Panel1.Controls.Add(Me.psObjeto4)
        Me.Panel1.Controls.Add(Me.psObjeto1)
        Me.Panel1.Controls.Add(Me.panelHojas)
        Me.Panel1.Controls.Add(Me.nDistribuidores)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.backHoja)
        Me.Panel1.Controls.Add(Me.nextHoja)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(51, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 362)
        Me.Panel1.TabIndex = 64
        '
        'psObjeto33
        '
        Me.psObjeto33.AccessibleName = "0"
        Me.psObjeto33.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto33.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto33.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto33.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto33.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto33.Enabled = False
        Me.psObjeto33.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto33.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto33.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto33.Location = New System.Drawing.Point(99, 42)
        Me.psObjeto33.Name = "psObjeto33"
        Me.psObjeto33.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto33.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto33.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto33.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto33.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto33.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto33.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto33.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto33.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto33.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto33.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto33.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto33.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto33.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto33.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto33.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto33.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto33.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto33.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto33.TabIndex = 72
        Me.psObjeto33.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto33.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto33.TextStyle.Text = "No tienes Apuntes, ¡Intenta dar de alta alguno!"
        Me.psObjeto33.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto33.Visible = False
        Me.psObjeto33.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto6
        '
        Me.psObjeto6.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto6.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto6.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto6.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto6.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto6.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto6.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto6.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto6.Location = New System.Drawing.Point(99, 267)
        Me.psObjeto6.Name = "psObjeto6"
        Me.psObjeto6.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto6.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto6.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto6.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto6.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto6.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto6.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto6.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto6.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto6.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto6.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto6.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto6.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto6.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto6.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto6.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto6.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto6.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto6.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto6.TabIndex = 76
        Me.psObjeto6.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto6.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto6.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto6.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto6.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto5
        '
        Me.psObjeto5.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto5.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto5.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto5.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto5.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto5.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto5.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto5.Location = New System.Drawing.Point(99, 221)
        Me.psObjeto5.Name = "psObjeto5"
        Me.psObjeto5.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto5.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto5.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto5.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto5.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto5.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto5.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto5.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto5.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto5.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto5.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto5.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto5.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto5.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto5.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto5.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto5.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto5.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto5.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto5.TabIndex = 75
        Me.psObjeto5.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto5.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto5.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto5.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto5.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto2
        '
        Me.psObjeto2.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto2.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto2.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto2.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto2.Location = New System.Drawing.Point(99, 90)
        Me.psObjeto2.Name = "psObjeto2"
        Me.psObjeto2.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto2.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto2.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto2.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto2.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto2.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto2.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto2.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto2.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto2.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto2.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto2.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto2.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto2.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto2.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto2.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto2.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto2.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto2.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto2.TabIndex = 74
        Me.psObjeto2.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto2.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto2.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto3
        '
        Me.psObjeto3.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto3.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto3.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto3.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto3.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto3.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto3.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto3.Location = New System.Drawing.Point(99, 129)
        Me.psObjeto3.Name = "psObjeto3"
        Me.psObjeto3.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto3.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto3.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto3.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto3.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto3.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto3.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto3.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto3.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto3.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto3.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto3.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto3.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto3.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto3.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto3.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto3.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto3.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto3.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto3.TabIndex = 73
        Me.psObjeto3.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto3.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto3.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto3.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto4
        '
        Me.psObjeto4.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto4.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto4.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto4.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto4.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto4.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto4.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto4.Location = New System.Drawing.Point(99, 175)
        Me.psObjeto4.Name = "psObjeto4"
        Me.psObjeto4.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto4.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto4.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto4.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto4.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto4.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto4.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto4.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto4.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto4.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto4.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto4.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto4.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto4.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto4.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto4.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto4.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto4.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto4.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto4.TabIndex = 72
        Me.psObjeto4.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto4.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto4.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto4.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto4.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'psObjeto1
        '
        Me.psObjeto1.AccessibleDescription = "1"
        Me.psObjeto1.BackgroundStyle.GradientEndColor = System.Drawing.Color.White
        Me.psObjeto1.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.psObjeto1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto1.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.psObjeto1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psObjeto1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.psObjeto1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto1.Location = New System.Drawing.Point(99, 42)
        Me.psObjeto1.Name = "psObjeto1"
        Me.psObjeto1.Size = New System.Drawing.Size(447, 30)
        Me.psObjeto1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.psObjeto1.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto1.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto1.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.psObjeto1.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto1.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto1.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto1.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.psObjeto1.StateStyles.PressedStyle.BackgroundImageFilterColor = System.Drawing.SystemColors.AppWorkspace
        Me.psObjeto1.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.psObjeto1.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto1.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto1.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.psObjeto1.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.Solid
        Me.psObjeto1.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.LightGray
        Me.psObjeto1.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.psObjeto1.TabIndex = 71
        Me.psObjeto1.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.psObjeto1.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.psObjeto1.TextStyle.Text = "LOREM IPSUM"
        Me.psObjeto1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.psObjeto1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'panelHojas
        '
        Me.panelHojas.AutoSize = True
        Me.panelHojas.BackColor = System.Drawing.SystemColors.Control
        Me.panelHojas.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelHojas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelHojas.Location = New System.Drawing.Point(303, 322)
        Me.panelHojas.Name = "panelHojas"
        Me.panelHojas.Size = New System.Drawing.Size(49, 30)
        Me.panelHojas.TabIndex = 56
        Me.panelHojas.Text = "1/1"
        '
        'nDistribuidores
        '
        Me.nDistribuidores.AutoSize = True
        Me.nDistribuidores.BackColor = System.Drawing.SystemColors.Control
        Me.nDistribuidores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nDistribuidores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nDistribuidores.Location = New System.Drawing.Point(460, 330)
        Me.nDistribuidores.Name = "nDistribuidores"
        Me.nDistribuidores.Size = New System.Drawing.Size(152, 22)
        Me.nDistribuidores.TabIndex = 55
        Me.nDistribuidores.Text = "# Distribuidores:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(224, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 28)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Lista de Apuntes"
        '
        'backHoja
        '
        Me.backHoja.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.backHoja.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.backHoja.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backHoja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backHoja.Enabled = False
        Me.backHoja.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.backHoja.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.backHoja.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.backHoja.Location = New System.Drawing.Point(206, 318)
        Me.backHoja.Name = "backHoja"
        Me.backHoja.Size = New System.Drawing.Size(82, 41)
        Me.backHoja.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.backHoja.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.backHoja.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.backHoja.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.backHoja.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.backHoja.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.backHoja.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.backHoja.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.backHoja.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.backHoja.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.backHoja.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.backHoja.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.backHoja.TabIndex = 21
        Me.backHoja.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.backHoja.TextStyle.Text = "←"
        Me.backHoja.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.backHoja.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'nextHoja
        '
        Me.nextHoja.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.nextHoja.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.nextHoja.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nextHoja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextHoja.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.nextHoja.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.nextHoja.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nextHoja.Location = New System.Drawing.Point(363, 318)
        Me.nextHoja.Name = "nextHoja"
        Me.nextHoja.Size = New System.Drawing.Size(82, 41)
        Me.nextHoja.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.nextHoja.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.nextHoja.StateStyles.HoverStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.nextHoja.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.nextHoja.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.nextHoja.StateStyles.HoverStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.nextHoja.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.nextHoja.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nextHoja.StateStyles.PressedStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.LinearGradient
        Me.nextHoja.StateStyles.PressedStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.nextHoja.StateStyles.PressedStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.nextHoja.StateStyles.PressedStyle.BorderPaintType = Klik.Windows.Forms.v1.Common.BorderPaintTypes.LinearGradient
        Me.nextHoja.TabIndex = 22
        Me.nextHoja.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.nextHoja.TextStyle.Text = "→"
        Me.nextHoja.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nextHoja.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(753, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Opciones:"
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
        Me.ElButton4.Location = New System.Drawing.Point(713, 118)
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
        Me.ElButton4.TabIndex = 61
        Me.ElButton4.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton4.TextStyle.Text = "Nuevo Apunte"
        Me.ElButton4.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton4.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(659, 380)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PnlConfirmacion
        '
        Me.PnlConfirmacion.BackColor = System.Drawing.Color.Transparent
        Me.PnlConfirmacion.Controls.Add(Me.LblContenido)
        Me.PnlConfirmacion.Controls.Add(Me.LblTitulo)
        Me.PnlConfirmacion.Controls.Add(Me.LblAutor)
        Me.PnlConfirmacion.Controls.Add(Me.Label14)
        Me.PnlConfirmacion.Controls.Add(Me.LblPermisos)
        Me.PnlConfirmacion.Controls.Add(Me.ElButton8)
        Me.PnlConfirmacion.Controls.Add(Me.Label17)
        Me.PnlConfirmacion.Controls.Add(Me.Label18)
        Me.PnlConfirmacion.Controls.Add(Me.Label21)
        Me.PnlConfirmacion.Controls.Add(Me.ElButton9)
        Me.PnlConfirmacion.Location = New System.Drawing.Point(969, 592)
        Me.PnlConfirmacion.Name = "PnlConfirmacion"
        Me.PnlConfirmacion.Size = New System.Drawing.Size(944, 520)
        Me.PnlConfirmacion.TabIndex = 73
        '
        'LblContenido
        '
        Me.LblContenido.AutoSize = True
        Me.LblContenido.BackColor = System.Drawing.Color.Transparent
        Me.LblContenido.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContenido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblContenido.Location = New System.Drawing.Point(270, 128)
        Me.LblContenido.Name = "LblContenido"
        Me.LblContenido.Size = New System.Drawing.Size(166, 120)
        Me.LblContenido.TabIndex = 75
        Me.LblContenido.Text = "Lorem" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ipsum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Multiline Test" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTitulo.Location = New System.Drawing.Point(270, 91)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(220, 30)
        Me.LblTitulo.TabIndex = 74
        Me.LblTitulo.Text = "Título del apunte:"
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.BackColor = System.Drawing.Color.Transparent
        Me.LblAutor.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblAutor.Location = New System.Drawing.Point(270, 43)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(222, 30)
        Me.LblAutor.TabIndex = 73
        Me.LblAutor.Text = "Autor del Apunte:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(32, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(222, 30)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Autor del Apunte:"
        '
        'LblPermisos
        '
        Me.LblPermisos.AutoSize = True
        Me.LblPermisos.BackColor = System.Drawing.Color.Transparent
        Me.LblPermisos.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPermisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblPermisos.Location = New System.Drawing.Point(44, 405)
        Me.LblPermisos.Name = "LblPermisos"
        Me.LblPermisos.Size = New System.Drawing.Size(612, 30)
        Me.LblPermisos.TabIndex = 71
        Me.LblPermisos.Text = "Solo el Autor Podra editar el contenido del apunte"
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
        Me.ElButton8.Location = New System.Drawing.Point(275, 456)
        Me.ElButton8.Name = "ElButton8"
        Me.ElButton8.Size = New System.Drawing.Size(139, 41)
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
        Me.ElButton8.TabIndex = 69
        Me.ElButton8.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton8.TextStyle.Text = "Corregir"
        Me.ElButton8.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton8.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(32, 125)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(222, 30)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Texto del Apunte:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(31, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(220, 30)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Título del apunte:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(405, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 28)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Nuevo Apunte:"
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
        Me.ElButton9.Location = New System.Drawing.Point(594, 456)
        Me.ElButton9.Name = "ElButton9"
        Me.ElButton9.Size = New System.Drawing.Size(139, 41)
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
        Me.ElButton9.TabIndex = 22
        Me.ElButton9.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton9.TextStyle.Text = "Finalizar"
        Me.ElButton9.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton9.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Comedor_PacificoDataSet
        '
        Me.Comedor_PacificoDataSet.DataSetName = "Comedor_PacificoDataSet"
        Me.Comedor_PacificoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApuntesBindingSource
        '
        Me.ApuntesBindingSource.DataMember = "Apuntes"
        Me.ApuntesBindingSource.DataSource = Me.Comedor_PacificoDataSet
        '
        'ApuntesTableAdapter
        '
        Me.ApuntesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApuntesTableAdapter = Me.ApuntesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        'Apuntes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1047, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlConfirmacion)
        Me.Controls.Add(Me.PnlNuevo)
        Me.Controls.Add(Me.PnlLista)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ElButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(27, 12)
        Me.Name = "Apuntes"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNuevo.ResumeLayout(False)
        Me.PnlNuevo.PerformLayout()
        CType(Me.BtnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLista.ResumeLayout(False)
        Me.PnlLista.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.psObjeto33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psObjeto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backHoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextHoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlConfirmacion.ResumeLayout(False)
        Me.PnlConfirmacion.PerformLayout()
        CType(Me.ElButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApuntesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PnlNuevo As Panel
    Private WithEvents ElButton24 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtTitulo As UIDC.UI_TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Private WithEvents ElButton7 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PnlLista As Panel
    Friend WithEvents Label1 As Label
    Private WithEvents ElButton4 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtContenido As UIDC.UI_TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBoxEditable As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorBox As Label
    Friend WithEvents PnlConfirmacion As Panel
    Friend WithEvents LblPermisos As Label
    Private WithEvents ElButton8 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Private WithEvents ElButton9 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label14 As Label
    Friend WithEvents LblContenido As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblAutor As Label
    Friend WithEvents ApuntesBindingSource As BindingSource
    Friend WithEvents Comedor_PacificoDataSet As Comedor_PacificoDataSet
    Friend WithEvents ApuntesTableAdapter As Comedor_PacificoDataSetTableAdapters.ApuntesTableAdapter
    Friend WithEvents TableAdapterManager As Comedor_PacificoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelHojas As Label
    Friend WithEvents nDistribuidores As Label
    Friend WithEvents Label2 As Label
    Private WithEvents backHoja As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents nextHoja As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents psObjeto6 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto5 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto4 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents BtnEliminar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents psObjeto33 As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
