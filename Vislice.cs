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
    public partial class Vislice : Form
    {
        VisliceDataSet ds = new VisliceDataSet();
        static string beseda;
        string success;
        int poskusi;
        bool konec;
        string trenutni = "";
        string[] shramba;
        public int n;
        int loop = 0;
        List<char> missed;
        string[] ugibanje;
        readonly int poskusiConfig=10;
        string vhod;

        public Vislice() 
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            this.pictureBox1.Image = null;
            labelMessage.Text = "";
            missed = new List<char>();
            lblMissed.Text = "";
            poskusi = poskusiConfig;
            konec = false;
            loop = 0;
            textBox1.Enabled = true;
            button1.Enabled = false;
            tries.Text = poskusi.ToString();
            var dt = ds.Besede;
            besedeTableAdapter1.Fill(dt);
            var rand = new Random();
            var result = dt.AsEnumerable().OrderBy(r => rand.Next());
            beseda = result.First().beseda.ToUpper();
            n = beseda.Count();
            ugibanje = new string[n];
            for (int i = 0; i < n; i++)
                ugibanje[i] = "_";
            status.Text = string.Join(" ", ugibanje);
        }
        void Win()
        {
            this.pictureBox1.Image = global::Vislice.Properties.Resources.winner;
            konec = true;
            textBox1.Text = "";
            success = "Bravo";
            labelMessage.Text = success;
            poskusi = 0;
            button1.Enabled = true;
        }
        void Lose()
        {
            this.pictureBox1.Image = global::Vislice.Properties.Resources._10;
            success = "Obešen si";
            labelMessage.Text = success;
            textBox1.Enabled = false;
        }
        void switchPoskusi() {
            switch (poskusi)
            {
                case 10:
                    this.pictureBox1.Image = null;
                    break;
                case 9:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._1;
                    break;
                case 8:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._2;
                    break;
                case 7:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._3;
                    break;
                case 6:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._4;
                    break;
                case 5:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._5;
                    break;
                case 4:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._6;
                    break;
                case 3:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._7;
                    break;
                case 2:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._8;
                    break;
                case 1:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._9;
                    break;
                case 0:
                    this.pictureBox1.Image = global::Vislice.Properties.Resources._10;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Init();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vhod = textBox1.Text.ToUpper();
            if (e.KeyChar == 13)
            {
                // ce smo uganili besedo
                if (vhod.Equals(beseda)) {
                    status.Text = string.Join(" ", beseda.ToCharArray());
                    Win();
                }
                // ce smo vnesli samo eno crko
                else if (vhod.Count() == 1)
                {
                    poskusi--;
                    switchPoskusi();
                    tries.Text = poskusi.ToString();
                    int miss = 0;
                    // pogledamo, ali je ta crka v besedi
                    for (int j = 0; j < n; ++j)
                    {
                        if (beseda[j] == vhod[0])
                        {
                            ugibanje[j] = vhod[0].ToString().ToUpper();
                        }
                        else { miss++; }
                    }
                    if (miss == n) { miss = 1; missed.Add(char.Parse(vhod)); lblMissed.Text = string.Join(", ", missed); }
                    if (loop == 0)
                    {
                        shramba = ugibanje;
                        trenutni = string.Join("", shramba);
                        loop = 1;
                    }
                    else {
                        trenutni = string.Join("", shramba);
                    }
                    // izpisemo trenutno stanje
                    status.Text = string.Join(" ", shramba);

                    // ce je trenutno stanje enako besedi, koncamo
                    if (trenutni.Equals(beseda)) Win();
                    
                    textBox1.Text = "";
                }
                else if (vhod.Count() > 1 && !vhod.Equals(beseda)) { Lose(); }
                if (poskusi == 0 && konec == false) { Lose(); }
                else if (poskusi == 0 && konec == true) { textBox1.Enabled = false; }
            }
        
        }
    }
}
