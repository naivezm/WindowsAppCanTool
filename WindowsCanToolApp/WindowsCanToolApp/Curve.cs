using DevExpress.XtraCharts;
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
    public partial class Curve : Form
    {
        //string SelectedChildNodeName;
        //string selectedParentNodeName;
        public Curve()
        {
            InitializeComponent();
        }

        private void TreeView4_MouseDown(object sender, MouseEventArgs e)
        {
            
            if ((sender as TreeView) != null)
            {
                TreeView4.SelectedNode = TreeView4.GetNodeAt(e.X, e.Y);
            }

            try
            {
                if (TreeView4.SelectedNode.Level == 0)
                {
                    this.chartControl1.Series[0].Points.Clear();
                    //MessageBox.Show("父节点");
                    //SelectedChildNodeName = TreeView4.SelectedNode.Text.ToString();
                    //selectedParentNodeName = TreeView4.SelectedNode.Parent.Text.ToString();
                    ////读取当前信号的信号名
                    //string SignalName = SelectedChildNodeName;
                    //SignalName = SignalName.Remove(0, 3);
                    ////读取当前信号所属信息的ID
                    string MessageIDStr = TreeView4.SelectedNode.Text.ToString();
                    MessageIDStr = MessageIDStr.Remove(0, 3);
                    int MessageIDInt = int.Parse(MessageIDStr);
                    ////遍历数据库，取A，B，和信号值
                    LINQDataContext context = new LINQDataContext();
                    var query = from sg in context.SendSignal
                                where  sg.ID == MessageIDInt
                                select sg;
                    string ABValue = null;
                    string SignalValue = null;
                   // MessageBox.Show("ssssss");
                    foreach (var item in query)
                    {

                        ABValue = item._A_B_;
                        SignalValue = item.Signal_Value;
                        int SplitIndexStart = ABValue.IndexOf(",");
                        string AValueStr = ABValue.Substring(1, SplitIndexStart - 1);
                        int SplitIndexEnd = ABValue.IndexOf(")");
                        string BValueStr = ABValue.Substring(SplitIndexStart + 1, SplitIndexEnd - SplitIndexStart - 1);
                        int AValueInt = int.Parse(AValueStr);
                        int BValueInt = int.Parse(BValueStr);
                        //信号值转换为十进制
                        int SignalValueDecimal = Convert.ToInt32(SignalValue, 16);
                        //推算出物理值
                        int Y= AValueInt * SignalValueDecimal + BValueInt;
                     
                       // MessageBox.Show(X,Y.ToString());
                        this.chartControl1.Series[0].Points.Add(new SeriesPoint(item.Signal_Name,Y));

                    }
                    //int SplitIndexStart = ABValue.IndexOf(",");
                    //string AValueStr = ABValue.Substring(1, SplitIndexStart - 1);
                    //int SplitIndexEnd = ABValue.IndexOf(")");
                    //string BValueStr = ABValue.Substring(SplitIndexStart + 1, SplitIndexEnd - SplitIndexStart - 1);
                    //int AValueInt = int.Parse(AValueStr);
                    //int BValueInt = int.Parse(BValueStr);
                    ////信号值转换为十进制
                    //int SignalValueDecimal = Convert.ToInt32(SignalValue, 16);
                    ////推算出物理值
                    //int physics = AValueInt * SignalValueDecimal + BValueInt;
                    //MessageBox.Show(physics.ToString());
              



                }

            }
            catch (Exception)
            {

                ;
            }
        }

        private void Curve_Load(object sender, EventArgs e)
        {
            LINQDataContext context = new LINQDataContext();
            var query = from sm in context.SendMessage
                        select sm;
            foreach (var item in query)
            {


                TreeNode tn = TreeView4.Nodes.Add(item.BO_.ToString().Trim() + item.ID.ToString().Trim());
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

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
