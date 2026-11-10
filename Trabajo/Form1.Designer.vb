<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.InmuebleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProximoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InmuebleToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(919, 24)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'InmuebleToolStripMenuItem
        '
        Me.InmuebleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProxToolStripMenuItem, Me.CatalogoToolStripMenuItem, Me.AsientosToolStripMenuItem})
        Me.InmuebleToolStripMenuItem.Name = "InmuebleToolStripMenuItem"
        Me.InmuebleToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.InmuebleToolStripMenuItem.Text = "Proximamente"
        '
        'ProxToolStripMenuItem
        '
        Me.ProxToolStripMenuItem.Name = "ProxToolStripMenuItem"
        Me.ProxToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProxToolStripMenuItem.Text = "&Proximamente"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CatalogoToolStripMenuItem.Text = "&Proximamente"
        '
        'AsientosToolStripMenuItem
        '
        Me.AsientosToolStripMenuItem.Name = "AsientosToolStripMenuItem"
        Me.AsientosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsientosToolStripMenuItem.Text = "&Asientos Contables"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProximoToolStripMenuItem, Me.VerReportesToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ReporteToolStripMenuItem.Text = "Proximamente"
        '
        'ProximoToolStripMenuItem
        '
        Me.ProximoToolStripMenuItem.Name = "ProximoToolStripMenuItem"
        Me.ProximoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProximoToolStripMenuItem.Text = "Proximamente"
        '
        'VerReportesToolStripMenuItem
        '
        Me.VerReportesToolStripMenuItem.Name = "VerReportesToolStripMenuItem"
        Me.VerReportesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerReportesToolStripMenuItem.Text = "Ver reportes"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 576)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Contable"
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents InmuebleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProximoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
