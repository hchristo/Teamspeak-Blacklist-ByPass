Imports System.IO, System.Net
Public Class Form1
    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        FormOpenInfo.ShowDialog()
        LabelMeShowLauncher.Text = Application.ProductVersion
        CheckForUpdates()
    End Sub
    Public Sub CheckForUpdates()
        Try
            Dim request As HttpWebRequest = WebRequest.Create("https://home-hosting.de/ts3_blacklist_patcher/patcher_version.txt")
            Dim response As HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            LabelMeShowLauncher.Text = currentversion.ToString
            LabelMeShowServer.Text = newestversion.ToString
            If LabelMeShowServer.Text > LabelMeShowLauncher.Text Then
                Select Case MsgBox("Es wurde ein Launcher Update gefunden!" & vbNewLine & vbNewLine & "Wollen Sie das Update Runterladen?", MsgBoxStyle.YesNo, "Update Benachrichtigung!")
                    Case MsgBoxResult.Yes
                        Process.Start("https://home-hosting.de/ts3_blacklist_patcher/Teamspeak-Blacklist-ByPass.exe")
                        Me.Close()
                    Case MsgBoxResult.No
                        MsgBox("Update Abbruch durch Benutzer." & vbNewLine & "Sie verwenden eine alte Version, das kann zufolge Haben, dass das Spiel eventuell nicht mehr funktioniert!", MsgBoxStyle.Critical, "Abbruch des Updates durch benutzer!")
                        Me.Show()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Select Case MessageBox.Show("Willst du das Programm wirklich beenden?", "Programm beenden?", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
        End Select
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub label1_MouseDown(sender As Object, e As MouseEventArgs) Handles label1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ImprintForm.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Select Case MessageBox.Show("Willst du die Blacklist einträge setzen?", "Enträge Setzen?", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "127.0.0.1 blacklist2.teamspeak.com", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "127.0.0.1 blacklist.teamspeak.com", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "127.0.0.1 104.20.2.15", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "127.0.0.1 ipcheck.teamspeak.com", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "::1 blacklist2.teamspeak.com", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "::1 blacklist.teamspeak.com", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "::1 104.20.2.15", True)
                My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", vbNewLine & "::1 ipcheck.teamspeak.com", True)
                MsgBox("Die Einträge wurden erfolgreich gesetzt!", MsgBoxStyle.Information, "Einträge gesetzt!")
            Case DialogResult.No
                MsgBox("Das Eintragen wurde abgebrochen!", MsgBoxStyle.Critical, "Eintragung abgebrochen.")
        End Select

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelMeShowServer.Click

    End Sub
End Class
