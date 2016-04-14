Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 10
        Dim dFile As New System.Net.WebClient
        '下载更新列表
        '打开网页后检测更新

        Try
            dFile.DownloadFile("http://tybh.vicp.net:81/downloads/d2updata.rar", "d2updata.rar")
            'dFile.DownloadFile("https://github.com/yjfyy/bhbnetd2load/raw/master/autoupdata/d2updata.rar", "d2updata.rar")
            ProgressBar1.Value = 60
        Catch ex As Exception
            MsgBox("d2updata.rar下载失败请重试")
            Exit Sub
        End Try
        Try
            ' dFile.DownloadFile("https://github.com/yjfyy/bhbnetd2load/raw/master/autoupdata/updata.rar", "updata.bat")
            dFile.DownloadFile("http://tybh.vicp.net:81/downloads/updata.rar", "updata.bat")
            ProgressBar1.Value = 70
        Catch ex As Exception
            MsgBox("updata.bat下载失败请重试")
            Exit Sub
        End Try
        Shell("updata.bat", AppWinStyle.Hide)
        ProgressBar1.Value = 100
        MsgBox("升级成功")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            My.Computer.FileSystem.DeleteFile("updata.bat")
        Catch ex As Exception

        End Try
        Shell("暗黑II BH战网.exe", AppWinStyle.NormalFocus)
    End Sub
End Class
