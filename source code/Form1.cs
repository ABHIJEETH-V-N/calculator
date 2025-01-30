using System.Collections;


namespace calculator
{
    public partial class Form1 : Form
    {
        string oper;

        public Form1()
        {
            // Load the icon dynamically
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> btnnums = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9, b0 };
            List<Button> btnopers = new List<Button> { sum, min, div, mul };
            foreach (Button btn in btnnums)
            {
                btn.Click += new System.EventHandler(this.num_click);
            }
            foreach (Button btn in btnopers)
            {
                btn.Click += new System.EventHandler(this.btn_click);
            }

        }

        private void num_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            res.Text += btn.Text;
        }



        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            oper += btn.Text;
            n1.Text = res.Text;
            res.Text = "";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (oper == "+")
            {
                n2.Text = res.Text;
                int a = int.Parse(n1.Text) + int.Parse(n2.Text);
                res.Text = a.ToString();
            }
            if (oper == "-")
            {
                n2.Text = res.Text;
                int a = int.Parse(n1.Text) - int.Parse(n2.Text);
                res.Text = a.ToString();
            }
            if (oper == "/")
            {
                n2.Text = res.Text;
                int a = int.Parse(n1.Text) / int.Parse(n2.Text);
                res.Text = a.ToString();
            }
            if (oper == "x")
            {
                n2.Text = res.Text;
                int a = int.Parse(n1.Text) * int.Parse(n2.Text);
                res.Text = a.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            res.Text = "";
            oper = "";
        }

    }
}