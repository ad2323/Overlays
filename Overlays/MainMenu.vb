Public Class MainForm
    Dim OverlayControllers As New List(Of OverlayController)


    Sub AddNewOverlay()
        Dim newOverlay = New OverlayController
        newOverlay.Initialize(70)
        OverlayControllers.Add(newOverlay)
        FlowLayoutPanel1.Controls.Add(newOverlay)
    End Sub

    Sub CloseAllOverlay()
        For Each overlayController As OverlayController In OverlayControllers
            overlayController.PerformClose()
        Next
    End Sub

    Sub ProgramShutDown()
        End
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        AddNewOverlay()
    End Sub

    Private Sub btnCloseAll_Click(sender As Object, e As EventArgs) Handles btnCloseAll.Click
        CloseAllOverlay()
    End Sub

    Private Sub btnProgramExit_Click(sender As Object, e As EventArgs) Handles btnProgramExit.Click
        ProgramShutDown()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
