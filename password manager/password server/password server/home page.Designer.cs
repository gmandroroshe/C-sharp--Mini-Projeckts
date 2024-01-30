namespace password_server
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNlogout = new System.Windows.Forms.Button();
            this.password_id = new System.Windows.Forms.Label();
            this.password_name = new System.Windows.Forms.Label();
            this.update_date = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_Pid = new System.Windows.Forms.TextBox();
            this.txt_Pname = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(56, 120);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(136, 44);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(56, 200);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 44);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(56, 279);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(136, 44);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.BTNlogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(515, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 558);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 70);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password Manager";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(56, 367);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 44);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(78, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BTNlogout
            // 
            this.BTNlogout.BackColor = System.Drawing.Color.White;
            this.BTNlogout.Location = new System.Drawing.Point(155, 507);
            this.BTNlogout.Name = "BTNlogout";
            this.BTNlogout.Size = new System.Drawing.Size(75, 35);
            this.BTNlogout.TabIndex = 13;
            this.BTNlogout.Text = "Log out";
            this.BTNlogout.UseVisualStyleBackColor = false;
            this.BTNlogout.Click += new System.EventHandler(this.BTNlogout_Click);
            this.BTNlogout.MouseLeave += new System.EventHandler(this.BTNlogout_MouseLeave);
            this.BTNlogout.MouseHover += new System.EventHandler(this.BTNlogout_MouseHover);
            // 
            // password_id
            // 
            this.password_id.AutoSize = true;
            this.password_id.BackColor = System.Drawing.Color.Transparent;
            this.password_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_id.ForeColor = System.Drawing.Color.White;
            this.password_id.Location = new System.Drawing.Point(21, 107);
            this.password_id.Name = "password_id";
            this.password_id.Size = new System.Drawing.Size(149, 28);
            this.password_id.TabIndex = 12;
            this.password_id.Text = "PASSWORD ID";
            // 
            // password_name
            // 
            this.password_name.AutoSize = true;
            this.password_name.BackColor = System.Drawing.Color.Transparent;
            this.password_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_name.ForeColor = System.Drawing.Color.White;
            this.password_name.Location = new System.Drawing.Point(21, 166);
            this.password_name.Name = "password_name";
            this.password_name.Size = new System.Drawing.Size(188, 28);
            this.password_name.TabIndex = 13;
            this.password_name.Text = "PASSWORD NAME";
            // 
            // update_date
            // 
            this.update_date.AutoSize = true;
            this.update_date.BackColor = System.Drawing.Color.Transparent;
            this.update_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_date.ForeColor = System.Drawing.Color.White;
            this.update_date.Location = new System.Drawing.Point(21, 224);
            this.update_date.Name = "update_date";
            this.update_date.Size = new System.Drawing.Size(146, 28);
            this.update_date.TabIndex = 14;
            this.update_date.Text = "UPDATE DATE";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(21, 278);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 28);
            this.password.TabIndex = 15;
            this.password.Text = "PASSWORD";
            // 
            // txt_Pid
            // 
            this.txt_Pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pid.Location = new System.Drawing.Point(240, 107);
            this.txt_Pid.Multiline = true;
            this.txt_Pid.Name = "txt_Pid";
            this.txt_Pid.Size = new System.Drawing.Size(238, 28);
            this.txt_Pid.TabIndex = 16;
            // 
            // txt_Pname
            // 
            this.txt_Pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pname.Location = new System.Drawing.Point(240, 166);
            this.txt_Pname.Multiline = true;
            this.txt_Pname.Name = "txt_Pname";
            this.txt_Pname.Size = new System.Drawing.Size(238, 28);
            this.txt_Pname.TabIndex = 17;
            // 
            // txt_p
            // 
            this.txt_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p.Location = new System.Drawing.Point(240, 278);
            this.txt_p.Multiline = true;
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(238, 28);
            this.txt_p.TabIndex = 18;
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(240, 229);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(238, 23);
            this.date.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 184);
            this.dataGridView1.TabIndex = 20;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.txt_Pname);
            this.Controls.Add(this.txt_Pid);
            this.Controls.Add(this.password);
            this.Controls.Add(this.password_name);
            this.Controls.Add(this.update_date);
            this.Controls.Add(this.password_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_page";
            this.Text = "home_page";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button BTNlogout;
        private System.Windows.Forms.Label password_id;
        private System.Windows.Forms.Label password_name;
        private System.Windows.Forms.Label update_date;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_Pid;
        private System.Windows.Forms.TextBox txt_Pname;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}