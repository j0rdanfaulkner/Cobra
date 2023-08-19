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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            pnlInfo = new Panel();
            lblDifficulty = new Label();
            tbrSpeed = new TrackBar();
            lblChangeSpeed = new Label();
            btnRestart = new Button();
            lblGameOver = new Label();
            lblScore = new Label();
            pnlGameArea = new Panel();
            pbxCanvas = new PictureBox();
            pbxBottomWall = new PictureBox();
            pbxTopWall = new PictureBox();
            pbxRightWall = new PictureBox();
            pbxLeftWall = new PictureBox();
            tmrTimer = new System.Windows.Forms.Timer(components);
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbrSpeed).BeginInit();
            pnlGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).BeginInit();
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
            pnlContainer.Font = new Font("Microsoft Sans Serif", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(734, 782);
            pnlContainer.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pnlInfo);
            pnlBottom.Dock = DockStyle.Top;
            pnlBottom.Location = new Point(0, 611);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(734, 171);
            pnlBottom.TabIndex = 2;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblDifficulty);
            pnlInfo.Controls.Add(tbrSpeed);
            pnlInfo.Controls.Add(lblChangeSpeed);
            pnlInfo.Controls.Add(btnRestart);
            pnlInfo.Controls.Add(lblGameOver);
            pnlInfo.Controls.Add(lblScore);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(734, 171);
            pnlInfo.TabIndex = 2;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(614, 120);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(154, 33);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "DEFAULT";
            lblDifficulty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbrSpeed
            // 
            tbrSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbrSpeed.BackColor = Color.Moccasin;
            tbrSpeed.Cursor = Cursors.Hand;
            tbrSpeed.Location = new Point(231, 124);
            tbrSpeed.Maximum = 45;
            tbrSpeed.Minimum = 1;
            tbrSpeed.Name = "tbrSpeed";
            tbrSpeed.RightToLeft = RightToLeft.Yes;
            tbrSpeed.Size = new Size(372, 45);
            tbrSpeed.SmallChange = 5;
            tbrSpeed.TabIndex = 5;
            tbrSpeed.TickFrequency = 3;
            tbrSpeed.Value = 1;
            tbrSpeed.Scroll += tbrSpeed_Scroll;
            tbrSpeed.KeyDown += tbrSpeed_KeyDown;
            tbrSpeed.KeyUp += tbrSpeed_KeyUp;
            // 
            // lblChangeSpeed
            // 
            lblChangeSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblChangeSpeed.AutoSize = true;
            lblChangeSpeed.Location = new Point(29, 120);
            lblChangeSpeed.Name = "lblChangeSpeed";
            lblChangeSpeed.Size = new Size(265, 33);
            lblChangeSpeed.TabIndex = 6;
            lblChangeSpeed.Text = "CHANGE SPEED:";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRestart.BackColor = Color.DarkOrange;
            btnRestart.Cursor = Cursors.Hand;
            btnRestart.FlatAppearance.BorderColor = Color.Peru;
            btnRestart.FlatAppearance.BorderSize = 3;
            btnRestart.Location = new Point(560, 23);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(150, 57);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "START";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.ForeColor = Color.DarkRed;
            lblGameOver.Location = new Point(291, 34);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(208, 33);
            lblGameOver.TabIndex = 1;
            lblGameOver.Text = "GAME OVER!";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblScore.AutoSize = true;
            lblScore.Location = new Point(29, 34);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(132, 33);
            lblScore.TabIndex = 0;
            lblScore.Text = "SCORE:";
            // 
            // pnlGameArea
            // 
            pnlGameArea.Controls.Add(pbxCanvas);
            pnlGameArea.Controls.Add(pbxBottomWall);
            pnlGameArea.Controls.Add(pbxTopWall);
            pnlGameArea.Controls.Add(pbxRightWall);
            pnlGameArea.Controls.Add(pbxLeftWall);
            pnlGameArea.Dock = DockStyle.Top;
            pnlGameArea.Location = new Point(0, 0);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(734, 611);
            pnlGameArea.TabIndex = 0;
            // 
            // pbxCanvas
            // 
            pbxCanvas.Dock = DockStyle.Fill;
            pbxCanvas.Location = new Point(15, 15);
            pbxCanvas.Name = "pbxCanvas";
            pbxCanvas.Size = new Size(704, 581);
            pbxCanvas.TabIndex = 4;
            pbxCanvas.TabStop = false;
            pbxCanvas.Paint += UpdateGraphics;
            // 
            // pbxBottomWall
            // 
            pbxBottomWall.BackColor = Color.DarkOrange;
            pbxBottomWall.Dock = DockStyle.Bottom;
            pbxBottomWall.Location = new Point(15, 596);
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
            pbxRightWall.Size = new Size(15, 611);
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
            pbxLeftWall.Size = new Size(15, 611);
            pbxLeftWall.TabIndex = 0;
            pbxLeftWall.TabStop = false;
            pbxLeftWall.Tag = "wall";
            // 
            // tmrTimer
            // 
            tmrTimer.Interval = 25;
            tmrTimer.Tick += GameTimerEvent;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 782);
            Controls.Add(pnlContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Cobra";
            KeyDown += MainWindow_KeyDown;
            KeyUp += MainWindow_KeyUp;
            Resize += MainWindow_Resize;
            pnlContainer.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbrSpeed).EndInit();
            pnlGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).EndInit();
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
        private System.Windows.Forms.Timer tmrTimer;
        private PictureBox pbxCanvas;
        private Button btnRestart;
        private Label lblChangeSpeed;
        private TrackBar tbrSpeed;
        private Label lblDifficulty;
    }
}