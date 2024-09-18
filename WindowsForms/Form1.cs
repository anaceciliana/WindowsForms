using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txbName.Text + "\n" + txbCpf.Text + "\n" + txbTel.Text + "\n" + txbEmail.Text + "\n" + txbRg.Text + "\n" + txbEnd.Text);

            pagina_inicial frm = new pagina_inicial();
                this. Visible = false;
            frm.ShowDialog();
            this.Visible = true;    
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
