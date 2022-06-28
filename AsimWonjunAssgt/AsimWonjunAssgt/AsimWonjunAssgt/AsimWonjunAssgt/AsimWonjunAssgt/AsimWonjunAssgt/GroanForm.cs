using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsimWonjunAssgt
{
    public partial class frmGroan : Form
    {
        //Declearing Graphics
        Graphics graPaper;
        Graphics graPaper2;

        //Declearning the player's score to use in the other methods
        int iPlayer1RunningScore, iPlayer2RunningScore, iPlayer1CurrentScore,
            iPlayer2CurrentScore, iPlayer1CumulativeScore, iPlayer2CumulativeScore,
            iWinningCount1, iWinningCount2;

        //Declearning the player's turn to use that in the pass button
        bool Player1Turn = true,
             Player2Turn = true,
             AITurn = false,
             PlayerTurn = false;

        //Declearing Random dice here
        Random Dice = new Random();

        //Properties to get the value from Welcome form to the main game form
        public string sPlayer1 { get; set; }                                  //Setting and getting Player 1 Name
        public string sPlayer2 { get; set; }                                  //Setting and Getting Player 2 Name
        public int dGoal { get; set; }                                        //Setting and getting the value of GOAL (NumericUpsAndDown)

        #region Form constructor and conditions and managing Game mode
        //---------------------------------------------------------------------------------
        //This is bulding a constructor
        //This constructor is for to get the value from the welcome form to the main gaim form we create this constructor
        //Instantiating picture boxes in this constructor as well
        //----------------------------------------------------------------------------------
        public frmGroan(string sPlayer1, string sPlayer2, int dGoal, bool pWithAI, bool pWithMate, string SecondPlayer, string FirstPlayer)
        {
            InitializeComponent();                                                   //Instantiating picture boxes for dice one and two
            graPaper = picBxDice1.CreateGraphics();                                  //For Dice one
            graPaper2 = picBxDice2.CreateGraphics();                                 //For Dice two
            lblGameformGoal.Text = Convert.ToString(dGoal);                          //NumericUpDown which is GOAL in decimal
            if (pWithAI == true)
            {
                    AITurn = true;
                    lblGameFormPlayer1Name.Text = sPlayer1.ToUpper();                //Player 1
                    lblGameFormPlayer2Name.Text = sPlayer2;                          //Player 2
                    timerForPlayWithAI.Start();                                      //Starting the timer here
            }
            else if (pWithMate == true)
            {
                PlayerTurn = true;
                lblGameFormPlayer1Name.Text = FirstPlayer.ToUpper();                  //Start the game as left side
                lblGameFormPlayer2Name.Text = SecondPlayer.ToUpper();                 //Will be in the right side
            }
            DisablePlayer();
        }
        #endregion

        #region Function method for Dice face to recall

        //-----------------------------------------------------------------------------------
        //This piece of code is basiclly if statements
        //We are using that to set the dice faces match with the random numbers
        //Whatever will be shown up when the random number will be trigged the dice face will display the same
        //------------------------------------------------------------------------------------ 

        private void DiceFace(int Dice1, int Dice2)
        {
            if (Dice1 == 1)
            {
                DiceFace1(graPaper);
            }
            else if (Dice1 == 2)
            {
                DiceFace2(graPaper);
            }
            else if (Dice1 == 3)
            {
                DiceFace3(graPaper);
            }
            else if (Dice1 == 4)
            {
                DiceFace4(graPaper);
            }
            else if (Dice1 == 5)
            {
                DiceFace5(graPaper);
            }
            else
            {
                DiceFace6(graPaper);
            }

            if (Dice2 == 1)
            {
                DiceFace1(graPaper2);
            }
            else if (Dice2 == 2)
            {
                DiceFace2(graPaper2);
            }
            else if (Dice2 == 3)
            {
                DiceFace3(graPaper2);
            }
            else if (Dice2 == 4)
            {
                DiceFace4(graPaper2);
            }
            else if (Dice2 == 5)
            {
                DiceFace5(graPaper2);
            }
            else
            {
                DiceFace6(graPaper2);
            }
        }

        #endregion

        #region All dice properties
        //-----------------------------------------------------------------------------------------------
        //THis piece of code will do the below
        //Draw and fill Rectengle and give them a color
        //Draw and fill Elipse and give them a color
        //Properties for all the dice faces
        //------------------------------------------------------------------------------------------------

        private void DiceFace1(Graphics graP)
        {

            //Dice 1 Face when  rolls 1
            //Center dot
            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 50, 50, 20, 20);
            graP.FillEllipse(Brushes.Black, 50, 50, 20, 20);
        }


        private void DiceFace2(Graphics graP)
        {
            //Dice 2 Face when rolls 2
            //1 doct top right 1 dot bottom left
            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 20, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 80, 20, 20);
        }
        private void DiceFace3(Graphics graP)
        {
            //Dice 3 Face when rolls 3
            //1 dot top right 1 dot middle 1 dot bottom right
            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 20, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 50, 50, 20, 20);
            graP.FillEllipse(Brushes.Black, 50, 50, 20, 20);
        }

            private void DiceFace4(Graphics graP)
        {
            //Dice 4 Face when rolls 4
            //2 up left - right and 2 bottom left - right
            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 20, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 20, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 80, 20, 20);
        }


        private void DiceFace5(Graphics graP)
        {
            //Dice 5 Face when rolls 5
            //2 up left - right and 2 bottom left - right and 1 middle

            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 20, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 20, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 50, 50, 20, 20);
            graP.FillEllipse(Brushes.Black, 50, 50, 20, 20);
        }
        private void DiceFace6(Graphics graP)
        {
            //Dice 6 Face when rolls 6
            //2 up left - right and 2 bottom left - right and 2 middle
            graP.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            graP.FillRectangle(Brushes.White, 10, 10, 100, 100);
            graP.DrawEllipse(Pens.White, 20, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 20, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 20, 20, 20);
            graP.DrawEllipse(Pens.White, 20, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 80, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 80, 20, 20);
            graP.DrawEllipse(Pens.White, 20, 50, 20, 20);
            graP.FillEllipse(Brushes.Black, 20, 50, 20, 20);
            graP.DrawEllipse(Pens.White, 80, 50, 20, 20);
            graP.FillEllipse(Brushes.Black, 80, 50, 20, 20);
        }

        #endregion

        #region Function method for roll button 
        public void Roll(int Dice1, int Dice2)
        {
            //--------------------------------------------------------------------------------------------
            //This piece of code will do the below:
            //We have 6 numbers in a dice so we set the values 1, 7 as it's easier to understand and count
            //When the roll button will be pressed this function will choose 2 random numbers between 1 to 6
            //Then it will add the numbers and show that to the Running score field and Cumulative score field
            //Making the method so we can recall that in multiple places
            //-----------------------------------------------------------------------------------------------

            lblDice1Digit.Text = Convert.ToString(Dice1);                    //Converting the random value to string as it is a int number and set that in the label
            lblDice2Digit.Text = Convert.ToString(Dice2);                    //Converting the random value to string as it is a int number and set that in the label
            lblDice1Digit.Visible = true;                                    //Visible the random number as we set the label visible = false to hide the text from the user
            lblDice2Digit.Visible = true;

            if (Player1Turn == true)
            {
                Player(lblGameFormPlayer1Name.Text, Dice1, Dice2);
            }
            else if (Player2Turn == true)
            {
                Player(lblGameFormPlayer2Name.Text, Dice1, Dice2);
            }
            DisablePlayer();

            btnTossPlayAgain.Visible = false;
            lblPlayAgainToss.Visible = false;
            
        }
        #endregion

        #region Roll button Event Handler with the random codes and If statements to control the dice face

        public void btnRollDice_Click(object sender, EventArgs e)            
        {
            //--------------------------------
            //When roll button will be trigged
            //--------------------------------
            lblTurnIndicator.Visible = false;                                   //Useful label to guide player
            timerForDiceAnimation.Start();
        }


        #endregion

        #region When one Player roll Dice other Player will be unable
        private void DisablePlayer()
        {
            //-------------------------------------
            //This piece of code is for setting properties along with some conditiond
            //-------------------------------------

            if (Player1Turn == true)
            {
                lblGameFormPlayer1Name.Enabled = true;
                lblRunningScorePlayer1.Enabled = true;
                lblCumulativeScorePlayer1.Enabled = true;
                lblWinningCount1Title.Enabled = true;
                lblPlayer1RunningScore.Enabled = true;
                lblPlayer1CumulativeScore.Enabled = true;
                lblWinningCount1Digit.Enabled = true;
                lblPlayer1Turn.Visible = true;
                lblPlayer2Turn.Visible = false;

                lblGameFormPlayer2Name.Enabled = false;  
                lblRunningScorePlayer2.Enabled = false; 
                lblCumulativeScorePlayer2.Enabled = false;
                lblWinningCount2Title.Enabled = false;
                lblPlayer2RunningScore.Enabled = false;
                lblPlayer2CumulativeScore.Enabled = false;
                lblWinningCount2Digit.Enabled = false;
            }

            else if (Player2Turn == true)
            {
                lblGameFormPlayer2Name.Enabled = true;
                lblRunningScorePlayer2.Enabled = true;  
                lblCumulativeScorePlayer2.Enabled = true;
                lblWinningCount2Title.Enabled = true;
                lblPlayer2RunningScore.Enabled = true;
                lblPlayer2CumulativeScore.Enabled = true;
                lblWinningCount2Digit.Enabled = true;
                lblPlayer2Turn.Visible = true;
                lblPlayer1Turn.Visible = false;

                lblGameFormPlayer1Name.Enabled = false;
                lblRunningScorePlayer1.Enabled = false;
                lblCumulativeScorePlayer1.Enabled = false;
                lblWinningCount1Title.Enabled = false;
                lblPlayer1RunningScore.Enabled = false;
                lblPlayer1CumulativeScore.Enabled = false;
                lblWinningCount1Digit.Enabled = false;
            }
        }
        #endregion

        #region Function method for achieveGoal
        //----------------------------------------------------------------------------------
        //Using if statements to set the winner according to the goal
        //This will define the winning player
        //Some work with the visible and enable properties
        //----------------------------------------------------------------------------------
        private void achieveGoal(int RunningScore, int CumulativeScore, string pName)
        {
            if (CumulativeScore >= Convert.ToInt32(lblGameformGoal.Text) || CumulativeScore + RunningScore >= Convert.ToInt32(lblGameformGoal.Text))
            {
                lblWinnerText.Visible = true;
                lblMainformGoInstruction.Visible = true;
                btnRollDice.Enabled = false;
                btnRollPass.Enabled = false;
                lblWinnerText.Text = pName.ToUpper() + ", you are the winner"; //Making the name to uppercase and show the lable
                btnPlayAgain.Visible = true;
                btnMainForm.Visible = true;
                btnTossPlayAgain.Visible = true;
                if (CumulativeScore == iPlayer1CumulativeScore && RunningScore == iPlayer1RunningScore)
                {
                    iWinningCount1 = iWinningCount1 + 1;
                }
                else if (CumulativeScore == iPlayer2CumulativeScore && RunningScore == iPlayer2RunningScore)
                {
                    iWinningCount2 = iWinningCount2 + 1;
                }
                timerForPlayWithAI.Dispose();
            }
        }

        #endregion

        #region Player Scores
        //------------------------------------------------------------------------------
        //Creating function method to add the player 1 and two
        //Player running score
        //Player GameConditions
        //Player achieveGoal
        //------------------------------------------------------------------------------
        private void Player(string pName, int Dice1, int Dice2)
        {
            if (Player1Turn == true)
            {
                iPlayer1CurrentScore = Dice1 + Dice2;                                       //Adding both of the dice number and store that
                iPlayer1RunningScore += iPlayer1CurrentScore;                               //This line will keep adding the number whenever the dice will be trigged           
                lblPlayer1RunningScore.Text = Convert.ToString(iPlayer1RunningScore);       //Shwoing the score in a label and converting that to a string
                GameConditions(lblGameFormPlayer1Name.Text, Dice1, Dice2);
                achieveGoal(iPlayer1RunningScore, iPlayer1CumulativeScore, lblGameFormPlayer1Name.Text);
                lblWinningCount1Digit.Text = Convert.ToString(iWinningCount1);               //Count
            }
            else if (Player2Turn == true)
            {
                iPlayer2CurrentScore = Dice1 + Dice2;                                       //Adding both of the dice number and store that
                iPlayer2RunningScore += iPlayer2CurrentScore;                               //This line will keep adding the number whenever the dice will be trigged
                lblPlayer2RunningScore.Text = Convert.ToString(iPlayer2RunningScore);       //Shwoing the score in a label and converting that to a string    
                GameConditions(lblGameFormPlayer2Name.Text, Dice1, Dice2);
                achieveGoal(iPlayer2RunningScore, iPlayer2CumulativeScore, lblGameFormPlayer2Name.Text);
                lblWinningCount2Digit.Text = Convert.ToString(iWinningCount2);               //Count
            }
        }
        #endregion     

        #region Timer for DiceAnimation
        //--------------------------------------------------------------
        //Reference: The idea is taken from a youtube tutorial. We did the code ourself and there's a lot of changes between the codes. We took the concept only how can we work on that
        //Reference URL: https://www.youtube.com/watch?v=7LwsH8XqKIs
        //End of reference
        //--------------------------------------------------------------

        //----------------------------------------------
        //This piece of code is responsible to animate the dice
        //It will show all the dices faces randomly and then match with the random numbers
        //Toolbox item used: Progressbar and Timer

        private void timerForDiceAnimation_Tick(object sender, EventArgs e)
        {
            int Dice1 = Dice.Next(1, 7);                        //Random number
            int Dice2 = Dice.Next(1, 7);                        //Random number
            progressRollDice.Increment(10);                     //Every 10% of the progressbar the dice will show the face so dice will show the face 10 times
            TimeControl(300);                                   //0.3 Second
            if (progressRollDice.Value == 100)                  //Setting condition to the progress bar
            {
                timerForDiceAnimation.Stop();
                progressRollDice.Value = 0;
                DiceFace(Dice1, Dice2);
                Roll(Dice1, Dice2);
                if (AITurn == true && Player2Turn == true)      //As our AI is on timer so we need another condition for that
                {
                    TimeControl(2000);                           //Tick every after 2 Sceonds and that's reasonable. 3 seconds is too long to wait
                }
            }
            else
            {
                DiceFace(Dice1, Dice2);
            }
        }
        #endregion

        #region Game Conditions
        private void GameConditions(string pName, int Dice1, int Dice2)
        {
            //---------------------------------------
            //Giving game condition as isntructed in assignment sheet
            //Showing some other label
            //---------------------------------------
            if (Dice1 == 1 && Dice2 == 1)
            {
                if (lblGameFormPlayer1Name.Text == pName)
                {
                    iPlayer1RunningScore = 0;
                    iPlayer1CumulativeScore = 0;
                    lblPlayer1RunningScore.Text = "0";
                    lblPlayer1CumulativeScore.Text = "0";
                    lblSnakeEyeAndGroan.Text = "Snake's eyes: " + pName + ", loses everything";
                    Pass();
                }
                else if (lblGameFormPlayer2Name.Text == pName)
                {
                    iPlayer2RunningScore = 0;
                    iPlayer2CumulativeScore = 0;
                    lblPlayer2RunningScore.Text = "0";
                    lblPlayer2CumulativeScore.Text = "0";
                    lblSnakeEyeAndGroan.Text = "Snake's eyes: " + pName + ", loses everything";
                    Pass();
                }
                timerForSnakeEyes.Start();
                lblSnakeEyeAndGroan.Visible = true;
                TimeControl(1000);
                timerForSnakeEyes.Stop();
                lblSnakeEyeAndGroan.Visible = false;
            }
            else if (Dice1 == 1 || Dice2 == 1)
            {
                if (lblGameFormPlayer1Name.Text == pName)
                {
                    iPlayer1RunningScore = 0;
                    lblPlayer1RunningScore.Text = "0";
                    lblSnakeEyeAndGroan.Text = "Groan: " + pName + ", loses dice";
                    Pass();
                }
                else if (lblGameFormPlayer2Name.Text == pName)
                {
                    iPlayer2RunningScore = 0;
                    lblPlayer2RunningScore.Text = "0";
                    lblSnakeEyeAndGroan.Text = "Groan: " + pName + ", loses dice";
                    Pass();
                }
                timerForSnakeEyes.Start();
                lblSnakeEyeAndGroan.Visible = true;
                TimeControl(1000);
                timerForSnakeEyes.Stop();
                lblSnakeEyeAndGroan.Visible = false;

            }
        }

        #endregion

        #region Function method for passing the dice

        //------------------------------------------------------
        //This function will pass the dice on user request
        //It will switch in between two methods Player 1 and Player 2 and AI as well)
        //The reason we do that we need to recall the function in AI part and this attempt will reduce the amount of codes
        //-------------------------------------------------------

        private void Pass()
        {
            if (Player1Turn == true)
            {
                Player1Turn = false;                                                            //Switch the turn to Player 2 and make player 1 False
                Player2Turn = true;                                                             //Switch the turn to Player 2
                lblPlayer1RunningScore.Text = "0";                                              //Running score will be 0 for player 1
                lblPlayer2RunningScore.Text = "0";                                              //Running score will be 0 for player 2
                iPlayer1CumulativeScore += iPlayer1RunningScore;                                //Keep adding the cumulative score when the user will press the Pass button
                iPlayer1RunningScore = 0;                                                       //Start the running score from 0 again
                lblPlayer1CumulativeScore.Text = Convert.ToString(iPlayer1CumulativeScore);     //Convertion
                lblTurnIndicator.Visible = true;
                lblTurnIndicator.Text = lblGameFormPlayer2Name.Text + "'s turn";
            }

            else if (Player2Turn == true)
            {
                Player2Turn = false;                                                            //Switch the turn to Player 1 and make player 2 False
                Player1Turn = true;                                                             //Switch the turn to Player 1
                lblPlayer1RunningScore.Text = "0";                                              //Running score will be 0 for player 1 (Code repeating)
                lblPlayer2RunningScore.Text = "0";                                              //Running score will be 0 for player 2 (Code repeating)
                iPlayer2CumulativeScore += iPlayer2RunningScore;                                //Keep adding the cumulative score when the user will press the Pass button
                iPlayer2RunningScore = 0;                                                       //Start the running score from 0 again
                lblPlayer2CumulativeScore.Text = Convert.ToString(iPlayer2CumulativeScore);     //Convertion
                lblTurnIndicator.Visible = true;
                lblTurnIndicator.Text = lblGameFormPlayer1Name.Text + "'s turn";
            }
        }

        #endregion 

        #region Pass button
        //------------------------------------------------------
        //This event handler will pass the dice on user request
        //It will switch in between two methods Player 1 and Player 2)
        //It will keep switching the players whenever the user trigged Pass
        //-------------------------------------------------------
        private void btnRollPass_Click(object sender, EventArgs e)
        {
            Pass();
            btnTossPlayAgain.Visible = false;
            lblPlayAgainToss.Visible = false;
        }
        #endregion

        #region Play Again
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //--------------------------------------
            //This piece of code is completely setting new properties after play again
            //------------------------------------

            iPlayer1CurrentScore = 0;
            iPlayer1RunningScore = 0;
            iPlayer1CumulativeScore = 0;
            iPlayer2CurrentScore = 0;
            iPlayer2RunningScore = 0;
            iPlayer2CumulativeScore = 0;

            lblPlayer1RunningScore.Text = "0";                                                  //Running score will be 0 for player 1 (Code repeating)
            lblPlayer2RunningScore.Text = "0";                                                  //Running score will be 0 for player 2 (Code repeating)
            lblPlayer1CumulativeScore.Text = "0";
            lblPlayer2CumulativeScore.Text = "0";

            btnPlayAgain.Visible = false;
            btnMainForm.Visible = false;
            lblMainformGoInstruction.Visible = false;
            lblWinnerText.Visible = false;
            lblPlayAgainToss.Visible = false;
            btnRollDice.Enabled = false;
            btnRollPass.Enabled = false;
            btnTossPlayAgain.Visible = true;
            btnTossPlayAgain.Enabled = true;
        }

        #endregion

        #region Toss after pressing play again      
        private void btnTossPlayAgain_Click(object sender, EventArgs e)
        {
            //-----------------------------------
            //This piece of code is basically chnaging properties after play again toss
            //Some other conditions
            //-----------------------------------
            btnTossPlayAgain.Visible = false;
            GameTurnDecide(lblGameFormPlayer1Name.Text, lblGameFormPlayer2Name.Text);
            lblPlayAgainToss.Visible = true;
            lblPlayAgainToss.Enabled = true;
            btnRollPass.Enabled = true;
            btnRollDice.Enabled = true;
            btnTossPlayAgain.Enabled = false;

            if (AITurn == true)
            {
                timerForPlayWithAI.Start();
                TimeControl(2000);
            }

        }
        private void GameTurnDecide(string pName1, string pName2)
        {
            //------------------------------------
            //Same code we use in Welcome form
            //Choosing a player randomly
            //Show some suitable label to guide user
            //------------------------------------

            string[] TurnDecide = { pName1, pName2 };
            int toss = Dice.Next(TurnDecide.Length);
            lblPlayAgainToss.Text = TurnDecide[toss];
            int winCount1;
            if (PlayerTurn == true)
            {
                if (lblPlayAgainToss.Text == pName1)
                {
                    lblGameFormPlayer1Name.Text = pName1;
                    lblGameFormPlayer2Name.Text = pName2;
                    lblWinningCount1Digit.Text = Convert.ToString(iWinningCount1);
                    lblWinningCount2Digit.Text = Convert.ToString(iWinningCount2);
                    lblPlayAgainToss.Text = "You will start the game: " + pName1;
                    Player2Turn = false;                                                            //Switch the turn to Player 1 and make player 2 False
                    Player1Turn = true;                                                             //Switch the turn to Player 1
                }
                else if (lblPlayAgainToss.Text == pName2)
                {
                    lblGameFormPlayer1Name.Text = pName2;
                    lblGameFormPlayer2Name.Text = pName1;
                    winCount1 = iWinningCount1;
                    iWinningCount1 = iWinningCount2;
                    iWinningCount2 = winCount1;
                    lblWinningCount2Digit.Text = Convert.ToString(iWinningCount1);
                    lblWinningCount1Digit.Text = Convert.ToString(winCount1);
                    lblWinningCount1Digit.Text = Convert.ToString(iWinningCount1);
                    lblWinningCount2Digit.Text = Convert.ToString(iWinningCount2);
                    lblPlayAgainToss.Text = "You will start the game: " + pName2;
                    lblWinningCount1Title.Text = lblWinningCount2Title.Text;
                    lblWinningCount2Title.Text = lblWinningCount1Title.Text;
                    Player2Turn = false;                                                            //Switch the turn to Player 1 and make player 2 False
                    Player1Turn = true;                                                             //Switch the turn to Player 1
                }
            }
            if (AITurn == true)
            {
                if (lblPlayAgainToss.Text == pName1)
                {
                    lblGameFormPlayer1Name.Text = pName1;
                    lblGameFormPlayer2Name.Text = pName2;
                    lblWinningCount1Digit.Text = Convert.ToString(iWinningCount1);
                    lblWinningCount2Digit.Text = Convert.ToString(iWinningCount2);
                    lblPlayAgainToss.Text = "You will start the game: " + pName1;
                    Player2Turn = false;
                    Player1Turn = true;
                }
                else if (lblPlayAgainToss.Text == pName2)
                {
                    lblGameFormPlayer1Name.Text = pName1;
                    lblGameFormPlayer2Name.Text = pName2;
                    lblWinningCount1Digit.Text = Convert.ToString(iWinningCount1);
                    lblWinningCount2Digit.Text = Convert.ToString(iWinningCount2);
                    lblPlayAgainToss.Text = "You will start the game: " + pName2;
                    Player1Turn = false;
                    Player2Turn = true;
                }
            }
        }

        #endregion

        #region Play again with new set goal and new names      
        private void btnMainForm_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------
            //This code will go back to the form 1 and start a complete new game
            //---------------------------------------------------

            MessageBox.Show("You will lose everything from this game if you set new goal or change player name", "Attention");

            frmWelcome frm = new frmWelcome();
            this.Hide();
            frm.ShowDialog();
            Show();
        }
        #endregion

        #region Function method for Time control within some codes
        //--------------------------------------------
        //This piece of code will animate the dices
        //We need to set up a time while recalling the function
        //--------------------------------------------
        private void TimeControl(int iMillisecs)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(iMillisecs);
        }

        #endregion

        #region Timer event handler

        private void timerForPlayWithAI_Tick(object sender, EventArgs e)
        {
            //--------------------------------------
            //This timer is to control the AI
            //We specify the Random numbers here
            //--------------------------------------

            int Dice1 = Dice.Next(1, 7), Dice2 = Dice.Next(1, 7);                                                     //Random numbers
            if (Player2Turn == true && Player1Turn == false)                                                          //Condition
            {
                PlayWithAI(lblGameFormPlayer2Name.Text, iPlayer2RunningScore, iPlayer2CumulativeScore, Dice1, Dice2); //Recalling earlier function
            }
            if (Player1Turn == true && Player2Turn == false)
            {
                btnRollDice.Enabled = true;
                btnRollPass.Enabled = true;
            }
        }
        #endregion

        #region Play with AI (Computer) STRATEGIes, Function methods, properties
        private void PlayWithAI(string pName, int RunningScore, int CumulativeScore, int Dice1, int Dice2)
        {
            //-------------------------------------------------
            //This is the code for Play with the Computer
            //When the user check play with AI radio button the timer will start
            //Then we are recalling the Button function method and Pass function method to do the job when the timer tick
            //To pass the dice we need to put some condition in other words Some STRATEGY
            //IT COULD BE DONE BY USING FOR LOOP AS WELL 
            //------------------------------------------------

            btnRollDice.Enabled = false;            //Chnage of button properties
            btnRollPass.Enabled = false;            //Change of button properties

            //--------------------------------
            //STRATEGIes to control the game so the AI can pass the dice

            //STRATEGY 1:

            // If the user decided with some goal such as the range is 0 to 20 then if the running score is less than or equal 5 then it will keep rolling the dice and after score 5 the AI will pass the dice

            //STRATEGY 2:

            //If the goal is more than 20 and less or equal than 50 then if the running score is less than or equal 10 then it will keep rolling the dice and after score 10  the AI will pass the dice

            //STRATEGY 3:

            //If the goal is more than 50 and less or equal than 100 then if the running score is less than or equal 20 then it will keep rolling the dice and after score 20  the AI will pass the dice


            int goal = Convert.ToInt32(lblGameformGoal.Text);

            if (goal <= 20)
            {
                if (RunningScore <= 5)
                {
                    timerForDiceAnimation.Start();
                }
                else if (RunningScore > 5)
                {
                    Pass();
                }
            }
            else if (goal > 20 && goal <= 50)
            {
                if (RunningScore <= 10)
                {
                    timerForDiceAnimation.Start();
                }
                else if (RunningScore >= 10)
                {
                    Pass();
                }
            }
            else if (goal > 50 && goal <= 100)
            {
                if (RunningScore <= 10 )
                {
                    timerForDiceAnimation.Start();
                }
                else if (RunningScore > 10 || RunningScore >= 20)
                {
                    Pass();
                }
            }
        }

        #endregion

        #region Application Exit button Event handler
        private void btnExit_Click(object sender, EventArgs e)

            //---------------------------------------------
            //This will exit the application
            //---------------------------------------------
        {
            Application.Exit();
        }

        #endregion
    }
}


