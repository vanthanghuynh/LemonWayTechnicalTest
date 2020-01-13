using LemonWay.Service.Interfaces;

namespace LemonWay.Service
{
    public class FibonacciService : IFibonacciService
    {
        public int ComputeFibonacci(int n)
        {
            if (n < 1 || n > 100)
                return -1;

            if (n == 1 || n == 2)
                return 1;

            return ComputeFibonacci(n - 1) + ComputeFibonacci(n - 2);
        }
    }
}
