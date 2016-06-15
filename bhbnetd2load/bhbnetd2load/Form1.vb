
Public Class Form_BHbnetD2Loader
    Public upsrc = "http://code.taobao.org/svn/BHBnet/trunk/updatafiles/"
    Public url = "\index.mht"
    '    Public frist_run = "Y"
    Private Sub BHbnetD2Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '读取ini文件
        load_ini()
        '设置注册表
        'set_reg()

        '更新autoupdata
        up_autoupdata()
        kongjianzhuangtai()
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

        '调用更新程序
        runautoupdata()
    End Sub

    Private Sub runCommand()
        Dim d2run_command As String
        Dim d2loader As String = “d2loader-1.13c.exe"
        Dim local As String
        Dim w As String
        Dim ns As String
        Dim skiptobnet As String
        Dim customVar As String
        Dim fix As String
        Dim map As String
        Dim dFile As New System.Net.WebClient

        '语言
        If RadioButton_chi.Checked Then
            local = " -locale chi"
        Else
            local = " -locale eng"
        End If

        '引导模式
        If RadioButton_load_d2.Checked Then
            d2loader = "diablo II.exe "
        End If
        If RadioButton_load_d2loader.Checked Then
            d2loader = "d2loader-1.13c.exe "
        End If
        If RadioButton_load_d2loader_high.Checked Then
            d2loader = "d2loader-high.exe "
        End If
        If RadioButton_load_PlugY.Checked Then
            d2loader = "plugy.exe "
        End If

        '游戏参数
        If CheckBox_w.Checked Then
            w = " -w"
        Else
            w = ""
        End If

        If CheckBox_ns.Checked Then
            ns = " -ns"
        Else
            ns = ""
        End If

        If CheckBox_skiptobnet.Checked Then
            skiptobnet = " -skiptobnet"
        Else
            skiptobnet = ""
        End If

        If CheckBox_hackmap.Checked Then
            map = " -pdir bh113map"
        Else
            map = ""
        End If

        '自定义命令
        customVar = TextBox_customVar.Text

        '固定命令
        fix = TextBox_command_fix.Text

        d2run_command = d2loader + local + w + ns + skiptobnet + map + " " + customVar + " " + fix

        If RadioButton_hackmap_cfg_plot.Checked Then
            '重命名D2HackMap-plot.cfg
            Try
                My.Computer.FileSystem.CopyFile(Application.StartupPath + "/bh113map/D2HackMap-plot.cfg", Application.StartupPath + "/bh113map/D2HackMap.cfg", True)
                'MsgBox("改为剧情")
            Catch ex As Exception

            End Try


        Else
            '重命名D2HackMap-fram.cfg

            Try
                My.Computer.FileSystem.CopyFile(Application.StartupPath + "/bh113map/D2HackMap-fram.cfg", Application.StartupPath + "/bh113map/D2HackMap.cfg", True)
                'MsgBox("改为fram")
            Catch ex As Exception

            End Try
        End If

        '修改分辨率写入注册表
        Dim D2RMRes As Integer
        If RadioButton_800x600.Checked = True Then
            D2RMRes = 13
        Else
            D2RMRes = 16
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "D2RMRes", D2RMRes)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "Resolution", 1)
        Try
            ' MsgBox(d2run_command)
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BnetIP", dFile.DownloadString("http://code.taobao.org/svn/BHBnet/trunk/ip/ip.txt"))
            Catch ex As Exception
                MsgBox（"获取战网ip失败，清重试"）
                Exit Sub
            End Try
            Shell(d2run_command, AppWinStyle.NormalFocus, False)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub save_ini()
        '写入ini文件


        Try
            Dim load_mode = "d2loader-1.13c.exe"
            Dim path As String
            path = Application.StartupPath + "\暗黑II BH战网.ini"

            WriteINI("cfg", "frist_run", "N", path)

            '语言
            If RadioButton_chi.Checked = True Then
                WriteINI("CFG", "locale", "chi", path)
            Else
                WriteINI("CFG", "locale", "eng", path)
            End If

            '启动模式
            If RadioButton_load_d2.Checked Then
                load_mode = "diablo II.exe"
            End If
            If RadioButton_load_d2loader.Checked Then
                load_mode = "d2loader-1.13c.exe"
            End If
            If RadioButton_load_d2loader_high.Checked Then
                load_mode = "D2Loader-high.exe"
            End If
            If RadioButton_load_PlugY.Checked Then
                load_mode = "plugy.exe"
            End If
            WriteINI("CFG", "load_mode", load_mode, path)

            '游戏参数
            WriteINI("CFG", "w", CheckBox_w.Checked.ToString, path)
            WriteINI("CFG", "ns", CheckBox_ns.Checked.ToString, path)
            WriteINI("CFG", "skiptobnet", CheckBox_skiptobnet.Checked.ToString, path)
            WriteINI("CFG", "map", CheckBox_hackmap.Checked.ToString, path)

            '分辨率
            If RadioButton_800x600.Checked = True Then
                WriteINI("CFG", "D2RMRes", "800X600", path)
            Else
                WriteINI("CFG", "D2RMRes", "1280X720", path)
            End If

            '插件选项
            If RadioButton_hackmap_cfg_fram.Checked = True Then
                WriteINI("CFG", "hackmap_cfg", "fram", path)
            Else
                WriteINI("CFG", "hackmap_cfg", "plot", path)
            End If

            '自定义参数
            WriteINI("CFG", "customVar", TextBox_customVar.Text, path)

            '固定参数
            WriteINI("cfg", "command_fix", " -direct -nofixaspect -nohide -txt", path)

            '更新源
            WriteINI("CFG", "upsrc", upsrc, path)
            WriteINI("CFG", "url", url, path)

        Catch ex As Exception
            MsgBox("参数没有保存成功，检查文件可写性，权限等")
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

    Private Sub load_ini()
        Try
            Dim path As String
            Dim load_mode
            Dim frist_run
            path = Application.StartupPath + "\暗黑II BH战网.ini"

            '第一次运行，修改兼容性。
            frist_run = GetINI("CFG", "frist_run", "Y", path)
            If frist_run = "Y" Then
                'MsgBox("首次运行“)
                '待增加。
            Else
                'MsgBox（”已经设置兼容性“）
            End If

            '语言
            If GetINI("CFG", "locale", "chi", path) = "chi" Then
                RadioButton_chi.Checked = True
            Else
                RadioButton_eng.Checked = True
            End If

            '启动模式
            load_mode = GetINI("CFG", "load_mode", "d2loader-1.13c.exe", path)
            Select Case load_mode
                Case "diablo II.exe"
                    RadioButton_load_d2.Checked = True
                Case "d2loader-1.13c.exe"
                    RadioButton_load_d2loader.Checked = True
                Case "plugy.exe"
                    RadioButton_load_PlugY.Checked = True
                Case Else
                    RadioButton_load_d2loader_high.Checked = True
            End Select

            '游戏参数
            CheckBox_w.Checked = GetINI("CFG", "w", "True", path)
            CheckBox_ns.Checked = GetINI("CFG", "ns", "False", path)
            CheckBox_skiptobnet.Checked = GetINI("CFG", "skiptobnet", "True", path)
            CheckBox_hackmap.Checked = GetINI("CFG", "hackmap", "True", path)

            '分辨率
            If GetINI("CFG", "D2RMRes", "800X600", path) = "800X600" Then
                RadioButton_800x600.Checked = True
            Else
                RadioButton_1280x720.Checked = True
            End If

            '插件选项
            If GetINI("CFG", "hackmap_cfg", "plot", path) = "plot" Then
                RadioButton_hackmap_cfg_plot.Checked = True
            Else
                RadioButton_hackmap_cfg_fram.Checked = True
            End If

            TextBox_customVar.Text = GetINI("CFG", "customVar", "", path)
            If TextBox_customVar.Text = "null" Then
                TextBox_customVar.Text = ""
            End If

            '固定参数
            TextBox_command_fix.Text = GetINI("cfg", "command_fix", "-direct -pdir bh113map -nofixaspect -nohide -txt", path)

            '更新源
            upsrc = GetINI("CFG", "upsrc", upsrc, path)
            url = GetINI("CFG", "url", url, path)

        Catch ex As Exception
            MsgBox("错误！！！！" & ex.ToString)
        End Try
    End Sub
    Private Sub set_reg()
        ' My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II")
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BnetIP", "tybh.vicp.net")
    End Sub
    Private Sub up_autoupdata()

        If My.Computer.FileSystem.FileExists("autoupdata.rar") Then
            Try
                My.Computer.FileSystem.DeleteFile("autoupdata.exe")
                My.Computer.FileSystem.RenameFile("autoupdata.rar", "autoupdata.exe")
            Catch ex As Exception

            End Try
        End If

        If My.Computer.FileSystem.FileExists("autoupdata.exe.rar") Then
            Try
                My.Computer.FileSystem.DeleteFile("autoupdata.exe")
                My.Computer.FileSystem.RenameFile("autoupdata.exe.rar", "autoupdata.exe")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            'MsgBox(Application.StartupPath + url)
            WebBrowser.Url = New Uri(Application.StartupPath + url)
        Catch ex As Exception

        End Try

        Try
            check_ver()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub check_ver()
        Dim dFile As New System.Net.WebClient
        Dim r_version = "0"
        Dim l_version = "0"

        Try
            r_version = dFile.DownloadString(upsrc + "version.txt")
            Label_r_version.Text = r_version
        Catch ex As Exception
            Label_r_version.Text = "检测超时"
        End Try

        Try
            l_version = My.Computer.FileSystem.ReadAllText(".\version.txt")
            Label_l_version.Text = l_version
        Catch ex As Exception
            If l_version = "0" Then
                Label_l_version.Text = "无法获得本地版本"
                MsgBox("无法获得本地版本,推荐修复游戏")
                Button_rund2.Text = "请修复游戏"
                Exit Sub
            End If
        End Try


        If Label_r_version.Text = "检测超时" Or Label_r_version.Text = Label_l_version.Text Then
            Button_rund2.Text = "运行游戏"
        Else
            Button_rund2.Text = "更新游戏"
        End If
        Button_rund2.Enabled = True
    End Sub

    Private Sub kongjianzhuangtai()
        If RadioButton_load_d2.Checked Then
            CheckBox_hackmap.Enabled = False
            CheckBox_hackmap.Checked = False
        Else
            CheckBox_hackmap.Enabled = True
            'CheckBox_hackmap.Checked = True
        End If

        If CheckBox_hackmap.Checked = False Then
            GroupBox_hackmap_cfg.Enabled = False
            'RadioButton_hackmap_cfg_fram.Checked = False
            'RadioButton_hackmap_cfg_plot.Checked = False
        Else
            GroupBox_hackmap_cfg.Enabled = True
            'RadioButton_hackmap_cfg_plot.Checked = True
        End If
    End Sub

    Private Sub RadioButton_load_d2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_load_d2.CheckedChanged
        kongjianzhuangtai()

    End Sub

    Private Sub CheckBox_hackmap_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_hackmap.CheckedChanged
        kongjianzhuangtai()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label_l_version_Click(sender As Object, e As EventArgs) Handles Label_l_version.Click

    End Sub

    Private Sub Label_r_version_Click(sender As Object, e As EventArgs) Handles Label_r_version.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
