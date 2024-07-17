Public Class frm_cadastrar_produto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_vendedor.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frm_cadastrar_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "select * from cadastrar_produto"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "insert into cadastrar_produto values ('" & txt_nome_produto_cadastro.Text & "'," &
                                                       "'" & txt_codigo_produto_cadastro.Text & "'," &
                                                       "" & txt_unidade_cadastro.Text & "," &
                                                       "'" & txt_preco_cadastro.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro de produto realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_nome_produto_cadastro.Clear()
                txt_codigo_produto_cadastro.Clear()
                txt_unidade_cadastro.Clear()
                txt_preco_cadastro.Clear()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class