namespace SQLIndexManager {
  partial class ConnectionManagerBox {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      DevExpress.XtraGrid.Columns.GridColumn Server;
      DevExpress.XtraGrid.Columns.GridColumn AuthType;
      DevExpress.XtraGrid.Columns.GridColumn User;
      DevExpress.XtraGrid.Columns.GridColumn Password;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionManagerBox));
      this.grid = new DevExpress.XtraGrid.GridControl();
      this.view = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.buttonNewConnection = new DevExpress.XtraBars.BarButtonItem();
      this.buttonDeleteConnection = new DevExpress.XtraBars.BarButtonItem();
      this.buttonImportConnection = new DevExpress.XtraBars.BarButtonItem();
      this.buttonEditConnection = new DevExpress.XtraBars.BarButtonItem();
      this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
      this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
      this.boxSearch = new DevExpress.XtraBars.BarEditItem();
      Server = new DevExpress.XtraGrid.Columns.GridColumn();
      AuthType = new DevExpress.XtraGrid.Columns.GridColumn();
      User = new DevExpress.XtraGrid.Columns.GridColumn();
      Password = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // grid
      // 
      this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid.Font = new System.Drawing.Font("Tahoma", 9F);
      this.grid.Location = new System.Drawing.Point(0, 27);
      this.grid.MainView = this.view;
      this.grid.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
      this.grid.Name = "grid";
      this.grid.Size = new System.Drawing.Size(790, 368);
      this.grid.TabIndex = 1;
      this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
      // 
      // view
      // 
      this.view.Appearance.EvenRow.BackColor = System.Drawing.Color.Gainsboro;
      this.view.Appearance.EvenRow.Options.UseBackColor = true;
      this.view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.75F);
      this.view.Appearance.HeaderPanel.Options.UseFont = true;
      this.view.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent;
      this.view.Appearance.HideSelectionRow.Options.UseBackColor = true;
      this.view.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
      this.view.Appearance.OddRow.Options.UseBackColor = true;
      this.view.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.75F);
      this.view.Appearance.Row.Options.UseFont = true;
      this.view.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
      this.view.Appearance.SelectedRow.Options.UseBackColor = true;
      this.view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.view.ColumnPanelRowHeight = 26;
      this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            Server,
            AuthType,
            User,
            Password});
      this.view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
      this.view.GridControl = this.grid;
      this.view.Name = "view";
      this.view.OptionsBehavior.Editable = false;
      this.view.OptionsCustomization.AllowColumnMoving = false;
      this.view.OptionsCustomization.AllowColumnResizing = false;
      this.view.OptionsCustomization.AllowGroup = false;
      this.view.OptionsCustomization.AllowQuickHideColumns = false;
      this.view.OptionsDetail.EnableMasterViewMode = false;
      this.view.OptionsDetail.ShowDetailTabs = false;
      this.view.OptionsDetail.SmartDetailExpand = false;
      this.view.OptionsFilter.AllowFilterEditor = false;
      this.view.OptionsFind.AllowFindPanel = false;
      this.view.OptionsFind.FindFilterColumns = "Server";
      this.view.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
      this.view.OptionsFind.FindNullPrompt = "";
      this.view.OptionsFind.ShowClearButton = false;
      this.view.OptionsFind.ShowCloseButton = false;
      this.view.OptionsFind.ShowFindButton = false;
      this.view.OptionsMenu.EnableColumnMenu = false;
      this.view.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.view.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.view.OptionsSelection.EnableAppearanceHideSelection = false;
      this.view.OptionsSelection.UseIndicatorForSelection = false;
      this.view.OptionsView.EnableAppearanceEvenRow = true;
      this.view.OptionsView.EnableAppearanceOddRow = true;
      this.view.OptionsView.ShowGroupPanel = false;
      this.view.OptionsView.ShowIndicator = false;
      this.view.RowHeight = 24;
      // 
      // Server
      // 
      Server.Caption = "Server";
      Server.FieldName = "Server";
      Server.MaxWidth = 200;
      Server.MinWidth = 200;
      Server.Name = "Server";
      Server.Visible = true;
      Server.VisibleIndex = 0;
      Server.Width = 200;
      // 
      // AuthType
      // 
      AuthType.Caption = "AuthType";
      AuthType.FieldName = "AuthType";
      AuthType.MaxWidth = 105;
      AuthType.MinWidth = 105;
      AuthType.Name = "AuthType";
      AuthType.Visible = true;
      AuthType.VisibleIndex = 1;
      AuthType.Width = 105;
      // 
      // User
      // 
      User.Caption = "User";
      User.FieldName = "User";
      User.MaxWidth = 130;
      User.MinWidth = 130;
      User.Name = "User";
      User.Visible = true;
      User.VisibleIndex = 2;
      User.Width = 130;
      // 
      // Password
      // 
      Password.Caption = "Password";
      Password.FieldName = "Password";
      Password.MaxWidth = 130;
      Password.MinWidth = 130;
      Password.Name = "Password";
      Password.Visible = true;
      Password.VisibleIndex = 3;
      Password.Width = 130;
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.buttonNewConnection,
            this.buttonDeleteConnection,
            this.buttonImportConnection,
            this.buttonEditConnection,
            this.barEditItem1});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 7;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.QuickToolbarItemLinks.Add(this.buttonNewConnection);
      this.ribbonControl1.QuickToolbarItemLinks.Add(this.buttonEditConnection);
      this.ribbonControl1.QuickToolbarItemLinks.Add(this.buttonDeleteConnection);
      this.ribbonControl1.QuickToolbarItemLinks.Add(this.barEditItem1);
      this.ribbonControl1.QuickToolbarItemLinks.Add(this.buttonImportConnection);
      this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
      this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
      this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
      this.ribbonControl1.ShowCategoryInCaption = false;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new System.Drawing.Size(790, 27);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      // 
      // buttonNewConnection
      // 
      this.buttonNewConnection.Caption = "New Connection";
      this.buttonNewConnection.Id = 2;
      this.buttonNewConnection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
      this.buttonNewConnection.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
      this.buttonNewConnection.Name = "buttonNewConnection";
      // 
      // buttonDeleteConnection
      // 
      this.buttonDeleteConnection.Caption = "Delete Connection";
      this.buttonDeleteConnection.Id = 3;
      this.buttonDeleteConnection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
      this.buttonDeleteConnection.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
      this.buttonDeleteConnection.Name = "buttonDeleteConnection";
      // 
      // buttonImportConnection
      // 
      this.buttonImportConnection.Caption = "Import Connections From CSV";
      this.buttonImportConnection.Id = 4;
      this.buttonImportConnection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
      this.buttonImportConnection.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
      this.buttonImportConnection.Name = "buttonImportConnection";
      // 
      // buttonEditConnection
      // 
      this.buttonEditConnection.Caption = "Edit Connection";
      this.buttonEditConnection.Id = 5;
      this.buttonEditConnection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
      this.buttonEditConnection.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
      this.buttonEditConnection.Name = "buttonEditConnection";
      // 
      // barEditItem1
      // 
      this.barEditItem1.Edit = this.repositoryItemSearchControl1;
      this.barEditItem1.EditWidth = 220;
      this.barEditItem1.Id = 6;
      this.barEditItem1.Name = "barEditItem1";
      // 
      // repositoryItemSearchControl1
      // 
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
      this.repositoryItemSearchControl1.Client = this.grid;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.repositoryItemSearchControl1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
      // 
      // boxSearch
      // 
      this.boxSearch.Edit = null;
      this.boxSearch.EditWidth = 220;
      this.boxSearch.Id = 15;
      this.boxSearch.Name = "boxSearch";
      // 
      // ConnectionManagerBox
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(790, 395);
      this.Controls.Add(this.grid);
      this.Controls.Add(this.ribbonControl1);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(800, 400);
      this.Name = "ConnectionManagerBox";
      this.Ribbon = this.ribbonControl1;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Connection Manager";
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl grid;
    private DevExpress.XtraGrid.Views.Grid.GridView view;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.BarButtonItem buttonNewConnection;
    private DevExpress.XtraBars.BarButtonItem buttonDeleteConnection;
    private DevExpress.XtraBars.BarButtonItem buttonImportConnection;
    private DevExpress.XtraBars.BarButtonItem buttonEditConnection;
    private DevExpress.XtraBars.BarEditItem barEditItem1;
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
    private DevExpress.XtraBars.BarEditItem boxSearch;
  }
}