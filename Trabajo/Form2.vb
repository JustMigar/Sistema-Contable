Public Class frmLogin


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim password_ingresada As Integer

        If IsNumeric(txtUsuario.Text) Then

            MessageBox.Show("Usuario invalido." & Environment.NewLine & "(No debe contener numeros).")
            Return
        End If

        If Not (Integer.TryParse(txtPassword.Text, password_ingresada)) Then
            MessageBox.Show("Debe ingresar numeros solamente.")
            Return
        End If


        ' 3. Buscar si el texto ingresado coincide con un usuario de tu "ModuloSeguridad.ListaUsuarios"
        Dim usuarioEncontrado As Usuario = Nothing
        For Each u As Usuario In ModuloSeguridad.ListaUsuarios
            ' Comparamos ignorando mayúsculas/minúsculas para evitar errores de tipeo
            If u.Nombre.Equals(txtUsuario.Text, StringComparison.OrdinalIgnoreCase) Then
                usuarioEncontrado = u
                Exit For
            End If
        Next

        ' 4. Si el bucle terminó y no encontró coincidencias
        If usuarioEncontrado Is Nothing Then
            MessageBox.Show("El usuario no coincide.")
            Return
        End If

        ' 5. Si el usuario existe, validamos su contraseña correspondiente
        If Not (password_ingresada = usuarioEncontrado.Password) Then
            MessageBox.Show("La contrasenia no coincide.")
            Return
        End If

        ModuloSeguridad.UsuarioLogueado = usuarioEncontrado
        ModuloUsuario.RolUsuarioActual = usuarioEncontrado.Rol

        Me.Close()

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MOVE As Integer = &HF010

        If m.Msg = WM_SYSCOMMAND AndAlso (m.WParam.ToInt32() And &HFFF0) = SC_MOVE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        MessageBox.Show("Esta funcion se implementara mas adelante.")
    End Sub
End Class