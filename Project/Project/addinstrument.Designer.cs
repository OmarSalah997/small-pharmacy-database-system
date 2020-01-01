namespace Project
{
    partial class addinstrument
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
            this.textBox2cat = new System.Windows.Forms.TextBox();
            this.textBox3type = new System.Windows.Forms.TextBox();
            this.textBox4id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(125, 38);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(100, 20);
            this.textBox1name.TabIndex = 1;
            // 
            // textBox2cat
            // 
            this.textBox2cat.Location = new System.Drawing.Point(125, 81);
            this.textBox2cat.Name = "textBox2cat";
            this.textBox2cat.Size = new System.Drawing.Size(100, 20);
            this.textBox2cat.TabIndex = 2;
            // 
            // textBox3type
            // 
            this.textBox3type.Location = new System.Drawing.Point(125, 123);
            this.textBox3type.Name = "textBox3type";
            this.textBox3type.Size = new System.Drawing.Size(100, 20);
            this.textBox3type.TabIndex = 3;
            // 
            // textBox4id
            // 
            this.textBox4id.Location = new System.Drawing.Point(125, 166);
            this.textBox4id.Name = "textBox4id";
            this.textBox4id.Size = new System.Drawing.Size(100, 20);
            this.textBox4id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // addinstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4id);
            this.Controls.Add(this.textBox3type);
            this.Controls.Add(this.textBox2cat);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.button1);
            this.Name = "addinstrument";
            this.Text = "addinstrument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.TextBox textBox2cat;
        private System.Windows.Forms.TextBox textBox3type;
        private System.Windows.Forms.TextBox textBox4id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}