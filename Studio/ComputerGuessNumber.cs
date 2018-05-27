using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio
{
    internal class ComputerGuessNumber
    {
        //可能答案清單
        private Guestlis guestList = new Guestlis();

        //移除清單
        private List<string> removeList = new List<string>();

        private int ansCount;
        private List<int> ans = new List<int>();

        //電腦試猜答案
        private string ansString = string.Empty;

        private Dictionary<string, int> chkResult = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };

        //產生0-9的LIST
        private List<int> iList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //判定結果
        private string result;

        //猜題次數
        private int count = 0;

        public ComputerGuessNumber()
        {
            count++;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            //產生0-9的LIST
            iList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //建立空LIST
            for (int i = 1; i <= 4; i++)
            {
                //取索引
                int index = random.Next(0, iList.Count - 1);
                //在結果LIST寫入值
                ans.Add(iList[index]);
                ansString += iList[index].ToString();
                //從0-9LIST移除已取出數值
                iList.Remove(iList[index]);
            }

            Console.WriteLine("電腦第{0}次猜:{1}", count.ToString(), ansString);

            //0A0B大量移除
            chkResult = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };
            if (result == "0A0B")
            {
                foreach (string x in guestList.ansList)
                {
                    foreach (char t in ansString)
                    {
                        if (x.IndexOf(t) >= 1)
                            removeList.Add(x);
                    }
                }
            }

            foreach (string x in guestList.ansList)
            {
                if (result != GetChkResult(ansString, x))
                    removeList.Add(x);
            }

            foreach (string x in removeList)
                guestList.ansList.Remove(x);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="result">請放入前次猜題結果</param>
        public ComputerGuessNumber(string result)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Console.WriteLine("結果是:{0}", result);

            if (result == "4A0B")
            {
                Console.WriteLine("電腦在第{0}次猜中了！", count);
            }
            //0A0B大量移除
            else if (result == "0A0B")
                foreach (string x in guestList.ansList)
                    foreach (char t in ansString)
                        if (x.IndexOf(t) >= 1)
                            removeList.Add(x);

            if (count == 1)
            {
                for (int i = 1; i <= 4; i++)
                {
                    //取索引
                    int index = random.Next(0, iList.Count - 1);
                    //在結果LIST寫入值
                    ans.Add(iList[index]);
                    ansString += iList[index].ToString();
                    //從0-9LIST移除已取出數值
                    iList.Remove(iList[index]);
                }
            }
            else
            {
                int indexList;

                if (guestList.ansList.Count > 1)
                {
                    indexList = random.Next(0, guestList.ansList.Count - 1);
                }
                else
                {
                    indexList = 0;
                }
                ansString = guestList.ansList[indexList].ToString();
            }

            foreach (string x in guestList.ansList)
            {
                if (result != GetChkResult(ansString, x))
                    removeList.Add(x);
            }

            foreach (string x in removeList)
            {
                guestList.ansList.Remove(x);
            }
            ansCount = guestList.ansList.Count();
        }

        private string GetChkResult(string question, string ans)
        {
            Dictionary<string, int> chkResult = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };
            for (int j = 0; j < 4; j++)
                for (int k = 0; k < 4; k++)
                {
                    if (question[j] == ans[k] && j == k)
                        chkResult["a"]++;
                    else if (question[j] == ans[k])
                        chkResult["b"]++;
                }
            return string.Format("{0}A{1}B", chkResult["a"].ToString(), chkResult["b"].ToString());
        }
    }
}