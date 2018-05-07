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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgCandy = new System.Windows.Forms.PictureBox();
            this.imgCandy2 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandy2)).BeginInit();
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
            this.btnEvolve.Click += new System.EventHandler(this.btnEvolve_Click);
            // 
            // lblNameCht
            // 
            this.lblNameCht.AutoSize = true;
            this.lblNameCht.Location = new System.Drawing.Point(75, 269);
            this.lblNameCht.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblNameCht.Name = "lblNameCht";
            this.lblNameCht.Size = new System.Drawing.Size(150, 12);
            this.lblNameCht.TabIndex = 2;
            this.lblNameCht.Text = "Name";
            this.lblNameCht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(75, 286);
            this.lblHP.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(150, 12);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "HP/HP";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTypeValue.Location = new System.Drawing.Point(87, 324);
            this.lblTypeValue.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblTypeValue.MinimumSize = new System.Drawing.Size(120, 0);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(120, 13);
            this.lblTypeValue.TabIndex = 4;
            this.lblTypeValue.Text = "Type";
            this.lblTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.AutoSize = true;
            this.lblWeightValue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeightValue.Location = new System.Drawing.Point(2, 309);
            this.lblWeightValue.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.Size = new System.Drawing.Size(90, 16);
            this.lblWeightValue.TabIndex = 5;
            this.lblWeightValue.Text = "WeightValue";
            this.lblWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.AutoSize = true;
            this.lblHeightValue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHeightValue.Location = new System.Drawing.Point(215, 308);
            this.lblHeightValue.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(87, 16);
            this.lblHeightValue.TabIndex = 6;
            this.lblHeightValue.Text = "HeightValue";
            this.lblHeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 328);
            this.label7.MinimumSize = new System.Drawing.Size(80, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Weight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 327);
            this.label8.MinimumSize = new System.Drawing.Size(80, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Height";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStardustValue
            // 
            this.lblStardustValue.AutoSize = true;
            this.lblStardustValue.Location = new System.Drawing.Point(27, 351);
            this.lblStardustValue.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblStardustValue.Name = "lblStardustValue";
            this.lblStardustValue.Size = new System.Drawing.Size(100, 12);
            this.lblStardustValue.TabIndex = 7;
            this.lblStardustValue.Text = "StardustValue";
            this.lblStardustValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 363);
            this.label10.MinimumSize = new System.Drawing.Size(100, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "Stardust";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCandyValue
            // 
            this.lblCandyValue.AutoSize = true;
            this.lblCandyValue.Location = new System.Drawing.Point(176, 351);
            this.lblCandyValue.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblCandyValue.Name = "lblCandyValue";
            this.lblCandyValue.Size = new System.Drawing.Size(100, 12);
            this.lblCandyValue.TabIndex = 7;
            this.lblCandyValue.Text = "CandyValue";
            this.lblCandyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCandy
            // 
            this.lblCandy.AutoSize = true;
            this.lblCandy.Location = new System.Drawing.Point(176, 363);
            this.lblCandy.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblCandy.Name = "lblCandy";
            this.lblCandy.Size = new System.Drawing.Size(100, 12);
            this.lblCandy.TabIndex = 7;
            this.lblCandy.Text = "Candy";
            this.lblCandy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPwStardust
            // 
            this.lblPwStardust.AutoSize = true;
            this.lblPwStardust.Location = new System.Drawing.Point(119, 398);
            this.lblPwStardust.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblPwStardust.Name = "lblPwStardust";
            this.lblPwStardust.Size = new System.Drawing.Size(80, 12);
            this.lblPwStardust.TabIndex = 7;
            this.lblPwStardust.Text = "PwStardust";
            this.lblPwStardust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPwCandy
            // 
            this.lblPwCandy.AutoSize = true;
            this.lblPwCandy.Location = new System.Drawing.Point(206, 398);
            this.lblPwCandy.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblPwCandy.Name = "lblPwCandy";
            this.lblPwCandy.Size = new System.Drawing.Size(80, 12);
            this.lblPwCandy.TabIndex = 7;
            this.lblPwCandy.Text = "PwCandy";
            this.lblPwCandy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEvCandy
            // 
            this.lblEvCandy.AutoSize = true;
            this.lblEvCandy.Location = new System.Drawing.Point(206, 425);
            this.lblEvCandy.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblEvCandy.Name = "lblEvCandy";
            this.lblEvCandy.Size = new System.Drawing.Size(80, 12);
            this.lblEvCandy.TabIndex = 7;
            this.lblEvCandy.Text = "EvCandy";
            this.lblEvCandy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Study\\296C#\\296CSHARP\\PokemonUi\\images\\Stardust_Icon.png";
            this.pictureBox1.Location = new System.Drawing.Point(98, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "D:\\Study\\296C#\\296CSHARP\\PokemonUi\\images\\Stardust_Icon.png";
            this.pictureBox2.Location = new System.Drawing.Point(12, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // imgCandy
            // 
            this.imgCandy.ImageLocation = "";
            this.imgCandy.Location = new System.Drawing.Point(140, 340);
            this.imgCandy.Name = "imgCandy";
            this.imgCandy.Size = new System.Drawing.Size(30, 44);
            this.imgCandy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCandy.TabIndex = 13;
            this.imgCandy.TabStop = false;
            // 
            // imgCandy2
            // 
            this.imgCandy2.ImageLocation = "";
            this.imgCandy2.Location = new System.Drawing.Point(187, 381);
            this.imgCandy2.Name = "imgCandy2";
            this.imgCandy2.Size = new System.Drawing.Size(30, 44);
            this.imgCandy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCandy2.TabIndex = 14;
            this.imgCandy2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(279, 134);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(5, 134);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(22, 23);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // PokemonUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 513);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.imgCandy2);
            this.Controls.Add(this.imgCandy);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblNameCht);
            this.Controls.Add(this.btnEvolve);
            this.Controls.Add(this.btnPowerUp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PokemonUi";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandy2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgCandy;
        private System.Windows.Forms.PictureBox imgCandy2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

