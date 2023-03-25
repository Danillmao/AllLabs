using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR6WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox1.Text ="1";
            textBox2.Text = "10";
            textBox3.Text = "100";

        }
        void DrawFunction(Equation equation)
        {
            Integrator i1 = new Integrator(equation); //создаем интегратор для этого уравнения
            double integrValue = i1.Integrate(10, 30); //вызываем интегрирование на интвервале 10;30

            Series mySeriesOfPoint = new Series("1st func");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox2.Text);
            double N = int.Parse(textBox3.Text);
            double h = (x2 - x1) / N;
            for (double x = x1; x <= x2; x +=h)
            {
                double y = equation.GetValue(x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }
            chart1.Series.Add(mySeriesOfPoint);

        }
        void QuadDrawFunction()
        { 
            Equation e = new QuadEquation(0, 20, 0);    //создаем объект класса "кв. уравнение"
            DrawFunction(e);
        }
        void SecondDrawFunction()
        {
            Equation e = new Becuation(1);  //создаем объект класса "кв. уравнение"
            DrawFunction(e);
        }
        void ThirdDrawFunction()
        {
            Equation g = new Cequation(1, 2);
            DrawFunction(g);
        }
        public void button2_Click_1(object sender, EventArgs e)
        {
           
            chart1.Series.Clear();
            //comboBox1.SelectedIndex = 0;
            //chart1.Dispose();
            if (comboBox1.SelectedIndex == 0)
            {
                QuadDrawFunction();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SecondDrawFunction();
            } 
            else if (comboBox1.SelectedIndex == 2)
            {
                ThirdDrawFunction();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
/*
     label4.Text = Timed.LMAO.ToString();
               Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
 */