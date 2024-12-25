namespace FormCarGame
{
    partial class GameScene
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player1Slide = new System.Windows.Forms.ProgressBar();
            this.Player2Slide = new System.Windows.Forms.ProgressBar();
            this.Player1label = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player2label = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1Slide
            // 
            this.Player1Slide.Location = new System.Drawing.Point(12, 130);
            this.Player1Slide.Name = "Player1Slide";
            this.Player1Slide.Size = new System.Drawing.Size(223, 30);
            this.Player1Slide.TabIndex = 0;
            // 
            // Player2Slide
            // 
            this.Player2Slide.Location = new System.Drawing.Point(577, 130);
            this.Player2Slide.Name = "Player2Slide";
            this.Player2Slide.Size = new System.Drawing.Size(223, 30);
            this.Player2Slide.TabIndex = 1;
            // 
            // Player1label
            // 
            this.Player1label.AutoSize = true;
            this.Player1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Player1label.Location = new System.Drawing.Point(56, 207);
            this.Player1label.Name = "Player1label";
            this.Player1label.Size = new System.Drawing.Size(147, 29);
            this.Player1label.TabIndex = 2;
            this.Player1label.Text = "Player1label";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Player2label
            // 
            this.Player2label.AutoSize = true;
            this.Player2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Player2label.Location = new System.Drawing.Point(612, 207);
            this.Player2label.Name = "Player2label";
            this.Player2label.Size = new System.Drawing.Size(154, 29);
            this.Player2label.TabIndex = 3;
            this.Player2label.Text = "Player2Label";
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Player1Name.Location = new System.Drawing.Point(82, 87);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(94, 29);
            this.Player1Name.TabIndex = 4;
            this.Player1Name.Text = "Player1";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Player2Name.Location = new System.Drawing.Point(641, 87);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(94, 29);
            this.Player2Name.TabIndex = 5;
            this.Player2Name.Text = "Player2";
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Startbtn.Location = new System.Drawing.Point(297, 380);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(200, 60);
            this.Startbtn.TabIndex = 6;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 488);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player2label);
            this.Controls.Add(this.Player1label);
            this.Controls.Add(this.Player2Slide);
            this.Controls.Add(this.Player1Slide);
            this.Name = "GameScene";
            this.Text = "GameScene";
            this.Load += new System.EventHandler(this.GameScene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Player1Slide;
        private System.Windows.Forms.ProgressBar Player2Slide;
        private System.Windows.Forms.Label Player1label;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Player2label;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Button Startbtn;
    }
}

