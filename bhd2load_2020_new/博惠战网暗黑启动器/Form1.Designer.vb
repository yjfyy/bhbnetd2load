<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker_check_ver = New System.ComponentModel.BackgroundWorker()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.Label_l_version = New System.Windows.Forms.Label()
        Me.Label_r_version = New System.Windows.Forms.Label()
        Me.Button_run_game = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_w = New System.Windows.Forms.CheckBox()
        Me.Button_D2VidTst = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackgroundWorker_check_ver
        '
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.Location = New System.Drawing.Point(12, 135)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(29, 12)
        Me.Label_status.TabIndex = 0
        Me.Label_status.Text = "状态"
        '
        'Label_l_version
        '
        Me.Label_l_version.AutoSize = True
        Me.Label_l_version.Location = New System.Drawing.Point(78, 12)
        Me.Label_l_version.Name = "Label_l_version"
        Me.Label_l_version.Size = New System.Drawing.Size(23, 12)
        Me.Label_l_version.TabIndex = 1
        Me.Label_l_version.Text = "0.1"
        '
        'Label_r_version
        '
        Me.Label_r_version.AutoSize = True
        Me.Label_r_version.Location = New System.Drawing.Point(77, 40)
        Me.Label_r_version.Name = "Label_r_version"
        Me.Label_r_version.Size = New System.Drawing.Size(11, 12)
        Me.Label_r_version.TabIndex = 2
        Me.Label_r_version.Text = "0"
        '
        'Button_run_game
        '
        Me.Button_run_game.Enabled = False
        Me.Button_run_game.Location = New System.Drawing.Point(205, 7)
        Me.Button_run_game.Name = "Button_run_game"
        Me.Button_run_game.Size = New System.Drawing.Size(75, 23)
        Me.Button_run_game.TabIndex = 3
        Me.Button_run_game.Text = "启动游戏"
        Me.Button_run_game.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "本地版本:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "远端版本:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 103)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(252, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "By 疯掉的兔子"
        '
        'CheckBox_w
        '
        Me.CheckBox_w.AutoSize = True
        Me.CheckBox_w.Location = New System.Drawing.Point(127, 11)
        Me.CheckBox_w.Name = "CheckBox_w"
        Me.CheckBox_w.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_w.TabIndex = 9
        Me.CheckBox_w.Text = "窗口模式"
        Me.CheckBox_w.UseVisualStyleBackColor = True
        '
        'Button_D2VidTst
        '
        Me.Button_D2VidTst.Location = New System.Drawing.Point(205, 72)
        Me.Button_D2VidTst.Name = "Button_D2VidTst"
        Me.Button_D2VidTst.Size = New System.Drawing.Size(75, 23)
        Me.Button_D2VidTst.TabIndex = 10
        Me.Button_D2VidTst.Text = "检测显卡"
        Me.Button_D2VidTst.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "首次启动请检测显卡"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 160)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_D2VidTst)
        Me.Controls.Add(Me.CheckBox_w)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_run_game)
        Me.Controls.Add(Me.Label_r_version)
        Me.Controls.Add(Me.Label_l_version)
        Me.Controls.Add(Me.Label_status)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "博惠暗黑2战网启动器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker_check_ver As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label_status As Label
    Friend WithEvents Label_l_version As Label
    Friend WithEvents Label_r_version As Label
    Friend WithEvents Button_run_game As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_w As CheckBox
    Friend WithEvents Button_D2VidTst As Button
    Friend WithEvents Label2 As Label
End Class
