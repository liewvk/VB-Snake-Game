<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblInstruction = New Label()
        lblScore = New Label()
        lblStatus = New Label()
        btnStart = New Button()
        btnRestart = New Button()
        btnExit = New Button()
        pnlGameArea = New Panel()
        gameTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(237, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(128, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Snake Game"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New Point(28, 434)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(96, 25)
        lblInstruction.TabIndex = 1
        lblInstruction.Text = "Instruction"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(221, 470)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 1
        lblScore.Text = "Score"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(28, 470)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(452, 443)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(94, 33)
        btnStart.TabIndex = 2
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(562, 443)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(94, 33)
        btnRestart.TabIndex = 2
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(673, 443)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 33)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' pnlGameArea
        ' 
        pnlGameArea.Location = New Point(28, 66)
        pnlGameArea.Name = "pnlGameArea"
        pnlGameArea.Size = New Size(728, 359)
        pnlGameArea.TabIndex = 3
        ' 
        ' gameTimer
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 504)
        Controls.Add(pnlGameArea)
        Controls.Add(btnExit)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(lblStatus)
        Controls.Add(lblScore)
        Controls.Add(lblInstruction)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents gameTimer As Timer

End Class
