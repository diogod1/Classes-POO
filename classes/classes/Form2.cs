using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num_1.Text);
            int n2 = Convert.ToInt32(txt_num_2.Text);
            lbl_resultado_2.Text = (n1 / n2).ToString();
        }

        private void btn_multi2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num_1.Text);
            int n2 = Convert.ToInt32(txt_num_2.Text);
            lbl_resultado_2.Text = (n1 * n2).ToString();
        }

        private void btn_soma2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num_1.Text);
            int n2 = Convert.ToInt32(txt_num_2.Text);
            lbl_resultado_2.Text = (n1 + n2).ToString();
        }

        private void btn_sub2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num_1.Text);
            int n2 = Convert.ToInt32(txt_num_2.Text);
            lbl_resultado_2.Text = (n1 - n2).ToString();
        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
