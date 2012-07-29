using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vislice
{
    public partial class Uporabniki : Form
    {
        public Uporabniki()
        {
            InitializeComponent();
        }
        private void uporabnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uporabnikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visliceDataSet);
        }
        private void Uporabniki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visliceDataSet.Uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(this.visliceDataSet.Uporabniki);
        }
        private void Encrypt()
        {
            var frm = new Prijava();
            if (!string.IsNullOrEmpty(uporabnikTextBox.Text))
            {
                gesloTextBox.Text = frm.EncryptPassword(uporabnikTextBox.Text, gesloTextBox.Text);
            }
        }
        private void gesloTextBox_Validating(object sender, CancelEventArgs e)
        {
            Encrypt();
        }
    }
}
