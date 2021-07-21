using System;
namespace Tic_Tac_Toe
{
    public class Game
    {
        protected char[,] Board;
        protected int GameBoardL;
        protected Game(int Size)
        {
            this.GameBoardL = Size;
            this.Board = new char[Size, Size];

        }
        public void PrintGameBoard()
        {
            for (int i = 0; i < GameBoardL; i++)
            {
                for (int y = 0; y < GameBoardL; y++)
                {
                    if (Board[i, y] != 'X' && Board[i, y] != 'O') Console.Write($"|   ");
                    else Console.Write($"| {Board[i, y]} ");
                }
                Console.WriteLine("|");
            }
        }
        protected string GetWinner(char Player)
        {
            int x = 0;
            for (int row = 0; row < GameBoardL; row++)
            {
                x = 0;
                for (int coulmn = 0; coulmn < GameBoardL; coulmn++)
                {
                    if (Board[row, coulmn] == Player) x++;
                }
                if (x == GameBoardL) return (Player + " Is the Winner");
            }
            x = 0;
            for (int Coulmn = 0; Coulmn < GameBoardL; Coulmn++)
            {
                x = 0;
                for (int Row = 0; Row < GameBoardL; Row++)
                {
                    if (Board[Row, Coulmn] == Player) x++;
                }
                if (x == GameBoardL) return (Player + " Is the Winner");
            }
            x = 0;
            for (int i = 0; i < GameBoardL; i++)
            {
                if (Board[i, i] == Player) x++;
            }
            if (x == GameBoardL) return (Player + " Is the Winner");
            x = 0;
            int y = GameBoardL - 1;
            for (int i = 0; i < GameBoardL; i++, y--)
            {
                if (Board[i, y] == Player) x++;
            }
            if (x == GameBoardL) return (Player + " Is the Winner");
            return "No";
        }
        protected bool ValidOrNot(int R, int C)
        {
            if (R < 0 || R >= GameBoardL || C < 0 || C >= GameBoardL) return false;
            if (Board[R, C] == 'X' || Board[R, C] == 'O') return false;
            return true;
        }
       protected void NewPlay(char Player)
        {
            Console.WriteLine($"Enter {Player} Position : ");
            string Pos = Console.ReadLine();
            string[] Positions = Pos.Split(',');
            if (Positions.Length != 2)
            {
                Console.WriteLine("Invalid Input");
                NewPlay(Player);
            }
            int a = 0, b = 0;
            foreach (var iterator in Positions[0])
            {
                if (iterator >= '0' && iterator <= '9') a++;
                else break;
            }
            foreach (var iterator in Positions[1])
            {
                if (iterator >= '0' && iterator <= '9') b++;
                else break;
            }
            if (a != Positions[0].Length || b != Positions[1].Length
                || Positions[0] == "" || Positions[1] == "")
            {
                Console.WriteLine("Invalid Input");
                NewPlay(Player);
            }
            else
            {
                int Row = Convert.ToInt32(Positions[0]);
                int Coulmn = Convert.ToInt32(Positions[1]);
                if (ValidOrNot(Row, Coulmn) == false)
                {
                    Console.WriteLine("Invalid Input");
                    NewPlay(Player);
                }
                else { Board[Row, Coulmn] = Player; }
            }
        }
    }
}