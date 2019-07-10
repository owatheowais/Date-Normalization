namespace Date_Normalization
{
    partial class Form1
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
            this.Submit = new System.Windows.Forms.Button();
            this.rt = new System.Windows.Forms.RichTextBox();
            this.rt2 = new System.Windows.Forms.RichTextBox();
            this.rt3 = new System.Windows.Forms.RichTextBox();
            this.rt4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rt5 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rt7 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rt6 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(465, 488);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rt
            // 
            this.rt.Location = new System.Drawing.Point(24, 291);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(140, 166);
            this.rt.TabIndex = 1;
            this.rt.Text = "";
            // 
            // rt2
            // 
            this.rt2.Location = new System.Drawing.Point(24, 33);
            this.rt2.Name = "rt2";
            this.rt2.Size = new System.Drawing.Size(941, 211);
            this.rt2.TabIndex = 2;
            this.rt2.Text = "";
            // 
            // rt3
            // 
            this.rt3.Location = new System.Drawing.Point(195, 291);
            this.rt3.Name = "rt3";
            this.rt3.Size = new System.Drawing.Size(140, 166);
            this.rt3.TabIndex = 3;
            this.rt3.Text = "";
            this.rt3.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // rt4
            // 
            this.rt4.Location = new System.Drawing.Point(669, 291);
            this.rt4.Name = "rt4";
            this.rt4.Size = new System.Drawing.Size(140, 166);
            this.rt4.TabIndex = 4;
            this.rt4.Text = "";
            this.rt4.TextChanged += new System.EventHandler(this.rt4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year Month Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year Day Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Month Day Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Month Year Day";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rt5
            // 
            this.rt5.Location = new System.Drawing.Point(824, 291);
            this.rt5.Name = "rt5";
            this.rt5.Size = new System.Drawing.Size(140, 166);
            this.rt5.TabIndex = 12;
            this.rt5.Text = "";
            this.rt5.TextChanged += new System.EventHandler(this.rt5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Day Year Month";
            // 
            // rt7
            // 
            this.rt7.Location = new System.Drawing.Point(515, 291);
            this.rt7.Name = "rt7";
            this.rt7.Size = new System.Drawing.Size(140, 166);
            this.rt7.TabIndex = 16;
            this.rt7.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Day Month Year";
            // 
            // rt6
            // 
            this.rt6.Location = new System.Drawing.Point(358, 291);
            this.rt6.Name = "rt6";
            this.rt6.Size = new System.Drawing.Size(140, 166);
            this.rt6.TabIndex = 14;
            this.rt6.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rt7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rt6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rt5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt4);
            this.Controls.Add(this.rt3);
            this.Controls.Add(this.rt2);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Date Normalization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox rt;
        private System.Windows.Forms.RichTextBox rt2;
        private System.Windows.Forms.RichTextBox rt3;
        private System.Windows.Forms.RichTextBox rt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rt7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rt6;
    }
}

