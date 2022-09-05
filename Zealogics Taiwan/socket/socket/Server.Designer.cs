
namespace socket
{
    partial class Server
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
            this.Client_desktop = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.ServerIP_txtbox = new System.Windows.Forms.TextBox();
            this.label_wait_staus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerPort_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbx_FileName = new System.Windows.Forms.TextBox();
            this.txtbx_Path = new System.Windows.Forms.TextBox();
            this.lpl_Path_tiltie = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.Home_iconBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Client_desktop.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client_desktop
            // 
            this.Client_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Client_desktop.Controls.Add(this.panel6);
            this.Client_desktop.Controls.Add(this.panel5);
            this.Client_desktop.Controls.Add(this.panel4);
            this.Client_desktop.Controls.Add(this.panel3);
            this.Client_desktop.Controls.Add(this.panel2);
            this.Client_desktop.Controls.Add(this.panel1);
            this.Client_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client_desktop.Location = new System.Drawing.Point(0, 0);
            this.Client_desktop.Name = "Client_desktop";
            this.Client_desktop.Size = new System.Drawing.Size(1094, 501);
            this.Client_desktop.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.iconButton5);
            this.panel6.Controls.Add(this.Home_iconBtn);
            this.panel6.Location = new System.Drawing.Point(622, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 284);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.ServerIP_txtbox);
            this.panel5.Controls.Add(this.label_wait_staus);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.ServerPort_txtbox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(24, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(566, 252);
            this.panel5.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(33, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 31);
            this.label16.TabIndex = 5;
            this.label16.Text = "Setting";
            // 
            // ServerIP_txtbox
            // 
            this.ServerIP_txtbox.Location = new System.Drawing.Point(206, 110);
            this.ServerIP_txtbox.Name = "ServerIP_txtbox";
            this.ServerIP_txtbox.Size = new System.Drawing.Size(130, 22);
            this.ServerIP_txtbox.TabIndex = 2;
            this.ServerIP_txtbox.TextChanged += new System.EventHandler(this.ServerIP_txtbox_TextChanged);
            this.ServerIP_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerIP_txtbox_KeyPress);
            // 
            // label_wait_staus
            // 
            this.label_wait_staus.AutoSize = true;
            this.label_wait_staus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_wait_staus.Location = new System.Drawing.Point(474, 210);
            this.label_wait_staus.Name = "label_wait_staus";
            this.label_wait_staus.Size = new System.Drawing.Size(67, 24);
            this.label_wait_staus.TabIndex = 5;
            this.label_wait_staus.Text = "待機中";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ClientIP Set";
            // 
            // ServerPort_txtbox
            // 
            this.ServerPort_txtbox.Location = new System.Drawing.Point(206, 172);
            this.ServerPort_txtbox.Name = "ServerPort_txtbox";
            this.ServerPort_txtbox.Size = new System.Drawing.Size(130, 22);
            this.ServerPort_txtbox.TabIndex = 4;
            this.ServerPort_txtbox.TextChanged += new System.EventHandler(this.ServerPort_txtbox_TextChanged);
            this.ServerPort_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerPort_txtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ClientPort Set";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(184)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(828, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 130);
            this.panel4.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(65, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "None";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(15, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 26);
            this.label18.TabIndex = 2;
            this.label18.Text = "Request";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.txtbx_FileName);
            this.panel3.Controls.Add(this.txtbx_Path);
            this.panel3.Controls.Add(this.lpl_Path_tiltie);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(560, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 130);
            this.panel3.TabIndex = 8;
            // 
            // txtbx_FileName
            // 
            this.txtbx_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.txtbx_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_FileName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbx_FileName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbx_FileName.ForeColor = System.Drawing.Color.White;
            this.txtbx_FileName.Location = new System.Drawing.Point(74, 55);
            this.txtbx_FileName.Name = "txtbx_FileName";
            this.txtbx_FileName.ReadOnly = true;
            this.txtbx_FileName.Size = new System.Drawing.Size(100, 23);
            this.txtbx_FileName.TabIndex = 8;
            // 
            // txtbx_Path
            // 
            this.txtbx_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(244)))));
            this.txtbx_Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Path.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbx_Path.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbx_Path.ForeColor = System.Drawing.Color.White;
            this.txtbx_Path.Location = new System.Drawing.Point(65, 96);
            this.txtbx_Path.Name = "txtbx_Path";
            this.txtbx_Path.ReadOnly = true;
            this.txtbx_Path.Size = new System.Drawing.Size(100, 23);
            this.txtbx_Path.TabIndex = 7;
            // 
            // lpl_Path_tiltie
            // 
            this.lpl_Path_tiltie.AutoSize = true;
            this.lpl_Path_tiltie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lpl_Path_tiltie.ForeColor = System.Drawing.Color.White;
            this.lpl_Path_tiltie.Location = new System.Drawing.Point(16, 96);
            this.lpl_Path_tiltie.Name = "lpl_Path_tiltie";
            this.lpl_Path_tiltie.Size = new System.Drawing.Size(44, 20);
            this.lpl_Path_tiltie.TabIndex = 4;
            this.lpl_Path_tiltie.Text = "Path";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 26);
            this.label14.TabIndex = 2;
            this.label14.Text = "FileName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(88)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(292, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 130);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(147, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "false";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Connect Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "ServerPort ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 130);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Connect Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "ServerIP ";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Modx;
            this.iconButton5.IconColor = System.Drawing.Color.Maroon;
            this.iconButton5.IconSize = 70;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 218);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(449, 66);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.Tag = "Client";
            this.iconButton5.Text = "     Sendmsg";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // Home_iconBtn
            // 
            this.Home_iconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Home_iconBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_iconBtn.FlatAppearance.BorderSize = 0;
            this.Home_iconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_iconBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Home_iconBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Home_iconBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Home_iconBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.Home_iconBtn.IconColor = System.Drawing.Color.Brown;
            this.Home_iconBtn.IconSize = 70;
            this.Home_iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_iconBtn.Location = new System.Drawing.Point(0, 0);
            this.Home_iconBtn.Name = "Home_iconBtn";
            this.Home_iconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home_iconBtn.Rotation = 0D;
            this.Home_iconBtn.Size = new System.Drawing.Size(449, 66);
            this.Home_iconBtn.TabIndex = 5;
            this.Home_iconBtn.Tag = "Client";
            this.Home_iconBtn.Text = "     Choose File";
            this.Home_iconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_iconBtn.UseVisualStyleBackColor = false;
            this.Home_iconBtn.Click += new System.EventHandler(this.Home_iconBtn_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(19, 48);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(49, 36);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(19, 48);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(49, 36);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Strikethrough;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(19, 48);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(49, 36);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Signal;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(19, 48);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(49, 36);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 501);
            this.Controls.Add(this.Client_desktop);
            this.Name = "Server";
            this.Text = "Server";
            this.Client_desktop.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Client_desktop;
        private System.Windows.Forms.TextBox ServerIP_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerPort_txtbox;
        private System.Windows.Forms.Label label_wait_staus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lpl_Path_tiltie;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton Home_iconBtn;
        private System.Windows.Forms.TextBox txtbx_Path;
        private System.Windows.Forms.TextBox txtbx_FileName;
    }
}