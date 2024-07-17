Module Module1
    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public sql, diretorio, diretorio2, diretorio3 As String
    Public dir_banco = Application.StartupPath & "Banco\DGgames.accdb"

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
