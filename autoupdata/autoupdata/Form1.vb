Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dFile As New System.Net.WebClient
        '下载更新列表

        '打开网页后检测更新

        Dim r_version = "0"
        Dim l_version = "0"
        Try
            dFile.DownloadFile("https://raw.githubusercontent.com/yjfyy/bhbnetd2load/master/autoupdata/filelist.txt", "filelist.txt")
        Catch ex As Exception

        End Try

        Try
            r_version = dFile.DownloadString("https://raw.githubusercontent.com/yjfyy/bhbnetd2load/master/autoupdata/version.txt")
        Catch ex As Exception
            If r_version = "0" Then
                Label_r_version.Text = "检测超时"
            End If

        End Try
        Label_r_version.Text = r_version
        If r_version = l_version And l_version <> "0" Then
            Button_rund2.Text = "运行游戏"
        Else
            Button_rund2.Text = "更新游戏"
        End If
        Button_rund2.Enabled = True
        'dFile.DownloadFile("https://raw.githubusercontent.com/yjfyy/bhbnetd2load/master/autoupdata/filelist.txt", "c:\a.txt")
    End Sub
    End Sub
End Class
