<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MnuAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuIngresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAcceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TsBarraInferior = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TsVentas = New System.Windows.Forms.ToolStripButton()
        Me.TsCompras = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAlmacen, Me.MnuIngresos, Me.MnuVentas, Me.MnuAcceso, Me.MnuConsultas, Me.MnuSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(763, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MnuAlmacen
        '
        Me.MnuAlmacen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoríasToolStripMenuItem, Me.ArtículosToolStripMenuItem})
        Me.MnuAlmacen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuAlmacen.ForeColor = System.Drawing.Color.Black
        Me.MnuAlmacen.Name = "MnuAlmacen"
        Me.MnuAlmacen.Size = New System.Drawing.Size(94, 23)
        Me.MnuAlmacen.Text = "Almacén"
        '
        'CategoríasToolStripMenuItem
        '
        Me.CategoríasToolStripMenuItem.Name = "CategoríasToolStripMenuItem"
        Me.CategoríasToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.CategoríasToolStripMenuItem.Text = "Cate&gorias"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ArtículosToolStripMenuItem.Text = "&Artículos"
        '
        'MnuIngresos
        '
        Me.MnuIngresos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MnuIngresos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuIngresos.ForeColor = System.Drawing.Color.Black
        Me.MnuIngresos.Name = "MnuIngresos"
        Me.MnuIngresos.Size = New System.Drawing.Size(83, 23)
        Me.MnuIngresos.Text = "Ingresos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ProveedoresToolStripMenuItem.Text = "&Proveedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ComprasToolStripMenuItem.Text = "&Compras"
        '
        'MnuVentas
        '
        Me.MnuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem1})
        Me.MnuVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuVentas.ForeColor = System.Drawing.Color.Black
        Me.MnuVentas.Name = "MnuVentas"
        Me.MnuVentas.Size = New System.Drawing.Size(73, 23)
        Me.MnuVentas.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.ClientesToolStripMenuItem.Text = "Clien&tes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(138, 24)
        Me.VentasToolStripMenuItem1.Text = "&Ventas"
        '
        'MnuAcceso
        '
        Me.MnuAcceso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MnuAcceso.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuAcceso.ForeColor = System.Drawing.Color.Black
        Me.MnuAcceso.Name = "MnuAcceso"
        Me.MnuAcceso.Size = New System.Drawing.Size(79, 23)
        Me.MnuAcceso.Text = "Acceso"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.RolesToolStripMenuItem.Text = "&Roles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'MnuConsultas
        '
        Me.MnuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaVentasToolStripMenuItem})
        Me.MnuConsultas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuConsultas.ForeColor = System.Drawing.Color.Black
        Me.MnuConsultas.Name = "MnuConsultas"
        Me.MnuConsultas.Size = New System.Drawing.Size(94, 23)
        Me.MnuConsultas.Text = "Consultas"
        '
        'ConsultaVentasToolStripMenuItem
        '
        Me.ConsultaVentasToolStripMenuItem.Name = "ConsultaVentasToolStripMenuItem"
        Me.ConsultaVentasToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.ConsultaVentasToolStripMenuItem.Text = "Consulta Ventas"
        '
        'MnuSalir
        '
        Me.MnuSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuSalir.ForeColor = System.Drawing.Color.Black
        Me.MnuSalir.ImageTransparentColor = System.Drawing.Color.Cyan
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.Size = New System.Drawing.Size(53, 23)
        Me.MnuSalir.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsBarraInferior})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(763, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'TsBarraInferior
        '
        Me.TsBarraInferior.Name = "TsBarraInferior"
        Me.TsBarraInferior.Size = New System.Drawing.Size(282, 17)
        Me.TsBarraInferior.Text = "Desarrollado por: https://github.com/adrianhdzm13"
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsVentas, Me.TsCompras})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(763, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sistema.Presentacion.My.Resources.Resources.a3332ecc83a344ffa67d4fd067f7bf8b_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(763, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TsVentas
        '
        Me.TsVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsVentas.Image = CType(resources.GetObject("TsVentas.Image"), System.Drawing.Image)
        Me.TsVentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsVentas.Name = "TsVentas"
        Me.TsVentas.Size = New System.Drawing.Size(23, 22)
        Me.TsVentas.Text = "ToolStripButton1"
        Me.TsVentas.ToolTipText = "Ventas"
        '
        'TsCompras
        '
        Me.TsCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsCompras.Image = CType(resources.GetObject("TsCompras.Image"), System.Drawing.Image)
        Me.TsCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsCompras.Name = "TsCompras"
        Me.TsCompras.Size = New System.Drawing.Size(23, 22)
        Me.TsCompras.Text = "ToolStripButton1"
        Me.TsCompras.ToolTipText = "Compras"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema Compras - Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TsBarraInferior As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuAlmacen As ToolStripMenuItem
    Friend WithEvents CategoríasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuIngresos As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuVentas As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MnuAcceso As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuConsultas As ToolStripMenuItem
    Friend WithEvents ConsultaVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents TsVentas As ToolStripButton
    Friend WithEvents TsCompras As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
