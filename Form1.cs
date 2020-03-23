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

namespace IntegralMethods
{
    public partial class Form1 : Form
    {
        double a,b;
        int n, functionType;

        Integral integral;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = (double)nUpDa.Value;
            b = (double)nUpDb.Value;
            n = (int)nUpDn.Value;
            functionType = comboBox1.SelectedIndex;

            DrawBaseGraphic(a, b, 150, functionType);

                if (prRBtn.Checked)
                {
                integral = new Pramocutnic(a,b,n,functionType);
                }
                if (smpRBtn.Checked)
                {
                integral = new Simpson(a, b, n, functionType);
                }
                if (trapRbtn.Checked)
                {
                integral = new Trapetsia(a, b, n, functionType);
                }

            integral.DrawChart(chart1);
            resultLabel.Text = "РЕЗУЛЬТАТ: " + integral.CalcIntegral()+"      ЧАС: "+integral.time.ToString();
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


        void DrawBaseGraphic(double a, double b, int n, int funcType)
        {
            Integral integral = new Pramocutnic(a,b,n,funcType);
            double x = a;
            double h = (b - a)/ n;
            
            chart1.Series[1].Points.Clear();
            while ((int)x != b)
            {
                chart1.Series[1].Points.AddXY(x, integral.InFunction(x));
                x += h;
            }
        }
    }
}
