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
using System.Runtime.InteropServices;
using System.IO;
using IniOperate;

namespace WindowsCanToolApp
{
    
    public partial class Form1 : Form
    {
        private string stopbits ;
      //  private string parity;
        public static string SelectedChildNodeName;
        public static string selectedParentNodeName;
        public static string FistLevelNodeName;
        public int A;
        public int B;
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
           // ComSetting cs = new ComSetting();
            //GetCOMList();
            this.MainPanel.Controls.Add(this.COMPanel);
            
        }

        private void GetCOMList() //遍历端口
        {
            //RegistryKey是注册表中的顶级节点
            //LocalMachine读取windows注册表基项HKEY_LOCAL_MACHINE
            //OpenSubKey("Hardware\\DeviceMap\\SerialComm")只读方式读取Hardware\DeviceMap\SerialComm中的可用COM口
            RegistryKey keyCOM = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCOM != null)
            {
                string[] sSubKeys = keyCOM.GetValueNames();
                this.COMComboBox.Items.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCOM.GetValue(sName);
                    this.COMComboBox.Items.Add(sValue);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            FileStream COM = new FileStream("COMSetting.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            COM.Close();
            GetCOMList();
            this.COMComboBox.SelectedIndex = 0;
            this.COMComboBox.Text = OperateIniFile.ReadIniData("PORT", "NAME", "COM1", ".\\COMSetting.ini"); //从ini文件中读取上一次保存的串口

            this.BaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            //this.BaudRateComboBox.SelectedIndex = 3; //波特率默认值9600
            this.BaudRateComboBox.Text = OperateIniFile.ReadIniData("BaudRate", "NAME", "9600", ".\\COMSetting.ini");
            //加入奇偶校验选择
            this.ParityComboBox.Items.Add("None");
            this.ParityComboBox.SelectedIndex = 0; //奇偶校验默认为None
            this.ParityComboBox.Text = OperateIniFile.ReadIniData("Parity", "NAME", "None", ".\\COMSetting.ini");

            //停止位选择
            this.StopBitsComboBox.Items.Add("1");
           // StopBitsComboBox.SelectedIndex =0;//停止位默认为1
            stopbits = StopBitsComboBox.Text;
            this.StopBitsComboBox.Text = OperateIniFile.ReadIniData("StopBits", "NAME", "1", ".\\COMSetting.ini");
            

            //数据位选择

            this.DataBitsComboBox.Items.Add("8");
            //this.DataBitsComboBox.SelectedIndex=0; //默认填入8
            this.DataBitsComboBox.Text = OperateIniFile.ReadIniData("DataBits", "NAME", "8", ".\\COMSetting.ini");
            try
            {
              
            }
            catch (Exception eee)
            {

                MessageBox.Show(eee.ToString());
            }
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "ID";
            col.ReadOnly = true;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Name";
            col1.ReadOnly = true;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "DLC";
            col2.ReadOnly = true;
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Data";
            col3.ReadOnly = true;
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Columns.Add(col3);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\1.jpg"));
            this.TreeView.ImageList = myImageList;
            TreeView.ImageIndex = 0;
            TreeView.SelectedImageIndex = 1;

            LINQDataContext context = new LINQDataContext();
            var query = from sm in context.SendMessage
                       select sm;
            PhysicsValueForm p = new PhysicsValueForm();
            foreach (var item in query)
            {

               // string MessageIDStr = item.ID.ToString("x8");
               // string all=item.ID.ToString();
               // //截取十六进制中的有效字段
               // //int NotZeroIndex = 0;  //第一个不为0的位置
               // //foreach (var itemStr in MessageIDStr)
               // //{
               // //    if (itemStr == '0') NotZeroIndex++;
               // //    else break;
               // //}
               // //MessageIDStr = MessageIDStr.Substring(NotZeroIndex, 8 - NotZeroIndex);
               // MessageIDStr = MessageIDStr.Substring(5, 3);
               // int index = dataGridView1.Rows.Add();
               // dataGridView1.Rows[index].Cells[0].Value = MessageIDStr;
               // dataGridView1.Rows[index].Cells[1].Value = item.Message_Name;
               // dataGridView1.Rows[index].Cells[2].Value = item.DLC.ToString();
               // var query1 = from sg in context.SendSignal
               //              where sg.ID == item.ID
               //              select sg;
               // foreach (var item1 in query1)
               // {

               //     p.ReadABFromDB(item1.Signal_Name, item1.ID);
               //     int signal_value = Convert.ToInt32(item1.Signal_Value, 16);
               //   //  MessageBox.Show(signal_value.ToString());
               //     double phy = (PhysicsValueForm.A*signal_value) -PhysicsValueForm.B;
               //    // MessageBox.Show(phy.ToString());
               //     all = all+' ' + phy;

               // }
               // all = p.canSend(all);
               //// MessageBox.Show(all);
               // all = all.Remove(0, 5);
               // int count = 1;
               // string All = "";
               // foreach (var s in all)
               // {
               //     count++;
               //     if (count % 2 == 0)
               //     {
               //         All += " ";
               //     }
               //     All += s;
               // }
               // dataGridView1.Rows[index].Cells[3].Value = All;

                TreeNode tn = TreeView.Nodes.Add(item.BO_.ToString().Trim() + item.ID.ToString().Trim());
                var query2 = from sg in context.SendSignal
                             where sg.ID == item.ID
                             select sg;
                foreach (var item2 in query2)
                {
                    TreeNode tn1 = new TreeNode(item2.SG_.ToString().Trim() + item2.Signal_Name.ToString().Trim());
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
                if (SerialPort.IsOpen)
                {
                    SerialPort.WriteLine(data);
                }
                else MessageBox.Show("端口未打开");
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
       
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as TreeView) != null)
            {
                TreeView.SelectedNode = TreeView.GetNodeAt(e.X, e.Y);
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
                    string MessageSendChar = "t";
                    //读取当前信息的ID
                    string MessageIDStr = TreeView.SelectedNode.Text.ToString();
                    MessageIDStr = MessageIDStr.Remove(0, 3);
                    int MessageIDInt = int.Parse(MessageIDStr);
                    //转换为十六进制
                    MessageIDStr = MessageIDInt.ToString("x8");
                    // MessageBox.Show(MessageIDStr);
                    //截取十六进制中的有效字段
                    string str = PhysicsValueForm.CutHex(MessageIDStr);
                    MessageSendChar += str;
                    LINQDataContext context = new LINQDataContext();
                    var query = from sm in context.SendMessage
                                where sm.ID == MessageIDInt
                                select sm;
                    int DLC = 0;
                    foreach (var item in query)
                    {
                        DLC = item.DLC;
                        MessageSendChar += "" + DLC.ToString();
                    }
                    //MessageBox.Show(MessageSendChar);
                    var query1 = from sg in context.SendSignal
                                 where sg.ID == MessageIDInt
                                 select sg;
                    string SignalValue = null;
                    int count = 0;
                    foreach (var item in query1)
                    {
                        SignalValue = item.Signal_Value;
                        SignalValue = SignalValue.Remove(0, 6);
                        MessageSendChar += SignalValue;
                        count++;


                    }
                    for (int i = 1; i <= DLC - count; i++)
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
            try
            {
                StreamWriter sw = new StreamWriter(".\\CANString.txt");
                sw.WriteLine(this.ReceiveTextBox.Text);
                sw.Flush();
                sw.Close();
                
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.ToString());
            }
            

        }


        private void cAN原始数据显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainPanel.Controls.Clear();
                this.dataGridView1.Rows.Clear();
                StreamReader sr = new StreamReader(".\\CANString.txt");
                string str;

                string ID, DLC;
                string DATA;
                while ((str = sr.ReadLine()) != null)
                {
                    int index = dataGridView1.Rows.Add();
                    //essageBox.Show(str);
                    ID = str.Substring(1, 3);
                    DLC = str.Substring(4, 1);
                    DATA = str.Substring(5, str.Length - 7);
                    // MessageIDStr = MessageIDInt.ToString("x8");
                    LINQDataContext context = new LINQDataContext();
                    var query = from sm in context.SendMessage
                                where sm.ID == System.Int32.Parse(ID, System.Globalization.NumberStyles.HexNumber)
                                select sm;
                    foreach (var item in query)
                    {
                        dataGridView1.Rows[index].Cells[1].Value = item.Message_Name;
                    }
                    int count = 1;
                    string All = "";
                    foreach (var s in DATA)
                    {
                        count++;
                        if (count % 2 == 0)
                        {
                            All += " ";
                        }
                        All += s;
                    }

                    dataGridView1.Rows[index].Cells[0].Value = ID;
                    dataGridView1.Rows[index].Cells[2].Value = DLC;
                    dataGridView1.Rows[index].Cells[3].Value = All;
                    sr.ReadLine();

                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("字符串位数不合法！！");
            }

                //LINQDataContext context = new LINQDataContext();
                //var query = from sm in context.SendMessage
                //            select sm;
                //PhysicsValueForm p = new PhysicsValueForm();
                //foreach (var item in query)
                //{

                //    string MessageIDStr = item.ID.ToString("x8");
                //    string all = item.ID.ToString();

                //    MessageIDStr = MessageIDStr.Substring(5, 3);
                //    int index = dataGridView1.Rows.Add();
                //    dataGridView1.Rows[index].Cells[0].Value = MessageIDStr;
                //    dataGridView1.Rows[index].Cells[1].Value = item.Message_Name;
                //    dataGridView1.Rows[index].Cells[2].Value = item.DLC.ToString();
                //    var query1 = from sg in context.SendSignal
                //                 where sg.ID == item.ID
                //                 select sg;
                //    foreach (var item1 in query1)
                //    {

                //        p.ReadABFromDB(item1.Signal_Name, item1.ID);
                //        int signal_value = Convert.ToInt32(item1.Signal_Value, 16);
                //        //  MessageBox.Show(signal_value.ToString());
                //        double phy = (PhysicsValueForm.A * signal_value) - PhysicsValueForm.B;
                //        // MessageBox.Show(phy.ToString());
                //        all = all + ' ' + phy;

                //    }
                //    all = p.canSend(all);
                //    // MessageBox.Show(all);
                //    all = all.Remove(0, 5);
                //    int count = 1;
                //    string All = "";
                //    foreach (var s in all)
                //    {
                //        count++;
                //        if (count % 2 == 0)
                //        {
                //            All += " ";
                //        }
                //        All += s;
                //    }
                //    dataGridView1.Rows[index].Cells[3].Value = All;

                //}


                this.MainPanel.Controls.Add(this.DataDisplayPanel);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {


            try
            {
                OperateIniFile.WriteIniData("PORT", "NAME", COMComboBox.Text, ".\\COMSetting.ini");
                OperateIniFile.WriteIniData("BaudRate", "NAME", BaudRateComboBox.Text, ".\\COMSetting.ini");
                OperateIniFile.WriteIniData("Parity", "NAME", ParityComboBox.Text, ".\\COMSetting.ini");
                OperateIniFile.WriteIniData("StopBits", "NAME", StopBitsComboBox.Text, ".\\COMSetting.ini");
                OperateIniFile.WriteIniData("DataBits", "NAME", DataBitsComboBox.Text, ".\\COMSetting.ini");
                SerialPort.PortName = COMComboBox.Text;                                                                       //选择串口
                SerialPort.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);
                SerialPort.Parity = Parity.None;
                SerialPort.StopBits = (System.IO.Ports.StopBits)int.Parse(StopBitsComboBox.Text);  //StopBits
                SerialPort.DataBits = Convert.ToInt32(DataBitsComboBox.Text);                                                    //DataBits
                SerialPort.Open();
                OpenButton.Enabled = false;
                CloseButton.Enabled = true;
                this.ConditionLabel.Text = this.COMComboBox.SelectedItem.ToString() + "     OPEND";
                SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                /// f.SerialPort.DataReceived += new SerialDataReceivedEventHandler(CommDataReceived); //串口监听
                SerialPort.ReceivedBytesThreshold = 1;//用来控制缓冲区的大小，接收足够的字符串后再接收处理，注意每次发送加的换行符占1字节而且算一次发送
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void COMPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
                ConditionLabel.Text = this.COMComboBox.SelectedItem.ToString() + "    Closed";
                OpenButton.Enabled = true;
                CloseButton.Enabled = false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetSendMessage(string s)
        {
            this.SendTextBox.Text=s;
        
        }
        private void TreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TreeView.SelectedNode.Level == 0)
            {
                FistLevelNodeName = TreeView.SelectedNode.Text.ToString();
                PhysicsValueForm physics_value = new PhysicsValueForm();
                physics_value.Text = TreeView.SelectedNode.Text.ToString();
                physics_value.ShowDialog();
                this.SendTextBox.AppendText(physics_value.sss+"\n");
                
            }
        }

        private void 基本设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

       

       
    }
}
    
 namespace IniOperate
    {
        public class OperateIniFile
        {
            #region API函数声明

            [DllImport("kernel32")]//返回0表示失败，非0为成功
            private static extern long WritePrivateProfileString(string section, string key,
                string val, string filePath);

            [DllImport("kernel32")]//返回取得字符串缓冲区的长度
            private static extern long GetPrivateProfileString(string section, string key,
                string def, StringBuilder retVal, int size, string filePath);


            #endregion

            #region 读Ini文件

            public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
            {
                if (File.Exists(iniFilePath))
                {
                    StringBuilder temp = new StringBuilder(1024);
                    GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                    return temp.ToString();
                }
                else
                {
                    return String.Empty;
                }
            }

            #endregion

            #region 写Ini文件

            public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
            {
                if (File.Exists(iniFilePath))
                {
                    long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                    if (OpStation == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }

            #endregion



        }
    }

