Imports System.Net


Public Class Main

    Inherits System.Windows.Forms.Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim showname, showpath As String
            showname = My.Settings.CurrentShow
            showpath = "/ProgramData/OpenSCS/" + showname
            DataSet1.ReadXml(showpath)
            Me.Text = "Show: " + My.Settings.CurrentShow
        Catch
        End Try
    End Sub

    Private Sub ChangeShowToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ChangeShowToolStripMenuItem.Click
        ShowSave.Show()
    End Sub

    Private Sub DeleteShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteShowToolStripMenuItem.Click
        Delete.Show()
    End Sub



    Private Sub NewCueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCueToolStripMenuItem.Click
        NewCue.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim showname, showpath As String
        showname = My.Settings.CurrentShow
        showpath = "/ProgramData/OpenSCS/" + showname
        DataSet1.WriteXml(showpath)
        Application.Exit()


    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub

    Private Sub TridentCSDWebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim url As String = “http://tridentcsd.com“

        Process.Start(url)
    End Sub

    Private Sub RenameShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameShowToolStripMenuItem.Click
        rename.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim showname, showpath As String
        showname = My.Settings.CurrentShow
        showpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Desktop/" + showname + ".show"
        DataSet1.WriteXml(showpath)
        MsgBox("Exported to Desktop.")
    End Sub

    Private Sub StopwatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopwatchToolStripMenuItem.Click
        Stopwatch.Show()

    End Sub

    Private Sub RealTimeClockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RTC.Show()

    End Sub

    Private Sub RealTimeClockToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RealTimeClockToolStripMenuItem.Click
        RTC.Show()

    End Sub

    Private Sub LightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightModeToolStripMenuItem.Click
        If LightModeToolStripMenuItem.Checked = True Then
            DataGridView1.BackgroundColor = Color.Black
            DataGridView1.DefaultCellStyle.BackColor = Color.Black
            DataGridView1.DefaultCellStyle.ForeColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            LightModeToolStripMenuItem.Checked = False
        Else
            DataGridView1.BackgroundColor = Color.White
            DataGridView1.DefaultCellStyle.BackColor = Color.White
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            LightModeToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub OpenSCSToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles OpenSCSToolStripMenuItem.DropDownOpened
        OpenSCSToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub OpenSCSToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles OpenSCSToolStripMenuItem.DropDownClosed
        OpenSCSToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub HelpToolStripMenuItem_Open(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.DropDownOpened

        HelpToolStripMenuItem.ForeColor = Color.Black

    End Sub
    Private Sub HelpToolStripMenuItem_Close(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.DropDownClosed

        HelpToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub ToolsToolStripMenuItem_Open(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.DropDownOpened
        ToolsToolStripMenuItem.ForeColor = Color.Black


    End Sub
    Private Sub ToolsToolStripMenuItem_Close(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.DropDownClosed
        ToolsToolStripMenuItem.ForeColor = Color.White


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        OpenFileDialog1.DefaultExt = ".show"
        OpenFileDialog1.Filter = "OpenSCS Show Files|*.show"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            DataSet1.ReadXml(OpenFileDialog1.OpenFile())
        Catch ex As Exception
            MsgBox("File Corrupt or Unreadable.")
        End Try

    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        Connect.Show()

    End Sub


End Class
