Option Strict Off
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Net
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Imports System.Diagnostics

Public Class RemoteAccess
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()
        Form1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Form1.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Form1.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Form1.Visible = True
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As EventArgs) Handles Button1.MouseClick
        Process.Start("C:\Windows\System32\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To OtsAV PC... & echo N310T5H34dph0n3s! | " & Chr(34) & "C:\Program Files (x86)\AnyDesk\AnyDesk.exe" & Chr(34) & " 450130805 --with-password ")
        Me.Close()
        Form1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Form1.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Form1.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Form1.Visible = True
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As EventArgs) Handles Button2.MouseClick
        Process.Start("C:\Windows\System32\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To Logger PC... & echo N31L0gg3r18! | " & Chr(34) & "C:\Program Files (x86)\AnyDesk\AnyDesk.exe" & Chr(34) & " 400074608 --with-password ")
        Me.Close()
        Form1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Form1.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Form1.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Form1.Visible = True
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As EventArgs) Handles Button3.MouseClick
        Process.Start("C:\Windows\System32\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To Office PC... & echo N310ff1c318! | " & Chr(34) & "C:\Program Files (x86)\AnyDesk\AnyDesk.exe" & Chr(34) & " 746157348 --with-password ")
        Me.Close()
        Form1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Form1.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Form1.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Form1.Visible = True
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
    End Sub

    Private Sub RemoteAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Me.TopMost = True
        Button4.Select()

    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        Button4.Select()
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        Button4.Select()
    End Sub

    Private Sub Button3_GotFocus(sender As Object, e As EventArgs) Handles Button3.GotFocus
        Button4.Select()
    End Sub

    Private Sub RemoteAccess_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\LoggerPC.txt") Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If

        If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\OfficePC.txt") Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If

    End Sub

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick
        Dim time As Integer
        time = Label2.Text
        If time > -1 Then
            Label2.Text = time - 1
            Button4.Text = "Back (" & time & ")"
        End If
    End Sub

    Private Sub closetimer_Tick(sender As Object, e As EventArgs) Handles closetimer.Tick
        Me.Close()
        Form1.Visible = False

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Form1.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Form1.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Form1.Visible = True
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
    End Sub
End Class