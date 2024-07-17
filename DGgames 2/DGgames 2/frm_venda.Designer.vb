<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_venda
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_venda))
        btn_confirmar_venda = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_codigo_vendas = New TextBox()
        txt_preco_venda = New TextBox()
        txt_nome_venda = New TextBox()
        Label6 = New Label()
        txt_cpf_venda = New TextBox()
        Button1 = New Button()
        txt_pagamento_venda = New TextBox()
        txt_presente_venda = New TextBox()
        Label8 = New Label()
        pb_venda = New PictureBox()
        OpenFileDialog3 = New OpenFileDialog()
        CType(pb_venda, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_confirmar_venda
        ' 
        btn_confirmar_venda.BackColor = Color.Cyan
        btn_confirmar_venda.Location = New Point(472, 306)
        btn_confirmar_venda.Name = "btn_confirmar_venda"
        btn_confirmar_venda.Size = New Size(194, 73)
        btn_confirmar_venda.TabIndex = 0
        btn_confirmar_venda.Text = "CONFIRMAR VENDA"
        btn_confirmar_venda.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(33, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 1
        Label1.Text = "CODIGO DO PRODUTO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(250, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 2
        Label2.Text = "PREÇO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Cyan
        Label3.Location = New Point(33, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 3
        Label3.Text = "CPF DO CLIENTE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Cyan
        Label4.Location = New Point(33, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 15)
        Label4.TabIndex = 4
        Label4.Text = "FORMA DE PAGAMENTO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Cyan
        Label5.Location = New Point(250, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 5
        Label5.Text = "PRESENTE"
        ' 
        ' txt_codigo_vendas
        ' 
        txt_codigo_vendas.Location = New Point(33, 67)
        txt_codigo_vendas.Name = "txt_codigo_vendas"
        txt_codigo_vendas.Size = New Size(178, 23)
        txt_codigo_vendas.TabIndex = 6
        ' 
        ' txt_preco_venda
        ' 
        txt_preco_venda.Location = New Point(250, 67)
        txt_preco_venda.Name = "txt_preco_venda"
        txt_preco_venda.Size = New Size(154, 23)
        txt_preco_venda.TabIndex = 7
        ' 
        ' txt_nome_venda
        ' 
        txt_nome_venda.Location = New Point(33, 181)
        txt_nome_venda.Name = "txt_nome_venda"
        txt_nome_venda.Size = New Size(371, 23)
        txt_nome_venda.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(33, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 15)
        Label6.TabIndex = 11
        Label6.Text = "NOME DO CLIENTE"
        ' 
        ' txt_cpf_venda
        ' 
        txt_cpf_venda.Location = New Point(33, 128)
        txt_cpf_venda.Name = "txt_cpf_venda"
        txt_cpf_venda.Size = New Size(371, 23)
        txt_cpf_venda.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(28, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 73)
        Button1.TabIndex = 13
        Button1.Text = "VOLTAR AO MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_pagamento_venda
        ' 
        txt_pagamento_venda.Location = New Point(33, 246)
        txt_pagamento_venda.Name = "txt_pagamento_venda"
        txt_pagamento_venda.Size = New Size(178, 23)
        txt_pagamento_venda.TabIndex = 14
        ' 
        ' txt_presente_venda
        ' 
        txt_presente_venda.Location = New Point(250, 246)
        txt_presente_venda.Name = "txt_presente_venda"
        txt_presente_venda.Size = New Size(154, 23)
        txt_presente_venda.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.Cyan
        Label8.Location = New Point(501, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 15)
        Label8.TabIndex = 61
        Label8.Text = "FOTO COMPRADOR"
        ' 
        ' pb_venda
        ' 
        pb_venda.BackColor = Color.White
        pb_venda.Location = New Point(481, 67)
        pb_venda.Name = "pb_venda"
        pb_venda.Size = New Size(163, 190)
        pb_venda.SizeMode = PictureBoxSizeMode.StretchImage
        pb_venda.TabIndex = 60
        pb_venda.TabStop = False
        ' 
        ' OpenFileDialog3
        ' 
        OpenFileDialog3.FileName = "OpenFileDialog1"
        ' 
        ' frm_venda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(695, 401)
        Controls.Add(Label8)
        Controls.Add(pb_venda)
        Controls.Add(txt_presente_venda)
        Controls.Add(txt_pagamento_venda)
        Controls.Add(Button1)
        Controls.Add(txt_cpf_venda)
        Controls.Add(Label6)
        Controls.Add(txt_nome_venda)
        Controls.Add(txt_preco_venda)
        Controls.Add(txt_codigo_vendas)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_confirmar_venda)
        ForeColor = SystemColors.ControlText
        Name = "frm_venda"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VENDAS"
        CType(pb_venda, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_confirmar_venda As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo_vendas As TextBox
    Friend WithEvents txt_preco_venda As TextBox
    Friend WithEvents txt_nome_venda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cpf_venda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_pagamento_venda As TextBox
    Friend WithEvents txt_presente_venda As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pb_venda As PictureBox
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
End Class
