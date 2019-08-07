using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpson__Method
{
    abstract class Integral
    {
        public abstract double CalcIntegral(double a, double b, int n, int funcType);

        public double InFunction(double x, int funcType) //Підінтегральні функції
        {
            if (funcType == 0)
            {
                return Math.Pow(x, 2) * Math.Sin(10 * x) + Math.Pow(x, 4) - 10 * Math.Pow(x, 3) + 25 * Math.Pow(x, 2) - 5 * x + 1;
            }
            if(funcType == 1)
            {
                return Math.Sin(x);
            }
            if(funcType == 2)
            {
                return 3;
            }
            return 0;
        }
    }

    class Pramocutnic : Integral
    {
        double h;
        public override double CalcIntegral(double a, double b, int n, int funcType)
        {
            double result = 0;
            h = (b - a) / n;

            for(int i = 0; i < n; i++)
            {
                result += InFunction(a + h * (i + 0.5),funcType);
            }
            result *= h;
            return result;
        }
        
    }

    class Simpson : Integral
    {
        double h;
        public override double CalcIntegral(double a, double b, int n, int funcType)
        {
           double s = 0;
            h = (b - a) / n;
            double x = a + h;

            while (x < b)
            {
                s += 4 * InFunction(x,funcType);
                x += h;
                s += 2 * InFunction(x,funcType);
                x += h;
            }
            s = h / 3 * (s + InFunction(a,funcType) - InFunction(b,funcType));

            return s;
        }
    }

    class Trapetsia: Integral
    {
        public override double CalcIntegral(double a, double b, int n, int funcType)
        {
            double s = 0;
            double h = (b - a) / n;
            double x=0;

            for(int i = 1; i < n; i++)
            {
                x = a + h * i;
                s+= 2 * InFunction(x, funcType);

            }
            s = h / 2 * (s+InFunction(a, funcType) + InFunction(b, funcType));

            return s;
        }
    }
}
