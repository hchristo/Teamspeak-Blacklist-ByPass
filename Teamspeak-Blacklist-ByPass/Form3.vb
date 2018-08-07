Public Class FormOpenInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        ImprintForm.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub FormOpenInfo_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class