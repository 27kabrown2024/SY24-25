<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        enemy = New PictureBox()
        enemy2 = New PictureBox()
        enemy3 = New PictureBox()
        platform = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = My.Resources.Resources.pdiddy
        avatar.Location = New Point(384, 77)
        avatar.Name = "avatar"
        avatar.Size = New Size(35, 53)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.penny
        PictureBox2.Location = New Point(384, 294)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources.drake
        enemy.Location = New Point(129, 52)
        enemy.Name = "enemy"
        enemy.Size = New Size(34, 43)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources.drake
        enemy2.Location = New Point(796, 294)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(37, 48)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' enemy3
        ' 
        enemy3.Image = My.Resources.Resources.drake
        enemy3.Location = New Point(384, 160)
        enemy3.Name = "enemy3"
        enemy3.Size = New Size(34, 41)
        enemy3.SizeMode = PictureBoxSizeMode.Zoom
        enemy3.TabIndex = 5
        enemy3.TabStop = False
        enemy3.Tag = "-1"
        ' 
        ' platform
        ' 
        platform.BackColor = SystemColors.ActiveCaptionText
        platform.Location = New Point(-1, 174)
        platform.Name = "platform"
        platform.Size = New Size(702, 17)
        platform.TabIndex = 6
        platform.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 404)
        Controls.Add(platform)
        Controls.Add(enemy3)
        Controls.Add(enemy2)
        Controls.Add(enemy)
        Controls.Add(PictureBox2)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(platform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents platform As PictureBox

End Class
