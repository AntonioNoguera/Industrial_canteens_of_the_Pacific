<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearNuevoUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElButton5 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New UIDC.UI_TextBox()
        Me.txtApellidos = New UIDC.UI_TextBox()
        Me.txtTelefono = New UIDC.UI_TextBox()
        Me.txtRol = New UIDC.UI_TextBox()
        Me.txtContrasena = New UIDC.UI_TextBox()
        Me.txtOtraContra = New UIDC.UI_TextBox()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(215, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre(s):"
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
        Me.ElButton2.Location = New System.Drawing.Point(302, 550)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(269, 41)
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
        Me.ElButton2.TabIndex = 14
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton2.TextStyle.Text = "Volver a Inicio de Sesión"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.ElButton1.Location = New System.Drawing.Point(625, 550)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(158, 41)
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
        Me.ElButton1.TabIndex = 15
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton1.TextStyle.Text = "Crear Cuenta"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(305, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(502, 58)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Crear Nuevo Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(200, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(230, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellidos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(235, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 30)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(222, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Rol (Área):"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'ElButton5
        '
        Me.ElButton5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ElButton5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElButton5.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElButton5.BorderStyle.EdgeRadius = 100
        Me.ElButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElButton5.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton5.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton5.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.Location = New System.Drawing.Point(938, 32)
        Me.ElButton5.Name = "ElButton5"
        Me.ElButton5.Size = New System.Drawing.Size(50, 28)
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
        Me.ElButton5.TabIndex = 17
        Me.ElButton5.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.ElButton5.TextStyle.ForeColor = System.Drawing.Color.IndianRed
        Me.ElButton5.TextStyle.Text = "×"
        Me.ElButton5.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(109, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 30)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Repetir Contraseña:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.BackgroundColour = System.Drawing.Color.White
        Me.txtNombre.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtNombre.BorderSize = 2
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(384, 129)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Multiline = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = False
        Me.txtNombre.Size = New System.Drawing.Size(539, 45)
        Me.txtNombre.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNombre.TextColour = System.Drawing.Color.Black
        Me.txtNombre.UseSystemPasswordChar = False
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.Transparent
        Me.txtApellidos.BackgroundColour = System.Drawing.Color.White
        Me.txtApellidos.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtApellidos.BorderSize = 2
        Me.txtApellidos.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtApellidos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtApellidos.Location = New System.Drawing.Point(384, 189)
        Me.txtApellidos.MaxLength = 32767
        Me.txtApellidos.Multiline = False
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.ReadOnly = False
        Me.txtApellidos.Size = New System.Drawing.Size(539, 45)
        Me.txtApellidos.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtApellidos.TabIndex = 21
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtApellidos.TextColour = System.Drawing.Color.Black
        Me.txtApellidos.UseSystemPasswordChar = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefono.BackgroundColour = System.Drawing.Color.White
        Me.txtTelefono.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtTelefono.BorderSize = 2
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono.Location = New System.Drawing.Point(384, 256)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Multiline = False
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = False
        Me.txtTelefono.Size = New System.Drawing.Size(539, 45)
        Me.txtTelefono.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtTelefono.TabIndex = 22
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTelefono.TextColour = System.Drawing.Color.Black
        Me.txtTelefono.UseSystemPasswordChar = False
        '
        'txtRol
        '
        Me.txtRol.BackColor = System.Drawing.Color.Transparent
        Me.txtRol.BackgroundColour = System.Drawing.Color.White
        Me.txtRol.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtRol.BorderSize = 2
        Me.txtRol.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtRol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRol.Location = New System.Drawing.Point(384, 319)
        Me.txtRol.MaxLength = 32767
        Me.txtRol.Multiline = False
        Me.txtRol.Name = "txtRol"
        Me.txtRol.ReadOnly = False
        Me.txtRol.Size = New System.Drawing.Size(539, 45)
        Me.txtRol.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtRol.TabIndex = 23
        Me.txtRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRol.TextColour = System.Drawing.Color.Black
        Me.txtRol.UseSystemPasswordChar = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.Transparent
        Me.txtContrasena.BackgroundColour = System.Drawing.Color.White
        Me.txtContrasena.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtContrasena.BorderSize = 2
        Me.txtContrasena.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContrasena.Location = New System.Drawing.Point(384, 376)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Multiline = False
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.ReadOnly = False
        Me.txtContrasena.Size = New System.Drawing.Size(539, 45)
        Me.txtContrasena.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtContrasena.TabIndex = 24
        Me.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContrasena.TextColour = System.Drawing.Color.Black
        Me.txtContrasena.UseSystemPasswordChar = False
        '
        'txtOtraContra
        '
        Me.txtOtraContra.BackColor = System.Drawing.Color.Transparent
        Me.txtOtraContra.BackgroundColour = System.Drawing.Color.White
        Me.txtOtraContra.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtOtraContra.BorderSize = 2
        Me.txtOtraContra.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtOtraContra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOtraContra.Location = New System.Drawing.Point(384, 430)
        Me.txtOtraContra.MaxLength = 32767
        Me.txtOtraContra.Multiline = False
        Me.txtOtraContra.Name = "txtOtraContra"
        Me.txtOtraContra.ReadOnly = False
        Me.txtOtraContra.Size = New System.Drawing.Size(539, 45)
        Me.txtOtraContra.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtOtraContra.TabIndex = 25
        Me.txtOtraContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOtraContra.TextColour = System.Drawing.Color.Black
        Me.txtOtraContra.UseSystemPasswordChar = False
        '
        'CrearNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1049, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtOtraContra)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ElButton5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ElButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ElButton2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrearNuevoUsuario"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Private WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents ElButton5 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOtraContra As UIDC.UI_TextBox
    Friend WithEvents txtContrasena As UIDC.UI_TextBox
    Friend WithEvents txtRol As UIDC.UI_TextBox
    Friend WithEvents txtTelefono As UIDC.UI_TextBox
    Friend WithEvents txtApellidos As UIDC.UI_TextBox
    Friend WithEvents txtNombre As UIDC.UI_TextBox
End Class
