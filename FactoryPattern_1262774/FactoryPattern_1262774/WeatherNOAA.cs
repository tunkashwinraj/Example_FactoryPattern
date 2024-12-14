﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public class WeatherNOAA : ICheckWeather
    {
        public double GetCurrentTemperature(string zipcode)
        {
            double temp = 0;
            switch (zipcode)
            {
                case "99164": temp = 67; break;
                case "06484": temp = 57; break;
                case "06601": temp = 73; break;
                case "99352": temp = 81; break;
                default: temp = 50; break;
            }
            return temp;
        }

        public string CheckNextDayForecast(string city, string state)
        {
            string res = "";
            if ((city.ToUpper() == "AUSTIN") && (state.ToUpper() == "TX"))
            {
                res = "partly cloudy with a high of 78";
            }
            else if ((city.ToUpper() == "Topeka") && (state.ToUpper() == "KS"))
            {
                res = "thunder storms in the afternoon with a high of 71";
            }
            return res;
        }
    }

}
