namespace classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblreduzir_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculadora res = new calculadora();
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            lbl_result.Text = (res.divisao(n1, n2)).ToString();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            calculadora res = new calculadora();
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            lbl_result.Text = (res.Soma(n1, n2)).ToString();
        }

        private void btn_subtrac_Click(object sender, EventArgs e)
        {
            calculadora res = new calculadora();
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            lbl_result.Text = (res.subtraçao(n1, n2)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            calculadora res = new calculadora();
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            lbl_result.Text = (res.Multiplicaçao(n1, n2)).ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}