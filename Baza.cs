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
    public partial class Baza : Form
    {
        public Baza()
        {
            InitializeComponent();
        }

        private void besedeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.besedeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visliceDataSet);
        }

        private void Baza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visliceDataSet.Besede' table. You can move, or remove it, as needed.
            this.besedeTableAdapter.Fill(this.visliceDataSet.Besede);
        }
    }
}
