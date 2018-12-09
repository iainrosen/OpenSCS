<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.CuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New OpenSCS.DataSet1()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Scene = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SystemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CueNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenSCSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopwatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealTimeClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.CuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CuesBindingSource
        '
        Me.CuesBindingSource.DataMember = "Cues"
        Me.CuesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CueIDDataGridViewTextBoxColumn, Me.Scene, Me.SystemDataGridViewTextBoxColumn, Me.CueNoteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CuesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(695, 539)
        Me.DataGridView1.TabIndex = 5
        '
        'CueIDDataGridViewTextBoxColumn
        '
        Me.CueIDDataGridViewTextBoxColumn.DataPropertyName = "Cue ID"
        Me.CueIDDataGridViewTextBoxColumn.FillWeight = 121.8274!
        Me.CueIDDataGridViewTextBoxColumn.HeaderText = "Go #"
        Me.CueIDDataGridViewTextBoxColumn.Name = "CueIDDataGridViewTextBoxColumn"
        Me.CueIDDataGridViewTextBoxColumn.Width = 60
        '
        'Scene
        '
        Me.Scene.DataPropertyName = "Scene"
        Me.Scene.FillWeight = 92.72419!
        Me.Scene.HeaderText = "Scene"
        Me.Scene.Name = "Scene"
        Me.Scene.Width = 167
        '
        'SystemDataGridViewTextBoxColumn
        '
        Me.SystemDataGridViewTextBoxColumn.DataPropertyName = "System"
        Me.SystemDataGridViewTextBoxColumn.FillWeight = 92.72419!
        Me.SystemDataGridViewTextBoxColumn.HeaderText = "Cue"
        Me.SystemDataGridViewTextBoxColumn.Name = "SystemDataGridViewTextBoxColumn"
        Me.SystemDataGridViewTextBoxColumn.Width = 168
        '
        'CueNoteDataGridViewTextBoxColumn
        '
        Me.CueNoteDataGridViewTextBoxColumn.DataPropertyName = "Cue Note"
        Me.CueNoteDataGridViewTextBoxColumn.FillWeight = 92.72419!
        Me.CueNoteDataGridViewTextBoxColumn.HeaderText = "Line/Note"
        Me.CueNoteDataGridViewTextBoxColumn.Name = "CueNoteDataGridViewTextBoxColumn"
        Me.CueNoteDataGridViewTextBoxColumn.Width = 300
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSCSToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(695, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenSCSToolStripMenuItem
        '
        Me.OpenSCSToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OpenSCSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCueToolStripMenuItem, Me.ToolStripSeparator1, Me.ChangeShowToolStripMenuItem, Me.RenameShowToolStripMenuItem, Me.DeleteShowToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.OpenSCSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenSCSToolStripMenuItem.Name = "OpenSCSToolStripMenuItem"
        Me.OpenSCSToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.OpenSCSToolStripMenuItem.Text = "File"
        '
        'NewCueToolStripMenuItem
        '
        Me.NewCueToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.NewCueToolStripMenuItem.Image = Global.OpenSCS.My.Resources.Resources.newicon
        Me.NewCueToolStripMenuItem.Name = "NewCueToolStripMenuItem"
        Me.NewCueToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewCueToolStripMenuItem.Text = "New Cue"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(146, 6)
        '
        'ChangeShowToolStripMenuItem
        '
        Me.ChangeShowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ChangeShowToolStripMenuItem.Image = Global.OpenSCS.My.Resources.Resources.open
        Me.ChangeShowToolStripMenuItem.Name = "ChangeShowToolStripMenuItem"
        Me.ChangeShowToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ChangeShowToolStripMenuItem.Text = "Open Show"
        '
        'RenameShowToolStripMenuItem
        '
        Me.RenameShowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.RenameShowToolStripMenuItem.Image = Global.OpenSCS.My.Resources.Resources.edit
        Me.RenameShowToolStripMenuItem.Name = "RenameShowToolStripMenuItem"
        Me.RenameShowToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.RenameShowToolStripMenuItem.Text = "Rename Show"
        '
        'DeleteShowToolStripMenuItem
        '
        Me.DeleteShowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteShowToolStripMenuItem.Image = Global.OpenSCS.My.Resources.Resources.delete
        Me.DeleteShowToolStripMenuItem.Name = "DeleteShowToolStripMenuItem"
        Me.DeleteShowToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DeleteShowToolStripMenuItem.Text = "Delete Show"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(146, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.OpenSCS.My.Resources.Resources.left
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem3.Text = "Import Show"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripMenuItem1.Image = Global.OpenSCS.My.Resources.Resources.forward
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem1.Text = "Export Show"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(146, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.ExitToolStripMenuItem1.Image = Global.OpenSCS.My.Resources.Resources.exiticon
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.ExitToolStripMenuItem1.Text = "Save and Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.AboutToolStripMenuItem1.Image = Global.OpenSCS.My.Resources.Resources.find
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopwatchToolStripMenuItem, Me.RealTimeClockToolStripMenuItem, Me.LightModeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'StopwatchToolStripMenuItem
        '
        Me.StopwatchToolStripMenuItem.Name = "StopwatchToolStripMenuItem"
        Me.StopwatchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StopwatchToolStripMenuItem.Text = "Stopwatch"
        '
        'RealTimeClockToolStripMenuItem
        '
        Me.RealTimeClockToolStripMenuItem.Name = "RealTimeClockToolStripMenuItem"
        Me.RealTimeClockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RealTimeClockToolStripMenuItem.Text = "Real-Time Clock"
        '
        'LightModeToolStripMenuItem
        '
        Me.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem"
        Me.LightModeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LightModeToolStripMenuItem.Text = "Light Mode"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(695, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Default/Unsaved Show"
        CType(Me.CuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CuesBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpenSCSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RenameShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopwatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealTimeClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Scene As DataGridViewTextBoxColumn
    Friend WithEvents SystemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CueNoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
