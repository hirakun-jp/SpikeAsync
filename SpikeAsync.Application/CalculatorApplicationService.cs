using SpikeAsync.Domain;

namespace SpikeAsync.Application
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
