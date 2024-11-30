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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            button3 = new Button();
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
            btnCircleArea.TabIndex = 2;
            btnCircleArea.Text = "คำนวณ";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(436, 55);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(114, 38);
            btnTriangleArea.TabIndex = 5;
            btnTriangleArea.Text = "คำนวณ";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(436, 54);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(114, 38);
            btnHexagonArea.TabIndex = 7;
            btnHexagonArea.Text = "คำนวณ";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(164, 61);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(198, 27);
            txtRadius.TabIndex = 1;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(164, 38);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(198, 27);
            txtHeight.TabIndex = 3;
            txtHeight.Text = "1";
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextChanged += textBox2_TextChanged;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(164, 83);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(198, 27);
            txtWidth.TabIndex = 4;
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
            txtPolygonWidth.TabIndex = 6;
            txtPolygonWidth.Text = "1";
            txtPolygonWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 45);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "ความยาวของฐาน";
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
            lblResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(663, 29);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(273, 78);
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
            groupBox2.Location = new Point(12, 149);
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
            groupBox4.Location = new Point(12, 290);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(567, 125);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "คำนวณหาพื้นที่หกเหลี่ยมด้านเท่า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 9);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 20;
            label6.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(99, 431);
            button1.Name = "button1";
            button1.Size = new Size(163, 44);
            button1.TabIndex = 21;
            button1.Text = "ปิดโปรแกรม";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Aqua;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(663, 181);
            label7.Name = "label7";
            label7.Size = new Size(273, 78);
            label7.TabIndex = 22;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Aqua;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(663, 321);
            label8.Name = "label8";
            label8.Size = new Size(273, 78);
            label8.TabIndex = 23;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(663, 149);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 24;
            label9.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(663, 290);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 25;
            label10.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // label11
            // 
            label11.BackColor = Color.Aqua;
            label11.Location = new Point(713, 416);
            label11.Name = "label11";
            label11.Size = new Size(223, 57);
            label11.TabIndex = 26;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(578, 430);
            button2.Name = "button2";
            button2.Size = new Size(102, 43);
            button2.TabIndex = 8;
            button2.Text = "ผลรวม";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Location = new Point(319, 430);
            button3.Name = "button3";
            button3.Size = new Size(163, 44);
            button3.TabIndex = 9;
            button3.Text = "เริ่มใหม่";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1015, 491);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblResult);
            Controls.Add(label5);
            Name = "Form1";
            Text = "โปรแกรมคำนวณพื้นที่รูปเรขาคณิต";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
        private Button button3;
    }
}
