namespace ReactionTest
{
    partial class Form1
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactionsTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEbugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDebugscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbllblGood = new System.Windows.Forms.Label();
            this.lbllblError = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gentagRækkefølgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 32);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(277, 173);
            this.txtLog.TabIndex = 3;
            this.txtLog.WordWrap = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Location = new System.Drawing.Point(332, 205);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 44);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnStopGame
            // 
            this.btnStopGame.Enabled = false;
            this.btnStopGame.Location = new System.Drawing.Point(423, 205);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(83, 44);
            this.btnStopGame.TabIndex = 6;
            this.btnStopGame.Text = "STOP";
            this.btnStopGame.UseVisualStyleBackColor = true;
            this.btnStopGame.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTxt.Location = new System.Drawing.Point(390, 32);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(100, 37);
            this.lblScoreTxt.TabIndex = 7;
            this.lblScoreTxt.Text = "Score";
            // 
            // lblErrors
            // 
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.Location = new System.Drawing.Point(450, 94);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(103, 70);
            this.lblErrors.TabIndex = 8;
            this.lblErrors.Text = "0";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Location = new System.Drawing.Point(481, 164);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(34, 13);
            this.lblAverageTime.TabIndex = 9;
            this.lblAverageTime.Text = "0.000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.dEbugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reactionsTestToolStripMenuItem,
            this.gentagRækkefølgenToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.gameToolStripMenuItem.Text = "Spil";
            // 
            // reactionsTestToolStripMenuItem
            // 
            this.reactionsTestToolStripMenuItem.Name = "reactionsTestToolStripMenuItem";
            this.reactionsTestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reactionsTestToolStripMenuItem.Text = "Tryk på den der lyser";
            this.reactionsTestToolStripMenuItem.Click += new System.EventHandler(this.reactionsTestToolStripMenuItem_Click);
            // 
            // dEbugToolStripMenuItem
            // 
            this.dEbugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDebugscreenToolStripMenuItem});
            this.dEbugToolStripMenuItem.Name = "dEbugToolStripMenuItem";
            this.dEbugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dEbugToolStripMenuItem.Text = "Debug";
            // 
            // openDebugscreenToolStripMenuItem
            // 
            this.openDebugscreenToolStripMenuItem.Name = "openDebugscreenToolStripMenuItem";
            this.openDebugscreenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openDebugscreenToolStripMenuItem.Text = "Open debugscreen";
            this.openDebugscreenToolStripMenuItem.Click += new System.EventHandler(this.openDebugscreenToolStripMenuItem_Click);
            // 
            // lbllblGood
            // 
            this.lbllblGood.AutoSize = true;
            this.lbllblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblGood.Location = new System.Drawing.Point(364, 69);
            this.lbllblGood.Name = "lbllblGood";
            this.lbllblGood.Size = new System.Drawing.Size(52, 25);
            this.lbllblGood.TabIndex = 11;
            this.lbllblGood.Text = "God";
            // 
            // lbllblError
            // 
            this.lbllblError.AutoSize = true;
            this.lbllblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblError.Location = new System.Drawing.Point(492, 69);
            this.lbllblError.Name = "lbllblError";
            this.lbllblError.Size = new System.Drawing.Size(47, 25);
            this.lbllblError.TabIndex = 12;
            this.lbllblError.Text = "Fejl";
            // 
            // lblGood
            // 
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.Location = new System.Drawing.Point(322, 94);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(109, 70);
            this.lblGood.TabIndex = 14;
            this.lblGood.Text = "0";
            this.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gennemsnits svartid i millisekunder";
            // 
            // gentagRækkefølgenToolStripMenuItem
            // 
            this.gentagRækkefølgenToolStripMenuItem.Name = "gentagRækkefølgenToolStripMenuItem";
            this.gentagRækkefølgenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gentagRækkefølgenToolStripMenuItem.Text = "Gentag rækkefølgen";
            this.gentagRækkefølgenToolStripMenuItem.Click += new System.EventHandler(this.gentagRækkefølgenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lbllblError);
            this.Controls.Add(this.lbllblGood);
            this.Controls.Add(this.lblAverageTime);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.btnStopGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEbugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDebugscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reactionsTestToolStripMenuItem;
        private System.Windows.Forms.Label lbllblGood;
        private System.Windows.Forms.Label lbllblError;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem gentagRækkefølgenToolStripMenuItem;
    }
}

