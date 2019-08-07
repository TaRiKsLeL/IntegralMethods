using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simpson__Method
{
    public partial class Form1 : Form
    {
        double h,a,b;
        int n, functionType;

        double x1, x2, x3, y1, y2, y3, valA, valB, valC;

        Object ob;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                a = (double)nUpDa.Value;
                b = (double)nUpDb.Value;
                n = (int)nUpDn.Value;
                functionType = comboBox1.SelectedIndex;

                getGraphic(a, b, 150, functionType);

                if (prRBtn.Checked)
                {
                    ob = new Pramocutnic();
                }
                if (smpRBtn.Checked)
                {
                    ob = new Simpson();
                }
                if (trapRbtn.Checked)
                {
                    ob = new Trapetsia();
                }

                printGraphic(ob, a, b, n, functionType);
            }
            else
            {
                MessageBox.Show("ВИБЕРІТЬ ФУНКЦІЮ", "!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainGraphCBox.Checked)
            {
                chart1.Series[1].Enabled = true;
            }
            else
            {
                chart1.Series[1].Enabled = false;
            }
        }

      

        static double Y(double p)
        {
            return Math.Pow(p, 2) * Math.Sin(10 * p) + Math.Pow(p, 4) - 10 * Math.Pow(p, 3) + 25 * Math.Pow(p, 2) - 5 * p + 1;// 1 / (1 + p * p*p*p*Math.Sin(p));
        }

        void getGraphic(double a, double b, int n, int funcType)
        {
            Pramocutnic pr = new Pramocutnic();
            double x = a;
            h = (double)(b - a)/ n;
            
            chart1.Series[1].Points.Clear();
            while ((int)x != b)
            {
                chart1.Series[1].Points.AddXY(x, pr.InFunction(x, funcType));
                x += h;
            }
           
            
        }

        public void parabola(int p)
        {
            chart1.Series[2].Points.Clear();

            h = (double)(b - a) / n;
            x1 = a + p * h;
            x2 = x1 + h;
            x3 = x1 + 2 * h;

            y1 = Y(x1);
            y2 = Y(x2);
            y3 = Y(x3);

            valA = (((x2 - x3) / (x2 - x1)) * (y2 - y1) + (y3 - y2))/((x2-x3)/(x2-x1))*(Math.Pow(x2,2)-Math.Pow(x1,2))+ (Math.Pow(x3, 2) - Math.Pow(x2, 2));
            valB = (y2 - y1 + valA * (Math.Pow(x1, 2) - Math.Pow(x2, 2))) / x2 - x1;
            valC = -valA * Math.Pow(x1, 2) - valB * x1 + y1;


            chart1.Series[2].Points.AddXY(x1, P(x1));
            chart1.Series[2].Points.AddXY(x2, P(x2));
            chart1.Series[2].Points.AddXY(x3, P(x3));

        }

        double P(double x)
        {
            return valA * Math.Pow(x, 2) + valB * x + valC;
        }

        public void printGraphic(Object obj, double a, double b, int n, int funcType)
        {
            double h = (b - a) / n;
            

            if (obj.GetType() == typeof(Pramocutnic))
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[2].Points.Clear();
                double tempY = 0;
                Pramocutnic p = (Pramocutnic)obj;

                for (int i = 0; i < n; i++)
                {
                    tempY = p.InFunction(a + h * (i + 0.5), funcType);
                    chart1.Series[2].Points.AddXY(a + h * i, 0);
                    chart1.Series[2].Points.AddXY(a+h*i,tempY);
                    chart1.Series[2].Points.AddXY(a + h*i+h,tempY);
                    if (i==n-1)
                    {
                        chart1.Series[2].Points.AddXY(a + h * i + h, 0);
                    }
                }
                resultLabel.Text = "INTEGRAL RESULT: " + p.CalcIntegral(a, b, n, funcType);
            }

            if (obj.GetType() == typeof(Simpson))
            {
                Simpson s = (Simpson)obj;
                double x = a;
                chart1.Series[2].Points.Clear();
                chart1.Series[0].Points.Clear();
                while ((int)x != b)
                {
                    chart1.Series[0].Points.AddXY(x, s.InFunction(x, funcType));
                    chart1.Series[0].Points.AddXY(x, 0);
                    chart1.Series[0].Points.AddXY(x, s.InFunction(x, funcType));

                    x += h;
                }
                chart1.Series[0].Points.AddXY(b, s.InFunction(x, funcType));
                chart1.Series[0].Points.AddXY(b, 0);
                chart1.Series[0].Points.AddXY(b, s.InFunction(x, funcType));
                resultLabel.Text = "INTEGRAL RESULT: " + s.CalcIntegral(a, b, n, funcType);
            }

            if (obj.GetType() == typeof(Trapetsia))
            {
                Trapetsia t = (Trapetsia)obj;
                double x = a;
                chart1.Series[2].Points.Clear();
                chart1.Series[0].Points.Clear();
                while ((int)x != b)
                {
                    chart1.Series[0].Points.AddXY(x, t.InFunction(x, funcType));
                    chart1.Series[0].Points.AddXY(x, 0);
                    chart1.Series[0].Points.AddXY(x, t.InFunction(x, funcType));

                    x += h;
                }
                chart1.Series[0].Points.AddXY(b, t.InFunction(x, funcType));
                chart1.Series[0].Points.AddXY(b, 0);
                chart1.Series[0].Points.AddXY(b, t.InFunction(x, funcType));

                resultLabel.Text = "INTEGRAL RESULT: " + t.CalcIntegral(a, b, n, funcType);
            }
        }

    }
}
