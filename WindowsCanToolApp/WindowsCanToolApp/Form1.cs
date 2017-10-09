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
            this.Mainpanel.Controls.Add(this.COMpanel);
            GetCOMList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                this.comboBox1.Items.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)keyCOM.GetValue(sName);
                    this.comboBox1.Items.Add(sValue);
                }
            }
        
        }
    }
}
