namespace DPM.MINI.PW_AutoRegister
{
    partial class MainForm
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info_panel = new System.Windows.Forms.Panel();
            this.cookie_ro_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_ro_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.node_time_min_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.node_time_hour_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.node_add_button = new System.Windows.Forms.Button();
            this.node_count_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.node_id_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tasks_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.login_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.login_panel.Controls.Add(this.login_button);
            this.login_panel.Controls.Add(this.password_box);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.username_box);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_panel.Location = new System.Drawing.Point(0, 0);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(644, 31);
            this.login_panel.TabIndex = 0;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(505, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(127, 23);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(326, 6);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '●';
            this.password_box.Size = new System.Drawing.Size(145, 20);
            this.password_box.TabIndex = 2;
            this.password_box.Text = "GkXp@%G9M^gLTRrDMt4ayqGxX9D*aU%6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(123, 6);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(145, 20);
            this.username_box.TabIndex = 0;
            this.username_box.Text = "Zaczero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.info_panel.Controls.Add(this.cookie_ro_box);
            this.info_panel.Controls.Add(this.label3);
            this.info_panel.Controls.Add(this.username_ro_box);
            this.info_panel.Controls.Add(this.label4);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(0, 31);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(644, 31);
            this.info_panel.TabIndex = 1;
            this.info_panel.Visible = false;
            // 
            // cookie_ro_box
            // 
            this.cookie_ro_box.Location = new System.Drawing.Point(327, 6);
            this.cookie_ro_box.Name = "cookie_ro_box";
            this.cookie_ro_box.ReadOnly = true;
            this.cookie_ro_box.Size = new System.Drawing.Size(305, 20);
            this.cookie_ro_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Session:";
            // 
            // username_ro_box
            // 
            this.username_ro_box.Location = new System.Drawing.Point(123, 6);
            this.username_ro_box.Name = "username_ro_box";
            this.username_ro_box.ReadOnly = true;
            this.username_ro_box.Size = new System.Drawing.Size(145, 20);
            this.username_ro_box.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nazwa użytkownika:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.node_time_min_box);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.node_time_hour_box);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.node_add_button);
            this.panel1.Controls.Add(this.node_count_box);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.node_id_box);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 31);
            this.panel1.TabIndex = 2;
            // 
            // node_time_min_box
            // 
            this.node_time_min_box.Location = new System.Drawing.Point(458, 6);
            this.node_time_min_box.MaxLength = 2;
            this.node_time_min_box.Name = "node_time_min_box";
            this.node_time_min_box.Size = new System.Drawing.Size(30, 20);
            this.node_time_min_box.TabIndex = 9;
            this.node_time_min_box.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Minuta rejestracji:";
            // 
            // node_time_hour_box
            // 
            this.node_time_hour_box.Location = new System.Drawing.Point(327, 6);
            this.node_time_hour_box.MaxLength = 2;
            this.node_time_hour_box.Name = "node_time_hour_box";
            this.node_time_hour_box.Size = new System.Drawing.Size(30, 20);
            this.node_time_hour_box.TabIndex = 7;
            this.node_time_hour_box.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Godzina rejestracji:";
            // 
            // node_add_button
            // 
            this.node_add_button.Location = new System.Drawing.Point(505, 4);
            this.node_add_button.Name = "node_add_button";
            this.node_add_button.Size = new System.Drawing.Size(127, 23);
            this.node_add_button.TabIndex = 4;
            this.node_add_button.Text = "Dodaj";
            this.node_add_button.UseVisualStyleBackColor = true;
            this.node_add_button.Click += new System.EventHandler(this.node_add_button_Click);
            // 
            // node_count_box
            // 
            this.node_count_box.Location = new System.Drawing.Point(193, 6);
            this.node_count_box.MaxLength = 3;
            this.node_count_box.Name = "node_count_box";
            this.node_count_box.Size = new System.Drawing.Size(30, 20);
            this.node_count_box.TabIndex = 3;
            this.node_count_box.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ilość miejsc:";
            // 
            // node_id_box
            // 
            this.node_id_box.Location = new System.Drawing.Point(87, 6);
            this.node_id_box.MaxLength = 3;
            this.node_id_box.Name = "node_id_box";
            this.node_id_box.Size = new System.Drawing.Size(30, 20);
            this.node_id_box.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numer zajęć:";
            // 
            // tasks_panel
            // 
            this.tasks_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasks_panel.Location = new System.Drawing.Point(0, 62);
            this.tasks_panel.Name = "tasks_panel";
            this.tasks_panel.Size = new System.Drawing.Size(644, 248);
            this.tasks_panel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.tasks_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.login_panel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DPM.MINI.PW AutoRegister";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TextBox cookie_ro_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_ro_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox node_id_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox node_count_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button node_add_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox node_time_min_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox node_time_hour_box;
        private System.Windows.Forms.FlowLayoutPanel tasks_panel;
    }
}

