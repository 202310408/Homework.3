namespace C_Project01
{
    partial class Form3
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seafood Alfredo - $15.95", "Chicken Alfredo - $13.95", "Chicken Picatta - $13.95", "Turkey Club - $11.95", "Lobster Pie - $19.95", "Prime Rib  - $20.95", "Shrimp Scampi  - $18.95", "Turkey Dinner - $13.95", "Stuffed Chicken - $14.95" });
            comboBox1.Location = new Point(148, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Buffalo Wings - $5.95", "Buffalo Fingers - $6.95", "Potato Skins - $8.95", "Nachos - $8.95", "Mushroom Caps - $10.95", "Shrimp Cocktail - $12.95", "chip and Salsa - $6.95" });
            comboBox2.Location = new Point(148, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 29);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Apple Pie - $5.95", "Sundae - $3.95", "Carrot Cake - $5.95", "Mud Pie  - $4.95", "Apple Crisp - $5.95" });
            comboBox3.Location = new Point(148, 125);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(225, 29);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Soda - $1.95", "Tea - $1.50", "Coffee - $1.25", "Mineral Water - $2.95", "Juice - $2.50", "Milk - $1.50" });
            comboBox4.Location = new Point(148, 20);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(225, 29);
            comboBox4.TabIndex = 3;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(57, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 186);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu Items";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 125);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 7;
            label6.Text = "Dessert";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 90);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 6;
            label5.Text = "Main Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 55);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 5;
            label4.Text = "Appetizer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 4;
            label3.Text = "Beverage";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(477, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waiter information";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 29);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 67);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Waiter's name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Table number";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(131, 240);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 6;
            button1.Text = "Clear Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(330, 9);
            label7.Name = "label7";
            label7.Size = new Size(137, 32);
            label7.TabIndex = 7;
            label7.Text = "Restaurant";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(78, 287);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 4;
            label9.Text = "Subtotal:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(78, 370);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 9;
            label10.Text = "Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(78, 331);
            label11.Name = "label11";
            label11.Size = new Size(40, 21);
            label11.TabIndex = 10;
            label11.Text = "Tax:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(205, 367);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 13;
            textBox3.Text = "$0.00";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(205, 328);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 14;
            textBox4.Text = "$0.00";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(205, 284);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 29);
            textBox5.TabIndex = 15;
            textBox5.Text = "$0.00";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}