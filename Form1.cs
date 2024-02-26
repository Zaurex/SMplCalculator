namespace SmplCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         int var1;
          int var2;
        int result;
        string op;
        string resultTotal;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + Buttonn7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultDisp.Text = resultDisp.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op = "-";
            var1 = int.Parse(resultDisp.Text);

            resultDisp.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = "+";
            var1 = int.Parse(resultDisp.Text);

            resultDisp.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = "*";
            var1 = int.Parse(resultDisp.Text);

            resultDisp.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "/";
            var1 = int.Parse(resultDisp.Text);

            resultDisp.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var2 = int.Parse(resultDisp.Text);
            if (op == "-") result = var1 - var2;
            if (op == "+") result = var1 + var2;
            if (op == "*") result = var1 * var2;
            if (op == "/") result = var1 / var2;

            resultDisp.Text = result + "";



        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultDisp.Clear();
            var1 = (0);
            var2 = (0);
            result = (0);
        }
    }
}