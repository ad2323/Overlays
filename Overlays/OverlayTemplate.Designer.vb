<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverlayTemplate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverlayTemplate))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.borderRight = New System.Windows.Forms.Label()
        Me.borderLeft = New System.Windows.Forms.Label()
        Me.borderTop = New System.Windows.Forms.Label()
        Me.borderBottom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'borderRight
        '
        Me.borderRight.BackColor = System.Drawing.Color.Red
        Me.borderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.borderRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borderRight.ForeColor = System.Drawing.Color.White
        Me.borderRight.Location = New System.Drawing.Point(727, 0)
        Me.borderRight.Name = "borderRight"
        Me.borderRight.Size = New System.Drawing.Size(2, 551)
        Me.borderRight.TabIndex = 0
        '
        'borderLeft
        '
        Me.borderLeft.BackColor = System.Drawing.Color.Red
        Me.borderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.borderLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borderLeft.ForeColor = System.Drawing.Color.White
        Me.borderLeft.Location = New System.Drawing.Point(0, 0)
        Me.borderLeft.Name = "borderLeft"
        Me.borderLeft.Size = New System.Drawing.Size(2, 551)
        Me.borderLeft.TabIndex = 1
        '
        'borderTop
        '
        Me.borderTop.BackColor = System.Drawing.Color.Red
        Me.borderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.borderTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borderTop.ForeColor = System.Drawing.Color.White
        Me.borderTop.Location = New System.Drawing.Point(2, 0)
        Me.borderTop.Name = "borderTop"
        Me.borderTop.Size = New System.Drawing.Size(725, 2)
        Me.borderTop.TabIndex = 2
        '
        'borderBottom
        '
        Me.borderBottom.BackColor = System.Drawing.Color.Red
        Me.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.borderBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borderBottom.ForeColor = System.Drawing.Color.White
        Me.borderBottom.Location = New System.Drawing.Point(2, 549)
        Me.borderBottom.Name = "borderBottom"
        Me.borderBottom.Size = New System.Drawing.Size(725, 2)
        Me.borderBottom.TabIndex = 3
        '
        'OverlayTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(729, 551)
        Me.Controls.Add(Me.borderBottom)
        Me.Controls.Add(Me.borderTop)
        Me.Controls.Add(Me.borderLeft)
        Me.Controls.Add(Me.borderRight)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OverlayTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents borderLeft As Label
    Friend WithEvents borderTop As Label
    Friend WithEvents borderBottom As Label
    Friend WithEvents borderRight As Label
End Class
