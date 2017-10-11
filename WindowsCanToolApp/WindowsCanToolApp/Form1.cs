using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsCanToolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cAN信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Mainpanel.Controls.Clear();
            
        }

        private void cOM口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Mainpanel.Controls.Clear();
            this.Mainpanel.Controls.Add(this.COMpanel);
            GetCOMList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sPort.PortName = "COM2";
            sPort.Open();
            sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);
            //将事件处理函数，挂接到事件DataReceived 中
           
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void GetCOMList()
        { 
            //RegistryKey是注册表中的顶级节点
            //LocalMachine读取windows注册表基项HKEY_LOCAL_MACHINE
            //OpenSubKey("Hardware\\DeviceMap\\SerialComm")只读方式读取Hardware\DeviceMap\SerialComm中的可用COM口
            RegistryKey keyCOM=Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCOM != null)
            {
                string[] sSubKeys = keyCOM.GetValueNames();
                this.COMcomboBox.Items.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCOM.GetValue(sName);
                    this.COMcomboBox.Items.Add(sValue);
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Mainpanel.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cAN信息发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Mainpanel.Controls.Clear();
            this.Mainpanel.Controls.Add(this.SendReceivepanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                //byte[] data = Encoding.Unicode.GetBytes(textBox1.Text);
                string data = SendTextBox.Text.ToString();
                // string str = Convert.ToBase64String(data);
                sPort.WriteLine(data);
                // sPort.Close();
                MessageBox.Show("数据发送成功！", "系统提示");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "提示信息");
            }
        }

        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[sPort.BytesToRead];
            sPort.Read(ReDatas, 0, ReDatas.Length);//读取数据
            this.AddData(ReDatas);//输出数据
        }
         /// <summary>
         /// 添加数据
         /// </summary>
         /// <param name="data">字节数组</param>
         public void AddData(byte[] data)
        {
            AddContent(new ASCIIEncoding().GetString(data));
            
         }

         /// <summary>
         /// 输入到显示区域
         /// </summary>
        /// <param name="content"></param>
         private void AddContent(string content)
         {
             this.BeginInvoke(new MethodInvoker(delegate//在创建控件的基础句柄所在线程上异步执行指定委托。
             {
                 if(ReceiveTextBox.Text.Length>0)//存在内容
                 {
                     ReceiveTextBox.AppendText("\r\n");//换行
                 }
                 ReceiveTextBox.AppendText(content);
             }));
         }
      
    }
    
}
