
namespace socket
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Home_iconBtn = new FontAwesome.Sharp.IconButton();
            this.Server_iconbtn = new FontAwesome.Sharp.IconButton();
            this.Client_iconbtn = new FontAwesome.Sharp.IconButton();
            this.btmMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbx_FileName = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.Home_iconBtn);
            this.panelMenu.Controls.Add(this.Server_iconbtn);
            this.panelMenu.Controls.Add(this.Client_iconbtn);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 561);
            this.panelMenu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmMenu);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 60);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socket Unit Test";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.panel_logo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1124, 501);
            this.panelDesktop.TabIndex = 4;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panel_logo.Controls.Add(this.pictureBox2);
            this.panel_logo.Controls.Add(this.txtbx_FileName);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_logo.Location = new System.Drawing.Point(0, 401);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(1124, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::socket.Properties.Resources.Github;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Home_iconBtn
            // 
            this.Home_iconBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Home_iconBtn.FlatAppearance.BorderSize = 0;
            this.Home_iconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_iconBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Home_iconBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Home_iconBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Home_iconBtn.IconChar = FontAwesome.Sharp.IconChar.Houzz;
            this.Home_iconBtn.IconColor = System.Drawing.Color.White;
            this.Home_iconBtn.IconSize = 70;
            this.Home_iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_iconBtn.Location = new System.Drawing.Point(0, 495);
            this.Home_iconBtn.Name = "Home_iconBtn";
            this.Home_iconBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home_iconBtn.Rotation = 0D;
            this.Home_iconBtn.Size = new System.Drawing.Size(230, 66);
            this.Home_iconBtn.TabIndex = 4;
            this.Home_iconBtn.Tag = "Client";
            this.Home_iconBtn.Text = "     Home";
            this.Home_iconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_iconBtn.UseVisualStyleBackColor = true;
            this.Home_iconBtn.Click += new System.EventHandler(this.Home_iconBtn_Click);
            // 
            // Server_iconbtn
            // 
            this.Server_iconbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Server_iconbtn.FlatAppearance.BorderSize = 0;
            this.Server_iconbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Server_iconbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Server_iconbtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Server_iconbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Server_iconbtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Server_iconbtn.IconColor = System.Drawing.Color.White;
            this.Server_iconbtn.IconSize = 70;
            this.Server_iconbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Server_iconbtn.Location = new System.Drawing.Point(0, 166);
            this.Server_iconbtn.Name = "Server_iconbtn";
            this.Server_iconbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Server_iconbtn.Rotation = 0D;
            this.Server_iconbtn.Size = new System.Drawing.Size(230, 66);
            this.Server_iconbtn.TabIndex = 3;
            this.Server_iconbtn.Tag = "Server";
            this.Server_iconbtn.Text = "     Server";
            this.Server_iconbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Server_iconbtn.UseVisualStyleBackColor = true;
            this.Server_iconbtn.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Client_iconbtn
            // 
            this.Client_iconbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Client_iconbtn.FlatAppearance.BorderSize = 0;
            this.Client_iconbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_iconbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Client_iconbtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Client_iconbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Client_iconbtn.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.Client_iconbtn.IconColor = System.Drawing.Color.White;
            this.Client_iconbtn.IconSize = 70;
            this.Client_iconbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Client_iconbtn.Location = new System.Drawing.Point(0, 100);
            this.Client_iconbtn.Name = "Client_iconbtn";
            this.Client_iconbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Client_iconbtn.Rotation = 0D;
            this.Client_iconbtn.Size = new System.Drawing.Size(230, 66);
            this.Client_iconbtn.TabIndex = 2;
            this.Client_iconbtn.Tag = "Client";
            this.Client_iconbtn.Text = "     Client";
            this.Client_iconbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Client_iconbtn.UseVisualStyleBackColor = true;
            this.Client_iconbtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btmMenu
            // 
            this.btmMenu.FlatAppearance.BorderSize = 0;
            this.btmMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btmMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btmMenu.IconColor = System.Drawing.Color.White;
            this.btmMenu.IconSize = 30;
            this.btmMenu.Location = new System.Drawing.Point(160, 12);
            this.btmMenu.Name = "btmMenu";
            this.btmMenu.Rotation = 0D;
            this.btmMenu.Size = new System.Drawing.Size(70, 70);
            this.btmMenu.TabIndex = 2;
            this.btmMenu.UseVisualStyleBackColor = true;
            this.btmMenu.Click += new System.EventHandler(this.btmMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::socket.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtbx_FileName
            // 
            this.txtbx_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.txtbx_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_FileName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbx_FileName.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbx_FileName.ForeColor = System.Drawing.Color.White;
            this.txtbx_FileName.Location = new System.Drawing.Point(615, 34);
            this.txtbx_FileName.Name = "txtbx_FileName";
            this.txtbx_FileName.ReadOnly = true;
            this.txtbx_FileName.Size = new System.Drawing.Size(509, 39);
            this.txtbx_FileName.TabIndex = 9;
            this.txtbx_FileName.Text = "https://github.com/jeson51612";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Socket_Form_Test";
            this.TopMost = true;
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btmMenu;
        private FontAwesome.Sharp.IconButton Client_iconbtn;
        private FontAwesome.Sharp.IconButton Server_iconbtn;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Home_iconBtn;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbx_FileName;
    }
}

