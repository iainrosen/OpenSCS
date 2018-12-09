Public NotInheritable Class ResetIP

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        System.IO.Directory.Delete("C:\ProgramData\OpenSCS", True)
        System.IO.Directory.Delete("C:\ProgramData\OpenSCSDump", True)
        My.Settings.AppID = ""
        My.Settings.Username = ""
        My.Settings.CurrentShow = "Default"
        My.Settings.TOS = False
        Label1.Text = "Reset Complete."
        Button1.Visible = True
        ProgressBar1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reboot.Show()


    End Sub

    Private Sub ResetIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevOpt.Close()
        Main.Close()
        DevReset.Close()
        Timer1.Start()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
