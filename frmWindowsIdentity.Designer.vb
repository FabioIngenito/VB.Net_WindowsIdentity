<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWindowsIdentity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVerificarDireitos = New System.Windows.Forms.Button()
        Me.tbcWindowsIdentity = New System.Windows.Forms.TabControl()
        Me.tbpGrupo = New System.Windows.Forms.TabPage()
        Me.btnGruposUsuarioAtual = New System.Windows.Forms.Button()
        Me.lbUsuarios = New System.Windows.Forms.ListBox()
        Me.tbpUsuario = New System.Windows.Forms.TabPage()
        Me.btnUsuarioAtual = New System.Windows.Forms.Button()
        Me.txtUsuarioAtual = New System.Windows.Forms.TextBox()
        Me.tbpUsuarioRede = New System.Windows.Forms.TabPage()
        Me.btnUsuarioRede = New System.Windows.Forms.Button()
        Me.txtUsuarioRede = New System.Windows.Forms.TextBox()
        Me.tbcWindowsIdentity.SuspendLayout()
        Me.tbpGrupo.SuspendLayout()
        Me.tbpUsuario.SuspendLayout()
        Me.tbpUsuarioRede.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerificarDireitos
        '
        Me.btnVerificarDireitos.Location = New System.Drawing.Point(12, 468)
        Me.btnVerificarDireitos.Name = "btnVerificarDireitos"
        Me.btnVerificarDireitos.Size = New System.Drawing.Size(189, 23)
        Me.btnVerificarDireitos.TabIndex = 0
        Me.btnVerificarDireitos.Text = "&Verificar Direitos - Check Rights"
        Me.btnVerificarDireitos.UseVisualStyleBackColor = True
        '
        'tbcWindowsIdentity
        '
        Me.tbcWindowsIdentity.Controls.Add(Me.tbpGrupo)
        Me.tbcWindowsIdentity.Controls.Add(Me.tbpUsuario)
        Me.tbcWindowsIdentity.Controls.Add(Me.tbpUsuarioRede)
        Me.tbcWindowsIdentity.Location = New System.Drawing.Point(12, 12)
        Me.tbcWindowsIdentity.Name = "tbcWindowsIdentity"
        Me.tbcWindowsIdentity.SelectedIndex = 0
        Me.tbcWindowsIdentity.Size = New System.Drawing.Size(458, 450)
        Me.tbcWindowsIdentity.TabIndex = 5
        '
        'tbpGrupo
        '
        Me.tbpGrupo.Controls.Add(Me.btnGruposUsuarioAtual)
        Me.tbpGrupo.Controls.Add(Me.lbUsuarios)
        Me.tbpGrupo.Location = New System.Drawing.Point(4, 22)
        Me.tbpGrupo.Name = "tbpGrupo"
        Me.tbpGrupo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGrupo.Size = New System.Drawing.Size(450, 424)
        Me.tbpGrupo.TabIndex = 0
        Me.tbpGrupo.Text = "Grupo - Group"
        Me.tbpGrupo.UseVisualStyleBackColor = True
        '
        'btnGruposUsuarioAtual
        '
        Me.btnGruposUsuarioAtual.Location = New System.Drawing.Point(6, 385)
        Me.btnGruposUsuarioAtual.Name = "btnGruposUsuarioAtual"
        Me.btnGruposUsuarioAtual.Size = New System.Drawing.Size(228, 23)
        Me.btnGruposUsuarioAtual.TabIndex = 8
        Me.btnGruposUsuarioAtual.Text = "&Grupos Usuario Atual - Current User Groups"
        Me.btnGruposUsuarioAtual.UseVisualStyleBackColor = True
        '
        'lbUsuarios
        '
        Me.lbUsuarios.FormattingEnabled = True
        Me.lbUsuarios.Location = New System.Drawing.Point(6, 6)
        Me.lbUsuarios.Name = "lbUsuarios"
        Me.lbUsuarios.Size = New System.Drawing.Size(438, 368)
        Me.lbUsuarios.TabIndex = 3
        '
        'tbpUsuario
        '
        Me.tbpUsuario.Controls.Add(Me.btnUsuarioAtual)
        Me.tbpUsuario.Controls.Add(Me.txtUsuarioAtual)
        Me.tbpUsuario.Location = New System.Drawing.Point(4, 22)
        Me.tbpUsuario.Name = "tbpUsuario"
        Me.tbpUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUsuario.Size = New System.Drawing.Size(450, 424)
        Me.tbpUsuario.TabIndex = 1
        Me.tbpUsuario.Text = "Usuário - User"
        Me.tbpUsuario.UseVisualStyleBackColor = True
        '
        'btnUsuarioAtual
        '
        Me.btnUsuarioAtual.Location = New System.Drawing.Point(6, 365)
        Me.btnUsuarioAtual.Name = "btnUsuarioAtual"
        Me.btnUsuarioAtual.Size = New System.Drawing.Size(179, 23)
        Me.btnUsuarioAtual.TabIndex = 8
        Me.btnUsuarioAtual.Text = "&Usuário Atual - Current User"
        Me.btnUsuarioAtual.UseVisualStyleBackColor = True
        '
        'txtUsuarioAtual
        '
        Me.txtUsuarioAtual.Location = New System.Drawing.Point(3, 6)
        Me.txtUsuarioAtual.Multiline = True
        Me.txtUsuarioAtual.Name = "txtUsuarioAtual"
        Me.txtUsuarioAtual.Size = New System.Drawing.Size(441, 340)
        Me.txtUsuarioAtual.TabIndex = 5
        '
        'tbpUsuarioRede
        '
        Me.tbpUsuarioRede.Controls.Add(Me.btnUsuarioRede)
        Me.tbpUsuarioRede.Controls.Add(Me.txtUsuarioRede)
        Me.tbpUsuarioRede.Location = New System.Drawing.Point(4, 22)
        Me.tbpUsuarioRede.Name = "tbpUsuarioRede"
        Me.tbpUsuarioRede.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUsuarioRede.Size = New System.Drawing.Size(450, 424)
        Me.tbpUsuarioRede.TabIndex = 2
        Me.tbpUsuarioRede.Text = "Usuário Rede - Network User"
        Me.tbpUsuarioRede.UseVisualStyleBackColor = True
        '
        'btnUsuarioRede
        '
        Me.btnUsuarioRede.Location = New System.Drawing.Point(6, 365)
        Me.btnUsuarioRede.Name = "btnUsuarioRede"
        Me.btnUsuarioRede.Size = New System.Drawing.Size(179, 23)
        Me.btnUsuarioRede.TabIndex = 10
        Me.btnUsuarioRede.Text = "Usuário &Rede - Network User"
        Me.btnUsuarioRede.UseVisualStyleBackColor = True
        '
        'txtUsuarioRede
        '
        Me.txtUsuarioRede.Location = New System.Drawing.Point(3, 6)
        Me.txtUsuarioRede.Multiline = True
        Me.txtUsuarioRede.Name = "txtUsuarioRede"
        Me.txtUsuarioRede.Size = New System.Drawing.Size(441, 340)
        Me.txtUsuarioRede.TabIndex = 9
        '
        'frmWindowsIdentity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 499)
        Me.Controls.Add(Me.tbcWindowsIdentity)
        Me.Controls.Add(Me.btnVerificarDireitos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWindowsIdentity"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Windows Identity"
        Me.tbcWindowsIdentity.ResumeLayout(False)
        Me.tbpGrupo.ResumeLayout(False)
        Me.tbpUsuario.ResumeLayout(False)
        Me.tbpUsuario.PerformLayout()
        Me.tbpUsuarioRede.ResumeLayout(False)
        Me.tbpUsuarioRede.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVerificarDireitos As System.Windows.Forms.Button
    Friend WithEvents tbcWindowsIdentity As System.Windows.Forms.TabControl
    Friend WithEvents tbpGrupo As System.Windows.Forms.TabPage
    Friend WithEvents lbUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents tbpUsuario As System.Windows.Forms.TabPage
    Friend WithEvents txtUsuarioAtual As System.Windows.Forms.TextBox
    Friend WithEvents btnGruposUsuarioAtual As System.Windows.Forms.Button
    Friend WithEvents btnUsuarioAtual As System.Windows.Forms.Button
    Friend WithEvents tbpUsuarioRede As System.Windows.Forms.TabPage
    Friend WithEvents btnUsuarioRede As System.Windows.Forms.Button
    Friend WithEvents txtUsuarioRede As System.Windows.Forms.TextBox

End Class
