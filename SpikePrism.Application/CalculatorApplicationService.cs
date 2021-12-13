using SpikePrism.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikePrism.Application
{
    public class CalculatorApplicationService
    {
        public Calculator NewCalculator()
        {
            return new Calculator();
        }

        public void Run(Calculator calculator)
        {
            calculator.Run();
        }

        public void Cancel(Calculator calculator)
        {
            calculator.Cancel();
        }
    }
}
