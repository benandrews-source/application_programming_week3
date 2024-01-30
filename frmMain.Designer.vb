<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblNumberOfPeople = New System.Windows.Forms.Label()
        Me.lblNumberOfVolunteers = New System.Windows.Forms.Label()
        Me.cboServing = New System.Windows.Forms.ComboBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.txtVolunteers = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(139, 359)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(117, 54)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(377, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 54)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(639, 359)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 54)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblNumberOfPeople
        '
        Me.lblNumberOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumberOfPeople.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPeople.Location = New System.Drawing.Point(12, 88)
        Me.lblNumberOfPeople.Name = "lblNumberOfPeople"
        Me.lblNumberOfPeople.Size = New System.Drawing.Size(175, 118)
        Me.lblNumberOfPeople.TabIndex = 1
        Me.lblNumberOfPeople.Text = "Number of People"
        Me.lblNumberOfPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberOfVolunteers
        '
        Me.lblNumberOfVolunteers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumberOfVolunteers.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfVolunteers.Location = New System.Drawing.Point(12, 209)
        Me.lblNumberOfVolunteers.Name = "lblNumberOfVolunteers"
        Me.lblNumberOfVolunteers.Size = New System.Drawing.Size(175, 118)
        Me.lblNumberOfVolunteers.TabIndex = 3
        Me.lblNumberOfVolunteers.Text = "Number of Volunteers"
        Me.lblNumberOfVolunteers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboServing
        '
        Me.cboServing.FormattingEnabled = True
        Me.cboServing.Location = New System.Drawing.Point(241, 34)
        Me.cboServing.Name = "cboServing"
        Me.cboServing.Size = New System.Drawing.Size(121, 24)
        Me.cboServing.TabIndex = 0
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(458, 88)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(301, 244)
        Me.lstDisplay.TabIndex = 8
        Me.lstDisplay.TabStop = False
        '
        'txtPeople
        '
        Me.txtPeople.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeople.Location = New System.Drawing.Point(241, 88)
        Me.txtPeople.Multiline = True
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(175, 118)
        Me.txtPeople.TabIndex = 2
        Me.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolunteers
        '
        Me.txtVolunteers.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolunteers.Location = New System.Drawing.Point(241, 209)
        Me.txtVolunteers.Multiline = True
        Me.txtVolunteers.Name = "txtVolunteers"
        Me.txtVolunteers.Size = New System.Drawing.Size(175, 118)
        Me.txtVolunteers.TabIndex = 4
        Me.txtVolunteers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtVolunteers)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cboServing)
        Me.Controls.Add(Me.lblNumberOfVolunteers)
        Me.Controls.Add(Me.lblNumberOfPeople)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmMain"
        Me.Text = "Soup Kitchen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblNumberOfPeople As Label
    Friend WithEvents lblNumberOfVolunteers As Label
    Friend WithEvents cboServing As ComboBox
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents txtVolunteers As TextBox
End Class
