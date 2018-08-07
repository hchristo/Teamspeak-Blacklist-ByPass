<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImprintForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprintForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(147, 113)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.linkLabel1.TabIndex = 11
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "www.hchristo.de"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 113)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(347, 65)
        Me.label2.TabIndex = 10
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(12, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(340, 39)
        Me.button2.TabIndex = 12
        Me.button2.Text = "Black- und Greylist Einträge entfernen"
        Me.button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(340, 39)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Changelog Anzeigen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ImprintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(364, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImprintForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents label2 As Label
    Private WithEvents button2 As Button
    Private WithEvents Button3 As Button
End Class
