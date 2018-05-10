using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandomGen
{
    public partial class 猜數字出題器 : Form
    {
        public 猜數字出題器()
        {
            InitializeComponent();
            randomList(lbl1, lbl2, lbl3, lbl4);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            randomList(lbl1, lbl2, lbl3, lbl4);
        }

        /// <summary>
        /// 4位不重複產生器(含更新4個LABEL控制項)
        /// </summary>
        /// <param name="label1"></param>
        /// <param name="label2"></param>
        /// <param name="label3"></param>
        /// <param name="label4"></param>
        public void randomList(Label label1, Label label2, Label label3, Label label4)
        {
            Random random = new Random();
            //產生0-9的LIST
            List<int> iList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //建立空LIST
            List<int> result = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                //取索引
                int index = random.Next(0, iList.Count - 1);
                //在結果LIST寫入值
                result.Add(iList[index]);
                //從0-9LIST移除已取出數值
                iList.Remove(iList[index]);
            }

            #region 寫入畫面控制項

            label1.Text = result[0].ToString();
            label2.Text = result[1].ToString();
            label3.Text = result[2].ToString();
            label4.Text = result[3].ToString();

            #endregion 寫入畫面控制項
        }
    }
}