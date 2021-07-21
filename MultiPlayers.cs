using System;
using static Tic_Tac_Toe.Game;
namespace Tic_Tac_Toe
{
	public class  MultiPlayers: Game
	{
        public MultiPlayers(int Size) : base(Size)
        {
        }
            public void Play()
        {
            int Playes = 0;
            while (Playes < GameBoardL*GameBoardL) { 
                NewPlay('X');
                PrintGameBoard();
                if (GetWinner('X') != "No") {
                Console.WriteLine(GetWinner('X'));
                return;
                }
                Playes++;
                if (Playes == GameBoardL * GameBoardL) break;
                NewPlay('O');
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