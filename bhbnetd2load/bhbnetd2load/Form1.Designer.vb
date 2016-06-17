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
        Me.CheckBox_w = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ns = New System.Windows.Forms.CheckBox()
        Me.CheckBox_skiptobnet = New System.Windows.Forms.CheckBox()
        Me.GroupBox_locale = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_eng = New System.Windows.Forms.RadioButton()
        Me.RadioButton_chi = New System.Windows.Forms.RadioButton()
        Me.GroupBox_canshu = New System.Windows.Forms.GroupBox()
        Me.CheckBox_hackmap = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox_hackmap_cfg = New System.Windows.Forms.GroupBox()
        Me.RadioButton_hackmap_cfg_fram = New System.Windows.Forms.RadioButton()
        Me.RadioButton_hackmap_cfg_plot = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_load_PlugY = New System.Windows.Forms.RadioButton()
        Me.RadioButton_load_d2loader_high = New System.Windows.Forms.RadioButton()
        Me.RadioButton_load_d2loader = New System.Windows.Forms.RadioButton()
        Me.RadioButton_load_d2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_1280x720 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_800x600 = New System.Windows.Forms.RadioButton()
        Me.GroupBox_locale.SuspendLayout()
        Me.GroupBox_canshu.SuspendLayout()
        Me.GroupBox_zidingyicanshu.SuspendLayout()
        Me.GroupBox_hackmap_cfg.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MaximumSize = New System.Drawing.Size(880, 530)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(880, 530)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScrollBarsEnabled = False
        Me.WebBrowser.Size = New System.Drawing.Size(880, 530)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.TabStop = False
        Me.WebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser.WebBrowserShortcutsEnabled = False
        '
        'Button_rund2
        '
        Me.Button_rund2.Enabled = False
        Me.Button_rund2.Location = New System.Drawing.Point(781, 553)
        Me.Button_rund2.Name = "Button_rund2"
        Me.Button_rund2.Size = New System.Drawing.Size(86, 23)
        Me.Button_rund2.TabIndex = 1
        Me.Button_rund2.Text = "检测更新中"
        Me.Button_rund2.UseVisualStyleBackColor = True
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
        Me.CheckBox_skiptobnet.Location = New System.Drawing.Point(114, 20)
        Me.CheckBox_skiptobnet.Name = "CheckBox_skiptobnet"
        Me.CheckBox_skiptobnet.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox_skiptobnet.TabIndex = 8
        Me.CheckBox_skiptobnet.Text = "直接登录Bnet"
        Me.CheckBox_skiptobnet.UseVisualStyleBackColor = True
        '
        'GroupBox_locale
        '
        Me.GroupBox_locale.Controls.Add(Me.RadioButton1)
        Me.GroupBox_locale.Controls.Add(Me.RadioButton_eng)
        Me.GroupBox_locale.Controls.Add(Me.RadioButton_chi)
        Me.GroupBox_locale.Location = New System.Drawing.Point(12, 536)
        Me.GroupBox_locale.Name = "GroupBox_locale"
        Me.GroupBox_locale.Size = New System.Drawing.Size(215, 49)
        Me.GroupBox_locale.TabIndex = 9
        Me.GroupBox_locale.TabStop = False
        Me.GroupBox_locale.Text = "语言"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(136, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "繁体中文"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        Me.RadioButton_chi.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_chi.TabIndex = 0
        Me.RadioButton_chi.Text = "简体中文"
        Me.RadioButton_chi.UseVisualStyleBackColor = True
        '
        'GroupBox_canshu
        '
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_hackmap)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_skiptobnet)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_ns)
        Me.GroupBox_canshu.Controls.Add(Me.CheckBox_w)
        Me.GroupBox_canshu.Location = New System.Drawing.Point(18, 591)
        Me.GroupBox_canshu.Name = "GroupBox_canshu"
        Me.GroupBox_canshu.Size = New System.Drawing.Size(267, 48)
        Me.GroupBox_canshu.TabIndex = 10
        Me.GroupBox_canshu.TabStop = False
        Me.GroupBox_canshu.Text = "游戏参数"
        '
        'CheckBox_hackmap
        '
        Me.CheckBox_hackmap.AutoSize = True
        Me.CheckBox_hackmap.Location = New System.Drawing.Point(217, 21)
        Me.CheckBox_hackmap.Name = "CheckBox_hackmap"
        Me.CheckBox_hackmap.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_hackmap.TabIndex = 9
        Me.CheckBox_hackmap.Text = "插件"
        Me.CheckBox_hackmap.UseVisualStyleBackColor = True
        '
        'GroupBox_zidingyicanshu
        '
        Me.GroupBox_zidingyicanshu.Controls.Add(Me.TextBox_customVar)
        Me.GroupBox_zidingyicanshu.Location = New System.Drawing.Point(475, 591)
        Me.GroupBox_zidingyicanshu.Name = "GroupBox_zidingyicanshu"
        Me.GroupBox_zidingyicanshu.Size = New System.Drawing.Size(94, 48)
        Me.GroupBox_zidingyicanshu.TabIndex = 11
        Me.GroupBox_zidingyicanshu.TabStop = False
        Me.GroupBox_zidingyicanshu.Text = "自定义参数"
        '
        'TextBox_customVar
        '
        Me.TextBox_customVar.Location = New System.Drawing.Point(6, 20)
        Me.TextBox_customVar.Name = "TextBox_customVar"
        Me.TextBox_customVar.Size = New System.Drawing.Size(77, 21)
        Me.TextBox_customVar.TabIndex = 1
        '
        'Button_D2VidTst
        '
        Me.Button_D2VidTst.Location = New System.Drawing.Point(6, 18)
        Me.Button_D2VidTst.Name = "Button_D2VidTst"
        Me.Button_D2VidTst.Size = New System.Drawing.Size(75, 23)
        Me.Button_D2VidTst.TabIndex = 2
        Me.Button_D2VidTst.Text = "测试显卡"
        Me.Button_D2VidTst.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(795, 625)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "引导器版本: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.11 by yjfyy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(779, 580)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "本地版本:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(779, 599)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "远端版本:"
        '
        'Label_l_version
        '
        Me.Label_l_version.AutoSize = True
        Me.Label_l_version.Location = New System.Drawing.Point(843, 580)
        Me.Label_l_version.Name = "Label_l_version"
        Me.Label_l_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_l_version.TabIndex = 16
        Me.Label_l_version.Text = "0"
        '
        'Label_r_version
        '
        Me.Label_r_version.AutoSize = True
        Me.Label_r_version.Location = New System.Drawing.Point(843, 599)
        Me.Label_r_version.Name = "Label_r_version"
        Me.Label_r_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_r_version.TabIndex = 17
        Me.Label_r_version.Text = "0"
        '
        'Button_fixgame
        '
        Me.Button_fixgame.Location = New System.Drawing.Point(6, 60)
        Me.Button_fixgame.Name = "Button_fixgame"
        Me.Button_fixgame.Size = New System.Drawing.Size(75, 23)
        Me.Button_fixgame.TabIndex = 18
        Me.Button_fixgame.Text = "修复游戏"
        Me.Button_fixgame.UseVisualStyleBackColor = True
        '
        'TextBox_command_fix
        '
        Me.TextBox_command_fix.Location = New System.Drawing.Point(0, 519)
        Me.TextBox_command_fix.Name = "TextBox_command_fix"
        Me.TextBox_command_fix.Size = New System.Drawing.Size(111, 21)
        Me.TextBox_command_fix.TabIndex = 19
        Me.TextBox_command_fix.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox_hackmap_cfg
        '
        Me.GroupBox_hackmap_cfg.Controls.Add(Me.RadioButton_hackmap_cfg_fram)
        Me.GroupBox_hackmap_cfg.Controls.Add(Me.RadioButton_hackmap_cfg_plot)
        Me.GroupBox_hackmap_cfg.Location = New System.Drawing.Point(291, 591)
        Me.GroupBox_hackmap_cfg.Name = "GroupBox_hackmap_cfg"
        Me.GroupBox_hackmap_cfg.Size = New System.Drawing.Size(178, 48)
        Me.GroupBox_hackmap_cfg.TabIndex = 2
        Me.GroupBox_hackmap_cfg.TabStop = False
        Me.GroupBox_hackmap_cfg.Text = "插件选项"
        '
        'RadioButton_hackmap_cfg_fram
        '
        Me.RadioButton_hackmap_cfg_fram.AutoSize = True
        Me.RadioButton_hackmap_cfg_fram.Location = New System.Drawing.Point(92, 17)
        Me.RadioButton_hackmap_cfg_fram.Name = "RadioButton_hackmap_cfg_fram"
        Me.RadioButton_hackmap_cfg_fram.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton_hackmap_cfg_fram.TabIndex = 1
        Me.RadioButton_hackmap_cfg_fram.TabStop = True
        Me.RadioButton_hackmap_cfg_fram.Text = "我要刷刷刷"
        Me.RadioButton_hackmap_cfg_fram.UseVisualStyleBackColor = True
        '
        'RadioButton_hackmap_cfg_plot
        '
        Me.RadioButton_hackmap_cfg_plot.AutoSize = True
        Me.RadioButton_hackmap_cfg_plot.Location = New System.Drawing.Point(3, 17)
        Me.RadioButton_hackmap_cfg_plot.Name = "RadioButton_hackmap_cfg_plot"
        Me.RadioButton_hackmap_cfg_plot.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton_hackmap_cfg_plot.TabIndex = 0
        Me.RadioButton_hackmap_cfg_plot.TabStop = True
        Me.RadioButton_hackmap_cfg_plot.Text = "我要玩剧情"
        Me.RadioButton_hackmap_cfg_plot.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_D2VidTst)
        Me.GroupBox2.Controls.Add(Me.Button_fixgame)
        Me.GroupBox2.Location = New System.Drawing.Point(675, 540)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(94, 99)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "辅助工具"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton_load_PlugY)
        Me.GroupBox3.Controls.Add(Me.RadioButton_load_d2loader_high)
        Me.GroupBox3.Controls.Add(Me.RadioButton_load_d2loader)
        Me.GroupBox3.Controls.Add(Me.RadioButton_load_d2)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 537)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 48)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "启动模式"
        '
        'RadioButton_load_PlugY
        '
        Me.RadioButton_load_PlugY.AutoSize = True
        Me.RadioButton_load_PlugY.Enabled = False
        Me.RadioButton_load_PlugY.Location = New System.Drawing.Point(229, 21)
        Me.RadioButton_load_PlugY.Name = "RadioButton_load_PlugY"
        Me.RadioButton_load_PlugY.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton_load_PlugY.TabIndex = 3
        Me.RadioButton_load_PlugY.TabStop = True
        Me.RadioButton_load_PlugY.Text = "单机大箱子"
        Me.RadioButton_load_PlugY.UseVisualStyleBackColor = True
        '
        'RadioButton_load_d2loader_high
        '
        Me.RadioButton_load_d2loader_high.AutoSize = True
        Me.RadioButton_load_d2loader_high.Location = New System.Drawing.Point(151, 21)
        Me.RadioButton_load_d2loader_high.Name = "RadioButton_load_d2loader_high"
        Me.RadioButton_load_d2loader_high.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_load_d2loader_high.TabIndex = 2
        Me.RadioButton_load_d2loader_high.TabStop = True
        Me.RadioButton_load_d2loader_high.Text = "高分辨率"
        Me.RadioButton_load_d2loader_high.UseVisualStyleBackColor = True
        '
        'RadioButton_load_d2loader
        '
        Me.RadioButton_load_d2loader.AutoSize = True
        Me.RadioButton_load_d2loader.Location = New System.Drawing.Point(73, 21)
        Me.RadioButton_load_d2loader.Name = "RadioButton_load_d2loader"
        Me.RadioButton_load_d2loader.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_load_d2loader.TabIndex = 1
        Me.RadioButton_load_d2loader.TabStop = True
        Me.RadioButton_load_d2loader.Text = "D2Loader"
        Me.RadioButton_load_d2loader.UseVisualStyleBackColor = True
        '
        'RadioButton_load_d2
        '
        Me.RadioButton_load_d2.AutoSize = True
        Me.RadioButton_load_d2.Location = New System.Drawing.Point(7, 21)
        Me.RadioButton_load_d2.Name = "RadioButton_load_d2"
        Me.RadioButton_load_d2.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton_load_d2.TabIndex = 0
        Me.RadioButton_load_d2.TabStop = True
        Me.RadioButton_load_d2.Text = "D2原版"
        Me.RadioButton_load_d2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_1280x720)
        Me.GroupBox1.Controls.Add(Me.RadioButton_800x600)
        Me.GroupBox1.Location = New System.Drawing.Point(575, 540)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(94, 99)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "分辨率"
        '
        'RadioButton_1280x720
        '
        Me.RadioButton_1280x720.AutoSize = True
        Me.RadioButton_1280x720.Checked = True
        Me.RadioButton_1280x720.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_1280x720.Name = "RadioButton_1280x720"
        Me.RadioButton_1280x720.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton_1280x720.TabIndex = 1
        Me.RadioButton_1280x720.TabStop = True
        Me.RadioButton_1280x720.Text = "1280X720"
        Me.RadioButton_1280x720.UseVisualStyleBackColor = True
        '
        'RadioButton_800x600
        '
        Me.RadioButton_800x600.AutoSize = True
        Me.RadioButton_800x600.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_800x600.Name = "RadioButton_800x600"
        Me.RadioButton_800x600.Size = New System.Drawing.Size(65, 16)
        Me.RadioButton_800x600.TabIndex = 0
        Me.RadioButton_800x600.Text = "800X600"
        Me.RadioButton_800x600.UseVisualStyleBackColor = True
        '
        'Form_BHbnetD2Loader
        '
        Me.AcceptButton = Me.Button_rund2
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 652)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_hackmap_cfg)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox_zidingyicanshu)
        Me.Controls.Add(Me.GroupBox_canshu)
        Me.Controls.Add(Me.GroupBox_locale)
        Me.Controls.Add(Me.Button_rund2)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.TextBox_command_fix)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 690)
        Me.MinimumSize = New System.Drawing.Size(900, 690)
        Me.Name = "Form_BHbnetD2Loader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BHbnetD2Loader"
        Me.GroupBox_locale.ResumeLayout(False)
        Me.GroupBox_locale.PerformLayout()
        Me.GroupBox_canshu.ResumeLayout(False)
        Me.GroupBox_canshu.PerformLayout()
        Me.GroupBox_zidingyicanshu.ResumeLayout(False)
        Me.GroupBox_zidingyicanshu.PerformLayout()
        Me.GroupBox_hackmap_cfg.ResumeLayout(False)
        Me.GroupBox_hackmap_cfg.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents Button_rund2 As Button
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox_hackmap_cfg As GroupBox
    Friend WithEvents RadioButton_hackmap_cfg_fram As RadioButton
    Friend WithEvents RadioButton_hackmap_cfg_plot As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton_load_PlugY As RadioButton
    Friend WithEvents RadioButton_load_d2loader_high As RadioButton
    Friend WithEvents RadioButton_load_d2loader As RadioButton
    Friend WithEvents RadioButton_load_d2 As RadioButton
    Friend WithEvents CheckBox_hackmap As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_1280x720 As RadioButton
    Friend WithEvents RadioButton_800x600 As RadioButton
End Class
