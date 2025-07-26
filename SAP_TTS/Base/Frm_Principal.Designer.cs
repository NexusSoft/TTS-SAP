namespace SAP_TTS
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_HojadeCarga = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Usuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Pantallas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Perfiles = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Permisos = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Remision = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FacturaF = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Status = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Facturas_Bind = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ODC_Bind = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Gastos_Bind = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Recepcion_Bind = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ventas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CartaPorte = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CruceAduanal = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CruceAduanal_Pedimento = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TipoCambio = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SkinForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_HojadeCarga,
            this.btn_Usuarios,
            this.btn_Pantallas,
            this.btn_Perfiles,
            this.btn_Permisos,
            this.btn_Remision,
            this.btn_FacturaF,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btn_Status,
            this.btn_Facturas_Bind,
            this.btn_ODC_Bind,
            this.btn_Gastos_Bind,
            this.btn_Recepcion_Bind,
            this.btn_Ventas,
            this.btn_CartaPorte,
            this.btn_CruceAduanal,
            this.btn_CruceAduanal_Pedimento,
            this.btn_TipoCambio});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1002, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Caption = "Usuarios";
            this.btn_Usuarios.Id = 2;
            this.btn_Usuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.ImageOptions.Image")));
            this.btn_Usuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.ImageOptions.LargeImage")));
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Usuarios_ItemClick);
            // 
            // btn_Pantallas
            // 
            this.btn_Pantallas.Caption = "Pantallas";
            this.btn_Pantallas.Id = 3;
            this.btn_Pantallas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pantallas.ImageOptions.Image")));
            this.btn_Pantallas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Pantallas.ImageOptions.LargeImage")));
            this.btn_Pantallas.Name = "btn_Pantallas";
            this.btn_Pantallas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Pantallas_ItemClick);
            // 
            // btn_Perfiles
            // 
            this.btn_Perfiles.Caption = "Perfiles";
            this.btn_Perfiles.Id = 4;
            this.btn_Perfiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Perfiles.ImageOptions.Image")));
            this.btn_Perfiles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Perfiles.ImageOptions.LargeImage")));
            this.btn_Perfiles.Name = "btn_Perfiles";
            this.btn_Perfiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Perfiles_ItemClick);
            // 
            // btn_Permisos
            // 
            this.btn_Permisos.Caption = "Permisos";
            this.btn_Permisos.Id = 5;
            this.btn_Permisos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Permisos.ImageOptions.Image")));
            this.btn_Permisos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Permisos.ImageOptions.LargeImage")));
            this.btn_Permisos.Name = "btn_Permisos";
            this.btn_Permisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Permisos_ItemClick);
           
            
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Orden Compra TF";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Carta Porte";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Remesa";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Factura A";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Orden Compra GF";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btn_Status
            // 
            this.btn_Status.Caption = "Estado Documentos";
            this.btn_Status.Id = 13;
            this.btn_Status.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Status.ImageOptions.Image")));
            this.btn_Status.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Status.ImageOptions.LargeImage")));
            this.btn_Status.Name = "btn_Status";
            
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Caption = "Ventas";
            this.btn_Ventas.Id = 18;
            this.btn_Ventas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.ImageOptions.Image")));
            this.btn_Ventas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.ImageOptions.LargeImage")));
            this.btn_Ventas.Name = "btn_Ventas";
            
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Control";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Seguridad";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Usuarios);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Pantallas);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Perfiles);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Permisos);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Accesos";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 524);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1002, 31);
            // 
            // SkinForm
            // 
            this.SkinForm.EnableBonusSkins = true;
            this.SkinForm.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 555);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_HojadeCarga;
        public DevExpress.LookAndFeel.DefaultLookAndFeel SkinForm;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_Usuarios;
        private DevExpress.XtraBars.BarButtonItem btn_Pantallas;
        private DevExpress.XtraBars.BarButtonItem btn_Perfiles;
        private DevExpress.XtraBars.BarButtonItem btn_Permisos;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_Remision;
        private DevExpress.XtraBars.BarButtonItem btn_FacturaF;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btn_Status;
        private DevExpress.XtraBars.BarButtonItem btn_Facturas_Bind;
        private DevExpress.XtraBars.BarButtonItem btn_ODC_Bind;
        private DevExpress.XtraBars.BarButtonItem btn_Gastos_Bind;
        private DevExpress.XtraBars.BarButtonItem btn_Recepcion_Bind;
        private DevExpress.XtraBars.BarButtonItem btn_Ventas;
        private DevExpress.XtraBars.BarButtonItem btn_CartaPorte;
        private DevExpress.XtraBars.BarButtonItem btn_CruceAduanal;
        private DevExpress.XtraBars.BarButtonItem btn_CruceAduanal_Pedimento;
        private DevExpress.XtraBars.BarButtonItem btn_TipoCambio;
    }
}