using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 12;

            Console.WriteLine(myInt);

            myInt *= myInt;
            myInt += 14;
            myInt -= 3;

            Console.WriteLine(myInt);


        }
    }
}
