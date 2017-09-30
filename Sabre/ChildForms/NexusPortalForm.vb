'Imports CefSharp
'Imports CefSharp.WinForms

Imports DevExpress.XtraEditors

Public Class NexusPortalForm
    'Private cef_browser As ChromiumWebBrowser



    Private Sub NexusPortalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myBrowser.Navigate("www.nexusmods.com/witcher3/")

    End Sub

    Private Sub myBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles myBrowser.Navigating
        url_txtboxCtrl.EditValue = DirectCast(sender, WebBrowser).Url

    End Sub

    Private Sub url_txtboxCtrl_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles url_txtboxCtrl.ButtonClick
        If e.Button.Index = 1 Then
            SafeNavigate()
        End If
    End Sub

    Private Sub url_txtboxCtrl_KeyDown(sender As Object, e As KeyEventArgs) Handles url_txtboxCtrl.KeyDown
        If e.KeyCode = Keys.Enter Then
            SafeNavigate()
        End If
    End Sub

    Private Sub SafeNavigate()
        If url_txtboxCtrl.EditValue.ToString().StartsWith("http://www.nexusmods.com/witcher3/") = False Then
            If url_txtboxCtrl.EditValue.ToString().StartsWith("https://www.nexusmods.com/witcher3/") = False Then
                XtraMessageBox.Show("You must remain within the Nexus network, specifically the Witcher 3 section.")
                Exit Sub
            End If
        Else
            myBrowser.Navigate(url_txtboxCtrl.EditValue)
        End If
    End Sub

    Private Sub navBack_Button_Click(sender As Object, e As EventArgs) Handles navBack_Button.Click
        If myBrowser.CanGoBack Then
            myBrowser.GoBack()
        End If
    End Sub

    Private Sub navForward_Button_Click(sender As Object, e As EventArgs) Handles navForward_Button.Click
        If myBrowser.CanGoForward Then
            myBrowser.GoForward()
        End If
    End Sub

    Private Sub navHome_Button_Click(sender As Object, e As EventArgs) Handles navHome_Button.Click
        myBrowser.Navigate("http://www.nexusmods.com/witcher3/")
    End Sub
End Class