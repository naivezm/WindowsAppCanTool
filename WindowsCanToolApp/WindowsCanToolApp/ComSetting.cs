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

namespace WindowsCanToolApp
{
    public partial class ComSetting : UserControl
    {
        public ComSetting()
        {
            InitializeComponent();
        }
        public void GetCOMList()
        {
            //RegistryKey是注册表中的顶级节点
            //LocalMachine读取windows注册表基项HKEY_LOCAL_MACHINE
            //OpenSubKey("Hardware\\DeviceMap\\SerialComm")只读方式读取Hardware\DeviceMap\SerialComm中的可用COM口
            RegistryKey keyCOM = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
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
    }
}
