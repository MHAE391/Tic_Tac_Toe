using System;
namespace Tic_Tac_Toe
{
	public class GetGameStatus
	{
       public static void GetSize(ref int GameL)
        {
            Console.Write("Enter Game Board Length ' 3 Is The Minimum Length '  :  ");
            int a = 0;
            string Size = Console.ReadLine();
            foreach (var c in Size)
            {
                if (c >= '0' && c <= '9') a++;
                else break;
            }
            if (a != Size.Length || Size == "")
            {
                Console.WriteLine("Invalid Input");
                GetSize(ref GameL);
            }
            else
            {
                int GameBoardL = Convert.ToInt32(Size);
                if (GameBoardL < 3)
                {
                    Console.WriteLine("Invalid Size");
                    GetSize(ref GameL);
                }
                else GameL = GameBoardL;
            }
        }
        public static void GetSingleOrMulti(ref string SingleOrMulti)
        {
            Console.Write("Your Choise : ");
            string Temp = Console.ReadLine();

            if (Temp == "1" || Temp == "2")
            {
                SingleOrMulti = Temp;
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                GetSingleOrMulti(ref SingleOrMulti);

            }
        }
        public static void GetPlayer(ref string Player)
        {
            Console.Write("Enter Your Player : ");
            string Temp = Console.ReadLine();

            if (Temp == "X" || Temp == "O" || Temp == "o" || Temp == "x")
            {
                Player = Temp.ToUpper();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                GetPlayer(ref Player);

            }
        }
    }
}