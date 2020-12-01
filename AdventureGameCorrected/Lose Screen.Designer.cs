
namespace AdventureGameCorrected
{
    partial class Lose_Screen
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
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblLoseText = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Location = new System.Drawing.Point(222, 129);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(100, 50);
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // lblLose
            // 
            this.lblLose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("SWGothe", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(84, 24);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(759, 102);
            this.lblLose.TabIndex = 1;
            this.lblLose.Text = "You Have Lost!";
            // 
            // lblLoseText
            // 
            this.lblLoseText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoseText.Font = new System.Drawing.Font("SWGothe", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoseText.Location = new System.Drawing.Point(84, 327);
            this.lblLoseText.Name = "lblLoseText";
            this.lblLoseText.Size = new System.Drawing.Size(759, 157);
            this.lblLoseText.TabIndex = 2;
            this.lblLoseText.Text = "Place Holder";
            this.lblLoseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgain
            // 
            this.lblAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgain.AutoSize = true;
            this.lblAgain.Font = new System.Drawing.Font("SWGothe", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgain.Location = new System.Drawing.Point(84, 171);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(585, 102);
            this.lblAgain.TabIndex = 3;
            this.lblAgain.Text = "Play Again?";
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.Font = new System.Drawing.Font("SWGothe", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.Location = new System.Drawing.Point(664, 171);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(108, 102);
            this.lblPlayAgain.TabIndex = 4;
            this.lblPlayAgain.Text = "Y";
            this.lblPlayAgain.Click += new System.EventHandler(this.lblPlayAgain_Click);
            this.lblPlayAgain.MouseLeave += new System.EventHandler(this.lblPlayAgain_MouseLeave);
            this.lblPlayAgain.MouseHover += new System.EventHandler(this.lblPlayAgain_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SWGothe", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 102);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("SWGothe", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(828, 171);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(114, 102);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "N";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // Lose_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 493);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.lblLoseText);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.pbBackground);
            this.Name = "Lose_Screen";
            this.Text = "Lose Screen";
            this.Load += new System.EventHandler(this.Lose_Screen_Load);
            this.SizeChanged += new System.EventHandler(this.Lose_Screen_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblLoseText;
        private System.Windows.Forms.Label lblAgain;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExit;
    }
}