namespace auto_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hpl = new System.Windows.Forms.Label();
            this.mpl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dnhp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.key_dnhp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dnmp = new System.Windows.Forms.TextBox();
            this.key_dnmp = new System.Windows.Forms.TextBox();
            this.dl1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.TextBox();
            this.key2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dl2 = new System.Windows.Forms.TextBox();
            this.key3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dl3 = new System.Windows.Forms.TextBox();
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.standonl = new System.Windows.Forms.CheckBox();
            this.notx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MP:";
            // 
            // hpl
            // 
            this.hpl.AutoSize = true;
            this.hpl.ForeColor = System.Drawing.Color.Red;
            this.hpl.Location = new System.Drawing.Point(44, 43);
            this.hpl.Name = "hpl";
            this.hpl.Size = new System.Drawing.Size(0, 13);
            this.hpl.TabIndex = 2;
            // 
            // mpl
            // 
            this.mpl.AutoSize = true;
            this.mpl.ForeColor = System.Drawing.Color.Blue;
            this.mpl.Location = new System.Drawing.Point(47, 80);
            this.mpl.Name = "mpl";
            this.mpl.Size = new System.Drawing.Size(0, 13);
            this.mpl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dnhp
            // 
            this.dnhp.Location = new System.Drawing.Point(198, 48);
            this.dnhp.Name = "dnhp";
            this.dnhp.Size = new System.Drawing.Size(66, 20);
            this.dnhp.TabIndex = 6;
            this.dnhp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dnhp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danger HP:";
            // 
            // key_dnhp
            // 
            this.key_dnhp.Location = new System.Drawing.Point(281, 48);
            this.key_dnhp.Name = "key_dnhp";
            this.key_dnhp.Size = new System.Drawing.Size(58, 20);
            this.key_dnhp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danger MP:";
            // 
            // dnmp
            // 
            this.dnmp.Location = new System.Drawing.Point(198, 80);
            this.dnmp.Name = "dnmp";
            this.dnmp.Size = new System.Drawing.Size(66, 20);
            this.dnmp.TabIndex = 11;
            this.dnmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dnmp_KeyPress);
            // 
            // key_dnmp
            // 
            this.key_dnmp.Location = new System.Drawing.Point(281, 79);
            this.key_dnmp.Name = "key_dnmp";
            this.key_dnmp.Size = new System.Drawing.Size(58, 20);
            this.key_dnmp.TabIndex = 12;
            // 
            // dl1
            // 
            this.dl1.Location = new System.Drawing.Point(124, 135);
            this.dl1.Name = "dl1";
            this.dl1.Size = new System.Drawing.Size(71, 20);
            this.dl1.TabIndex = 13;
            this.dl1.TextChanged += new System.EventHandler(this.dl1_TextChanged);
            this.dl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dl1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Slot1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "delay:";
            // 
            // key1
            // 
            this.key1.Location = new System.Drawing.Point(202, 135);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(62, 20);
            this.key1.TabIndex = 16;
            // 
            // key2
            // 
            this.key2.Location = new System.Drawing.Point(203, 161);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(62, 20);
            this.key2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "delay:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Slot2:";
            // 
            // dl2
            // 
            this.dl2.Location = new System.Drawing.Point(125, 161);
            this.dl2.Name = "dl2";
            this.dl2.Size = new System.Drawing.Size(71, 20);
            this.dl2.TabIndex = 17;
            this.dl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dl2_KeyPress);
            // 
            // key3
            // 
            this.key3.Location = new System.Drawing.Point(203, 187);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(62, 20);
            this.key3.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "delay:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Slot3:";
            // 
            // dl3
            // 
            this.dl3.Location = new System.Drawing.Point(125, 187);
            this.dl3.Name = "dl3";
            this.dl3.Size = new System.Drawing.Size(71, 20);
            this.dl3.TabIndex = 21;
            this.dl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dl3_KeyPress);
            // 
            // text_x
            // 
            this.text_x.Location = new System.Drawing.Point(75, 235);
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(73, 20);
            this.text_x.TabIndex = 25;
            this.text_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_x_KeyPress);
            // 
            // text_y
            // 
            this.text_y.Location = new System.Drawing.Point(170, 235);
            this.text_y.Name = "text_y";
            this.text_y.Size = new System.Drawing.Size(74, 20);
            this.text_y.TabIndex = 26;
            this.text_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_y_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Direction";
            // 
            // standonl
            // 
            this.standonl.AutoSize = true;
            this.standonl.Location = new System.Drawing.Point(259, 238);
            this.standonl.Name = "standonl";
            this.standonl.Size = new System.Drawing.Size(76, 17);
            this.standonl.TabIndex = 28;
            this.standonl.Text = "Stand only";
            this.standonl.UseVisualStyleBackColor = true;
            this.standonl.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // notx
            // 
            this.notx.AutoSize = true;
            this.notx.Location = new System.Drawing.Point(259, 266);
            this.notx.Name = "notx";
            this.notx.Size = new System.Drawing.Size(77, 17);
            this.notx.TabIndex = 29;
            this.notx.Text = "Not Attack";
            this.notx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 317);
            this.Controls.Add(this.notx);
            this.Controls.Add(this.standonl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dl3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dl2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dl1);
            this.Controls.Add(this.key_dnmp);
            this.Controls.Add(this.dnmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.key_dnhp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dnhp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mpl);
            this.Controls.Add(this.hpl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fuck_Dragonica - Coded by Codecrack3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hpl;
        private System.Windows.Forms.Label mpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dnhp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox key_dnhp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dnmp;
        private System.Windows.Forms.TextBox key_dnmp;
        private System.Windows.Forms.TextBox dl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.TextBox key2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dl2;
        private System.Windows.Forms.TextBox key3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dl3;
        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox standonl;
        private System.Windows.Forms.CheckBox notx;
    }
}

