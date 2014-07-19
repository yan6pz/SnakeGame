namespace GameTrial
{
    partial class GameEngine
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
            this.TheTime = new System.Windows.Forms.Timer(this.components);
            this.snakeScoreLabel = new System.Windows.Forms.Label();
            this.spaceBarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TheTime
            // 
            this.TheTime.Interval = 150;
            this.TheTime.Tick += new System.EventHandler(this.TheTime_Tick);
            // 
            // snakeScoreLabel
            // 
            this.snakeScoreLabel.AutoSize = true;
            this.snakeScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.snakeScoreLabel.Location = new System.Drawing.Point(1, 0);
            this.snakeScoreLabel.Name = "snakeScoreLabel";
            this.snakeScoreLabel.Size = new System.Drawing.Size(60, 24);
            this.snakeScoreLabel.TabIndex = 0;
            this.snakeScoreLabel.Text = "Score";
            // 
            // spaceBarLabel
            // 
            this.spaceBarLabel.AutoSize = true;
            this.spaceBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.spaceBarLabel.Location = new System.Drawing.Point(321, 181);
            this.spaceBarLabel.Name = "spaceBarLabel";
            this.spaceBarLabel.Size = new System.Drawing.Size(134, 46);
            this.spaceBarLabel.TabIndex = 1;
            this.spaceBarLabel.Text = "Space";
            // 
            // GameEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.spaceBarLabel);
            this.Controls.Add(this.snakeScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameEngine_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameEngine_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameEngine_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TheTime;
        private System.Windows.Forms.Label snakeScoreLabel;
        private System.Windows.Forms.Label spaceBarLabel;
    }
}

