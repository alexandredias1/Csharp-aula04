﻿namespace ExemploForms
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(569, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(176, 27);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Recém Habilidado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(569, 189);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(172, 27);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Menor de 25 anos";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(569, 250);
            button1.Name = "button1";
            button1.Size = new Size(188, 44);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(569, 324);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(569, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(569, 40);
            label2.Name = "label2";
            label2.Size = new Size(194, 34);
            label2.TabIndex = 6;
            label2.Text = "Simulador de seguro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(511, 98);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 7;
            label3.Text = "Valor";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.carro2;
            ClientSize = new Size(843, 479);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}