﻿namespace Exercicio3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 89);
            label1.Name = "label1";
            label1.Size = new Size(411, 15);
            label1.TabIndex = 0;
            label1.Text = "Diga se o valor A é multiplo do valor B. Se for multiplo mostre quantas vezes:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 117);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor A: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 156);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor B:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(129, 197);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 5;
            button1.Text = "Executa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 312);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
