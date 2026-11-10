
Public Class Usuario
    Public Property Nombre As String
    Public Property Password As Integer
    Public Property Rol As String

    Public Sub New(ByVal nom As String, ByVal pass As Integer, ByVal rl As String)
        Nombre = nom
        Password = pass
        Rol = rl
    End Sub
End Class

Public Module ModuloSeguridad

    Public UsuarioLogueado As Usuario = Nothing

    Public ListaUsuarios As New List(Of Usuario) From {
        New Usuario("Admin", 1234, "Admin"),
        New Usuario("Analista", 5555, "Analista"),
        New Usuario("Contador", 9999, "Contador")
    }
End Module

