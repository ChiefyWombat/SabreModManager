<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolInventoryForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim ItemTemplate1 As DevExpress.XtraGrid.Views.Tile.ItemTemplate = New DevExpress.XtraGrid.Views.Tile.ItemTemplate()
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition5 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition6 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan4 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan5 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colVersion = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colAuthor = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colSite = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepoItem_HyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colShortDesc = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RunTool_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.RunParam_BarBtnEdit = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Toolbox_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.RefreshTools_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.RemoveTool_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.ResetTool_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.AddTool_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.Info_BarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.Parameter_BarTextEdit = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ParamCaption_StaticTextBar = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colPath = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colLaunchParams = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.RichEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RepoItem_HyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colVersion
        '
        Me.colVersion.FieldName = "Version"
        Me.colVersion.Name = "colVersion"
        Me.colVersion.Visible = True
        Me.colVersion.VisibleIndex = 2
        '
        'colAuthor
        '
        Me.colAuthor.FieldName = "Author"
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.Visible = True
        Me.colAuthor.VisibleIndex = 1
        '
        'colSite
        '
        Me.colSite.ColumnEdit = Me.RepoItem_HyperLinkEdit
        Me.colSite.FieldName = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.Visible = True
        Me.colSite.VisibleIndex = 3
        '
        'RepoItem_HyperLinkEdit
        '
        Me.RepoItem_HyperLinkEdit.LinkColor = System.Drawing.Color.Gold
        Me.RepoItem_HyperLinkEdit.Name = "RepoItem_HyperLinkEdit"
        Me.RepoItem_HyperLinkEdit.SingleClick = True
        Me.RepoItem_HyperLinkEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepoItem_HyperLinkEdit.UseReadOnlyAppearance = False
        '
        'colShortDesc
        '
        Me.colShortDesc.FieldName = "ShortDesc"
        Me.colShortDesc.Name = "colShortDesc"
        Me.colShortDesc.Visible = True
        Me.colShortDesc.VisibleIndex = 4
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RunTool_BarButton, Me.RunParam_BarBtnEdit, Me.Toolbox_BarButton, Me.RefreshTools_BarButton, Me.RemoveTool_BarButton, Me.ResetTool_BarButton, Me.AddTool_BarButton, Me.Info_BarButton, Me.Parameter_BarTextEdit, Me.ParamCaption_StaticTextBar})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit2, Me.RepositoryItemTextEdit2})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(782, 182)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RunTool_BarButton
        '
        Me.RunTool_BarButton.Caption = "Run"
        Me.RunTool_BarButton.Id = 1
        Me.RunTool_BarButton.Name = "RunTool_BarButton"
        '
        'RunParam_BarBtnEdit
        '
        Me.RunParam_BarBtnEdit.Edit = Me.RepositoryItemButtonEdit2
        Me.RunParam_BarBtnEdit.EditWidth = 150
        Me.RunParam_BarBtnEdit.Id = 2
        Me.RunParam_BarBtnEdit.Name = "RunParam_BarBtnEdit"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'Toolbox_BarButton
        '
        Me.Toolbox_BarButton.Caption = "Toolbox Options"
        Me.Toolbox_BarButton.Id = 3
        Me.Toolbox_BarButton.Name = "Toolbox_BarButton"
        '
        'RefreshTools_BarButton
        '
        Me.RefreshTools_BarButton.Caption = "Refresh Toolbox"
        Me.RefreshTools_BarButton.Id = 4
        Me.RefreshTools_BarButton.Name = "RefreshTools_BarButton"
        '
        'RemoveTool_BarButton
        '
        Me.RemoveTool_BarButton.Caption = "Remove Tool"
        Me.RemoveTool_BarButton.Id = 5
        Me.RemoveTool_BarButton.Name = "RemoveTool_BarButton"
        '
        'ResetTool_BarButton
        '
        Me.ResetTool_BarButton.Caption = "Reset Tool"
        Me.ResetTool_BarButton.Id = 6
        Me.ResetTool_BarButton.Name = "ResetTool_BarButton"
        '
        'AddTool_BarButton
        '
        Me.AddTool_BarButton.Caption = "Add Tool"
        Me.AddTool_BarButton.Id = 7
        Me.AddTool_BarButton.Name = "AddTool_BarButton"
        '
        'Info_BarButton
        '
        Me.Info_BarButton.Caption = "Toolbox Info"
        Me.Info_BarButton.Id = 8
        Me.Info_BarButton.Name = "Info_BarButton"
        '
        'Parameter_BarTextEdit
        '
        Me.Parameter_BarTextEdit.Edit = Me.RepositoryItemTextEdit2
        Me.Parameter_BarTextEdit.EditHeight = 10
        Me.Parameter_BarTextEdit.EditWidth = 150
        Me.Parameter_BarTextEdit.Id = 9
        Me.Parameter_BarTextEdit.Name = "Parameter_BarTextEdit"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ParamCaption_StaticTextBar
        '
        Me.ParamCaption_StaticTextBar.Caption = "Parameters:"
        Me.ParamCaption_StaticTextBar.Id = 10
        Me.ParamCaption_StaticTextBar.Name = "ParamCaption_StaticTextBar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "MainPage"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.RunTool_BarButton)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ParamCaption_StaticTextBar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.Parameter_BarTextEdit)
        Me.RibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Tool"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.Toolbox_BarButton)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.RefreshTools_BarButton)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.RemoveTool_BarButton)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.ResetTool_BarButton)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.AddTool_BarButton)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Options"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.Info_BarButton)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Info"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.ExternalRepository = Me.PersistentRepository1
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(500, 338)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoItem_HyperLinkEdit})
        '
        'TileView1
        '
        Me.TileView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TileView1.Appearance.EmptySpace.Options.UseBackColor = True
        Me.TileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colAuthor, Me.colVersion, Me.colSite, Me.colShortDesc, Me.colPath, Me.colLaunchParams, Me.colNotes, Me.colId})
        Me.TileView1.FocusBorderColor = System.Drawing.Color.Gold
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.HighlightFocusedTileOnGridLoad = True
        Me.TileView1.OptionsTiles.IndentBetweenGroups = 0
        Me.TileView1.OptionsTiles.IndentBetweenItems = 0
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(446, 100)
        Me.TileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.TileView1.OptionsTiles.RowCount = 0
        ItemTemplate1.Columns.Add(TableColumnDefinition1)
        ItemTemplate1.Columns.Add(TableColumnDefinition2)
        ItemTemplate1.Columns.Add(TableColumnDefinition3)
        TileViewItemElement1.Appearance.Hovered.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Hovered.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement1.Appearance.Hovered.Options.UseFont = True
        TileViewItemElement1.Appearance.Hovered.Options.UseForeColor = True
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Appearance.Pressed.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement1.Appearance.Pressed.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement1.Appearance.Pressed.Options.UseFont = True
        TileViewItemElement1.Appearance.Pressed.Options.UseForeColor = True
        TileViewItemElement1.Appearance.Selected.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement1.Appearance.Selected.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement1.Appearance.Selected.Options.UseFont = True
        TileViewItemElement1.Appearance.Selected.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.colName
        TileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.Text = "colName"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Column = Me.colVersion
        TileViewItemElement2.ColumnIndex = 2
        TileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.Text = "colVersion"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Column = Me.colAuthor
        TileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 1
        TileViewItemElement3.Text = "colAuthor"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement4.Appearance.Normal.Options.UseFont = True
        TileViewItemElement4.Column = Me.colSite
        TileViewItemElement4.ColumnIndex = 1
        TileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.RowIndex = 1
        TileViewItemElement4.Text = "colSite"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement5.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement5.Appearance.Normal.Options.UseFont = True
        TileViewItemElement5.Column = Me.colShortDesc
        TileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement5.RowIndex = 2
        TileViewItemElement5.Text = "colShortDesc"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        ItemTemplate1.Elements.Add(TileViewItemElement1)
        ItemTemplate1.Elements.Add(TileViewItemElement2)
        ItemTemplate1.Elements.Add(TileViewItemElement3)
        ItemTemplate1.Elements.Add(TileViewItemElement4)
        ItemTemplate1.Elements.Add(TileViewItemElement5)
        ItemTemplate1.Name = "ToolTemplate"
        ItemTemplate1.Rows.Add(TableRowDefinition1)
        ItemTemplate1.Rows.Add(TableRowDefinition2)
        ItemTemplate1.Rows.Add(TableRowDefinition3)
        TableSpan1.ColumnIndex = 1
        TableSpan1.ColumnSpan = 2
        TableSpan1.RowIndex = 1
        TableSpan2.ColumnSpan = 2
        TableSpan2.RowIndex = 2
        ItemTemplate1.Spans.Add(TableSpan1)
        ItemTemplate1.Spans.Add(TableSpan2)
        Me.TileView1.Templates.Add(ItemTemplate1)
        TableColumnDefinition4.Length.Value = 143.0R
        TableColumnDefinition5.Length.Value = 214.0R
        TableColumnDefinition6.Length.Value = 65.0R
        Me.TileView1.TileColumns.Add(TableColumnDefinition4)
        Me.TileView1.TileColumns.Add(TableColumnDefinition5)
        Me.TileView1.TileColumns.Add(TableColumnDefinition6)
        TableRowDefinition4.Length.Value = 32.0R
        TableRowDefinition4.PaddingBottom = 1
        TableRowDefinition4.PaddingTop = 1
        TableRowDefinition5.Length.Value = 32.0R
        TableRowDefinition5.PaddingBottom = 2
        TableRowDefinition5.PaddingTop = 2
        TableRowDefinition6.Length.Value = 20.0R
        Me.TileView1.TileRows.Add(TableRowDefinition4)
        Me.TileView1.TileRows.Add(TableRowDefinition5)
        Me.TileView1.TileRows.Add(TableRowDefinition6)
        TableSpan3.ColumnSpan = 2
        TableSpan4.ColumnIndex = 1
        TableSpan4.ColumnSpan = 2
        TableSpan4.RowIndex = 1
        TableSpan5.ColumnSpan = 3
        TableSpan5.RowIndex = 2
        Me.TileView1.TileSpans.Add(TableSpan3)
        Me.TileView1.TileSpans.Add(TableSpan4)
        Me.TileView1.TileSpans.Add(TableSpan5)
        TileViewItemElement6.Appearance.Hovered.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement6.Appearance.Hovered.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement6.Appearance.Hovered.Options.UseFont = True
        TileViewItemElement6.Appearance.Hovered.Options.UseForeColor = True
        TileViewItemElement6.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement6.Appearance.Normal.Options.UseFont = True
        TileViewItemElement6.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement6.Appearance.Pressed.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement6.Appearance.Pressed.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement6.Appearance.Pressed.Options.UseFont = True
        TileViewItemElement6.Appearance.Pressed.Options.UseForeColor = True
        TileViewItemElement6.Appearance.Selected.Font = New System.Drawing.Font("PF Din Text Cond Pro", 16.2!)
        TileViewItemElement6.Appearance.Selected.ForeColor = System.Drawing.Color.Goldenrod
        TileViewItemElement6.Appearance.Selected.Options.UseFont = True
        TileViewItemElement6.Appearance.Selected.Options.UseForeColor = True
        TileViewItemElement6.Column = Me.colName
        TileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement6.StretchHorizontal = True
        TileViewItemElement6.StretchVertical = True
        TileViewItemElement6.Text = "colName"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement7.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement7.Appearance.Normal.Options.UseFont = True
        TileViewItemElement7.Column = Me.colVersion
        TileViewItemElement7.ColumnIndex = 2
        TileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement7.Text = "colVersion"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement8.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
        TileViewItemElement8.AnchorElementIndex = 6
        TileViewItemElement8.AnchorOffset = New System.Drawing.Point(0, -2)
        TileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement8.Appearance.Normal.Options.UseFont = True
        TileViewItemElement8.Column = Me.colAuthor
        TileViewItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement8.RowIndex = 1
        TileViewItemElement8.StretchHorizontal = True
        TileViewItemElement8.StretchVertical = True
        TileViewItemElement8.Text = "colAuthor"
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement9.Appearance.Hovered.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!)
        TileViewItemElement9.Appearance.Hovered.ForeColor = System.Drawing.Color.SkyBlue
        TileViewItemElement9.Appearance.Hovered.Options.UseFont = True
        TileViewItemElement9.Appearance.Hovered.Options.UseForeColor = True
        TileViewItemElement9.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement9.Appearance.Normal.ForeColor = System.Drawing.Color.SkyBlue
        TileViewItemElement9.Appearance.Normal.Options.UseFont = True
        TileViewItemElement9.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement9.Appearance.Pressed.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!)
        TileViewItemElement9.Appearance.Pressed.ForeColor = System.Drawing.Color.SkyBlue
        TileViewItemElement9.Appearance.Pressed.Options.UseFont = True
        TileViewItemElement9.Appearance.Pressed.Options.UseForeColor = True
        TileViewItemElement9.Appearance.Selected.Font = New System.Drawing.Font("PF Din Text Cond Pro", 7.8!)
        TileViewItemElement9.Appearance.Selected.ForeColor = System.Drawing.Color.SkyBlue
        TileViewItemElement9.Appearance.Selected.Options.UseFont = True
        TileViewItemElement9.Appearance.Selected.Options.UseForeColor = True
        TileViewItemElement9.Column = Me.colSite
        TileViewItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement9.RowIndex = 2
        TileViewItemElement9.StretchHorizontal = True
        TileViewItemElement9.Text = "colSite"
        TileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        TileViewItemElement10.Appearance.Normal.Font = New System.Drawing.Font("PF Din Text Cond Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement10.Appearance.Normal.Options.UseFont = True
        TileViewItemElement10.Column = Me.colShortDesc
        TileViewItemElement10.ColumnIndex = 1
        TileViewItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement10.RowIndex = 1
        TileViewItemElement10.StretchHorizontal = True
        TileViewItemElement10.StretchVertical = True
        TileViewItemElement10.Text = "colShortDesc"
        TileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement11.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
        TileViewItemElement11.AnchorElementIndex = 1
        TileViewItemElement11.AnchorIndent = 1
        TileViewItemElement11.AnchorOffset = New System.Drawing.Point(0, -2)
        TileViewItemElement11.ColumnIndex = 2
        TileViewItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement11.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement11.Text = "v"
        TileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement12.RowIndex = 1
        TileViewItemElement12.Text = "by:"
        TileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TileView1.TileTemplate.Add(TileViewItemElement6)
        Me.TileView1.TileTemplate.Add(TileViewItemElement7)
        Me.TileView1.TileTemplate.Add(TileViewItemElement8)
        Me.TileView1.TileTemplate.Add(TileViewItemElement9)
        Me.TileView1.TileTemplate.Add(TileViewItemElement10)
        Me.TileView1.TileTemplate.Add(TileViewItemElement11)
        Me.TileView1.TileTemplate.Add(TileViewItemElement12)
        '
        'colPath
        '
        Me.colPath.FieldName = "Path"
        Me.colPath.Name = "colPath"
        Me.colPath.Visible = True
        Me.colPath.VisibleIndex = 5
        '
        'colLaunchParams
        '
        Me.colLaunchParams.FieldName = "LaunchParams"
        Me.colLaunchParams.Name = "colLaunchParams"
        Me.colLaunchParams.Visible = True
        Me.colLaunchParams.VisibleIndex = 6
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 7
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 8
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 182)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.MinSize = 500
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.RichEditControl1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel2.MinSize = 350
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(782, 338)
        Me.SplitContainerControl1.SplitterPosition = 719
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'RichEditControl1
        '
        Me.RichEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
        Me.RichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichEditControl1.Location = New System.Drawing.Point(0, 31)
        Me.RichEditControl1.LookAndFeel.SkinName = "McSkin"
        Me.RichEditControl1.MenuManager = Me.RibbonControl1
        Me.RichEditControl1.Name = "RichEditControl1"
        Me.RichEditControl1.ReadOnly = True
        Me.RichEditControl1.Size = New System.Drawing.Size(267, 307)
        Me.RichEditControl1.TabIndex = 0
        Me.RichEditControl1.Views.SimpleView.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("PF Din Text Cond Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelControl1.Size = New System.Drawing.Size(267, 31)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Notes:"
        '
        'ToolInventoryForm
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 520)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.HtmlText = "Extensions and Add-ons"
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ToolInventoryForm"
        Me.Ribbon = Me.RibbonControl1
        Me.Tag = "1"
        CType(Me.RepoItem_HyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RunTool_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RunParam_BarBtnEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Toolbox_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RefreshTools_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RemoveTool_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ResetTool_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AddTool_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Info_BarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Parameter_BarTextEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ParamCaption_StaticTextBar As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colAuthor As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colVersion As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colSite As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colShortDesc As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPath As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colLaunchParams As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepoItem_HyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents RichEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
