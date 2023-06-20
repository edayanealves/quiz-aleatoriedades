using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class FrmP1 : Form
    {
        public FrmP1()
        {
            InitializeComponent();
        }

        private void FrmP1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta!");
                //somar na variavel global acertos
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Errrrrrrrrrou");
                //somar na variavel global erros
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
                this.Dispose();
            }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
