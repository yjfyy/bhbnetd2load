<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_BHbnetD2Loader
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BHbnetD2Loader))
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.Button_rund2 = New System.Windows.Forms.Button()
        Me.CheckBox_high = New System.Windows.Forms.CheckBox()
        Me.CheckBox_w = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ns = New System.Windows.Forms.CheckBox()
        Me.CheckBox_skiptobnet = New System.Windows.Forms.CheckBox()
        Me.GroupBox_locale = New System.Windows.Forms.GroupBox()
        Me.RadioButton_eng = New System.Windows.Forms.RadioButton()
        Me.RadioButton_chi = New System.Windows.Forms.RadioButton()
        Me.GroupBox_canshu = New System.Windows.Forms.GroupBox()
        Me.CheckBox_map = New System.Windows.Forms.CheckBox()
        Me.GroupBox_zidingyicanshu = New System.Windows.Forms.GroupBox()
        Me.TextBox_customVar = New System.Windows.Forms.TextBox()
        Me.Button_D2VidTst = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_l_version = New System.Windows.Forms.Label()
        Me.Label_r_version = New System.Windows.Forms.Label()
        Me.Button_fixgame = New System.Windows.Forms.Button()
        Me.TextBox_command_fix = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_locale.SuspendLayout()
        Me.GroupBox_canshu.SuspendLayout()
        Me.GroupBox_zidingyicanshu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MaximumSize = New System.Drawing.Size(884, 540)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(884, 540)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(884, 540)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.TabStop = False
        Me.WebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser.WebBrowserShortcutsEnabled = False
        '
        'Button_rund2
        '
        Me.Button_rund2.Enabled = False
        Me.Button_rund2.Location = New System.Drawing.Point(402, 608)
        Me.Button_rund2.Name = "Button_rund2"
        Me.Button_rund2.Size = New System.Drawing.Size(86, 23)
        Me.Button_rund2.TabIndex = 1
        Me.Button_rund2.Text = "检测更新中"
        Me.Button_rund2.UseVisualStyleBackColor = True
        '
        'CheckBox_high
        '
        Me.CheckBox_high.AutoSize = True
        Me.CheckBox_high.Location = New System.Drawing.Point(114, 20)
        Me.CheckBox_high.Name = "CheckBox_high"
        Me.CheckBox_high.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_high.TabIndex = 5
        Me.CheckBox_high.Text = "高清"
        Me.CheckBox_high.UseVisualStyleBackColor = True
        '
        'CheckBox_w
        '
        Me.CheckBox_w.AutoSize = True
        Me.CheckBox_w.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox_w.Name = "CheckBox_w"
        Me.CheckBox_w.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_w.TabIndex = 6
        Me.CheckBox_w.Text = "窗口"
        Me.CheckBox_w.UseVisualStyleBackColor = True
        '
        'CheckBox_ns
        '
        Me.CheckBox_ns.AutoSize = True
        Me.CheckBox_ns.Location = New System.Drawing.Point(60, 20)
        Me.CheckBox_ns.Name = "CheckBox_ns"
        Me.CheckBox_ns.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_ns.TabIndex = 7
        Me.CheckBox_ns.Text = "无声"
        Me.CheckBox_ns.UseVisualStyleBackColor = True
        '
        'CheckBox_skiptobnet
        '
        Me.CheckBox_skiptobnet.AutoSize = True
        Me.CheckBox_skiptobnet.Location = New System.Drawing.Point(168, 20)
        Me.CheckBox_skiptobnet.Name = "CheckBox_skiptobnet"
        Me.CheckBox_skiptobnet.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox_skiptobnet.TabIndex = 8
        Me.CheckBox_skiptobnet.Text = "直接登录Bnet"
        Me.CheckBox_skiptobnet.UseVisualStyleBackColor = True
        '
        'GroupBox_locale
        '
        Me.GroupBox_locale.Controls.Add(Me.RadioButton_eng)
        Me.GroupBox_locale.Controls.Add(Me.RadioButton_chi)
        Me.GroupBox_locale.Location = New System.Drawing.Point(12, 550)
        Me.GroupBox_locale.Name = "GroupBox_locale"
        Me.GroupBox_locale.Size = New System.Drawing.Size(111, 52)
        Me.GroupBox_locale.TabIndex = 9
        Me.GroupBox_locale.TabStop = False
        Me.GroupBox_locale.Text = "语言"
        '
        'RadioButton_eng
        '
        Me.RadioButton_eng.AutoSize = True
        Me.RadioButton_eng.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_eng.Name = "RadioButton_eng"
        Me.RadioButton_eng.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_eng.TabIndex = 1
        Me.RadioButton_eng.Text = "英文"
        Me.RadioButton_eng.UseVisualStyleBackColor = True
        '
        'RadioButton_chi
        '
        Me.RadioButton_chi.AutoSize = True
        Me.RadioButton_chi.Location = New System.Drawing.Point(59, 20)
        Me.RadioButton_chi.Name = "RadioButton_chi"
        Me.RadioButton_chi.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_chi.TabIndex = 0
        Me.RadioButton_chi.Text = "中文"
        Me.RadioButton_chi.UseVisualStyleBackColor = True
        '
        'GroupBox_canshu
        '
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_map)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_skiptobnet)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_ns)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_high)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_w)
        Me.GroupBox_canshu.Location = New System.Drawing.Point(129, 550)
        Me.GroupBox_canshu.Name = "GroupBox_canshu"
        Me.GroupBox_canshu.Size = New System.Drawing.Size(321, 52)
        Me.GroupBox_canshu.TabIndex = 10
        Me.GroupBox_canshu.TabStop = False
        Me.GroupBox_canshu.Text = "参数"
        '
        'CheckBox_map
        '
        Me.CheckBox_map.AutoSize = True
        Me.CheckBox_map.Location = New System.Drawing.Point(270, 20)
        Me.CheckBox_map.Name = "CheckBox_map"
        Me.CheckBox_map.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_map.TabIndex = 9
        Me.CheckBox_map.Text = "插件"
        Me.CheckBox_map.UseVisualStyleBackColor = True
        '
        'GroupBox_zidingyicanshu
        '
        Me.GroupBox_zidingyicanshu.Controls.Add(Me.TextBox_customVar)
        Me.GroupBox_zidingyicanshu.Location = New System.Drawing.Point(456, 550)
        Me.GroupBox_zidingyicanshu.Name = "GroupBox_zidingyicanshu"
        Me.GroupBox_zidingyicanshu.Size = New System.Drawing.Size(207, 52)
        Me.GroupBox_zidingyicanshu.TabIndex = 11
        Me.GroupBox_zidingyicanshu.TabStop = False
        Me.GroupBox_zidingyicanshu.Text = "自定义参数"
        '
        'TextBox_customVar
        '
        Me.TextBox_customVar.Location = New System.Drawing.Point(6, 18)
        Me.TextBox_customVar.Name = "TextBox_customVar"
        Me.TextBox_customVar.Size = New System.Drawing.Size(195, 21)
        Me.TextBox_customVar.TabIndex = 1
        '
        'Button_D2VidTst
        '
        Me.Button_D2VidTst.Location = New System.Drawing.Point(669, 567)
        Me.Button_D2VidTst.Name = "Button_D2VidTst"
        Me.Button_D2VidTst.Size = New System.Drawing.Size(75, 23)
        Me.Button_D2VidTst.TabIndex = 2
        Me.Button_D2VidTst.Text = "测试显卡"
        Me.Button_D2VidTst.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(771, 651)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ver 0.9 by yjfyy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 646)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "本地版本:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(475, 646)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "远端版本:"
        '
        'Label_l_version
        '
        Me.Label_l_version.AutoSize = True
        Me.Label_l_version.Location = New System.Drawing.Point(400, 646)
        Me.Label_l_version.Name = "Label_l_version"
        Me.Label_l_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_l_version.TabIndex = 16
        Me.Label_l_version.Text = "0"
        '
        'Label_r_version
        '
        Me.Label_r_version.AutoSize = True
        Me.Label_r_version.Location = New System.Drawing.Point(540, 646)
        Me.Label_r_version.Name = "Label_r_version"
        Me.Label_r_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_r_version.TabIndex = 17
        Me.Label_r_version.Text = "0"
        '
        'Button_fixgame
        '
        Me.Button_fixgame.Location = New System.Drawing.Point(750, 567)
        Me.Button_fixgame.Name = "Button_fixgame"
        Me.Button_fixgame.Size = New System.Drawing.Size(75, 23)
        Me.Button_fixgame.TabIndex = 18
        Me.Button_fixgame.Text = "修复游戏"
        Me.Button_fixgame.UseVisualStyleBackColor = True
        '
        'TextBox_command_fix
        '
        Me.TextBox_command_fix.Location = New System.Drawing.Point(12, 639)
        Me.TextBox_command_fix.Name = "TextBox_command_fix"
        Me.TextBox_command_fix.Size = New System.Drawing.Size(267, 21)
        Me.TextBox_command_fix.TabIndex = 19
        Me.TextBox_command_fix.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Form_BHbnetD2Loader
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 672)
        Me.Controls.Add(Me.TextBox_command_fix)
        Me.Controls.Add(Me.Button_fixgame)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_D2VidTst)
        Me.Controls.Add(Me.GroupBox_zidingyicanshu)
        Me.Controls.Add(Me.GroupBox_canshu)
        Me.Controls.Add(Me.GroupBox_locale)
        Me.Controls.Add(Me.Button_rund2)
        Me.Controls.Add(Me.WebBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 710)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 710)
        Me.Name = "Form_BHbnetD2Loader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BHbnetD2Loader"
        Me.GroupBox_locale.ResumeLayout(False)
        Me.GroupBox_locale.PerformLayout()
        Me.GroupBox_canshu.ResumeLayout(False)
        Me.GroupBox_canshu.PerformLayout()
        Me.GroupBox_zidingyicanshu.ResumeLayout(False)
        Me.GroupBox_zidingyicanshu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents Button_rund2 As Button
    Friend WithEvents CheckBox_high As CheckBox
    Friend WithEvents CheckBox_w As CheckBox
    Friend WithEvents CheckBox_ns As CheckBox
    Friend WithEvents CheckBox_skiptobnet As CheckBox
    Friend WithEvents GroupBox_locale As GroupBox
    Friend WithEvents RadioButton_eng As RadioButton
    Friend WithEvents RadioButton_chi As RadioButton
    Friend WithEvents GroupBox_canshu As GroupBox
    Friend WithEvents GroupBox_zidingyicanshu As GroupBox
    Friend WithEvents TextBox_customVar As TextBox
    Friend WithEvents Button_D2VidTst As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_l_version As Label
    Friend WithEvents Label_r_version As Label
    Friend WithEvents Button_fixgame As Button
    Friend WithEvents TextBox_command_fix As TextBox
    Friend WithEvents CheckBox_map As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
