Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml

Public Class Form1
    Inherits Form
    Private WithEvents backgroundWorker1 As BackgroundWorker
    Private WithEvents dowloadButton As Button
    Private document As XmlDocument = Nothing


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dowloadButton_Click(
    ByVal sender As Object,
    ByVal e As EventArgs) _
    Handles dowloadButton.Click

        ' Start the download operation in the background.
        Me.backgroundWorker1.RunWorkerAsync()

        ' Disable the button for the duration of the download.
        Me.dowloadButton.Enabled = False

        ' Wait for the BackgroundWorker to finish the download.
        While Me.backgroundWorker1.IsBusy
            ' Keep UI messages moving, so the form remains 
            ' responsive during the asynchronous operation.
            Application.DoEvents()
        End While

        ' The download is done, so enable the button.
        Me.dowloadButton.Enabled = True
    End Sub

    Private Sub backgroundWorker1_DoWork(
    ByVal sender As Object,
    ByVal e As DoWorkEventArgs) _
    Handles backgroundWorker1.DoWork

        document = New XmlDocument()

        ' Replace this file name with a valid file name.
        document.Load("http://www.tailspintoys.com/sample.xml")

        ' Uncomment the following line to
        ' simulate a noticeable latency.
        'Thread.Sleep(5000);
    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        If e.Error Is Nothing Then
            MessageBox.Show(document.InnerXml, "Download Complete")
        Else
            MessageBox.Show("Failed to download file", "Download failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' <summary>
    ' Required designer variable.
    ' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ' <summary>
    ' Clean up any resources being used.
    ' </summary>
    ' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"


    ' <summary>
    ' Required method for Designer support - do not modify
    ' the contents of this method with the code editor.
    ' </summary>
    Private Sub InitializeComponent()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dowloadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' backgroundWorker1
        ' 
        ' 
        ' dowloadButton
        ' 
        Me.dowloadButton.Location = New System.Drawing.Point(12, 12)
        Me.dowloadButton.Name = "dowloadButton"
        Me.dowloadButton.Size = New System.Drawing.Size(75, 23)
        Me.dowloadButton.TabIndex = 0
        Me.dowloadButton.Text = "Download file"
        Me.dowloadButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(104, 54)
        Me.Controls.Add(dowloadButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region
End Class


Public Class Program

    ' <summary>
    ' The main entry point for the application.
    ' </summary>
    <STAThread()>
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Class