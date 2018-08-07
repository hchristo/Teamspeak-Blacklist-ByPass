Public Class ImprintForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Process.Start("https://www.hchristo.de")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Select Case MessageBox.Show("Willst du die Einträge wieder Löschen?", "Einträge Löschen?", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                Dim txt = IO.File.ReadAllText("C:\Windows\System32\drivers\etc\hosts")
                txt = txt.Replace("127.0.0.1 blacklist.teamspeak.com", "")
                txt = txt.Replace("127.0.0.1 blacklist2.teamspeak.com", "")
                txt = txt.Replace("127.0.0.1 104.20.2.15", "")
                txt = txt.Replace("127.0.0.1 ipcheck.teamspeak.com", "")
                txt = txt.Replace("::1 blacklist.teamspeak.com", "")
                txt = txt.Replace("::1 blacklist2.teamspeak.com", "")
                txt = txt.Replace("::1 104.20.2.15", "")
                txt = txt.Replace("::1 ipcheck.teamspeak.com", "")
                IO.File.WriteAllText("C:\Windows\System32\drivers\etc\hosts", txt)
                MsgBox("Einträge erfolgreich gelöscht!", MsgBoxStyle.Information, "Löschen erfolgreich!.")
            Case DialogResult.No
                MsgBox("Löschen der Einträge abgebrochen!", MsgBoxStyle.Critical, "Löschen abgebrochen.")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormChangeLog.Show()
    End Sub
End Class