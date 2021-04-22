using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    public class WeatherTime
    {
        public string _Weather;
        public string _Time;

        public string Weather
        {
            get
            {
                return _Weather;
            }
            set
            {
                _Weather = value;
            }
        }
        public string Time
        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
            }
        }
    }
}
