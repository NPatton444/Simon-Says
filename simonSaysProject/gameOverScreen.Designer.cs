namespace simonSaysProject
{
    partial class gameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(190, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 38);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Game Over";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.BackColor = System.Drawing.Color.DimGray;
            this.scoreLabel2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel2.ForeColor = System.Drawing.Color.White;
            this.scoreLabel2.Location = new System.Drawing.Point(227, 249);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(0, 25);
            this.scoreLabel2.TabIndex = 2;
            this.scoreLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // replayButton
            // 
            this.replayButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.Location = new System.Drawing.Point(220, 276);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(147, 38);
            this.replayButton.TabIndex = 3;
            this.replayButton.Text = "Play Again?";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(250, 320);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(85, 38);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.titleLabel);
            this.Name = "gameOverScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button closeButton;
    }
}
