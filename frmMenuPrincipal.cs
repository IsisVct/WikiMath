using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCGTEC2023
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void círculoTrigonométricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCirculoTrigonometrico form = new frmCirculoTrigonometrico();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicao form = new frmAdicao();
            form.Show();
        }

        private void origemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrigem form = new frmOrigem();
            form.Show();
        }

        private void substraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                frmSubtracao form = new frmSubtracao();
                form.Show();
            }
        }

        private void divisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDivisao form = new frmDivisao();
            form.Show();
        }

        private void multiplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiplicacao form =new frmMultiplicacao();
            form.Show();
        }

        private void exponenciaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExponenciacao form = new frmExponenciacao();
            form.Show();
        }

        private void radiaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadiciacao form = new frmRadiciacao();
            form.Show();
        }

        private void trigonometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void origemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrigemTrig form = new frmOrigemTrig();
            form.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void oQuemVemAlémToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlem form = new frmAlem();
            form.Show();
        }
    }
}
