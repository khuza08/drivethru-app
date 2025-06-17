<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daliyReport
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        lblTotal = New Label()
        dgvLog = New Guna.UI2.WinForms.Guna2DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        TabPage2 = New TabPage()
        Guna2TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvLog, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2TabControl1
        ' 
        Guna2TabControl1.Alignment = TabAlignment.Left
        Guna2TabControl1.Controls.Add(TabPage1)
        Guna2TabControl1.Controls.Add(TabPage2)
        Guna2TabControl1.Dock = DockStyle.Fill
        Guna2TabControl1.ItemSize = New Size(180, 40)
        Guna2TabControl1.Location = New Point(0, 0)
        Guna2TabControl1.Name = "Guna2TabControl1"
        Guna2TabControl1.SelectedIndex = 0
        Guna2TabControl1.Size = New Size(872, 436)
        Guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonHoverState.ForeColor = Color.White
        Guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        Guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(CByte(29), CByte(37), CByte(49))
        Guna2TabControl1.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F)
        Guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White
        Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(CByte(76), CByte(132), CByte(255))
        Guna2TabControl1.TabButtonSize = New Size(180, 40)
        Guna2TabControl1.TabIndex = 0
        Guna2TabControl1.TabMenuBackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblTotal)
        TabPage1.Controls.Add(dgvLog)
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Location = New Point(184, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(684, 428)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(502, 348)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(88, 30)
        lblTotal.TabIndex = 4
        lblTotal.Text = "totalan"
        ' 
        ' dgvLog
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvLog.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLog.ColumnHeadersHeight = 4
        dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLog.DefaultCellStyle = DataGridViewCellStyle3
        dgvLog.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLog.Location = New Point(6, 77)
        dgvLog.Name = "dgvLog"
        dgvLog.RowHeadersVisible = False
        dgvLog.RowHeadersWidth = 62
        dgvLog.Size = New Size(670, 225)
        dgvLog.TabIndex = 3
        dgvLog.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvLog.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvLog.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvLog.ThemeStyle.BackColor = Color.White
        dgvLog.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLog.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvLog.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvLog.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvLog.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvLog.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvLog.ThemeStyle.HeaderStyle.Height = 4
        dgvLog.ThemeStyle.ReadOnly = False
        dgvLog.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvLog.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLog.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvLog.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvLog.ThemeStyle.RowsStyle.Height = 33
        dgvLog.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLog.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(dtpFrom, 0, 0)
        TableLayoutPanel1.Controls.Add(dtpTo, 1, 0)
        TableLayoutPanel1.Location = New Point(6, 8)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(670, 63)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Checked = True
        dtpFrom.CustomizableEdges = CustomizableEdges1
        dtpFrom.Dock = DockStyle.Fill
        dtpFrom.Font = New Font("Segoe UI", 9F)
        dtpFrom.Format = DateTimePickerFormat.Long
        dtpFrom.Location = New Point(3, 3)
        dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dtpFrom.Size = New Size(329, 57)
        dtpFrom.TabIndex = 0
        dtpFrom.Value = New Date(2025, 6, 16, 21, 59, 36, 808)
        ' 
        ' dtpTo
        ' 
        dtpTo.Checked = True
        dtpTo.CustomizableEdges = CustomizableEdges3
        dtpTo.Dock = DockStyle.Fill
        dtpTo.Font = New Font("Segoe UI", 9F)
        dtpTo.Format = DateTimePickerFormat.Long
        dtpTo.Location = New Point(338, 3)
        dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        dtpTo.Size = New Size(329, 57)
        dtpTo.TabIndex = 1
        dtpTo.Value = New Date(2025, 6, 16, 22, 0, 8, 178)
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(184, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(684, 428)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' daliyReport
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(872, 436)
        Controls.Add(Guna2TabControl1)
        Name = "daliyReport"
        Text = "daliyReport"
        Guna2TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvLog, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dgvLog As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblTotal As Label
End Class
