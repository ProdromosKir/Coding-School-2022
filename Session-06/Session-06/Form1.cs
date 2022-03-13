using System.Globalization;

namespace Session_06
{
    public partial class Form1 : Form
    {
        //session06

        Calc.Calculator calc = new Calc.Calculator(); 

        float num1, num2;
        float result;
        string operation = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text += button.Text;
           
            // num1 = float.Parse(textBox.Text);
            // label1.Text = textBox.Text;
        }



        private void operation_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //textBox.Text += button.Text;

            num1 = float.Parse(textBox.Text);
            label1.Text = num1.ToString();
            textBox.Clear();
            textBox.Focus();
           
            Button button = (Button)sender;
            operation = button.Text;


            switch (operation)
            {
                case "+":
                   string stringNum2 = textBox.Text;
                    num2 
                   // result = calc.Add(num1, num2);
                    break;
                default:
                    break;

            }
            
           


            //ans = float.Parse(textBox.Text);
            //result = (float)calc.Add(num1, ans);
            //label1.Text = result.ToString();

        }









        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox.Text += 1;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    textBox.Text += 2;
        //}
    }
}