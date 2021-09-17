using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        protected char[] board;
        protected char userMarker;
        protected char aiMarker;
        protected char winner;
        protected char currentMarker;

        public TicTacToe(char playerToken, char aiMarker)
        {
            this.userMarker = playerToken;
            this.aiMarker = aiMarker;
            this.winner = '-';
            this.board = setBoard();
        }

        public static char[] setBoard()
        {
            char[] board = new char[9];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = '-';
            }
            return board;
        }

        public bool playTurn(int spot)
        {
            bool isValid = withinRange(spot) && !isSpotTaken(spot);
            if (isValid)
            {
                board[spot - 1] = currentMarker;
                currentMarker = (currentMarker == userMarker) ? aiMarker : userMarker;
            }
            return isValid;
        }

        // Check if spot is in range
        public bool withinRange(int number)
        {
            return number > 0 && number < board.Length + 1;
        }

        // Check if spot is taken
        public bool isSpotTaken(int number)
        {
            return board[number - 1] != '-';
        }

        public void printBoard()
        {
            // Board
            // | - | - | - |
            // -------------
            // | - | - | - |
            // -------------
            // | - | - | - |

            Console.WriteLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
                Console.WriteLine(" | " + board[i]);
            }
            Console.WriteLine();
        }

        public void printIndexBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
                Console.WriteLine(" | " + (i + 1));
            }
            Console.WriteLine();
        }

        public bool isThereAWinner()
        {
            bool diagonalsAndMiddles = rightDi() || leftDi() || middleRow() || secondCol() && board[4] != '-';
            bool topAndFirst = topRow() || firstCol() && board[0] != '-';
            bool bottomAndThird = bottomRow() || thirdCol() && board[8] != '-';
            if (diagonalsAndMiddles)
            {
                this.winner = board[4];
            } else if (topAndFirst)
            {
                this.winner = board[0];
            } else if (bottomAndThird)
            {
                this.winner = board[8];
            }
            return diagonalsAndMiddles || topAndFirst || bottomAndThird;
        }
        //win conditions
        public bool topRow()
        {
            return board[0] == board[1] && board[1] == board[2];
        }

        public bool middleRow()
        {
            return board[3] == board[4] && board[4] == board[5];
        }

        public bool bottomRow()
        {
            return board[6] == board[7] && board[7] == board[8];
        }

        public bool firstCol()
        {
            return board[0] == board[3] && board[3] == board[6];
        }

        public bool secondCol()
        {
            return board[1] == board[4] && board[4] == board[7];
        }

        public bool thirdCol()
        {
            return board[2] == board[5] && board[5] == board[8];
        }

        public bool rightDi()
        {
            return board[0] == board[4] && board[4] == board[8];
        }
        public bool leftDi()
        {
            return board[2] == board[4] && board[4] == board[6];
        }

        public bool isTheBoardFilled()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == '-')
                {
                    return false;
                }
                
            }
            return true;
        }

        public String gameOver()
        {
            bool didSomeoneWin = isThereAWinner();
            if (didSomeoneWin)
            {
                return "We have a winner! The winner is " + this.winner + "'s";
            } else if (isTheBoardFilled())
            {
                return "Draw: Game Over!";
            } else
            {
                return "Continue game...";
            }
        }
    }
 }

