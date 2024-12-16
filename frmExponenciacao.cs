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
    public partial class frmExponenciacao : Form
    {
        public frmExponenciacao()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                double baseNumber = 0;
                double exponent = 0;
                double result = 0;
                baseNumber = int.Parse(txtNum1.Text);
                exponent = int.Parse(txtNum2.Text);
                result = Math.Pow(baseNumber, exponent);
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
