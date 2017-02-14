Imports System.Security.Principal

Public Class clsSeguranca

    ''' <summary>
    ''' Obtém o usuário atual logado
    ''' Gets the current logged-on user
    ''' </summary>
    ''' <returns>isAdmin</returns>
    ''' <remarks>http://www.macoratti.net/15/05/net_pers1.htm</remarks>
    Public Function IsUserAdministrator() As Boolean
        Dim isAdmin As Boolean

        Try
            Dim user As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim principal As New WindowsPrincipal(user)
            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As UnauthorizedAccessException
            isAdmin = False
        Catch ex As Exception
            isAdmin = False
        End Try

        Return isAdmin
    End Function

    ''' <summary>
    ''' Use valores atuais da WindowsIdentity para construir um conjunto de funções GenericPrincipal.
    ''' Use current WindowsIdentity values to construct a GenericPrincipal function set.
    ''' </summary>
    ''' <returns>New GenericPrincipal(genericIdentity, roles)</returns>
    ''' <remarks>https://msdn.microsoft.com/pt-br/library/system.security.principal.genericprincipal(v=vs.110).aspx</remarks>
    Public Function GetGenericPrincipal() As GenericPrincipal
        Dim roles(10) As String
        Dim windowsIdentity As WindowsIdentity = windowsIdentity.GetCurrent()

        If (windowsIdentity.IsAuthenticated) Then
            ' Adicionar função NetworkUser personalizada.
            ' Add custom NetworkUser role.
            roles(0) = "NetworkUser"
        End If

        If (windowsIdentity.IsGuest) Then
            ' Adicionar função GuestUser personalizada.
            ' Add custom GuestUser function.
            roles(1) = "GuestUser"
        End If


        If (windowsIdentity.IsSystem) Then
            ' Adicionar função SystemUser personalizada.
            ' Add custom SystemUser function.
            roles(2) = "SystemUser"
        End If

        ' Construct a GenericIdentity object based on the current Windows
        ' identity name and authentication type.
        Dim authenticationType As String = windowsIdentity.AuthenticationType
        Dim userName As String = windowsIdentity.Name
        Dim genericIdentity = _
            New GenericIdentity(userName, authenticationType)

        ' Construct a GenericPrincipal object based on the generic identity
        ' and custom roles for the user.
        Dim genericPrincipal As New GenericPrincipal(genericIdentity, roles)

        Return genericPrincipal
    End Function

    ''' <summary>
    ''' Criar identidade genérica com base em valores a partir do atual WindowsIdentity.
    ''' Create generic identity based values from the current WindowsIdentity.
    ''' </summary>
    ''' <returns>New GenericIdentity(userName, authenticationType)</returns>
    ''' <remarks>https://msdn.microsoft.com/pt-br/library/system.security.principal.genericidentity(v=vs.110).aspx</remarks>
    Public Function GetGenericIdentity()
        ' Obter valores da WindowsIdentity atual.
        ' Get values from the current WindowsIdentity.
        Dim windowsIdentity As WindowsIdentity = windowsIdentity.GetCurrent()

        ' Construir um objeto GenericIdentity baseado no Windows atual
        ' Building a GenericIdentity Object Based on Current Windows
        ' Nome de identidade e tipo de autenticação.
        ' identity name and authentication type.
        Dim authenticationType As String = windowsIdentity.AuthenticationType
        Dim userName As String = windowsIdentity.Name
        Dim authenticatedGenericIdentity As _
            New GenericIdentity(userName, authenticationType)

        Return authenticatedGenericIdentity
    End Function

End Class
