using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoWindowsSize;
using DBReviseTool;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _operator = null;//记录操作符
        private double num1;//第一个数
        private double num2;//第二个数
        private double result;//返回结果
        private double memory = 0;//记录存储值
        AutoAdaptWindowsSize AutoSize;//自适应窗口类
        DataTable dt;
        DBRevise revise = new DBRevise();
        public Form1()
        {
            InitializeComponent();
            var temp = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_control.Enabled = false;//清除、读取数据控件权限
            outcome_tbx.Text = "0";
            history_Rtbx.SelectionAlignment = HorizontalAlignment.Right;//右对齐
            //history_Rtbx.RightToLeft = RightToLeft.Yes; 使用这个属性对richtextBox进行对齐时，当输入特殊字符时会造成文本输入结果反转
            AutoSize = new AutoAdaptWindowsSize(this);
            //DataShow();
            //合并
        }
        #region 清除操作
        /// <summary>
        /// 清空计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanBtn_Click(object sender, EventArgs e)
        {
            outcome_tbx.Text = "0";
            history_tbx.Text = "";
            _operator = null;
        }
        /// <summary>
        /// 清空输入框中的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clean_Outcome_Btn_Click(object sender, EventArgs e)
        {
            if (_equalTrigger == true)//当输出结果后，直接清空
            {
                outcome_tbx.Text = "0";
                history_tbx.Text = "";
                _operator = null;
                return;
            }
            outcome_tbx.Text = "0";
        }
        /// <summary>
        /// 对输入框的值进行删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Btn_Click(object sender, EventArgs e)
        {
            if (_equalTrigger == true)//当输出结果后，删除不了输入框中的数据
            {
                history_tbx.Text = "";
                return;
            }
            if (outcome_tbx.Text == "" || outcome_tbx.Text == "0")//判断输入框是否有值
            {
                return;
            }
            if (outcome_tbx.Text.Length > 1)
            {
                char[] temp = outcome_tbx.Text.ToCharArray();
                temp[temp.Length - 1] = '\0';//string 以\0为结束的标志符
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(temp);
                outcome_tbx.Text = sb.ToString();
            }
            else
            {
                outcome_tbx.Text = "0";
            }
        }
        #endregion
        #region 数字、运算符的点击获取方法
        /// <summary>
        /// 数字获取方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;    // as 即为类型转换
            String temp = btnTemp.Text;   // 获得点击的数字。
            if (_equalTrigger == true)
            {
                outcome_tbx.Text = "0";
                history_tbx.Text = "";
                _equalTrigger = false;
            }
            if (outcome_tbx.Text == "0")
            {
                outcome_tbx.Text = temp;
            }
            else
            {
                outcome_tbx.Text += temp;
            }
        }
        /// <summary>
        /// 运算符获取方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            _operator = btnTemp.Text;   // 获得点击的运算符。
            try
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                history_tbx.Text = outcome_tbx.Text + _operator;
                outcome_tbx.Text = "";
                _equalTrigger = false;
            }
            catch (Exception)
            {
                MessageBox.Show("重复输入运算符！");
                MessageBox.Show("");
            }
        }
        /// <summary>
        /// 添加小数点方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dot_Btn_Click(object sender, EventArgs e)
        {
            if (outcome_tbx.Text.Contains("."))
            {
                return;
            }
            outcome_tbx.Text += ".";
            _equalTrigger = false;
        }
        #endregion
        #region 等号运算
        bool _equalTrigger = false;//记录等号是否触发
        /// <summary>
        /// 等号方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_equalTrigger != true)//连续运算
                {
                    num2 = Convert.ToDouble(outcome_tbx.Text);
                }
                else
                {
                    num1 = result;
                }
                switch (_operator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "× ":
                        result = num1 * num2;
                        break;
                    case "÷":
                        if (num2 == 0)
                        {
                            MessageBox.Show("被除数不能为0！");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default://没有运算符，一直按等于号的情况
                        result = num2;
                        history_tbx.Text = result.ToString() + "=";
                        _equalTrigger = true;
                        HistoryShow();
                        return;
                }
                history_tbx.Text = num1.ToString() + _operator + num2.ToString() + "=";//运算表达式输出
                outcome_tbx.Text = result.ToString();
                _equalTrigger = true;
                //HistoryShow();
                //DBRevise.BulkInsert(history_tbx.Text, outcome_tbx.Text);
                //DataShow();
            }
            catch
            {
                MessageBox.Show("请输入有效数字！");

            }
            finally
            {
                revise.ReleaseDatabase();
            }
        }
        #endregion
        #region 各运算功能实现
        /// <summary>
        /// 数字正负转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Num_Change_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && outcome_tbx.Text == "")
            {
                MessageBox.Show("错误输入！");
            }
            else
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                Num_Change(num1);
            }
        }
        /// <summary>
        /// 正负运算方法
        /// </summary>
        /// <param name="x"></param>
        private void Num_Change(double x)
        {
            if (x >= 0)
            {
                x = 0 - x;
                outcome_tbx.Text = x.ToString();
            }
            else
            {
                outcome_tbx.Text = (Math.Abs(x)).ToString();
            }
        }
        /// <summary>
        /// 开平方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Squared_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && outcome_tbx.Text == "")
            {
                MessageBox.Show("错误输入！");
            }
            else
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                if (_operator != null)
                {
                    history_tbx.Text = history_tbx.Text + $"Sqrt({outcome_tbx.Text})" + "=";
                }
                else
                {
                    history_tbx.Text = $"Sqrt({outcome_tbx.Text})" + "=";
                }
                outcome_tbx.Text = (Math.Sqrt(num1)).ToString();
                //
                num2 = Convert.ToDouble(outcome_tbx.Text);
                result = num1;
                _equalTrigger = true;//这种开方运算相当于等于的作用，保证等号连续运算
                //HistoryShow();
                //DBRevise.BulkInsert(history_tbx.Text, outcome_tbx.Text);
                // DataShow();
            }
        }
        /// <summary>
        /// 平方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && outcome_tbx.Text == "")
            {
                MessageBox.Show("错误输入！");
            }
            else
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                if (_operator != null)
                {
                    history_tbx.Text = history_tbx.Text + $"Pow({outcome_tbx.Text})" + "=";
                }
                else
                {
                    history_tbx.Text = $"Pow({outcome_tbx.Text})" + "=";
                }
                outcome_tbx.Text = (Math.Pow(num1, 2)).ToString();
                num2 = Convert.ToDouble(outcome_tbx.Text);
                result = num1;
                _equalTrigger = true;
                //HistoryShow();
                //DBRevise.BulkInsert(history_tbx.Text, outcome_tbx.Text);
                // DataShow();
            }
        }
        /// <summary>
        /// 倒数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reciprocal_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && outcome_tbx.Text == "")
            {
                MessageBox.Show("错误输入!");
            }
            else
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                num1 = 1 / num1;
                if (_operator != null)
                {
                    history_tbx.Text = history_tbx.Text + $"1/({outcome_tbx.Text})" + "=";
                }
                else
                {
                    history_tbx.Text = $"1/({outcome_tbx.Text})" + "=";
                }
                outcome_tbx.Text = num1.ToString();
                num2 = Convert.ToDouble(outcome_tbx.Text);
                result = num1;
                _equalTrigger = true;
                //HistoryShow();
                //DBRevise.BulkInsert(history_tbx.Text, outcome_tbx.Text);
                //DataShow();
            }
        }
        /// <summary>
        /// 百分号运算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Percent_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && outcome_tbx.Text == "")
            {
                MessageBox.Show("错误输入!");
            }
            else
            {
                num1 = Convert.ToDouble(outcome_tbx.Text);
                num1 = num1 / 100;
                if (_operator != null)
                {
                    history_tbx.Text = history_tbx.Text + $"1/({outcome_tbx.Text})" + "=";
                }
                else
                {
                    history_tbx.Text = $"1/({outcome_tbx.Text})" + "=";
                }
                outcome_tbx.Text = num1.ToString();
                num2 = Convert.ToDouble(outcome_tbx.Text);
                result = num1;
                _equalTrigger = true;
                //HistoryShow();
                //DBRevise.BulkInsert(history_tbx.Text, outcome_tbx.Text);
                //DataShow();
            }
        }
        #endregion
        #region 历史记录展示
        private void HistoryShow()
        {
            String expressStr = history_tbx.Text;
            String resultStr = outcome_tbx.Text;
            history_Rtbx.AppendText(expressStr + "\r\n");    // 添加表达式,换行
            int startIndex = history_Rtbx.Text.Length;
            history_Rtbx.AppendText(resultStr + "\r\n");    //添加结果，换行
            history_Rtbx.Select(startIndex, resultStr.Length);    // 将结果部分在richTextBox中设为选中
            history_Rtbx.SelectionFont = new Font(history_Rtbx.Font.Name, history_Rtbx.Font.Size + 1, FontStyle.Bold);
        }
        #endregion
        #region 存取数据组按键
        /// <summary>
        /// 数据存储按键MS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Memory_Save_Btn_Click(object sender, EventArgs e)
        {
            if (_operator != null && _equalTrigger == false && outcome_tbx.Text != " ")
            {
                memory = Convert.ToDouble(history_tbx.Text.Substring(0, (history_tbx.Text.Length - 2)));
            }
            else
            {
                memory = Convert.ToDouble(outcome_tbx.Text);
                history_tbx.Text = "";
            }
            M_identifier_lab.Visible = true;//存错数据后，显示M表示有数据被存储
            panel_control.Enabled = true;//打开控件控制
        }
        /// <summary>
        /// 数据读取按键MR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Memory_Read_Btn_Click(object sender, EventArgs e)
        {
            outcome_tbx.Text = memory.ToString();
        }
        /// <summary>
        /// 数据清除按键MR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Memory_Clear_Btn_Click(object sender, EventArgs e)
        {
            memory = 0;//微软计算器默认为0；
            M_identifier_lab.Visible = false;
            panel_control.Enabled = false;//关闭控件控制
        }
        /// <summary>
        /// 存储数据加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Memory_Subtract_Btn_Click(object sender, EventArgs e)
        {
            if (outcome_tbx.Text == "")
            {
                MessageBox.Show("请输入数据！");
            }
            else
            {
                memory -= Convert.ToDouble(outcome_tbx.Text);
            }
        }
        /// <summary>
        /// 存储数据减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Memory_Add_Btn_Click(object sender, EventArgs e)
        {
            if (outcome_tbx.Text == "")
            {
                MessageBox.Show("请输入数据！");
            }
            else
            {
                memory += Convert.ToDouble(outcome_tbx.Text);
            }
        }
        #endregion
        #region 数据清除、查询
        /// <summary>
        /// 清空历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void History_Del_Ptx_Click(object sender, EventArgs e)
        {
            history_Rtbx.Text = "";
        }
        /// <summary>
        /// 数据库清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Data_Clear_Ptx_Click(object sender, EventArgs e)
        {
            revise.ClearDatabase("delete from CalculatorData_Table");
            //DataShow();
        }
        /// <summary>
        /// 数据库数据查询展示
        /// </summary>
        private void DataShow()
        {
            dt = revise.QueryDatabase("select * from CalculatorData_Table").Tables[0];
            dataGridView1.DataSource = dt;
        }
        #endregion
        /// <summary>
        /// 自适应窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) // 这个判断，电脑缩放布局不是100%的时候，会报错
            {
                AutoSize.FormSizeChanged();
            }
        }
        private void InitialForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);// 系统的桌面地址
                string lnkPath = desktopPath + "\\计算器.lnk";
                var wshShell = new IWshRuntimeLibrary.WshShell();
                var shortCut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(lnkPath);
                shortCut.TargetPath = Application.ExecutablePath;   // 程序可执行文件地址
                shortCut.Description = "计算器"; // 默认如果为空情况会显示创建时快捷方式的文件位置。
                shortCut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);  // 设置起始位置，不然起始位置是桌面，会导致程序文件生成在桌面上。
                shortCut.IconLocation = "Calculator.exe, 0";//获取程序图标
                shortCut.Save();    // 同名快捷方式会自动执行修改逻辑，鼠标放在图标上的备注会一直是创建时的内容。
                MessageBox.Show("已生成快捷方式");
            }
        }
        /// <summary>
        /// 减轻Form窗口闪屏
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
