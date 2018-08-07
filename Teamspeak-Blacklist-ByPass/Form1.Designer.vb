<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMeShowServer = New System.Windows.Forms.Label()
        Me.LabelMeShowLauncher = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(12, 162)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(340, 39)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Black- und Greylist Einträge setzen"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(340, 132)
        Me.label1.TabIndex = 6
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(12, 207)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(340, 39)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Programm Schließen"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Button3.Location = New System.Drawing.Point(277, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "mehr..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Patcher Version:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Update Version:"
        '
        'LabelMeShowServer
        '
        Me.LabelMeShowServer.AutoSize = True
        Me.LabelMeShowServer.Location = New System.Drawing.Point(92, 256)
        Me.LabelMeShowServer.Name = "LabelMeShowServer"
        Me.LabelMeShowServer.Size = New System.Drawing.Size(35, 13)
        Me.LabelMeShowServer.TabIndex = 14
        Me.LabelMeShowServer.Text = "NULL"
        '
        'LabelMeShowLauncher
        '
        Me.LabelMeShowLauncher.AutoSize = True
        Me.LabelMeShowLauncher.Location = New System.Drawing.Point(92, 269)
        Me.LabelMeShowLauncher.Name = "LabelMeShowLauncher"
        Me.LabelMeShowLauncher.Size = New System.Drawing.Size(35, 13)
        Me.LabelMeShowLauncher.TabIndex = 15
        Me.LabelMeShowLauncher.Text = "NULL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelMeShowLauncher)
        Me.Controls.Add(Me.LabelMeShowServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teamspeak Black- and greylist Patcher ver. 1.6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As Button
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelMeShowServer As Label
    Friend WithEvents LabelMeShowLauncher As Label
End Class
