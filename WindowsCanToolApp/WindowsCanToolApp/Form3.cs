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
    public partial class Form3 : Form
    {
        string SelectedChildNodeName;
        string selectedParentNodeName;
        public Form3()
        {
            InitializeComponent();
        }

        private void TreeView3_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as TreeView) != null)
            {
                TreeView3.SelectedNode = TreeView3.GetNodeAt(e.X, e.Y);
            }

            try
            {
                if (TreeView3.SelectedNode.Parent.Level == 0)
                {
                    SelectedChildNodeName = TreeView3.SelectedNode.Text.ToString();
                    selectedParentNodeName = TreeView3.SelectedNode.Parent.Text.ToString();
                    //读取当前信号的信号名
                    string SignalName =SelectedChildNodeName;
                    SignalName = SignalName.Remove(0, 3);
                    //读取当前信号所属信息的ID
                    string MessageIDStr = selectedParentNodeName;
                    MessageIDStr = MessageIDStr.Remove(0, 3);
                    int MessageIDInt = int.Parse(MessageIDStr);
                    //遍历数据库，取A，B，和信号值
                    LINQDataContext context = new LINQDataContext();
                    var query = from sg in context.SendSignal
                                where sg.Signal_Name == SignalName && sg.ID == MessageIDInt
                                select sg;
                    string ABValue=null;
                    string SignalValue=null;
                    foreach (var item in query)
                    {
                         ABValue = item._A_B_;
                         SignalValue = item.Signal_Value;

                    }
                    int SplitIndexStart = ABValue.IndexOf(",");
                    string AValueStr = ABValue.Substring(1, SplitIndexStart - 1);
                    int SplitIndexEnd = ABValue.IndexOf(")");
                    string BValueStr = ABValue.Substring(SplitIndexStart + 1, SplitIndexEnd - SplitIndexStart - 1);
                    int AValueInt = int.Parse(AValueStr);
                    int BValueInt = int.Parse(BValueStr);
                    //信号值转换为十进制
                    int SignalValueDecimal = Convert.ToInt32(SignalValue, 16);  
                    //推算出物理值
                    int physics = AValueInt * SignalValueDecimal + BValueInt;
                    //MessageBox.Show(physics.ToString());
                    this.digitalGauge1.Text =Convert.ToString(physics);
                    this.arcScaleComponent1.Value = physics;
             


                }

            }
            catch (Exception )
            {

                ;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LINQDataContext context = new LINQDataContext();
            var query = from sm in context.SendMessage
                        select sm;
            foreach (var item in query)
            {

               
                TreeNode tn = TreeView3.Nodes.Add(item.BO_.ToString().Trim() + item.ID.ToString().Trim());
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
    }
}
