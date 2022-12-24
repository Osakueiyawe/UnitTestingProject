using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public interface ISampleClass
    {
        Task<double> GetAverage(int num1, int num2);
    }
}
