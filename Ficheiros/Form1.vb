Imports System.IO

Public Class Form1
    Dim ScoreFile As String = "Scores.txt"
    Dim ConfigFile As String = "Config.txt"

    ' Variaveis globais
    Dim N_Botoes As Integer = 3
    Dim Logo As String = "Twin Software"

    Sub LerConfig()
        If File.Exists(ConfigFile) Then
            Dim Config As New StreamReader(ConfigFile)

            Do Until (Config.EndOfStream)
                Dim linha As String = Config.ReadLine
                If Not linha.StartsWith("#") Then
                    Dim PosicaoIgual As Integer

                    PosicaoIgual = InStr(1, linha, "=", CompareMethod.Text)
                    If PosicaoIgual > 0 Then
                        If linha.Contains("Botoes") Then N_Botoes = Integer.Parse(Mid(linha, PosicaoIgual + 1, 500))
                        If linha.Contains("Logo") Then Logo = Mid(linha, PosicaoIgual + 1, 500)
                    End If
                End If
            Loop

            Config.Close()

            MsgBox("Configurações lidas com sucesso !!!! ")

        End If
    End Sub

    Sub GravarConfig()
        Dim Config As New StreamWriter(ConfigFile, False)

        Config.WriteLine("Botoes=" & tbN_Botoes.Text)
        Config.WriteLine("Logo=" & tbLogo.Text)

        Config.Close()

        MsgBox("Configurações gravadas com sucesso !!!! ")
    End Sub

    Sub MostrarConfigs()
        tbN_Botoes.Text = N_Botoes
        tbLogo.Text = Logo
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarConfigs()
    End Sub

    Private Sub bLerConfig_Click(sender As Object, e As EventArgs) Handles bLerConfig.Click
        LerConfig()

        MostrarConfigs()

    End Sub

    Private Sub bGravarConfig_Click(sender As Object, e As EventArgs) Handles bGravarConfig.Click
        GravarConfig()

    End Sub
End Class
