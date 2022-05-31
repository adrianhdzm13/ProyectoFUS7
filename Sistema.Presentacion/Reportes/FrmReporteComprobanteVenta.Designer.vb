<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteComprobanteVenta
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.venta_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSistema = New Sistema.Presentacion.DsSistema()
        Me.venta_comprobanteTableAdapter = New Sistema.Presentacion.DsSistemaTableAdapters.venta_comprobanteTableAdapter()
        CType(Me.venta_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsComprobanteVenta"
        ReportDataSource1.Value = Me.venta_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.RptComprobanteVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1028, 609)
        Me.ReportViewer1.TabIndex = 1
        '
        'venta_comprobanteBindingSource
        '
        Me.venta_comprobanteBindingSource.DataMember = "venta_comprobante"
        Me.venta_comprobanteBindingSource.DataSource = Me.DsSistema
        '
        'DsSistema
        '
        Me.DsSistema.DataSetName = "DsSistema"
        Me.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_comprobanteTableAdapter
        '
        Me.venta_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteComprobanteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteComprobanteVenta"
        Me.Text = "Comprobante Venta"
        CType(Me.venta_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_comprobanteBindingSource As BindingSource
    Friend WithEvents DsSistema As DsSistema
    Friend WithEvents venta_comprobanteTableAdapter As DsSistemaTableAdapters.venta_comprobanteTableAdapter
End Class
