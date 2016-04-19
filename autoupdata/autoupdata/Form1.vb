Public Class Form1
    '读ini API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32

    '读取ini文件内容
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function



    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            My.Computer.FileSystem.DeleteFile("updata.bat")
            My.Computer.FileSystem.DeleteFile("d2updata.rar")
        Catch ex As Exception

        End Try
        Shell("暗黑II BH战网.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button_updata_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        If Button_updata.Text = "开始更新" Then
            Button_updata.Enabled = False
            Button_updata.Text = "正在更新"
            Dim path As String
            path = Application.StartupPath + "\暗黑II BH战网.ini"
            Dim upsrc
            upsrc = GetINI("CFG", "upsrc", "http://tybh.vicp.net:81/updatafiles/", path)
            ProgressBar1.Value = 10
            Dim dFile As New System.Net.WebClient
            '下载更新列表
            '打开网页后检测更新
            Try
                dFile.DownloadFile(upsrc + "d2updata.rar", "d2updata.rar")
                'dFile.DownloadFile("https://github.com/yjfyy/bhbnetd2load/raw/master/autoupdata/d2updata.rar", "d2updata.rar")
                ProgressBar1.Value = 60
            Catch ex As Exception
                MsgBox("d2updata.rar下载失败请重试")
                ProgressBar1.Value = 0
                Exit Sub
            End Try
            Try
                ' dFile.DownloadFile("https://github.com/yjfyy/bhbnetd2load/raw/master/autoupdata/updata.rar", "updata.bat")
                dFile.DownloadFile(upsrc + "updata.rar", "updata.bat")
                ProgressBar1.Value = 70
            Catch ex As Exception
                MsgBox("updata.bat下载失败请重试")
                ProgressBar1.Value = 0
                Exit Sub
            End Try
            Shell("updata.bat", AppWinStyle.Hide)
            ProgressBar1.Value = 100
            MsgBox("升级成功")
            Button_updata.Text = "关闭"
            Button_updata.Enabled = True
        Else
            Me.Close()
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim upsrc As String
        Dim path As String
        Dim updata_readme_txt As String
        Dim dFile As New System.Net.WebClient
        path = Application.StartupPath + "\暗黑II BH战网.ini"
        upsrc = GetINI("CFG", "upsrc", "http://tybh.vicp.net:81/updatafiles/", path)
        updata_readme_txt = dFile.DownloadString(upsrc + "updata_readme.txt")
        TextBox1.Text = updata_readme_txt
    End Sub

End Class
