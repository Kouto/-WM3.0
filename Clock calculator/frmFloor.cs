using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    internal partial class frmFloor : Form
    {
        internal frmFloor()
        {
            InitializeComponent();
        }

        internal frmFloor(Floor floor)
        {
            InitializeComponent();

            // заполняем поля
            txtPerimeter.Text = floor.perimeter.ToString(); ;
            numCnt.Value = floor.cnt;
            numNumber.Value = floor.number;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
