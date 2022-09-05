using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using FontAwesome.Sharp;

namespace socket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private IconButton currentBtn;
        private Form currentChildForm;
              
        private void btmMenu_Click(object sender, EventArgs e)
        {
            CollapesMenau();
        }

        private void CollapesMenau()
        {
            if(this.panelMenu.Width>200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btmMenu.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btmMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 126, 127);
            public static Color color3 = Color.FromArgb(44, 207, 75);
        }
        private void ActivateButton(object senderbtn,Color color)
        {
            if(senderbtn!=null)
            {
                DisableButton();
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = Color.FromArgb(37,36,99);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(92, 102, 244);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            panel_logo.Visible = false;
            OpenChildFrom(new Client());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            panel_logo.Visible = false;
            OpenChildFrom(new Server());
            
        }

        private void OpenChildFrom(Form childFrom)
        {
            if(currentChildForm != null)
            {
                //open onlyy form
                currentChildForm.Close();
            }
            currentChildForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();


        }

        private void Home_iconBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            panel_logo.Visible = true;
        }
    }
}
