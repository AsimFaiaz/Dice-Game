namespace AsimWonjunAssgt
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.txtBxPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtBxPlayer2Name = new System.Windows.Forms.TextBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.lblCongo = new System.Windows.Forms.Label();
            this.lblTossName = new System.Windows.Forms.Label();
            this.lblTossName2 = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.rdoBtnPlayWithAI = new System.Windows.Forms.RadioButton();
            this.lblChooseMode = new System.Windows.Forms.Label();
            this.rdoBtnPlayWithMate = new System.Windows.Forms.RadioButton();
            this.lblGoal = new System.Windows.Forms.Label();
            this.numericUpDownGoal = new System.Windows.Forms.NumericUpDown();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRules2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInsertNames = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTimerToss = new System.Windows.Forms.Label();
            this.lblAIinstruction = new System.Windows.Forms.Label();
            this.lblMateInstruction = new System.Windows.Forms.Label();
            this.lblPlayer1AIinstruction = new System.Windows.Forms.Label();
            this.lblAISetGoalInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Enabled = false;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(610, 150);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(99, 25);
            this.lblPlayer1Name.TabIndex = 3;
            this.lblPlayer1Name.Text = "Player 1";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Enabled = false;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.Location = new System.Drawing.Point(610, 191);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(99, 25);
            this.lblPlayer2Name.TabIndex = 4;
            this.lblPlayer2Name.Text = "Player 2";
            // 
            // txtBxPlayer1Name
            // 
            this.txtBxPlayer1Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxPlayer1Name.Enabled = false;
            this.txtBxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPlayer1Name.Location = new System.Drawing.Point(715, 152);
            this.txtBxPlayer1Name.Multiline = true;
            this.txtBxPlayer1Name.Name = "txtBxPlayer1Name";
            this.txtBxPlayer1Name.Size = new System.Drawing.Size(158, 26);
            this.txtBxPlayer1Name.TabIndex = 5;
            this.txtBxPlayer1Name.TextChanged += new System.EventHandler(this.txtBxPlayer1Name_TextChanged);
            // 
            // txtBxPlayer2Name
            // 
            this.txtBxPlayer2Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxPlayer2Name.Enabled = false;
            this.txtBxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPlayer2Name.Location = new System.Drawing.Point(715, 190);
            this.txtBxPlayer2Name.Multiline = true;
            this.txtBxPlayer2Name.Name = "txtBxPlayer2Name";
            this.txtBxPlayer2Name.Size = new System.Drawing.Size(158, 26);
            this.txtBxPlayer2Name.TabIndex = 6;
            // 
            // btnToss
            // 
            this.btnToss.BackColor = System.Drawing.Color.White;
            this.btnToss.Enabled = false;
            this.btnToss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToss.Location = new System.Drawing.Point(715, 235);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(158, 35);
            this.btnToss.TabIndex = 7;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = false;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lblCongo
            // 
            this.lblCongo.AutoSize = true;
            this.lblCongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongo.Location = new System.Drawing.Point(16, 445);
            this.lblCongo.Name = "lblCongo";
            this.lblCongo.Size = new System.Drawing.Size(101, 25);
            this.lblCongo.TabIndex = 8;
            this.lblCongo.Text = "Goal Set:";
            this.lblCongo.Visible = false;
            // 
            // lblTossName
            // 
            this.lblTossName.AutoSize = true;
            this.lblTossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTossName.Location = new System.Drawing.Point(170, 445);
            this.lblTossName.Name = "lblTossName";
            this.lblTossName.Size = new System.Drawing.Size(72, 25);
            this.lblTossName.TabIndex = 10;
            this.lblTossName.Text = "Name";
            this.lblTossName.Visible = false;
            // 
            // lblTossName2
            // 
            this.lblTossName2.AutoSize = true;
            this.lblTossName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTossName2.Location = new System.Drawing.Point(170, 488);
            this.lblTossName2.Name = "lblTossName2";
            this.lblTossName2.Size = new System.Drawing.Size(72, 25);
            this.lblTossName2.TabIndex = 12;
            this.lblTossName2.Text = "Name";
            this.lblTossName2.Visible = false;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(16, 488);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(126, 25);
            this.lblStartGame.TabIndex = 13;
            this.lblStartGame.Text = "Start Game:";
            this.lblStartGame.Visible = false;
            // 
            // rdoBtnPlayWithAI
            // 
            this.rdoBtnPlayWithAI.AutoSize = true;
            this.rdoBtnPlayWithAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnPlayWithAI.Location = new System.Drawing.Point(20, 152);
            this.rdoBtnPlayWithAI.Name = "rdoBtnPlayWithAI";
            this.rdoBtnPlayWithAI.Size = new System.Drawing.Size(153, 29);
            this.rdoBtnPlayWithAI.TabIndex = 14;
            this.rdoBtnPlayWithAI.TabStop = true;
            this.rdoBtnPlayWithAI.Text = "Play with AI";
            this.rdoBtnPlayWithAI.UseVisualStyleBackColor = true;
            this.rdoBtnPlayWithAI.CheckedChanged += new System.EventHandler(this.rdoBtnPlayWithAI_CheckedChanged);
            // 
            // lblChooseMode
            // 
            this.lblChooseMode.AutoSize = true;
            this.lblChooseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseMode.Location = new System.Drawing.Point(14, 98);
            this.lblChooseMode.Name = "lblChooseMode";
            this.lblChooseMode.Size = new System.Drawing.Size(196, 33);
            this.lblChooseMode.TabIndex = 15;
            this.lblChooseMode.Text = "Select Mode:";
            // 
            // rdoBtnPlayWithMate
            // 
            this.rdoBtnPlayWithMate.AutoSize = true;
            this.rdoBtnPlayWithMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnPlayWithMate.Location = new System.Drawing.Point(20, 191);
            this.rdoBtnPlayWithMate.Name = "rdoBtnPlayWithMate";
            this.rdoBtnPlayWithMate.Size = new System.Drawing.Size(184, 29);
            this.rdoBtnPlayWithMate.TabIndex = 16;
            this.rdoBtnPlayWithMate.TabStop = true;
            this.rdoBtnPlayWithMate.Text = "Play with Mate";
            this.rdoBtnPlayWithMate.UseVisualStyleBackColor = true;
            this.rdoBtnPlayWithMate.CheckedChanged += new System.EventHandler(this.rdoBtnPlayWithMate_CheckedChanged);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Enabled = false;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(539, 478);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(170, 25);
            this.lblGoal.TabIndex = 17;
            this.lblGoal.Text = "Select the goal";
            // 
            // numericUpDownGoal
            // 
            this.numericUpDownGoal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numericUpDownGoal.Enabled = false;
            this.numericUpDownGoal.Location = new System.Drawing.Point(715, 478);
            this.numericUpDownGoal.Name = "numericUpDownGoal";
            this.numericUpDownGoal.Size = new System.Drawing.Size(158, 20);
            this.numericUpDownGoal.TabIndex = 18;
            this.numericUpDownGoal.ValueChanged += new System.EventHandler(this.numericUpDownGoal_ValueChanged);
            this.numericUpDownGoal.Enter += new System.EventHandler(this.numericUpDownGoal_Enter);
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLetsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetsPlay.Location = new System.Drawing.Point(544, 624);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(209, 70);
            this.btnLetsPlay.TabIndex = 21;
            this.btnLetsPlay.Text = "Let\'s Play";
            this.btnLetsPlay.UseVisualStyleBackColor = false;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1158, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(924, 320);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(119, 42);
            this.lblRules.TabIndex = 23;
            this.lblRules.Text = "Rules\r\n";
            // 
            // lblRules2
            // 
            this.lblRules2.AutoSize = true;
            this.lblRules2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules2.Location = new System.Drawing.Point(927, 374);
            this.lblRules2.Name = "lblRules2";
            this.lblRules2.Size = new System.Drawing.Size(451, 280);
            this.lblRules2.TabIndex = 24;
            this.lblRules2.Text = resources.GetString("lblRules2.Text");
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(408, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(377, 42);
            this.lblWelcome.TabIndex = 25;
            this.lblWelcome.Text = "Welcome to GROAN";
            // 
            // lblInsertNames
            // 
            this.lblInsertNames.AutoSize = true;
            this.lblInsertNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertNames.Location = new System.Drawing.Point(609, 98);
            this.lblInsertNames.Name = "lblInsertNames";
            this.lblInsertNames.Size = new System.Drawing.Size(345, 33);
            this.lblInsertNames.TabIndex = 26;
            this.lblInsertNames.Text = "Insert Names and Goal:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(14, 402);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(113, 33);
            this.lblResult.TabIndex = 27;
            this.lblResult.Text = "Result:";
            // 
            // lblTimerToss
            // 
            this.lblTimerToss.AutoSize = true;
            this.lblTimerToss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerToss.ForeColor = System.Drawing.Color.Black;
            this.lblTimerToss.Location = new System.Drawing.Point(593, 293);
            this.lblTimerToss.Name = "lblTimerToss";
            this.lblTimerToss.Size = new System.Drawing.Size(355, 25);
            this.lblTimerToss.TabIndex = 28;
            this.lblTimerToss.Text = "Set the Goal or Try again to toss";
            this.lblTimerToss.Visible = false;
            // 
            // lblAIinstruction
            // 
            this.lblAIinstruction.AutoSize = true;
            this.lblAIinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIinstruction.ForeColor = System.Drawing.Color.Black;
            this.lblAIinstruction.Location = new System.Drawing.Point(12, 345);
            this.lblAIinstruction.Name = "lblAIinstruction";
            this.lblAIinstruction.Size = new System.Drawing.Size(625, 25);
            this.lblAIinstruction.TabIndex = 29;
            this.lblAIinstruction.Text = "AI Instruction: Put Player 1 Name and Proceed to Set Goal";
            this.lblAIinstruction.Visible = false;
            // 
            // lblMateInstruction
            // 
            this.lblMateInstruction.AutoSize = true;
            this.lblMateInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateInstruction.ForeColor = System.Drawing.Color.Black;
            this.lblMateInstruction.Location = new System.Drawing.Point(12, 370);
            this.lblMateInstruction.Name = "lblMateInstruction";
            this.lblMateInstruction.Size = new System.Drawing.Size(697, 25);
            this.lblMateInstruction.TabIndex = 30;
            this.lblMateInstruction.Text = "Mate Instruction: Fill all the Empty fields and Proceed to set Goal";
            this.lblMateInstruction.Visible = false;
            // 
            // lblPlayer1AIinstruction
            // 
            this.lblPlayer1AIinstruction.AutoSize = true;
            this.lblPlayer1AIinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1AIinstruction.Location = new System.Drawing.Point(879, 150);
            this.lblPlayer1AIinstruction.Name = "lblPlayer1AIinstruction";
            this.lblPlayer1AIinstruction.Size = new System.Drawing.Size(241, 25);
            this.lblPlayer1AIinstruction.TabIndex = 31;
            this.lblPlayer1AIinstruction.Text = "Please enter name here";
            this.lblPlayer1AIinstruction.Visible = false;
            // 
            // lblAISetGoalInstruction
            // 
            this.lblAISetGoalInstruction.AutoSize = true;
            this.lblAISetGoalInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAISetGoalInstruction.Location = new System.Drawing.Point(879, 186);
            this.lblAISetGoalInstruction.Name = "lblAISetGoalInstruction";
            this.lblAISetGoalInstruction.Size = new System.Drawing.Size(268, 25);
            this.lblAISetGoalInstruction.TabIndex = 32;
            this.lblAISetGoalInstruction.Text = "Please proceed to set goal";
            this.lblAISetGoalInstruction.Visible = false;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1379, 749);
            this.Controls.Add(this.lblAISetGoalInstruction);
            this.Controls.Add(this.lblPlayer1AIinstruction);
            this.Controls.Add(this.lblMateInstruction);
            this.Controls.Add(this.lblAIinstruction);
            this.Controls.Add(this.lblTimerToss);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInsertNames);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblRules2);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.numericUpDownGoal);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.rdoBtnPlayWithMate);
            this.Controls.Add(this.lblChooseMode);
            this.Controls.Add(this.rdoBtnPlayWithAI);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.lblTossName2);
            this.Controls.Add(this.lblTossName);
            this.Controls.Add(this.lblCongo);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.txtBxPlayer2Name);
            this.Controls.Add(this.txtBxPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.TextBox txtBxPlayer1Name;
        private System.Windows.Forms.TextBox txtBxPlayer2Name;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Label lblCongo;
        private System.Windows.Forms.Label lblTossName;
        private System.Windows.Forms.Label lblTossName2;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.RadioButton rdoBtnPlayWithAI;
        private System.Windows.Forms.Label lblChooseMode;
        private System.Windows.Forms.RadioButton rdoBtnPlayWithMate;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.NumericUpDown numericUpDownGoal;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRules2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInsertNames;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTimerToss;
        private System.Windows.Forms.Label lblAIinstruction;
        private System.Windows.Forms.Label lblMateInstruction;
        private System.Windows.Forms.Label lblPlayer1AIinstruction;
        private System.Windows.Forms.Label lblAISetGoalInstruction;
    }
}

