﻿Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(enemy, avatar, 10, 0)
        follow(enemy2, avatar, 0, 5)
        pace(enemy3, platform, 5)
    End Sub
    Sub pace(e As PictureBox, p As PictureBox, s As Integer)
        Dim dir As Integer
        dir = e.Tag
        If e.Location.X > p.Location.X + p.Width Then
            e.Location += New Point(dir * s, 0)
        Else
            e.Tag = -dir
            e.Location += New Point(dir * s, 0)
        End If

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(avatar, -10, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(avatar, 10, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(avatar, 0, 10)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(avatar, 0, -10)
        End If
        If e.KeyCode = Keys.Space Then
            avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        avatar.Refresh()
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            PictureBox2.Visible = False
        End If
    End Sub
    Sub follow(e As PictureBox, a As PictureBox, speedx As Integer, speedy As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, speedy)
        Else move(e, 0, -speedy)
        End If
        If e.Location.X < a.Location.X Then
            move(e, speedx, 0)
        Else move(e, -speedx, 0)
        End If
    End Sub


End Class
