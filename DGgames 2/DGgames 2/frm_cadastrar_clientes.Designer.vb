<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastrar_clientes
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_cadastrar_clientes))
        txt_endereco = New TextBox()
        Button1 = New Button()
        txt_email = New TextBox()
        Label6 = New Label()
        txt_nome = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_confirmar = New Button()
        txt_data = New MaskedTextBox()
        txt_celular = New MaskedTextBox()
        txt_cidade = New TextBox()
        txt_cpf = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        pb_cliente = New PictureBox()
        OpenFileDialog2 = New OpenFileDialog()
        CType(pb_cliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(33, 241)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(401, 23)
        txt_endereco.TabIndex = 31
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(33, 316)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 73)
        Button1.TabIndex = 30
        Button1.Text = "VOLTAR AO MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(33, 84)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(401, 23)
        txt_email.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(33, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 15)
        Label6.TabIndex = 28
        Label6.Text = "NOME DO CLIENTE"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(33, 137)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(401, 23)
        txt_nome.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Cyan
        Label5.Location = New Point(33, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 24
        Label5.Text = "CIDADE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Cyan
        Label4.Location = New Point(33, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 23
        Label4.Text = "ENDEREÇO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Cyan
        Label3.Location = New Point(33, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 22
        Label3.Text = "E-MAIL DO CLIENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(250, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 21
        Label2.Text = "CELULAR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(33, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 20
        Label1.Text = "IDADE"
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.BackColor = Color.Cyan
        btn_confirmar.Location = New Point(472, 316)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(194, 73)
        btn_confirmar.TabIndex = 19
        btn_confirmar.Text = "CADASTRAR CLIENTE"
        btn_confirmar.UseVisualStyleBackColor = False
        ' 
        ' txt_data
        ' 
        txt_data.Location = New Point(33, 23)
        txt_data.Mask = "00/00/0000"
        txt_data.Name = "txt_data"
        txt_data.Size = New Size(193, 23)
        txt_data.TabIndex = 35
        txt_data.ValidatingType = GetType(Date)
        ' 
        ' txt_celular
        ' 
        txt_celular.Location = New Point(250, 23)
        txt_celular.Mask = "(00) 00000-0000"
        txt_celular.Name = "txt_celular"
        txt_celular.Size = New Size(184, 23)
        txt_celular.TabIndex = 36
        txt_celular.ValidatingType = GetType(Date)
        ' 
        ' txt_cidade
        ' 
        txt_cidade.Location = New Point(33, 192)
        txt_cidade.Name = "txt_cidade"
        txt_cidade.Size = New Size(401, 23)
        txt_cidade.TabIndex = 37
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(33, 287)
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(401, 23)
        txt_cpf.TabIndex = 39
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.Cyan
        Label7.Location = New Point(33, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 38
        Label7.Text = "CPF"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.Cyan
        Label8.Location = New Point(525, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 15)
        Label8.TabIndex = 61
        Label8.Text = "FOTO CLIENTE"
        ' 
        ' pb_cliente
        ' 
        pb_cliente.BackColor = Color.White
        pb_cliente.Location = New Point(488, 49)
        pb_cliente.Name = "pb_cliente"
        pb_cliente.Size = New Size(163, 190)
        pb_cliente.SizeMode = PictureBoxSizeMode.StretchImage
        pb_cliente.TabIndex = 60
        pb_cliente.TabStop = False
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog1"
        ' 
        ' frm_cadastrar_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(695, 401)
        Controls.Add(Label8)
        Controls.Add(pb_cliente)
        Controls.Add(txt_cpf)
        Controls.Add(Label7)
        Controls.Add(txt_cidade)
        Controls.Add(txt_celular)
        Controls.Add(txt_data)
        Controls.Add(txt_endereco)
        Controls.Add(Button1)
        Controls.Add(txt_email)
        Controls.Add(Label6)
        Controls.Add(txt_nome)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_confirmar)
        Name = "frm_cadastrar_clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRAR CLIENTES"
        CType(pb_cliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pb_cliente As PictureBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
