using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculate
{
    public partial class BMI計算機 : Form
    {
        public BMI計算機()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string bodyStatus;
            float height = 0.0f;
            float weight = 0.0f;
            float bmi = 0.0f;
            height = float.Parse(txtHeight.Text) / 100;
            float.TryParse(txtWeight.Text, out weight);
            bmi = weight / (height * height);
            if (bmi > 18.5 && bmi <= 24)
            {
                bodyStatus = "健康";
            }
            else if (bmi > 24)
            {
                bodyStatus = "過重";
            }
            else
            {
                bodyStatus = "過輕";
            }
            lblBMI.Text = string.Format("您的BMI是 {0} 身體狀況為 {1}", bmi, bodyStatus);
            txtHeight.Focus();
        }

        private void txtHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & txtHeight.TextLength > 1)
            {
                txtWeight.Focus();
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & txtWeight.TextLength > 1)
            {
                btnCalc.Focus();
            }
        }
    }
}