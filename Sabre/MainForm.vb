Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows

Partial Public Class MainForm
    Private _soundPlayer As Media.SoundPlayer = New Media.SoundPlayer
    Private _menuButtonList As List(Of SimpleButton) = New List(Of SimpleButton)
    Private _formDictionary As Dictionary(Of SimpleButton, XtraForm) = New Dictionary(Of SimpleButton, XtraForm)
    Private _IsShown As Boolean = False


    'Private _formNexusPortal As NexusPortalForm = Nothing
    'Private _formModInv As ModInventoryForm = Nothing
    'Private _formToolInv As ToolInventoryForm = Nothing
    'Private _formSettings As SettingsConsoleForm = Nothing
    'Private _formHome As HomeForm = Nothing



    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()

        With _menuButtonList
            .Add(NexusPortal_ButtonCtrl)
            .Add(MyMods_ButtonCtrl)
            .Add(MyTools_ButtonCtrl)
            .Add(MySettings_ButtonCtrl)
            .Add(MyHome_ButtonCtrl)
        End With

        With _formDictionary
            .Add(NexusPortal_ButtonCtrl, NexusPortalForm)
            .Add(MyMods_ButtonCtrl, ModInventoryForm)
            .Add(MyTools_ButtonCtrl, ToolInventoryForm)
            .Add(MySettings_ButtonCtrl, SettingsForm)
            .Add(MyHome_ButtonCtrl, UserHomeForm)
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OpenDefaultForm()
    End Sub

    Private Sub NexusPortal_ButtonCtrl_Click(sender As Object, e As EventArgs) Handles NexusPortal_ButtonCtrl.Click, MyTools_ButtonCtrl.Click, MySettings_ButtonCtrl.Click, MyMods_ButtonCtrl.Click, MyHome_ButtonCtrl.Click

        '_soundPlayer.Stream = My.Resources.Menu_Button_Click
        '_soundPlayer.Play()
        MenuButtonSelectionManager(sender)
    End Sub

    Private Sub MenuButtonSelectionManager(sender As Object)
        '*** Manage visual logic ***
        Dim _button = DirectCast(sender, SimpleButton)
        _button.BackgroundImage = My.Resources.Button_bg
        _button.BackgroundImageLayout = ImageLayout.Stretch
        _button.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        _button.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        _button.ForeColor = Color.Black
        _button.Appearance.FontSizeDelta = 5

        For Each b As SimpleButton In _menuButtonList
            If b.Name <> _button.Name Then
                b.BackgroundImage = Nothing
                b.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
                b.ForeColor = Color.WhiteSmoke
                b.Appearance.FontSizeDelta = 0
            End If
        Next

        '*** Activate corresponding sub-app ***

        Dim _formCheck As XtraForm = _formDictionary.Item(_button)
        For Each f In Application.OpenForms
            If _formCheck.Name = f.Name Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim _f As XtraForm = Activator.CreateInstance(_formDictionary.Item(_button).GetType)
        '_f.BackColor = Color.Transparent
        _f.MdiParent = Me
        Me.components.Add(_f)
        _f.Show()
        _f.Activate()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub OpenDefaultForm()
        Dim _f As XtraForm = New UserHomeForm()
        '_f.BackColor = Color.Transparent
        _f.MdiParent = Me
        Me.components.Add(_f)
        _f.Show()
        DocumentManager1.View.ActivateDocument(_f)
        _IsShown = True
    End Sub

    Private Sub DocumentManager1_DocumentActivate(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs) Handles DocumentManager1.DocumentActivate
        If _IsShown Then
            If e.Document IsNot Nothing Then
                Select Case e.Document.Control.Tag
                    Case 0
                        MyHome_ButtonCtrl.PerformClick()
                    Case 1
                        MyTools_ButtonCtrl.PerformClick()
                    Case 2
                        MySettings_ButtonCtrl.PerformClick()
                    Case 3
                        MyMods_ButtonCtrl.PerformClick()
                    Case 4
                        NexusPortal_ButtonCtrl.PerformClick()

                End Select
            End If
        End If
    End Sub

    Private Sub NexusPortal_ButtonCtrl_DoubleClick(sender As Object, e As EventArgs) Handles NexusPortal_ButtonCtrl.DoubleClick, MyTools_ButtonCtrl.DoubleClick, MySettings_ButtonCtrl.DoubleClick, MyMods_ButtonCtrl.DoubleClick, MyHome_ButtonCtrl.DoubleClick

    End Sub

    Private Sub Undock_ButtonCtrl_Click(sender As Object, e As EventArgs) Handles Undock_ButtonCtrl.Click
        If DocumentManager1.View.ActiveDocument IsNot Nothing Then
            Dim _baseDoc As DevExpress.XtraBars.Docking2010.Views.BaseDocument = DocumentManager1.View.ActiveDocument
            With DirectCast(_baseDoc.Form, XtraForm)
                .MdiParent = Nothing
                .Owner = DocumentManager1.MdiParent
            End With
            DocumentManager1.View.FloatDocuments.Add(_baseDoc)
        End If
    End Sub

    Private Sub HyperLinkEdit1_OpenLink(sender As Object, e As Controls.OpenLinkEventArgs) Handles HyperLinkEdit1.OpenLink
        e.EditValue = "https://discord.gg/mRnty9P"
    End Sub
End Class
