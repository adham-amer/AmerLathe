<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        TrackBar1 = New TrackBar()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(1467, 475)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 121)
        Button1.TabIndex = 0
        Button1.Text = "X+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(103, 424)
        TrackBar1.Margin = New Padding(4, 3, 4, 3)
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Orientation = Orientation.Vertical
        TrackBar1.Size = New Size(56, 157)
        TrackBar1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Info
        Button2.Location = New Point(1209, 475)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 121)
        Button2.TabIndex = 0
        Button2.Text = "X-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Info
        Button3.Location = New Point(1467, 624)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(233, 121)
        Button3.TabIndex = 2
        Button3.Text = "Z+"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.Info
        Button4.Location = New Point(1209, 624)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(233, 121)
        Button4.TabIndex = 3
        Button4.Text = "Z-"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(214, 475)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(418, 208)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateGray
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.ForeColor = Color.Ivory
        Panel1.Location = New Point(0, 869)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2597, 49)
        Panel1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightCoral
        Label2.Location = New Point(193, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 24)
        Label2.TabIndex = 1
        Label2.Text = "Not Connected"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 24)
        Label1.TabIndex = 0
        Label1.Text = "Board Connection:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSlateGray
        Panel2.Location = New Point(288, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(880, 361)
        Panel2.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(2597, 918)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TrackBar1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
