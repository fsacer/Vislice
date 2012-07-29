using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vislice
{
    public partial class Prijava : Form
    {
        public bool LogonSuccessfull = false;
        public bool Relogin = false;
        public VisliceDataSet db = new VisliceDataSet();
        public Prijava()
        {
            InitializeComponent();
        }
        private void Prijava_Load(object sender, EventArgs e)
        {
            FillAll();
            if (AreThereAnyUsers()==false) {
                var frm = new AddInitialUser();
                frm.ShowInTaskbar = false;
                frm.ControlBox=false;
                frm.ShowDialog();
                FillAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidUser(uporabnikComboBox.Text, textBox1.Text))
            {
                LogonSuccessfull = true;
                this.Close();
            }
            else 
            {
                if (!DoesUserExist(uporabnikComboBox.Text))
                {
                    MessageBox.Show("Uporabnik se ne ujema z nobenim v bazi.", "Baza", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else 
                {
                    MessageBox.Show("Geslo se ne ujema z uporabnikom.", "Napačno geslo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidUser(string userName,string password) {
            var count=(from u in db.Uporabniki where u.Uporabnik==userName && u.Geslo==EncryptPassword(userName,password) select u.Uporabnik).Count();
            //Final step for calculation
            var query = (from n in db.Nastavitve where n.Name == "User" select n).Count();
            if (count>0){
            if (query==0)
            {
                VisliceDataSet.NastavitveRow row = db.Nastavitve.NewNastavitveRow();
                row.String = uporabnikComboBox.Text;
                row.Name = "User";
                db.Nastavitve.Rows.Add(row);
            }
            else
            {
                var getUserSetting = (from n in db.Nastavitve where n.Name == "User" select n).SingleOrDefault();
                getUserSetting.String = userName;
            }
            this.Validate();
            this.tableAdapterManager.UpdateAll(db);
            }
            return (count>0);
        }
        private bool AreThereAnyUsers()
        {
            if (db.Uporabniki.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public string EncryptPassword(string salt,string password) { 
                    //lower salt
                    salt=salt.ToLower();
                    HashAlgorithm hash = new SHA512Managed();

                    // compute hash of the password
                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = hash.ComputeHash(plainTextBytes);

                    // create salted byte array
                    byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                    byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];
                    for (int i = 0; i < plainTextBytes.Length; i++)
                    {
                    plainTextWithSaltBytes[i] = plainTextBytes[i];
                    }

                    // compute salted hash
                    byte[] saltedHashBytes = hash.ComputeHash(plainTextWithSaltBytes);
                    string saltedHashValue = Convert.ToBase64String(saltedHashBytes);
                    return saltedHashValue;
        }
        private void uporabnikComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                 textBox1.Focus();
                }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private bool DoesUserExist(string userName)
        {
            var q = (from u in db.Uporabniki where u.Uporabnik == userName select u.Uporabnik).FirstOrDefault();
            return (q!=null);
        }
        public void FillAll() {
            // TODO: This line of code loads data into the 'visliceDataSet.Uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(this.visliceDataSet.Uporabniki);
            // TODO: This line of code loads data into the 'db.Uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(db.Uporabniki);
            // TODO: This line of code loads data into the 'db.Nastavitve' table. You can move, or remove it, as needed.
            this.nastavitveTableAdapter.Fill(db.Nastavitve);
        }

        private void uporabnikComboBox_Leave(object sender, EventArgs e)
        {
            if (!DoesUserExist(uporabnikComboBox.Text))
                {
                    uporabnikComboBox.Focus();
                    MessageBox.Show("Uporabnik se ne ujema z nobenim v bazi.", "Baza", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
        }
        
    }
}
