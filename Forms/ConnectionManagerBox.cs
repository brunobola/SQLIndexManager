using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace SQLIndexManager {

  public partial class ConnectionManagerBox : DevExpress.XtraBars.Ribbon.RibbonForm {

    public ConnectionManagerBox() {
      InitializeComponent();

      view.CustomColumnDisplayText += GridMethod.GridColumnDisplayText;
      view.RowCellStyle += GridMethod.GridRowCellStyle;
      view.DoubleClick += GridMethod.GridDoubleClick;

      grid.DataSource = Settings.Hosts;
    }

  }

}
