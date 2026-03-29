namespace _2a
{
    partial class Form2b
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.digit1 = new System.Windows.Forms.TextBox();
            this.digit2 = new System.Windows.Forms.TextBox();
            this.digit4 = new System.Windows.Forms.TextBox();
            this.digit3 = new System.Windows.Forms.TextBox();
            this.digit5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Extracted Digits";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter 5 digits";
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(146, 153);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(18, 20);
            this.digit1.TabIndex = 17;
            this.digit1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(170, 153);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(18, 20);
            this.digit2.TabIndex = 18;
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(217, 153);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(18, 20);
            this.digit4.TabIndex = 20;
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(193, 153);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(18, 20);
            this.digit3.TabIndex = 19;
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(241, 153);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(18, 20);
            this.digit5.TabIndex = 21;
            // 
            // Form2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2b";
            this.Text = "Form2b";
            this.Load += new System.EventHandler(this.Form2b_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox digit1;
        private System.Windows.Forms.TextBox digit2;
        private System.Windows.Forms.TextBox digit4;
        private System.Windows.Forms.TextBox digit3;
        private System.Windows.Forms.TextBox digit5;
    }
}