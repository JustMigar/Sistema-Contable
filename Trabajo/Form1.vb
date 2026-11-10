Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mnuPrincipal.Enabled = False
        Dim hijo As New frmLogin


        AddHandler hijo.FormClosed, AddressOf AlCerrarLogin
        hijo.ShowDialog()

    End Sub

    Private Sub AlCerrarLogin(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' permisos del rol que acaba de iniciar sesión
        AplicarPermisosMenu(ModuloUsuario.RolUsuarioActual)

        ' Activa el menú principal del sistema
        mnuPrincipal.Enabled = True
    End Sub



    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click

        For i As Integer = Me.MdiChildren.Length - 1 To 0 Step -1
            Me.MdiChildren(i).Close()
        Next


        mnuPrincipal.Enabled = False
        ModuloUsuario.RolUsuarioActual = ""
        ModuloSeguridad.UsuarioLogueado = Nothing

        AplicarPermisosMenu("")

        Dim hijo As New frmLogin
        AddHandler hijo.FormClosed, AddressOf AlCerrarLogin
        hijo.ShowDialog()
    End Sub

    Private Sub AplicarPermisosMenu(ByVal rol As String)

        Select Case rol

            Case "Admin"
                ' El Administrador puede ver y hacer absolutamente todo
                InmuebleToolStripMenuItem.Visible = True
                ReporteToolStripMenuItem.Visible = True

                ' reactiva los submenús por si el usuario anterior los bloqueó
                AgregarToolStripMenuItem.Enabled = True
                EditarToolStripMenuItem.Enabled = True

            Case "Analista"
                ' sean visibles en pantalla
                InmuebleToolStripMenuItem.Visible = True
                ReporteToolStripMenuItem.Visible = True

                InmuebleToolStripMenuItem.Enabled = True
                ReporteToolStripMenuItem.Enabled = True
                AgregarToolStripMenuItem.Enabled = False
                EditarToolStripMenuItem.Enabled = False

            Case "Contador"
                ' El usuario comun o de consulta ve los inmuebles, pero no ve Reportes
                InmuebleToolStripMenuItem.Visible = True
                ReporteToolStripMenuItem.Visible = False

                AgregarToolStripMenuItem.Enabled = False
                EditarToolStripMenuItem.Enabled = False

            Case ""
                ' Al cerrar sesión, ocultamos todo de forma limpia
                InmuebleToolStripMenuItem.Visible = False
                ReporteToolStripMenuItem.Visible = False

            Case Else
                ' Por seguridad, si el rol no se reconoce, se bloquea el sistema
                InmuebleToolStripMenuItem.Visible = False
                ReporteToolStripMenuItem.Visible = False
                MessageBox.Show("Acceso denegado. Rol de usuario no válido.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
        End Select
    End Sub

End Class