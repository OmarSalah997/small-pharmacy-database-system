namespace Project
{
    partial class addnewsupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.textBox2phone = new System.Windows.Forms.TextBox();
            this.textBox3email = new System.Windows.Forms.TextBox();
            this.textBox4id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(106, 19);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(100, 20);
            this.textBox1name.TabIndex = 5;
            // 
            // textBox2phone
            // 
            this.textBox2phone.Location = new System.Drawing.Point(106, 42);
            this.textBox2phone.Name = "textBox2phone";
            this.textBox2phone.Size = new System.Drawing.Size(100, 20);
            this.textBox2phone.TabIndex = 6;
            // 
            // textBox3email
            // 
            this.textBox3email.Location = new System.Drawing.Point(106, 65);
            this.textBox3email.Name = "textBox3email";
            this.textBox3email.Size = new System.Drawing.Size(100, 20);
            this.textBox3email.TabIndex = 7;
            // 
            // textBox4id
            // 
            this.textBox4id.Location = new System.Drawing.Point(106, 87);
            this.textBox4id.Name = "textBox4id";
            this.textBox4id.Size = new System.Drawing.Size(100, 20);
            this.textBox4id.TabIndex = 8;
            // 
            // addnewsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 137);
            this.Controls.Add(this.textBox4id);
            this.Controls.Add(this.textBox3email);
            this.Controls.Add(this.textBox2phone);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "addnewsupplier";
            this.Text = "addnewsupplier";
            this.Load += new System.EventHandler(this.addnewsupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.TextBox textBox2phone;
        private System.Windows.Forms.TextBox textBox3email;
        private System.Windows.Forms.TextBox textBox4id;
    }
}