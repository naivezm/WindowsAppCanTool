using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCanToolApp
{
    public partial class PhysicsValueForm:Form
    {
        private int MessageIDInt;
        public string sss="";
        public static int A, B;
      
        public PhysicsValueForm()
        {
            InitializeComponent();
        }

        private void PhysicsValueForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Name";
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col.ReadOnly = true;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "PhyValue";
            
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Range";
            PhyDataGridView.Columns.Add(col);
            PhyDataGridView.Columns.Add(col1);
            PhyDataGridView.Columns.Add(col2);
            PhyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
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
            string MessageIDStr = Form1.FistLevelNodeName;
            MessageIDStr = MessageIDStr.Remove(0, 3);
            MessageIDInt = int.Parse(MessageIDStr);
            var query = from sg in context.SendSignal
                        where sg.ID == MessageIDInt
                        select sg;

            foreach (var item in query)
            {


                int index = PhyDataGridView.Rows.Add();
                PhyDataGridView.Rows[index].Cells[0].Value = item.Signal_Name;
                PhyDataGridView.Rows[index].Cells[1].Value =0 ;
               // PhyDataGridView.Rows[index].Cells[2].Value =
            }



        }

   
         
        public void ReadABFromDB(string Signal_name, int MessageID)
        {
            //读取当前信号的(A，B)的值
            try
            {
                LINQDataContext context = new LINQDataContext();
                var query = from sg in context.SendSignal
                            where sg.Signal_Name == Signal_name && sg.ID == MessageID
                            select sg;
                string ABValue = null;
                foreach (var item in query)
                {
                    ABValue = item._A_B_;

                }
                int SplitIndexStart = ABValue.IndexOf(",");
                string AValueStr = ABValue.Substring(1, SplitIndexStart - 1);
                int SplitIndexEnd = ABValue.IndexOf(")");
                string BValueStr = ABValue.Substring(SplitIndexStart + 1, SplitIndexEnd - SplitIndexStart - 1);
                A = int.Parse(AValueStr);
                B = int.Parse(BValueStr);
            }
            catch (Exception ee)
            {
                
                MessageBox.Show(ee.ToString());
            }
          
        }
       
        public string toBinary(string anaresult)//将CanData转化为二进制数（输入字符串，输出二进制形式字符串）
        {
            int i;
            #region //把字符串DATA转化为2进制数，以后考虑用函数封装(anaresult->binarycandata)

            byte[] returnBytes = new byte[anaresult.Length / 2];
            for (i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(anaresult.Substring(i * 2, 2), 16);
            string returnStr = "";
            if (returnBytes != null)
            {
                for (i = 0; i < returnBytes.Length; i++)
                {
                    returnStr += returnBytes[i].ToString("X2");
                }
            }


            string t, binarycandata = "";
            for (i = 0; i < returnBytes.Length; i++)
            {
                t = System.Convert.ToString(returnBytes[i], 2);
                t = t.ToString().PadLeft(8, '0');//高位用0补足
                binarycandata += t;
            }

            Console.WriteLine(returnStr);
            Console.WriteLine(binarycandata);
            #endregion

            /* #region //临时区域

             int  test=Convert.ToInt32("11", 2);
             Console.WriteLine(test);

             #endregion*/

            return binarycandata;
        }
        public string GetStart(string str)
        {
            int firstIndex = str.IndexOf('|');
            return str.Substring(0, firstIndex);

        }
        public string GetLen(string str)
        {
            int firstIndex = str.IndexOf('|');
            int seconIndex = str.IndexOf('@');
            return str.Substring(firstIndex + 1, seconIndex - firstIndex - 1);

        }
        public string to16CanData(string anaresult) //8个8位二进制数转化为16进制
        {
            string CanData16 = "";
            for (int i = 0; i < 8; i++)
            {
                string subana = anaresult.Substring(i * 8, 8);
                byte Bytes = Convert.ToByte(subana, 2);
                string t = Bytes.ToString("x2");//16进制数
                CanData16 += t;
            }
            return CanData16;
        }
      

        public string canSendAnalysis(string CanSignal)//把用户输入的内容转化为Can信息 string格式为ID+数据 最后
        {
            //61 0 0 0
            string anaresult = null;
            string candata = CanSignal;

            //将用户输入数值按顺序解析，生成CanData
            //查找位置

            int i = 0;
            anaresult = candata;
            string[] candatablock = candata.Split(' ');///按空格分割
            //Console.WriteLine("*****************");
            string binaryCanID_Data = "0000000000000000000";//标准帧的CanID和Data 19个0

            //ID放入binaryCanID_Data
            string CanID16 = Convert.ToString(Convert.ToInt32(candatablock[0]), 16);//16进制的CanID
            Console.WriteLine(CanID16);
            binaryCanID_Data = binaryCanID_Data.Remove(3 - CanID16.Length, CanID16.Length);
            binaryCanID_Data = binaryCanID_Data.Insert(3 - CanID16.Length, CanID16);
            //Console.WriteLine(binaryCanID_Data);
            //现在扩展帧，标准帧分别默认为3位和8位十进制数，后期按相应16进制进行解析
            //暂时不写扩展帧的解析

            LINQDataContext context = new LINQDataContext();
            var query = from sg in context.SendSignal
                        where sg.ID == int.Parse(candatablock[0])
                        select sg;
            int start, len;
            string binarycandata = toBinary("0000000000000000"); //转化为二进制
            foreach (var item in query)
            {
                double phy = Convert.ToInt32(candatablock[++i]);//根据第i行解析
                //Console.WriteLine(phy);
                ReadABFromDB(item.Signal_Name, item.ID);
                double a = Convert.ToDouble(A);
                double b = Convert.ToDouble(B);
                int x = Convert.ToInt32((phy - b) / a);//获取一行的x
                //Console.WriteLine(x);
                string binaryx_value = System.Convert.ToString(x, 2);
                start = Convert.ToInt32(GetStart(item.Bit_Format));
                len = Convert.ToInt32(GetLen(item.Bit_Format));
                int substart = start / 8 * 8 - start % 8 + 7;
                int sublen = len - binaryx_value.Length;
                binarycandata = binarycandata.Remove(System.Math.Abs(substart + sublen), binaryx_value.Length); //
                binarycandata = binarycandata.Insert(System.Math.Abs(substart + sublen), binaryx_value);
            }
            anaresult = to16CanData(binarycandata);
            binaryCanID_Data = binaryCanID_Data.Remove(3, 16);
            var query1 = from sm in context.SendMessage
                        where sm.ID == int.Parse(candatablock[0])
                        select sm;
            string DLC = null;
            foreach (var item in query1)
            {
                DLC = item.DLC.ToString();
            }
            binaryCanID_Data = binaryCanID_Data.Insert(3, DLC);
            binaryCanID_Data = binaryCanID_Data.Insert(4, anaresult);

            //标准帧
            binaryCanID_Data = "t" + binaryCanID_Data;
            binaryCanID_Data =binaryCanID_Data+"\\r";
            return binaryCanID_Data;
        }
        public string canSend(string CanSignals)//向装置发送信息
        {
            //给出一个can信息格式：candata = "61 2 2 2";
            //解析为Can信息格式发送
            string All = "";
            All += canSendAnalysis(CanSignals); 
            return All;
        }
        private void SaveValue_Click(object sender, EventArgs e)
        {
            int row = PhyDataGridView.RowCount-1;
            LINQDataContext context = new LINQDataContext();
            string s = this.MessageIDInt.ToString();
            s += ' ';
            int PhysicsValue;
            for (int i = 0; i < row; i++)
            {
               
                var query = from sg in context.SendSignal
                            where sg.Signal_Name == PhyDataGridView.Rows[i].Cells[0].Value.ToString() && sg.ID == this.MessageIDInt
                            select sg;
   
                foreach (var item in query )
                {
                    
                    //第一步把用户输入的物理值转换为十进制
                    PhysicsValue = int.Parse(PhyDataGridView.Rows[i].Cells[1].Value.ToString());
                    s += PhyDataGridView.Rows[i].Cells[1].Value.ToString();
                    s += ' ';
                    //第二步读取当前信号的(A，B)的值
                    ReadABFromDB(item.Signal_Name,item.ID);
                    //第三步计算信号值，并且转换为十六进制
                    int SignalValue = (PhysicsValue - B) / A;
                    String str = SignalValue.ToString("x8");
                    //取有效的十六进制数据
                    //MessageBox.Show(str);
                    ////第四步存到数据库中
                    item.Signal_Value = str;
                    
                }

                context.SubmitChanges();

                
            }
            //MessageBox.Show(s);
            sss=canSend(s);
            //MessageBox.Show(sss);
           
            this.Close();
            //int row = PhyDataGridView.RowCount - 1;
            //LINQDataContext context = new LINQDataContext();
            //for (int i = 0; i < row; i++)
            //{

            //    var query = from sg in context.SendSignal
            //                where sg.Signal_Name == PhyDataGridView.Rows[i].Cells[0].Value.ToString() && sg.ID == this.MessageIDInt
            //                select sg;

            //    foreach (var item in query)
            //    {

            //        //第一步把用户输入的物理值转换为十进制
            //        int PhysicsValue = int.Parse(PhyDataGridView.Rows[i].Cells[1].Value.ToString());
            //        //第二步读取当前信号的(A，B)的值
            //        ReadABFromDB(item.Signal_Name, item.ID);
            //        //第三步计算信号值，并且转换为十六进制
            //        int SignalValue = (PhysicsValue - B) / A;
            //        String str = SignalValue.ToString("x8");
            //        //取有效的十六进制数据
            //        MessageBox.Show(str);
            //        ////第四步存到数据库中
            //        item.Signal_Value = str;

            //    }

            //    context.SubmitChanges();


            //}


        


        }
     

       
       
       
       
        public static  string  CutHex(string hex)
        {
            //截取十六进制中的有效字段
            int NotZeroIndex =0;  //第一个不为0的位置
            foreach (var item in hex)
            {
                if (item == '0') NotZeroIndex++;
                else break;
            }
            hex = hex.Substring(NotZeroIndex, 8 - NotZeroIndex);
            return hex;
        }

       
    }
}


