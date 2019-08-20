<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sign_out_review
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sign_out_review))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tb_event_title = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_student_name = New System.Windows.Forms.TextBox()
        Me.tb_user_query = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_review = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_star_rating = New Bunifu.Framework.UI.BunifuRating()
        Me.btn_sign_out = New Bunifu.Framework.UI.BunifuFlatButton()
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
        Me.PictureBox1.Size = New System.Drawing.Size(1026, 660)
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
        Me.Panel1.Size = New System.Drawing.Size(1026, 660)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.tb_event_title)
        Me.Panel3.Location = New System.Drawing.Point(89, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(856, 50)
        Me.Panel3.TabIndex = 4
        '
        'tb_event_title
        '
        Me.tb_event_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_event_title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_event_title.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_event_title.ForeColor = System.Drawing.Color.White
        Me.tb_event_title.Location = New System.Drawing.Point(42, 13)
        Me.tb_event_title.Name = "tb_event_title"
        Me.tb_event_title.Size = New System.Drawing.Size(761, 26)
        Me.tb_event_title.TabIndex = 49
        Me.tb_event_title.Text = "EVENT TITLE"
        Me.tb_event_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tb_student_name)
        Me.Panel2.Controls.Add(Me.tb_user_query)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tb_review)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cb_star_rating)
        Me.Panel2.Controls.Add(Me.btn_sign_out)
        Me.Panel2.Location = New System.Drawing.Point(89, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(856, 526)
        Me.Panel2.TabIndex = 2
        '
        'tb_student_name
        '
        Me.tb_student_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_student_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_student_name.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_student_name.ForeColor = System.Drawing.Color.White
        Me.tb_student_name.Location = New System.Drawing.Point(121, 120)
        Me.tb_student_name.Name = "tb_student_name"
        Me.tb_student_name.Size = New System.Drawing.Size(591, 26)
        Me.tb_student_name.TabIndex = 48
        Me.tb_student_name.Text = "Name of Student"
        Me.tb_student_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_user_query
        '
        Me.tb_user_query.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tb_user_query.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_user_query.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user_query.ForeColor = System.Drawing.Color.White
        Me.tb_user_query.Location = New System.Drawing.Point(309, 55)
        Me.tb_user_query.MaxLength = 7
        Me.tb_user_query.Name = "tb_user_query"
        Me.tb_user_query.Size = New System.Drawing.Size(208, 22)
        Me.tb_user_query.TabIndex = 46
        Me.tb_user_query.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(345, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Enter Student ID Number Here"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(301, 68)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(224, 32)
        Me.BunifuSeparator1.TabIndex = 47
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(341, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 12)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Maximum input is 250 characters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(338, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Write us a short review"
        '
        'tb_review
        '
        Me.tb_review.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_review.Location = New System.Drawing.Point(265, 269)
        Me.tb_review.MaxLength = 250
        Me.tb_review.Multiline = True
        Me.tb_review.Name = "tb_review"
        Me.tb_review.Size = New System.Drawing.Size(297, 90)
        Me.tb_review.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(351, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Event Performance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_star_rating
        '
        Me.cb_star_rating.BackColor = System.Drawing.Color.Transparent
        Me.cb_star_rating.ForeColor = System.Drawing.Color.Gold
        Me.cb_star_rating.Location = New System.Drawing.Point(279, 211)
        Me.cb_star_rating.Name = "cb_star_rating"
        Me.cb_star_rating.Size = New System.Drawing.Size(268, 29)
        Me.cb_star_rating.TabIndex = 7
        Me.cb_star_rating.Value = 1
        '
        'btn_sign_out
        '
        Me.btn_sign_out.Activecolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sign_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sign_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sign_out.BorderRadius = 0
        Me.btn_sign_out.ButtonText = "SIGN OUT"
        Me.btn_sign_out.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sign_out.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sign_out.Enabled = False
        Me.btn_sign_out.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sign_out.Iconimage = Nothing
        Me.btn_sign_out.Iconimage_right = Nothing
        Me.btn_sign_out.Iconimage_right_Selected = Nothing
        Me.btn_sign_out.Iconimage_Selected = Nothing
        Me.btn_sign_out.IconMarginLeft = 0
        Me.btn_sign_out.IconMarginRight = 0
        Me.btn_sign_out.IconRightVisible = True
        Me.btn_sign_out.IconRightZoom = 0R
        Me.btn_sign_out.IconVisible = True
        Me.btn_sign_out.IconZoom = 90.0R
        Me.btn_sign_out.IsTab = False
        Me.btn_sign_out.Location = New System.Drawing.Point(301, 428)
        Me.btn_sign_out.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sign_out.Name = "btn_sign_out"
        Me.btn_sign_out.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sign_out.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sign_out.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sign_out.selected = False
        Me.btn_sign_out.Size = New System.Drawing.Size(224, 48)
        Me.btn_sign_out.TabIndex = 1
        Me.btn_sign_out.Text = "SIGN OUT"
        Me.btn_sign_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sign_out.Textcolor = System.Drawing.Color.White
        Me.btn_sign_out.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frm_sign_out_review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 660)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1042, 699)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1042, 699)
        Me.Name = "frm_sign_out_review"
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
    Friend WithEvents btn_sign_out As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cb_star_rating As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_review As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_user_query As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tb_event_title As TextBox
    Friend WithEvents tb_student_name As TextBox
End Class
