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
            ComSetting cs = new ComSetting();
            this.Mainpanel.Controls.Add(cs.COMpanel);
            cs.GetCOMList();
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

       
        /// <summary>
        /// 
        /// </summary>
      

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
