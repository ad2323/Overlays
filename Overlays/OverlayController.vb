Public Class OverlayController


    Public OverlayForm As New OverlayTemplate

    Public Sub Initialize(Optional percent As Integer = 70)
        AddHandler OverlayForm.FormClosing, AddressOf Overlay_Form_Closing
        SetColor(lblColor.BackColor)
        OverlayForm.HideLocator()
        SetOpacity(percent)
        tbOpacity.Value = percent
        OverlayForm.Show()
    End Sub

    Public Sub PerformClose(Optional closeOverlay = True)
        If (closeOverlay) Then
            OverlayForm.Close()
        End If
        Dispose()
    End Sub

    Sub SetColor(color As Color)
        OverlayForm.BackColor = color
        lblColor.BackColor = color
    End Sub


    Sub SetOpacity(percent)
        OverlayForm.Opacity = percent
        lblOpacity.Text = percent & "%"
        OverlayForm.Opacity = percent / 100
    End Sub

    Private Sub Overlay_Form_Closing(sender As Object, e As FormClosingEventArgs)
        PerformClose(False)
    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        PerformClose()
    End Sub

    Private Sub lblLocate_Click(sender As Object, e As EventArgs) Handles btnLocate.Click
        OverlayForm.PerformLocate()
    End Sub

    Private Sub tbOpacity_Scroll(sender As Object, e As EventArgs) Handles tbOpacity.Scroll
        SetOpacity(tbOpacity.Value)
    End Sub

    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Dim resultOk = ColorDialog1.ShowDialog()
        If (resultOk = DialogResult.OK) Then
            SetColor(ColorDialog1.Color)
        End If
    End Sub

    Private Sub chkClickable_CheckedChanged(sender As Object, e As EventArgs) Handles chkClickable.CheckedChanged
        OverlayForm.SetClickable(chkClickable.Checked)
    End Sub

    Private Sub chkVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisible.CheckedChanged
        OverlayForm.SetVisible(chkVisible.Checked)
    End Sub
End Class
