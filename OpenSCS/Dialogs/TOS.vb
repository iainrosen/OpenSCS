Imports System.Windows.Forms

Public Class TOS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.TOS = True
        If TextBox1.Text = "" Then
            My.Settings.Username = ""
        Else
            My.Settings.Username = TextBox1.Text
        End If
        Main.Show()

        SplashScreen1.Close()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.TOS = False
        Main.Show()
        SplashScreen1.Close()

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()

        TextBox1.Text = My.Settings.Username

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
