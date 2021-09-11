<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverlayController
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnColor = New System.Windows.Forms.Button()
        Me.tbOpacity = New System.Windows.Forms.TrackBar()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblOpacity = New System.Windows.Forms.Label()
        Me.btnLocate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.chkClickable = New System.Windows.Forms.CheckBox()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnColor
        '
        Me.btnColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnColor.Location = New System.Drawing.Point(281, 35)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(70, 29)
        Me.btnColor.TabIndex = 3
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'tbOpacity
        '
        Me.tbOpacity.AutoSize = False
        Me.tbOpacity.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbOpacity.Location = New System.Drawing.Point(94, 0)
        Me.tbOpacity.Maximum = 100
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(129, 67)
        Me.tbOpacity.TabIndex = 2
        Me.tbOpacity.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbOpacity.Value = 100
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Black
        Me.lblColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblColor.Location = New System.Drawing.Point(0, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 67)
        Me.lblColor.TabIndex = 4
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOpacity
        '
        Me.lblOpacity.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblOpacity.Location = New System.Drawing.Point(34, 0)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(60, 67)
        Me.lblOpacity.TabIndex = 5
        Me.lblOpacity.Text = "100%"
        Me.lblOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLocate
        '
        Me.btnLocate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLocate.Location = New System.Drawing.Point(281, 0)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(70, 29)
        Me.btnLocate.TabIndex = 6
        Me.btnLocate.Text = "Locate"
        Me.btnLocate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(356, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 29)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkClickable
        '
        Me.chkClickable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkClickable.AutoSize = True
        Me.chkClickable.Location = New System.Drawing.Point(356, 31)
        Me.chkClickable.Name = "chkClickable"
        Me.chkClickable.Size = New System.Drawing.Size(82, 19)
        Me.chkClickable.TabIndex = 8
        Me.chkClickable.Text = "isClickable"
        Me.chkClickable.UseVisualStyleBackColor = True
        '
        'chkVisible
        '
        Me.chkVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Location = New System.Drawing.Point(356, 49)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(68, 19)
        Me.chkVisible.TabIndex = 9
        Me.chkVisible.Text = "isVisible"
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'OverlayController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.chkClickable)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLocate)
        Me.Controls.Add(Me.tbOpacity)
        Me.Controls.Add(Me.lblOpacity)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.btnColor)
        Me.Name = "OverlayController"
        Me.Size = New System.Drawing.Size(438, 67)
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnColor As Button
    Friend WithEvents tbOpacity As TrackBar
    Friend WithEvents lblColor As Label
    Friend WithEvents lblOpacity As Label
    Friend WithEvents btnLocate As Button
    Friend WithEvents lblClose As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents chkClickable As CheckBox
    Friend WithEvents chkVisible As CheckBox
    Friend WithEvents btnClose As Button
End Class
