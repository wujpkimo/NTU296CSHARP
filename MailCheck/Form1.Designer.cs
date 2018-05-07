namespace MailCheck
{
    partial class MailChecker
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnSummit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(113, 41);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(149, 22);
            this.txtMail.TabIndex = 0;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(13, 46);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(94, 12);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "請輸入您的MAIL";
            // 
            // btnSummit
            // 
            this.btnSummit.Location = new System.Drawing.Point(113, 69);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(75, 23);
            this.btnSummit.TabIndex = 2;
            this.btnSummit.Text = "送出";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(111, 95);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 3;
            // 
            // MailChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 183);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSummit);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Name = "MailChecker";
            this.Text = "郵件位置檢核工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnSummit;
        private System.Windows.Forms.Label lblResult;
    }
}

