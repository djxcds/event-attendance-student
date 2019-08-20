<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_attend_list
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_attend_list))
        Me.dgv_upcoming_events = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbleventname = New System.Windows.Forms.Label()
        Me.btnsigninout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbl_clickable = New System.Windows.Forms.Label()
        CType(Me.dgv_upcoming_events, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_upcoming_events
        '
        Me.dgv_upcoming_events.AllowUserToAddRows = False
        Me.dgv_upcoming_events.AllowUserToDeleteRows = False
        Me.dgv_upcoming_events.AllowUserToResizeColumns = False
        Me.dgv_upcoming_events.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_upcoming_events.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_upcoming_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_upcoming_events.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.dgv_upcoming_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_upcoming_events.Location = New System.Drawing.Point(47, 70)
        Me.dgv_upcoming_events.MultiSelect = False
        Me.dgv_upcoming_events.Name = "dgv_upcoming_events"
        Me.dgv_upcoming_events.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_upcoming_events.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_upcoming_events.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_upcoming_events.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_upcoming_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_upcoming_events.Size = New System.Drawing.Size(620, 262)
        Me.dgv_upcoming_events.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(64, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 12)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Select an event to sign in/out "
        '
        'lbleventname
        '
        Me.lbleventname.AutoSize = True
        Me.lbleventname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleventname.ForeColor = System.Drawing.Color.White
        Me.lbleventname.Location = New System.Drawing.Point(479, 37)
        Me.lbleventname.Name = "lbleventname"
        Me.lbleventname.Size = New System.Drawing.Size(174, 21)
        Me.lbleventname.TabIndex = 47
        Me.lbleventname.Text = "ACTIVE ATTENDANCE"
        '
        'btnsigninout
        '
        Me.btnsigninout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsigninout.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsigninout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsigninout.BorderRadius = 0
        Me.btnsigninout.ButtonText = "REFRESH"
        Me.btnsigninout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsigninout.DisabledColor = System.Drawing.Color.Gray
        Me.btnsigninout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsigninout.Iconcolor = System.Drawing.Color.Transparent
        Me.btnsigninout.Iconimage = Nothing
        Me.btnsigninout.Iconimage_right = Nothing
        Me.btnsigninout.Iconimage_right_Selected = Nothing
        Me.btnsigninout.Iconimage_Selected = Nothing
        Me.btnsigninout.IconMarginLeft = 0
        Me.btnsigninout.IconMarginRight = 0
        Me.btnsigninout.IconRightVisible = True
        Me.btnsigninout.IconRightZoom = 0R
        Me.btnsigninout.IconVisible = True
        Me.btnsigninout.IconZoom = 90.0R
        Me.btnsigninout.IsTab = False
        Me.btnsigninout.Location = New System.Drawing.Point(47, 30)
        Me.btnsigninout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsigninout.Name = "btnsigninout"
        Me.btnsigninout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsigninout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsigninout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnsigninout.selected = False
        Me.btnsigninout.Size = New System.Drawing.Size(118, 33)
        Me.btnsigninout.TabIndex = 48
        Me.btnsigninout.Text = "REFRESH"
        Me.btnsigninout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnsigninout.Textcolor = System.Drawing.Color.White
        Me.btnsigninout.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbl_clickable
        '
        Me.lbl_clickable.AutoSize = True
        Me.lbl_clickable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_clickable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clickable.ForeColor = System.Drawing.Color.White
        Me.lbl_clickable.Location = New System.Drawing.Point(636, 366)
        Me.lbl_clickable.Name = "lbl_clickable"
        Me.lbl_clickable.Size = New System.Drawing.Size(69, 17)
        Me.lbl_clickable.TabIndex = 49
        Me.lbl_clickable.Text = "About Me"
        '
        'frm_display_attend_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 390)
        Me.Controls.Add(Me.lbl_clickable)
        Me.Controls.Add(Me.btnsigninout)
        Me.Controls.Add(Me.lbleventname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_upcoming_events)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(729, 429)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(729, 429)
        Me.Name = "frm_display_attend_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Event"
        CType(Me.dgv_upcoming_events, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_upcoming_events As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbleventname As System.Windows.Forms.Label
    Friend WithEvents btnsigninout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbl_clickable As Label
End Class
