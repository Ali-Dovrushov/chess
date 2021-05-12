using System;

namespace ShaxmatiAlfavit
{
    class Program
    {
        public static char[] myArray = new char[5];
        public static char[] MyMetod()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter №{i + 1}: ");
                myArray[i] = Convert.ToChar(Console.ReadLine());
            }
            return myArray;
        }

        public static void MyChecker()
        {
            Console.WriteLine($"{myArray[0]}{myArray[1]}{myArray[2]}{myArray[3]}{myArray[4]}");
            if (myArray[0] != 'A'
                && myArray[0] != 'B'
                && myArray[0] != 'C'
                && myArray[0] != 'D'
                && myArray[0] != 'E'
                && myArray[0] != 'F'
                && myArray[0] != 'G'
                && myArray[0] != 'H'
                ||
                myArray[3] != 'A'
                && myArray[3] != 'B'
                && myArray[3] != 'C'
                && myArray[3] != 'D'
                && myArray[3] != 'E'
                && myArray[3] != 'F'
                && myArray[3] != 'G'
                && myArray[3] != 'H')
            {
                Console.WriteLine("Error");
            }
            else if(myArray[2] != '-')
            {
                Console.WriteLine("You forgot symbol '-'");
            }
            else
            {
                Console.WriteLine("Yes");
            }

            if (myArray[0] == myArray[3] || myArray[1] == myArray[4])
            {
                Console.WriteLine("Letters or numbers can't be same");
            }
        }

        public static void Move()
        {
            if (Math.Abs(myArray[1] - myArray[4]) == 2 || Math.Abs(myArray[1] - myArray[4]) == 1)
            {
                Console.WriteLine($"Horse {myArray[0]}{myArray[1]} move to {myArray[3]}{myArray[4]}");
            }
            else
            {
                Console.WriteLine("Horse can't move this coordinat");
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
