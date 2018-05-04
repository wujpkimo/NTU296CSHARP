namespace PokemonUi
{
    partial class PokemonUi
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
            this.btnPowerUp = new System.Windows.Forms.Button();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.lblNameCht = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblWeightValue = new System.Windows.Forms.Label();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStardustValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCandyValue = new System.Windows.Forms.Label();
            this.lblCandy = new System.Windows.Forms.Label();
            this.lblPwStardust = new System.Windows.Forms.Label();
            this.lblPwCandy = new System.Windows.Forms.Label();
            this.lblEvCandy = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblCPvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPowerUp
            // 
            this.btnPowerUp.Location = new System.Drawing.Point(25, 390);
            this.btnPowerUp.Name = "btnPowerUp";
            this.btnPowerUp.Size = new System.Drawing.Size(75, 23);
            this.btnPowerUp.TabIndex = 0;
            this.btnPowerUp.Text = "POWER UP";
            this.btnPowerUp.UseVisualStyleBackColor = true;
            this.btnPowerUp.Click += new System.EventHandler(this.btnPowerUp_Click);
            // 
            // btnEvolve
            // 
            this.btnEvolve.Location = new System.Drawing.Point(25, 420);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(75, 23);
            this.btnEvolve.TabIndex = 1;
            this.btnEvolve.Text = "EVOLVE";
            this.btnEvolve.UseVisualStyleBackColor = true;
            // 
            // lblNameCht
            // 
            this.lblNameCht.AutoSize = true;
            this.lblNameCht.Location = new System.Drawing.Point(129, 265);
            this.lblNameCht.Name = "lblNameCht";
            this.lblNameCht.Size = new System.Drawing.Size(32, 12);
            this.lblNameCht.TabIndex = 2;
            this.lblNameCht.Text = "Name";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(125, 286);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(36, 12);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "HP/HP";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTypeValue.Location = new System.Drawing.Point(12, 311);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(31, 13);
            this.lblTypeValue.TabIndex = 4;
            this.lblTypeValue.Text = "Type";
            this.lblTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.AutoSize = true;
            this.lblWeightValue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeightValue.Location = new System.Drawing.Point(124, 308);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.Size = new System.Drawing.Size(90, 16);
            this.lblWeightValue.TabIndex = 5;
            this.lblWeightValue.Text = "WeightValue";
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.AutoSize = true;
            this.lblHeightValue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHeightValue.Location = new System.Drawing.Point(229, 308);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(87, 16);
            this.lblHeightValue.TabIndex = 6;
            this.lblHeightValue.Text = "HeightValue";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 327);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Height";
            // 
            // lblStardustValue
            // 
            this.lblStardustValue.AutoSize = true;
            this.lblStardustValue.Location = new System.Drawing.Point(52, 351);
            this.lblStardustValue.Name = "lblStardustValue";
            this.lblStardustValue.Size = new System.Drawing.Size(69, 12);
            this.lblStardustValue.TabIndex = 7;
            this.lblStardustValue.Text = "StardustValue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "Stardust";
            // 
            // lblCandyValue
            // 
            this.lblCandyValue.AutoSize = true;
            this.lblCandyValue.Location = new System.Drawing.Point(181, 351);
            this.lblCandyValue.Name = "lblCandyValue";
            this.lblCandyValue.Size = new System.Drawing.Size(63, 12);
            this.lblCandyValue.TabIndex = 7;
            this.lblCandyValue.Text = "CandyValue";
            // 
            // lblCandy
            // 
            this.lblCandy.AutoSize = true;
            this.lblCandy.Location = new System.Drawing.Point(181, 363);
            this.lblCandy.Name = "lblCandy";
            this.lblCandy.Size = new System.Drawing.Size(36, 12);
            this.lblCandy.TabIndex = 7;
            this.lblCandy.Text = "Candy";
            // 
            // lblPwStardust
            // 
            this.lblPwStardust.AutoSize = true;
            this.lblPwStardust.Location = new System.Drawing.Point(119, 398);
            this.lblPwStardust.Name = "lblPwStardust";
            this.lblPwStardust.Size = new System.Drawing.Size(56, 12);
            this.lblPwStardust.TabIndex = 7;
            this.lblPwStardust.Text = "PwStardust";
            // 
            // lblPwCandy
            // 
            this.lblPwCandy.AutoSize = true;
            this.lblPwCandy.Location = new System.Drawing.Point(206, 398);
            this.lblPwCandy.Name = "lblPwCandy";
            this.lblPwCandy.Size = new System.Drawing.Size(50, 12);
            this.lblPwCandy.TabIndex = 7;
            this.lblPwCandy.Text = "PwCandy";
            // 
            // lblEvCandy
            // 
            this.lblEvCandy.AutoSize = true;
            this.lblEvCandy.Location = new System.Drawing.Point(206, 425);
            this.lblEvCandy.Name = "lblEvCandy";
            this.lblEvCandy.Size = new System.Drawing.Size(49, 12);
            this.lblEvCandy.TabIndex = 7;
            this.lblEvCandy.Text = "EvCandy";
            // 
            // imgPhoto
            // 
            this.imgPhoto.Location = new System.Drawing.Point(54, 44);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(197, 218);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 8;
            this.imgPhoto.TabStop = false;
            this.imgPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(119, 29);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(19, 12);
            this.lblCP.TabIndex = 9;
            this.lblCP.Text = "CP";
            // 
            // lblCPvalue
            // 
            this.lblCPvalue.AutoSize = true;
            this.lblCPvalue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCPvalue.Location = new System.Drawing.Point(144, 25);
            this.lblCPvalue.Name = "lblCPvalue";
            this.lblCPvalue.Size = new System.Drawing.Size(40, 16);
            this.lblCPvalue.TabIndex = 10;
            this.lblCPvalue.Text = "****";
            // 
            // PokemonUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 451);
            this.Controls.Add(this.lblCPvalue);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.lblEvCandy);
            this.Controls.Add(this.lblPwCandy);
            this.Controls.Add(this.lblCandy);
            this.Controls.Add(this.lblPwStardust);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCandyValue);
            this.Controls.Add(this.lblStardustValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHeightValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWeightValue);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblNameCht);
            this.Controls.Add(this.btnEvolve);
            this.Controls.Add(this.btnPowerUp);
            this.Name = "PokemonUi";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowerUp;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.Label lblNameCht;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStardustValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCandyValue;
        private System.Windows.Forms.Label lblCandy;
        private System.Windows.Forms.Label lblPwStardust;
        private System.Windows.Forms.Label lblPwCandy;
        private System.Windows.Forms.Label lblEvCandy;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblCPvalue;
    }
}

