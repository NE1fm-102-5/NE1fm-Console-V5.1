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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.starttime = New System.Windows.Forms.Timer(Me.components)
        Me.logtime = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.songtimer = New System.Windows.Forms.Timer(Me.components)
        Me.songtimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.startstream = New System.Windows.Forms.Timer(Me.components)
        Me.contstream = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cd = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Song: "
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NE1fm Console"
        '
        'starttime
        '
        Me.starttime.Enabled = True
        Me.starttime.Interval = 3000
        '
        'logtime
        '
        Me.logtime.Enabled = True
        Me.logtime.Interval = 60000
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Location = New System.Drawing.Point(106, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Collecting Information..."
        Me.Label2.UseMnemonic = False
        '
        'songtimer
        '
        Me.songtimer.Enabled = True
        Me.songtimer.Interval = 20000
        '
        'songtimer2
        '
        Me.songtimer2.Enabled = True
        Me.songtimer2.Interval = 300
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NE1fm Console v5.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 39)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "This program shows " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NE1fm data and keeps " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "programs running!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stream Status:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(106, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Collecting Information..."
        '
        'startstream
        '
        Me.startstream.Enabled = True
        Me.startstream.Interval = 15000
        '
        'contstream
        '
        Me.contstream.Interval = 302000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Logger Status:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(106, 144)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Collecting Information..."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 25)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Hide / Close"
        Me.ToolTip1.SetToolTip(Me.Button2, "Left-click to minimise software to icon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right-click to close program completely" &
        ".")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label8.Location = New System.Drawing.Point(2, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(453, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "NOTE: Logger may report as Not Recording or In Minutes for up to an hour after be" &
    "ing restarted."
        Me.Label8.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(301, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 28)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Remote Control Another PC"
        Me.ToolTip1.SetToolTip(Me.Button3, "Allows you to control any studio computer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Useful for co-presenting or training." &
        "")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(301, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Refreshing Data..."
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to refresh stream and logger data now." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Automatically updates every five mi" &
        "nutes.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'opentimer
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(275, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "301"
        Me.Label9.Visible = False
        '
        'cd
        '
        Me.cd.Interval = 1000
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 184)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "NE1fm Console"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents starttime As Timer
    Friend WithEvents logtime As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents songtimer As Timer
    Friend WithEvents songtimer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents startstream As Timer
    Friend WithEvents contstream As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents opentimer As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents cd As Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
