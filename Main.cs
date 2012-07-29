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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Baza();
            frm.Show();
        }

        private void igrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Vislice();
            frm.Show();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutBox();
            frm.ShowDialog();
        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void uporabnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Uporabniki();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visliceDataSet.Nastavitve' table. You can move, or remove it, as needed.
            this.nastavitveTableAdapter.Fill(this.visliceDataSet.Nastavitve);
            // TODO: This line of code loads data into the 'visliceDataSet.Uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(this.visliceDataSet.Uporabniki);
            this.nastavitveTableAdapter.Fill(this.visliceDataSet.Nastavitve);
            StatusLabel.Text = "Prijavljen: " + GetCurrentUser().ToString();
            if(!canDB(GetCurrentUser())){
                bazaToolStripMenuItem.Visible = false;
            }
            if (!canManageUsers(GetCurrentUser())) {
                uporabnikiToolStripMenuItem.Visible = false;
            }
        }

        private void uporabnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uporabnikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visliceDataSet);
        }
        private string GetCurrentUser()
        {
            var user = (from n in this.visliceDataSet.Nastavitve where n.Name == "User" select n.String).SingleOrDefault().ToString();
            return user;
        }
        public bool canManageUsers(string userName)
        {
            var q = (from u in this.visliceDataSet.Uporabniki where u.Uporabnik == userName select u.Uporabniki).SingleOrDefault();
            return q;
        }
        public bool canDB(string userName)
        {
            var q = (from u in this.visliceDataSet.Uporabniki where u.Uporabnik == userName select u.DB).SingleOrDefault();
            return q;
        }
    }
}
