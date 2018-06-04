using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studio;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private GuessNumber guessNumber;
        private ComputerGuessNumber computerGuessNumber;
        private List<int> guessList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            playerGuess();
        }

        private void btnComGuess_Click(object sender, EventArgs e)
        {
            disableAllControl();
            autoGuess();
        }

        private void disableAllControl()
        {
            txtAns.Enabled = false;
            btnReset.Visible = btnReset.Enabled = true;
            btnGuess.Enabled = btnComGuess.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            guessNumber = new GuessNumber();
            lblComGen.Text = string.Format("電腦出題為{0}", guessNumber.resultString);
            lblGuessList.Text = string.Empty;
            txtAns.Enabled = true;
            txtAns.Text = string.Empty;
            btnReset.Visible = btnReset.Enabled = true;
            btnGuess.Enabled = btnComGuess.Enabled = true;
        }

        private void autoGuess()
        {
            string anstring;
            lblGuessList.Text += "\n" + string.Format("電腦出題：{0}", guessNumber.resultString);

            computerGuessNumber = new ComputerGuessNumber();

            //將答案輸入產生結果
            anstring = guessNumber.ChkAns(computerGuessNumber.ansString);

            lblGuessList.Text += "\n" + string.Format("電腦第{0}次猜:{1}", computerGuessNumber.count.ToString(), computerGuessNumber.ansString);
            lblGuessList.Text += "\n" + string.Format(guessNumber.ChkAns(computerGuessNumber.ansString));

            while (anstring != "4A0B")
            {
                //猜答案
                computerGuessNumber.Guess(anstring);
                //將答案輸入產生結果
                anstring = guessNumber.ChkAns(computerGuessNumber.ansString);
                lblGuessList.Text += "\n" + string.Format("電腦第{0}次猜:{1}", computerGuessNumber.count.ToString(), computerGuessNumber.ansString);
                lblGuessList.Text += "\n" + string.Format(guessNumber.ChkAns(computerGuessNumber.ansString));
            }
            lblGuessList.Text += "\n" + string.Format("電腦在第{0}次猜中了！", computerGuessNumber.count.ToString());
        }

        private void btnAutoGuess1k_Click(object sender, EventArgs e)
        {
            autoPlay(100);
        }

        private void btnAutoGuess10k_Click(object sender, EventArgs e)
        {
            autoPlay(1000);
        }

        private void autoPlay(int playCount)
        {
            disableAllControl();
            DateTime time_start = DateTime.Now;//計時開始 取得目前時間

            //後面的時間減前面的時間後 轉型成TimeSpan即可印出時間差

            guessList = new List<int>();
            double avgCount = 0;
            for (int i = 1; i <= playCount; i++)
            {
                reset();
                autoGuess();
                guessList.Add(computerGuessNumber.count);
                avgCount += computerGuessNumber.count;
            }

            DateTime time_end = DateTime.Now;//計時結束 取得目前時間
            string second = ((TimeSpan)(time_end - time_start)).TotalSeconds.ToString();

            avgCount = avgCount / playCount;
            lblGuessList.Text = string.Format("玩1000次，共花費{0}秒，電腦平均{1}次猜出答案！", second.ToString(), avgCount.ToString())
                + "\n" + lblGuessList.Text;
        }

        private void txtAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & txtAns.TextLength == 4)
            {
                playerGuess();
            }
        }

        private void playerGuess()
        {
            count++;
            string msg;
            msg = string.Format("玩家第{0}次猜:{1}", count.ToString(), txtAns.Text);
            msg += "\n" + string.Format(guessNumber.ChkAns(txtAns.Text));
            if (lblGuessList.Text == "")
            {
                lblGuessList.Text = msg;
            }
            else
            {
                lblGuessList.Text = msg + "\n" + lblGuessList.Text;
            }
            txtAns.Text = string.Empty;
            txtAns.Focus();
        }
    }
}