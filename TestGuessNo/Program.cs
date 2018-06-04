using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio;

namespace TestGuessNo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string anstring;
            GuessNumber guessNumber = new GuessNumber();
            Console.WriteLine("電腦出題：{0}", guessNumber.resultString);

            ComputerGuessNumber computerGuessNumber = new ComputerGuessNumber();

            //將答案輸入產生結果
            anstring = guessNumber.ChkAns(computerGuessNumber.ansString);

            Console.WriteLine(guessNumber.ChkAns(computerGuessNumber.ansString));

            while (anstring != "4A0B")
            {
                //猜答案
                computerGuessNumber.Guess(anstring);
                //將答案輸入產生結果
                anstring = guessNumber.ChkAns(computerGuessNumber.ansString);
                Console.WriteLine(guessNumber.ChkAns(computerGuessNumber.ansString));
            }
            Console.WriteLine("電腦在第{0}次猜中了！", computerGuessNumber.count.ToString());
        }
    }
}