namespace Cobra
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            pnlInfo = new Panel();
            lblGameOver = new Label();
            lblScore = new Label();
            pnlGameArea = new Panel();
            pbxBottomWall = new PictureBox();
            pbxTopWall = new PictureBox();
            pbxRightWall = new PictureBox();
            pbxLeftWall = new PictureBox();
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBottomWall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTopWall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRightWall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLeftWall).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Moccasin;
            pnlContainer.Controls.Add(pnlBottom);
            pnlContainer.Controls.Add(pnlGameArea);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Font = new Font("EurostileLTW03-BoldCond", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(734, 711);
            pnlContainer.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pnlInfo);
            pnlBottom.Dock = DockStyle.Top;
            pnlBottom.Location = new Point(0, 500);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(734, 212);
            pnlBottom.TabIndex = 2;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblGameOver);
            pnlInfo.Controls.Add(lblScore);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(734, 212);
            pnlInfo.TabIndex = 2;
            // 
            // lblGameOver
            // 
            lblGameOver.Anchor = AnchorStyles.None;
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.ForeColor = Color.DarkRed;
            lblGameOver.Location = new Point(291, 89);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(153, 35);
            lblGameOver.TabIndex = 1;
            lblGameOver.Text = "GAME OVER!";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.None;
            lblScore.AutoSize = true;
            lblScore.Location = new Point(24, 21);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(95, 35);
            lblScore.TabIndex = 0;
            lblScore.Text = "SCORE:";
            // 
            // pnlGameArea
            // 
            pnlGameArea.Controls.Add(pbxBottomWall);
            pnlGameArea.Controls.Add(pbxTopWall);
            pnlGameArea.Controls.Add(pbxRightWall);
            pnlGameArea.Controls.Add(pbxLeftWall);
            pnlGameArea.Dock = DockStyle.Top;
            pnlGameArea.Location = new Point(0, 0);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(734, 500);
            pnlGameArea.TabIndex = 0;
            // 
            // pbxBottomWall
            // 
            pbxBottomWall.BackColor = Color.DarkOrange;
            pbxBottomWall.Dock = DockStyle.Bottom;
            pbxBottomWall.Location = new Point(15, 485);
            pbxBottomWall.Name = "pbxBottomWall";
            pbxBottomWall.Size = new Size(704, 15);
            pbxBottomWall.TabIndex = 3;
            pbxBottomWall.TabStop = false;
            pbxBottomWall.Tag = "wall";
            // 
            // pbxTopWall
            // 
            pbxTopWall.BackColor = Color.DarkOrange;
            pbxTopWall.Dock = DockStyle.Top;
            pbxTopWall.Location = new Point(15, 0);
            pbxTopWall.Name = "pbxTopWall";
            pbxTopWall.Size = new Size(704, 15);
            pbxTopWall.TabIndex = 2;
            pbxTopWall.TabStop = false;
            pbxTopWall.Tag = "wall";
            // 
            // pbxRightWall
            // 
            pbxRightWall.BackColor = Color.DarkOrange;
            pbxRightWall.Dock = DockStyle.Right;
            pbxRightWall.Location = new Point(719, 0);
            pbxRightWall.Name = "pbxRightWall";
            pbxRightWall.Size = new Size(15, 500);
            pbxRightWall.TabIndex = 1;
            pbxRightWall.TabStop = false;
            pbxRightWall.Tag = "wall";
            // 
            // pbxLeftWall
            // 
            pbxLeftWall.BackColor = Color.DarkOrange;
            pbxLeftWall.Dock = DockStyle.Left;
            pbxLeftWall.Location = new Point(0, 0);
            pbxLeftWall.Name = "pbxLeftWall";
            pbxLeftWall.Size = new Size(15, 500);
            pbxLeftWall.TabIndex = 0;
            pbxLeftWall.TabStop = false;
            pbxLeftWall.Tag = "wall";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 711);
            Controls.Add(pnlContainer);
            Name = "MainWindow";
            Text = "Cobra";
            pnlContainer.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxBottomWall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTopWall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRightWall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLeftWall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlGameArea;
        private PictureBox pbxBottomWall;
        private PictureBox pbxTopWall;
        private PictureBox pbxRightWall;
        private PictureBox pbxLeftWall;
        private Panel pnlBottom;
        private Label lblGameOver;
        private Label lblScore;
        private Panel pnlInfo;
    }
}