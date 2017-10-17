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
            this.MainPanel.Controls.Clear();
            
        }

        private void cOM口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            ComSetting cs = new ComSetting();
<<<<<<< HEAD
            this.MainPanel.Controls.Add(cs.COMpanel);
=======
            this.MainPanel.Controls.Add(cs.COMPanel);
>>>>>>> f4d1569903088494afaf64ffef9933bd9aaa197f
            cs.GetCOMList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialPort.PortName = "COM2";
            SerialPort.Open();
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);
<<<<<<< HEAD
            LINQDataContext context = new LINQDataContext();
            var query = from sm in context.SendMessage
                        select sm ;
            foreach (var item in query)
            {
                SendTextBox.AppendText(item.BO_.ToString()); 
                SendTextBox.AppendText(item.ID.ToString());
                SendTextBox.AppendText(item.Message_Name.ToString());
                SendTextBox.AppendText(item.Separator.ToString());
                SendTextBox.AppendText(item.DLC.ToString());
                SendTextBox.AppendText(item.Node_Name.ToString());
                SendTextBox.AppendText("\r\n");
               
            }
=======
            //将事件处理函数，挂接到事件DataReceived 中
>>>>>>> f4d1569903088494afaf64ffef9933bd9aaa197f
           
        }

       
        /// <summary>
        /// 
        /// </summary>
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cAN信息发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
<<<<<<< HEAD
            this.MainPanel.Controls.Add(this.SendReceivepanel);
=======
            this.MainPanel.Controls.Add(this.SendReceivePanel);
>>>>>>> f4d1569903088494afaf64ffef9933bd9aaa197f
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                //将事件处理函数，挂接到事件DataReceived 中
                //byte[] data = Encoding.Unicode.GetBytes(textBox1.Text);
                string data = SendTextBox.Text.ToString();
                // string str = Convert.ToBase64String(data);
                SerialPort.WriteLine(data);
                // sPort.Close();
              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "提示信息");
            }
        }

        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[SerialPort.BytesToRead];
            SerialPort.Read(ReDatas, 0, ReDatas.Length);//读取数据
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

<<<<<<< HEAD
         private void SendTextBox_TextChanged(object sender, EventArgs e)
         {
            

         }
      
=======
        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> f4d1569903088494afaf64ffef9933bd9aaa197f
    }
    
}
