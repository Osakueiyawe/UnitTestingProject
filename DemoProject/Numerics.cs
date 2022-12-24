using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Numerics:INumerics
    {
        public async Task<int> AddNumbers(int a, int b)
        {
            return a + b;
        }

        public async Task<int> SubtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
