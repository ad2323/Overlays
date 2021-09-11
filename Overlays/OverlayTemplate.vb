Imports System.Runtime.InteropServices

Public Class OverlayTemplate

    Private InitialStyle As Integer
    Dim PercentVisible As Decimal

    Public Sub HideLocator()
        borderLeft.Visible = False
        borderRight.Visible = False
        borderTop.Visible = False
        borderBottom.Visible = False
    End Sub

    Public Async Sub PerformLocate()
        Dim ctr = 0
        While ctr <= 5
            Await Task.Delay(100)
            borderLeft.Visible = Not borderLeft.Visible
            borderRight.Visible = Not borderRight.Visible
            borderTop.Visible = Not borderTop.Visible
            borderBottom.Visible = Not borderBottom.Visible
            ctr += 1
        End While
        HideLocator()
    End Sub

    Public Sub SetClickable(ByVal clickable As Boolean)
        ' Grab the Extended Style information
        ' for this window and store it.
        ' Set this window to Transparent
        ' (to the mouse that is!)
        PercentVisible = Opacity
        If (clickable) Then
            InitialStyle = GetWindowLong(Me.Handle, GWL.ExStyle)
            ' This creates a new Extended Style
            ' for our window, which takes effect
            ' immediately upon being set, that
            ' combines the initial style of our window
            ' (saved in Form.Load) and adds the ability
            ' to be Transparent to the mouse.
            ' Both Layered and Transparent must be
            ' turned on for this to work AND have
            '  the window render properly!
            SetWindowLong(Me.Handle, GWL.ExStyle, InitialStyle Or WS_EX.Layered Or WS_EX.Transparent)

            ' Don't forget to set the Alpha
            ' for the window or else you won't be able
            ' to see the window! Possible values
            ' are 0 (visibly transparent)
            ' to 255 (visibly opaque). I'll set
            ' it to 70% visible here for show.
            ' The second parameter is 0, because
            ' we're not using a ColorKey!
            SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, LWA.Alpha)
        Else
            SetWindowLong(Me.Handle, GWL.ExStyle, InitialStyle)
            SetLayeredWindowAttributes(Me.Handle, 0, 255 * PercentVisible, LWA.Alpha)
        End If
    End Sub

    Public Sub SetVisible(visible As Boolean)
        If (visible) Then
            Show()
        Else
            Hide()
        End If
    End Sub



    Private Sub OverlayTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Enum GWL As Integer
        ExStyle = -20
    End Enum

    Public Enum WS_EX As Integer
        Transparent = &H20
        Layered = &H80000
    End Enum

    Public Enum LWA As Integer
        ColorKey = &H1
        Alpha = &H2
    End Enum

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")>
    Public Shared Function GetWindowLong(
    ByVal hWnd As IntPtr,
    ByVal nIndex As GWL
        ) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowLong")>
    Public Shared Function SetWindowLong(
    ByVal hWnd As IntPtr,
    ByVal nIndex As GWL,
    ByVal dwNewLong As WS_EX
        ) As Integer
    End Function

    <DllImport("user32.dll",
  EntryPoint:="SetLayeredWindowAttributes")>
    Public Shared Function SetLayeredWindowAttributes(
    ByVal hWnd As IntPtr,
    ByVal crKey As Integer,
    ByVal alpha As Byte,
    ByVal dwFlags As LWA
        ) As Boolean
    End Function
End Class
