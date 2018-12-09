Public Class NewCue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Main.DataSet1.Cues.AddCuesRow(Cue_ID:=CueNumI.Text, System:=SystemI.Text, Cue_Note:=NoteI.Text, Scene:=SceneI.Text)
            Dim showname, showpath As String
            showname = My.Settings.CurrentShow
            showpath = "/ProgramData/OpenSCS/" + showname
            Main.DataSet1.WriteXml(showpath)

        Catch
            Dialog1.Show()
        End Try
        Try
            CueNumI.Text = CueNumI.Text + 1
        Catch

        End Try

        SystemI.ResetText()
        NoteI.ResetText()
        SceneI.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub NewCue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SceneI.Select()

    End Sub
End Class