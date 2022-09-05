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
using System.Threading.Tasks;

namespace socket
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Thread _waiting_file;

        static String receivedPath = "";
        static String ServerIP = "";
        static String ServerPort = "";
        static String FileName = "";
        

        
        private void wait_file()
        {
            try
            {
                
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(ServerIP), Int32.Parse(ServerPort));
                Socket sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);
                sock.Listen(100);
              
                byte[] clientData = new byte[1024 * 1024];
                
                Socket clientSock = sock.Accept();               
                int receivedBytesLen = clientSock.Receive(clientData);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);

                FileName = fileName;
                BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath +"\\"+ Path.GetFileName(fileName),
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            /*/傳送指令與本身IP,告知要下載檔案
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(ServerIP_txtbox.Text);
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, Int32.Parse(ServerPort_txtbox.Text));
            //取得本地IP
            string localip = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = host.AddressList;
            foreach(var ipv4 in addr)
            {
                localip = ipv4.ToString();
            }
            if (localip.Length > 15)
                return;
            localip +=  ":" + ServerPort_txtbox.Text;
            byte[] byData = System.Text.Encoding.ASCII.GetBytes(localip);
            await socket_sendmsg(soc, byData, remoteEP);*/


            //接收檔案
            ServerIP = ServerIP_txtbox.Text;
            ServerPort = ServerPort_txtbox.Text;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    receivedPath = fbd.SelectedPath;
                    txtbx_FileName.Text = receivedPath;
                }
            }
            _waiting_file = new Thread(wait_file);
             _waiting_file.Start();
            txtbx_FileName.Text = FileName;
        }

        private void ServerIP_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ServerPort_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ServerIP_txtbox_TextChanged(object sender, EventArgs e)
        {
             label6.Text= ServerIP_txtbox.Text;
        }

        private void ServerPort_txtbox_TextChanged(object sender, EventArgs e)
        {
             label7.Text= ServerPort_txtbox.Text;
        }
    }
}
