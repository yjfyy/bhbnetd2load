
Public Class BHbnetD2Loader
    Private Sub BHbnetD2Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '读取ini文件
        Try
            Dim path As String
            path = Application.StartupPath + "\BHBnetD2Loader.ini"
            If GetINI("CFG", "local", "chi", path) = "chi" Then
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


    End Sub

    Private Sub BHbnetD2Loader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        savecfg()
    End Sub

    Private Sub Button_rund2_Click(sender As Object, e As EventArgs) Handles Button_rund2.Click
        savecfg()

    End Sub





    Private Sub runCommand()
        Dim d2loader As String
        Dim local As String
        Dim w As String
        Dim ns As String
        Dim high As String
        Dim skiptobnet As String
        Dim customVar As String

        If CheckBox_high.Checked Then
            high = "D2Loader-high.exe"
        Else
            high = "D2Loader-1.13c.exe"
        End If

    End Sub



    Private Sub savecfg()
        '写入ini文件
        Try
            Dim path As String
            path = Application.StartupPath + "\BHBnetD2Loader.ini"
            If RadioButton_chi.Checked = True Then
                WriteINI("CFG", "local", "chi", path)
            Else
                WriteINI("CFG", "local", "eng", path)
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


End Class
