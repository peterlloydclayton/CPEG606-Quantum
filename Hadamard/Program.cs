 using System;

namespace Hadamard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Please enter a matrix size: ");
                string size = Console.ReadLine();
                Hadamard hMatrix = new Hadamard(int.Parse(size));
                hMatrix.Run(hMatrix.HadamardMatrix);

                Console.Write("Enter \'y\' to continue: ");
                string go = Console.ReadLine();
                if (go.ToLower() == "y")
                    keepGoing = true;
                else keepGoing = false;
            }
        }
    }
}
