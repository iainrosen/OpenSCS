Imports System.IO
Imports System.Windows.Forms

Public Class ShowSave

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Reboot.Show()
        Dim showname, showpath As String
        showname = My.Settings.CurrentShow
        showpath = "/ProgramData/OpenSCS/" + showname
        Main.DataSet1.WriteXml(showpath)
        My.Settings.CurrentShow = TextBox1.Text
        Main.DataSet1.Clear()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.CurrentShow
        Dim files() As String = Directory.GetFiles("C:\ProgramData\OpenSCS")

        ListBox1.Items.Clear()

        For Each file As String In files

            ListBox1.Items.Add(Path.GetFileName(file))

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem
    End Sub
End Class
