using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;
using WindowsCanToolApp.IniOperate;
using System.IO.Ports;


namespace WindowsCanToolApp
{
    public partial class ComSetting : UserControl
    {

        public ComSetting()
        {
            InitializeComponent();
        }
        private string parity=null;
        private string stopbits=null;
        Form1 f=new Form1();
        public void GetCOMList()
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

        private void ComSetting_Load(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //FileStream COM = new FileStream("COMSetting.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //COM.Close();
            //this.COMComboBox.SelectedIndex = 0;
            //this.COMComboBox.Text = OperateIniFile.ReadIniData("PORT", "NAME", "COM1", ".\\COMSetting.ini"); //从ini文件中读取上一次保存的串口

            //this.BaudRateComboBox.SelectedIndex = 3; //波特率默认值9600
            //this.BaudRateComboBox.Text = OperateIniFile.ReadIniData("BaudRate", "NAME", "9600", ".\\COMSetting.ini");

            ////加入奇偶校验选择
            //foreach (string str in Enum.GetNames(typeof(System.IO.Ports.Parity)))
            //{
            //    ParityComboBox.Items.Add(str);
            //}

            //ParityComboBox.SelectedIndex = 0;
            //parity = ParityComboBox.Text.ToString();

            ////停止位选择
            //foreach (string str in Enum.GetNames(typeof(System.IO.Ports.StopBits)))
            //{
            //    StopBitsComboBox.Items.Add(str);
            //}

            //StopBitsComboBox.SelectedIndex = 1;
            //stopbits = StopBitsComboBox.Text;

            ////数据位选择

            //this.DataBitsComboBox.Items.Add("8");
            //this.DataBitsComboBox.SelectedText = "8"; //默认填入8


        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenButton.Enabled = false;
            CloseButton.Enabled = true;

            try
            {
                OperateIniFile.WriteIniData("PORT", "NAME", COMComboBox.Text, ".\\COMSetting.ini");
                OperateIniFile.WriteIniData("BaudRate", "NAME", BaudRateComboBox.Text, ".\\COMSetting.ini");

                f.SerialPort.PortName = COMComboBox.Text;                                                                       //选择串口
                f.SerialPort.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);                                                  //Baud Rate
                f.SerialPort.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity);           //Parity
                f.SerialPort.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopbits);  //StopBits
                f.SerialPort.DataBits = Convert.ToInt32(DataBitsComboBox.Text);                                                  //Data bits                                                        //DataBits
                f.SerialPort.Open();
                f.SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                /// f.SerialPort.DataReceived += new SerialDataReceivedEventHandler(CommDataReceived); //串口监听
                f.SerialPort.ReceivedBytesThreshold = 1;//用来控制缓冲区的大小，接收足够的字符串后再接收处理，注意每次发送加的换行符占1字节而且算一次发送
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[f.SerialPort.BytesToRead];
            f.SerialPort.Read(ReDatas, 0, ReDatas.Length);//读取数据
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
                if (f.ReceiveTextBox.Text.Length > 0)//存在内容
                {
                    f.ReceiveTextBox.AppendText("\r\n");//换行
                }
                f.ReceiveTextBox.AppendText(content);
            }));
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
}
