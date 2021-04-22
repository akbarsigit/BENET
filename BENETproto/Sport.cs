using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    public class Sport
    {
        public string sportName;
        public string sportType;
        public string SportName
        {
            get
            {
                return sportName;
            }
            set
            {
                sportName = value;
            }
        }
        public string SportType
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }
        }
        public string GetDrill()
        {
            return Drill;
        }
        public string GetPlace()
        {
            return Place;
        }
    }
}
