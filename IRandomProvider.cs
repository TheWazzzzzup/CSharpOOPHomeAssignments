using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brezerkers_Assignemnt
{
    internal interface IRandomProvider
    {
        public int MinNum { get ; set; }
        public int MaxNum { get; set; }

        void RandomRange(int min, int max)
        {
            if (min == max) return;
            else if (max > min)
            {
                MinNum = min;
                MaxNum = max;
            }
            else
            {
                MinNum = max;
                MaxNum = min;
            }
        }
        int Provider()
        {
            return Random.Shared.Next(MinNum, MaxNum);
        }
    }
}
