using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    public class Drill : Sport
    {
        public string drillName;
        public string drillType;
        public string drillPreferences;
        public string GetSportName()
        {
            return this.SportName;
        }
        public string GetPreferences()
        {
            return this.drillPreferences;
        }
        public string DrillName
        {
            get
            {
                return drillName;
            }
            set
            {
                drillName = value;
            }
        }
        public string DrillType
        {
            get
            {
                return drillType;
            }
            set
            {
                drillType = value;
            }
        }
        
    }
}
