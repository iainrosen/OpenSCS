Imports System.Windows.Forms

Public Class Delete

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Reboot.Show()

        Dim showname, showpath As String
        showname = My.Settings.CurrentShow
        showpath = "/ProgramData/OpenSCS/" + showname
        System.IO.File.Delete(showpath)
        My.Settings.CurrentShow = "Default"
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
