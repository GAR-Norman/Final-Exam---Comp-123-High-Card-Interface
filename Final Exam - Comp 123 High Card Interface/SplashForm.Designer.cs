namespace Final_Exam___Comp_123_High_Card_Interface
{
    partial class SplashForm
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
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashLabel = new System.Windows.Forms.Label();
            this.SplashPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashLabel
            // 
            this.SplashLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SplashLabel.Location = new System.Drawing.Point(89, 51);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(366, 90);
            this.SplashLabel.TabIndex = 0;
            this.SplashLabel.Text = "Welcome To the Highest Card Game";
            this.SplashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashPictureBox
            // 
            this.SplashPictureBox.BackgroundImage = global::Final_Exam___Comp_123_High_Card_Interface.Properties.Resources.card_clipart_cards_clip_art_8;
            this.SplashPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplashPictureBox.Location = new System.Drawing.Point(34, 168);
            this.SplashPictureBox.Name = "SplashPictureBox";
            this.SplashPictureBox.Size = new System.Drawing.Size(508, 221);
            this.SplashPictureBox.TabIndex = 1;
            this.SplashPictureBox.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.SplashPictureBox);
            this.Controls.Add(this.SplashLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.PictureBox SplashPictureBox;
    }
}