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

Public Class Form1

    Sub Stats()

        cd.Enabled = False
        contstream.Enabled = False
        Button1.Enabled = False
        Button1.Text = "Refreshing Data..."

        Try
            Dim webstatus As New WebClient()
            Dim statusresponse As String = webstatus.DownloadString("http://scripts.myradiostream.com/s46/4350/status.js")
            Dim status_start As String
            Dim status_end As String
            status_start = Replace(statusresponse, "document.write('", "")
            status_end = Replace(status_start, "');", "")
            If status_end = "Online" Then
                Dim weblisten As New WebClient()
                Dim listenresponse As String = weblisten.DownloadString("http://scripts.myradiostream.com/s46/4350/listeners.js")
                Dim list_start As String
                Dim list_end As String
                Dim list_rem As String
                list_start = Replace(listenresponse, "document.write('", "")
                list_end = Replace(list_start, "');", "")
                list_rem = Replace(list_end, "<html><body>", "")
                Label22.Text = "Online" & " with " & list_rem & " listeners"
                Label22.ForeColor = Color.Green()
            End If
            If status_end = "Offline (No Server Connection)" Then
                Label22.Text = "Offline - Server Down"
                Label22.ForeColor = Color.Red()
            End If
            If status_end = "Offline (No Source)" Then
                Label22.Text = "Offline - Not Streaming"
                Label22.ForeColor = Color.DarkOrange()
            End If
        Catch ex As Exception
        End Try

        Dim minutetime As String = Format(Now, "mm")
        If minutetime = "59" Or minutetime = "00" Or minutetime = "01" Then
            If Label27.Text = "Collecting Information..." Then
                Label27.Text = "Updating Soon - Too Close To The Hour"
                Label27.ForeColor = Color.DarkBlue
            End If
            Label9.Text = 121
            Button1.Text = "Refresh Data Now (2:00)"
            Button1.Enabled = True
            contstream.Interval = 122000
            contstream.Enabled = True
            cd.Enabled = True

        Else
            Dim lognumber As String
            Dim cachelognumber As String
            Dim logname As String
            Dim cachelognameogg As String
            Dim cachelognametmp As String
            Dim logpath As String
            Dim cachelogpatha As String
            Dim cachelogpathb As String
            Dim hournow As Integer
            hournow = Format(Now, "HH")
            Dim minutenow As String
            minutenow = Format(Now, "mm")
            Dim twohourago As Integer
            twohourago = hournow - 2
            Dim twohoursago As String
            twohoursago = twohourago
            lognumber = Format(Now, "yyyyMMddHH")
            cachelognumber = Format(Now, "yyyyMMddHHmm")
            logname = lognumber + "0000.ogg"
            cachelognametmp = cachelognumber + "00.tmp"
            cachelognameogg = cachelognumber + "00.ogg"

            If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\OfficePC.txt") Then
                Try
                    logpath = "\\NE1-LOGGER\Logger\Store\" + logname
                    cachelogpatha = "\\NE1-LOGGER\Logger\Cache\" + cachelognametmp
                    cachelogpathb = "\\NE1-LOGGER\Logger\Cache\" + cachelognameogg
                    If My.Computer.FileSystem.FileExists(logpath) Then
                        Label27.Text = "Recording"
                        Label27.ForeColor = Color.Green()
                        Label8.Visible = False
                    ElseIf My.Computer.FileSystem.FileExists(cachelogpatha) Or My.Computer.FileSystem.FileExists(cachelogpathb) Then
                        Label27.Text = "Recording In Minutes"
                        Label27.ForeColor = Color.DarkOrange()
                        Label8.Visible = True
                    Else
                        Label27.Text = "Not Recording"
                        Label27.ForeColor = Color.Red()
                        Label8.Visible = True
                    End If
                Catch ex As Exception
                End Try
            ElseIf My.Computer.FileSystem.FileExists("C:\NE1fmConsole\LoggerPC.txt") Then
                logpath = "C:\Logger\Store\" + logname
                cachelogpatha = "C:\Logger\Cache\" + cachelognametmp
                cachelogpathb = "C:\Logger\Cache\" + cachelognameogg
                If My.Computer.FileSystem.FileExists(logpath) Then
                    Label27.Text = "Recording"
                    Label27.ForeColor = Color.Green()
                    Label8.Visible = False
                ElseIf My.Computer.FileSystem.FileExists(cachelogpatha) Or My.Computer.FileSystem.FileExists(cachelogpathb) Then
                    Label27.Text = "Recording In Minutes"
                    Label27.ForeColor = Color.DarkOrange()
                    Label8.Visible = True
                Else
                    Label27.Text = "Not Recording"
                    Label27.ForeColor = Color.Red()
                    Label8.Visible = True
                End If
            Else
                Label27.Text = "Unconfigured Environment"
                Label27.ForeColor = Color.DarkBlue
                Label8.Visible = False
            End If

            Button1.Enabled = True
            Button1.Text = "Refresh Data Now (5:00)"
            contstream.Interval = 302000
            contstream.Enabled = True

            Label9.Text = 301
            cd.Enabled = True
        End If








    End Sub


    Sub ConsoleUpdater()
        Try
            File.Delete("C:\NE1fmConsole\ConsoleUpdater.exe")
        Catch ex As Exception

        End Try

        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/s/oe4lzcotlbrktjd/version.txt?insert_anything_you_want")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                'do nothing
            Else
                Dim link As String = "https://www.dropbox.com/s/1pyfy9dhe2puj75/ConsoleUpdater.exe?dl=1"
                Dim wc As New WebClient
                wc.DownloadFile(link, "C:\NE1fmConsole\ConsoleUpdater.exe")
                System.Threading.Thread.Sleep(5000)
                Process.Start("C:\NE1fmConsole\ConsoleUpdater.exe")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub LogProg()
        Try
            If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\LoggerPC.txt") Then
                Dim p1() As Process
                p1 = Process.GetProcessesByName("ALFiler")
                If p1.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Logger\ALFiler.exe")
                    Catch ex As Exception
                    End Try
                End If
                Dim p2() As Process
                p2 = Process.GetProcessesByName("ALRec")
                If p2.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Logger\ALRec.exe")
                    Catch ex As Exception
                    End Try
                End If
                Dim p3() As Process
                p3 = Process.GetProcessesByName("butt")
                If p3.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Users\logger\AppData\Local\butt-0.1.16\butt.exe")
                    Catch ex As Exception
                    End Try
                End If
                Dim p4() As Process
                p4 = Process.GetProcessesByName("piraside")
                If p4.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Program Files (x86)\Pira CZ Silence Detector\piraside.exe")
                    Catch ex As Exception
                    End Try
                End If
                Dim p5() As Process
                p5 = Process.GetProcessesByName("Now Playing Tool for OtsAV")
                If p5.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Program Files\Now Playing Tool for OtsAV\Now Playing Tool for OtsAV.exe")
                    Catch ex As Exception
                    End Try
                End If
                Dim p6() As Process
                p6 = Process.GetProcessesByName("Stats Tool For OtsAV")
                If p6.Count > 0 Then
                    'Already Running
                Else
                    Try
                        Process.Start("C:\Program Files\Stats Tool for OtsAV\Stats Tool for OtsAV.exe")
                    Catch ex As Exception
                    End Try
                End If
            Else
                'Do Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Minimized

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Me.TopMost = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        NotifyIcon1.Visible = False
    End Sub

    Private Sub starttime_Tick(sender As Object, e As EventArgs) Handles starttime.Tick
        'Me.Visible = False
        'NotifyIcon1.Visible = True
        'starttime.Enabled = False
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        NotifyIcon1.Visible = False
        opentimer.Enabled = False

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
        NotifyIcon1.Visible = True
    End Sub

    Private Sub logtime_Tick(sender As Object, e As EventArgs) Handles logtime.Tick
        LogProg()
    End Sub

    Private Sub songtimer_Tick(sender As Object, e As EventArgs) Handles songtimer.Tick
        Try
            If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\OfficePC.txt") Then
                Try
                    Dim npo As String = My.Computer.FileSystem.ReadAllText("\\NE1-LOGGER\Logger\LoggerNowPlaying\nowplaying.txt")
                    If Len(npo) > 25 Then
                        Label2.Text = npo + "  :::  "
                    Else
                        Label2.Text = npo
                    End If
                Catch ex As Exception
                    Label2.Text = "UNKNOWN"
                End Try
            ElseIf My.Computer.FileSystem.FileExists("C:\NE1fmConsole\LoggerPC.txt") Then
                Dim npo As String = My.Computer.FileSystem.ReadAllText("C:\Logger\LoggerNowPlaying\nowplaying.txt")
                If Len(npo) > 25 Then
                    Label2.Text = npo + "  :::  "
                Else
                    Label2.Text = npo
                End If
            Else
                Label2.Text = "Unconfigured Environment"
            End If
        Catch ex As Exception
            Label2.Text = "UNKNOWN"
        End Try


    End Sub

    Private Sub songtimer2_Tick(sender As Object, e As EventArgs) Handles songtimer2.Tick
        Try
            If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\OfficePC.txt") Then
                Try
                    Dim npmod As DateTime
                    npmod = File.GetLastWriteTime("\\NE1-LOGGER\Logger\LoggerNowPlaying\nowplaying.txt")
                    Dim timenow As DateTime
                    timenow = Date.Now
                    Dim difftime As Integer
                    difftime = DateDiff(DateInterval.Minute, timenow, npmod)

                    If difftime < -5 Then
                        Label2.Text = "UNKNOWN"
                    ElseIf Len(Label2.Text) > 25 Then
                        Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, Len(Label2.Text) - 1) + Microsoft.VisualBasic.Left(Label2.Text, 1)
                    Else
                        'Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                    End If
                Catch ex As Exception
                    Label2.Text = "UNKNOWN"
                End Try
            ElseIf My.Computer.FileSystem.FileExists("C:\NE1fmConsole\LoggerPC.txt") Then
                Dim npmod As DateTime
                npmod = File.GetLastWriteTime("C:\Logger\LoggerNowPlaying\nowplaying.txt")
                Dim timenow As DateTime
                timenow = Date.Now
                Dim difftime As Integer
                difftime = DateDiff(DateInterval.Minute, timenow, npmod)

                If difftime < -5 Then
                    Label2.Text = "UNKNOWN"
                ElseIf Len(Label2.Text) > 25 Then
                    Label2.Text = Microsoft.VisualBasic.Right(Label2.Text, Len(Label2.Text) - 1) + Microsoft.VisualBasic.Left(Label2.Text, 1)
                Else
                    'Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                End If
            Else
                Label2.Text = "Unconfigured Environment"
            End If

        Catch ex As Exception
            Label2.Text = "UNKNOWN"
        End Try


    End Sub

    Private Sub startstream_Tick(sender As Object, e As EventArgs) Handles startstream.Tick

        Stats()

        LogProg()

        startstream.Enabled = False
    End Sub

    Private Sub contstream_Tick(sender As Object, e As EventArgs) Handles contstream.Tick
        Stats()

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Visible = False
            NotifyIcon1.Visible = True
            Dim dt As DateTime = DateTime.Today.AddHours(DateTime.Now.Hour)
            dt = dt.AddHours(1)
            Dim showtime As Integer = dt.Subtract(DateTime.Now).TotalMilliseconds
            opentimer.Interval = showtime
            opentimer.Enabled = True
            NotifyIcon1.BalloonTipTitle = "NE1fm Console Minimised"
            NotifyIcon1.BalloonTipText = "Click the pink icon next to clock to reopen the console, or it will open automatically at the start of the next hour."
            NotifyIcon1.ShowBalloonTip(3000)
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Me.Hide()
            passbox.Show()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 600000

        If My.Computer.FileSystem.FileExists("C:\NE1fmConsole\VBPC.txt") Then
            Dim result As Integer = MessageBox.Show("It appears you are using this program on a PC which is used for developmental purposes. Would you like to enable software update?", "Update?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Timer1.Enabled = False
                File.Delete("C:\NE1fmConsole\ConsoleUpdater.exe")
            ElseIf result = DialogResult.Yes Then
                ConsoleUpdater()
            Else
                Timer1.Enabled = False
                File.Delete("C:\NE1fmConsole\ConsoleUpdater.exe")
            End If
        Else
            ConsoleUpdater()
        End If
    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As EventArgs) Handles Button3.MouseClick
        Me.Hide()
        RemoteAccess.Show()
    End Sub

    Private Sub Button3_GotFocus(sender As Object, e As EventArgs) Handles Button3.GotFocus
        PictureBox1.Select()
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        PictureBox1.Select()
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        PictureBox1.Select()
    End Sub


    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MessageBox.Show("Left Mouse Button")
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            MessageBox.Show("Right Mouse Button")
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NotifyIcon1.Visible = False
    End Sub

    Private Sub opentimer_Tick(sender As Object, e As EventArgs) Handles opentimer.Tick
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        NotifyIcon1.Visible = False
        opentimer.Enabled = False
    End Sub

    Private Sub cd_Tick(sender As Object, e As EventArgs) Handles cd.Tick
        Dim time As Integer
        time = Label9.Text
        If time > 0 Then
            Dim seconds As Integer = time
            Dim example1 As New TimeSpan(0, 0, seconds)
            Dim example2 As DateTime = example2.AddSeconds(seconds)
            Label9.Text = time - 1
            Dim corsec As Integer = example2.Second - 1
            Dim sec As String = corsec.ToString.PadLeft(2, "0")
            Dim min As String
            If sec = "-1" Then
                Dim cormin As Integer = example2.Minute - 1
                min = cormin.ToString()
                sec = "59"
            Else
                min = example2.Minute.ToString
            End If


            Button1.Text = "Refresh Data Now (" & min & ":" & sec & ")"
        End If
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Stats()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
