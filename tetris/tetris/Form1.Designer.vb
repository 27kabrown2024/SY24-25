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
        scorelabel = New Label()
        Timer2 = New Timer(components)
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
        avatar.Location = New Point(432, 69)
        avatar.Name = "avatar"
        avatar.Size = New Size(39, 48)
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
        PictureBox2.Location = New Point(432, 265)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 41)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources.drake
        enemy.Location = New Point(145, 47)
        enemy.Name = "enemy"
        enemy.Size = New Size(38, 39)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources.drake
        enemy2.Location = New Point(896, 265)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(42, 43)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' enemy3
        ' 
        enemy3.Image = My.Resources.Resources.drake
        enemy3.Location = New Point(369, 114)
        enemy3.Name = "enemy3"
        enemy3.Size = New Size(38, 37)
        enemy3.SizeMode = PictureBoxSizeMode.Zoom
        enemy3.TabIndex = 5
        enemy3.TabStop = False
        enemy3.Tag = "-1"
        ' 
        ' platform
        ' 
        platform.BackColor = SystemColors.ActiveCaptionText
        platform.Location = New Point(-1, 157)
        platform.Name = "platform"
        platform.Size = New Size(790, 15)
        platform.TabIndex = 6
        platform.TabStop = False
        platform.Tag = "wall"
        ' 
        ' scorelabel
        ' 
        scorelabel.AutoSize = True
        scorelabel.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        scorelabel.Location = New Point(12, 9)
        scorelabel.Name = "scorelabel"
        scorelabel.Size = New Size(96, 34)
        scorelabel.TabIndex = 7
        scorelabel.Text = "Label1"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1012, 364)
        Controls.Add(scorelabel)
        Controls.Add(platform)
        Controls.Add(enemy3)
        Controls.Add(enemy2)
        Controls.Add(enemy)
        Controls.Add(PictureBox2)
        Controls.Add(avatar)
        Font = New Font("Microsoft Sans Serif", 9F)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(platform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents platform As PictureBox
    Friend WithEvents scorelabel As Label
    Friend WithEvents Timer2 As Timer

End Class
