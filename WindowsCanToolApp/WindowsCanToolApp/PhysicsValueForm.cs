using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCanToolApp
{
    public partial class PhysicsValueForm : Form
    {
        public PhysicsValueForm()
        {
            InitializeComponent();
        }

        private void PhysicsValueForm_Load(object sender, EventArgs e)
        {
         
  
        }

        private void PhysicsValueForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void SaveValue_Click(object sender, EventArgs e)
        {
            //读取当前信号的信号名
            string SignalName = Form1.SelectedChildNodeName;
            SignalName = SignalName.Remove(0, 3);
            //读取当前信号所属信息的ID
            string MessageIDStr = Form1.selectedParentNodeName;
            MessageIDStr = MessageIDStr.Remove(0, 3);
            int MessageIDInt = int.Parse(MessageIDStr);
            //第一步把用户输入的物理值转换为十进制
            string InputPhysicsValue = InputTextBox.Text.ToString().Trim();
            int PhysicsValueInt= int.Parse(InputPhysicsValue);
           
            
            //第二步读取当前信号的(A，B)的值
            LINQDataContext context = new LINQDataContext();
            var query = from sg in context.SendSignal
                        where sg.Signal_Name == SignalName && sg.ID==MessageIDInt
                        select sg;
            string ABValue=null;
            foreach (var item in query)
            {
                ABValue = item._A_B_;

            }
            int SplitIndexStart=ABValue.IndexOf(",");
            string AValueStr=ABValue.Substring(1,SplitIndexStart-1);
            int SplitIndexEnd = ABValue.IndexOf(")");
            string BValueStr = ABValue.Substring(SplitIndexStart + 1, SplitIndexEnd - SplitIndexStart - 1);
            int AValueInt = int.Parse(AValueStr);
            int BValueInt = int.Parse(BValueStr);

            //第三步计算信号值，并且转换为十六进制
            int SignalValue = (PhysicsValueInt - BValueInt) / AValueInt;
            String str = SignalValue.ToString("x8");
            MessageBox.Show(str);
            ////第四步存到数据库中

            var query1 = from sg in context.SendSignal
                        where sg.Signal_Name == SignalName && sg.ID == MessageIDInt
                        select sg;
            foreach (var item in query1)
            { 
                item.Signal_Value = str;

            }
            context.SubmitChanges();
            this.Close();
            
        }
    }
}
