namespace CS311_Project2_ABE
{
    public partial class Form1 : Form
    {
        double bankBalance = 100;
        int point = 0; //initializes Point to 0
        bool gameInProgress = false; //changes to True when the Point is set
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (!gameInProgress)
            {
                if (double.TryParse(txtBet.Text, out double bet))
                {
                    if (bet > 0 && bet <= bankBalance)
                    {
                        int dice1 = RollDie();
                        int dice2 = RollDie();
                        int sum = dice1 + dice2;

                        lblDice1.Text = dice1.ToString();
                        lblDice2.Text = dice2.ToString();

                        if (sum == 7 || sum == 11)
                        {
                            lblOutcome.Text = "You win!";
                            bankBalance += bet;
                        }//end rolling a 7 or 11 on first roll

                        else if (sum == 2 || sum == 3 || sum == 12)
                        {
                            lblOutcome.Text = "You lose!";
                            bankBalance -= bet;
                        }//end rolling a 2, 3, or 12 on first roll

                        else
                        {
                            lblOutcome.Text = "Point is " + sum;
                            point = sum;
                            gameInProgress = true; //starts the effort to roll the point
                        }//end rolling something else, the Point set, and toggles "gameInProgress" on; jump to code below.

                        lblBankBalance.Text = bankBalance.ToString("C"); //shows bank balance

                    }//end if/else statements tied to first dice roll

                    else
                    {
                        MessageBox.Show("Invalid bet! Check your balance and try again.");
                    }//end else for if balance insufficient

                }//end if statement validating bet

                else
                {
                    MessageBox.Show("Invalid number. Try again.");
                }//end else in response to invalid number for bet

            }//end if checking if a game is in progress after Point set

            else //proceeds when a game is in progress upon a Point being rolled
            {
                if (double.TryParse(txtBet.Text, out double bet))
                {
                    int dice1 = RollDie();
                    int dice2 = RollDie();
                    int sum = dice1 + dice2;

                    lblDice1.Text = dice1.ToString();
                    lblDice2.Text = dice2.ToString();

                    if (sum == point)
                    {
                        lblOutcome.Text = "You win!";
                        bankBalance += bet;
                        gameInProgress = false; //ends the game
                    }//end rolling the Point and winning

                    else if (sum == 7)
                    {
                        lblOutcome.Text = "You lose!";
                        bankBalance -= bet;
                        gameInProgress = false; // ends the game
                    }//end rolling a 7 instead of Point, and losing
                }//end of the Point-rolling part of game
            }//end else that proceeds once Point is set
        }//end btnRoll_Click

        private int RollDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }//end RollDie

    }//end form
}//end namespace