Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Remoting.Channels
Imports System.Text

Public Class Form1
    Dim l_version
    Dim r_version
    Dim up_root = "http://butwhy.vicp.net:82/tuzi_updata/Diablo_II/"
    Dim app_path As String = Application.StartupPath()

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", app_path & "\D2Loader-1.13c.exe", "~ WINXPSP3")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", app_path & "\D2VidTst.exe", "~ DWM8And16BitMitigation RUNASADMIN WIN7RTM")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "Resolution", "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "LVL_REST", "666")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "MAX_PLAYER", "8")
        loadcfg()
        deltemp()
        Label_status.Text = "正在检测更新......"
        BackgroundWorker_check_ver.RunWorkerAsync()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        savecfg()
    End Sub

    Private Sub BackgroundWorker_check_ver_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker_check_ver.DoWork
        Dim dFile As New System.Net.WebClient
        Dim upUri_version As New Uri(up_root & "version.txt")
        Try
            r_version = dFile.DownloadString(upUri_version)
        Catch ex As Exception
            r_version = "0"
        End Try
        'MsgBox(upUri_version.ToString)
    End Sub

    Private Sub BackgroundWorker_check_ver_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_check_ver.RunWorkerCompleted
        Label_r_version.Text = r_version
        l_version = Label_l_version.Text
        If r_version = "0" Then
            Label_status.Text = "检测失败"

        Else
            If l_version <> r_version Then
                Label_status.Text = "有新版,请更新。"
                Button_run_game.Text = "更新"

            Else
                Label_status.Text = "已是最新版!"
                Button_run_game.Text = "运行游戏"
            End If
        End If
        Button_run_game.Enabled = True
    End Sub

    Private Sub Button_run_game_Click(sender As Object, e As EventArgs) Handles Button_run_game.Click
        savecfg()
        If Button_run_game.Text = "更新" Then
            Up_autoupdata()
        Else
            Dim canshu As String
            If CheckBox_w.Checked = True Then
                canshu = "-locale chi -w -skiptobnet -pdir bh113map -direct -nofixaspect -nohide -txt"
            Else
                canshu = "-locale chi -skiptobnet -pdir bh113map -direct -nofixaspect -nohide -txt"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BnetIP", "butwhy.vicp.net")
            Dim p = New System.Diagnostics.Process()
            p.StartInfo.WorkingDirectory = app_path
            p.StartInfo.FileName = "D2Loader-1.13c.exe"
            p.StartInfo.Arguments = canshu
            p.Start()
            'Shell("d2loader-1.13c.exe -locale chi -w")
        End If


    End Sub

    Private Sub Up_autoupdata()
        Button_run_game.Enabled = False
        Dim dFile As New System.Net.WebClient
        AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Up_autoupdata1
        Label_status.Text = "正在下载..."
        dFile.DownloadFileAsync(New Uri(up_root & "up_data.exe"), "up_data.exe")

    End Sub
    Private Sub Up_autoupdata1()

        Dim dFile As New System.Net.WebClient
        'AddHandler dFile.DownloadProgressChanged, AddressOf ShowDownProgress
        AddHandler dFile.DownloadFileCompleted, AddressOf Wanchen

        dFile.DownloadFileAsync(New Uri(up_root & "up_com.bat"), "up_com.bat")

    End Sub
    Sub Wanchen(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label_status.Text = "下载完成"
        Try
            Label_status.Text = "升级完成后将自动重启。"
            Process.Start("up_com.bat")
            Me.Close()
        Catch ex As Exception
            MsgBox（"升级错误，请手动执行 up_data.exe",, "提示")
        End Try
    End Sub
    Private Sub ShowDownProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Invoke(New Action(Of Integer)(Sub(i) ProgressBar1.Value = i), e.ProgressPercentage)
    End Sub

    Private Sub Button_D2VidTst_Click(sender As Object, e As EventArgs) Handles Button_D2VidTst.Click
        Dim p = New System.Diagnostics.Process()
        p.StartInfo.WorkingDirectory = app_path
        p.StartInfo.FileName = "D2VidTst.exe"
        p.Start()
    End Sub
    Private Sub savecfg()
        If CheckBox_w.Checked = True Then
            WriteINI("通用", "windows", "1", app_path & "/bhd2cfg.ini")
        Else
            WriteINI("通用", "windows", "0", app_path & "/bhd2cfg.ini")
        End If
    End Sub
    Private Sub loadcfg()
        If GetINI("通用", "windows", "1", app_path & "/bhd2cfg.ini") = "1" Then
            CheckBox_w.Checked = 1
        Else
            CheckBox_w.Checked = 0
        End If
    End Sub
    Private Sub deltemp()
        Try
            My.Computer.FileSystem.DeleteFile("up_com.bat")
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile("up_data.exe")
        Catch ex As Exception
        End Try
    End Sub


End Class
