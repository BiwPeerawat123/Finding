using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                double circleArea = CalculateCircleArea(radius); // เรียก Method Return
                DisplayLabelResult(lblResult, circleArea);       // แสดงผลผ่าน Method Void
                txtRadius.Focus();
                txtRadius.SelectAll();
            }
            else
            {
                DisplayMessage("กรอกข้อมูลไม่ถูกต้อง", "!!!Error!!!");
                txtRadius.Focus();
            }


        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHeight.Text, out double height) &&
                double.TryParse(txtWidth.Text, out double width))
            {
                double triangleArea = CalculateTriangleArea(height, width); // เรียก Method Return
                DisplayLabelResult(label7, triangleArea);                  // แสดงผลผ่าน Method Void
                txtHeight.Focus();
                txtHeight.SelectAll();
            }
            else
            {
                DisplayMessage("กรอกข้อมูลไม่ถูกต้อง", "!!!Error!!!");
                txtHeight.Focus();
            }
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPolygonWidth.Text, out double polygonWidth))
            {
                double hexagonArea = CalculateHexagonArea(polygonWidth); // เรียก Method Return
                DisplayLabelResult(label8, hexagonArea);                // แสดงผลผ่าน Method Void
                txtPolygonWidth.Focus();
                txtPolygonWidth.SelectAll();
            }
            else
            {
                DisplayMessage("กรอกข้อมูลไม่ถูกต้อง", "!!!Error!!!");
                txtPolygonWidth.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(lblResult.Text, out double circleArea);
            double.TryParse(label7.Text, out double triangleArea);
            double.TryParse(label8.Text, out double hexagonArea);

            double totalArea = circleArea + triangleArea + hexagonArea;

            DisplayLabelResult(label11, totalArea); // แสดงผลผ่าน Method Void



        }





        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private double CalculateTriangleArea(double height, double width)
        {
            return 0.5 * height * width;
        }

        private double CalculateHexagonArea(double polygonWidth)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(polygonWidth, 2);
        }

        private void DisplayMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }



        private void DisplayLabelResult(Label label, double value)
        {
            label.Text = value.ToString("0.00");
        }

        private void clearForm()
        {


            txtRadius.Text = "0";
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtPolygonWidth.Text = "0";
            lblResult.Text = "";
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            txtRadius.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }


}
