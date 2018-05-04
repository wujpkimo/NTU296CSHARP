namespace BMICalculate
{
    partial class BMI計算機
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重(kg)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(70, 33);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHeight_KeyDown);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(70, 64);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 99);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(155, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "計算BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(15, 129);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 12);
            this.lblBMI.TabIndex = 4;
            // 
            // BMI計算機
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BMI計算機";
            this.Text = "BMI計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblBMI;
    }
}

