using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shap_open_other_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="vothongthai"&& txtmk.Text=="thaineae")
            {
                Form2 form2= new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai rồi nhập lại đi coi mật khẩu với tài khoản đi mấy ông nội", "sai rồi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
