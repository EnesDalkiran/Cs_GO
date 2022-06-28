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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deagle DeagleForm = new Deagle();
            DeagleForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
