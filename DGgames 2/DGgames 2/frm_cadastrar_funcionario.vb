Public Class frm_cadastrar_funcionario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_gerente.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frm_cadastrar_funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            sql = "select * from cadastrar_funcionario"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "insert into cadastrar_funcionario values('" & txt_cpf_funcionario.Text & "'," &
                                                       "'" & txt_nome_funcionario.Text & "'," &
                                                       "'" & txt_email_funcionario.Text & "'," &
                                                       "'" & txt_endereco_funcionario.Text & "'," &
                                                       "'" & txt_complemento_funcionario.Text & "'," &
                                                       "'" & txt_celular_funcionario.Text & "'," &
                                                       "'" & txt_login_funcionario.Text & "'," &
                                                       "'" & txt_senha_funcionario.Text & "'," &
                                                       "'" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro de funcionário realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cpf_funcionario.Clear()
                txt_nome_funcionario.Clear()
                txt_email_funcionario.Clear()
                txt_endereco_funcionario.Clear()
                txt_complemento_funcionario.Clear()
                txt_celular_funcionario.Clear()
                txt_login_funcionario.Clear()
                txt_senha_funcionario.Clear()
            End If
        Catch ex As Exception
            MsgBox("Nao foi possivel realizar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub pb_funcionario_Click(sender As Object, e As EventArgs) Handles pb_funcionario.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\FOTOS"
                .ShowDialog()
                diretorio = .FileName
                pb_funcionario.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class