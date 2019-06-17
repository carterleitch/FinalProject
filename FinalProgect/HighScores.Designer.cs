namespace FinalProgect
{
    partial class HighScores
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
            this.HighscoreExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HighscoreExitButton
            // 
            this.HighscoreExitButton.BackColor = System.Drawing.Color.White;
            this.HighscoreExitButton.Location = new System.Drawing.Point(31, 71);
            this.HighscoreExitButton.Name = "HighscoreExitButton";
            this.HighscoreExitButton.Size = new System.Drawing.Size(141, 63);
            this.HighscoreExitButton.TabIndex = 0;
            this.HighscoreExitButton.Text = "Main Menu";
            this.HighscoreExitButton.UseVisualStyleBackColor = false;
            this.HighscoreExitButton.Click += new System.EventHandler(this.HighscoreExitButton_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.HighscoreExitButton);
            this.Name = "HighScores";
            this.Size = new System.Drawing.Size(200, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighscoreExitButton;
    }
}
