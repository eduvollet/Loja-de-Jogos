<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastrar_funcionario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_cadastrar_funcionario))
        txt_endereco_funcionario = New TextBox()
        Button1 = New Button()
        txt_email_funcionario = New TextBox()
        Label6 = New Label()
        txt_nome_funcionario = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txt_celular_funcionario = New MaskedTextBox()
        Label2 = New Label()
        txt_login_funcionario = New TextBox()
        Label1 = New Label()
        Label7 = New Label()
        txt_senha_funcionario = New TextBox()
        Button2 = New Button()
        pb_funcionario = New PictureBox()
        Label8 = New Label()
        txt_cpf_funcionario = New MaskedTextBox()
        txt_complemento_funcionario = New TextBox()
        Label9 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        CType(pb_funcionario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_endereco_funcionario
        ' 
        txt_endereco_funcionario.Location = New Point(12, 202)
        txt_endereco_funcionario.Name = "txt_endereco_funcionario"
        txt_endereco_funcionario.Size = New Size(365, 23)
        txt_endereco_funcionario.TabIndex = 45
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(12, 316)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 73)
        Button1.TabIndex = 44
        Button1.Text = "VOLTAR AO MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_email_funcionario
        ' 
        txt_email_funcionario.Location = New Point(12, 36)
        txt_email_funcionario.Name = "txt_email_funcionario"
        txt_email_funcionario.Size = New Size(365, 23)
        txt_email_funcionario.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(12, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 15)
        Label6.TabIndex = 42
        Label6.Text = "NOME DO FUNCIONÁRIO"
        ' 
        ' txt_nome_funcionario
        ' 
        txt_nome_funcionario.Location = New Point(12, 89)
        txt_nome_funcionario.Name = "txt_nome_funcionario"
        txt_nome_funcionario.Size = New Size(365, 23)
        txt_nome_funcionario.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Cyan
        Label5.Location = New Point(12, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 40
        Label5.Text = "CPF"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Cyan
        Label4.Location = New Point(12, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 39
        Label4.Text = "ENDEREÇO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Cyan
        Label3.Location = New Point(12, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 15)
        Label3.TabIndex = 38
        Label3.Text = "E-MAIL DO FUNCIONÁRIO"
        ' 
        ' txt_celular_funcionario
        ' 
        txt_celular_funcionario.Location = New Point(203, 149)
        txt_celular_funcionario.Mask = "(00) 00000-0000"
        txt_celular_funcionario.Name = "txt_celular_funcionario"
        txt_celular_funcionario.Size = New Size(174, 23)
        txt_celular_funcionario.TabIndex = 48
        txt_celular_funcionario.ValidatingType = GetType(Date)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(203, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 47
        Label2.Text = "CELULAR"
        ' 
        ' txt_login_funcionario
        ' 
        txt_login_funcionario.Location = New Point(431, 277)
        txt_login_funcionario.Name = "txt_login_funcionario"
        txt_login_funcionario.Size = New Size(252, 23)
        txt_login_funcionario.TabIndex = 49
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(431, 259)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 50
        Label1.Text = "LOGIN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.Cyan
        Label7.Location = New Point(431, 312)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 15)
        Label7.TabIndex = 52
        Label7.Text = "SENHA"
        ' 
        ' txt_senha_funcionario
        ' 
        txt_senha_funcionario.Location = New Point(431, 330)
        txt_senha_funcionario.Name = "txt_senha_funcionario"
        txt_senha_funcionario.Size = New Size(252, 23)
        txt_senha_funcionario.TabIndex = 51
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Location = New Point(216, 316)
        Button2.Name = "Button2"
        Button2.Size = New Size(198, 73)
        Button2.TabIndex = 54
        Button2.Text = "CADASTRAR FUNCIONÁRIO"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' pb_funcionario
        ' 
        pb_funcionario.BackColor = Color.White
        pb_funcionario.Location = New Point(465, 36)
        pb_funcionario.Name = "pb_funcionario"
        pb_funcionario.Size = New Size(163, 190)
        pb_funcionario.SizeMode = PictureBoxSizeMode.StretchImage
        pb_funcionario.TabIndex = 57
        pb_funcionario.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.Cyan
        Label8.Location = New Point(485, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 15)
        Label8.TabIndex = 59
        Label8.Text = "FOTO FUNCIONÁRIO"
        ' 
        ' txt_cpf_funcionario
        ' 
        txt_cpf_funcionario.Location = New Point(12, 149)
        txt_cpf_funcionario.Mask = "999.999.999.99"
        txt_cpf_funcionario.Name = "txt_cpf_funcionario"
        txt_cpf_funcionario.Size = New Size(174, 23)
        txt_cpf_funcionario.TabIndex = 60
        txt_cpf_funcionario.ValidatingType = GetType(Date)
        ' 
        ' txt_complemento_funcionario
        ' 
        txt_complemento_funcionario.Location = New Point(12, 259)
        txt_complemento_funcionario.Name = "txt_complemento_funcionario"
        txt_complemento_funcionario.Size = New Size(365, 23)
        txt_complemento_funcionario.TabIndex = 62
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.Cyan
        Label9.Location = New Point(12, 241)
        Label9.Name = "Label9"
        Label9.Size = New Size(164, 15)
        Label9.TabIndex = 61
        Label9.Text = "COMPLEMENTO (OPCIONAL)"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frm_cadastrar_funcionario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(695, 401)
        Controls.Add(txt_complemento_funcionario)
        Controls.Add(Label9)
        Controls.Add(txt_cpf_funcionario)
        Controls.Add(Label8)
        Controls.Add(pb_funcionario)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(txt_senha_funcionario)
        Controls.Add(Label1)
        Controls.Add(txt_login_funcionario)
        Controls.Add(txt_celular_funcionario)
        Controls.Add(Label2)
        Controls.Add(txt_endereco_funcionario)
        Controls.Add(Button1)
        Controls.Add(txt_email_funcionario)
        Controls.Add(Label6)
        Controls.Add(txt_nome_funcionario)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "frm_cadastrar_funcionario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRAR FUNCIONÁRIO"
        CType(pb_funcionario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_endereco_funcionario As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_email_funcionario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nome_funcionario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_celular_funcionario As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login_funcionario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_senha_funcionario As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pb_funcionario As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cpf_funcionario As MaskedTextBox
    Friend WithEvents txt_complemento_funcionario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
