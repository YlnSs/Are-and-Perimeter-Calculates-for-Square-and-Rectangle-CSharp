namespace _9._25._2022_9._03_PM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
            label7.Visible = false;
            textBox2.Visible = false;
            panel1.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
            label2.Text = "Write The Short Side(Kisa Kenari Giriniz)";
            panel1.Visible = true;
            button4.Visible = false;
            button3.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int oneside;
            int area;
            int perimeter;

            oneside = Convert.ToInt32(textBox1.Text);

            area = oneside * oneside;
            perimeter = 4 * oneside;

            label5.Text = area.ToString();
            label6.Text = perimeter.ToString();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int longside;
            int shortside;
            int areofreact, perimeterofreact;

            longside = Convert.ToInt32(textBox2.Text);
            shortside = Convert.ToInt32(textBox1.Text);

            areofreact = longside * shortside;
            perimeterofreact = (2 * shortside) + (2 * longside);
            label5.Text = areofreact.ToString();
            label6.Text = perimeterofreact.ToString();
        }
    }
}