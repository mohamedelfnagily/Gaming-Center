namespace games.SnakeGame
{
    partial class snakeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.myBoundries = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myBoundries)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(641, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(115, 86);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.HandlingGameStart);
            // 
            // myBoundries
            // 
            this.myBoundries.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myBoundries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myBoundries.Location = new System.Drawing.Point(12, 12);
            this.myBoundries.Name = "myBoundries";
            this.myBoundries.Size = new System.Drawing.Size(623, 693);
            this.myBoundries.TabIndex = 1;
            this.myBoundries.TabStop = false;
            this.myBoundries.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox);
            // 
            // myTimer
            // 
            this.myTimer.Interval = 40;
            this.myTimer.Tick += new System.EventHandler(this.HandlingTimerEvent);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.score.Location = new System.Drawing.Point(637, 129);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(74, 22);
            this.score.TabIndex = 2;
            this.score.Text = "score: 0";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.ForeColor = System.Drawing.Color.DarkOrange;
            this.highScore.Location = new System.Drawing.Point(637, 170);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(99, 22);
            this.highScore.TabIndex = 3;
            this.highScore.Text = "High Score";
            // 
            // snakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(768, 717);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.myBoundries);
            this.Controls.Add(this.startBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "snakeGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snakeGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.snakeGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandligKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlingKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.myBoundries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox myBoundries;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highScore;
    }
}