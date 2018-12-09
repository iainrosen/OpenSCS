Public Class DevOpt
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub DevOpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.TOS = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False

        End If
        If My.Settings.AppID = "" Then
            TextBox1.Text = "Missing AppID"
        Else
            TextBox1.Text = My.Settings.AppID

        End If
        Timer1.Start()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.TOS = True
        Else
            My.Settings.TOS = False
            TOS.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.AppID = ""
        Application.Restart()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DevReset.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Settings.AppID = TextBox1.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class