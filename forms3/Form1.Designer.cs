namespace forms3
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_shopping_cart_illustration_shopping_cart_grocery_store_vehicle;
            pictureBox1.Location = new Point(371, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(98, 246);
            button1.Name = "button1";
            button1.Size = new Size(131, 41);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 152);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 3;
            label1.Text = "Insira 1 item abaixo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 29);
            label2.Name = "label2";
            label2.Size = new Size(177, 46);
            label2.TabIndex = 4;
            label2.Text = "Senac Eats";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Salmon;
            label3.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 44);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(371, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 154);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(98, 324);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 7;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Button button2;
    }
}