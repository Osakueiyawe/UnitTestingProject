using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public interface INumerics
    {
        Task<int> AddNumbers(int a, int b);
        Task<int> SubtractNumbers(int a, int b);
    }
}
