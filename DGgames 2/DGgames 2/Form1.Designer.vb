<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btn_confirmar = New Button()
        lbl_nome = New Label()
        lbl_senha = New Label()
        txt_nome_login = New TextBox()
        txt_senha_login = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.BackColor = Color.Cyan
        btn_confirmar.ForeColor = SystemColors.ActiveCaptionText
        btn_confirmar.Location = New Point(191, 212)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(253, 62)
        btn_confirmar.TabIndex = 0
        btn_confirmar.Text = "CONFIRMAR"
        btn_confirmar.UseVisualStyleBackColor = False
        ' 
        ' lbl_nome
        ' 
        lbl_nome.AutoSize = True
        lbl_nome.BackColor = Color.Transparent
        lbl_nome.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_nome.ForeColor = Color.Fuchsia
        lbl_nome.Location = New Point(191, 86)
        lbl_nome.Name = "lbl_nome"
        lbl_nome.Size = New Size(42, 15)
        lbl_nome.TabIndex = 1
        lbl_nome.Text = "NOME"
        ' 
        ' lbl_senha
        ' 
        lbl_senha.AutoSize = True
        lbl_senha.BackColor = Color.Transparent
        lbl_senha.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_senha.ForeColor = Color.Fuchsia
        lbl_senha.Location = New Point(191, 150)
        lbl_senha.Name = "lbl_senha"
        lbl_senha.Size = New Size(46, 15)
        lbl_senha.TabIndex = 2
        lbl_senha.Text = "SENHA"
        ' 
        ' txt_nome_login
        ' 
        txt_nome_login.Location = New Point(191, 104)
        txt_nome_login.Name = "txt_nome_login"
        txt_nome_login.Size = New Size(253, 23)
        txt_nome_login.TabIndex = 3
        ' 
        ' txt_senha_login
        ' 
        txt_senha_login.Location = New Point(191, 168)
        txt_senha_login.Name = "txt_senha_login"
        txt_senha_login.PasswordChar = "*"c
        txt_senha_login.Size = New Size(253, 23)
        txt_senha_login.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Felix Titling", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Fuchsia
        Label1.Location = New Point(249, 14)
        Label1.Margin = New Padding(3, 5, 3, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 28)
        Label1.TabIndex = 5
        Label1.Text = "DG GAMES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Felix Titling", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Fuchsia
        Label2.Location = New Point(173, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 24)
        Label2.TabIndex = 6
        Label2.Text = "A MELHOR LOJA DE GAMES"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(607, 300)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_senha_login)
        Controls.Add(txt_nome_login)
        Controls.Add(lbl_senha)
        Controls.Add(lbl_nome)
        Controls.Add(btn_confirmar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        WindowState = FormWindowState.Minimized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_confirmar As Button
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_nome_login As TextBox
    Friend WithEvents txt_senha_login As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
