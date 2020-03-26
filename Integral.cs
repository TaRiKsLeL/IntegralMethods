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
        protected double a, b, h, area, x;
        protected int n, funcType;

        protected List<double> funcsResults;

        public double Time { get; protected set; }

        protected Stopwatch stopwatch;

        public Integral(double a, double b,int n, int funcType)
        {
            this.a = a;
            this.b = b;
            this.n = n;
            this.funcType = funcType;

            funcsResults = new List<double>();

            if (a<0 || b < 0)
            {
                h = ((b + 10) - (a + 10)) / n;
            }
            else
            {
                h = (b - a) / n;
            }

        }

        public abstract void FillList();
        public abstract double CalcIntegral();

        public abstract void DrawChart(Chart chart);

        public double Func(double x) //Підінтегральні функції
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

        protected double GetResultsListSum()
        {
            double sum = 0;
            foreach (double d in funcsResults)
            {
                sum += d;
            }
            return sum;
        }

    }

    class Pramocutnic : Integral
    {
        public Pramocutnic(double a, double b, int n, int funcType) : base(a, b, n, funcType) { }

        public override void FillList()
        {
            for(int i = 0; i < n; i++)
            {
                funcsResults.Add(Func(a + h * (i + 0.5)));
            }
        }

        public override double CalcIntegral()
        {
            SetupTimer();
            FillList();
            area = GetResultsListSum()*h;
            
            Time = stopwatch.Elapsed.TotalMilliseconds;
            return area;
        }

        public override void DrawChart(Chart chart)
        {
            chart.Series[0].Points.Clear();
            chart.Series[2].Points.Clear();
            double tempY = 0;

            for (int i = 0; i < n; i++)
            {
                tempY = Func(a + h * (i + 0.5));
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
        public Simpson(double a, double b, int n, int funcType) : base(a, b, n, funcType) {}

        public override void FillList()
        {
            x = a + h;

            while (x < b) {
                funcsResults.Add(4 * Func(x));
                x += h;
                funcsResults.Add(2 * Func(x));
                x += h;
            }

            funcsResults.Add(Func(a));
            funcsResults.Add(-Func(b));

        }

        public override double CalcIntegral()
        {
            SetupTimer();
            FillList();
            area = h / 3 * GetResultsListSum();
            Time = stopwatch.Elapsed.TotalMilliseconds;
            return area;
        }

        public override void DrawChart(Chart chart)
        {
            double x = a;
            chart.Series[2].Points.Clear();
            chart.Series[0].Points.Clear();
            while ((int)x != b)
            {
                chart.Series[0].Points.AddXY(x, Func(x));
                chart.Series[0].Points.AddXY(x, 0);
                chart.Series[0].Points.AddXY(x, Func(x));

                x += h;
            }
            chart.Series[0].Points.AddXY(b, Func(x));
            chart.Series[0].Points.AddXY(b, 0);
            chart.Series[0].Points.AddXY(b, Func(x));
        }
    }

    class Trapetsia: Integral
    {
        public Trapetsia(double a, double b, int n, int funcType) : base(a, b, n, funcType) { }

        public override void FillList()
        {
            for (int i = 1; i < n; i++)
            {
                x = a + h * i;
                funcsResults.Add(2 * Func(x));
            }

            funcsResults.Add(Func(a));
            funcsResults.Add(Func(b));
        }
        public override double CalcIntegral()
        {
            SetupTimer();
            FillList();
            area = h / 2 * GetResultsListSum();

            Time = stopwatch.Elapsed.TotalMilliseconds;

            return area;
        }

        public override void DrawChart(Chart chart)
        {
            double x = a;
            chart.Series[2].Points.Clear();
            chart.Series[0].Points.Clear();
            while ((int)x != b)
            {
                chart.Series[0].Points.AddXY(x, Func(x));
                chart.Series[0].Points.AddXY(x, 0);
                chart.Series[0].Points.AddXY(x, Func(x));

                x += h;
            }
            chart.Series[0].Points.AddXY(b, Func(x));
            chart.Series[0].Points.AddXY(b, 0);
            chart.Series[0].Points.AddXY(b, Func(x));
        }
    }
}
