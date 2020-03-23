using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace IntegralMethods
{
    abstract class Integral
    {
        public double a, b, h;
        public int n, funcType;

        public double time;

        protected Stopwatch stopwatch;

        public Integral(double a, double b,int n, int funcType)
        {
            this.a = a;
            this.b = b;
            this.n = n;
            this.funcType = funcType;
            
            if(a<0 || b < 0)
            {
                h = ((b + 10) - (a + 10)) / n;
            }
            else
            {
                h = (b - a) / n;
            }

        }

        public abstract double CalcIntegral();

        public abstract void DrawChart(Chart chart);

        public double InFunction(double x) //Підінтегральні функції
        {
            if (funcType == 0)
            {
                return Math.Pow(x, 2) * Math.Sin(10 * x) + Math.Pow(x, 4) - 10 * Math.Pow(x, 3) + 25 * Math.Pow(x, 2) - 5 * x + 1;
            }
            if(funcType == 1)
            {
                return Math.Sin(x);
            }
            if (funcType == 2)
            {
                return Math.Sin(x)/x;
            }
            if (funcType == 3)
            {
                return 3;
            }
            return 0;
        }

        protected void SetupTimer()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

    }

    class Pramocutnic : Integral
    {
        public Pramocutnic(double a, double b, int n, int funcType) : base(a, b, n, funcType) { }


        public override double CalcIntegral()
        {
            SetupTimer();

            double result = 0;

            for(int i = 0; i < n; i++)
            {
                result += InFunction(a + h * (i + 0.5));
            }
            result *= h;

            time = stopwatch.Elapsed.TotalMilliseconds;

            return result;
        }

        public override void DrawChart(Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[2].Points.Clear();
            double tempY = 0;

            for (int i = 0; i < n; i++)
            {
                tempY = InFunction(a + h * (i + 0.5));
                chart.Series[2].Points.AddXY(a + h * i, 0);
                chart.Series[2].Points.AddXY(a + h * i, tempY);
                chart.Series[2].Points.AddXY(a + h * i + h, tempY);
                if (i == n - 1)
                {
                    chart.Series[2].Points.AddXY(a + h * i + h, 0);
                }
            }
        }
    }

    class Simpson : Integral
    {
        public Simpson(double a, double b, int n, int funcType) : base(a, b, n, funcType) { }

        public override double CalcIntegral()
        {
            SetupTimer();

           double s = 0;
            double x = a + h;

            while (x < b)
            {
                s += 4 * InFunction(x);
                x += h;
                s += 2 * InFunction(x);
                x += h;
            }
            s = h / 3 * (s + InFunction(a) - InFunction(b));

            time = stopwatch.Elapsed.TotalMilliseconds;

            return s;
        }

        public override void DrawChart(Chart chart)
        {
            double x = a;
            chart.Series[2].Points.Clear();
            chart.Series[0].Points.Clear();
            while ((int)x != b)
            {
                chart.Series[0].Points.AddXY(x, InFunction(x));
                chart.Series[0].Points.AddXY(x, 0);
                chart.Series[0].Points.AddXY(x, InFunction(x));

                x += h;
            }
            chart.Series[0].Points.AddXY(b, InFunction(x));
            chart.Series[0].Points.AddXY(b, 0);
            chart.Series[0].Points.AddXY(b, InFunction(x));
        }
    }

    class Trapetsia: Integral
    {
        public Trapetsia(double a, double b, int n, int funcType) : base(a, b, n, funcType) { }
        

        public override double CalcIntegral()
        {
            SetupTimer();

            double s = 0;
            double x=0;

            for(int i = 1; i < n; i++)
            {
                x = a + h * i;
                s+= 2 * InFunction(x);

            }
            s = h / 2 * (s+InFunction(a) + InFunction(b));

            time = stopwatch.Elapsed.TotalMilliseconds;

            return s;
        }

        public override void DrawChart(Chart chart)
        {
            double x = a;
            chart.Series[2].Points.Clear();
            chart.Series[0].Points.Clear();
            while ((int)x != b)
            {
                chart.Series[0].Points.AddXY(x, InFunction(x));
                chart.Series[0].Points.AddXY(x, 0);
                chart.Series[0].Points.AddXY(x, InFunction(x));

                x += h;
            }
            chart.Series[0].Points.AddXY(b, InFunction(x));
            chart.Series[0].Points.AddXY(b, 0);
            chart.Series[0].Points.AddXY(b, InFunction(x));
        }
    }
}
