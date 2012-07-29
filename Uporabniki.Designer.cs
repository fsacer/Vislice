namespace Vislice
{
    partial class Uporabniki
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label uporabnikLabel;
            System.Windows.Forms.Label gesloLabel;
            System.Windows.Forms.Label dBLabel;
            System.Windows.Forms.Label uporabnikiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uporabniki));
            this.visliceDataSet = new VisliceDataSet();
            this.uporabnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uporabnikiTableAdapter = new VisliceDataSetTableAdapters.UporabnikiTableAdapter();
            this.tableAdapterManager = new VisliceDataSetTableAdapters.TableAdapterManager();
            this.uporabnikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uporabnikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingNavigator)).BeginInit();
            this.uporabnikiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(11, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // uporabnikLabel
            // 
            uporabnikLabel.AutoSize = true;
            uporabnikLabel.Location = new System.Drawing.Point(11, 57);
            uporabnikLabel.Name = "uporabnikLabel";
            uporabnikLabel.Size = new System.Drawing.Size(59, 13);
            uporabnikLabel.TabIndex = 3;
            uporabnikLabel.Text = "Uporabnik:";
            // 
            // gesloLabel
            // 
            gesloLabel.AutoSize = true;
            gesloLabel.Location = new System.Drawing.Point(11, 83);
            gesloLabel.Name = "gesloLabel";
            gesloLabel.Size = new System.Drawing.Size(37, 13);
            gesloLabel.TabIndex = 5;
            gesloLabel.Text = "Geslo:";
            // 
            // dBLabel
            // 
            dBLabel.AutoSize = true;
            dBLabel.Location = new System.Drawing.Point(11, 111);
            dBLabel.Name = "dBLabel";
            dBLabel.Size = new System.Drawing.Size(25, 13);
            dBLabel.TabIndex = 7;
            dBLabel.Text = "DB:";
            // 
            // uporabnikiLabel
            // 
            uporabnikiLabel.AutoSize = true;
            uporabnikiLabel.Location = new System.Drawing.Point(11, 141);
            uporabnikiLabel.Name = "uporabnikiLabel";
            uporabnikiLabel.Size = new System.Drawing.Size(61, 13);
            uporabnikiLabel.TabIndex = 9;
            uporabnikiLabel.Text = "Uporabniki:";
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
            // uporabnikiBindingNavigator
            // 
            this.uporabnikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uporabnikiBindingNavigator.BindingSource = this.uporabnikiBindingSource;
            this.uporabnikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uporabnikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uporabnikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uporabnikiBindingNavigatorSaveItem});
            this.uporabnikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uporabnikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uporabnikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uporabnikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uporabnikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uporabnikiBindingNavigator.Name = "uporabnikiBindingNavigator";
            this.uporabnikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uporabnikiBindingNavigator.Size = new System.Drawing.Size(281, 25);
            this.uporabnikiBindingNavigator.TabIndex = 0;
            this.uporabnikiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uporabnikiBindingNavigatorSaveItem
            // 
            this.uporabnikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uporabnikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uporabnikiBindingNavigatorSaveItem.Image")));
            this.uporabnikiBindingNavigatorSaveItem.Name = "uporabnikiBindingNavigatorSaveItem";
            this.uporabnikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uporabnikiBindingNavigatorSaveItem.Text = "Save Data";
            this.uporabnikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.uporabnikiBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(78, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(104, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // uporabnikTextBox
            // 
            this.uporabnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "Uporabnik", true));
            this.uporabnikTextBox.Location = new System.Drawing.Point(78, 54);
            this.uporabnikTextBox.Name = "uporabnikTextBox";
            this.uporabnikTextBox.Size = new System.Drawing.Size(104, 20);
            this.uporabnikTextBox.TabIndex = 4;
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "Geslo", true));
            this.gesloTextBox.Location = new System.Drawing.Point(78, 80);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.Size = new System.Drawing.Size(104, 20);
            this.gesloTextBox.TabIndex = 6;
            this.gesloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gesloTextBox_Validating);
            // 
            // dBCheckBox
            // 
            this.dBCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uporabnikiBindingSource, "DB", true));
            this.dBCheckBox.Location = new System.Drawing.Point(78, 106);
            this.dBCheckBox.Name = "dBCheckBox";
            this.dBCheckBox.Size = new System.Drawing.Size(104, 24);
            this.dBCheckBox.TabIndex = 8;
            this.dBCheckBox.UseVisualStyleBackColor = true;
            // 
            // uporabnikiCheckBox
            // 
            this.uporabnikiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uporabnikiBindingSource, "Uporabniki", true));
            this.uporabnikiCheckBox.Location = new System.Drawing.Point(78, 136);
            this.uporabnikiCheckBox.Name = "uporabnikiCheckBox";
            this.uporabnikiCheckBox.Size = new System.Drawing.Size(104, 24);
            this.uporabnikiCheckBox.TabIndex = 10;
            this.uporabnikiCheckBox.UseVisualStyleBackColor = true;
            // 
            // Uporabniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 169);
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
            this.Controls.Add(this.uporabnikiBindingNavigator);
            this.Name = "Uporabniki";
            this.Text = "Uporabniki";
            this.Load += new System.EventHandler(this.Uporabniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visliceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingNavigator)).EndInit();
            this.uporabnikiBindingNavigator.ResumeLayout(false);
            this.uporabnikiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisliceDataSet visliceDataSet;
        private System.Windows.Forms.BindingSource uporabnikiBindingSource;
        private VisliceDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private VisliceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uporabnikiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uporabnikiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox uporabnikTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.CheckBox dBCheckBox;
        private System.Windows.Forms.CheckBox uporabnikiCheckBox;

    }
}