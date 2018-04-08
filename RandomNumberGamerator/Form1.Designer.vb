<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrFlashText = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblGamesAmount = New System.Windows.Forms.Label()
        Me.btnChangeFont = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnForecolor = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnBackcolor = New System.Windows.Forms.Button()
        Me.btnFlashColor = New System.Windows.Forms.Button()
        Me.tmrRNG = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(325, 16)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(75, 23)
        Me.btnFile.TabIndex = 0
        Me.btnFile.Text = "Select File"
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(6, 16)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(313, 23)
        Me.lblLocation.TabIndex = 1
        Me.lblLocation.Text = "No File Selected"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGame
        '
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.Location = New System.Drawing.Point(12, 61)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(411, 59)
        Me.lblGame.TabIndex = 2
        Me.lblGame.Text = "No Game Generated"
        Me.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFile)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 46)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Selection"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(158, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generate!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrFlashText
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Test Sound"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblGamesAmount
        '
        Me.lblGamesAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamesAmount.Location = New System.Drawing.Point(158, 146)
        Me.lblGamesAmount.Name = "lblGamesAmount"
        Me.lblGamesAmount.Size = New System.Drawing.Size(106, 64)
        Me.lblGamesAmount.TabIndex = 6
        Me.lblGamesAmount.Text = "Games: 0"
        Me.lblGamesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeFont
        '
        Me.btnChangeFont.Location = New System.Drawing.Point(340, 116)
        Me.btnChangeFont.Name = "btnChangeFont"
        Me.btnChangeFont.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeFont.TabIndex = 7
        Me.btnChangeFont.Text = "Font"
        Me.btnChangeFont.UseVisualStyleBackColor = True
        '
        'btnForecolor
        '
        Me.btnForecolor.Location = New System.Drawing.Point(12, 116)
        Me.btnForecolor.Name = "btnForecolor"
        Me.btnForecolor.Size = New System.Drawing.Size(75, 23)
        Me.btnForecolor.TabIndex = 8
        Me.btnForecolor.Text = "Font Color"
        Me.btnForecolor.UseVisualStyleBackColor = True
        '
        'btnBackcolor
        '
        Me.btnBackcolor.Location = New System.Drawing.Point(12, 145)
        Me.btnBackcolor.Name = "btnBackcolor"
        Me.btnBackcolor.Size = New System.Drawing.Size(75, 23)
        Me.btnBackcolor.TabIndex = 9
        Me.btnBackcolor.Text = "Back Color"
        Me.btnBackcolor.UseVisualStyleBackColor = True
        '
        'btnFlashColor
        '
        Me.btnFlashColor.Location = New System.Drawing.Point(12, 174)
        Me.btnFlashColor.Name = "btnFlashColor"
        Me.btnFlashColor.Size = New System.Drawing.Size(75, 23)
        Me.btnFlashColor.TabIndex = 10
        Me.btnFlashColor.Text = "Flash Color"
        Me.btnFlashColor.UseVisualStyleBackColor = True
        '
        'tmrRNG
        '
        Me.tmrRNG.Interval = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 209)
        Me.Controls.Add(Me.btnFlashColor)
        Me.Controls.Add(Me.btnBackcolor)
        Me.Controls.Add(Me.btnForecolor)
        Me.Controls.Add(Me.btnChangeFont)
        Me.Controls.Add(Me.lblGamesAmount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Random Number Gamerator"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tmrFlashText As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblGamesAmount As Label
    Friend WithEvents btnChangeFont As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents btnForecolor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnBackcolor As Button
    Friend WithEvents btnFlashColor As Button
    Friend WithEvents tmrRNG As Timer
End Class
