namespace Finding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCircleArea = new Button();
            btnTriangleArea = new Button();
            btnHexagonArea = new Button();
            toolTip1 = new ToolTip(components);
            txtRadius = new TextBox();
            txtHeight = new TextBox();
            txtWidth = new TextBox();
            label1 = new Label();
            txtPolygonWidth = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblResult = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(436, 53);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(114, 42);
            btnCircleArea.TabIndex = 0;
            btnCircleArea.Text = "คำนวณ";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(436, 55);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(114, 38);
            btnTriangleArea.TabIndex = 1;
            btnTriangleArea.Text = "คำนวณ";
            btnTriangleArea.UseVisualStyleBackColor = true;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(436, 54);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(114, 38);
            btnHexagonArea.TabIndex = 2;
            btnHexagonArea.Text = "คำนวณ";
            btnHexagonArea.UseVisualStyleBackColor = true;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(164, 61);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(198, 27);
            txtRadius.TabIndex = 3;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(164, 38);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(198, 27);
            txtHeight.TabIndex = 4;
            txtHeight.Text = "1";
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextChanged += textBox2_TextChanged;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(164, 83);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(198, 27);
            txtWidth.TabIndex = 5;
            txtWidth.Text = "1";
            txtWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 64);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "รัศมีของวงกลม ";
            // 
            // txtPolygonWidth
            // 
            txtPolygonWidth.Location = new Point(164, 60);
            txtPolygonWidth.Name = "txtPolygonWidth";
            txtPolygonWidth.Size = new Size(198, 27);
            txtPolygonWidth.TabIndex = 7;
            txtPolygonWidth.Text = "1";
            txtPolygonWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 45);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 8;
            label2.Text = "ค่าความยาวของฐาน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "ความสูง";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 60);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 10;
            label4.Text = "ความยาวฐาน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 9);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Aqua;
            lblResult.Location = new Point(663, 32);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(295, 132);
            lblResult.TabIndex = 14;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Moccasin;
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 125);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณหาพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Fuchsia;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 125);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณหาพื้นที่สามเหลี่ยม";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(360, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.PaleGreen;
            groupBox4.Controls.Add(txtPolygonWidth);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(btnHexagonArea);
            groupBox4.Location = new Point(12, 313);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(567, 125);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "คำนวณหาพื้นที่หกเหลี่ยมด้านเท่า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 12);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 20;
            label6.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(819, 396);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 21;
            button1.Text = "ปิดโปรแกรม";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1015, 464);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblResult);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Formคำนวณหาพื้นที่รูปเลขาคณิต";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCircleArea;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private ToolTip toolTip1;
        private TextBox txtRadius;
        private TextBox txtHeight;
        private TextBox txtWidth;
        private Label label1;
        private TextBox txtPolygonWidth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblResult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private Button button1;
    }
}
