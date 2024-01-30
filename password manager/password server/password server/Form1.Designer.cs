namespace password_server
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtuser = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.check_show_pass = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.BTNlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 600);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Account ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // Txtuser
            // 
            this.Txtuser.BackColor = System.Drawing.Color.White;
            this.Txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtuser.Location = new System.Drawing.Point(353, 247);
            this.Txtuser.Multiline = true;
            this.Txtuser.Name = "Txtuser";
            this.Txtuser.Size = new System.Drawing.Size(389, 45);
            this.Txtuser.TabIndex = 3;
            // 
            // Txtpassword
            // 
            this.Txtpassword.BackColor = System.Drawing.Color.White;
            this.Txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpassword.Location = new System.Drawing.Point(353, 379);
            this.Txtpassword.Multiline = true;
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '*';
            this.Txtpassword.Size = new System.Drawing.Size(389, 45);
            this.Txtpassword.TabIndex = 4;
            // 
            // check_show_pass
            // 
            this.check_show_pass.AutoSize = true;
            this.check_show_pass.BackColor = System.Drawing.Color.Transparent;
            this.check_show_pass.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_show_pass.Location = new System.Drawing.Point(613, 430);
            this.check_show_pass.Name = "check_show_pass";
            this.check_show_pass.Size = new System.Drawing.Size(123, 20);
            this.check_show_pass.TabIndex = 5;
            this.check_show_pass.Text = "Show Password";
            this.check_show_pass.UseVisualStyleBackColor = false;
            this.check_show_pass.CheckedChanged += new System.EventHandler(this.check_show_pass_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(353, 498);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(136, 44);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNlogout
            // 
            this.BTNlogout.BackColor = System.Drawing.Color.White;
            this.BTNlogout.Location = new System.Drawing.Point(688, 12);
            this.BTNlogout.Name = "BTNlogout";
            this.BTNlogout.Size = new System.Drawing.Size(75, 35);
            this.BTNlogout.TabIndex = 0;
            this.BTNlogout.Text = "Log out";
            this.BTNlogout.UseVisualStyleBackColor = false;
            this.BTNlogout.Click += new System.EventHandler(this.BTNlogout_Click);
            this.BTNlogout.MouseLeave += new System.EventHandler(this.BTNlogout_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 600);
            this.Controls.Add(this.BTNlogout);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.check_show_pass);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtuser;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.CheckBox check_show_pass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button BTNlogout;
    }
}

