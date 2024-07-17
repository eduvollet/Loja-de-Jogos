Public Class frm_gerente
    Private Sub btn_cadastrar_gerente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_gerente.Click
        Me.Visible = False
        frm_cadastrar_funcionario.ShowDialog()
    End Sub

    Private Sub btn_encerrar_gerente_Click(sender As Object, e As EventArgs) Handles btn_encerrar_gerente.Click
        Me.Finalize()
    End Sub
End Class