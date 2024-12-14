using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWeatherFactory_Click(object sender, EventArgs e)
        {
            ICheckWeather icw = WeatherFactory.CreateWeatherInfo(ForecastAccuracy.FAIR);
            double temp = icw.GetCurrentTemperature("06484");
            MessageBox.Show("Current Temperature (less accurate) = " + temp.ToString());

            ICheckWeather icw2 = WeatherFactory.CreateWeatherInfo(ForecastAccuracy.GOOD);
            double temp2 = icw2.GetCurrentTemperature("06484");
            MessageBox.Show("Current Temperature (more accurate) = " + temp2.ToString());
        }

        private void btnComputeFactory_Click(object sender, EventArgs e)
        {
            ICompute ic = ComputeFactory.CreateComputeObject(CVersion.v1_1);
            double res1 = ic.ComputeCylinderVolume(4.5f, 3.7f);
            MessageBox.Show("Result from old version = " + res1.ToString());

            ICompute ic2 = ComputeFactory.CreateComputeObject(CVersion.v2_0);
            double res2 = ic2.ComputeCylinderVolume(4.5f, 3.7f);
            MessageBox.Show("Result from new version = " + res2.ToString());
        }

    }
}
