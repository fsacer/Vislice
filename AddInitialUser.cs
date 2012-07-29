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
    public partial class AddInitialUser : Form
    {
        public VisliceDataSet db = new VisliceDataSet();
        public AddInitialUser()
        {
            InitializeComponent();
        }
        private void AddInitialUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(db.Uporabniki);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Prijava();
            if (string.IsNullOrEmpty(uporabnikTextBox.Text) == false && string.IsNullOrEmpty(gesloTextBox.Text) == false)
            {
                VisliceDataSet.UporabnikiRow row = db.Uporabniki.NewUporabnikiRow();
                row.ID = Convert.ToInt64(iDTextBox.Text);
                row.Uporabnik = uporabnikTextBox.Text;
                row.Geslo = frm.EncryptPassword(uporabnikTextBox.Text, gesloTextBox.Text);
                row.DB = dBCheckBox.Checked;
                row.Uporabniki = uporabnikiCheckBox.Checked;
                db.Uporabniki.Rows.Add(row);
                this.Validate();
                this.tableAdapterManager.UpdateAll(db);
                this.Close();
            }
            else
            {
                MessageBox.Show("Prosim, da vnesete uporabnika in geslo");
            }
            
        }
    }
}
