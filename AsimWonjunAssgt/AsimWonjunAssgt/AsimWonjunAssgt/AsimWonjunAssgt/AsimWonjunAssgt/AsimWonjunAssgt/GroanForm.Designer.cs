namespace AsimWonjunAssgt
{
    partial class frmGroan
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
            this.lblGameFormPlayer1Name = new System.Windows.Forms.Label();
            this.lblGameFormPlayer2Name = new System.Windows.Forms.Label();
            this.lblRunningScorePlayer1 = new System.Windows.Forms.Label();
            this.lblCumulativeScorePlayer1 = new System.Windows.Forms.Label();
            this.lblRunningScorePlayer2 = new System.Windows.Forms.Label();
            this.lblCumulativeScorePlayer2 = new System.Windows.Forms.Label();
            this.picBxDice1 = new System.Windows.Forms.PictureBox();
            this.picBxDice2 = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnRollPass = new System.Windows.Forms.Button();
            this.lblDice1Digit = new System.Windows.Forms.Label();
            this.lblDice2Digit = new System.Windows.Forms.Label();
            this.lblGameFormGoalTitle = new System.Windows.Forms.Label();
            this.lblGameformGoal = new System.Windows.Forms.Label();
            this.lblPlayer1RunningScore = new System.Windows.Forms.Label();
            this.lblPlayer1CumulativeScore = new System.Windows.Forms.Label();
            this.lblPlayer2CumulativeScore = new System.Windows.Forms.Label();
            this.lblPlayer2RunningScore = new System.Windows.Forms.Label();
            this.lblWinnerText = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblPlayAgainToss = new System.Windows.Forms.Label();
            this.btnTossPlayAgain = new System.Windows.Forms.Button();
            this.lblWinningCount1Title = new System.Windows.Forms.Label();
            this.lblWinningCount2Title = new System.Windows.Forms.Label();
            this.lblWinningCount1Digit = new System.Windows.Forms.Label();
            this.lblWinningCount2Digit = new System.Windows.Forms.Label();
            this.timerForPlayWithAI = new System.Windows.Forms.Timer(this.components);
            this.lblSnakeEyeAndGroan = new System.Windows.Forms.Label();
            this.lblPlayer1Turn = new System.Windows.Forms.Label();
            this.lblPlayer2Turn = new System.Windows.Forms.Label();
            this.timerForSnakeEyes = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.lblMainformGoInstruction = new System.Windows.Forms.Label();
            this.timerForDiceAnimation = new System.Windows.Forms.Timer(this.components);
            this.progressRollDice = new System.Windows.Forms.ProgressBar();
            this.lblTurnIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameFormPlayer1Name
            // 
            this.lblGameFormPlayer1Name.AutoSize = true;
            this.lblGameFormPlayer1Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGameFormPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFormPlayer1Name.Location = new System.Drawing.Point(12, 56);
            this.lblGameFormPlayer1Name.Name = "lblGameFormPlayer1Name";
            this.lblGameFormPlayer1Name.Size = new System.Drawing.Size(55, 20);
            this.lblGameFormPlayer1Name.TabIndex = 0;
            this.lblGameFormPlayer1Name.Text = "Name";
            // 
            // lblGameFormPlayer2Name
            // 
            this.lblGameFormPlayer2Name.AutoSize = true;
            this.lblGameFormPlayer2Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGameFormPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFormPlayer2Name.Location = new System.Drawing.Point(1126, 56);
            this.lblGameFormPlayer2Name.Name = "lblGameFormPlayer2Name";
            this.lblGameFormPlayer2Name.Size = new System.Drawing.Size(55, 20);
            this.lblGameFormPlayer2Name.TabIndex = 1;
            this.lblGameFormPlayer2Name.Text = "Name";
            // 
            // lblRunningScorePlayer1
            // 
            this.lblRunningScorePlayer1.AutoSize = true;
            this.lblRunningScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningScorePlayer1.Location = new System.Drawing.Point(12, 76);
            this.lblRunningScorePlayer1.Name = "lblRunningScorePlayer1";
            this.lblRunningScorePlayer1.Size = new System.Drawing.Size(119, 20);
            this.lblRunningScorePlayer1.TabIndex = 2;
            this.lblRunningScorePlayer1.Text = "Running Score:";
            // 
            // lblCumulativeScorePlayer1
            // 
            this.lblCumulativeScorePlayer1.AutoSize = true;
            this.lblCumulativeScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumulativeScorePlayer1.Location = new System.Drawing.Point(12, 114);
            this.lblCumulativeScorePlayer1.Name = "lblCumulativeScorePlayer1";
            this.lblCumulativeScorePlayer1.Size = new System.Drawing.Size(137, 20);
            this.lblCumulativeScorePlayer1.TabIndex = 3;
            this.lblCumulativeScorePlayer1.Text = "Cumulative Score:";
            // 
            // lblRunningScorePlayer2
            // 
            this.lblRunningScorePlayer2.AutoSize = true;
            this.lblRunningScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningScorePlayer2.Location = new System.Drawing.Point(1126, 76);
            this.lblRunningScorePlayer2.Name = "lblRunningScorePlayer2";
            this.lblRunningScorePlayer2.Size = new System.Drawing.Size(119, 20);
            this.lblRunningScorePlayer2.TabIndex = 4;
            this.lblRunningScorePlayer2.Text = "Running Score:";
            // 
            // lblCumulativeScorePlayer2
            // 
            this.lblCumulativeScorePlayer2.AutoSize = true;
            this.lblCumulativeScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumulativeScorePlayer2.Location = new System.Drawing.Point(1126, 114);
            this.lblCumulativeScorePlayer2.Name = "lblCumulativeScorePlayer2";
            this.lblCumulativeScorePlayer2.Size = new System.Drawing.Size(137, 20);
            this.lblCumulativeScorePlayer2.TabIndex = 5;
            this.lblCumulativeScorePlayer2.Text = "Cumulative Score:";
            // 
            // picBxDice1
            // 
            this.picBxDice1.Location = new System.Drawing.Point(283, 341);
            this.picBxDice1.Name = "picBxDice1";
            this.picBxDice1.Size = new System.Drawing.Size(149, 150);
            this.picBxDice1.TabIndex = 6;
            this.picBxDice1.TabStop = false;
            // 
            // picBxDice2
            // 
            this.picBxDice2.Location = new System.Drawing.Point(847, 341);
            this.picBxDice2.Name = "picBxDice2";
            this.picBxDice2.Size = new System.Drawing.Size(149, 150);
            this.picBxDice2.TabIndex = 7;
            this.picBxDice2.TabStop = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(283, 162);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(149, 37);
            this.btnRollDice.TabIndex = 8;
            this.btnRollDice.Text = "Roll";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnRollPass
            // 
            this.btnRollPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRollPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollPass.Location = new System.Drawing.Point(847, 162);
            this.btnRollPass.Name = "btnRollPass";
            this.btnRollPass.Size = new System.Drawing.Size(149, 37);
            this.btnRollPass.TabIndex = 9;
            this.btnRollPass.Text = "Pass";
            this.btnRollPass.UseVisualStyleBackColor = false;
            this.btnRollPass.Click += new System.EventHandler(this.btnRollPass_Click);
            // 
            // lblDice1Digit
            // 
            this.lblDice1Digit.AutoSize = true;
            this.lblDice1Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1Digit.Location = new System.Drawing.Point(329, 322);
            this.lblDice1Digit.Name = "lblDice1Digit";
            this.lblDice1Digit.Size = new System.Drawing.Size(52, 16);
            this.lblDice1Digit.TabIndex = 10;
            this.lblDice1Digit.Text = "Dice 1";
            this.lblDice1Digit.Visible = false;
            // 
            // lblDice2Digit
            // 
            this.lblDice2Digit.AutoSize = true;
            this.lblDice2Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2Digit.Location = new System.Drawing.Point(895, 322);
            this.lblDice2Digit.Name = "lblDice2Digit";
            this.lblDice2Digit.Size = new System.Drawing.Size(52, 16);
            this.lblDice2Digit.TabIndex = 11;
            this.lblDice2Digit.Text = "Dice 2";
            this.lblDice2Digit.Visible = false;
            // 
            // lblGameFormGoalTitle
            // 
            this.lblGameFormGoalTitle.AutoSize = true;
            this.lblGameFormGoalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameFormGoalTitle.Location = new System.Drawing.Point(661, 9);
            this.lblGameFormGoalTitle.Name = "lblGameFormGoalTitle";
            this.lblGameFormGoalTitle.Size = new System.Drawing.Size(47, 20);
            this.lblGameFormGoalTitle.TabIndex = 12;
            this.lblGameFormGoalTitle.Text = "Goal";
            // 
            // lblGameformGoal
            // 
            this.lblGameformGoal.AutoSize = true;
            this.lblGameformGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameformGoal.Location = new System.Drawing.Point(661, 41);
            this.lblGameformGoal.Name = "lblGameformGoal";
            this.lblGameformGoal.Size = new System.Drawing.Size(47, 20);
            this.lblGameformGoal.TabIndex = 13;
            this.lblGameformGoal.Text = "Goal";
            // 
            // lblPlayer1RunningScore
            // 
            this.lblPlayer1RunningScore.AutoSize = true;
            this.lblPlayer1RunningScore.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlayer1RunningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1RunningScore.Location = new System.Drawing.Point(155, 76);
            this.lblPlayer1RunningScore.Name = "lblPlayer1RunningScore";
            this.lblPlayer1RunningScore.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer1RunningScore.TabIndex = 14;
            this.lblPlayer1RunningScore.Text = "0";
            // 
            // lblPlayer1CumulativeScore
            // 
            this.lblPlayer1CumulativeScore.AutoSize = true;
            this.lblPlayer1CumulativeScore.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlayer1CumulativeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1CumulativeScore.Location = new System.Drawing.Point(155, 114);
            this.lblPlayer1CumulativeScore.Name = "lblPlayer1CumulativeScore";
            this.lblPlayer1CumulativeScore.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer1CumulativeScore.TabIndex = 15;
            this.lblPlayer1CumulativeScore.Text = "0";
            // 
            // lblPlayer2CumulativeScore
            // 
            this.lblPlayer2CumulativeScore.AutoSize = true;
            this.lblPlayer2CumulativeScore.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlayer2CumulativeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2CumulativeScore.Location = new System.Drawing.Point(1269, 114);
            this.lblPlayer2CumulativeScore.Name = "lblPlayer2CumulativeScore";
            this.lblPlayer2CumulativeScore.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer2CumulativeScore.TabIndex = 16;
            this.lblPlayer2CumulativeScore.Text = "0";
            // 
            // lblPlayer2RunningScore
            // 
            this.lblPlayer2RunningScore.AutoSize = true;
            this.lblPlayer2RunningScore.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlayer2RunningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2RunningScore.Location = new System.Drawing.Point(1269, 76);
            this.lblPlayer2RunningScore.Name = "lblPlayer2RunningScore";
            this.lblPlayer2RunningScore.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer2RunningScore.TabIndex = 17;
            this.lblPlayer2RunningScore.Text = "0";
            // 
            // lblWinnerText
            // 
            this.lblWinnerText.AutoSize = true;
            this.lblWinnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerText.ForeColor = System.Drawing.Color.Black;
            this.lblWinnerText.Location = new System.Drawing.Point(505, 240);
            this.lblWinnerText.Name = "lblWinnerText";
            this.lblWinnerText.Size = new System.Drawing.Size(297, 33);
            this.lblWinnerText.TabIndex = 18;
            this.lblWinnerText.Text = ",Your are the winner";
            this.lblWinnerText.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(571, 461);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(172, 57);
            this.btnPlayAgain.TabIndex = 19;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblPlayAgainToss
            // 
            this.lblPlayAgainToss.AutoSize = true;
            this.lblPlayAgainToss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgainToss.ForeColor = System.Drawing.Color.Black;
            this.lblPlayAgainToss.Location = new System.Drawing.Point(546, 284);
            this.lblPlayAgainToss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayAgainToss.Name = "lblPlayAgainToss";
            this.lblPlayAgainToss.Size = new System.Drawing.Size(220, 24);
            this.lblPlayAgainToss.TabIndex = 20;
            this.lblPlayAgainToss.Text = "You will start the game";
            this.lblPlayAgainToss.Visible = false;
            // 
            // btnTossPlayAgain
            // 
            this.btnTossPlayAgain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTossPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTossPlayAgain.Location = new System.Drawing.Point(585, 399);
            this.btnTossPlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTossPlayAgain.Name = "btnTossPlayAgain";
            this.btnTossPlayAgain.Size = new System.Drawing.Size(141, 57);
            this.btnTossPlayAgain.TabIndex = 21;
            this.btnTossPlayAgain.Text = "Toss";
            this.btnTossPlayAgain.UseVisualStyleBackColor = false;
            this.btnTossPlayAgain.Visible = false;
            this.btnTossPlayAgain.Click += new System.EventHandler(this.btnTossPlayAgain_Click);
            // 
            // lblWinningCount1Title
            // 
            this.lblWinningCount1Title.AutoSize = true;
            this.lblWinningCount1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningCount1Title.Location = new System.Drawing.Point(12, 152);
            this.lblWinningCount1Title.Name = "lblWinningCount1Title";
            this.lblWinningCount1Title.Size = new System.Drawing.Size(87, 20);
            this.lblWinningCount1Title.TabIndex = 22;
            this.lblWinningCount1Title.Text = "Win Count:";
            // 
            // lblWinningCount2Title
            // 
            this.lblWinningCount2Title.AutoSize = true;
            this.lblWinningCount2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningCount2Title.Location = new System.Drawing.Point(1126, 152);
            this.lblWinningCount2Title.Name = "lblWinningCount2Title";
            this.lblWinningCount2Title.Size = new System.Drawing.Size(87, 20);
            this.lblWinningCount2Title.TabIndex = 23;
            this.lblWinningCount2Title.Text = "Win Count:";
            // 
            // lblWinningCount1Digit
            // 
            this.lblWinningCount1Digit.AutoSize = true;
            this.lblWinningCount1Digit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWinningCount1Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningCount1Digit.Location = new System.Drawing.Point(155, 152);
            this.lblWinningCount1Digit.Name = "lblWinningCount1Digit";
            this.lblWinningCount1Digit.Size = new System.Drawing.Size(19, 20);
            this.lblWinningCount1Digit.TabIndex = 24;
            this.lblWinningCount1Digit.Text = "0";
            // 
            // lblWinningCount2Digit
            // 
            this.lblWinningCount2Digit.AutoSize = true;
            this.lblWinningCount2Digit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWinningCount2Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningCount2Digit.Location = new System.Drawing.Point(1269, 152);
            this.lblWinningCount2Digit.Name = "lblWinningCount2Digit";
            this.lblWinningCount2Digit.Size = new System.Drawing.Size(19, 20);
            this.lblWinningCount2Digit.TabIndex = 25;
            this.lblWinningCount2Digit.Text = "0";
            // 
            // timerForPlayWithAI
            // 
            this.timerForPlayWithAI.Interval = 1000;
            this.timerForPlayWithAI.Tick += new System.EventHandler(this.timerForPlayWithAI_Tick);
            // 
            // lblSnakeEyeAndGroan
            // 
            this.lblSnakeEyeAndGroan.AutoSize = true;
            this.lblSnakeEyeAndGroan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnakeEyeAndGroan.ForeColor = System.Drawing.Color.Maroon;
            this.lblSnakeEyeAndGroan.Location = new System.Drawing.Point(553, 280);
            this.lblSnakeEyeAndGroan.Name = "lblSnakeEyeAndGroan";
            this.lblSnakeEyeAndGroan.Size = new System.Drawing.Size(138, 29);
            this.lblSnakeEyeAndGroan.TabIndex = 27;
            this.lblSnakeEyeAndGroan.Text = "Conditions";
            this.lblSnakeEyeAndGroan.Visible = false;
            // 
            // lblPlayer1Turn
            // 
            this.lblPlayer1Turn.AutoSize = true;
            this.lblPlayer1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Turn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer1Turn.Location = new System.Drawing.Point(12, 19);
            this.lblPlayer1Turn.Name = "lblPlayer1Turn";
            this.lblPlayer1Turn.Size = new System.Drawing.Size(102, 24);
            this.lblPlayer1Turn.TabIndex = 28;
            this.lblPlayer1Turn.Text = "Your turn:";
            // 
            // lblPlayer2Turn
            // 
            this.lblPlayer2Turn.AutoSize = true;
            this.lblPlayer2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Turn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer2Turn.Location = new System.Drawing.Point(1126, 19);
            this.lblPlayer2Turn.Name = "lblPlayer2Turn";
            this.lblPlayer2Turn.Size = new System.Drawing.Size(102, 24);
            this.lblPlayer2Turn.TabIndex = 29;
            this.lblPlayer2Turn.Text = "Your turn:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 663);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 57);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainForm.Location = new System.Drawing.Point(571, 588);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(172, 57);
            this.btnMainForm.TabIndex = 31;
            this.btnMainForm.Text = "Set here!";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Visible = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // lblMainformGoInstruction
            // 
            this.lblMainformGoInstruction.AutoSize = true;
            this.lblMainformGoInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainformGoInstruction.Location = new System.Drawing.Point(449, 535);
            this.lblMainformGoInstruction.Name = "lblMainformGoInstruction";
            this.lblMainformGoInstruction.Size = new System.Drawing.Size(420, 50);
            this.lblMainformGoInstruction.TabIndex = 32;
            this.lblMainformGoInstruction.Text = "To set a new goal or Change Player name:\r\n(You will lose everything from this gam" +
    "e)";
            this.lblMainformGoInstruction.Visible = false;
            // 
            // timerForDiceAnimation
            // 
            this.timerForDiceAnimation.Tick += new System.EventHandler(this.timerForDiceAnimation_Tick);
            // 
            // progressRollDice
            // 
            this.progressRollDice.Location = new System.Drawing.Point(1339, 562);
            this.progressRollDice.Name = "progressRollDice";
            this.progressRollDice.Size = new System.Drawing.Size(100, 23);
            this.progressRollDice.TabIndex = 33;
            this.progressRollDice.Visible = false;
            // 
            // lblTurnIndicator
            // 
            this.lblTurnIndicator.AutoSize = true;
            this.lblTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnIndicator.Location = new System.Drawing.Point(606, 166);
            this.lblTurnIndicator.Name = "lblTurnIndicator";
            this.lblTurnIndicator.Size = new System.Drawing.Size(102, 24);
            this.lblTurnIndicator.TabIndex = 34;
            this.lblTurnIndicator.Text = " Your turn";
            this.lblTurnIndicator.Visible = false;
            // 
            // frmGroan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1379, 749);
            this.Controls.Add(this.lblTurnIndicator);
            this.Controls.Add(this.progressRollDice);
            this.Controls.Add(this.lblMainformGoInstruction);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPlayer2Turn);
            this.Controls.Add(this.lblPlayer1Turn);
            this.Controls.Add(this.lblSnakeEyeAndGroan);
            this.Controls.Add(this.lblWinningCount2Digit);
            this.Controls.Add(this.lblWinningCount1Digit);
            this.Controls.Add(this.lblWinningCount2Title);
            this.Controls.Add(this.lblWinningCount1Title);
            this.Controls.Add(this.btnTossPlayAgain);
            this.Controls.Add(this.lblPlayAgainToss);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblWinnerText);
            this.Controls.Add(this.lblPlayer2RunningScore);
            this.Controls.Add(this.lblPlayer2CumulativeScore);
            this.Controls.Add(this.lblPlayer1CumulativeScore);
            this.Controls.Add(this.lblPlayer1RunningScore);
            this.Controls.Add(this.lblGameformGoal);
            this.Controls.Add(this.lblGameFormGoalTitle);
            this.Controls.Add(this.lblDice2Digit);
            this.Controls.Add(this.lblDice1Digit);
            this.Controls.Add(this.btnRollPass);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.picBxDice2);
            this.Controls.Add(this.picBxDice1);
            this.Controls.Add(this.lblCumulativeScorePlayer2);
            this.Controls.Add(this.lblRunningScorePlayer2);
            this.Controls.Add(this.lblCumulativeScorePlayer1);
            this.Controls.Add(this.lblRunningScorePlayer1);
            this.Controls.Add(this.lblGameFormPlayer2Name);
            this.Controls.Add(this.lblGameFormPlayer1Name);
            this.Name = "frmGroan";
            this.Text = "Groan Form";
            ((System.ComponentModel.ISupportInitialize)(this.picBxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameFormPlayer1Name;
        private System.Windows.Forms.Label lblGameFormPlayer2Name;
        private System.Windows.Forms.Label lblRunningScorePlayer1;
        private System.Windows.Forms.Label lblCumulativeScorePlayer1;
        private System.Windows.Forms.Label lblRunningScorePlayer2;
        private System.Windows.Forms.Label lblCumulativeScorePlayer2;
        private System.Windows.Forms.PictureBox picBxDice1;
        private System.Windows.Forms.PictureBox picBxDice2;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnRollPass;
        private System.Windows.Forms.Label lblDice1Digit;
        private System.Windows.Forms.Label lblDice2Digit;
        private System.Windows.Forms.Label lblGameFormGoalTitle;
        private System.Windows.Forms.Label lblGameformGoal;
        private System.Windows.Forms.Label lblPlayer1RunningScore;
        private System.Windows.Forms.Label lblPlayer1CumulativeScore;
        private System.Windows.Forms.Label lblPlayer2CumulativeScore;
        private System.Windows.Forms.Label lblPlayer2RunningScore;
        private System.Windows.Forms.Label lblWinnerText;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblPlayAgainToss;
        private System.Windows.Forms.Button btnTossPlayAgain;
        private System.Windows.Forms.Label lblWinningCount1Title;
        private System.Windows.Forms.Label lblWinningCount2Title;
        private System.Windows.Forms.Label lblWinningCount1Digit;
        private System.Windows.Forms.Label lblWinningCount2Digit;
        private System.Windows.Forms.Timer timerForPlayWithAI;
        private System.Windows.Forms.Label lblSnakeEyeAndGroan;
        private System.Windows.Forms.Label lblPlayer1Turn;
        private System.Windows.Forms.Label lblPlayer2Turn;
        private System.Windows.Forms.Timer timerForSnakeEyes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Label lblMainformGoInstruction;
        private System.Windows.Forms.Timer timerForDiceAnimation;
        private System.Windows.Forms.ProgressBar progressRollDice;
        private System.Windows.Forms.Label lblTurnIndicator;
    }
}