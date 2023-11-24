using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        public TicTacToe()
        {


        }

        public void play()
        {
            int moveCounter = 0;    
            Board gameBoard = new Board();
            Player playerX = new Player('X');
            Player playerO = new Player('O');

            Player currentPlayer = playerX; 
            bool play = true;           
            while (play)
            {
                gameBoard.printBoard();     
                Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);    
            getTurn:
                try
                {
                    int turn = currentPlayer.takeTurn();
                    if (!gameBoard.putMark(currentPlayer.Sign, turn))

                    {
                        xulySai();
                        goto getTurn;
                    }
                    else
                    {
                        gameBoard.clearBoard();
                        moveCounter++;
                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }

                        else if (moveCounter == 9)
                        {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                        }

                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                }
                catch (Exception ex)
                {
                    xulySai();
                    goto getTurn;
                }
            }
        }
        public void play2()
        {
            int moveCounter = 0;
            Board gameBoard = new Board();
            Player playerX = new Player('X');
            Robot playerO = new Robot('O');
            Player currentPlayer = playerX;
            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);
            getTurn:
                try
                {


                    int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn();
                    char c = (moveCounter % 2 == 0) ? playerX.Sign : playerO.Sign;

                    if (!gameBoard.putMark(c, turn))
                    {
                        xulySai();
                        goto getTurn;
                    }
                    else
                    {
                        gameBoard.clearBoard();
                        moveCounter++;
                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }

                        else if (moveCounter == 9)
                        {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                        }

                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                }
                catch (Exception ex)
                {
                    xulySai();
                    goto getTurn;
                }
            }
        }
        public void play3()
        {
            int moveCounter = 0;
            Board gameBoard = new Board();
            Robot playerX = new Robot('X');
            Robot playerO = new Robot('O');
            Player currentPlayer = playerX;
            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);    //chờ ng dùng nhập dữ liệu
            getTurn:
                try
                {


                    int turn = (moveCounter % 2 == 0) ? playerX.takeTurn() : playerO.takeTurn();
                    char c = (moveCounter % 2 == 0) ? playerX.Sign : playerO.Sign;

                    if (!gameBoard.putMark(c, turn))
                    {
                        playerX.removeChoose(turn);
                        xulySai();
                        goto getTurn;
                    }
                    else
                    {
                        playerO.removeChoose(turn);
                        playerX.removeChoose(turn);
                        gameBoard.clearBoard();
                        moveCounter++;  //tối đa lên tới 9
                        //kiểm tra đã thắng chưa
                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }
                        //kiểm tra có hòa chưa
                        else if (moveCounter == 9)
                        {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                        }
                        //ko thắng , ko hòa -> đi tiếp
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                }
                catch (Exception ex)
                {
                    xulySai();
                    goto getTurn;
                }
            }
        }
        private void xulySai()
        {
            Console.WriteLine("Invalid input. Please enter number between 1- 9!");
        }
    }
}
