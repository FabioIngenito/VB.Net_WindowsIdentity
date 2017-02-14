Imports System
Imports System.Security.Principal

''' <summary>
''' http://www.macoratti.net/15/05/net_pers1.htm
''' https://msdn.microsoft.com/pt-br/library/system.security.principal.genericidentity(v=vs.110).aspx
''' https://msdn.microsoft.com/pt-br/library/system.security.principal.genericprincipal(v=vs.110).aspx
''' </summary>
''' <remarks>
''' VB.NET - Usando os recursos do WindowsIdentity - representando usuários
''' VB.NET - Using WindowsIdentity Features - Representing Users
''' </remarks>
Public Class frmWindowsIdentity
    Dim cSeguranca As New clsSeguranca

    Private Sub btnVerificarDireitos_Click(sender As Object, e As EventArgs) Handles btnVerificarDireitos.Click

        Try
            If cSeguranca.IsUserAdministrator() Then
                MessageBox.Show("O usuário atual possui direitos de administrador." + vbCrLf + "The current user has administrator rights.")
            Else
                MessageBox.Show("O usuário atual Não possui direitos de administrador." + vbCrLf + "Current user does Not have administrator rights.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Grupo - Group"

    Private Sub btnGruposUsuarioAtual_Click(sender As Object, e As EventArgs) Handles btnGruposUsuarioAtual.Click
        Dim usuario As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim nome = usuario.Name

        Try
            For Each group In usuario.Groups
                lbUsuarios.Items.Add(group.Translate(GetType(NTAccount)).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

#Region "Usuário - User"
    Private Sub btnUsuarioAtual_Click(sender As Object, e As EventArgs) Handles btnUsuarioAtual.Click

        txtUsuarioAtual.Cursor = Cursors.WaitCursor
        txtUsuarioAtual.Text = ""

        ' Criar um objeto GenericIdentity com nenhum tipo de autenticação especificado.
        ' Create a GenericIdentity object with no specified authentication type.
        Dim defaultIdentity As New GenericIdentity("DefaultUser")

        ' Recuperar uma GenericIdentity criado a partir de valores atuais WindowsIdentity.
        ' Retrieve a GenericIdentity created from current WindowsIdentity values.
        Dim currentIdentity As GenericIdentity = cSeguranca.GetGenericIdentity()

        ShowIdentityPreferences(New GenericIdentity(""))
        ShowIdentityPreferences(defaultIdentity)
        ShowIdentityPreferences(currentIdentity)

        ' Interface de alinhar e concluir aplicação.
        ' Align interface and finish application.
        txtUsuarioAtual.AppendText(vbCrLf + "Esta amostra foi concluída com sucesso." + vbCrLf + "This sample was successfully completed.")

        txtUsuarioAtual.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' Preferências de identidade de impressão.
    ''' Printing identity preferences.
    ''' </summary>
    ''' <param name="genericIdentity"></param>
    Public Sub ShowIdentityPreferences(ByVal genericIdentity As GenericIdentity)

        ' Recuperar o nome do objeto de identidade genérica.
        Dim identityName As String = genericIdentity.Name

        ' Recuperar o tipo de autenticação da identidade de objeto genérico.
        Dim identityAuthenticationType As String
        identityAuthenticationType = genericIdentity.AuthenticationType()

        txtUsuarioAtual.AppendText(vbCrLf + "Nome - Name: " + identityName)
        txtUsuarioAtual.AppendText(vbCrLf + "Tipo - Type: " + identityAuthenticationType)

        txtUsuarioAtual.AppendText(vbCrLf)

        ' Verifique se a identidade do usuário foi autenticada
        ' (foi criado com um nome válido).
        If (genericIdentity.IsAuthenticated) Then
            txtUsuarioAtual.AppendText("A identidade do usuário foi autenticada." + vbCrLf + "The user's identity has been authenticated.")
        Else
            txtUsuarioAtual.AppendText("A identidade do usuário NÃO foi autenticada." + vbCrLf + "The user's identity was NOT authenticated.")
        End If

        txtUsuarioAtual.AppendText(vbCrLf + "~~~~~~~~~~~~~~~~~~~~~~~~~")
    End Sub

#End Region

#Region "Usuário Rede - Network User"
    Private Sub btnUsuarioRede_Click(sender As Object, e As EventArgs) Handles btnUsuarioRede.Click
        txtUsuarioRede.Cursor = Cursors.WaitCursor
        txtUsuarioRede.Text = ""

        ' Recuperar uma GenericPrincipal que é baseada no utilizador corrente
        ' WindowsIdentity.
        Dim genericPrincipal As GenericPrincipal = cSeguranca.GetGenericPrincipal()

        ' Recuperar a identidade genérica do objeto GenericPrincipal.
        Dim principalIdentity As GenericIdentity = _
            CType(genericPrincipal.Identity, GenericIdentity)

        ' Exibição nome de identidade e tipo de autenticação.
        If (principalIdentity.IsAuthenticated) Then
            txtUsuarioRede.AppendText("Nome - Name: " + principalIdentity.Name + vbCrLf)
            txtUsuarioRede.AppendText("Tipo - Type:" + principalIdentity.AuthenticationType + vbCrLf)
        End If

        ' Verifique se o genérico principal foi atribuído a
        ' regra NetworkUser.
        If (genericPrincipal.IsInRole("NetworkUser")) Then
            txtUsuarioRede.AppendText("Usuário pertence à função NetworkUser." + vbCrLf + "User belongs to the NetworkUser role." + vbCrLf)
        End If

        txtUsuarioRede.AppendText("Esta amostra foi concluída com sucesso." + vbCrLf + "This sample was successfully completed." + vbCrLf)
        txtUsuarioRede.Cursor = Cursors.Default
    End Sub

#End Region

End Class
