Public Class Stopwatch
    Public sec As Integer
    Public min As Integer
    Public hr As Integer
    Private Sub Stopwatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sec = 0
        min = 0
        hr = 0
        Timer2.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec = sec + 1
        If sec = 60 Then
            min = min + 1
            sec = 0
        End If
        If min = 60 Then
            hr = hr + 1
            min = 0
        End If
        'build the label
        Label1.Text = hr.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Label1.Text = "00:00:00"
        sec = 0
        min = 0
        hr = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If TextBox1.Text = "" Then
            Me.Text = "Stopwatch"
        Else
            Me.Text = TextBox1.Text
        End If


    End Sub
End Class