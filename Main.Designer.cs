namespace Vislice
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uporabnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visliceDataSet = new VisliceDataSet();
            this.uporabnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uporabnikiTableAdapter = new VisliceDataSetTableAdapters.UporabnikiTableAdapter();
            this.tableAdapterManager = new VisliceDataSetTableAdapters.TableAdapterManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nastavitveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavitveTableAdapter = new VisliceDataSetTableAdapters.NastavitveTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.bazaToolStripMenuItem,
            this.uporabnikiToolStripMenuItem,
            this.igrajToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(321, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem,
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.izhodToolStripMenuItem.Text = "Izhod";
            this.izhodToolStripMenuItem.Click += new System.EventHandler(this.izhodToolStripMenuItem_Click);
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            this.bazaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bazaToolStripMenuItem.Text = "Baza";
            this.bazaToolStripMenuItem.Click += new System.EventHandler(this.bazaToolStripMenuItem_Click);
            // 
            // uporabnikiToolStripMenuItem
            // 
            this.uporabnikiToolStripMenuItem.Name = "uporabnikiToolStripMenuItem";
            this.uporabnikiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.uporabnikiToolStripMenuItem.Text = "Uporabniki";
            this.uporabnikiToolStripMenuItem.Click += new System.EventHandler(this.uporabnikiToolStripMenuItem_Click);
            // 
            // igrajToolStripMenuItem
            // 
            this.igrajToolStripMenuItem.Name = "igrajToolStripMenuItem";
            this.igrajToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.igrajToolStripMenuItem.Text = "Igraj";
            this.igrajToolStripMenuItem.Click += new System.EventHandler(this.igrajToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // visliceDataSet
            // 
            this.visliceDataSet.DataSetName = "VisliceDataSet";
            this.visliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uporabnikiBindingSource
            // 
            this.uporabnikiBindingSource.DataMember = "Uporabniki";
            this.uporabnikiBindingSource.DataSource = this.visliceDataSet;
            // 
            // uporabnikiTableAdapter
            // 
            this.uporabnikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BesedeTableAdapter = null;
            this.tableAdapterManager.NastavitveTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VisliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikiTableAdapter = this.uporabnikiTableAdapter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(321, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // nastavitveBindingSource
            // 
            this.nastavitveBindingSource.DataMember = "Nastavitve";
            this.nastavitveBindingSource.DataSource = this.visliceDataSet;
            // 
            // nastavitveTableAdapter
            // 
            this.nastavitveTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 47);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Vislice";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uporabnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igrajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private VisliceDataSet visliceDataSet;
        private System.Windows.Forms.BindingSource uporabnikiBindingSource;
        private VisliceDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private VisliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.BindingSource nastavitveBindingSource;
        private VisliceDataSetTableAdapters.NastavitveTableAdapter nastavitveTableAdapter;
    }
}