namespace games
{
    partial class mainPage
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
            this.snakeBtn = new System.Windows.Forms.Button();
            this.snakeLaderBtn = new System.Windows.Forms.Button();
            this.breakOutBtn = new System.Windows.Forms.Button();
            this.TicTacBtn = new System.Windows.Forms.Button();
            this.zombieLandBtn = new System.Windows.Forms.Button();
            this.flyingBirdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snakeBtn
            // 
            this.snakeBtn.BackgroundImage = global::games.Properties.Resources.snakeGame;
            this.snakeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snakeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snakeBtn.Location = new System.Drawing.Point(446, 231);
            this.snakeBtn.Name = "snakeBtn";
            this.snakeBtn.Size = new System.Drawing.Size(211, 213);
            this.snakeBtn.TabIndex = 6;
            this.snakeBtn.UseVisualStyleBackColor = true;
            this.snakeBtn.Click += new System.EventHandler(this.snakeBtn_Click);
            // 
            // snakeLaderBtn
            // 
            this.snakeLaderBtn.BackgroundImage = global::games.Properties.Resources.snake_ladder;
            this.snakeLaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snakeLaderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snakeLaderBtn.Location = new System.Drawing.Point(229, 231);
            this.snakeLaderBtn.Name = "snakeLaderBtn";
            this.snakeLaderBtn.Size = new System.Drawing.Size(211, 213);
            this.snakeLaderBtn.TabIndex = 5;
            this.snakeLaderBtn.UseVisualStyleBackColor = true;
            this.snakeLaderBtn.Click += new System.EventHandler(this.snakeLaderBtn_Click);
            // 
            // breakOutBtn
            // 
            this.breakOutBtn.BackgroundImage = global::games.Properties.Resources.breakout;
            this.breakOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.breakOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breakOutBtn.Location = new System.Drawing.Point(12, 231);
            this.breakOutBtn.Name = "breakOutBtn";
            this.breakOutBtn.Size = new System.Drawing.Size(211, 213);
            this.breakOutBtn.TabIndex = 4;
            this.breakOutBtn.UseVisualStyleBackColor = true;
            this.breakOutBtn.Click += new System.EventHandler(this.breakOutBtn_Click);
            // 
            // TicTacBtn
            // 
            this.TicTacBtn.BackgroundImage = global::games.Properties.Resources.TicTac;
            this.TicTacBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicTacBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicTacBtn.Location = new System.Drawing.Point(446, 12);
            this.TicTacBtn.Name = "TicTacBtn";
            this.TicTacBtn.Size = new System.Drawing.Size(211, 213);
            this.TicTacBtn.TabIndex = 2;
            this.TicTacBtn.UseVisualStyleBackColor = true;
            this.TicTacBtn.Click += new System.EventHandler(this.TicTacBtn_Click);
            // 
            // zombieLandBtn
            // 
            this.zombieLandBtn.BackgroundImage = global::games.Properties.Resources.zombie;
            this.zombieLandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zombieLandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zombieLandBtn.Location = new System.Drawing.Point(229, 12);
            this.zombieLandBtn.Name = "zombieLandBtn";
            this.zombieLandBtn.Size = new System.Drawing.Size(211, 213);
            this.zombieLandBtn.TabIndex = 1;
            this.zombieLandBtn.UseVisualStyleBackColor = true;
            this.zombieLandBtn.Click += new System.EventHandler(this.zombieLandBtn_Click);
            // 
            // flyingBirdBtn
            // 
            this.flyingBirdBtn.BackgroundImage = global::games.Properties.Resources.flyingBird;
            this.flyingBirdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flyingBirdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flyingBirdBtn.Location = new System.Drawing.Point(12, 12);
            this.flyingBirdBtn.Name = "flyingBirdBtn";
            this.flyingBirdBtn.Size = new System.Drawing.Size(211, 213);
            this.flyingBirdBtn.TabIndex = 0;
            this.flyingBirdBtn.UseVisualStyleBackColor = true;
            this.flyingBirdBtn.Click += new System.EventHandler(this.flyingBirdBtn_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.snakeBtn);
            this.Controls.Add(this.snakeLaderBtn);
            this.Controls.Add(this.breakOutBtn);
            this.Controls.Add(this.TicTacBtn);
            this.Controls.Add(this.zombieLandBtn);
            this.Controls.Add(this.flyingBirdBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaming Center";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flyingBirdBtn;
        private System.Windows.Forms.Button zombieLandBtn;
        private System.Windows.Forms.Button TicTacBtn;
        private System.Windows.Forms.Button snakeBtn;
        private System.Windows.Forms.Button snakeLaderBtn;
        private System.Windows.Forms.Button breakOutBtn;
    }
}