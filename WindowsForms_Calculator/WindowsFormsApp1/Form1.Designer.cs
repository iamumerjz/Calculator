
namespace WindowsFormsApp1
{
    partial class lab
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(18, 52);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(430, 72);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.TextChanged += new System.EventHandler(this.resultbox_TextChanged);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.plus.Location = new System.Drawing.Point(341, 356);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(99, 77);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(20, 443);
            this.one.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(99, 77);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(127, 443);
            this.two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(99, 77);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(233, 443);
            this.three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(99, 77);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button3_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.four.Location = new System.Drawing.Point(20, 356);
            this.four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(99, 77);
            this.four.TabIndex = 11;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(20, 530);
            this.zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(206, 77);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.five.Location = new System.Drawing.Point(126, 356);
            this.five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(99, 77);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button6_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.six.Location = new System.Drawing.Point(234, 356);
            this.six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(99, 77);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button7_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.minus.Location = new System.Drawing.Point(341, 269);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(99, 77);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.seven.Location = new System.Drawing.Point(20, 269);
            this.seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(99, 77);
            this.seven.TabIndex = 16;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.eight.Location = new System.Drawing.Point(127, 269);
            this.eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(99, 77);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nine.Location = new System.Drawing.Point(234, 269);
            this.nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(99, 77);
            this.nine.TabIndex = 18;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.multiply.Location = new System.Drawing.Point(341, 182);
            this.multiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(99, 77);
            this.multiply.TabIndex = 19;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.Highlight;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(341, 443);
            this.equal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(99, 164);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.divide.Location = new System.Drawing.Point(234, 182);
            this.divide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(99, 77);
            this.divide.TabIndex = 21;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click_1);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(234, 530);
            this.dot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(99, 77);
            this.dot.TabIndex = 22;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(18, 182);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(207, 77);
            this.clear.TabIndex = 23;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 639);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.multiply);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lab";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.lab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button clear;
    }
}

