using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Equation e = new QuadEquation(0, 20, 0);    //создаем объект класса "кв. уравнение"
            //Integrator i1 = new Integrator(e); //создаем интегратор для этого уравнения
            //double integrValue = i1.Integrate(10, 30); //вызываем интегрирование на интвервале 10;30

            ////создаем интегратор для другого уравнения:
            //Integrator i2 = new Integrator(new QuadEquation(-3, 0, 2.3));
            //integrValue = i2.Integrate(-2, 100);    //вызываем ф-ю интегрирования

            //Моё 
            Equation beq = new Becuation(20);
            Integrator i3 = new Integrator(beq);
            double integrValue = i3.Integrate(10, 30);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.AliceBlue, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i,200);
            }
            graphics.DrawPolygon(pen, points);
        }
    }
}
