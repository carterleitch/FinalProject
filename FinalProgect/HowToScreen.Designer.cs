namespace FinalProgect
{
    partial class HowToScreen
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
            this.howtoExit = new System.Windows.Forms.Button();
            this.howtoPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // howtoExit
            // 
            this.howtoExit.BackColor = System.Drawing.Color.White;
            this.howtoExit.Location = new System.Drawing.Point(52, 159);
            this.howtoExit.Name = "howtoExit";
            this.howtoExit.Size = new System.Drawing.Size(141, 63);
            this.howtoExit.TabIndex = 1;
            this.howtoExit.Text = "Main Menu";
            this.howtoExit.UseVisualStyleBackColor = false;
            this.howtoExit.Click += new System.EventHandler(this.howtoExit_Click);
            // 
            // howtoPlay
            // 
            this.howtoPlay.BackColor = System.Drawing.Color.White;
            this.howtoPlay.Location = new System.Drawing.Point(397, 159);
            this.howtoPlay.Name = "howtoPlay";
            this.howtoPlay.Size = new System.Drawing.Size(141, 63);
            this.howtoPlay.TabIndex = 2;
            this.howtoPlay.Text = "Play";
            this.howtoPlay.UseVisualStyleBackColor = false;
            this.howtoPlay.Click += new System.EventHandler(this.howtoPlay_Click);
            // 
            // HowToScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.howtoPlay);
            this.Controls.Add(this.howtoExit);
            this.Name = "HowToScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button howtoExit;
        private System.Windows.Forms.Button howtoPlay;
    }
}
