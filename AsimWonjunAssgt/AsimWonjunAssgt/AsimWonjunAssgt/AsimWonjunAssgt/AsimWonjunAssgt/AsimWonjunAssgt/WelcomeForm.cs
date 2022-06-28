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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        //Declearing Random dice here
        Random rToss = new Random();

        #region Toss button Event handler
        //--------------------------------------------------
        //In this event handler we worked on the toss button
        //This button will allow the user choose a player randomly to set the goal and start the game
        //Moreover, we did some property work manually here
        //--------------------------------------------------
        private void btnToss_Click(object sender, EventArgs e)
        {
            if (txtBxPlayer1Name.Text == "" || txtBxPlayer2Name.Text == "")
            {
                MessageBox.Show("Please enter player Names", "Attention");
            }
            {
                Toss();                                     //Recalling the function method
                btnToss.Text = "Try Again";                 //Changing button 
                lblTimerToss.Visible = true;

            }
        }
        #endregion

        #region Function method for the Toss
        //------------------------------------------
        //In this event handler we worked on the toss button
        //This button will allow the user choose a player randomly to set the goal and start the game
        //Moreover, we did some property work manually here
        //The reason we are doing that so we can use the same code somewhere else
        //------------------------------------------
        public void Toss()
        {
            string sPlayer1 = "", sPlayer2 = "";                                                                      //Declearing the players
            string[] stringPlayerName = { txtBxPlayer1Name.Text, txtBxPlayer2Name.Text };                    //Using Array style to store the input
            int sName = 0;

            //----------------------------------------------------------
            //Choose the name within the list
            //Using that so no confussion who will set goal and who will start the game
            //Tester: Please try a few times to see it's working smoothly as the name will appear randomly so it may repeat the same for a few times
            //----------------------------------------------------------        
            sName = rToss.Next(stringPlayerName.Length);                                                //For tossing we need the random value
            sPlayer1 = txtBxPlayer1Name.Text;                                                           //Using text box Player 1
            sPlayer2 = txtBxPlayer2Name.Text;                                                           //Using text box Player 1
            lblTossName.Text = stringPlayerName[sName].ToUpper();                                       // This will show who will set the goal and make it uppercase

            //----------------------------------------------------------
            //Using if statement
            //When the Toss btn will be pressed One player will set the goal and other player will start the game
            //This is for make everything clear between the players
            //----------------------------------------------------------

            if (stringPlayerName[sName] == sPlayer1)     //Condition for the winning label show up
            {

                lblTossName2.Visible = true;
                lblTossName2.Text = sPlayer2.ToUpper();
            }
            else
            {
                lblTossName2.Text = sPlayer1.ToUpper();
            }

            //Condition for the empty text boxes


            //------------------------------------------------------
            //Some work after the button pressed
            //Toss button Enable is false after one click so the user can't press twice 
            //------------------------------------------------------

            lblCongo.Visible = true;
            lblStartGame.Visible = true;
            lblTossName.Visible = true;
            lblTossName2.Visible = true;
            btnToss.Enabled = true;
            numericUpDownGoal.Enabled = true;
            lblGoal.Enabled = true;
        }
        #endregion

        #region Radio button Event handlers
        private void rdoBtnPlayWithAI_CheckedChanged(object sender, EventArgs e)
        {
            //-----------------------------------------
            //Setting properties when user press the AI
            //Player 2 AI textbox label is by default
            //-----------------------------------------

            lblPlayer1Name.Enabled = true;
            txtBxPlayer1Name.Enabled = true;
            lblCongo.Visible = false;
            lblStartGame.Visible = false;
            btnToss.Visible = false;
            txtBxPlayer2Name.Enabled = false;
            txtBxPlayer2Name.Text = "AI";
            lblTossName.Text = "";
            lblTossName2.Text = "";
            lblAIinstruction.Visible = true;
            lblMateInstruction.Visible = false;
            lblPlayer1AIinstruction.Visible = true;
            lblResult.Visible = false;

            //--------------------------
            //Reference: https://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
            numericUpDownGoal.ResetText();     //Reset the text to 0
            //---------------------------
        }

        private void rdoBtnPlayWithMate_CheckedChanged(object sender, EventArgs e)
        {
            //-----------------------------------------
            //Setting properties when user press the Play with mate
            //-----------------------------------------

            numericUpDownGoal.Enabled = false;
            lblGoal.Enabled = false;
            lblPlayer2Name.Enabled = true;
            txtBxPlayer2Name.Enabled = true;
            btnToss.Visible = true;
            txtBxPlayer1Name.Text = "";
            txtBxPlayer2Name.Text = "";
            lblAIinstruction.Visible = false;
            lblMateInstruction.Visible = true;
            lblPlayer1AIinstruction.Visible = false;
            lblAISetGoalInstruction.Visible = false;
            lblResult.Visible = true;

            //--------------------------
            //Reference: https://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
            numericUpDownGoal.ResetText();     //Reset the text to 0
            //---------------------------
        }
        #endregion

        #region Numeric Up and down 
        //------------------------------------
        //This code will set the goal
        //It's a Dacimal number
        //------------------------------------
        private void numericUpDownGoal_ValueChanged(object sender, EventArgs e)
        {
            //--------------------------------------------------
            //Numeric up and down
            //Set if statement to warn the user about the points
            //The user must need to write names in the text boxes to enable the numeric field
            //---------------------------------------------------

            numericUpDownGoal.Minimum = 0;              //Setting the minimum value
            numericUpDownGoal.Maximum = 100;            //Setting the maximum value; It's 200 because no restriction on the Minimum and Maximum for the value in assignment sheet

            //----------------------------------------------------
            //Using if Statement to set some condition
            //It's up to the user what they will do it's just show a messagebox
            //-----------------------------------------------------

            lblTimerToss.Visible = false;               //Devisible the label if the user uses the up and down

            if (numericUpDownGoal.Value < 50)           //If the goal is less than 50
            {
                MessageBox.Show("Your game may finish a bit too quick, Press LET'S PLAY to proceed or Change the Goal", "Acknowledgement");
            }

            else if (numericUpDownGoal.Value > 100)      //If the goal is more than 100
            {
                MessageBox.Show("Your game may run a bit too long, Press LET'S PLAY to proceed or Change the Goal", "Acknowledgement");
            }
        }

        private void numericUpDownGoal_Enter(object sender, EventArgs e)
        {
            //---------------------------------------
            //This piece of code will devisible the label if the user enters
            //---------------------------------------

            lblTimerToss.Visible = false;
        }
        #endregion

        #region Text box 1 as Player 1 Proprties
        //-------------------------------------
        //The user must need to write names in the text boxes to enable the numeric field
        //As only one player in AI we need to modify the property
        //--------------------------------------
        private void txtBxPlayer1Name_TextChanged(object sender, EventArgs e)
        {
            if (rdoBtnPlayWithAI.Checked)
            {
                numericUpDownGoal.Enabled = true;
                lblGoal.Enabled = true;
                lblGoal.Enabled = true;
                lblPlayer1AIinstruction.Visible = false;
                lblAISetGoalInstruction.Visible = true;
            }

            if (rdoBtnPlayWithMate.Checked)
            {
                btnToss.Enabled = true;
                lblAISetGoalInstruction.Visible = false;
            }

        }
        #endregion

        #region Let's Play button Event handler
        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------
            //New game form to play the game
            //Declear everything we need to pass data to the othe form so it can help the constructor to get and set the 
            //It will follow some other condition and give the user feedback to do and run the game
            //----------------------------------------------------

            frmGroan frmGroan = new frmGroan(txtBxPlayer1Name.Text, txtBxPlayer2Name.Text, (int)numericUpDownGoal.Value, rdoBtnPlayWithAI.Checked, rdoBtnPlayWithMate.Checked, lblTossName.Text, lblTossName2.Text);


            if (numericUpDownGoal.Value <= 0)                                               //Conditions to start the game
            {
                MessageBox.Show("Please set a goal to procced", "Attention");               //Messag box to show the user as instruction
            }
            else if (txtBxPlayer1Name.Text == "" || txtBxPlayer2Name.Text == "")
            {
                MessageBox.Show("Please enter player Name", "Attention");                   //Messag box to show the user as instruction
            }
            else if (rdoBtnPlayWithMate.Checked)
            {
                if (lblTossName.Text == "" || lblTossName2.Text == "")
                {
                    MessageBox.Show("Hmm..Something is wrong. " +                           //Messag box to show the user as instruction
                        "Please enter the player names and Toss again", "Attention");
                }
                else
                {
                    this.Hide();
                    frmGroan.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                frmGroan.ShowDialog();
                this.Close();
            }

        }
        #endregion

        #region Timer for label
        private void Time(int iMillisecs)
        {
            //Using timer to control a label

            Application.DoEvents();
            System.Threading.Thread.Sleep(iMillisecs);
        }
        #endregion
    }
}



