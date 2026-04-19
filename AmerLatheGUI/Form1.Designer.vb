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
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        z = New Label()
        x = New Label()
        Label6 = New Label()
        Label5 = New Label()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' JOGXP
        ' 
        JOGXP.FlatStyle = FlatStyle.Flat
        JOGXP.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGXP.ForeColor = SystemColors.Info
        JOGXP.Location = New Point(486, 68)
        JOGXP.Margin = New Padding(4, 3, 4, 3)
        JOGXP.Name = "JOGXP"
        JOGXP.Size = New Size(233, 121)
        JOGXP.TabIndex = 0
        JOGXP.Text = "X+"
        JOGXP.UseVisualStyleBackColor = True
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Dock = DockStyle.Left
        TrackBar1.Location = New Point(3, 28)
        TrackBar1.Margin = New Padding(4, 3, 4, 3)
        TrackBar1.Maximum = 500
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Orientation = Orientation.Vertical
        TrackBar1.Size = New Size(56, 320)
        TrackBar1.TabIndex = 1
        ' 
        ' JOGXN
        ' 
        JOGXN.FlatStyle = FlatStyle.Flat
        JOGXN.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JOGXN.ForeColor = SystemColors.Info
        JOGXN.Location = New Point(245, 68)
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
        JOGZP.Location = New Point(486, 195)
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
        JOGZN.Location = New Point(245, 195)
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
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(TrackBar1)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(JOGXP)
        GroupBox1.Controls.Add(JOGXN)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(JOGZN)
        GroupBox1.Controls.Add(JOGZP)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(1069, 322)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(764, 351)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jogging"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(66, 136)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(97, 28)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Tag = "0.01"
        RadioButton4.Text = "0.01mm"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(66, 102)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(87, 28)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Tag = "0.1"
        RadioButton3.Text = "0.1mm"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Checked = True
        RadioButton2.Location = New Point(66, 68)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 28)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Tag = "0.5"
        RadioButton2.Text = "0.5mm"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(66, 34)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 28)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Tag = "1"
        RadioButton1.Text = "1mm"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateGray
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.ForeColor = Color.Ivory
        Panel1.Location = New Point(0, 701)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1862, 49)
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
        Panel2.Location = New Point(63, 322)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(722, 305)
        Panel2.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(232), CByte(185), CByte(102))
        PictureBox1.Location = New Point(820, 322)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 305)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(1065, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(531, 270)
        TabControl1.TabIndex = 8
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 33)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(523, 233)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(NumericUpDown1)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(523, 237)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Machine Physics"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 24)
        Label4.TabIndex = 2
        Label4.Text = "Linear distance per rev"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(166, 17)
        NumericUpDown1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 32)
        NumericUpDown1.TabIndex = 1
        NumericUpDown1.Value = New Decimal(New Integer() {200, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 24)
        Label3.TabIndex = 0
        Label3.Text = "Steps per rev"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(z)
        GroupBox2.Controls.Add(x)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.ForeColor = SystemColors.ButtonFace
        GroupBox2.Location = New Point(137, 73)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(460, 209)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' z
        ' 
        z.AutoSize = True
        z.Location = New Point(104, 98)
        z.Name = "z"
        z.Size = New Size(21, 24)
        z.TabIndex = 4
        z.Text = "0"
        ' 
        ' x
        ' 
        x.AutoSize = True
        x.Location = New Point(104, 51)
        x.Name = "x"
        x.Size = New Size(21, 24)
        x.TabIndex = 3
        x.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 24)
        Label6.TabIndex = 2
        Label6.Text = "Z:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(56, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 24)
        Label5.TabIndex = 1
        Label5.Text = "X:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(11), CByte(28))
        ClientSize = New Size(1862, 750)
        Controls.Add(GroupBox2)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Font = New Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents z As Label
    Friend WithEvents x As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label

End Class
