using System;
using static Tic_Tac_Toe.Game;
namespace Tic_Tac_Toe
{
     public class SinglePlayer: Game
    {
        public SinglePlayer(int Size) : base(Size)
        {
        }
        private void ConsolePlay(char Player)
        {
            Random Rnd = new Random();
            var Row = Rnd.Next(0, GameBoardL);
            var Coulmn = Rnd.Next(0, GameBoardL);
            if (ValidOrNot(Row, Coulmn) == false)
            {
                ConsolePlay(Player);
            }
            else
            {
                Board[Row, Coulmn] = Player;
                Console.WriteLine($"{Row}  {Coulmn}");
            }
        }
        public void Play(string Player) 
        {
           
                int Playes = 0;
                while (Playes < GameBoardL * GameBoardL)
                {
                    if(Player=="X")NewPlay('X');
                    else ConsolePlay('X');
                    PrintGameBoard();
                    if (GetWinner('X') != "No")
                    {
                        Console.WriteLine(GetWinner('X'));
                        return;
                    }
                    Playes++;
                    if (Playes == GameBoardL * GameBoardL) break;
                    if (Player == "O") NewPlay('O');
                    else ConsolePlay('O');
                    PrintGameBoard();
                    if (GetWinner('O') != "No")
                    {
                        Console.WriteLine(GetWinner('O'));
                        return;
                    }
                    Playes++;
                }
                Console.WriteLine("Drow Game");

        }

    }	
}