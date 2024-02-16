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
        public double Calculate(double x, double y, double c)
        {
            double sum = 0;
            for (int i = 0; i < 30; i++)
            {
                sum += (Math.Pow(-1, i + 1) * (Math.Sin(x) * Math.Cos(x) + Math.Tan(c) / Factorial(i + 3)));
            }
            return sum;
        }
        public double Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else if (i > 0)
            {
                return i * Factorial(i - 1);
            }
            else
            {
                throw new ArgumentException("Number must be non-negative");
            }
        }
    }
}
