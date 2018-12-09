Imports System.Windows.Forms

Public Class Connect

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim addr As String
            Dim remoteindex As String
            addr = TextBox1.Text
            remoteindex = "http://" + addr + "/shows/Default.show"
            Main.DataSet1.ReadXml(remoteindex)
        Catch
            MsgBox("Could not connect to server. Check IP.")
            Me.Close()
        End Try
        MsgBox("Connected to Server")
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
