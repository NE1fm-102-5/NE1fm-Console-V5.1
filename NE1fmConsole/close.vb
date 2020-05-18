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

Public Class passbox

    Sub closeform()
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

    Sub EnterRoutine()
        If TextBox1.Text = "N31ConsoleClose!" Then
            TextBox1.Text = ""
            Label2.Text = ""
            End

        ElseIf TextBox1.Text = "test" Then
            MessageBox.Show("Hello World!")

        ElseIf TextBox1.Text = "updatenow" Then
            closeform()
            Form1.ConsoleUpdater()

        ElseIf TextBox1.Text = "redownload" Then
            Me.Hide()
            Dim link As String = "https://www.dropbox.com/s/1pyfy9dhe2puj75/ConsoleUpdater.exe?dl=1"
            Dim wc As New WebClient
            wc.DownloadFile(link, "C:\NE1fmConsole\ConsoleUpdater.exe")
            System.Threading.Thread.Sleep(5000)
            Process.Start("C:\NE1fmConsole\ConsoleUpdater.exe")

        ElseIf TextBox1.Text = "N31OtsRemote!" Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "/incognito 192.168.1.135")
            Label2.Text = ""
            TextBox1.Text = ""
            closeform()

        ElseIf TextBox1.Text = "time" Then
            Dim dt As DateTime = DateTime.Today.AddHours(DateTime.Now.Hour)
            dt = dt.AddHours(1)
            Dim showtime As Integer = dt.Subtract(DateTime.Now).TotalMilliseconds
            MessageBox.Show(dt & showtime)

        ElseIf TextBox1.Text = "N31SCinfo!" Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "/incognito http://s46.myradiostream.com:4350")
            Label2.Text = ""
            TextBox1.Text = ""
            closeform()

        Else
            TextBox1.Text = ""
            Label2.Text = "Incorrect Password"
        End If
    End Sub


    Private Sub Button2_MouseClick(sender As Object, e As EventArgs) Handles Button2.MouseClick
        Label2.Text = ""
        TextBox1.Text = ""
        closeform()
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As EventArgs) Handles Button1.MouseClick
        EnterRoutine()
    End Sub

    Private Sub passbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Me.TopMost = True
        TextBox1.Select()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    Private Sub passbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Enter Pressed")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterRoutine()
        End If
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        TextBox1.Select()
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        closeform()
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

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick
        Dim time As Integer
        time = Label4.Text
        If time > -1 Then
            Label4.Text = time - 1
            Button2.Text = "CANCEL (" & time & ")"
        End If
    End Sub
End Class