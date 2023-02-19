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
            ClassesFunction();
            DrawFunction();
            
        }

        public void ClassesFunction()
        {
            /*
            Equation e = new QuadEquation(0, 20, 0);    //создаем объект класса "кв. уравнение"
            Integrator i1 = new Integrator(e); //создаем интегратор для этого уравнения
            double integrValue = i1.Integrate(10, 30); //вызываем интегрирование на интвервале 10;30

            Equation f = new Becuation(1);
            Integrator i2 = new Integrator(f);
            double integrValue2 = i2.Integrate(1, 2);
          */
            Equation g = new Cequation(1, 2);
            Integrator i3 = new Integrator(g);
            double integrValue3 = i3.Integrate(1, 2);  
            Timed.LMAO = integrValue3;
        }
        void DrawFunction(/*double x1, double x2, Equation equation*/)
        {

            Series mySeriesOfPoint = new Series("1st func");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            for (double x = 2; x <= 3; x++)
            {
                mySeriesOfPoint.Points.AddXY(x, x*x+20*x+0);
            }
            //Добавляем созданный набор точек в Chart
            chart1.Series.Add(mySeriesOfPoint);
            
        }
        public void button2_Click_1(object sender, EventArgs e)
        {
          
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