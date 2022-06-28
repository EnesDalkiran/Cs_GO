using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cs_GO
{
    public partial class Deagle : Form
    {
        public Deagle()
        {
            InitializeComponent();
        }
        int deaglemermi = 7;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DesertEagle benimdeagle = new DesertEagle();
            
            benimdeagle.Vur();

            deaglemermi --;
            
            if (deaglemermi == 0)
            {
                MessageBox.Show("mermi koy");
            }
            if (deaglemermi < 0)
            {
                MessageBox.Show("mermi koysana");     
            }
            
        }

       

        private void Deagle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                this.Hide();
                AWP awpform2 = new AWP();
                awpform2.Show();
            }
            if (e.KeyCode == Keys.D2)
            {
                this.Hide();
                Deagle DeagleForm = new Deagle();
                DeagleForm.Show();
            }
            if (e.KeyCode == Keys.R)
            {
                deaglemermi = 7;
            }

        }
    }
}
