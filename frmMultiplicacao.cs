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
    public partial class frmMultiplicacao : Form
    {
        public frmMultiplicacao()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 0;
                int n2 = 0;
                int result = 0;
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
                result = n1 * n2;
                lblResultado.Text = result.ToString();
            }
            catch (System.Exception ex) /*genérico*/
            {
                string mens = ex.Message;
                MessageBox.Show(mens + "\nTente Novamente! ! !",
                "### ERRO ###", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                lblResultado.Text = "";
                txtNum1.Focus();
            }
        }
    }
}
