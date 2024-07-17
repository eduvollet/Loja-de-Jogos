Public Class frm_vendedor
    Private Sub btn_vender_Click(sender As Object, e As EventArgs) Handles btn_vender.Click
        Me.Visible = False
        frm_venda.ShowDialog()
    End Sub

    Private Sub btn_cadastro_vendedor_Click(sender As Object, e As EventArgs) Handles btn_cadastro_vendedor.Click
        Me.Visible = False
        frm_cadastrar_produto.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        frm_cadastrar_clientes.ShowDialog()
    End Sub

    Private Sub btn_encerrar_vendedor_Click(sender As Object, e As EventArgs) Handles btn_encerrar_vendedor.Click
        Me.Finalize()
    End Sub
End Class