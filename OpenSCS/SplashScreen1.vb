Imports System.Net

Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        ' Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'Copyright info
        Label1.Text = "Initializing AppID..."
        Dim random As New Random()
        If My.Settings.AppID = "" Then
            My.Settings.AppID = String.Format(random.Next(10000000, 99999999))
        End If
        Copyright.Text = My.Application.Info.Copyright
        Version.Text = "Version " + String.Format(My.Application.Info.Version.Major) + "." + String.Format(My.Application.Info.Version.Minor)
        Label1.Text = "Verifying Program Data..."
        If (Not System.IO.Directory.Exists("/ProgramData/OpenSCS")) Then
            System.IO.Directory.CreateDirectory("/ProgramData/OpenSCS")

        End If
        Label1.Text = "Starting OpenSCS..."
        Timer2.Start()

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.TOS = False Then
            TOS.Show()
            Timer1.Stop()
        Else
            Main.Show()
            Timer1.Stop()
            Me.Close()
        End If

    End Sub


End Class
