namespace Calculator_homework2
{
    public partial class Form1 : Form
    {
        decimal a; //������1
        decimal b; //������2
        char c; //�����



        public Form1()
        {
            InitializeComponent();
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                c = Convert.ToChar(radioButton.Text);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(numBox1.Text);
            b = Convert.ToDecimal(numBox2.Text);
            decimal d = 0;
            if (c == '+')
            {
                d = a + b;
            }
            else if (c == '-')
            {
                d = a - b;
            }
            else if (c == '*')
            {
                d = a * b;
            }
            else if (c == '/')
            {
                d = a / b;
            }
            textBox1.Text = d.ToString("G");

        }

    }
}