<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerente
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_gerente))
        btn_encerrar_gerente = New Button()
        btn_cadastrar_gerente = New Button()
        SuspendLayout()
        ' 
        ' btn_encerrar_gerente
        ' 
        btn_encerrar_gerente.BackColor = Color.Cyan
        btn_encerrar_gerente.Location = New Point(161, 139)
        btn_encerrar_gerente.Name = "btn_encerrar_gerente"
        btn_encerrar_gerente.Size = New Size(204, 72)
        btn_encerrar_gerente.TabIndex = 5
        btn_encerrar_gerente.Text = "ENCERRAR SESSÃO"
        btn_encerrar_gerente.UseVisualStyleBackColor = False
        ' 
        ' btn_cadastrar_gerente
        ' 
        btn_cadastrar_gerente.BackColor = Color.Cyan
        btn_cadastrar_gerente.Location = New Point(161, 30)
        btn_cadastrar_gerente.Name = "btn_cadastrar_gerente"
        btn_cadastrar_gerente.Size = New Size(204, 72)
        btn_cadastrar_gerente.TabIndex = 3
        btn_cadastrar_gerente.Text = "CADASTRAR FUNCIONÁRIO"
        btn_cadastrar_gerente.UseVisualStyleBackColor = False
        ' 
        ' frm_gerente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(524, 243)
        Controls.Add(btn_encerrar_gerente)
        Controls.Add(btn_cadastrar_gerente)
        Name = "frm_gerente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MENU GERENTE"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_encerrar_gerente As Button
    Friend WithEvents btn_cadastrar_gerente As Button
End Class
