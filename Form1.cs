namespace csharp_tutorial
{
    public partial class lbl_a : Form
    {
        public lbl_a()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            result  = a + b;
            lbl_result.Text = result.ToString();
        }
    }
}