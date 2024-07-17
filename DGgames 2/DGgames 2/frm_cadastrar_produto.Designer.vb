<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastrar_produto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_cadastrar_produto))
        txt_unidade_cadastro = New TextBox()
        txt_preco_cadastro = New TextBox()
        Button1 = New Button()
        txt_nome_produto_cadastro = New TextBox()
        Label6 = New Label()
        txt_codigo_produto_cadastro = New TextBox()
        Label3 = New Label()
        btn_confirmar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txt_unidade_cadastro
        ' 
        txt_unidade_cadastro.Location = New Point(148, 172)
        txt_unidade_cadastro.Name = "txt_unidade_cadastro"
        txt_unidade_cadastro.Size = New Size(401, 23)
        txt_unidade_cadastro.TabIndex = 46
        ' 
        ' txt_preco_cadastro
        ' 
        txt_preco_cadastro.Location = New Point(148, 222)
        txt_preco_cadastro.Name = "txt_preco_cadastro"
        txt_preco_cadastro.Size = New Size(401, 23)
        txt_preco_cadastro.TabIndex = 43
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(60, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 73)
        Button1.TabIndex = 42
        Button1.Text = "VOLTAR AO MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_nome_produto_cadastro
        ' 
        txt_nome_produto_cadastro.Location = New Point(147, 56)
        txt_nome_produto_cadastro.Name = "txt_nome_produto_cadastro"
        txt_nome_produto_cadastro.Size = New Size(401, 23)
        txt_nome_produto_cadastro.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(12, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 15)
        Label6.TabIndex = 40
        Label6.Text = "CÓDIGO DO PRODUTO"
        ' 
        ' txt_codigo_produto_cadastro
        ' 
        txt_codigo_produto_cadastro.Location = New Point(148, 114)
        txt_codigo_produto_cadastro.Name = "txt_codigo_produto_cadastro"
        txt_codigo_produto_cadastro.Size = New Size(401, 23)
        txt_codigo_produto_cadastro.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Cyan
        Label3.Location = New Point(23, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 15)
        Label3.TabIndex = 38
        Label3.Text = "NOME DO PRODUTO"
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.BackColor = Color.Cyan
        btn_confirmar.Location = New Point(355, 295)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(194, 73)
        btn_confirmar.TabIndex = 47
        btn_confirmar.Text = "CADASTRAR PRODUTO"
        btn_confirmar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(23, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 48
        Label1.Text = "QUANTAS UNIDADES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(98, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 49
        Label2.Text = "PREÇO"
        ' 
        ' frm_cadastrar_produto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(595, 401)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_confirmar)
        Controls.Add(txt_unidade_cadastro)
        Controls.Add(txt_preco_cadastro)
        Controls.Add(Button1)
        Controls.Add(txt_nome_produto_cadastro)
        Controls.Add(Label6)
        Controls.Add(txt_codigo_produto_cadastro)
        Controls.Add(Label3)
        Name = "frm_cadastrar_produto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_cadastrar_produto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_unidade_cadastro As TextBox
    Friend WithEvents txt_preco_cadastro As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_nome_produto_cadastro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_codigo_produto_cadastro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
