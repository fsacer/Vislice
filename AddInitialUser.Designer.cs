namespace Vislice
{
    partial class AddInitialUser
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label uporabnikLabel;
            System.Windows.Forms.Label gesloLabel;
            System.Windows.Forms.Label dBLabel;
            System.Windows.Forms.Label uporabnikiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInitialUser));
            this.visliceDataSet = new VisliceDataSet();
            this.uporabnikiTableAdapter = new VisliceDataSetTableAdapters.UporabnikiTableAdapter();
            this.tableAdapterManager = new VisliceDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.uporabnikTextBox = new System.Windows.Forms.TextBox();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.dBCheckBox = new System.Windows.Forms.CheckBox();
            this.uporabnikiCheckBox = new System.Windows.Forms.CheckBox();
            iDLabel = new System.Windows.Forms.Label();
            uporabnikLabel = new System.Windows.Forms.Label();
            gesloLabel = new System.Windows.Forms.Label();
            dBLabel = new System.Windows.Forms.Label();
            uporabnikiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(8, 8);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ID:";
            // 
            // uporabnikLabel
            // 
            uporabnikLabel.AutoSize = true;
            uporabnikLabel.Location = new System.Drawing.Point(8, 34);
            uporabnikLabel.Name = "uporabnikLabel";
            uporabnikLabel.Size = new System.Drawing.Size(59, 13);
            uporabnikLabel.TabIndex = 11;
            uporabnikLabel.Text = "Uporabnik:";
            // 
            // gesloLabel
            // 
            gesloLabel.AutoSize = true;
            gesloLabel.Location = new System.Drawing.Point(8, 60);
            gesloLabel.Name = "gesloLabel";
            gesloLabel.Size = new System.Drawing.Size(37, 13);
            gesloLabel.TabIndex = 13;
            gesloLabel.Text = "Geslo:";
            // 
            // dBLabel
            // 
            dBLabel.AutoSize = true;
            dBLabel.Location = new System.Drawing.Point(8, 88);
            dBLabel.Name = "dBLabel";
            dBLabel.Size = new System.Drawing.Size(25, 13);
            dBLabel.TabIndex = 15;
            dBLabel.Text = "DB:";
            // 
            // uporabnikiLabel
            // 
            uporabnikiLabel.AutoSize = true;
            uporabnikiLabel.Location = new System.Drawing.Point(8, 118);
            uporabnikiLabel.Name = "uporabnikiLabel";
            uporabnikiLabel.Size = new System.Drawing.Size(61, 13);
            uporabnikiLabel.TabIndex = 17;
            uporabnikiLabel.Text = "Uporabniki:";
            // 
            // visliceDataSet
            // 
            this.visliceDataSet.DataSetName = "BazaDataSet";
            this.visliceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(75, 5);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(104, 20);
            this.iDTextBox.TabIndex = 10;
            this.iDTextBox.Text = "1";
            // 
            // uporabnikTextBox
            // 
            this.uporabnikTextBox.Location = new System.Drawing.Point(75, 31);
            this.uporabnikTextBox.Name = "uporabnikTextBox";
            this.uporabnikTextBox.Size = new System.Drawing.Size(104, 20);
            this.uporabnikTextBox.TabIndex = 12;
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.Location = new System.Drawing.Point(75, 57);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.PasswordChar = '*';
            this.gesloTextBox.Size = new System.Drawing.Size(104, 20);
            this.gesloTextBox.TabIndex = 14;
            // 
            // dBCheckBox
            // 
            this.dBCheckBox.Checked = false;
            this.dBCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dBCheckBox.Enabled = true;
            this.dBCheckBox.Location = new System.Drawing.Point(75, 83);
            this.dBCheckBox.Name = "dBCheckBox";
            this.dBCheckBox.Size = new System.Drawing.Size(104, 24);
            this.dBCheckBox.TabIndex = 16;
            this.dBCheckBox.UseVisualStyleBackColor = true;
            // 
            // uporabnikiCheckBox
            // 
            this.uporabnikiCheckBox.Checked = true;
            this.uporabnikiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uporabnikiCheckBox.Enabled = false;
            this.uporabnikiCheckBox.Location = new System.Drawing.Point(75, 113);
            this.uporabnikiCheckBox.Name = "uporabnikiCheckBox";
            this.uporabnikiCheckBox.Size = new System.Drawing.Size(104, 24);
            this.uporabnikiCheckBox.TabIndex = 18;
            this.uporabnikiCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddInitialUser
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 182);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(uporabnikLabel);
            this.Controls.Add(this.uporabnikTextBox);
            this.Controls.Add(gesloLabel);
            this.Controls.Add(this.gesloTextBox);
            this.Controls.Add(dBLabel);
            this.Controls.Add(this.dBCheckBox);
            this.Controls.Add(uporabnikiLabel);
            this.Controls.Add(this.uporabnikiCheckBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInitialUser";
            this.Text = "Dodaj uporabnika";
            this.Load += new System.EventHandler(this.AddInitialUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisliceDataSet visliceDataSet;
        private VisliceDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private VisliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox uporabnikTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.CheckBox dBCheckBox;
        private System.Windows.Forms.CheckBox uporabnikiCheckBox;
    }
}