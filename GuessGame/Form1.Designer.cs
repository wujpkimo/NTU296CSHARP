namespace GuessGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblGuessList = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblComGen = new System.Windows.Forms.Label();
            this.btnComGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAutoGuess1k = new System.Windows.Forms.Button();
            this.btnAutoGuess10k = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(31, 79);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(100, 22);
            this.txtAns.TabIndex = 0;
            this.txtAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAns_KeyDown);
            // 
            // lblGuessList
            // 
            this.lblGuessList.AutoSize = true;
            this.lblGuessList.Location = new System.Drawing.Point(29, 164);
            this.lblGuessList.Name = "lblGuessList";
            this.lblGuessList.Size = new System.Drawing.Size(0, 12);
            this.lblGuessList.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(149, 79);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "猜答案";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblComGen
            // 
            this.lblComGen.AutoSize = true;
            this.lblComGen.Location = new System.Drawing.Point(31, 29);
            this.lblComGen.Name = "lblComGen";
            this.lblComGen.Size = new System.Drawing.Size(53, 12);
            this.lblComGen.TabIndex = 3;
            this.lblComGen.Text = "電腦出題";
            // 
            // btnComGuess
            // 
            this.btnComGuess.Location = new System.Drawing.Point(31, 117);
            this.btnComGuess.Name = "btnComGuess";
            this.btnComGuess.Size = new System.Drawing.Size(75, 23);
            this.btnComGuess.TabIndex = 4;
            this.btnComGuess.Text = "電腦自動猜";
            this.btnComGuess.UseVisualStyleBackColor = true;
            this.btnComGuess.Click += new System.EventHandler(this.btnComGuess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(126, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAutoGuess1k
            // 
            this.btnAutoGuess1k.Location = new System.Drawing.Point(220, 117);
            this.btnAutoGuess1k.Name = "btnAutoGuess1k";
            this.btnAutoGuess1k.Size = new System.Drawing.Size(160, 23);
            this.btnAutoGuess1k.TabIndex = 6;
            this.btnAutoGuess1k.Text = "電腦自動出題猜答100次";
            this.btnAutoGuess1k.UseVisualStyleBackColor = true;
            this.btnAutoGuess1k.Click += new System.EventHandler(this.btnAutoGuess1k_Click);
            // 
            // btnAutoGuess10k
            // 
            this.btnAutoGuess10k.Location = new System.Drawing.Point(386, 117);
            this.btnAutoGuess10k.Name = "btnAutoGuess10k";
            this.btnAutoGuess10k.Size = new System.Drawing.Size(160, 23);
            this.btnAutoGuess10k.TabIndex = 6;
            this.btnAutoGuess10k.Text = "電腦自動出題猜答1,000次";
            this.btnAutoGuess10k.UseVisualStyleBackColor = true;
            this.btnAutoGuess10k.Click += new System.EventHandler(this.btnAutoGuess10k_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoGuess10k);
            this.Controls.Add(this.btnAutoGuess1k);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnComGuess);
            this.Controls.Add(this.lblComGen);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessList);
            this.Controls.Add(this.txtAns);
            this.Name = "Form1";
            this.Text = "猜數字遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblGuessList;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblComGen;
        private System.Windows.Forms.Button btnComGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAutoGuess1k;
        private System.Windows.Forms.Button btnAutoGuess10k;
    }
}

