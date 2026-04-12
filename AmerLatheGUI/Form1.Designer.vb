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
        JOGXP = New Button()
        TrackBar1 = New TrackBar()
        JOGXN = New Button()
        JOGZP = New Button()
        JOGZN = New Button()
        Timer1 = New Timer(components)
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' JOGXP
        ' 
        JOGXP.FlatStyle = FlatStyle.Flat
        JOGXP.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGXP.ForeColor = SystemColors.Info
        JOGXP.Location = New Point(1467, 475)
        JOGXP.Margin = New Padding(4, 3, 4, 3)
        JOGXP.Name = "JOGXP"
        JOGXP.Size = New Size(233, 121)
        JOGXP.TabIndex = 0
        JOGXP.Text = "X+"
        JOGXP.UseVisualStyleBackColor = True
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
        ' JOGXN
        ' 
        JOGXN.FlatStyle = FlatStyle.Flat
        JOGXN.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGXN.ForeColor = SystemColors.Info
        JOGXN.Location = New Point(1209, 475)
        JOGXN.Margin = New Padding(4, 3, 4, 3)
        JOGXN.Name = "JOGXN"
        JOGXN.Size = New Size(233, 121)
        JOGXN.TabIndex = 0
        JOGXN.Text = "X-"
        JOGXN.UseVisualStyleBackColor = True
        ' 
        ' JOGZP
        ' 
        JOGZP.FlatStyle = FlatStyle.Flat
        JOGZP.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGZP.ForeColor = SystemColors.Info
        JOGZP.Location = New Point(1467, 624)
        JOGZP.Margin = New Padding(4, 3, 4, 3)
        JOGZP.Name = "JOGZP"
        JOGZP.Size = New Size(233, 121)
        JOGZP.TabIndex = 2
        JOGZP.Text = "Z+"
        JOGZP.UseVisualStyleBackColor = True
        ' 
        ' JOGZN
        ' 
        JOGZN.FlatStyle = FlatStyle.Flat
        JOGZN.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGZN.ForeColor = SystemColors.Info
        JOGZN.Location = New Point(1209, 624)
        JOGZN.Margin = New Padding(4, 3, 4, 3)
        JOGZN.Name = "JOGZN"
        JOGZN.Size = New Size(233, 121)
        JOGZN.TabIndex = 3
        JOGZN.Text = "Z-"
        JOGZN.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightBlue
        PictureBox1.Location = New Point(820, 424)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 52)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(2597, 918)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(JOGZN)
        Controls.Add(JOGZP)
        Controls.Add(TrackBar1)
        Controls.Add(JOGXN)
        Controls.Add(JOGXP)
        Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents JOGXP As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents JOGXN As Button
    Friend WithEvents JOGZP As Button
    Friend WithEvents JOGZN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox

End Class
