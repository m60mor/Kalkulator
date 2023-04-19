using System.Windows.Forms.VisualStyles;

namespace Kalkulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonSimbol = new Button();
            buttonSeparator = new Button();
            buttonResult = new Button();
            buttonSum = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonRoot = new Button();
            buttonBackspace = new Button();
            buttonClear = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 52, 52);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 248);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(60, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 52, 52);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(144, 248);
            button2.Name = "button2";
            button2.Size = new Size(60, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 52, 52);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(210, 248);
            button3.Name = "button3";
            button3.Size = new Size(60, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 52, 52);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(78, 192);
            button4.Name = "button4";
            button4.Size = new Size(60, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(52, 52, 52);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(144, 192);
            button5.Name = "button5";
            button5.Size = new Size(60, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(52, 52, 52);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(210, 192);
            button6.Name = "button6";
            button6.Size = new Size(60, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(52, 52, 52);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(78, 136);
            button7.Name = "button7";
            button7.Size = new Size(60, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(52, 52, 52);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(144, 136);
            button8.Name = "button8";
            button8.Size = new Size(60, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(52, 52, 52);
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(210, 136);
            button9.Name = "button9";
            button9.Size = new Size(60, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(52, 52, 52);
            button0.FlatAppearance.BorderColor = Color.Black;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(144, 304);
            button0.Name = "button0";
            button0.Size = new Size(60, 50);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button_Click;
            // 
            // buttonSimbol
            // 
            buttonSimbol.BackColor = Color.FromArgb(52, 52, 52);
            buttonSimbol.FlatAppearance.BorderColor = Color.Black;
            buttonSimbol.FlatStyle = FlatStyle.Flat;
            buttonSimbol.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSimbol.ForeColor = Color.White;
            buttonSimbol.Location = new Point(78, 304);
            buttonSimbol.Name = "buttonSimbol";
            buttonSimbol.Size = new Size(60, 50);
            buttonSimbol.TabIndex = 10;
            buttonSimbol.Text = "+/-";
            buttonSimbol.UseVisualStyleBackColor = false;
            buttonSimbol.Click += buttonSimbol_Click;
            // 
            // buttonSeparator
            // 
            buttonSeparator.BackColor = Color.FromArgb(52, 52, 52);
            buttonSeparator.FlatAppearance.BorderColor = Color.Black;
            buttonSeparator.FlatStyle = FlatStyle.Flat;
            buttonSeparator.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeparator.ForeColor = Color.White;
            buttonSeparator.Location = new Point(210, 304);
            buttonSeparator.Name = "buttonSeparator";
            buttonSeparator.Size = new Size(60, 50);
            buttonSeparator.TabIndex = 11;
            buttonSeparator.Text = ",";
            buttonSeparator.UseVisualStyleBackColor = false;
            buttonSeparator.Click += buttonSeparator_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.FromArgb(52, 52, 92);
            buttonResult.FlatAppearance.BorderColor = Color.Black;
            buttonResult.FlatStyle = FlatStyle.Flat;
            buttonResult.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResult.ForeColor = Color.White;
            buttonResult.Location = new Point(276, 304);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(106, 50);
            buttonResult.TabIndex = 12;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.FromArgb(52, 52, 52);
            buttonSum.FlatAppearance.BorderColor = Color.Black;
            buttonSum.FlatStyle = FlatStyle.Flat;
            buttonSum.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSum.ForeColor = Color.White;
            buttonSum.Location = new Point(276, 248);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(106, 50);
            buttonSum.TabIndex = 13;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonOperator_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = Color.FromArgb(52, 52, 52);
            buttonSubtract.FlatAppearance.BorderColor = Color.Black;
            buttonSubtract.FlatStyle = FlatStyle.Flat;
            buttonSubtract.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtract.ForeColor = Color.White;
            buttonSubtract.Location = new Point(276, 191);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(106, 50);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonOperator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.FromArgb(52, 52, 52);
            buttonMultiply.FlatAppearance.BorderColor = Color.Black;
            buttonMultiply.FlatStyle = FlatStyle.Flat;
            buttonMultiply.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.ForeColor = Color.White;
            buttonMultiply.Location = new Point(276, 135);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(106, 50);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonOperator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.FromArgb(52, 52, 52);
            buttonDivide.FlatAppearance.BorderColor = Color.Black;
            buttonDivide.FlatStyle = FlatStyle.Flat;
            buttonDivide.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.ForeColor = Color.White;
            buttonDivide.Location = new Point(276, 79);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(106, 50);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonOperator_Click;
            // 
            // buttonRoot
            // 
            buttonRoot.BackColor = Color.FromArgb(52, 52, 52);
            buttonRoot.FlatAppearance.BorderColor = Color.Black;
            buttonRoot.FlatStyle = FlatStyle.Flat;
            buttonRoot.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRoot.ForeColor = Color.White;
            buttonRoot.Location = new Point(78, 79);
            buttonRoot.Name = "buttonRoot";
            buttonRoot.Size = new Size(192, 50);
            buttonRoot.TabIndex = 17;
            buttonRoot.Text = "√";
            buttonRoot.UseVisualStyleBackColor = false;
            buttonRoot.Click += buttonRoot_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.BackColor = Color.FromArgb(122, 72, 52);
            buttonBackspace.FlatAppearance.BorderColor = Color.Black;
            buttonBackspace.FlatStyle = FlatStyle.Flat;
            buttonBackspace.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackspace.ForeColor = Color.White;
            buttonBackspace.Location = new Point(12, 221);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(60, 133);
            buttonBackspace.TabIndex = 18;
            buttonBackspace.Text = "<-";
            buttonBackspace.UseVisualStyleBackColor = false;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(92, 52, 52);
            buttonClear.FlatAppearance.BorderColor = Color.Black;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Carlito", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(12, 79);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(60, 133);
            buttonClear.TabIndex = 19;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(12, 12, 12);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.HideSelection = false;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(6, 20);
            textBox1.Margin = new Padding(3, 0, 3, 3);
            textBox1.MaxLength = 32000;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(382, 39);
            textBox1.TabIndex = 20;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(22, 22, 22);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(9, -2);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(361, 22);
            textBox2.TabIndex = 21;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(394, 366);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonClear);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonRoot);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonSum);
            Controls.Add(buttonResult);
            Controls.Add(buttonSeparator);
            Controls.Add(buttonSimbol);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kalkulator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonSimbol;
        private Button buttonSeparator;
        private Button buttonResult;
        private Button buttonSum;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonRoot;
        private Button buttonBackspace;
        private Button buttonClear;
        private TextBox textBox2;
        private TextBox textBox1;
        private ErrorProvider errorProvider1;
    }
}