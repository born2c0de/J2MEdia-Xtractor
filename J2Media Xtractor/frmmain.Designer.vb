<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnumain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.openfiledlg = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblperm = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbldesc = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbldatasize = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.picappicon = New System.Windows.Forms.PictureBox
        Me.lblprofile = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblconfig = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblcreatedby = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblvendor = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblappver = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblappname = New System.Windows.Forms.Label
        Me.folderbrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.btnseldir = New System.Windows.Forms.Button
        Me.lbldumpdir = New System.Windows.Forms.Label
        Me.btnsimple = New System.Windows.Forms.Button
        Me.lstsimple = New System.Windows.Forms.ListBox
        Me.lsthardcore = New System.Windows.Forms.ListBox
        Me.btnhardcore = New System.Windows.Forms.Button
        Me.prgsimple = New System.Windows.Forms.ProgressBar
        Me.prghardcore = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkpng = New System.Windows.Forms.CheckBox
        Me.chkmidi = New System.Windows.Forms.CheckBox
        Me.chkwav = New System.Windows.Forms.CheckBox
        Me.mnumain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picappicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnumain
        '
        Me.mnumain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnumain.Location = New System.Drawing.Point(0, 0)
        Me.mnumain.Name = "mnumain"
        Me.mnumain.Size = New System.Drawing.Size(834, 24)
        Me.mnumain.TabIndex = 0
        Me.mnumain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OpenToolStripMenuItem.Text = "Open Java Game/App"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'openfiledlg
        '
        Me.openfiledlg.FileName = "OpenFileDialog1"
        Me.openfiledlg.Filter = "Java Applications|*.jar|All Files|*.*"
        Me.openfiledlg.Title = "Select Java Application File"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblperm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbldesc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbldatasize)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.picappicon)
        Me.GroupBox1.Controls.Add(Me.lblprofile)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblconfig)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblcreatedby)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblvendor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblappver)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblappname)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 279)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application Details"
        '
        'lblperm
        '
        Me.lblperm.Location = New System.Drawing.Point(76, 228)
        Me.lblperm.Name = "lblperm"
        Me.lblperm.Size = New System.Drawing.Size(205, 13)
        Me.lblperm.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Permissions"
        '
        'lbldesc
        '
        Me.lbldesc.Location = New System.Drawing.Point(76, 252)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(205, 13)
        Me.lbldesc.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Description"
        '
        'lbldatasize
        '
        Me.lbldatasize.Location = New System.Drawing.Point(76, 204)
        Me.lbldatasize.Name = "lbldatasize"
        Me.lbldatasize.Size = New System.Drawing.Size(205, 13)
        Me.lbldatasize.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Data Size"
        '
        'picappicon
        '
        Me.picappicon.Image = Global.J2Media_Xtractor.My.Resources.Resources.j2me
        Me.picappicon.InitialImage = Global.J2Media_Xtractor.My.Resources.Resources.j2me
        Me.picappicon.Location = New System.Drawing.Point(18, 19)
        Me.picappicon.Name = "picappicon"
        Me.picappicon.Size = New System.Drawing.Size(50, 50)
        Me.picappicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picappicon.TabIndex = 12
        Me.picappicon.TabStop = False
        '
        'lblprofile
        '
        Me.lblprofile.Location = New System.Drawing.Point(76, 182)
        Me.lblprofile.Name = "lblprofile"
        Me.lblprofile.Size = New System.Drawing.Size(205, 13)
        Me.lblprofile.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Profile"
        '
        'lblconfig
        '
        Me.lblconfig.Location = New System.Drawing.Point(76, 160)
        Me.lblconfig.Name = "lblconfig"
        Me.lblconfig.Size = New System.Drawing.Size(205, 13)
        Me.lblconfig.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Config"
        '
        'lblcreatedby
        '
        Me.lblcreatedby.Location = New System.Drawing.Point(76, 138)
        Me.lblcreatedby.Name = "lblcreatedby"
        Me.lblcreatedby.Size = New System.Drawing.Size(205, 13)
        Me.lblcreatedby.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Created By"
        '
        'lblvendor
        '
        Me.lblvendor.Location = New System.Drawing.Point(76, 116)
        Me.lblvendor.Name = "lblvendor"
        Me.lblvendor.Size = New System.Drawing.Size(205, 13)
        Me.lblvendor.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Vendor"
        '
        'lblappver
        '
        Me.lblappver.Location = New System.Drawing.Point(76, 94)
        Me.lblappver.Name = "lblappver"
        Me.lblappver.Size = New System.Drawing.Size(205, 13)
        Me.lblappver.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Version"
        '
        'lblappname
        '
        Me.lblappname.Location = New System.Drawing.Point(78, 37)
        Me.lblappname.Name = "lblappname"
        Me.lblappname.Size = New System.Drawing.Size(203, 13)
        Me.lblappname.TabIndex = 1
        '
        'folderbrowser
        '
        Me.folderbrowser.Description = "Select a Folder for saving all the files that are extracted from J2ME Files."
        '
        'btnseldir
        '
        Me.btnseldir.Location = New System.Drawing.Point(384, 64)
        Me.btnseldir.Name = "btnseldir"
        Me.btnseldir.Size = New System.Drawing.Size(135, 23)
        Me.btnseldir.TabIndex = 2
        Me.btnseldir.Text = "Select Dump Folder"
        Me.btnseldir.UseVisualStyleBackColor = True
        '
        'lbldumpdir
        '
        Me.lbldumpdir.Location = New System.Drawing.Point(12, 64)
        Me.lbldumpdir.Name = "lbldumpdir"
        Me.lbldumpdir.Size = New System.Drawing.Size(366, 34)
        Me.lbldumpdir.TabIndex = 3
        '
        'btnsimple
        '
        Me.btnsimple.Location = New System.Drawing.Point(90, 316)
        Me.btnsimple.Name = "btnsimple"
        Me.btnsimple.Size = New System.Drawing.Size(132, 23)
        Me.btnsimple.TabIndex = 4
        Me.btnsimple.Text = "Simple Extract"
        Me.btnsimple.UseVisualStyleBackColor = True
        '
        'lstsimple
        '
        Me.lstsimple.FormattingEnabled = True
        Me.lstsimple.Location = New System.Drawing.Point(90, 198)
        Me.lstsimple.Name = "lstsimple"
        Me.lstsimple.Size = New System.Drawing.Size(120, 95)
        Me.lstsimple.TabIndex = 5
        '
        'lsthardcore
        '
        Me.lsthardcore.FormattingEnabled = True
        Me.lsthardcore.Location = New System.Drawing.Point(306, 198)
        Me.lsthardcore.Name = "lsthardcore"
        Me.lsthardcore.Size = New System.Drawing.Size(120, 95)
        Me.lsthardcore.TabIndex = 6
        '
        'btnhardcore
        '
        Me.btnhardcore.Location = New System.Drawing.Point(306, 316)
        Me.btnhardcore.Name = "btnhardcore"
        Me.btnhardcore.Size = New System.Drawing.Size(132, 23)
        Me.btnhardcore.TabIndex = 7
        Me.btnhardcore.Text = "Hardcore Extract"
        Me.btnhardcore.UseVisualStyleBackColor = True
        '
        'prgsimple
        '
        Me.prgsimple.Location = New System.Drawing.Point(90, 374)
        Me.prgsimple.Name = "prgsimple"
        Me.prgsimple.Size = New System.Drawing.Size(132, 17)
        Me.prgsimple.Step = 5
        Me.prgsimple.TabIndex = 8
        '
        'prghardcore
        '
        Me.prghardcore.Location = New System.Drawing.Point(306, 374)
        Me.prghardcore.Name = "prghardcore"
        Me.prghardcore.Size = New System.Drawing.Size(132, 17)
        Me.prghardcore.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Files Found with Simple Scan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Possible Files with Embedded Media"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(478, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Written by Sanchit Karve [born2c0de]"
        '
        'chkpng
        '
        Me.chkpng.AutoSize = True
        Me.chkpng.Location = New System.Drawing.Point(306, 351)
        Me.chkpng.Name = "chkpng"
        Me.chkpng.Size = New System.Drawing.Size(49, 17)
        Me.chkpng.TabIndex = 13
        Me.chkpng.Text = "PNG"
        Me.chkpng.UseVisualStyleBackColor = True
        '
        'chkmidi
        '
        Me.chkmidi.AutoSize = True
        Me.chkmidi.Location = New System.Drawing.Point(361, 351)
        Me.chkmidi.Name = "chkmidi"
        Me.chkmidi.Size = New System.Drawing.Size(49, 17)
        Me.chkmidi.TabIndex = 14
        Me.chkmidi.Text = "MIDI"
        Me.chkmidi.UseVisualStyleBackColor = True
        '
        'chkwav
        '
        Me.chkwav.AutoSize = True
        Me.chkwav.Location = New System.Drawing.Point(409, 351)
        Me.chkwav.Name = "chkwav"
        Me.chkwav.Size = New System.Drawing.Size(51, 17)
        Me.chkwav.TabIndex = 15
        Me.chkwav.Text = "WAV"
        Me.chkwav.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 415)
        Me.Controls.Add(Me.chkwav)
        Me.Controls.Add(Me.chkmidi)
        Me.Controls.Add(Me.chkpng)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prghardcore)
        Me.Controls.Add(Me.prgsimple)
        Me.Controls.Add(Me.btnhardcore)
        Me.Controls.Add(Me.lsthardcore)
        Me.Controls.Add(Me.lstsimple)
        Me.Controls.Add(Me.btnsimple)
        Me.Controls.Add(Me.lbldumpdir)
        Me.Controls.Add(Me.btnseldir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnumain)
        Me.MainMenuStrip = Me.mnumain
        Me.Name = "frmmain"
        Me.Text = "J2MEdia Xtractor Version 2.5"
        Me.mnumain.ResumeLayout(False)
        Me.mnumain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picappicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnumain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openfiledlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcreatedby As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblvendor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblappver As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblappname As System.Windows.Forms.Label
    Friend WithEvents lblprofile As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblconfig As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents picappicon As System.Windows.Forms.PictureBox
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbldatasize As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblperm As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents folderbrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnseldir As System.Windows.Forms.Button
    Friend WithEvents lbldumpdir As System.Windows.Forms.Label
    Friend WithEvents btnsimple As System.Windows.Forms.Button
    Friend WithEvents lstsimple As System.Windows.Forms.ListBox
    Friend WithEvents lsthardcore As System.Windows.Forms.ListBox
    Friend WithEvents btnhardcore As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prgsimple As System.Windows.Forms.ProgressBar
    Friend WithEvents prghardcore As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkpng As System.Windows.Forms.CheckBox
    Friend WithEvents chkmidi As System.Windows.Forms.CheckBox
    Friend WithEvents chkwav As System.Windows.Forms.CheckBox

End Class
