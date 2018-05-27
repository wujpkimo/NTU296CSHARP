using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Studio
{
    /// <summary>
    /// 猜數字程式
    /// </summary>
    public class GuessNumber
    {
        public List<int> result = new List<int>();
        public string resultString = string.Empty;

        /// <summary>
        /// 初始化出題
        /// </summary>
        public GuessNumber()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            //產生0-9的LIST
            List<int> iList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //建立空LIST
            for (int i = 1; i <= 4; i++)
            {
                //取索引
                int index = random.Next(0, iList.Count - 1);
                //在結果LIST寫入值
                result.Add(iList[index]);
                resultString += iList[index].ToString();
                //從0-9LIST移除已取出數值
                iList.Remove(iList[index]);
            }
        }

        /// <summary>
        /// 輸入並驗證答案
        /// 含規則檢核
        /// </summary>
        /// <param name="Ans">答案</param>
        public string ChkAns(string Ans)
        {
            Dictionary<string, int> chkResult = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };

            #region 檢查答案是否合法

            Match match = Regex.Match(Ans, @"^\d{4}$");
            if (!match.Success)
                return "答案不合法";
            List<string> ans = new List<string>();
            for (int i = 0; i < Ans.Length; i++)
            {
                ans.Add(Ans[i].ToString());
                for (int j = i + 1; j < Ans.Length; j++)
                {
                    if (Ans[i] == Ans[j])
                        return "答案不合法";
                }
            }

            #endregion 檢查答案是否合法

            #region 檢查結果

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (result[i] == int.Parse(ans[j]) && i == j)
                        chkResult["a"]++;
                    else if (result[i] == int.Parse(ans[j]))
                        chkResult["b"]++;
                }

            #endregion 檢查結果

            return string.Format("{0}A{1}B", chkResult["a"].ToString(), chkResult["b"].ToString());
        }
    }
}