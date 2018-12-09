Imports System.Windows.Forms

Public Class rename

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Reboot.Show()
        Dim showname, showpath As String
        My.Settings.CurrentShow = TextBox1.Text

        showname = TextBox1.Text

        showpath = "/ProgramData/OpenSCS/" + showname
        Main.DataSet1.WriteXml(showpath)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub rename_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
