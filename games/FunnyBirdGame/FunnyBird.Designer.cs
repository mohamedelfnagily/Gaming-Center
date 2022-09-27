namespace games.FunnyBirdGame
{
    partial class FunnyBird
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
            this.myScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.retry = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.exitApp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // myScore
            // 
            this.myScore.AutoSize = true;
            this.myScore.BackColor = System.Drawing.Color.NavajoWhite;
            this.myScore.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myScore.Location = new System.Drawing.Point(12, 630);
            this.myScore.Name = "myScore";
            this.myScore.Size = new System.Drawing.Size(128, 33);
            this.myScore.TabIndex = 4;
            this.myScore.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 135);
            this.label1.TabIndex = 5;
            this.label1.Text = "3";
            // 
            // retry
            // 
            this.retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retry.Image = global::games.Properties.Resources.retry;
            this.retry.Location = new System.Drawing.Point(190, 90);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(64, 63);
            this.retry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retry.TabIndex = 6;
            this.retry.TabStop = false;
            this.retry.Visible = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // topPipe
            // 
            this.topPipe.Image = global::games.Properties.Resources.pipedown;
            this.topPipe.Location = new System.Drawing.Point(437, 0);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(100, 203);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 3;
            this.topPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::games.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-2, 590);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(616, 93);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.Image = global::games.Properties.Resources.pipe;
            this.bottomPipe.Location = new System.Drawing.Point(276, 339);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(100, 286);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe.TabIndex = 1;
            this.bottomPipe.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::games.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(27, 201);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(62, 55);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // exitApp
            // 
            this.exitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitApp.Image = global::games.Properties.Resources.close;
            this.exitApp.Location = new System.Drawing.Point(276, 90);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(75, 63);
            this.exitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitApp.TabIndex = 7;
            this.exitApp.TabStop = false;
            this.exitApp.Visible = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Press Space button to fly";
            // 
            // FunnyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(612, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myScore);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.bird);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FunnyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunnyBird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FunnyBird_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.retry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.Label myScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox retry;
        private System.Windows.Forms.PictureBox exitApp;
        private System.Windows.Forms.Label label2;
    }
}