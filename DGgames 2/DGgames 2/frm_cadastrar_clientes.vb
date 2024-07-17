Public Class frm_cadastrar_clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_vendedor.Visible = True
        Me.Visible = False
    End Sub
    Private Sub frm_cadastrar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "select * from cadastrar_cliente"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "insert into cadastrar_cliente values('" & txt_cpf.Text & "'," &
                                                           "'" & txt_nome.Text & "'," &
                                                           "'" & txt_email.Text & "'," &
                                                           "'" & txt_cidade.Text & "'," &
                                                           "'" & txt_cpf.Text & "'," &
                                                           "'" & txt_data.Text & "'," &
                                                           "'" & txt_celular.Text & "'," &
                                                           "'" & diretorio2 & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro de cliente realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cpf.Clear()
                txt_nome.Clear()
                txt_email.Clear()
                txt_cidade.Clear()
                txt_cpf.Clear()
                txt_endereco.Clear()
                txt_data.Clear()
                txt_celular.Clear()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub pb_cliente_Click(sender As Object, e As EventArgs) Handles pb_cliente.Click
        Try
            With OpenFileDialog2
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\FOTOS"
                .ShowDialog()
                diretorio2 = .FileName
                pb_cliente.Load(diretorio2)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class