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

namespace sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Add("Seno");
            chart1.Series.Add("Coseno");
            chart1.Series["Seno"].ChartType = SeriesChartType.Line;
            chart1.Series["Coseno"].ChartType = SeriesChartType.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Seno"].Points.Clear();
            chart1.Series["Coseno"].Points.Clear();
            for (double x = 0; x <= 200; x += (Math.PI / 100))
            {
                chart1.Series["Seno"].Points.AddXY(x, Math.Sin(x*int.Parse(textBox1.Text)));
                chart1.Series["Coseno"].Points.AddXY(x, Math.Cos(x * int.Parse(textBox1.Text)));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
