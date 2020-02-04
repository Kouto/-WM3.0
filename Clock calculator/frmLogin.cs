using System;
using System.Windows.Forms;

namespace Clock_calculator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password.getKey())
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
