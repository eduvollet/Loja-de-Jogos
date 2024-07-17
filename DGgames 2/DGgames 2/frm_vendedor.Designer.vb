<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vendedor))
        Me.btn_vender = New System.Windows.Forms.Button()
        Me.btn_cadastro_vendedor = New System.Windows.Forms.Button()
        Me.btn_encerrar_vendedor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_vender
        '
        Me.btn_vender.BackColor = System.Drawing.Color.Cyan
        Me.btn_vender.Location = New System.Drawing.Point(161, 26)
        Me.btn_vender.Name = "btn_vender"
        Me.btn_vender.Size = New System.Drawing.Size(204, 72)
        Me.btn_vender.TabIndex = 0
        Me.btn_vender.Text = "VENDER"
        Me.btn_vender.UseVisualStyleBackColor = False
        '
        'btn_cadastro_vendedor
        '
        Me.btn_cadastro_vendedor.BackColor = System.Drawing.Color.Cyan
        Me.btn_cadastro_vendedor.Location = New System.Drawing.Point(161, 228)
        Me.btn_cadastro_vendedor.Name = "btn_cadastro_vendedor"
        Me.btn_cadastro_vendedor.Size = New System.Drawing.Size(204, 72)
        Me.btn_cadastro_vendedor.TabIndex = 1
        Me.btn_cadastro_vendedor.Text = "CADASTRAR PRODUTOS"
        Me.btn_cadastro_vendedor.UseVisualStyleBackColor = False
        '
        'btn_encerrar_vendedor
        '
        Me.btn_encerrar_vendedor.BackColor = System.Drawing.Color.Cyan
        Me.btn_encerrar_vendedor.Location = New System.Drawing.Point(161, 328)
        Me.btn_encerrar_vendedor.Name = "btn_encerrar_vendedor"
        Me.btn_encerrar_vendedor.Size = New System.Drawing.Size(204, 72)
        Me.btn_encerrar_vendedor.TabIndex = 2
        Me.btn_encerrar_vendedor.Text = "ENCERRAR SESSÃO"
        Me.btn_encerrar_vendedor.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(161, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 72)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CADASTRAR CLIENTES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_encerrar_vendedor)
        Me.Controls.Add(Me.btn_cadastro_vendedor)
        Me.Controls.Add(Me.btn_vender)
        Me.Name = "frm_vendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU VENDEDOR"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_vender As Button
    Friend WithEvents btn_cadastro_vendedor As Button
    Friend WithEvents btn_encerrar_vendedor As Button
    Friend WithEvents Button1 As Button
End Class
