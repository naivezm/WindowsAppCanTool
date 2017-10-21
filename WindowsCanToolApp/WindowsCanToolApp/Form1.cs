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
        public static string SelectedChildNodeName;
        public static string selectedParentNodeName;
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

            this.MainPanel.Controls.Add(cs.COMPanel);
            cs.GetCOMList();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
           
            try
            {
                
                SerialPort.PortName = "COM3";
                SerialPort.BaudRate = 9600;
                SerialPort.Parity=Parity.None;
                SerialPort.StopBits=StopBits.One;
                SerialPort.DataBits = 8;
                SerialPort.Handshake = Handshake.None;
                
                SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                //将事件处理函数，挂接到事件DataReceived 中
                SerialPort.Open();
            }
            catch (Exception eee)
            {

                MessageBox.Show(eee.ToString());
            }
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "ID";
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Name";
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "DLC";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Data";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Columns.Add(col3);
            //DataGridViewRow dr = new DataGridViewRow();
            //dataGridView1.Rows.Add(dr);
            //dr.Cells[0].Value = "aa";
           // int index = dataGridView1.Rows.Add();
           // dataGridView1.Rows[index].Cells[0].Value = "aaa";
            //try
            //{
            //    DataGridViewRow dr = new DataGridViewRow();
            //    dataGridView1.Rows.Add(dr);
            //    dr.Cells[0].Value = "a";
            //}
            //catch (Exception eee)
            //{

            //    MessageBox.Show(eee.ToString());
            //}
            
           
            LINQDataContext context = new LINQDataContext();
            var query = from sm in context.SendMessage
                        select sm;

            foreach (var item in query)
            {

                SendTextBox.AppendText(item.BO_.ToString());
                SendTextBox.AppendText(item.ID.ToString());
                SendTextBox.AppendText(item.Message_Name.ToString());
                SendTextBox.AppendText(item.Separator.ToString());
                SendTextBox.AppendText(item.DLC.ToString());
                SendTextBox.AppendText(item.Node_Name.ToString());
                SendTextBox.AppendText("\r\n");


                string MessageIDStr = item.ID.ToString("x8");
                //截取十六进制中的有效字段
                int NotZeroIndex = 0;  //第一个不为0的位置
                foreach (var itemStr in MessageIDStr)
                {
                    if (itemStr == '0') NotZeroIndex++;
                    else break;
                }
                MessageIDStr = MessageIDStr.Substring(NotZeroIndex, 8 - NotZeroIndex);
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value =MessageIDStr;
                dataGridView1.Rows[index].Cells[1].Value = item.Message_Name;
                dataGridView1.Rows[index].Cells[2].Value = item.DLC.ToString();


                TreeNode tn = TreeView.Nodes.Add(item.BO_.ToString().Trim() + item.ID.ToString().Trim());
                var query1 = from sg in context.SendSignal
                             where sg.ID == item.ID
                             select sg;
                foreach (var item1 in query1)
                {
                    TreeNode tn1 = new TreeNode(item1.SG_.ToString().Trim() + item1.Signal_Name.ToString().Trim());
                    tn.Nodes.Add(tn1);
                }
            }

        }
         private void cAN信息发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(this.SendReceivePanel);

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
           // this.SendTextBox.Clear();
            try
            {


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

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                if (ReceiveTextBox.Text.Length > 0)//存在内容
                {
                    ReceiveTextBox.AppendText("\r\n");//换行
                }
                ReceiveTextBox.AppendText(content);
            }));
        }

        private void TreeView_MouseUp(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    MessageBox.Show(TreeView.SelectedNode.Text.ToString());
            //}
            //catch (Exception ee)
            //{

            //    MessageBox.Show(ee.ToString());
            //}
            

        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            //try
            //{
            //    MessageBox.Show(TreeView.SelectedNode.Text.ToString());
            //    if (TreeView.SelectedNode.Parent.Level == 0)
            //    {
            //        PhysicsValueForm physics_value = new PhysicsValueForm();
            //        physics_value.ShowDialog();
      

            //    }
                
            //}
            //catch (Exception ee)
            //{

            //    //MessageBox.Show(ee.ToString());
            //}
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as TreeView) != null)
            {
                TreeView.SelectedNode = TreeView.GetNodeAt(e.X, e.Y);
            }
         
            try
            {
                 if (TreeView.SelectedNode.Parent.Level == 0)
                 {
                     SelectedChildNodeName = TreeView.SelectedNode.Text.ToString();
                     selectedParentNodeName = TreeView.SelectedNode.Parent.Text.ToString();
                     //MessageBox.Show(SelectNodeName);
                     PhysicsValueForm physics_value = new PhysicsValueForm();
                     physics_value.Text = TreeView.SelectedNode.Text.ToString();
                    
                     physics_value.ShowDialog();


                 }
                 
                
            }
            catch (Exception )
            {

                ;
            }
           

        }

        private void cAN信号仪表盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void cAN信号曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curve c = new Curve();
            c.ShowDialog();
        }

        private void cAN信息显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
        }

        private void SelectMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TreeView.SelectedNode.Level == 0)
                {
                    string MessageSendChar = "T";
                    //读取当前信息的ID
                    string MessageIDStr = TreeView.SelectedNode.Text.ToString();
                    MessageIDStr = MessageIDStr.Remove(0, 3);
                    int MessageIDInt = int.Parse(MessageIDStr);
                    //转换为十六进制
                    MessageIDStr = MessageIDInt.ToString("x8");
                    //截取十六进制中的有效字段
                    int NotZeroIndex = 0;  //第一个不为0的位置
                    foreach (var item in MessageIDStr)
                    {
                        if (item == '0') NotZeroIndex++;
                        else break;
                    }
                    MessageIDStr = MessageIDStr.Substring(NotZeroIndex, 8 - NotZeroIndex);
                    MessageSendChar += MessageIDStr;
                    LINQDataContext context = new LINQDataContext();
                    var query = from sm in context.SendMessage
                                where sm.ID == MessageIDInt
                                select sm;
                    int DLC=0;
                    foreach (var item in query)
                    {
                        DLC = item.DLC;
                        MessageSendChar += DLC.ToString();
                    }
                    //MessageBox.Show(MessageSendChar);
                    var query1 = from sg in context.SendSignal
                                 where sg.ID == MessageIDInt
                                 select sg;
                    string SignalValue = null;
                    int count=0;
                    foreach (var item in query1)
                    {
                        SignalValue = item.Signal_Value;
                        SignalValue = SignalValue.Remove(0, 6);
                        MessageSendChar += SignalValue;
                        count++;

                    }
                    for (int i = 1; i <=DLC - count; i++)
                    {
                        MessageSendChar += "00";
                    
                    }
                        //MessageBox.Show(MessageSendChar);
                        this.SendTextBox.AppendText(MessageSendChar);
                    this.SendTextBox.AppendText("\r\n");

                }
                else
                {
                    MessageBox.Show("请选中需要发送的信息！");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请选中需要发送的信息！");
            }
           
        }

        private void ReceiveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cAN原始数据显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(this.dataGridView1); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        
        }

       

       

       
    }
}
    

