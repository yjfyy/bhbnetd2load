﻿
Public Class Form_BHbnetD2Loader
    Public upsrc As String
    Private Sub BHbnetD2Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '读取ini文件
        load_ini()
        '设置注册表
        set_reg()
    End Sub

    Private Sub BHbnetD2Loader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '保存ini文件
        save_ini()
    End Sub

    Private Sub Button_rund2_Click(sender As Object, e As EventArgs) Handles Button_rund2.Click
        save_ini()
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

    Private Sub Button_fixgame_Click(sender As Object, e As EventArgs) Handles Button_fixgame.Click
        runautoupdata()
    End Sub

    Private Sub runCommand()
        Dim d2run_command As String
        Dim d2loader As String
        Dim local As String
        Dim w As String
        Dim ns As String
        Dim skiptobnet As String
        Dim customVar As String
        Dim fix As String
        Dim map As String

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

        If CheckBox_map.Checked Then
            map = "-pdir bh113map "
        Else
            map = ""
        End If

        customVar = TextBox_customVar.Text

        fix = TextBox_command_fix.Text

        d2run_command = d2loader + local + w + ns + skiptobnet + map + customVar + fix
        Try
            'MsgBox(d2run_command)
            Shell(d2run_command, AppWinStyle.NormalFocus, False)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub save_ini()
        '写入ini文件
        Try
            Dim path As String
            path = Application.StartupPath + "\暗黑II BH战网.ini"
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
            WriteINI("cfg", "command_fix", " -direct -nofixaspect -nohide -txt", path)
            WriteINI("CFG", "upsrc", "http://tybh.vicp.net:81/updatafiles/", path)
            WriteINI("CFG", "map", CheckBox_map.Checked.ToString, path)
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
                Exit Sub
            End If
        End Try
        Try
            r_version = dFile.DownloadString(upsrc + "version.txt")
            Label_r_version.Text = r_version
        Catch ex As Exception
            Label_r_version.Text = "检测超时"
        End Try
        If Label_r_version.Text = "检测超时" Or Label_r_version.Text = Label_l_version.Text Then
            Button_rund2.Text = "运行游戏"
        Else
            Button_rund2.Text = "更新游戏"
        End If
        Button_rund2.Enabled = True

    End Sub


    Private Sub load_ini()
        Try
            Dim path As String
            path = Application.StartupPath + "\暗黑II BH战网.ini"
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
            If TextBox_customVar.Text = "null" Then
                TextBox_customVar.Text = ""
            End If
            TextBox_command_fix.Text = GetINI("cfg", "command_fix", " -direct -pdir bh113map -nofixaspect -nohide -txt", path)
            upsrc = GetINI("CFG", "upsrc", "http://tybh.vicp.net:81/updatafiles/", path)
            CheckBox_map.Checked = GetINI("CFG", "map", "True", path)
        Catch ex As Exception
            MsgBox("错误！！！！" & ex.ToString)
        End Try
    End Sub
    Private Sub set_reg()
        My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BnetIP", "tybh.vicp.net")
    End Sub


End Class
