Public Class frm_venda
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_vendedor.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frm_venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_cpf_venda.Focus()
    End Sub

    Private Sub btn_confirmar_venda_Click(sender As Object, e As EventArgs) Handles btn_confirmar_venda.Click
        Try
            sql = "select * from vendas"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "insert into vendas values ('" & txt_codigo_vendas.Text & "'," &
                                             "'" & txt_preco_venda.Text & "'," &
                                             "'" & txt_cpf_venda.Text & "'," &
                                             "'" & txt_nome_venda.Text & "'," &
                                             "'" & txt_pagamento_venda.Text & "'," &
                                             "'" & txt_presente_venda.Text & "'," &
                                             "'" & diretorio3 & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Venda realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_codigo_vendas.Clear()
                txt_preco_venda.Clear()
                txt_cpf_venda.Clear()
                txt_nome_venda.Clear()
                txt_pagamento_venda.Clear()
                txt_presente_venda.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_cpf_venda_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_venda.LostFocus
        txt_codigo_vendas.Focus()
        Try
            sql = "select * from cadastrar_cliente where cpf = '" & txt_cpf_venda.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome_venda.Text = rs.Fields(1).Value
                pb_venda.Load(rs.Fields(7).Value)
            Else
                MsgBox("cpf não encontrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_codigo_vendas_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo_vendas.LostFocus
        Try
            sql = "select * from cadastrar_produto where codigo_produto = '" & txt_codigo_vendas.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_preco_venda.Text = rs.Fields(3).Value
            Else
                MsgBox("produto não encontrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pb_venda_Click(sender As Object, e As EventArgs) Handles pb_venda.Click
        Try
            With OpenFileDialog3
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\FOTOS"
                .ShowDialog()
                diretorio3 = .FileName
                pb_venda.Load(diretorio3)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class