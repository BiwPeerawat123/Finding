namespace Finding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("ยินดีต้อนรับผู้เข้าใช้งาน", "Welcome");
            //MessageBox.Show("Hello, User", "Second Message",
            //MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะๆๆๆๆๆๆ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิดฟอร์ม
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();

            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Text);
            if(double.TryParse(txtRadius.Text, out Radius)==false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "!!!Error!!!");
                txtRadius.Focus();
                return;
            }
                
            //process
            double CircleArea = Math.PI*Math.Pow(Radius, 2);
            //Math.PI  ให้ค่า PI
            //Math.Pow(x,y) x ยกกำลัง  y
            //output
            lblResult.Text = CircleArea.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }
    }

}
