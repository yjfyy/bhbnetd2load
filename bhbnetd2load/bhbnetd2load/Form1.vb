
Public Class Form_BHbnetD2Loader
    Private Sub BHbnetD2Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '读取ini文件
        Try
            Dim path As String
            path = Application.StartupPath + "\BHBnetD2Loader.ini"
            If GetINI("CFG", "locale", "chi", path) = "chi" Then
                RadioButton_chi.Checked = True
            Else
                RadioButton_eng.Checked = True
            End If

            CheckBox_w.Checked = GetINI("CFG", "w", "True", path)
            CheckBox_ns.Checked = GetINI("CFG", "ns", "False", path)
            CheckBox_high.Checked = GetINI("CFG", "high", "True", path)
            CheckBox_skiptobnet.Checked = GetINI("CFG", "skiptobnet", "True", path)
            TextBox_customVar.Text = GetINI("CFG", "customVar", "", path)
        Catch ex As Exception
            MsgBox("错误！！！！" & ex.ToString)
        End Try
        My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BnetIP", "tybh.vicp.net")
    End Sub

    Private Sub BHbnetD2Loader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        savecfg()
    End Sub

    Private Sub Button_rund2_Click(sender As Object, e As EventArgs) Handles Button_rund2.Click
        savecfg()
        If Button_rund2.Text = "运行游戏" Then
            runCommand()
        Else
            runautoupdata()
        End If


    End Sub
    Private Sub Button_D2VidTst_Click(sender As Object, e As EventArgs) Handles Button_D2VidTst.Click
        Try
            Shell("D2VidTst.exe", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub runautoupdata()

        Shell("autoupdata.exe", AppWinStyle.NormalFocus)
        Close()
    End Sub



    Private Sub runCommand()
        Dim command As String
        Dim d2loader As String
        Dim local As String
        Dim w As String
        Dim ns As String
        Dim skiptobnet As String
        Dim customVar As String
        Dim fix As String

        If CheckBox_high.Checked Then
            d2loader = "D2Loader-high.exe "
        Else
            d2loader = "D2Loader-1.13c.exe "
        End If

        If RadioButton_chi.Checked Then
            local = "-locale chi "
        Else
            local = "-locale eng "
        End If

        If CheckBox_w.Checked Then
            w = "-w "
        Else
            w = ""
        End If

        If CheckBox_ns.Checked Then
            ns = "-ns "
        Else
            ns = ""
        End If

        If CheckBox_skiptobnet.Checked Then
            skiptobnet = "-skiptobnet "
        Else
            skiptobnet = ""
        End If

        customVar = TextBox_customVar.Text

        Fix = "-direct "

        command = d2loader + local + w + ns + skiptobnet + customVar + fix
        Try
            Shell(command, AppWinStyle.NormalFocus, False, 2000)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub savecfg()
        '写入ini文件
        Try
            Dim path As String
            path = Application.StartupPath + "\BHBnetD2Loader.ini"
            If RadioButton_chi.Checked = True Then
                WriteINI("CFG", "locale", "chi", path)
            Else
                WriteINI("CFG", "locale", "eng", path)
            End If

            WriteINI("CFG", "w", CheckBox_w.Checked.ToString, path)
            WriteINI("CFG", "ns", CheckBox_ns.Checked.ToString, path)
            WriteINI("CFG", "high", CheckBox_high.Checked.ToString, path)
            WriteINI("CFG", "skiptobnet", CheckBox_skiptobnet.Checked.ToString, path)
            WriteINI("CFG", "customVar", TextBox_customVar.Text, path)

        Catch ex As Exception

        End Try
    End Sub

    '读取ini文件内容
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    '写ini文件操作
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function

    '读ini API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32

    '写ini API函数
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32


    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        '打开网页后检测更新
        Dim dFile As New System.Net.WebClient
        Dim r_version = "0"
        Dim l_version = "0"
        Try
            l_version = My.Computer.FileSystem.ReadAllText(".\version.txt")
            Label_l_version.Text = l_version
        Catch ex As Exception
            If l_version = "0" Then
                Label_r_version.Text = "无法获得本地版本"
                MsgBox("无法获得本地版本,推荐修复游戏")
            End If
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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        runautoupdata()
    End Sub
End Class
