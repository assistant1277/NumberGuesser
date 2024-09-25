using NumberGuesser.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;

            Guess.RunNumberGuesser(min, max);
            Console.ReadKey();
        }
    }
}
