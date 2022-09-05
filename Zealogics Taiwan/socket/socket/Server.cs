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
using System.Threading.Tasks;
using FontAwesome.Sharp;

namespace socket
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        //資料
        Thread _waiting_file;
        static byte[] clientData;
        static string FileName = "";
        static String receivedPath = "";
        static String ClientIP = "";
        static String ClientPort = "";


        public static async Task socket_sendmsg(Socket clientSock, byte[] clientData, IPEndPoint ipEnd)
        {
            await Task.Run(() => 
            {
                try
                {                    
                    clientSock.Connect(ipEnd);
                    clientSock.Send(clientData);
                    clientSock.Close();
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File Sending fail." + ex.Message);
                }
            }
            );
        }

        private void ServerIP_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar  > 47 && e.KeyChar  < 58) || e.KeyChar == 8  || e.KeyChar  == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ServerPort_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private async void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {

                //設定IP,port
                Console.WriteLine("That program can transfer small file.File limit 850kb ");
                IPAddress[] ipAddress = Dns.GetHostAddresses(ServerIP_txtbox.Text);
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], Int32.Parse(ServerPort_txtbox.Text));

                //設定IP,port
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                //設定欲要傳送的檔案路徑

                if (clientData == null)
                {
                    string currentpath = Directory.GetCurrentDirectory();
                    FileName = "";
                    //開啟預設檔案位置
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Title = "Select file";
                    dialog.InitialDirectory = currentpath;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = dialog.FileName;
                        txtbx_FileName.Text = Path.GetFileName(dialog.FileName);
                        txtbx_Path.Text = dialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("尚未選擇檔案");
                        return;
                    }
                }


                byte[] fileNameByte = Encoding.ASCII.GetBytes(FileName);
                byte[] fileData = File.ReadAllBytes(FileName);
                clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                label_wait_staus.Text = "傳送中";
                label5.Text = "True"; label8.Text = "True";
                await socket_sendmsg(clientSock, clientData, ipEnd);
                label_wait_staus.Text = "傳送完成";
                label5.Text = "False"; label8.Text = "False";
                clientData = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("尚未輸入IP或其他錯誤,Or " + ex.Message);
            }
        }

        private void Home_iconBtn_Click(object sender, EventArgs e)
        {
            string currentpath = Directory.GetCurrentDirectory();
            FileName = "";
            //開啟預設檔案位置
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = currentpath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileName = dialog.FileName;
                txtbx_FileName.Text= Path.GetFileName(dialog.FileName);
                txtbx_Path.Text= dialog.FileName;
            }
            else
            {
                MessageBox.Show("尚未選擇檔案");
                return;
            }
            byte[] fileNameByte = Encoding.ASCII.GetBytes(FileName);
            byte[] fileData = File.ReadAllBytes(FileName);
            clientData = new byte[4 + fileNameByte.Length + fileData.Length];
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

            fileNameLen.CopyTo(clientData, 0);
            fileNameByte.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fileNameByte.Length);
        }

        private void ServerIP_txtbox_TextChanged(object sender, EventArgs e)
        {
            label6.Text = ServerIP_txtbox.Text;
        }

        private void ServerPort_txtbox_TextChanged(object sender, EventArgs e)
        {
            label7.Text = ServerPort_txtbox.Text;
        }

        private void wait_file()
        {
            try
            {

                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(ClientIP), Int32.Parse(ClientPort));
                Socket sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);
                sock.Listen(100);

                byte[] clientData = new byte[5000 * 5000];

                Socket clientSock = sock.Accept();
                int receivedBytesLen = clientSock.Receive(clientData);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);

                FileName = fileName;
                BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "\\" + Path.GetFileName(fileName),
                FileMode.Append));
                bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 -
                fileNameLen);

                bWrite.Close();
                clientSock.Close();
                sock.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("尚未輸入IP或其他錯誤,Or " + ex.Message);
            }

            _waiting_file.Abort();
        }
    }
}
