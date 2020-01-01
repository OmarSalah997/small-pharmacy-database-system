namespace Project
{
    partial class addnewdrug
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
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.textBox2type = new System.Windows.Forms.TextBox();
            this.textBox3price = new System.Windows.Forms.TextBox();
            this.textBox4exp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(108, 27);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(100, 20);
            this.textBox1name.TabIndex = 0;
            // 
            // textBox2type
            // 
            this.textBox2type.Location = new System.Drawing.Point(108, 53);
            this.textBox2type.Name = "textBox2type";
            this.textBox2type.Size = new System.Drawing.Size(100, 20);
            this.textBox2type.TabIndex = 1;
            // 
            // textBox3price
            // 
            this.textBox3price.Location = new System.Drawing.Point(108, 79);
            this.textBox3price.Name = "textBox3price";
            this.textBox3price.Size = new System.Drawing.Size(100, 20);
            this.textBox3price.TabIndex = 2;
            // 
            // textBox4exp
            // 
            this.textBox4exp.Location = new System.Drawing.Point(108, 105);
            this.textBox4exp.Name = "textBox4exp";
            this.textBox4exp.Size = new System.Drawing.Size(100, 20);
            this.textBox4exp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "exp date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnewdrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4exp);
            this.Controls.Add(this.textBox3price);
            this.Controls.Add(this.textBox2type);
            this.Controls.Add(this.textBox1name);
            this.Name = "addnewdrug";
            this.Text = "addnewdrug";
            this.Load += new System.EventHandler(this.addnewdrug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.TextBox textBox2type;
        private System.Windows.Forms.TextBox textBox3price;
        private System.Windows.Forms.TextBox textBox4exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}