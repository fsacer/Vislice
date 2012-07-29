namespace Vislice
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.uporabnikComboBox = new System.Windows.Forms.ComboBox();
            this.uporabnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visliceDataSet = new VisliceDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nastavitveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavitveTableAdapter = new VisliceDataSetTableAdapters.NastavitveTableAdapter();
            this.tableAdapterManager = new VisliceDataSetTableAdapters.TableAdapterManager();
            this.uporabnikiTableAdapter = new VisliceDataSetTableAdapters.UporabnikiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uporabnikComboBox
            // 
            this.uporabnikComboBox.DataSource = this.uporabnikiBindingSource;
            this.uporabnikComboBox.DisplayMember = "Uporabnik";
            this.uporabnikComboBox.FormattingEnabled = true;
            this.uporabnikComboBox.Location = new System.Drawing.Point(76, 12);
            this.uporabnikComboBox.Name = "uporabnikComboBox";
            this.uporabnikComboBox.Size = new System.Drawing.Size(121, 21);
            this.uporabnikComboBox.TabIndex = 0;
            this.uporabnikComboBox.ValueMember = "Uporabnik";
            // 
            // uporabnikiBindingSource
            // 
            this.uporabnikiBindingSource.DataMember = "Uporabniki";
            this.uporabnikiBindingSource.DataSource = this.visliceDataSet;
            // 
            // visliceDataSet
            // 
            this.visliceDataSet.DataSetName = "VisliceDataSet";
            this.visliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uporabnik";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geslo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Potrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(122, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izhod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BesedeTableAdapter = null;
            this.tableAdapterManager.NastavitveTableAdapter = this.nastavitveTableAdapter;
            this.tableAdapterManager.UpdateOrder = VisliceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikiTableAdapter = this.uporabnikiTableAdapter;
            // 
            // uporabnikiTableAdapter
            // 
            this.uporabnikiTableAdapter.ClearBeforeFill = true;
            // 
            // Prijava
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(214, 106);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uporabnikComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uporabnikComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VisliceDataSet visliceDataSet;
        private System.Windows.Forms.BindingSource nastavitveBindingSource;
        private VisliceDataSetTableAdapters.NastavitveTableAdapter nastavitveTableAdapter;
        private VisliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private VisliceDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private System.Windows.Forms.BindingSource uporabnikiBindingSource;
    }
}