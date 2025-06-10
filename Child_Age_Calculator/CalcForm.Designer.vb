<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchildCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpchildDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblchildDOB = New System.Windows.Forms.Label()
        Me.lblageOutput = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblstatement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpchildDOB
        '
        Me.dtpchildDOB.CustomFormat = "MM/dd/yyyy"
        Me.dtpchildDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpchildDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpchildDOB.Location = New System.Drawing.Point(12, 42)
        Me.dtpchildDOB.Name = "dtpchildDOB"
        Me.dtpchildDOB.Size = New System.Drawing.Size(111, 22)
        Me.dtpchildDOB.TabIndex = 0
        '
        'lblchildDOB
        '
        Me.lblchildDOB.AutoSize = True
        Me.lblchildDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchildDOB.Location = New System.Drawing.Point(12, 26)
        Me.lblchildDOB.Name = "lblchildDOB"
        Me.lblchildDOB.Size = New System.Drawing.Size(69, 13)
        Me.lblchildDOB.TabIndex = 1
        Me.lblchildDOB.Text = "Child DOB:"
        '
        'lblageOutput
        '
        Me.lblageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblageOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblageOutput.Location = New System.Drawing.Point(153, 108)
        Me.lblageOutput.Name = "lblageOutput"
        Me.lblageOutput.Size = New System.Drawing.Size(50, 33)
        Me.lblageOutput.TabIndex = 2
        Me.lblageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(37, 206)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(238, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 113)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(135, 27)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "This child is"
        '
        'lblstatement
        '
        Me.lblstatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatement.Location = New System.Drawing.Point(221, 113)
        Me.lblstatement.Name = "lblstatement"
        Me.lblstatement.Size = New System.Drawing.Size(104, 23)
        Me.lblstatement.TabIndex = 7
        Me.lblstatement.Text = "years old"
        '
        'frmchildCalculator
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(357, 260)
        Me.Controls.Add(Me.lblstatement)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblageOutput)
        Me.Controls.Add(Me.lblchildDOB)
        Me.Controls.Add(Me.dtpchildDOB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmchildCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Child Age Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpchildDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblchildDOB As System.Windows.Forms.Label
    Friend WithEvents lblageOutput As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblstatement As System.Windows.Forms.Label

End Class
