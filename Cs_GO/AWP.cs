using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_GO
{
    public partial class AWP : Form
    {
        public AWP()
        {
            InitializeComponent();
        }
        int awpmermi = 10;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            AWPc Benimawp = new AWPc();
            Benimawp.Vur();
            awpmermi--;

            if (awpmermi == 0)
            {
                MessageBox.Show("mermi koy");
            }
            if (awpmermi < 0)
            {
                MessageBox.Show("mermi koysana");
            }
        }

        private void AWP_KeyDown(object sender, KeyEventArgs e)
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
                awpmermi = 10;
            }
        }
    }
}
