using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class SampleClass:ISampleClass
    {
        private readonly INumerics _numerics;
        public SampleClass(INumerics numerics)
        {
            _numerics = numerics;
        }
        public async Task<double> GetAverage(int num1, int num2)
        {
            double result = 0;
            try
            {
                int sum = await _numerics.AddNumbers(num1, num2);
                int diff = await _numerics.SubtractNumbers(num1, num2);
                result = sum - diff;
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        
    }
}
