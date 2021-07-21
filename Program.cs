using System;
using static Tic_Tac_Toe.GetGameStatus;
namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1- Single Player \n2- Multiple Players\n");
            string SingleOrMulti = "X";
            GetSingleOrMulti(ref SingleOrMulti);
            int GameBoardL=3;
            GetSize(ref GameBoardL);
            if (SingleOrMulti == "2")
            {
                MultiPlayers NewGame = new MultiPlayers(GameBoardL);
                NewGame.PrintGameBoard();
                NewGame.Play();
            }
            else
            {
                SinglePlayer NewGame = new SinglePlayer(GameBoardL);
                string Player = "X";
                GetPlayer(ref Player);
                NewGame.PrintGameBoard();
                NewGame.Play(Player);
            }
        }
    }
}
