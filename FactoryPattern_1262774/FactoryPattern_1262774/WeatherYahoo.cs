using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public class WeatherYahoo : ICheckWeather
    {
        public double GetCurrentTemperature(string zipcode)
        {
            double temp = 0;
            switch (zipcode)
            {
                case "99164": temp = 66.3; break;
                case "06484": temp = 58.5; break;
                case "06601": temp = 72.73; break;
                case "99352": temp = 87.9; break;
                default: temp = 50; break;
            }
            return temp;
        }

        public string CheckNextDayForecast(string city, string state)
        {
            string res = "";
            if ((city.ToUpper() == "AUSTIN") && (state.ToUpper() == "TX"))
            {
                res = "mix of sun and clouds with a high of 78, winds 10-15 mph";
            }
            else if ((city.ToUpper() == "Topeka") && (state.ToUpper() == "KS"))
            {
                res = "thunder showers early with a high of 71, winds 5-10 mph";
            }
            return res;
        }
    }

}
