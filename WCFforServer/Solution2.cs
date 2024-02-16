using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFforServer
{
    public class TransferObject : ITransferObject
    {
        public double Calculate(double a, double b, double x, double y)
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                double term1 = Math.Pow(Math.Log(x), y);
                double term2 = Math.Pow(Math.Sin(a), b);
                sum += (term1 + term2) / (i * factorial(i));
            }
            return sum;
        }
        public double factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * factorial(n - 1);
            }
            else
            {
                throw new ArgumentException("Number must be non-negative");
            }
        }
    }
}
