namespace NEWVALUET
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
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBoxDollar = new TextBox();
            textBoxEuro = new TextBox();
            textBoxRub = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 261);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(357, 85);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 152);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "КУРС";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 55);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextChanged += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Выберите валюту";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ввод";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.Tag = "abob";
            textBox2.Text = "abob";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(64, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBoxDollar
            // 
            textBoxDollar.Location = new Point(200, 26);
            textBoxDollar.Name = "textBoxDollar";
            textBoxDollar.Size = new Size(125, 27);
            textBoxDollar.TabIndex = 7;
            textBoxDollar.TextChanged += textBoxDollar_TextChanged;
            // 
            // textBoxEuro
            // 
            textBoxEuro.Location = new Point(200, 59);
            textBoxEuro.Name = "textBoxEuro";
            textBoxEuro.Size = new Size(125, 27);
            textBoxEuro.TabIndex = 8;
            // 
            // textBoxRub
            // 
            textBoxRub.Location = new Point(200, 92);
            textBoxRub.Name = "textBoxRub";
            textBoxRub.Size = new Size(125, 27);
            textBoxRub.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 375);
            Controls.Add(textBoxRub);
            Controls.Add(textBoxEuro);
            Controls.Add(textBoxDollar);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private TextBox textBoxDollar;
        private TextBox textBoxEuro;
        private TextBox textBoxRub;
    }
}
