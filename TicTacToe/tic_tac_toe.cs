/** =========================================================

David Gorden

Windows 10

Visual Studio 2015 community

CIS 169

Unit 7 tic tac toe

this program originally simulates games of tic tac toe and logs every victory or draws, i have also added the abillity to play tic tac toe against the computer as well

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class tic_tac_toe_form : Form
    {
        //0 stands for unused
        //1 stands for X
        //2 stands for O
        int winner = 0;
        int[,] tic_tac_toe = new int[,] { { 0, 0, 0 },    //row 1
                                          { 0, 0, 0 },    //row 2
                                          { 0, 0, 0 } };  //row 3
        int player_1_count = 0;
        int player_2_count = 0;
        int draw_count = 0;

        public tic_tac_toe_form()
        {
            InitializeComponent();
        }
        private void user_click(int rowChange, int columnChange)//when a the user presses a button this statement is run
        {
            int player = 1;//initializes player value
            if (tic_tac_toe[rowChange, columnChange] == 0)
            {
                button_finder(rowChange, columnChange, player);//changes clicked button
                tic_tac_toe[rowChange, columnChange] = player;//changes clicked row
                game_output.Text = "Good Luck!";//resets output text
                winner_calc(player);//checks if the player won
                if (winner == 0)
                {
                    ai_choice(2);//launches computer choice
                }
            }
            else
            {
                game_output.Text = "Please select a diffrent tile";//this is displayed if the player selects a pre selected tile
            }
        }
        private void winner_calc(int player)//DECIDES IF THE PLAYER HAS WON then changes the name 
        {
            //WINNING ROWS////////////////////////////////////////////////////////////////////////////////////////////////////
            if (tic_tac_toe[0,0] == player && tic_tac_toe[0,1] == player && tic_tac_toe[0,2] == player)                     //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            if (tic_tac_toe[1, 0] == player && tic_tac_toe[1, 1] == player && tic_tac_toe[1, 2] == player)                  //
            {                                                                                                               //    
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //    
            if (tic_tac_toe[2, 0] == player && tic_tac_toe[2, 1] == player && tic_tac_toe[2, 2] == player)                  //
            {                                                                                                               //    
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //        
            }                                                                                                               //
            ///WINNING ROWS///////////////////////////////////////////////////////////////////////////////////////////////////

            //WINNING COLUMNS/////////////////////////////////////////////////////////////////////////////////////////////////
            if (tic_tac_toe[0, 0] == player && tic_tac_toe[1, 0] == player && tic_tac_toe[2, 0] == player)                  //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            if (tic_tac_toe[0, 1] == player && tic_tac_toe[1, 1] == player && tic_tac_toe[2, 1] == player)                  //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            if (tic_tac_toe[0, 2] == player && tic_tac_toe[1, 2] == player && tic_tac_toe[2, 2] == player)                  //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            //WINNING COLUMNS/////////////////////////////////////////////////////////////////////////////////////////////////

            //WINNING DIAGNOLY////////////////////////////////////////////////////////////////////////////////////////////////
            if (tic_tac_toe[0, 0] == player && tic_tac_toe[1, 1] == player && tic_tac_toe[2, 2] == player)                  //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            if (tic_tac_toe[0, 2] == player && tic_tac_toe[1, 1] == player && tic_tac_toe[2, 0] == player)                  //
            {                                                                                                               //
                winner = 1;                                                                                                 //
                game_output.Text = "Player " + player + " has won the game!";                                               //
            }                                                                                                               //
            //WINNING DIAGNOLY////////////////////////////////////////////////////////////////////////////////////////////////

            if(winner == 1)//This decides who won the game and then adds a counter to the amount of wins the player has
            {
                if(player == 1)
                {
                    player_1_count++;
                    wins_count_player_1.Text = player_1_count.ToString();
                }
                if(player == 2)
                {
                    player_2_count++;
                    wins_count_player_2.Text = player_2_count.ToString();
                }
            }
        }
        private void ai_choice(int player)//this will be the AI's turn
        {
            int test_draw = 0;//used to count used tiles
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if(tic_tac_toe[i,j] != 0)//checks to see if tiles arent in use
                    {
                        test_draw++;//counter for used tiles
                    }
                }
            }
            if (test_draw != 9)// if tiles are not filled then it launches the ai's choice
            {
                int rowAi = ai_random();
                int columnAi = ai_random();
                Boolean exit_variable = false;// exit variable for when the ai completes a choice

                while (exit_variable == false)
                {
                    if (tic_tac_toe[rowAi, columnAi] != 0)//checks if the tile chosen is selected if so it picks again
                    {
                        rowAi = ai_random();
                        columnAi = ai_random();
                    }
                    else//when it choses correctly fills exit variable
                    {
                        exit_variable = true;
                    }
                }
                button_finder(rowAi, columnAi, player);//changes button
                tic_tac_toe[rowAi, columnAi] = player;//changes array
                winner_calc(player);// checks to see if the ai won
            }
            else if(test_draw == 9)//if the number is 9 then all tiles are filled and no winner was chosen 
            {
                player = 3;//changes variable so it doesnt count the player
                winner = 1;
                draw_count++;
                game_output.Text = "Its a draw";
                draw_count_value.Text = draw_count.ToString();
            }
        }
        private int ai_random()//generate random number 0-2
        {
            Random random = new Random();
            int random_number = random.Next(0, 3);
            return random_number;
        }
        private void button_finder(int row_selection, int column_selection, int player)//changes button based on row and column selection
        {
            String player_letter = "";//initializes letter variable

            if (player == 1)//player one has X
            {
                player_letter = "X";
            }
            else if (player == 2)//player 2 has O
            {
                player_letter = "O";
            }
            else if(player == 0)//clears all buttons for reset function
            {
                player_letter = " ";
            }

            if (row_selection == 0)//row 1
            {
                if (column_selection == 0)
                {
                    place_0_0.Text = player_letter;
                }
                if (column_selection == 1)
                {
                    place_0_1.Text = player_letter;
                }
                if (column_selection == 2)
                {
                    place_0_2.Text = player_letter;
                }
            }
            if (row_selection == 1)//row 2
            {
                if (column_selection == 0)
                {
                    place_1_0.Text = player_letter;
                }
                if (column_selection == 1)
                {
                    place_1_1.Text = player_letter;
                }
                if (column_selection == 2)
                {
                    place_1_2.Text = player_letter;
                }
            }
            if (row_selection == 2)//row 3
            {
                if (column_selection == 0)
                {
                    place_2_0.Text = player_letter;
                }
                if (column_selection == 1)
                {
                    place_2_1.Text = player_letter;
                }
                if (column_selection == 2)
                {
                    place_2_2.Text = player_letter;
                }
            }
        }
        private void reset_light()//RESETS ARRAY, BUTTONS resets for the end of each round
        {
            for(int row = 0; row <= 2; row++)//This resets the array to its original value
            {
                for(int column = 0; column <= 2; column++)
                {
                    tic_tac_toe[row, column] = 0;
                    button_finder(row, column, 0);
                }
            }
            winner = 0;
        }
        private void reset_master()//does a master reset that runs the light reset and then resets all other changed labels, and resets variables in use
        {
            reset_light();
            player_1_count = 0;
            player_2_count = 0;
            draw_count = 0;
            wins_count_player_1.Text = "0";
            wins_count_player_2.Text = "0";
            draw_count_value.Text = "0";
            game_output.Text = "Good Luck!";
        }

        private void place_0_0_Click(object sender, EventArgs e)
        {
            user_click(0,0);
        }
        private void place_0_1_Click(object sender, EventArgs e)
        {
            user_click(0, 1);
        }
        private void place_0_2_Click(object sender, EventArgs e)
        {
            user_click(0, 2);
        }
        private void place_1_0_Click(object sender, EventArgs e)
        {
            user_click(1, 0);
        }
        private void place_1_1_Click(object sender, EventArgs e)
        {
            user_click(1, 1);
        }
        private void place_1_2_Click(object sender, EventArgs e)
        {
            user_click(1, 2);
        }
        private void place_2_0_Click(object sender, EventArgs e)
        {
            user_click(2, 0);
        }
        private void place_2_1_Click(object sender, EventArgs e)
        {
            user_click(2, 1);

        }
        private void place_2_2_Click(object sender, EventArgs e)
        {
            user_click(2, 2);

        }
        private void reset_all_Click(object sender, EventArgs e)
        {
            reset_master();
        }
        private void random_winner_Click(object sender, EventArgs e)//this button randomly picks a winner
        {
            reset_light();//does a reset before to clear the board
            while (winner == 0)//runs as long as there is no winner
            {
                if (winner == 0)
                {
                    ai_choice(1);//uses ai to fill X's
                }
                if(winner == 0)
                {
                    ai_choice(2);//uses ai to fill O's
                }
            }
        }

        private void light_reset_Click(object sender, EventArgs e)
        {
            reset_light();
        }
    }
}
