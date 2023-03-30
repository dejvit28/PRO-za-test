using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace izpit_30._3._2023
{

    public partial class Form1 : Form 
    {

        Kontakt[] mojiKontakti = {
            new Kontakt { Ime = "Miha Kovač", EMail = "mk@gmail.com", Telefon = "12345" },
            new Kontakt { Ime = "Janez Novak", EMail = "jn@gmail.com", Telefon = "98765" },
            new Kontakt { Ime = "Peter Gruden", EMail = "pg@gmail.com", Telefon = "13579" },
            new Kontakt { Ime = "Andrej Hočevar", EMail = "ah@gmail.com", Telefon = "24680" },
            null};

        public Form1()
        {
            InitializeComponent();
            foreach (Kontakt k in mojiKontakti)
            {
                if (k != null)
                {
                    listBox1.Items.Add(k.Ime);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = mojiKontakti;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Kontakt k = mojiKontakti[listBox1.SelectedIndex];
                textBox1.Text = k.Ime;
                textBox2.Text = k.EMail;
                textBox3.Text = k.Telefon;
            }
        }

        private void DodajNov_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontakt novKontakt = new Kontakt();
            novKontakt.Ime = textBox1.Text;
            novKontakt.EMail = textBox2.Text;
            novKontakt.Telefon = textBox3.Text;
            listBox1.Items.Add(novKontakt);
        }
    }
}
