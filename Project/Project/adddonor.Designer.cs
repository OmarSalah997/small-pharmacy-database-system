namespace Project
{
    partial class adddonor
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.textBox2username = new System.Windows.Forms.TextBox();
            this.textBox3pass = new System.Windows.Forms.TextBox();
            this.textBox4phone = new System.Windows.Forms.TextBox();
            this.textBox5email = new System.Windows.Forms.TextBox();
            this.textBox6ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(112, 22);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(100, 20);
            this.textBox1name.TabIndex = 1;
            // 
            // textBox2username
            // 
            this.textBox2username.Location = new System.Drawing.Point(112, 48);
            this.textBox2username.Name = "textBox2username";
            this.textBox2username.Size = new System.Drawing.Size(100, 20);
            this.textBox2username.TabIndex = 2;
            // 
            // textBox3pass
            // 
            this.textBox3pass.Location = new System.Drawing.Point(112, 74);
            this.textBox3pass.Name = "textBox3pass";
            this.textBox3pass.Size = new System.Drawing.Size(100, 20);
            this.textBox3pass.TabIndex = 3;
            // 
            // textBox4phone
            // 
            this.textBox4phone.Location = new System.Drawing.Point(112, 100);
            this.textBox4phone.Name = "textBox4phone";
            this.textBox4phone.Size = new System.Drawing.Size(100, 20);
            this.textBox4phone.TabIndex = 4;
            // 
            // textBox5email
            // 
            this.textBox5email.Location = new System.Drawing.Point(112, 126);
            this.textBox5email.Name = "textBox5email";
            this.textBox5email.Size = new System.Drawing.Size(100, 20);
            this.textBox5email.TabIndex = 5;
            // 
            // textBox6ID
            // 
            this.textBox6ID.Location = new System.Drawing.Point(112, 152);
            this.textBox6ID.Name = "textBox6ID";
            this.textBox6ID.Size = new System.Drawing.Size(100, 20);
            this.textBox6ID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "user name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // adddonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 195);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6ID);
            this.Controls.Add(this.textBox5email);
            this.Controls.Add(this.textBox4phone);
            this.Controls.Add(this.textBox3pass);
            this.Controls.Add(this.textBox2username);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.button1);
            this.Name = "adddonor";
            this.Text = "adddonor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.TextBox textBox2username;
        private System.Windows.Forms.TextBox textBox3pass;
        private System.Windows.Forms.TextBox textBox4phone;
        private System.Windows.Forms.TextBox textBox5email;
        private System.Windows.Forms.TextBox textBox6ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}