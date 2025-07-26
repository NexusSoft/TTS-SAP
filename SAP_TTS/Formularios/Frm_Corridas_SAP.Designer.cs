namespace SAP_TTS
{
    partial class Frm_Corridas_SAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Corridas_SAP));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btn_Limpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_Importar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_Salir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtraFolderDialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_GeneraJSON = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BuscarLote = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdLote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtgLote = new DevExpress.XtraGrid.GridControl();
            this.dtgValLote = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValLote)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bIconos,
            this.bEstado});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem2,
            this.btn_Limpiar,
            this.btn_Importar,
            this.btn_Salir});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 80;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bEstado;
            // 
            // bIconos
            // 
            this.bIconos.BarName = "Menú principal";
            this.bIconos.DockCol = 0;
            this.bIconos.DockRow = 0;
            this.bIconos.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bIconos.FloatLocation = new System.Drawing.Point(42, 184);
            this.bIconos.FloatSize = new System.Drawing.Size(1106, 535);
            this.bIconos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Limpiar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Importar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Salir)});
            this.bIconos.OptionsBar.AllowCollapse = true;
            this.bIconos.OptionsBar.AllowQuickCustomization = false;
            this.bIconos.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bIconos.OptionsBar.DisableClose = true;
            this.bIconos.OptionsBar.DisableCustomization = true;
            this.bIconos.OptionsBar.DrawBorder = false;
            this.bIconos.OptionsBar.DrawDragBorder = false;
            this.bIconos.OptionsBar.RotateWhenVertical = false;
            this.bIconos.OptionsBar.UseWholeRow = true;
            this.bIconos.Text = "Menú principal";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Caption = "Limpiar";
            this.btn_Limpiar.Id = 50;
            this.btn_Limpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.ImageOptions.Image")));
            this.btn_Limpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.ImageOptions.LargeImage")));
            this.btn_Limpiar.Name = "btn_Limpiar";
            // 
            // btn_Importar
            // 
            this.btn_Importar.Caption = "Importar \r\n  Datos";
            this.btn_Importar.Id = 53;
            this.btn_Importar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Importar.ImageOptions.Image")));
            this.btn_Importar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Importar.ImageOptions.LargeImage")));
            this.btn_Importar.Name = "btn_Importar";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Caption = "Salir";
            this.btn_Salir.Id = 63;
            this.btn_Salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.ImageOptions.Image")));
            this.btn_Salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.ImageOptions.LargeImage")));
            this.btn_Salir.Name = "btn_Salir";
            // 
            // bEstado
            // 
            this.bEstado.BarName = "Barra de estado";
            this.bEstado.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bEstado.DockCol = 0;
            this.bEstado.DockRow = 0;
            this.bEstado.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bEstado.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "XML Carta Porte:";
            this.barStaticItem2.Id = 48;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(657, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(657, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(59, 531);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(657, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 531);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // xtraFolderDialog
            // 
            this.xtraFolderDialog.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_GeneraJSON);
            this.panelControl1.Controls.Add(this.btn_BuscarLote);
            this.panelControl1.Controls.Add(this.txtIdLote);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(59, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(598, 69);
            this.panelControl1.TabIndex = 4;
            // 
            // btn_GeneraJSON
            // 
            this.btn_GeneraJSON.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_GeneraJSON.Location = new System.Drawing.Point(322, 12);
            this.btn_GeneraJSON.Name = "btn_GeneraJSON";
            this.btn_GeneraJSON.Size = new System.Drawing.Size(128, 43);
            this.btn_GeneraJSON.TabIndex = 3;
            this.btn_GeneraJSON.Text = "Generar JSON";
            this.btn_GeneraJSON.Click += new System.EventHandler(this.btn_GeneraJSON_Click);
            // 
            // btn_BuscarLote
            // 
            this.btn_BuscarLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarLote.ImageOptions.Image")));
            this.btn_BuscarLote.Location = new System.Drawing.Point(188, 12);
            this.btn_BuscarLote.Name = "btn_BuscarLote";
            this.btn_BuscarLote.Size = new System.Drawing.Size(128, 43);
            this.btn_BuscarLote.TabIndex = 2;
            this.btn_BuscarLote.Text = "Buscar Lote";
            this.btn_BuscarLote.Click += new System.EventHandler(this.btn_BuscarLote_Click);
            // 
            // txtIdLote
            // 
            this.txtIdLote.EditValue = "0";
            this.txtIdLote.Location = new System.Drawing.Point(70, 23);
            this.txtIdLote.MenuManager = this.barManager1;
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIdLote.Properties.MaskSettings.Set("mask", "d");
            this.txtIdLote.Properties.MaskSettings.Set("culture", "es-MX");
            this.txtIdLote.Properties.MaskSettings.Set("valueType", typeof(int));
            this.txtIdLote.Properties.UseMaskAsDisplayFormat = true;
            this.txtIdLote.Size = new System.Drawing.Size(100, 20);
            this.txtIdLote.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IdLote";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtgLote);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(59, 69);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(598, 462);
            this.panelControl2.TabIndex = 5;
            // 
            // dtgLote
            // 
            this.dtgLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLote.Location = new System.Drawing.Point(7, 7);
            this.dtgLote.MainView = this.dtgValLote;
            this.dtgLote.MenuManager = this.barManager1;
            this.dtgLote.Name = "dtgLote";
            this.dtgLote.Size = new System.Drawing.Size(584, 448);
            this.dtgLote.TabIndex = 0;
            this.dtgLote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValLote});
            // 
            // dtgValLote
            // 
            this.dtgValLote.GridControl = this.dtgLote;
            this.dtgValLote.Name = "dtgValLote";
            this.dtgValLote.OptionsView.ShowFooter = true;
            this.dtgValLote.OptionsView.ShowGroupPanel = false;
            // 
            // Frm_Corridas_SAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 554);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Corridas_SAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Corridas_SAP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btn_Limpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btn_Importar;
        private DevExpress.XtraBars.BarLargeButtonItem btn_Salir;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderDialog;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdLote;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtgLote;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValLote;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarLote;
        private DevExpress.XtraEditors.SimpleButton btn_GeneraJSON;
    }
}