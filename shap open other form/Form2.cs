using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shap_open_other_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int so;
            so=int.Parse(txtso.Text);
            for(int i = 1; i <= so; i++) 
            {
                if (so % i == 0) 
                {
                lsbketqua.Items.Add(i.ToString());

                }

            }
        }
    }
}
