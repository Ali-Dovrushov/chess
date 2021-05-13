using System;

namespace ShaxmatiAlfavit
{
    class Program
    {
        public static char[] myArray = new char[5];

        static char NumberChecker()
        {
            char number;

            for (; ; )
            {
                string numberInString = Console.ReadLine();

                if (Char.TryParse(numberInString, out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Incorrect, please enter again: ");
                }
            }
        }

        public static char[] MyMetod()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == 0 || i == 3)
                {
                    Console.Write($"Enter №{ i + 1 } (Letters): ");
                }
                else if (i == 1 || i == 4)
                {
                    Console.Write($"Enter №{ i + 1 } (Numbers): ");
                }
                else
                {
                    Console.Write($"Enter №{ i + 1 } (Symbol '-'): ");
                }
                myArray[i] = NumberChecker();
                
            }
            return myArray;
        }

        public static void MyChecker()
        {
            //Проверка первой и второй буквы
            if ((myArray[0] != 'A' && myArray[0] != 'B' && myArray[0] != 'C' && myArray[0] != 'D' && myArray[0] != 'E' && myArray[0] != 'F' && myArray[0] != 'G' && myArray[0] != 'H')
                ||
                (myArray[3] != 'A' && myArray[3] != 'B' && myArray[3] != 'C' && myArray[3] != 'D' && myArray[3] != 'E' && myArray[3] != 'F' && myArray[3] != 'G' && myArray[3] != 'H'))
            {
                Console.WriteLine("Incorrect letters, letters can be only(A,B,C,D,E,F,G,H)");
                MyMetod();
                MyChecker();
            }
            else
            {
                Console.WriteLine($"Your hourse on { myArray[0] }{ myArray[1] } coordinat, you want to move on { myArray[3] }{ myArray[4] } coordinat");
            }

            //Проверка первой и второй цифры
            if ((myArray[1] == '0' || myArray[1] == '9') || (myArray[4] == '0' || myArray[4] == '9'))
            {
                Console.WriteLine("Incorrect numbers, numbers can be only from 1 till 8");
                MyMetod();
                MyChecker();
            }
            else
            {
                Console.Write("\t");
            }

            //Проверка символа между координатами '-'
            if (myArray[2] != '-')
            {
                Console.WriteLine("You forgot symbol '-'");
                MyMetod();
                MyChecker();
            }

            //Проверка на равенство
            if (myArray[0] == myArray[3] || myArray[1] == myArray[4])
            {
                Console.WriteLine("Letters or numbers can't be same");
                MyMetod();
                MyChecker();
            }
        }

        public static void Move()
        {
            if ((Math.Abs(myArray[1] - myArray[4]) == 2 && Math.Abs(myArray[0] - myArray[3]) == 1)
                ||
                (Math.Abs(myArray[0] - myArray[3]) == 1 && Math.Abs(myArray[1] - myArray[4]) == 2)) 
            {
                Console.WriteLine($"Yes horse can move from { myArray[0] }{ myArray[1] } to { myArray[3] }{ myArray[4] }");
            }
            else
            {
                Console.WriteLine($"Sorry but horse can't move from { myArray[0] }{ myArray[1] } to { myArray[3] }{ myArray[4] }.");
            }
        }

        static void Main(string[] args)
        {
            MyMetod();
            MyChecker();
            Move();
            Console.ReadKey();
        }
    }
}
