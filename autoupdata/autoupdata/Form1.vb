Public Class Form1
    '读ini API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32

    '读取ini文件内容
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public upsrc = "http://code.taobao.org/svn/BHBnet/trunk/updatafiles/"

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            My.Computer.FileSystem.DeleteFile("up_com.bat")
            My.Computer.FileSystem.DeleteFile("fix_com.bat")
            My.Computer.FileSystem.DeleteFile("d2updata.rar")
            My.Computer.FileSystem.DeleteFile("d2fixdata.rar")
        Catch ex As Exception

        End Try
        Shell("暗黑II BH战网.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button_updata_Click(sender As Object, e As EventArgs) Handles Button_updata.Click
        If Button_updata.Text = "开始更新" Then
            Button_updata.Enabled = False
            Button_fix_game.Enabled = False
            Button_updata.Text = "正在更新"
            Dim path As String
            path = Application.StartupPath + "\暗黑II BH战网.ini"
            upsrc = GetINI("CFG", "upsrc", upsrc, path)
            ProgressBar1.Value = 10
            Dim dFile As New System.Net.WebClient
            '下载更新文件
            Try
                dFile.DownloadFile(upsrc + "up_com.bat.rar", "up_com.bat")
                ProgressBar1.Value = 30
            Catch ex As Exception
                MsgBox("下载失败请重试")
                ProgressBar1.Value = 0
                Exit Sub
            End Try
            Try
                dFile.DownloadFile(upsrc + "d2updata.rar", "d2updata.rar")
                ProgressBar1.Value = 80
            Catch ex As Exception
                MsgBox("下载失败请重试")
                ProgressBar1.Value = 0
                Exit Sub
            End Try

            Shell("up_com.bat", AppWinStyle.Hide, Wait:=True, Timeout:=120000)
            ProgressBar1.Value = 100
            MsgBox("升级成功")
            Button_updata.Text = "关闭"
            Button_updata.Enabled = True
        Else
            Me.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        Dim updata_readme_txt As String
        Dim dFile As New System.Net.WebClient
        path = Application.StartupPath + "\暗黑II BH战网.ini"
        upsrc = GetINI("CFG", "upsrc", upsrc, path)
        Try
            updata_readme_txt = dFile.DownloadString(upsrc + "updata_readme.txt")
            TextBox1.Text = updata_readme_txt
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button_fix_game_Click(sender As Object, e As EventArgs) Handles Button_fix_game.Click
        Button_updata.Enabled = False
        Button_fix_game.Enabled = False
        Button_fix_game.Text = "正在修复"
        MsgBox（"修复游戏需要时间较长，请耐心等待"）

        '还原默认设置
        resetini()

        ' 下载文件
        Dim path As String
        path = Application.StartupPath + "\暗黑II BH战网.ini"
        upsrc = GetINI("CFG", "upsrc", upsrc, path)
        ProgressBar1.Value = 5
        Dim dFile As New System.Net.WebClient
        '下载更新列表
        '打开网页后检测更新
        Try

            dFile.DownloadFile(upsrc + "fixdata/fix_com.bat.rar", "fix_com.bat")
            ProgressBar1.Value = 10
        Catch ex As Exception
            MsgBox("1下载失败请重试")
            Button_fix_game.Enabled = True
            Button_fix_game.Text = "修复游戏"
            ProgressBar1.Value = 0
            Exit Sub
        End Try

        Try

            dFile.DownloadFile(upsrc + "fixdata/Rar.exe.rar", "rar.exe")
            ProgressBar1.Value = 40
        Catch ex As Exception
            MsgBox("2下载失败请重试")
            Button_fix_game.Enabled = True
            Button_fix_game.Text = "修复游戏"
            ProgressBar1.Value = 0
            Exit Sub
        End Try

        Try
            dFile.DownloadFile(upsrc + "fixdata/d2fixdata.rar", "d2fixdata.rar")

            ProgressBar1.Value = 80
        Catch ex As Exception
            MsgBox("3下载失败请重试")
            Button_fix_game.Enabled = True
            Button_fix_game.Text = "修复游戏"
            ProgressBar1.Value = 0
            Exit Sub
        End Try

        Try
            Shell("fix_com.bat", AppWinStyle.Hide)
        Catch ex As Exception
            MsgBox("修复程序运行错误，请重试")
            Button_fix_game.Enabled = True
            Button_fix_game.Text = "修复游戏"
            ProgressBar1.Value = 0
        End Try
        ProgressBar1.Value = 90

        '设置兼容性

        ProgressBar1.Value = 95

        '运行dvitest

        resetini()
        ProgressBar1.Value = 100


        MsgBox("修复完成，如果运行报错，请手动设置兼容性")
        Button_updata.Text = "关闭"
        Button_updata.Enabled = True




        Me.Close()
    End Sub
    Private Sub resetini()
        '删除本程序配置ini文件
        Try
            My.Computer.FileSystem.DeleteFile("暗黑II BH战网.ini")
        Catch ex As Exception
        End Try
        '删除mpq外文件

        '注册表还原默认设置
        '删除注册表
        Try
            My.Computer.Registry.LocalMachine.DeleteSubKeyTree("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Blizzard Entertainment\Diablo II")
        Catch ex As Exception

        End Try

        '写入注册表
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "Resolution", dFile.DownloadString("http://code.taobao.org/svn/BHBnet/trunk/ip/ip.txt"))

        '"Resolution"=dword:00000001
        '"Always Run"=dword:00000001
        '"MAX_PLAYER"=dword:00000008
        '"Perspective"=dword:00000001
        '"Resolution"=dword:00000001
        '"Always Run"=dword:00000001
        '"D2RMRes"=dword:00000012
        '"LVL_REST"=dword:0000029a
        '"MAX_PLAYER"=dword:00000007
        '"Perspective"=dword:00000000
        '"Aux Battle.net"="216.148.246.255"



    End Sub
End Class
