namespace ReactionTest
{
    partial class frmTest
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
            this.btnLight1 = new System.Windows.Forms.Button();
            this.btnLight2 = new System.Windows.Forms.Button();
            this.btnLight3 = new System.Windows.Forms.Button();
            this.lblButton1State = new System.Windows.Forms.Label();
            this.lblButton2State = new System.Windows.Forms.Label();
            this.lblButton3State = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLight1
            // 
            this.btnLight1.Location = new System.Drawing.Point(79, 52);
            this.btnLight1.Name = "btnLight1";
            this.btnLight1.Size = new System.Drawing.Size(75, 23);
            this.btnLight1.TabIndex = 0;
            this.btnLight1.Text = "Light #1";
            this.btnLight1.UseVisualStyleBackColor = true;
            this.btnLight1.Click += new System.EventHandler(this.btnLight1_Click);
            // 
            // btnLight2
            // 
            this.btnLight2.Location = new System.Drawing.Point(230, 52);
            this.btnLight2.Name = "btnLight2";
            this.btnLight2.Size = new System.Drawing.Size(75, 23);
            this.btnLight2.TabIndex = 1;
            this.btnLight2.Text = "Light 2";
            this.btnLight2.UseVisualStyleBackColor = true;
            this.btnLight2.Click += new System.EventHandler(this.btnLight2_Click);
            // 
            // btnLight3
            // 
            this.btnLight3.Location = new System.Drawing.Point(381, 52);
            this.btnLight3.Name = "btnLight3";
            this.btnLight3.Size = new System.Drawing.Size(75, 23);
            this.btnLight3.TabIndex = 2;
            this.btnLight3.Text = "Light 3";
            this.btnLight3.UseVisualStyleBackColor = true;
            this.btnLight3.Click += new System.EventHandler(this.btnLight3_Click);
            // 
            // lblButton1State
            // 
            this.lblButton1State.AutoSize = true;
            this.lblButton1State.Location = new System.Drawing.Point(100, 101);
            this.lblButton1State.Name = "lblButton1State";
            this.lblButton1State.Size = new System.Drawing.Size(27, 13);
            this.lblButton1State.TabIndex = 3;
            this.lblButton1State.Text = "OFF";
            // 
            // lblButton2State
            // 
            this.lblButton2State.AutoSize = true;
            this.lblButton2State.Location = new System.Drawing.Point(249, 101);
            this.lblButton2State.Name = "lblButton2State";
            this.lblButton2State.Size = new System.Drawing.Size(27, 13);
            this.lblButton2State.TabIndex = 4;
            this.lblButton2State.Text = "OFF";
            // 
            // lblButton3State
            // 
            this.lblButton3State.AutoSize = true;
            this.lblButton3State.Location = new System.Drawing.Point(398, 101);
            this.lblButton3State.Name = "lblButton3State";
            this.lblButton3State.Size = new System.Drawing.Size(27, 13);
            this.lblButton3State.TabIndex = 5;
            this.lblButton3State.Text = "OFF";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 206);
            this.Controls.Add(this.lblButton3State);
            this.Controls.Add(this.lblButton2State);
            this.Controls.Add(this.lblButton1State);
            this.Controls.Add(this.btnLight3);
            this.Controls.Add(this.btnLight2);
            this.Controls.Add(this.btnLight1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLight1;
        private System.Windows.Forms.Button btnLight2;
        private System.Windows.Forms.Button btnLight3;
        private System.Windows.Forms.Label lblButton1State;
        private System.Windows.Forms.Label lblButton2State;
        private System.Windows.Forms.Label lblButton3State;
        private System.Windows.Forms.Timer timer1;
    }
}