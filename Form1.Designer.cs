namespace banbotspam
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            buttonSelectSecret = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox2 = new CheckBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();

            // 
            // button1 (Ban Button)
            // 
            button1.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 160);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 0;
            button1.Text = "แบน!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // 
            // button2 (Fetch Button)
            // 
            button2.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(30, 50);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 1;
            button2.Text = "ดูด";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // 
            // richTextBox1 (Logs/Output)
            // 
            richTextBox1.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(260, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1100, 600);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";

            // 
            // buttonSelectSecret
            // 
            buttonSelectSecret.Font = new Font("Leelawadee UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectSecret.Location = new Point(30, 260);
            buttonSelectSecret.Name = "buttonSelectSecret";
            buttonSelectSecret.Size = new Size(200, 60);
            buttonSelectSecret.TabIndex = 4;
            buttonSelectSecret.Text = "เลือก secret";
            buttonSelectSecret.UseVisualStyleBackColor = true;
            buttonSelectSecret.Click += button4_Click;

            // 
            // textBox1 (Channel Url)
            // 
            textBox1.Location = new Point(30, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 5;

            // 
            // label1 (Channel Url Label)
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 340);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 8;
            label1.Text = "Channel Url";

            // 
            // textBox2 (Video Url)
            // 
            textBox2.Location = new Point(30, 500);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 9;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 480);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 10;
            label2.Text = "YouTube Url (ถ้าต้องการเช็คตามคลิป)";

            // 
            // checkBox2 (Loop)
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(30, 540);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "loop";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;

            // 
            // textBox3 (Loop Interval)
            // 
            textBox3.Location = new Point(90, 538);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;

            // 
            // label3 (Minutes Label)
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 541);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 13;
            label3.Text = "นาที";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 390);
            label4.Name = "label4";
            label4.Size = new Size(239, 15);
            label4.TabIndex = 15;
            label4.Text = "จำนวนคลิปที่ต้องการเช็ค (นับจากคลิปอัปโหลดล่าสุด)";

            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 408);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(40, 23);
            textBox4.TabIndex = 14;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 411);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 16;
            label5.Text = "คลิป";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 630);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonSelectSecret);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "banbot BY Cattales";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button buttonSelectSecret;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}
