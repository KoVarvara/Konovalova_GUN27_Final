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
            var rand = new Random();
            _min = min;
            _max = max;
            _number = rand.Next(_min, _max);
        }

    }
}
