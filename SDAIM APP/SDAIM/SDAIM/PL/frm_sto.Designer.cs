
namespace SDAIM.PL
{
    partial class frm_sto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDésignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatégorie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix_U_H_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colT_V_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoids = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantité = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_H_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_T_V_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_T_C = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            this.pnl_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_cat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnl_cat
            // 
            this.pnl_cat.Controls.Add(this.gridControl1);
            this.pnl_cat.Controls.Add(this.panel2);
            this.pnl_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cat.Location = new System.Drawing.Point(0, 0);
            this.pnl_cat.Name = "pnl_cat";
            this.pnl_cat.Size = new System.Drawing.Size(1030, 720);
            this.pnl_cat.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SDAIM.Purchase);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 620);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.FixedLine.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCyan;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDésignation,
            this.colCatégorie,
            this.colFournisseur,
            this.colPrix_U_H_T,
            this.colT_V_A,
            this.colPoids,
            this.colQuantité,
            this.colTotal_H_T,
            this.colTotal_T_V_A,
            this.colTotal_T_C});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            // 
            // colDésignation
            // 
            this.colDésignation.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colDésignation.AppearanceHeader.Options.UseBackColor = true;
            this.colDésignation.FieldName = "Désignation";
            this.colDésignation.Name = "colDésignation";
            this.colDésignation.Visible = true;
            this.colDésignation.VisibleIndex = 0;
            this.colDésignation.Width = 112;
            // 
            // colCatégorie
            // 
            this.colCatégorie.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colCatégorie.AppearanceHeader.Options.UseBackColor = true;
            this.colCatégorie.FieldName = "Catégorie";
            this.colCatégorie.Name = "colCatégorie";
            this.colCatégorie.Visible = true;
            this.colCatégorie.VisibleIndex = 1;
            this.colCatégorie.Width = 88;
            // 
            // colFournisseur
            // 
            this.colFournisseur.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colFournisseur.AppearanceHeader.Options.UseBackColor = true;
            this.colFournisseur.FieldName = "Fournisseur";
            this.colFournisseur.Name = "colFournisseur";
            this.colFournisseur.Visible = true;
            this.colFournisseur.VisibleIndex = 2;
            this.colFournisseur.Width = 106;
            // 
            // colPrix_U_H_T
            // 
            this.colPrix_U_H_T.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colPrix_U_H_T.AppearanceHeader.Options.UseBackColor = true;
            this.colPrix_U_H_T.Caption = "Prix.U H.T";
            this.colPrix_U_H_T.FieldName = "Prix_U_H_T";
            this.colPrix_U_H_T.Name = "colPrix_U_H_T";
            this.colPrix_U_H_T.Visible = true;
            this.colPrix_U_H_T.VisibleIndex = 3;
            this.colPrix_U_H_T.Width = 103;
            // 
            // colT_V_A
            // 
            this.colT_V_A.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colT_V_A.AppearanceHeader.Options.UseBackColor = true;
            this.colT_V_A.Caption = "T.V.A";
            this.colT_V_A.FieldName = "T_V_A";
            this.colT_V_A.Name = "colT_V_A";
            this.colT_V_A.Visible = true;
            this.colT_V_A.VisibleIndex = 4;
            this.colT_V_A.Width = 69;
            // 
            // colPoids
            // 
            this.colPoids.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colPoids.AppearanceHeader.Options.UseBackColor = true;
            this.colPoids.FieldName = "Poids";
            this.colPoids.Name = "colPoids";
            this.colPoids.Visible = true;
            this.colPoids.VisibleIndex = 5;
            this.colPoids.Width = 68;
            // 
            // colQuantité
            // 
            this.colQuantité.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colQuantité.AppearanceHeader.Options.UseBackColor = true;
            this.colQuantité.FieldName = "Quantité";
            this.colQuantité.Name = "colQuantité";
            this.colQuantité.Visible = true;
            this.colQuantité.VisibleIndex = 6;
            this.colQuantité.Width = 76;
            // 
            // colTotal_H_T
            // 
            this.colTotal_H_T.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colTotal_H_T.AppearanceHeader.Options.UseBackColor = true;
            this.colTotal_H_T.Caption = "Total H.T";
            this.colTotal_H_T.FieldName = "Total_H_T";
            this.colTotal_H_T.Name = "colTotal_H_T";
            this.colTotal_H_T.Visible = true;
            this.colTotal_H_T.VisibleIndex = 7;
            this.colTotal_H_T.Width = 77;
            // 
            // colTotal_T_V_A
            // 
            this.colTotal_T_V_A.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colTotal_T_V_A.AppearanceHeader.Options.UseBackColor = true;
            this.colTotal_T_V_A.Caption = "Total T.V.A";
            this.colTotal_T_V_A.FieldName = "Total_T_V_A";
            this.colTotal_T_V_A.Name = "colTotal_T_V_A";
            this.colTotal_T_V_A.Visible = true;
            this.colTotal_T_V_A.VisibleIndex = 8;
            this.colTotal_T_V_A.Width = 91;
            // 
            // colTotal_T_C
            // 
            this.colTotal_T_C.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colTotal_T_C.AppearanceHeader.Options.UseBackColor = true;
            this.colTotal_T_C.Caption = "Total T.C";
            this.colTotal_T_C.FieldName = "Total_T_C";
            this.colTotal_T_C.Name = "colTotal_T_C";
            this.colTotal_T_C.Visible = true;
            this.colTotal_T_C.VisibleIndex = 9;
            this.colTotal_T_C.Width = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.edt_search);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.Location = new System.Drawing.Point(945, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 75);
            this.btn_search.TabIndex = 11;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_search
            // 
            this.edt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_search.Location = new System.Drawing.Point(623, 29);
            this.edt_search.Name = "edt_search";
            this.edt_search.Size = new System.Drawing.Size(316, 38);
            this.edt_search.TabIndex = 10;
            this.edt_search.TextChanged += new System.EventHandler(this.edt_search_TextChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(317, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(137, 75);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Supprimer";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(163, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(137, 75);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Modifier";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(11, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 75);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(470, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(137, 75);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Mis à jour";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // frm_sto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_sto";
            this.Text = "frm_cat";
            this.panel1.ResumeLayout(false);
            this.pnl_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_cat;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDésignation;
        private DevExpress.XtraGrid.Columns.GridColumn colCatégorie;
        private DevExpress.XtraGrid.Columns.GridColumn colFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix_U_H_T;
        private DevExpress.XtraGrid.Columns.GridColumn colT_V_A;
        private DevExpress.XtraGrid.Columns.GridColumn colPoids;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantité;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_H_T;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_T_V_A;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_T_C;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox edt_search;
    }
}