namespace FinalProgect
{
    partial class PauseScreen
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
            this.exitGame = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(166, 61);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(75, 23);
            this.exitGame.TabIndex = 0;
            this.exitGame.Text = "Exit";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.Location = new System.Drawing.Point(166, 129);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(75, 23);
            this.resumeGame.TabIndex = 1;
            this.resumeGame.Text = "Resume";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.exitGame);
            this.Name = "PauseScreen";
            this.Size = new System.Drawing.Size(460, 292);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button resumeGame;
    }
}
