using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDell_oca
{
    public partial class FormNomi: Form
    {
        public FormNomi()
        {
            InitializeComponent();
        }

        public string FirstName;
        public string SecondName;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if(txtbx_1.Text != "" && txtbx_1.Text != "")
            {
                FirstName = txtbx_1.Text;
                SecondName = txtbx_2.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Per favori inserire entrambi i nomi");
                return;
            }
        }
    }
}
