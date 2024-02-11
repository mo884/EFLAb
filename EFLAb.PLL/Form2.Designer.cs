namespace EFLAb.PLL
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            textBox7 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            update = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(523, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 394);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 16;
            label1.Text = "title";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(77, 22);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(417, 32);
            textBox7.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 18;
            label2.Text = "Price";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 79);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(417, 32);
            textBox4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 142);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 20;
            label3.Text = "Advance";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 139);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(417, 32);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 197);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 22;
            label4.Text = "Royality";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 194);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 32);
            textBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 250);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 24;
            label5.Text = "Royality";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 247);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 32);
            textBox1.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 306);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 26;
            label6.Text = "Publisher";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(417, 23);
            comboBox1.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(38, 368);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 29;
            button2.Text = "Deleted";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(398, 368);
            button1.Name = "button1";
            button1.Size = new Size(119, 48);
            button1.TabIndex = 28;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(255, 128, 0);
            update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.ForeColor = SystemColors.ButtonHighlight;
            update.Location = new Point(181, 368);
            update.Name = "update";
            update.Size = new Size(177, 48);
            update.TabIndex = 27;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(update);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox7;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Button update;
    }
}