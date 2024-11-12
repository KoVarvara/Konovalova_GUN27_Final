using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Items
{
    public struct Dice
    {
        private int _min;
        private int _max;
        private readonly int _number {  get; }

        public Dice(int min, int max)
        {

          
            _min = min;
            _max = max;
            var rand = new Random();
            _number = rand.Next(_min, _max);

            //try
            //{
            //    int n = Int32.Parse(Console.ReadLine());
            //}
            //catch (WrongDiceNumberException exception) when (n > _max)
            //{
            //    Console.WriteLine("User number");
            //}
        }

    }
}
