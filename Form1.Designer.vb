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
        btnStartEngine = New Button()
        btnStopEngine = New Button()
        btnTurnLeft = New Button()
        btnTurnRight = New Button()
        btnMoveUp = New Button()
        btnMoveDown = New Button()
        btnRotateForward = New Button()
        btnRotateBackward = New Button()
        btnReturnHome = New Button()
        btnUndefined = New Button()
        SuspendLayout()
        ' 
        ' btnStartEngine
        ' 
        btnStartEngine.Location = New Point(27, 30)
        btnStartEngine.Name = "btnStartEngine"
        btnStartEngine.Size = New Size(128, 54)
        btnStartEngine.TabIndex = 0
        btnStartEngine.Text = "btnStartEngine"
        btnStartEngine.UseVisualStyleBackColor = True
        ' 
        ' btnStopEngine
        ' 
        btnStopEngine.Location = New Point(27, 106)
        btnStopEngine.Name = "btnStopEngine"
        btnStopEngine.Size = New Size(128, 54)
        btnStopEngine.TabIndex = 1
        btnStopEngine.Text = "btnStopEngine"
        btnStopEngine.UseVisualStyleBackColor = True
        ' 
        ' btnTurnLeft
        ' 
        btnTurnLeft.Location = New Point(36, 183)
        btnTurnLeft.Name = "btnTurnLeft"
        btnTurnLeft.Size = New Size(128, 54)
        btnTurnLeft.TabIndex = 2
        btnTurnLeft.Text = "btnTurnLeft"
        btnTurnLeft.UseVisualStyleBackColor = True
        ' 
        ' btnTurnRight
        ' 
        btnTurnRight.Location = New Point(36, 265)
        btnTurnRight.Name = "btnTurnRight"
        btnTurnRight.Size = New Size(128, 54)
        btnTurnRight.TabIndex = 3
        btnTurnRight.Text = "btnTurnRight"
        btnTurnRight.UseVisualStyleBackColor = True
        ' 
        ' btnMoveUp
        ' 
        btnMoveUp.Location = New Point(36, 346)
        btnMoveUp.Name = "btnMoveUp"
        btnMoveUp.Size = New Size(128, 54)
        btnMoveUp.TabIndex = 4
        btnMoveUp.Text = "btnMoveUp"
        btnMoveUp.UseVisualStyleBackColor = True
        ' 
        ' btnMoveDown
        ' 
        btnMoveDown.Location = New Point(174, 30)
        btnMoveDown.Name = "btnMoveDown"
        btnMoveDown.Size = New Size(128, 54)
        btnMoveDown.TabIndex = 5
        btnMoveDown.Text = "btnMoveDown"
        btnMoveDown.UseVisualStyleBackColor = True
        ' 
        ' btnRotateForward
        ' 
        btnRotateForward.Location = New Point(174, 116)
        btnRotateForward.Name = "btnRotateForward"
        btnRotateForward.Size = New Size(128, 54)
        btnRotateForward.TabIndex = 6
        btnRotateForward.Text = "btnRotateForward"
        btnRotateForward.UseVisualStyleBackColor = True
        ' 
        ' btnRotateBackward
        ' 
        btnRotateBackward.Location = New Point(174, 194)
        btnRotateBackward.Name = "btnRotateBackward"
        btnRotateBackward.Size = New Size(128, 54)
        btnRotateBackward.TabIndex = 7
        btnRotateBackward.Text = "btnRotateBackward"
        btnRotateBackward.UseVisualStyleBackColor = True
        ' 
        ' btnReturnHome
        ' 
        btnReturnHome.Location = New Point(174, 265)
        btnReturnHome.Name = "btnReturnHome"
        btnReturnHome.Size = New Size(128, 54)
        btnReturnHome.TabIndex = 8
        btnReturnHome.Text = "btnReturnHome"
        btnReturnHome.UseVisualStyleBackColor = True
        ' 
        ' btnUndefined
        ' 
        btnUndefined.Location = New Point(174, 346)
        btnUndefined.Name = "btnUndefined"
        btnUndefined.Size = New Size(128, 54)
        btnUndefined.TabIndex = 10
        btnUndefined.Text = "btnUndefined"
        btnUndefined.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUndefined)
        Controls.Add(btnReturnHome)
        Controls.Add(btnRotateBackward)
        Controls.Add(btnRotateForward)
        Controls.Add(btnMoveDown)
        Controls.Add(btnMoveUp)
        Controls.Add(btnTurnRight)
        Controls.Add(btnTurnLeft)
        Controls.Add(btnStopEngine)
        Controls.Add(btnStartEngine)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStartEngine As Button
    Friend WithEvents btnStopEngine As Button
    Friend WithEvents btnTurnLeft As Button
    Friend WithEvents btnTurnRight As Button
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents btnMoveDown As Button
    Friend WithEvents btnRotateForward As Button
    Friend WithEvents btnRotateBackward As Button
    Friend WithEvents btnReturnHome As Button
    Friend WithEvents btnUndefined As Button

End Class
