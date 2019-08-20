<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sign_in_out
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sign_in_out))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tb_event_title = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_user_query = New System.Windows.Forms.TextBox()
        Me.tb_student_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btn_attendance_signer = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(968, 555)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 555)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.tb_event_title)
        Me.Panel3.Location = New System.Drawing.Point(106, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(752, 50)
        Me.Panel3.TabIndex = 3
        '
        'tb_event_title
        '
        Me.tb_event_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_event_title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_event_title.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_event_title.ForeColor = System.Drawing.Color.White
        Me.tb_event_title.Location = New System.Drawing.Point(76, 12)
        Me.tb_event_title.Name = "tb_event_title"
        Me.tb_event_title.Size = New System.Drawing.Size(591, 26)
        Me.tb_event_title.TabIndex = 46
        Me.tb_event_title.Text = "EVENT TITLE"
        Me.tb_event_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tb_user_query)
        Me.Panel2.Controls.Add(Me.tb_student_name)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.btn_attendance_signer)
        Me.Panel2.Location = New System.Drawing.Point(106, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 332)
        Me.Panel2.TabIndex = 2
        '
        'tb_user_query
        '
        Me.tb_user_query.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_user_query.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_user_query.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user_query.ForeColor = System.Drawing.Color.White
        Me.tb_user_query.Location = New System.Drawing.Point(267, 60)
        Me.tb_user_query.MaxLength = 7
        Me.tb_user_query.Name = "tb_user_query"
        Me.tb_user_query.Size = New System.Drawing.Size(208, 22)
        Me.tb_user_query.TabIndex = 43
        Me.tb_user_query.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_student_name
        '
        Me.tb_student_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_student_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_student_name.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_student_name.ForeColor = System.Drawing.Color.White
        Me.tb_student_name.Location = New System.Drawing.Point(76, 144)
        Me.tb_student_name.Name = "tb_student_name"
        Me.tb_student_name.Size = New System.Drawing.Size(591, 26)
        Me.tb_student_name.TabIndex = 45
        Me.tb_student_name.Text = "Name of Student"
        Me.tb_student_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(303, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 12)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Enter Student ID Number Here"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(259, 73)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(224, 32)
        Me.BunifuSeparator1.TabIndex = 44
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'btn_attendance_signer
        '
        Me.btn_attendance_signer.Activecolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_attendance_signer.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_attendance_signer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_attendance_signer.BorderRadius = 0
        Me.btn_attendance_signer.ButtonText = "SIGN IN"
        Me.btn_attendance_signer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_attendance_signer.DisabledColor = System.Drawing.Color.Gray
        Me.btn_attendance_signer.Enabled = False
        Me.btn_attendance_signer.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_attendance_signer.Iconimage = Nothing
        Me.btn_attendance_signer.Iconimage_right = Nothing
        Me.btn_attendance_signer.Iconimage_right_Selected = Nothing
        Me.btn_attendance_signer.Iconimage_Selected = Nothing
        Me.btn_attendance_signer.IconMarginLeft = 0
        Me.btn_attendance_signer.IconMarginRight = 0
        Me.btn_attendance_signer.IconRightVisible = True
        Me.btn_attendance_signer.IconRightZoom = 0R
        Me.btn_attendance_signer.IconVisible = True
        Me.btn_attendance_signer.IconZoom = 90.0R
        Me.btn_attendance_signer.IsTab = False
        Me.btn_attendance_signer.Location = New System.Drawing.Point(259, 251)
        Me.btn_attendance_signer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_attendance_signer.Name = "btn_attendance_signer"
        Me.btn_attendance_signer.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_attendance_signer.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_attendance_signer.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_attendance_signer.selected = False
        Me.btn_attendance_signer.Size = New System.Drawing.Size(224, 48)
        Me.btn_attendance_signer.TabIndex = 1
        Me.btn_attendance_signer.Text = "SIGN IN"
        Me.btn_attendance_signer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_attendance_signer.Textcolor = System.Drawing.Color.White
        Me.btn_attendance_signer.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frm_sign_in_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 555)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(984, 594)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(984, 594)
        Me.Name = "frm_sign_in_out"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_attendance_signer As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents tb_user_query As System.Windows.Forms.TextBox
    Friend WithEvents tb_event_title As TextBox
    Friend WithEvents tb_student_name As TextBox
End Class
