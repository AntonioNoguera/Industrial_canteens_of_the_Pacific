<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ElButton3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton5 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.AlertaTexto = New System.Windows.Forms.Label()
        Me.txtUsuario = New UIDC.UI_TextBox()
        Me.txtContrasena = New UIDC.UI_TextBox()
        Me.Comedor_PacificoDataSet = New ProyectoPOO.Comedor_PacificoDataSet()
        Me.UsuariosComedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosComedorTableAdapter = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.UsuariosComedorTableAdapter()
        Me.TableAdapterManager = New ProyectoPOO.Comedor_PacificoDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosComedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(91, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(136, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(114, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña:"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 100
        Me.BunifuElipse2.TargetControl = Me
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
        Me.ElButton3.Location = New System.Drawing.Point(306, 377)
        Me.ElButton3.Name = "ElButton3"
        Me.ElButton3.Size = New System.Drawing.Size(41, 41)
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
        Me.ElButton3.TabIndex = 11
        Me.ElButton3.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton3.TextStyle.Text = "Ver"
        Me.ElButton3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.ElButton1.Location = New System.Drawing.Point(30, 458)
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
        Me.ElButton1.TabIndex = 12
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton1.TextStyle.Text = "Crear Nueva Cuenta"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.ElButton2.Location = New System.Drawing.Point(246, 458)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(101, 41)
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
        Me.ElButton2.TabIndex = 13
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ElButton2.TextStyle.Text = "Ingresar"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.ElButton5.Location = New System.Drawing.Point(297, 27)
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
        Me.ElButton5.TabIndex = 15
        Me.ElButton5.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.ElButton5.TextStyle.ForeColor = System.Drawing.Color.IndianRed
        Me.ElButton5.TextStyle.Text = "×"
        Me.ElButton5.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'AlertaTexto
        '
        Me.AlertaTexto.AutoSize = True
        Me.AlertaTexto.BackColor = System.Drawing.Color.Transparent
        Me.AlertaTexto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertaTexto.ForeColor = System.Drawing.Color.Red
        Me.AlertaTexto.Location = New System.Drawing.Point(97, 428)
        Me.AlertaTexto.Name = "AlertaTexto"
        Me.AlertaTexto.Size = New System.Drawing.Size(0, 16)
        Me.AlertaTexto.TabIndex = 17
        Me.AlertaTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtUsuario.BackgroundColour = System.Drawing.Color.White
        Me.txtUsuario.BorderColour = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtUsuario.BorderSize = 2
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsuario.Location = New System.Drawing.Point(30, 285)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Multiline = False
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = False
        Me.txtUsuario.Size = New System.Drawing.Size(317, 45)
        Me.txtUsuario.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtUsuario.TabIndex = 18
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsuario.TextColour = System.Drawing.Color.Black
        Me.txtUsuario.UseSystemPasswordChar = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.Transparent
        Me.txtContrasena.BackgroundColour = System.Drawing.Color.White
        Me.txtContrasena.BorderColour = System.Drawing.Color.DimGray
        Me.txtContrasena.BorderSize = 2
        Me.txtContrasena.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContrasena.Location = New System.Drawing.Point(30, 377)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Multiline = False
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.ReadOnly = False
        Me.txtContrasena.Size = New System.Drawing.Size(267, 45)
        Me.txtContrasena.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded
        Me.txtContrasena.TabIndex = 19
        Me.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContrasena.TextColour = System.Drawing.Color.Black
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'Comedor_PacificoDataSet
        '
        Me.Comedor_PacificoDataSet.DataSetName = "Comedor_PacificoDataSet"
        Me.Comedor_PacificoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosComedorBindingSource
        '
        Me.UsuariosComedorBindingSource.DataMember = "UsuariosComedor"
        Me.UsuariosComedorBindingSource.DataSource = Me.Comedor_PacificoDataSet
        '
        'UsuariosComedorTableAdapter
        '
        Me.UsuariosComedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApuntesTableAdapter = Nothing
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
        Me.TableAdapterManager.UsuariosComedorTableAdapter = Me.UsuariosComedorTableAdapter
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(378, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.AlertaTexto)
        Me.Controls.Add(Me.ElButton5)
        Me.Controls.Add(Me.ElButton2)
        Me.Controls.Add(Me.ElButton1)
        Me.Controls.Add(Me.ElButton3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioSesion"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comedor_PacificoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosComedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents ElButton3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Private WithEvents ElButton5 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents AlertaTexto As Label
    Friend WithEvents txtUsuario As UIDC.UI_TextBox
    Friend WithEvents txtContrasena As UIDC.UI_TextBox
    Friend WithEvents UsuariosComedorBindingSource As BindingSource
    Friend WithEvents Comedor_PacificoDataSet As Comedor_PacificoDataSet
    Friend WithEvents UsuariosComedorTableAdapter As Comedor_PacificoDataSetTableAdapters.UsuariosComedorTableAdapter
    Friend WithEvents TableAdapterManager As Comedor_PacificoDataSetTableAdapters.TableAdapterManager
End Class
