Public Class Form1
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If txt_nome_login.Text = "" Or
            txt_senha_login.Text = "" Then
                MsgBox("Preencha todos os campos!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            If txt_nome_login.Text = "admin" And txt_senha_login.Text = "admin" Then
                Me.Visible = False
                frm_gerente.ShowDialog()
                Exit Sub
            Else
                sql = "select * from cadastrar_funcionario where login_funcionario = '" & txt_nome_login.Text & "'"
                sql = "select * from cadastrar_funcionario where senha_funcionario = '" & txt_senha_login.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Conta logada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Visible = False
                    frm_vendedor.ShowDialog()
                Else
                    MsgBox("Conta não encontrada!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_nome_login.Clear()
                    txt_senha_login.Clear()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
End Class