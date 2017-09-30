<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NexusPortalForm
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.browser_PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.myBrowser = New System.Windows.Forms.WebBrowser()
        Me.nav_PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.navHome_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.navForward_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.navBack_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.url_txtboxCtrl = New DevExpress.XtraEditors.MRUEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.browser_PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.browser_PanelCtrl.SuspendLayout()
        CType(Me.nav_PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_PanelCtrl.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.url_txtboxCtrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'browser_PanelCtrl
        '
        Me.browser_PanelCtrl.Controls.Add(Me.myBrowser)
        Me.browser_PanelCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser_PanelCtrl.Location = New System.Drawing.Point(0, 60)
        Me.browser_PanelCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.browser_PanelCtrl.Name = "browser_PanelCtrl"
        Me.browser_PanelCtrl.Padding = New System.Windows.Forms.Padding(2)
        Me.browser_PanelCtrl.Size = New System.Drawing.Size(796, 437)
        Me.browser_PanelCtrl.TabIndex = 2
        '
        'myBrowser
        '
        Me.myBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myBrowser.Location = New System.Drawing.Point(4, 4)
        Me.myBrowser.Margin = New System.Windows.Forms.Padding(2)
        Me.myBrowser.MinimumSize = New System.Drawing.Size(15, 17)
        Me.myBrowser.Name = "myBrowser"
        Me.myBrowser.ScriptErrorsSuppressed = True
        Me.myBrowser.Size = New System.Drawing.Size(788, 429)
        Me.myBrowser.TabIndex = 0
        Me.myBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'nav_PanelCtrl
        '
        Me.nav_PanelCtrl.Controls.Add(Me.LayoutControl1)
        Me.nav_PanelCtrl.Dock = System.Windows.Forms.DockStyle.Top
        Me.nav_PanelCtrl.Location = New System.Drawing.Point(0, 0)
        Me.nav_PanelCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.nav_PanelCtrl.Name = "nav_PanelCtrl"
        Me.nav_PanelCtrl.Padding = New System.Windows.Forms.Padding(1)
        Me.nav_PanelCtrl.Size = New System.Drawing.Size(796, 60)
        Me.nav_PanelCtrl.TabIndex = 3
        '
        'LayoutControl1
        '
        Me.LayoutControl1.AllowCustomization = False
        Me.LayoutControl1.Controls.Add(Me.navHome_Button)
        Me.LayoutControl1.Controls.Add(Me.navForward_Button)
        Me.LayoutControl1.Controls.Add(Me.navBack_Button)
        Me.LayoutControl1.Controls.Add(Me.url_txtboxCtrl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(513, 118, 675, 599)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(790, 54)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'navHome_Button
        '
        Me.navHome_Button.AutoWidthInLayoutControl = True
        Me.navHome_Button.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.navHome_Button.ImageOptions.ImageUri.Uri = "Home;Size16x16"
        Me.navHome_Button.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.navHome_Button.Location = New System.Drawing.Point(675, 13)
        Me.navHome_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.navHome_Button.Name = "navHome_Button"
        Me.navHome_Button.Size = New System.Drawing.Size(26, 27)
        Me.navHome_Button.StyleController = Me.LayoutControl1
        Me.navHome_Button.TabIndex = 7
        '
        'navForward_Button
        '
        Me.navForward_Button.AutoWidthInLayoutControl = True
        Me.navForward_Button.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.navForward_Button.ImageOptions.ImageUri.Uri = "Forward;Size16x16"
        Me.navForward_Button.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.navForward_Button.Location = New System.Drawing.Point(751, 13)
        Me.navForward_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.navForward_Button.Name = "navForward_Button"
        Me.navForward_Button.Size = New System.Drawing.Size(26, 27)
        Me.navForward_Button.StyleController = Me.LayoutControl1
        Me.navForward_Button.TabIndex = 6
        '
        'navBack_Button
        '
        Me.navBack_Button.AutoWidthInLayoutControl = True
        Me.navBack_Button.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.navBack_Button.ImageOptions.ImageUri.Uri = "Backward;Size16x16"
        Me.navBack_Button.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.navBack_Button.Location = New System.Drawing.Point(713, 13)
        Me.navBack_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.navBack_Button.Name = "navBack_Button"
        Me.navBack_Button.Size = New System.Drawing.Size(26, 27)
        Me.navBack_Button.StyleController = Me.LayoutControl1
        Me.navBack_Button.TabIndex = 5
        '
        'url_txtboxCtrl
        '
        Me.url_txtboxCtrl.EditValue = ""
        Me.url_txtboxCtrl.Location = New System.Drawing.Point(3, 16)
        Me.url_txtboxCtrl.Margin = New System.Windows.Forms.Padding(2)
        Me.url_txtboxCtrl.Name = "url_txtboxCtrl"
        Me.url_txtboxCtrl.Properties.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.url_txtboxCtrl.Properties.Appearance.Options.UseForeColor = True
        Me.url_txtboxCtrl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
        Me.url_txtboxCtrl.Properties.ImmediatePopup = False
        Me.url_txtboxCtrl.Properties.ValidateOnEnterKey = False
        Me.url_txtboxCtrl.Size = New System.Drawing.Size(660, 22)
        Me.url_txtboxCtrl.StyleController = Me.LayoutControl1
        Me.url_txtboxCtrl.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem4, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(790, 54)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gold
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.Control = Me.url_txtboxCtrl
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(662, 54)
        Me.LayoutControlItem1.Text = "URL:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        Me.LayoutControlItem1.TrimClientAreaToControl = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.navBack_Button
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LayoutControlItem2.Location = New System.Drawing.Point(710, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(28, 54)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        Me.LayoutControlItem2.TrimClientAreaToControl = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.navForward_Button
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LayoutControlItem3.Location = New System.Drawing.Point(748, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(28, 54)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.TrimClientAreaToControl = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(662, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 54)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(776, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 54)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(738, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 54)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.navHome_Button
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LayoutControlItem4.Location = New System.Drawing.Point(672, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(28, 54)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.TrimClientAreaToControl = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(700, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 54)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'NexusPortalForm
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 497)
        Me.Controls.Add(Me.browser_PanelCtrl)
        Me.Controls.Add(Me.nav_PanelCtrl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NexusPortalForm"
        Me.Tag = "4"
        Me.Text = " Nexus Portal"
        CType(Me.browser_PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.browser_PanelCtrl.ResumeLayout(False)
        CType(Me.nav_PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_PanelCtrl.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.url_txtboxCtrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents browser_PanelCtrl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents nav_PanelCtrl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents navHome_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents navForward_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents navBack_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents myBrowser As WebBrowser
    Friend WithEvents url_txtboxCtrl As DevExpress.XtraEditors.MRUEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
